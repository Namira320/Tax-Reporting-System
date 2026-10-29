Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class CetakBuktiPotong
    Private Sub CetakBuktiPotong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTahun()
        LoadKaryawan()
    End Sub

    Private Sub LoadTahun()
        cmbTahun.Items.Clear()
        Dim currentYear = DateTime.Now.Year
        For i As Integer = 0 To 4
            cmbTahun.Items.Add(currentYear - i)
        Next
        cmbTahun.SelectedIndex = 0
    End Sub

    Private Sub LoadKaryawan()
        cmbKaryawan.Items.Clear()
        cmbKaryawan.Items.Add("Semua Karyawan")
        
        Try
            Using conn As SqlConnection = GetConnection()
                If OpenConnection(conn) Then
                    ' Ambil daftar pegawai unik dari tbl_Gaji milik Pemberi Kerja ini
                    Dim query As String = "SELECT DISTINCT NPWPPegawai, NamaPegawai FROM tbl_Gaji WHERE PemberiKerjaNPWP = @pkNpwp"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@pkNpwp", Module1.CurrentUserNIK)
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                Dim item As String = $"{reader("NamaPegawai")} - {reader("NPWPPegawai")}"
                                cmbKaryawan.Items.Add(item)
                            End While
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data karyawan: " & ex.Message)
        End Try
        
        cmbKaryawan.SelectedIndex = 0
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        If cmbKaryawan.SelectedIndex = 0 Then
            MessageBox.Show("Silakan pilih karyawan spesifik untuk melihat detail bukti potong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim parts = cmbKaryawan.SelectedItem.ToString().Split("-"c)
            Dim npwpPegawai = parts(1).Trim()
            Dim tahun = Convert.ToInt32(cmbTahun.SelectedItem)

            Using conn As SqlConnection = GetConnection()
                If OpenConnection(conn) Then
                    Dim query As String = "SELECT g.GajiBruto AS TotalGaji, g.PPhDipotong AS TotalPPh, wp.StatusPekerjaan " &
                                          "FROM tbl_Gaji g " &
                                          "LEFT JOIN tbl_WajibPajak wp ON g.NPWPPegawai = wp.NPWP " &
                                          "WHERE g.NPWPPegawai = @npwp AND g.TahunPajak = @tahun AND g.PemberiKerjaNPWP = @pkNpwp"
                    ' Note: Using SUM might differ if multiple entries per year? Assuming 1 entry per year/month logic handled.
                    ' The original was SUM. Let's keep SUM but we need to pivot Status.
                    ' Actually, StatusPekerjaan is one value per User.
                    Dim statusPekerjaan As String = ""
                    Dim jabatanPegawai As String = "-"

                    Dim queryCheck As String = "SELECT StatusPekerjaan, Jabatan FROM tbl_WajibPajak WHERE NPWP = @npwp"
                    Using cmdCheck As New SqlCommand(queryCheck, conn)
                        cmdCheck.Parameters.AddWithValue("@npwp", npwpPegawai)
                        Using rdrCheck As SqlDataReader = cmdCheck.ExecuteReader()
                            If rdrCheck.Read() Then
                                statusPekerjaan = If(IsDBNull(rdrCheck("StatusPekerjaan")), "", rdrCheck("StatusPekerjaan").ToString())
                                jabatanPegawai = If(IsDBNull(rdrCheck("Jabatan")), "-", rdrCheck("Jabatan").ToString())
                            End If
                        End Using
                    End Using
                    
                    If statusPekerjaan.Equals("Pensiun", StringComparison.OrdinalIgnoreCase) Then
                        MessageBox.Show("Pegawai ini berstatus PENSIUN / NON-AKTIF." & vbCrLf & "Tidak dapat mencetak bukti potong.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Dim querySum As String = "SELECT SUM(GajiBruto) as TotalGaji, SUM(PPhDipotong) as TotalPPh FROM tbl_Gaji WHERE NPWPPegawai = @npwp AND TahunPajak = @tahun AND PemberiKerjaNPWP = @pkNpwp"
                    Using cmd As New SqlCommand(querySum, conn)
                        cmd.Parameters.AddWithValue("@npwp", npwpPegawai)
                        cmd.Parameters.AddWithValue("@tahun", tahun)
                        cmd.Parameters.AddWithValue("@pkNpwp", Module1.CurrentUserNIK)
                        
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() AndAlso Not IsDBNull(reader("TotalGaji")) Then
                                Dim totalGaji = Convert.ToDecimal(reader("TotalGaji"))
                                Dim totalPPh = Convert.ToDecimal(reader("TotalPPh"))
                                
                                Dim msg As String = $"Preview Bukti Potong 1721-A1{vbCrLf}" &
                                                    $"--------------------------------{vbCrLf}" &
                                    $"NPWP Pegawai: {npwpPegawai}{vbCrLf}" &
                                    $"Jabatan : {jabatanPegawai}{vbCrLf}" &
                                    $"Tahun Pajak : {tahun}{vbCrLf}" &
                                                    $"Total Bruto : Rp {Module1.FormatAngka(totalGaji)}{vbCrLf}" &
                                                    $"Total PPh   : Rp {Module1.FormatAngka(totalPPh)}{vbCrLf}" &
                                                    $"--------------------------------{vbCrLf}" &
                                                    $"Status: Siap Cetak"

                                MessageBox.Show(msg, "Preview Bukti Potong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Tidak ada data penghasilan untuk karyawan ini di tahun " & tahun, "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Simulasi Export PDF
        MessageBox.Show("Bukti Potong berhasil diekspor ke PDF (Simulasi).", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class