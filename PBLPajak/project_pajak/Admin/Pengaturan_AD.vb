Imports System.Data.SqlClient

Namespace Admin
    Public Class Pengaturan_AD
        Private Sub Pengaturan_AD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            cmbStatusFilter.SelectedIndex = 0 ' Default: Semua User
            ConfigureDataGrid()
        End Sub

        Private Sub ConfigureDataGrid()
            dgvMonitoring.AutoGenerateColumns = False
            dgvMonitoring.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvMonitoring.MultiSelect = False
            dgvMonitoring.AllowUserToResizeRows = False
            dgvMonitoring.RowTemplate.Height = 35

            ' Styling
            dgvMonitoring.EnableHeadersVisualStyles = False
            dgvMonitoring.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 110, 164)
            dgvMonitoring.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvMonitoring.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            dgvMonitoring.ColumnHeadersHeight = 40
            dgvMonitoring.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            dgvMonitoring.DefaultCellStyle.SelectionBackColor = Color.FromArgb(67, 160, 71)
            dgvMonitoring.DefaultCellStyle.SelectionForeColor = Color.White
        End Sub

        Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
            LoadMonitoringData()
        End Sub

        Private Sub LoadMonitoringData()
            Try
                Using conn As SqlConnection = GetConnection()
                    If OpenConnection(conn) Then
                        ' Query: Get Users and their latest SPT status
                        ' We need to join tbl_Users with tbl_SPT
                        ' Assuming we want the LATEST SPT for each user or specific period?
                        ' For monitoring, let's look at the latest SPT entry for current year.
                        
                        Dim query As String = "
                            SELECT u.NamaLengkap, u.Username, s.PPhKurangLebih, s.StatusBayar
                            FROM tbl_Users u
                            LEFT JOIN tbl_SPT s ON u.Username = s.NIK 
                                AND YEAR(s.TanggalInput) = @Year
                            WHERE u.Role = 'WAJIBPAJAK'"

                        ' Filter logic
                        Dim filter As String = cmbStatusFilter.SelectedItem.ToString()
                        If filter <> "Semua User" Then
                            query &= " AND s.StatusBayar = @Status"
                        End If

                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Year", DateTime.Now.Year)
                            If filter <> "Semua User" Then
                                cmd.Parameters.AddWithValue("@Status", filter)
                            End If

                            Dim dt As New DataTable()
                            Using da As New SqlDataAdapter(cmd)
                                da.Fill(dt)
                            End Using

                            ' Map to DataGrid
                            ' We need a class or just bind DataTable if columns match
                            ' Let's manually bind to match the columns defined in Designer
                            ' Columns: colNama, colKontak, colTotalPajak, colStatusBayar
                            
                            dgvMonitoring.Rows.Clear()
                            For Each row As DataRow In dt.Rows
                                Dim nama = row("NamaLengkap").ToString()
                                Dim kontak = row("Username").ToString() ' Using NPWP/Username as contact for now
                                Dim totalPajak = If(IsDBNull(row("PPhKurangLebih")), 0, Convert.ToDecimal(row("PPhKurangLebih")))
                                Dim status = If(IsDBNull(row("StatusBayar")), "Belum Lapor", row("StatusBayar").ToString())

                                dgvMonitoring.Rows.Add(nama, kontak, totalPajak.ToString("N0"), status)
                            Next
                        End Using
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal memuat data monitoring: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnKirimNotifikasi_Click(sender As Object, e As EventArgs) Handles btnKirimNotifikasi.Click
            If String.IsNullOrWhiteSpace(rtbPesan.Text) Then
                MessageBox.Show("Isi pesan notifikasi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim targetCount = dgvMonitoring.Rows.Count
            If targetCount = 0 Then
                MessageBox.Show("Tidak ada penerima di daftar monitoring.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim result = MessageBox.Show($"Kirim notifikasi ke {targetCount} pengguna terpilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim successCount As Integer = 0
                Dim failCount As Integer = 0

                Cursor = Cursors.WaitCursor
                
                For Each row As DataGridViewRow In dgvMonitoring.Rows
                    If row.Cells.Count > 1 Then
                        Dim npwp = row.Cells(1).Value.ToString() ' Assuming Col Index 1 is NPWP/Username from LoadMonitoringData
                        
                        If ModuleWajibPajak.KirimNotifikasi("Pesan Admin", rtbPesan.Text, npwp) Then
                            successCount += 1
                        Else
                            failCount += 1
                        End If
                    End If
                Next
                
                Cursor = Cursors.Default
                MessageBox.Show($"Berhasil mengirim {successCount} notifikasi. Gagal: {failCount}.", "Laporan Pengiriman", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rtbPesan.Clear()
            End If
        End Sub

        Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
            Me.Close()
        End Sub

        Private Sub grpNotifikasi_Enter(sender As Object, e As EventArgs) Handles grpNotifikasi.Enter

        End Sub
    End Class
End Namespace