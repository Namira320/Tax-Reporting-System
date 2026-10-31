Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Simulasi
    Private currentNIK As String = ""

    Private Sub Simulasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set NIK from logged in user
        If Not String.IsNullOrEmpty(Module1.CurrentUserNIK) Then
            currentNIK = Module1.CurrentUserNIK
            ' Load User Name
            Using conn As SqlConnection = GetConnection()
                If OpenConnection(conn) Then
                    Try
                        Dim query = "SELECT NamaLengkap FROM tbl_WajibPajak WHERE NIK = @NIK"
                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@NIK", currentNIK)
                            Dim result = cmd.ExecuteScalar()
                            If result IsNot Nothing Then
                                ' Update form title with user name
                                Me.Text = "TaxEase | Simulasi Pajak - " & result.ToString()
                            End If
                        End Using
                    Catch ex As Exception
                        ' Ignore error for name loading
                    End Try
                    CloseConnection(conn)
                End If
            End Using
        End If

        ResetOutput()
        LoadHistorySimulasi()
    End Sub

    Private Sub ResetOutput()
        lblStatusResult.Text = "Belum dihitung"
        lblStatusResult.ForeColor = Color.FromArgb(32, 38, 44)
        pnlStatus.BackColor = Color.FromArgb(226, 232, 255)
        lblStatusDetail.Text = "Jawab pertanyaan di atas untuk mendapatkan hasil simulasi."
        lblPanduanBilling.Visible = False
        keterangan.Text = ""
    End Sub

    ' Update state Question 2 based on Question 1
    Private Sub rbQ1Yes_CheckedChanged(sender As Object, e As EventArgs) Handles rbQ1Yes.CheckedChanged, rbQ1No.CheckedChanged
        rbQ2Yes.Enabled = rbQ1Yes.Checked
        rbQ2No.Enabled = rbQ1Yes.Checked
        If Not rbQ1Yes.Checked Then
            rbQ2Yes.Checked = False
            rbQ2No.Checked = False
        End If
    End Sub

    ' Main Evaluation Function
    Private Function EvaluasiRule() As String
        ResetOutput()

        Dim punya_bukti = rbQ1Yes.Checked
        Dim penghasilan_lengkap = rbQ2Yes.Checked
        Dim penghasilan_lain = rbQ3Yes.Checked
        Dim ptkp_sesuai = rbQ4Yes.Checked
        Dim ada_selisih = rbQ5Yes.Checked
        Dim lebih_bayar = rbQ6Yes.Checked
        Dim kurang_bayar = rbQ7Yes.Checked
        Dim sudah_bayar = rbQ8Yes.Checked

        Dim detail As String = ""
        Dim panduan As String = ""
        Dim hasil As String = ""

        ' Unified Validation Logic
        If Not punya_bukti OrElse
           (penghasilan_lain And Not penghasilan_lengkap) OrElse
           Not ptkp_sesuai OrElse
           (ada_selisih And Not lebih_bayar And Not kurang_bayar) OrElse
           (lebih_bayar And kurang_bayar) Then

            detail = "Simulasi tidak dapat dilanjutkan karena kombinasi jawaban tidak logis atau data belum lengkap. Mohon periksa kembali apakah Anda memiliki Bukti Potong 1721-A1 yang valid dan tinjau jawaban Anda."
            hasil = "INVALID DATA"

        ElseIf Not ada_selisih Then
            detail = "Status Pajak Anda adalah NIHIL. Jumlah pajak yang telah dipotong oleh pemberi kerja (PPh 21) sudah sesuai dengan perhitungan beban pajak tahunan Anda. Tidak ada pembayaran tambahan yang diperlukan."
            hasil = "NIHIL"

        ElseIf lebih_bayar Then
            detail = "Status Pajak Anda adalah LEBIH BAYAR. Ini terjadi karena akumulasi potongan pajak oleh pemberi kerja melebihi jumlah pajak terutang yang seharusnya. Anda berhak mengajukan permohonan pengembalian (restitusi) atas kelebihan pembayaran ini."
            hasil = "LEBIH BAYAR"

        ElseIf kurang_bayar Then
            If Not sudah_bayar Then
                detail = "Status Pajak Anda adalah KURANG BAYAR. Total pajak terutang Anda lebih besar dari pajak yang telah dipotong pemberi kerja. Selisih ini wajib dilunasi melalui pembayaran via Bank/Pos (menggunakan Kode Billing) sebelum lapor SPT."
                panduan = "Panduan: Pilih Kode Pajak 411125 (PPh Pasal 29) → Generate Billing → Bayar via bank/ATM"
                hasil = "KURANG BAYAR"
            Else
                detail = "Status awal Anda KURANG BAYAR, namun Anda telah melunasi selisih tersebut. Simpan Bukti Penerimaan Negara (NTPN) Anda sebagai bukti pelunasan saat mengisi formulir SPT Tahunan."
                hasil = "NIHIL"
            End If
        Else
            detail = "Data Belum Lengkap: Mohon jawab semua pertanyaan dengan benar sesuai kondisi Anda."
            hasil = "INVALID DATA"
        End If

        lblStatusDetail.Text = detail
        keterangan.Text = detail
        If Not String.IsNullOrEmpty(panduan) Then
            lblPanduanBilling.Text = panduan
            lblPanduanBilling.Visible = True
        End If

        Return hasil
    End Function

    ' Button Click Handler
    Private Sub btnHitungSimulasi_Click(sender As Object, e As EventArgs) Handles btnHitungSimulasi.Click
        Dim hasil As String = EvaluasiRule()

        ' Color-code based on result
        If hasil = "INVALID DATA" Then
            lblStatusResult.Text = "INVALID DATA"
            lblStatusResult.ForeColor = Color.FromArgb(220, 38, 38)
            pnlStatus.BackColor = Color.FromArgb(254, 226, 226)

            ' Force UI update before showing popup
            Application.DoEvents()

            ' Show Detailed Popup
            MessageBox.Show("INVALID DATA", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            lblStatusResult.Text = hasil

            If hasil = "NIHIL" Then
                lblStatusResult.ForeColor = Color.FromArgb(22, 163, 74)
                pnlStatus.BackColor = Color.FromArgb(220, 252, 231)
            ElseIf hasil = "LEBIH BAYAR" Then
                lblStatusResult.ForeColor = Color.FromArgb(59, 130, 246)
                pnlStatus.BackColor = Color.FromArgb(219, 234, 254)
            ElseIf hasil = "KURANG BAYAR" Then
                lblStatusResult.ForeColor = Color.FromArgb(234, 179, 8)
                pnlStatus.BackColor = Color.FromArgb(254, 249, 195)
            End If
        End If

        ' Save to database including INVALID DATA
        SaveSimulasiToDatabase(hasil, lblStatusDetail.Text, lblPanduanBilling.Text)
    End Sub

    ' Load Simulation History from Database
    ' Load Simulation History from Database
    Private Sub LoadHistorySimulasi()
        If String.IsNullOrEmpty(currentNIK) Then
            DataGridViewRiwayat.Rows.Clear()
            Exit Sub
        End If

        Using conn As SqlConnection = GetConnection()
            If Not OpenConnection(conn) Then Exit Sub

            Try
                Dim query = "SELECT TanggalSimulasi, HasilSimulasi, DetailSimulasi FROM tbl_Simulasi WHERE NIK = @NIK ORDER BY TanggalSimulasi DESC"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NIK", currentNIK)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        DataGridViewRiwayat.Rows.Clear()
                        While reader.Read()
                            Dim tanggal = Convert.ToDateTime(reader("TanggalSimulasi")).ToString("dd/MM/yy HH:mm")
                            Dim status = reader("HasilSimulasi").ToString()
                            Dim detail = If(IsDBNull(reader("DetailSimulasi")), "-", reader("DetailSimulasi").ToString())
                            DataGridViewRiwayat.Rows.Add(tanggal, status, detail)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection(conn)
            End Try
        End Using
    End Sub

    ' Save Simulation Result to Database
    Private Sub SaveSimulasiToDatabase(hasil As String, detail As String, panduan As String)
        If String.IsNullOrEmpty(currentNIK) Then Exit Sub

        Using conn As SqlConnection = GetConnection()
            If Not OpenConnection(conn) Then Exit Sub

            Try
                Dim query = "INSERT INTO tbl_Simulasi (NIK, HasilSimulasi, DetailSimulasi, PanduanBilling) VALUES (@NIK, @Hasil, @Detail, @Panduan)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NIK", currentNIK)
                    cmd.Parameters.AddWithValue("@Hasil", hasil)
                    cmd.Parameters.AddWithValue("@Detail", detail)
                    cmd.Parameters.AddWithValue("@Panduan", If(String.IsNullOrEmpty(panduan), DBNull.Value, panduan))
                    cmd.ExecuteNonQuery()
                End Using

                ' Reload history after save
                LoadHistorySimulasi()
            Catch ex As Exception
                MessageBox.Show("Error saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection(conn)
            End Try
        End Using
    End Sub

    Public Sub SetUserNIK(nik As String)
        currentNIK = nik
        LoadHistorySimulasi()
    End Sub
    Private Sub btnKembaliDashboard_Click(sender As Object, e As EventArgs) Handles btnKembaliDashboard.Click
        Dim frm As New Dashboard()
        frm.Show()
        Me.Close()
    End Sub

    ' PDF Export Logic (Direct Print / Print to PDF)
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        If lblStatusResult.Text = "Belum dihitung" Then
            MessageBox.Show("Silakan lakukan perhitungan simulasi terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim pd As New PrintDocument()
        pd.DocumentName = "SimulasiPajak_" & currentNIK
        AddHandler pd.PrintPage, AddressOf PrintPageHandler

        Dim printDialog As New PrintDialog()
        printDialog.Document = pd
        printDialog.UseEXDialog = True ' Modern print dialog

        If printDialog.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        ' Graphics Setup
        Dim g As Graphics = e.Graphics
        Dim fontTitle As New Font("Segoe UI", 24, FontStyle.Bold)
        Dim fontSubtitle As New Font("Segoe UI", 14, FontStyle.Regular)
        Dim fontHeader As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim fontBody As New Font("Segoe UI", 11, FontStyle.Regular)
        Dim fontResult As New Font("Segoe UI", 18, FontStyle.Bold)

        Dim brushBlack As New SolidBrush(Color.Black)
        Dim brushBlue As New SolidBrush(Color.FromArgb(41, 128, 185))
        Dim brushGray As New SolidBrush(Color.FromArgb(100, 100, 100))

        Dim margin As Integer = 50
        Dim yPos As Integer = margin

        ' 1. Header Line
        g.DrawString("TaxEase", fontTitle, brushBlue, margin, yPos)
        yPos += 40
        g.DrawString("Laporan Hasil Simulasi Pajak", fontSubtitle, brushGray, margin, yPos)
        yPos += 60

        ' Separator
        g.DrawLine(Pens.LightGray, margin, yPos, e.PageBounds.Width - margin, yPos)
        yPos += 20

        ' 2. User Info
        g.DrawString("Informasi Wajib Pajak", fontHeader, brushBlack, margin, yPos)
        yPos += 30
        g.DrawString($"Nama  : {Me.Text.Replace("TaxEase | Simulasi Pajak - ", "")}", fontBody, brushBlack, margin, yPos)
        yPos += 25
        g.DrawString($"NIK   : {currentNIK}", fontBody, brushBlack, margin, yPos)
        yPos += 25
        g.DrawString($"Tanggal : {DateTime.Now.ToString("dd MMMM yyyy HH:mm")}", fontBody, brushBlack, margin, yPos)
        yPos += 50

        ' 3. Result Box
        Dim rectResult As New Rectangle(margin, yPos, e.PageBounds.Width - (2 * margin), 100)
        g.FillRectangle(New SolidBrush(Color.FromArgb(240, 248, 255)), rectResult)
        g.DrawRectangle(Pens.LightBlue, rectResult)

        Dim resultText As String = lblStatusResult.Text
        Dim resultColor As Brush = Brushes.Black
        If resultText = "KURANG BAYAR" Then resultColor = Brushes.Orange
        If resultText = "LEBIH BAYAR" Then resultColor = Brushes.Blue
        If resultText = "NIHIL" Then resultColor = Brushes.Green
        If resultText.StartsWith("ERROR") Then resultColor = Brushes.Red

        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        g.DrawString(resultText, fontResult, resultColor, rectResult, sf)
        yPos += 120

        ' 4. Detail Explanation
        g.DrawString("Detail Keterangan:", fontHeader, brushBlack, margin, yPos)
        yPos += 30

        Dim rectDetail As New RectangleF(margin, yPos, e.PageBounds.Width - (2 * margin), 200)
        g.DrawString(lblStatusDetail.Text, fontBody, brushBlack, rectDetail)

        yPos += 100

        ' 5. Panduan (If visible)
        If lblPanduanBilling.Visible Then
            g.DrawString("Tindak Lanjut:", fontHeader, brushBlack, margin, yPos)
            yPos += 30
            Dim rectPanduan As New RectangleF(margin, yPos, e.PageBounds.Width - (2 * margin), 100)
            g.DrawString(lblPanduanBilling.Text, fontBody, brushBlue, rectPanduan)
        End If

        ' Footer
        Dim footerY = e.PageBounds.Height - margin - 20
        g.DrawLine(Pens.LightGray, margin, footerY, e.PageBounds.Width - margin, footerY)
        g.DrawString("Dicetak melalui Aplikasi TaxEase © " & Date.Today.Year, New Font("Segoe UI", 9), brushGray, margin, footerY + 5)
    End Sub

End Class