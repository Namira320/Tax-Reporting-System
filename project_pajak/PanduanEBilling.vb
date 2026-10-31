Imports System.IO

Public Class PanduanEBilling
    Private pdfPath As String = ""

    Private Sub PanduanEBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set HTML path
        pdfPath = Path.Combine(Application.StartupPath, "Resources", "Panduan_eBilling.html")

        ' Cek apakah file HTML ada
        If File.Exists(pdfPath) Then
            LoadPDF()
        Else
            MessageBox.Show("File panduan e-Billing tidak ditemukan!" & vbCrLf & _
                          "Path: " & pdfPath & vbCrLf & vbCrLf & _
                          "Silakan pastikan file 'Panduan_eBilling.html' ada di folder Resources", _
                          "File Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            
            ' Show alternative - open browser ke website DJP
            ButtonBukaDJP.Visible = True
        End If
    End Sub

    Private Sub LoadPDF()
        Try
            ' Gunakan WebBrowser untuk menampilkan PDF
            WebBrowserPDF.Navigate(pdfPath)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat membuka PDF:" & vbCrLf & ex.Message, _
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Me.Close()
    End Sub

    Private Sub ButtonBukaDJP_Click(sender As Object, e As EventArgs) Handles ButtonBukaDJP.Click
        ' Buka website DJP untuk panduan e-Billing
        Try
            Process.Start(New ProcessStartInfo("https://www.pajak.go.id/id/panduan-ebilling") With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Tidak dapat membuka browser", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        ' Reload PDF
        If File.Exists(pdfPath) Then
            LoadPDF()
        End If
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Try
            If WebBrowserPDF.Document IsNot Nothing Then
                WebBrowserPDF.ShowPrintDialog()
            Else
                MessageBox.Show("Dokumen PDF belum dimuat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membuka dialog cetak: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
