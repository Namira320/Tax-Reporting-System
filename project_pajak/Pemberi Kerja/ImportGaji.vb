Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class ImportGaji
    Private _dtGaji As New DataTable()

    Private Sub ImportGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup DataTable columns matching CSV structure
        _dtGaji.Columns.Add("NPWPPegawai")
        _dtGaji.Columns.Add("NamaPegawai")
        _dtGaji.Columns.Add("Jabatan") ' New
        _dtGaji.Columns.Add("MasaPajak")
        _dtGaji.Columns.Add("TahunPajak")
        _dtGaji.Columns.Add("GajiBruto")
        _dtGaji.Columns.Add("PPhDipotong")

        dgvPreview.DataSource = _dtGaji
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtFilePath.Text = OpenFileDialog1.FileName
            LoadCsvData(txtFilePath.Text)
        End If
    End Sub

    Private Sub LoadCsvData(filePath As String)
        Try
            _dtGaji.Rows.Clear()
            Dim lines = File.ReadAllLines(filePath)
            
            ' Skip header if exists (assuming first line is header)
            Dim startIndex As Integer = 0
            If lines.Length > 0 AndAlso lines(0).ToLower().Contains("npwp") Then
                startIndex = 1
            End If

            For i As Integer = startIndex To lines.Length - 1
                Dim line = lines(i)
                If String.IsNullOrWhiteSpace(line) Then Continue For

                Dim parts = line.Split(","c)
                If parts.Length >= 7 Then
                    _dtGaji.Rows.Add(parts(0).Trim(), parts(1).Trim(), parts(2).Trim(), parts(3).Trim(), parts(4).Trim(), parts(5).Trim(), parts(6).Trim())
                ElseIf parts.Length = 6 Then 
                    ' Legacy format support
                     _dtGaji.Rows.Add(parts(0).Trim(), parts(1).Trim(), "-", parts(2).Trim(), parts(3).Trim(), parts(4).Trim(), parts(5).Trim())
                End If
            Next

            lblStatus.Text = $"Status: { _dtGaji.Rows.Count} data siap diimpor."
            btnSimpanDatabase.Enabled = _dtGaji.Rows.Count > 0
        Catch ex As Exception
            MessageBox.Show("Error membaca file CSV: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSimpanDatabase_Click(sender As Object, e As EventArgs) Handles btnSimpanDatabase.Click
        If _dtGaji.Rows.Count = 0 Then Return

        Try
            Using conn As SqlConnection = GetConnection()
                If OpenConnection(conn) Then
                    Dim successCount As Integer = 0
                    
                    For Each row As DataRow In _dtGaji.Rows
                        Dim query As String = "INSERT INTO tbl_Gaji (PemberiKerjaNPWP, NPWPPegawai, NamaPegawai, Jabatan, MasaPajak, TahunPajak, GajiBruto, PPhDipotong, TanggalInput) " &
                                              "VALUES (@pkNpwp, @npwp, @nama, @jabatan, @masa, @tahun, @bruto, @pph, @tgl)"
                        
                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@pkNpwp", Module1.CurrentUserNIK) 
                            cmd.Parameters.AddWithValue("@npwp", row("NPWPPegawai"))
                            cmd.Parameters.AddWithValue("@nama", row("NamaPegawai"))
                            cmd.Parameters.AddWithValue("@jabatan", row("Jabatan"))
                            cmd.Parameters.AddWithValue("@masa", Convert.ToInt32(row("MasaPajak")))
                            cmd.Parameters.AddWithValue("@tahun", Convert.ToInt32(row("TahunPajak")))
                            cmd.Parameters.AddWithValue("@bruto", Convert.ToDecimal(row("GajiBruto")))
                            cmd.Parameters.AddWithValue("@pph", Convert.ToDecimal(row("PPhDipotong")))
                            cmd.Parameters.AddWithValue("@tgl", DateTime.Now)
                            
                            cmd.ExecuteNonQuery()
                            successCount += 1
                        End Using
                    Next
                    
                    MessageBox.Show($"Berhasil menyimpan {successCount} data gaji ke database.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnSimpanDatabase.Enabled = False
                    _dtGaji.Rows.Clear()
                    lblStatus.Text = "Status: Data berhasil disimpan."
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDownloadTemplate_Click(sender As Object, e As EventArgs) Handles btnDownloadTemplate.Click
        SaveFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
        SaveFileDialog1.FileName = "Template_Gaji.csv"
        
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(SaveFileDialog1.FileName, False, Encoding.UTF8)
                    writer.WriteLine("NPWP_Pegawai,Nama_Pegawai,Jabatan,Masa_Pajak,Tahun_Pajak,Gaji_Bruto,PPh_Dipotong")
                    writer.WriteLine("01.234.567.8-001.000,Budi Santoso,Manager,1,2024,10000000,500000")
                    writer.WriteLine("01.234.567.8-002.000,Siti Aminah,Staff IT,1,2024,12000000,600000")
                End Using
                MessageBox.Show("Template berhasil didownload!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal download template: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCetakSPT_Click(sender As Object, e As EventArgs) Handles btnCetakSPT.Click
        Dim frm As New CetakBuktiPotong()
        frm.ShowDialog()
    End Sub
End Class