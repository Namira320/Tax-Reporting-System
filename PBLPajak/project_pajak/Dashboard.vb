Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms

Public Class Dashboard
    Private ReadOnly _currentUserId As Integer = 1
    Private _latestNotifications As List(Of NotificationItem) = New List(Of NotificationItem)()

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure DB Schema is correct immediately
        ModuleWajibPajak.CheckAndCreateProfileTables()

        ' Inisialisasi data
        LoadDashboardData()
        DrawCharts()

        ' Load User Name
        Dim nama As String = "Wajib Pajak"
        Try
            If Not String.IsNullOrEmpty(Module1.CurrentUserNIK) Then
                Dim data = ModuleWajibPajak.LoadWajibPajakByNIK(Module1.CurrentUserNIK)
                If data IsNot Nothing AndAlso data.ContainsKey("NamaWajibPajak") Then
                    nama = data("NamaWajibPajak").ToString()
                End If
            End If
        Catch ex As Exception
        End Try
        LabelTitle.Text = "Selamat Datang, " & nama
    End Sub

    Private Sub LoadDashboardData()
        ' Setup DataGridView
        DataGridViewRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewRiwayat.AllowUserToAddRows = False
        DataGridViewRiwayat.AllowUserToDeleteRows = False
        DataGridViewRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewRiwayat.MultiSelect = False
        DataGridViewRiwayat.ReadOnly = True
        DataGridViewRiwayat.RowHeadersVisible = False
        DataGridViewRiwayat.DefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
        DataGridViewRiwayat.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        DataGridViewRiwayat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252)
        DataGridViewRiwayat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252)

        ' Load data real dari database
        If Not String.IsNullOrEmpty(Module1.CurrentUserNIK) Then
            LoadRiwayatSPTFromDB()
            LoadCardDataFromDB()
        Else
            LabelPajakTerutangValue.Text = "Rp 0"
            LabelPajakDipotongValue.Text = "Rp 0"
            LabelStatusValue.Text = "Belum Login"
        End If
    End Sub

    Private Sub LoadRiwayatSPTFromDB()
        Try
            Using conn = GetConnection()
                If OpenConnection(conn) Then
                    Dim query = "SELECT TOP 5 TanggalInput, StatusBayar, PPhKurangLebih FROM tbl_SPT WHERE NIK = @NIK ORDER BY TanggalInput DESC"
                    Using cmd As New SqlClient.SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)
                        Using reader = cmd.ExecuteReader()
                            DataGridViewRiwayat.Rows.Clear()
                            While reader.Read()
                                Dim tanggal = If(Not IsDBNull(reader("TanggalInput")), Convert.ToDateTime(reader("TanggalInput")).ToString("dd MMM yyyy"), "-")
                                Dim keterangan = "Pelaporan SPT"
                                Dim jumlahVal = If(IsDBNull(reader("PPhKurangLebih")), 0D, Convert.ToDecimal(reader("PPhKurangLebih")))
                                Dim jumlah = "Rp " & FormatAngka(jumlahVal)
                                Dim status = If(Not IsDBNull(reader("StatusBayar")), reader("StatusBayar").ToString(), "-")
                                DataGridViewRiwayat.Rows.Add(tanggal, keterangan, jumlah, status)
                            End While
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Ignore error for dashboard view
        End Try
    End Sub

    Private Sub LoadCardDataFromDB()
        Try
            Using conn = GetConnection()
                If OpenConnection(conn) Then
                    ' Cari data SPT terakhir
                    Dim query = "SELECT TOP 1 PPhTerutang, PPhDipotong, StatusBayar, PPhKurangLebih FROM tbl_SPT WHERE NIK = @NIK ORDER BY TanggalInput DESC"
                    Using cmd As New SqlClient.SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)
                        Using reader = cmd.ExecuteReader()
                            If reader.Read() Then
                                LabelPajakTerutangValue.Text = "Rp " & FormatAngka(If(IsDBNull(reader("PPhTerutang")), 0D, Convert.ToDecimal(reader("PPhTerutang"))))
                                LabelPajakDipotongValue.Text = "Rp " & FormatAngka(If(IsDBNull(reader("PPhDipotong")), 0D, Convert.ToDecimal(reader("PPhDipotong"))))
                                Dim status = If(Not IsDBNull(reader("StatusBayar")), reader("StatusBayar").ToString(), "Nihil")
                                Dim kurangLebih = If(IsDBNull(reader("PPhKurangLebih")), 0D, Convert.ToDecimal(reader("PPhKurangLebih")))

                                LabelStatusValue.Text = status
                                If status.ToLower().Contains("kurang bayar") Then
                                    LabelStatusValue.ForeColor = Color.Red
                                ElseIf status.ToLower().Contains("lebih bayar") Then
                                    LabelStatusValue.ForeColor = Color.FromArgb(41, 128, 185) ' Same as Dipotong chart (Light Blue/Primary Blue)
                                Else
                                    LabelStatusValue.ForeColor = Color.Green
                                End If

                                If kurangLebih <> 0 Then
                                    LabelStatusValue.Text &= vbCrLf & "Rp " & FormatAngka(Math.Abs(kurangLebih))
                                End If
                            Else
                                ' Jika belum lapor SPT, estimasi dari data profil jika ada
                                reader.Close()
                                CalculateEstimasiPajak(conn)
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            LabelStatusValue.Text = "Error Load"
        End Try
    End Sub

    Private Sub CalculateEstimasiPajak(conn As SqlClient.SqlConnection)
        Try
            Dim query = "SELECT PenghasilanPerBulan, StatusPTKP FROM tbl_WajibPajak WHERE NIK = @NIK"
            Using cmd As New SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim penghasilan = If(IsDBNull(reader("PenghasilanPerBulan")), 0D, Convert.ToDecimal(reader("PenghasilanPerBulan"))) * 12
                        Dim status = If(Not IsDBNull(reader("StatusPTKP")), reader("StatusPTKP").ToString(), "TK/0")
                        LabelPajakTerutangValue.Text = "Rp Estimasi"
                        LabelPajakDipotongValue.Text = "Rp 0"
                        LabelStatusValue.Text = "Belum Lapor SPT"
                    End If
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DrawCharts()
        ' Draw bar chart untuk perbandingan
        AddHandler PanelChartPerbandingan.Paint, AddressOf PanelChartPerbandingan_Paint
        PanelChartPerbandingan.Invalidate()

        ' Draw line chart untuk tren
        AddHandler PanelChartTren.Paint, AddressOf PanelChartTren_Paint
        PanelChartTren.Invalidate()
    End Sub

    Private Sub PanelChartPerbandingan_Paint(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.Clear(panel.BackColor)

        ' Data untuk bar chart
        Dim terutang As Decimal = 0
        Dim dipotong As Decimal = 0

        Try
            ' Parse value from label (removing "Rp " and ".")
            Dim terutangStr As String = LabelPajakTerutangValue.Text.Replace("Rp ", "").Replace(".", "")
            Dim dipotongStr As String = LabelPajakDipotongValue.Text.Replace("Rp ", "").Replace(".", "")

            Decimal.TryParse(terutangStr, terutang)
            Decimal.TryParse(dipotongStr, dipotong)
        Catch
            ' Fallback if parsing fails
            terutang = 0
            dipotong = 0
        End Try

        Dim maxValue As Decimal = Math.Max(terutang, dipotong) * 1.2
        If maxValue = 0 Then maxValue = 1000000 ' Default scale


        Dim panelWidth As Integer = panel.Width - 80
        Dim panelHeight As Integer = panel.Height - 60
        Dim barWidth As Integer = 100
        Dim spacing As Integer = 60
        Dim startX As Integer = 40
        Dim startY As Integer = 20

        ' Draw grid lines
        Using pen As New Pen(Color.FromArgb(230, 233, 240), 1)
            For i As Integer = 0 To 4
                Dim y As Integer = startY + CInt((i / 4.0) * panelHeight)
                g.DrawLine(pen, startX, y, startX + panelWidth, y)
            Next
        End Using

        ' Draw bars
        Dim x1 As Integer = startX + 20
        Dim height1 As Integer = CInt((terutang / maxValue) * panelHeight)
        Dim y1 As Integer = startY + panelHeight - height1

        Dim x2 As Integer = x1 + barWidth + spacing
        Dim height2 As Integer = CInt((dipotong / maxValue) * panelHeight)
        Dim y2 As Integer = startY + panelHeight - height2

        ' Bar 1 - Pajak Terutang (Biru)
        Using brush As New SolidBrush(Color.FromArgb(41, 128, 185))
            g.FillRectangle(brush, x1, y1, barWidth, height1)
        End Using

        ' Bar 2 - Pajak Dipotong (Hijau)
        Using brush As New SolidBrush(Color.FromArgb(34, 197, 94))
            g.FillRectangle(brush, x2, y2, barWidth, height2)
        End Using

        ' Value labels on bars
        Using font As New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
            Using brush As New SolidBrush(Color.White)
                Dim text1 As String = FormatAngka(terutang)
                ' If too long, abbreviate to Millions
                If terutang >= 1000000 Then text1 = (terutang / 1000000D).ToString("0.#") & "M"
                Dim textSize1 As SizeF = g.MeasureString(text1, font)
                g.DrawString(text1, font, brush, x1 + (barWidth - textSize1.Width) / 2, y1 + 5)

                Dim textSize1_2 As SizeF = g.MeasureString(text1, font)
                g.DrawString(text1, font, brush, x1 + (barWidth - textSize1_2.Width) / 2, y1 + 5)

                Dim text2 As String = FormatAngka(dipotong)
                If dipotong >= 1000000 Then text2 = (dipotong / 1000000D).ToString("0.#") & "M"
                Dim textSize2 As SizeF = g.MeasureString(text2, font)
                g.DrawString(text2, font, brush, x2 + (barWidth - textSize2.Width) / 2, y2 + 5)
            End Using
        End Using

        ' Category labels
        Using font As New Font("Segoe UI", 9.0!, FontStyle.Regular)
            Using brush As New SolidBrush(Color.FromArgb(105, 112, 125))
                Dim labelY As Integer = startY + panelHeight + 10
                g.DrawString("Terutang", font, brush, x1 + (barWidth - g.MeasureString("Terutang", font).Width) / 2, labelY)
                g.DrawString("Dipotong", font, brush, x2 + (barWidth - g.MeasureString("Dipotong", font).Width) / 2, labelY)
            End Using
        End Using
    End Sub

    Private Sub PanelChartTren_Paint(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.Clear(panel.BackColor)

        ' Data untuk line chart
        Dim dataPoints As Integer() = {500000, 450000, 500000, 480000, 500000, 500000}
        Dim labels As String() = {"Jan", "Feb", "Mar", "Apr", "Mei", "Jun"}
        Dim panelWidth As Integer = panel.Width - 80
        Dim panelHeight As Integer = panel.Height - 60
        Dim maxValue As Integer = dataPoints.Max() * 1.2
        Dim minValue As Integer = 0
        Dim startX As Integer = 40
        Dim startY As Integer = 20

        ' Draw grid lines
        Using pen As New Pen(Color.FromArgb(230, 233, 240), 1)
            For i As Integer = 0 To 4
                Dim y As Integer = startY + CInt((i / 4.0) * panelHeight)
                g.DrawLine(pen, startX, y, startX + panelWidth, y)
            Next
        End Using

        ' Calculate points
        Dim points As New List(Of PointF)
        Dim xStep As Single = panelWidth / (dataPoints.Length - 1)
        Dim valueRange As Integer = maxValue - minValue

        For i As Integer = 0 To dataPoints.Length - 1
            Dim x As Single = startX + (i * xStep)
            Dim normalizedValue As Single = If(valueRange > 0, (dataPoints(i) - minValue) / valueRange, 0.5)
            Dim y As Single = startY + panelHeight - (normalizedValue * panelHeight)
            points.Add(New PointF(x, y))
        Next

        ' Draw filled area under line
        Dim path As New GraphicsPath()
        path.AddLines(points.ToArray())
        path.AddLine(points.Last().X, points.Last().Y, points.Last().X, startY + panelHeight)
        path.AddLine(points.First().X, startY + panelHeight, points.First().X, points.First().Y)
        path.CloseFigure()
        Using brush As New SolidBrush(Color.FromArgb(41, 128, 185, 30))
            g.FillPath(brush, path)
        End Using

        ' Draw line
        Using pen As New Pen(Color.FromArgb(41, 128, 185), 3)
            g.DrawLines(pen, points.ToArray())
        End Using

        ' Draw points
        For Each point As PointF In points
            g.FillEllipse(Brushes.White, point.X - 5, point.Y - 5, 10, 10)
            Using pen As New Pen(Color.FromArgb(41, 128, 185), 2)
                g.DrawEllipse(pen, point.X - 5, point.Y - 5, 10, 10)
            End Using
        Next

        ' Draw labels
        Using font As New Font("Segoe UI", 8.0!, FontStyle.Regular)
            Using brush As New SolidBrush(Color.FromArgb(105, 112, 125))
                For i As Integer = 0 To labels.Length - 1
                    Dim x As Single = startX + (i * xStep)
                    Dim textSize As SizeF = g.MeasureString(labels(i), font)
                    g.DrawString(labels(i), font, brush, x - textSize.Width / 2, startY + panelHeight + 5)
                Next
            End Using
        End Using
    End Sub

    ' Menu Events
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Login
            frm.Show()
            Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub ButtonNotification_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim notificationForm As New Notifikasi(_currentUserId)
        notificationForm.Show(Me)
    End Sub

    Private Sub ProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.Click

    End Sub

    Private Sub LabelTitle_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem1.Click
        Dim frm As New Profil()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Login
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PengisianSPTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PengisianSPTToolStripMenuItem1.Click
        Dim frm As New Pengisian_SPT()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub RiwayatPelaporanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RiwayatPelaporanToolStripMenuItem1.Click
        Dim frm1 As New Riwayat_Pelaporan()
        frm1.Show()
        Me.Close()
    End Sub

    Private Sub SimulasiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SimulasiToolStripMenuItem1.Click
        Dim frm As New Edukasi()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub PanduanEBillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanduanEBillingToolStripMenuItem.Click
        Dim frm As New PanduanEBilling()
        frm.Show()
        Me.Close()
    End Sub
End Class
