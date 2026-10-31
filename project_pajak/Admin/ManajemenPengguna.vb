Imports System.Data.SqlClient
Imports System.ComponentModel

Namespace Admin
    Public Class ManajemenPengguna
        Private _penggunaData As New List(Of PenggunaWP)

        Private Sub ManajemenPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Setup ComboBox
            cmbStatus.Items.Clear()
            cmbStatus.Items.Add("Aktif")
            cmbStatus.Items.Add("Non-Aktif")
            cmbStatus.Items.Add("Pensiun")
            cmbStatus.SelectedIndex = 0

            ConfigureDataGrid()
            LoadPenggunaData()
        End Sub

        Private Sub ConfigureDataGrid()
            dgvPengguna.AutoGenerateColumns = False
            dgvPengguna.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvPengguna.MultiSelect = False
            dgvPengguna.AllowUserToResizeRows = False
            dgvPengguna.RowTemplate.Height = 35

            ' Styling
            dgvPengguna.EnableHeadersVisualStyles = False
            dgvPengguna.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 81, 181)
            dgvPengguna.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvPengguna.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            dgvPengguna.ColumnHeadersHeight = 40
            dgvPengguna.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            dgvPengguna.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 149, 237)
            dgvPengguna.DefaultCellStyle.SelectionForeColor = Color.White
        End Sub

        Private Sub LoadPenggunaData(Optional searchKeyword As String = "")
            _penggunaData.Clear()

            Try
                Using conn As SqlConnection = GetConnection()
                    If OpenConnection(conn) Then
                        ' Modified Query to check Profile Completeness (Join with tbl_WajibPajak)
                        Dim query As String = "
                            SELECT 0 as ID, u.Username, u.NamaLengkap, u.Password, u.IsActive, wp.ID AS ProfileID, wp.StatusPekerjaan 
                            FROM tbl_Users u 
                            LEFT JOIN tbl_WajibPajak wp ON u.Username = wp.NIK
                            WHERE u.Role = 'WAJIBPAJAK'"

                        If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                            query &= " AND (u.Username LIKE @search OR u.NamaLengkap LIKE @search)"
                        End If

                        Using cmd As New SqlCommand(query, conn)
                            If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                                cmd.Parameters.AddWithValue("@search", "%" & searchKeyword & "%")
                            End If

                            Using reader As SqlDataReader = cmd.ExecuteReader()
                                While reader.Read()
                                    Dim p As New PenggunaWP()
                                    p.Id = Convert.ToInt32(reader("ID"))
                                    p.NPWP = reader("Username").ToString()
                                    p.NamaLengkap = reader("NamaLengkap").ToString()
                                    
                                    ' Check Profile Status
                                    Dim hasProfile = Not IsDBNull(reader("ProfileID"))
                                    Dim isActiveBool = Convert.ToBoolean(reader("IsActive"))
                                    Dim jobStatus = If(IsDBNull(reader("StatusPekerjaan")), "", reader("StatusPekerjaan").ToString())
                                    
                                    Dim displayStatus As String = ""
                                    If isActiveBool Then
                                        displayStatus = "Aktif"
                                    Else
                                        If jobStatus.Equals("Pensiun", StringComparison.OrdinalIgnoreCase) Then
                                            displayStatus = "Pensiun"
                                        Else
                                            displayStatus = "Non-Aktif"
                                        End If
                                    End If
                                    
                                    p.Status = displayStatus
                                    
                                    If hasProfile Then
                                        p.Status &= " (Lengkap)"
                                    Else
                                        p.Status &= " (Data Kurang)"
                                    End If
                                    
                                    p.Password = reader("Password").ToString()
                                    _penggunaData.Add(p)
                                End While
                            End Using
                        End Using
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal memuat data pengguna: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            dgvPengguna.DataSource = Nothing
            dgvPengguna.DataSource = _penggunaData
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            If String.IsNullOrWhiteSpace(txtNPWP.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Using conn As SqlConnection = GetConnection()
                    If OpenConnection(conn) Then
                        ' Cek apakah Insert atau Update
                        ' Kita gunakan NPWP (Username) sebagai kunci unik untuk pengecekan sederhana
                        ' Atau jika ada ID tersembunyi yang sedang diedit. 
                        ' Untuk simplifikasi, kita cek apakah NPWP sudah ada.

                        Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_Users WHERE Username = @npwp"
                        Dim count As Integer = 0
                        Using cmdCheck As New SqlCommand(checkQuery, conn)
                            cmdCheck.Parameters.AddWithValue("@npwp", txtNPWP.Text)
                            count = Convert.ToInt32(cmdCheck.ExecuteScalar())
                        End Using

                        ' Logika: Jika NPWP ada, kita Update. Jika tidak, Insert.
                        ' Masalah: Bagaimana jika user ingin ganti NPWP? 
                        ' Solusi ideal: Ada hidden field ID. Tapi UI tidak menampilkan ID.
                        ' Asumsi: NPWP tidak bisa diubah (Primary Key logic).

                        Dim query As String = ""
                        If count > 0 Then
                            ' Update
                            query = "UPDATE tbl_Users SET NamaLengkap = @nama, Password = @pass, IsActive = @active WHERE Username = @npwp"
                        Else
                            ' Insert
                            query = "INSERT INTO tbl_Users (Username, Password, NamaLengkap, Role, IsActive) VALUES (@npwp, @pass, @nama, 'WAJIBPAJAK', @active)"
                        End If

                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@npwp", txtNPWP.Text)
                            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                            cmd.Parameters.AddWithValue("@pass", Module1.HashPassword(txtPassword.Text)) ' Hash password
                            
                            Dim StatusSelection = cmbStatus.SelectedItem.ToString()
                            Dim isActive = If(StatusSelection = "Aktif", 1, 0)
                            cmd.Parameters.AddWithValue("@active", isActive)

                            cmd.ExecuteNonQuery()
                            
                            ' Handle Pensiun Update in tbl_WajibPajak
                            If StatusSelection = "Pensiun" Then
                                Dim qPensiun = "UPDATE tbl_WajibPajak SET StatusPekerjaan = 'Pensiun' WHERE NIK = @npwp"
                                Using cmdP As New SqlCommand(qPensiun, conn)
                                    cmdP.Parameters.AddWithValue("@npwp", txtNPWP.Text)
                                    cmdP.ExecuteNonQuery()
                                End Using
                            End If
                        End Using

                        MessageBox.Show("Data pengguna berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                        LoadPenggunaData()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnNonAktifkan_Click(sender As Object, e As EventArgs) Handles btnNonAktifkan.Click
            If String.IsNullOrWhiteSpace(txtNPWP.Text) Then
                MessageBox.Show("Pilih pengguna yang akan dihapus/dinonaktifkan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result = MessageBox.Show($"Apakah Anda yakin ingin menghapus pengguna {txtNama.Text}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Try
                    Using conn As SqlConnection = GetConnection()
                        If OpenConnection(conn) Then
                            ' Hard Delete sesuai permintaan "Hapus"
                            Dim query As String = "DELETE FROM tbl_Users WHERE Username = @npwp"
                            Using cmd As New SqlCommand(query, conn)
                                cmd.Parameters.AddWithValue("@npwp", txtNPWP.Text)
                                cmd.ExecuteNonQuery()
                            End Using

                            MessageBox.Show("Pengguna berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearForm()
                            LoadPenggunaData()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
            LoadPenggunaData(txtCari.Text)
        End Sub

        Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
            ClearForm()
            LoadPenggunaData()
        End Sub

        Private Sub ClearForm()
            txtNPWP.Clear()
            txtNama.Clear()
            txtPassword.Clear()
            cmbStatus.SelectedIndex = 0
            txtCari.Clear()
        End Sub

        Private Sub dgvPengguna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPengguna.CellClick
            If e.RowIndex >= 0 Then
                Dim selectedUser = _penggunaData(e.RowIndex)
                txtNPWP.Text = selectedUser.NPWP
                txtNama.Text = selectedUser.NamaLengkap
                txtPassword.Text = selectedUser.Password ' Encrypted/Hashed
                cmbStatus.SelectedItem = selectedUser.Status
            End If
        End Sub

        Private Sub dgvPengguna_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPengguna.CellFormatting
            If e.RowIndex < 0 Then Return

            Dim item = TryCast(dgvPengguna.Rows(e.RowIndex).DataBoundItem, PenggunaWP)
            If item Is Nothing Then Return

            ' Warna status
            If dgvPengguna.Columns(e.ColumnIndex).Name = "colStatus" Then
                Dim st = item.Status.ToLower()
                If st.Contains("aktif") AndAlso Not st.Contains("non") Then
                    e.CellStyle.ForeColor = Color.FromArgb(56, 142, 60) ' Green
                Else
                    e.CellStyle.ForeColor = Color.FromArgb(211, 47, 47) ' Red
                End If
                
                If st.Contains("belum lengkap") Then
                    e.CellStyle.ForeColor = Color.OrangeRed ' Warn for incomplete
                End If
                
                e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
            End If
        End Sub

        Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
            Me.Close()
        End Sub
    End Class
End Namespace