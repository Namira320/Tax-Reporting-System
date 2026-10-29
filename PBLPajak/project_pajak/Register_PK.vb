Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Register_PK
    Private Sub Register_PK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ComboBoxes
        InitializeProvinsi()
        
        ' Set initial states
        txtNamaKuasa.ReadOnly = True
        txtNamaKuasa.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub InitializeProvinsi()
        ' Load provinces
        If cmbProvinsi IsNot Nothing Then
            cmbProvinsi.Items.Clear()
            cmbProvinsi.Items.Add("DKI Jakarta")
            cmbProvinsi.Items.Add("Jawa Barat")
            cmbProvinsi.Items.Add("Jawa Tengah")
            cmbProvinsi.Items.Add("Jawa Timur")
            cmbProvinsi.Items.Add("Banten")
        End If
    End Sub

    ' Auto-fill nama kuasa when NIK is entered
    Private Sub txtNIKKuasa_TextChanged(sender As Object, e As EventArgs) Handles txtNIKKuasa.TextChanged
        If txtNIKKuasa.Text.Length = 16 AndAlso IsNumeric(txtNIKKuasa.Text) Then
            ' Query database to get name based on NIK
            Using conn = GetConnection()
                If OpenConnection(conn) Then
                    Try
                        Dim query = "SELECT NamaLengkap FROM tbl_WajibPajak WHERE NIK = @NIK"
                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@NIK", txtNIKKuasa.Text)
                            Dim result = cmd.ExecuteScalar()
                            If result IsNot Nothing Then
                                txtNamaKuasa.Text = result.ToString()
                            Else
                                txtNamaKuasa.Text = ""
                            End If
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        CloseConnection(conn)
                    End Try
                End If
            End Using
        Else
            txtNamaKuasa.Text = ""
        End If
    End Sub

    ' Cascading dropdown for address
    Private Sub cmbProvinsi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvinsi.SelectedIndexChanged
        If cmbKota IsNot Nothing Then
            cmbKota.Items.Clear()
            cmbKecamatan.Items.Clear()
            cmbKelurahan.Items.Clear()

            If cmbProvinsi.SelectedIndex >= 0 Then
                ' Mockup cities
                cmbKota.Items.Add("Jakarta Pusat")
                cmbKota.Items.Add("Jakarta Selatan")
                cmbKota.Items.Add("Jakarta Barat")
                cmbKota.Items.Add("Jakarta Utara")
                cmbKota.Items.Add("Jakarta Timur")
            End If
        End If
    End Sub

    Private Sub cmbKota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKota.SelectedIndexChanged
        If cmbKecamatan IsNot Nothing Then
            cmbKecamatan.Items.Clear()
            cmbKelurahan.Items.Clear()

            If cmbKota.SelectedIndex >= 0 Then
                cmbKecamatan.Items.Add("Kecamatan A")
                cmbKecamatan.Items.Add("Kecamatan B")
                cmbKecamatan.Items.Add("Kecamatan C")
            End If
        End If
    End Sub

    Private Sub cmbKecamatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKecamatan.SelectedIndexChanged
        If cmbKelurahan IsNot Nothing Then
            cmbKelurahan.Items.Clear()

            If cmbKecamatan.SelectedIndex >= 0 Then
                cmbKelurahan.Items.Add("Kelurahan X")
                cmbKelurahan.Items.Add("Kelurahan Y")
                cmbKelurahan.Items.Add("Kelurahan Z")
            End If
        End If
    End Sub

    ' Add employee to DataGridView
    Private Sub btnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles btnTambahKaryawan.Click
        If String.IsNullOrWhiteSpace(txtNIK_NPWP.Text) Then
            MessageBox.Show("NIK/NPWP karyawan harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIK_NPWP.Focus()
            Return
        End If



        ' Check if NIK/NPWP already exists
        For Each row As DataGridViewRow In dgvKaryawan.Rows
            If row.Cells("colNIK_NPWP").Value?.ToString() = txtNIK_NPWP.Text Then
                MessageBox.Show("NIK/NPWP sudah ada dalam daftar!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        ' Add to DataGridView
        dgvKaryawan.Rows.Add(txtNIK_NPWP.Text, "-")
        
        ' Clear inputs
        txtNIK_NPWP.Clear()
        txtNIK_NPWP.Focus()
    End Sub

    ' Remove selected employee
    Private Sub btnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles btnHapusKaryawan.Click
        If dgvKaryawan.SelectedRows.Count > 0 Then
            Dim result = MessageBox.Show("Hapus karyawan yang dipilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                dgvKaryawan.Rows.RemoveAt(dgvKaryawan.SelectedRows(0).Index)
            End If
        Else
            MessageBox.Show("Pilih karyawan yang akan dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Validate form
    Private Function ValidateForm() As Boolean
        ' Validate company name
        If String.IsNullOrWhiteSpace(txtNamaPT.Text) Then
            MessageBox.Show("Nama perusahaan harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaPT.Focus()
            Return False
        End If

        ' Validate email
        If String.IsNullOrWhiteSpace(txtEmailPT.Text) Then
            MessageBox.Show("Email perusahaan harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmailPT.Focus()
            Return False
        End If

        If Not IsValidEmail(txtEmailPT.Text) Then
            MessageBox.Show("Format email tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmailPT.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim regex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
            Return regex.IsMatch(email)
        Catch
            Return False
        End Try
    End Function

    ' Register button click
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If Not ValidateForm() Then Return

        Dim result = MessageBox.Show("Apakah data yang Anda masukkan sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Return

        Try
            Using conn = GetConnection()
                If OpenConnection(conn) Then
                    Dim transaction = conn.BeginTransaction()
                    Try
                        ' 1. Insert into tbl_Users
                        Dim defaultPassword = "PT123"
                        Dim hashedPassword = HashPassword(defaultPassword)

                        Dim queryUser = "INSERT INTO tbl_Users (Username, Password, Role, NamaLengkap, IsActive) VALUES (@Username, @Password, 'PEMBERIKERJA', @NamaLengkap, 1); SELECT SCOPE_IDENTITY();"
                        Dim userID As Integer
                        Using cmdUser As New SqlCommand(queryUser, conn, transaction)
                            cmdUser.Parameters.AddWithValue("@Username", txtEmailPT.Text)
                            cmdUser.Parameters.AddWithValue("@Password", hashedPassword)
                            cmdUser.Parameters.AddWithValue("@NamaLengkap", txtNamaPT.Text)
                            userID = Convert.ToInt32(cmdUser.ExecuteScalar())
                        End Using

                        ' 2. Insert into tbl_PemberiKerja
                        Dim queryPK = "INSERT INTO tbl_PemberiKerja " &
                            "(NamaPT, EmailPT, NIKKuasa, NamaKuasa, NoTelpKuasa, AlamatLengkap, Provinsi, Kota, Kecamatan, Kelurahan, KodePos, JumlahKaryawan) " &
                            "VALUES (@NamaPT, @EmailPT, @NIKKuasa, @NamaKuasa, @NoTelpKuasa, @AlamatLengkap, @Provinsi, @Kota, @Kecamatan, @Kelurahan, @KodePos, @JumlahKaryawan); SELECT SCOPE_IDENTITY();"

                        Dim pemberiKerjaID As Integer
                        Using cmdPK As New SqlCommand(queryPK, conn, transaction)
                            cmdPK.Parameters.AddWithValue("@NamaPT", txtNamaPT.Text)
                            cmdPK.Parameters.AddWithValue("@EmailPT", txtEmailPT.Text)
                            cmdPK.Parameters.AddWithValue("@NIKKuasa", If(String.IsNullOrWhiteSpace(txtNIKKuasa.Text), DBNull.Value, txtNIKKuasa.Text))
                            cmdPK.Parameters.AddWithValue("@NamaKuasa", If(String.IsNullOrWhiteSpace(txtNamaKuasa.Text), DBNull.Value, txtNamaKuasa.Text))
                            cmdPK.Parameters.AddWithValue("@NoTelpKuasa", If(String.IsNullOrWhiteSpace(txtNoTelpKuasa.Text), DBNull.Value, txtNoTelpKuasa.Text))
                            cmdPK.Parameters.AddWithValue("@AlamatLengkap", If(String.IsNullOrWhiteSpace(txtAlamatLengkap.Text), DBNull.Value, txtAlamatLengkap.Text))
                            cmdPK.Parameters.AddWithValue("@Provinsi", If(cmbProvinsi.SelectedItem Is Nothing, DBNull.Value, cmbProvinsi.SelectedItem.ToString()))
                            cmdPK.Parameters.AddWithValue("@Kota", If(cmbKota.SelectedItem Is Nothing, DBNull.Value, cmbKota.SelectedItem.ToString()))
                            cmdPK.Parameters.AddWithValue("@Kecamatan", If(cmbKecamatan.SelectedItem Is Nothing, DBNull.Value, cmbKecamatan.SelectedItem.ToString()))
                            cmdPK.Parameters.AddWithValue("@Kelurahan", If(cmbKelurahan.SelectedItem Is Nothing, DBNull.Value, cmbKelurahan.SelectedItem.ToString()))
                            cmdPK.Parameters.AddWithValue("@KodePos", If(String.IsNullOrWhiteSpace(txtKodePos.Text), DBNull.Value, txtKodePos.Text))
                            cmdPK.Parameters.AddWithValue("@JumlahKaryawan", dgvKaryawan.Rows.Count)
                            pemberiKerjaID = Convert.ToInt32(cmdPK.ExecuteScalar())
                        End Using

                        ' 3. Insert employees
                        For Each row As DataGridViewRow In dgvKaryawan.Rows
                            Dim queryKaryawan = "INSERT INTO tbl_KaryawanPemberiKerja (PemberiKerjaID, NIK_NPWP) VALUES (@PemberiKerjaID, @NIK_NPWP)"
                            Using cmdKaryawan As New SqlCommand(queryKaryawan, conn, transaction)
                                cmdKaryawan.Parameters.AddWithValue("@PemberiKerjaID", pemberiKerjaID)
                                cmdKaryawan.Parameters.AddWithValue("@NIK_NPWP", row.Cells("colNIK_NPWP").Value.ToString())
                                cmdKaryawan.ExecuteNonQuery()
                            End Using
                        Next

                        transaction.Commit()

                        MessageBox.Show(
                            $"Pendaftaran berhasil!{vbCrLf}Username: {txtEmailPT.Text}{vbCrLf}Password: {defaultPassword}{vbCrLf}Silakan login.",
                            "Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

                        Me.Close()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Cancel button
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim result = MessageBox.Show("Batalkan pendaftaran?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' Only allow numbers for NIK
    Private Sub txtNIKKuasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIKKuasa.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Only allow numbers for Kode Pos
    Private Sub txtKodePos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePos.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
