Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Windows.Forms

Public Class Dashboard
    ' Private ReadOnly _currentUserId As Integer = 1 ' Removed, using Module1.CurrentUserNIK
    ' Private _latestNotifications As List(Of NotificationItem) = New List(Of NotificationItem)() ' Commented out

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if user is logged in
        If String.IsNullOrEmpty(Module1.CurrentUserNIK) Then
            MessageBox.Show("Sesi anda telah habis. Silahkan login kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim frm As New Login()
            frm.Show()
            Me.Close()
            Return
        End If

        ' Inisialisasi data
        LoadDashboardData()
        DrawCharts()
        ' CheckUnreadNotifications() ' Commented out
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

        DataGridViewRiwayat.Rows.Clear()

        Using conn As SqlConnection = GetConnection()
            Try
                If OpenConnection(conn) Then
                    ' 1. Get User Name
                    Dim queryUser As String = "SELECT NamaLengkap FROM tbl_WajibPajak WHERE NIK = @NIK"
                    Using cmd As New SqlCommand(queryUser, conn)
                        cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing Then
                            LabelTitle.Text = "Halo, " & result.ToString()
                        End If
                    End Using

                    ' 2. Get Latest SPT for Cards
                    Dim queryLatest As String = "SELECT TOP 1 PPhTerutang, PPhDipotong, StatusSPT, PPhKurangLebih FROM tbl_SPT WHERE NIK = @NIK ORDER BY TanggalLapor DESC"
                    Using cmd As New SqlCommand(queryLatest, conn)
                        cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Dim terutang As Decimal = If(IsDBNull(reader("PPhTerutang")), 0, Convert.ToDecimal(reader("PPhTerutang")))
                                Dim dipotong As Decimal = If(IsDBNull(reader("PPhDipotong")), 0, Convert.ToDecimal(reader("PPhDipotong")))
                                Dim status As String = If(IsDBNull(reader("StatusSPT")), "-", reader("StatusSPT").ToString())
                                Dim kurangLebih As Decimal = If(IsDBNull(reader("PPhKurangLebih")), 0, Convert.ToDecimal(reader("PPhKurangLebih")))

                                LabelPajakTerutangValue.Text = "Rp " & terutang.ToString("N0")
                                LabelPajakDipotongValue.Text = "Rp " & dipotong.ToString("N0")
                                LabelStatusValue.Text = status
                            Else
                                LabelPajakTerutangValue.Text = "Rp 0"
                                LabelPajakDipotongValue.Text = "Rp 0"
                                LabelStatusValue.Text = "-"
                            End If
                        End Using
                    End Using

                    ' 3. Get History for Grid
                    Dim queryHistory As String = "SELECT TanggalLapor, JenisSPT, PPhTerutang, StatusSPT FROM tbl_SPT WHERE NIK = @NIK ORDER BY TanggalLapor DESC"
                    Using cmd As New SqlCommand(queryHistory, conn)
                        cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                Dim tgl As DateTime = Convert.ToDateTime(reader("TanggalLapor"))
                                Dim jenis As String = reader("JenisSPT").ToString()
                                Dim jumlah As Decimal = If(IsDBNull(reader("PPhTerutang")), 0, Convert.ToDecimal(reader("PPhTerutang")))
                                Dim stat As String = reader("StatusSPT").ToString()

                                DataGridViewRiwayat.Rows.Add(tgl.ToString("dd MMM yyyy"), jenis, "Rp " & jumlah.ToString("N0"), stat)
                            End While
                        End Using
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal memuat data dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Commented out notification logic
    ' Private Sub CheckUnreadNotifications()
    '     _latestNotifications = NotificationRepository.GetNotificationsForUser(_currentUserId)
    '     Dim unreadCount = _latestNotifications.Count(Function(n) Not n.IsRead)
    '     UpdateNotificationBadge(unreadCount)
    '     Dim hasUrgentUnread = _latestNotifications.Any(Function(n) n.IsUrgent AndAlso Not n.IsRead)
    '     If hasUrgentUnread Then
    '         Dim notificationForm As New Notifikasi(_currentUserId)
    '         notificationForm.Show(Me)
    '     End If
    ' End Sub

    ' Private Sub UpdateNotificationBadge(unreadCount As Integer)
    '     LabelNotificationBadge.Visible = unreadCount > 0
    '     If unreadCount > 0 Then
    '         LabelNotificationBadge.Text = unreadCount.ToString()
    '     End If
    ' End Sub

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

        ' Data untuk bar chart (Static for now, can be dynamic later)
        Dim terutang As Integer = 2500000
        Dim dipotong As Integer = 2000000
        Dim maxValue As Integer = Math.Max(terutang, dipotong) * 1.2

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
        Using brush As New SolidBrush(Color.FromArgb(7, 71, 166))
            g.FillRectangle(brush, x1, y1, barWidth, height1)
        End Using

        ' Bar 2 - Pajak Dipotong (Hijau)
        Using brush As New SolidBrush(Color.FromArgb(34, 197, 94))
            g.FillRectangle(brush, x2, y2, barWidth, height2)
        End Using

        ' Value labels on bars
        Using font As New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
            Using brush As New SolidBrush(Color.White)
                Dim text1 As String = "2.5M"
                Dim textSize1 As SizeF = g.MeasureString(text1, font)
                g.DrawString(text1, font, brush, x1 + (barWidth - textSize1.Width) / 2, y1 + 5)

                Dim text2 As String = "2M"
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

        ' Data untuk line chart (Static for now)
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
        Using brush As New SolidBrush(Color.FromArgb(7, 71, 166, 30))
            g.FillPath(brush, path)
        End Using

        ' Draw line
        Using pen As New Pen(Color.FromArgb(7, 71, 166), 3)
            g.DrawLines(pen, points.ToArray())
        End Using

        ' Draw points
        For Each point As PointF In points
            g.FillEllipse(Brushes.White, point.X - 5, point.Y - 5, 10, 10)
            Using pen As New Pen(Color.FromArgb(7, 71, 166), 2)
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
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Module1.CurrentUserNIK = "" ' Clear session
            Dim frm As New Login
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub ButtonNotification_Click(sender As Object, e As EventArgs) Handles ButtonNotification.Click, KeluarToolStripMenuItem.Click
        ' Dim notificationForm As New Notifikasi(_currentUserId)
        ' notificationForm.Show(Me)
        MessageBox.Show("Fitur notifikasi belum tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.Click
        Dim frm As New Profil()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub SimulasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimulasiToolStripMenuItem.Click
        Dim frm As New Simulasi()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub PengisianSPTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengisianSPTToolStripMenuItem.Click
        Dim frm As New Pengisian_SPT()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub RiwayatPelaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiwayatPelaporanToolStripMenuItem.Click
        Dim frm As New Riwayat_Pelaporan()
        frm.Show()
        Me.Hide()
    End Sub

End Class
