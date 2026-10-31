Imports System.Data.SqlClient

Public Class Register

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ComboBox items
        cmbstatuspernikahan.Items.AddRange(New String() {"Belum Menikah", "Menikah", "Cerai"})
        cmbStatusHubungan.Items.AddRange(New String() {"Kepala Keluarga", "Istri", "Anak"})
        cmbNegaraAsal.Items.AddRange(New String() {"Indonesia", "Asing"})
        cmbJenisKelamin.Items.AddRange(New String() {"Laki-laki", "Perempuan"})
        cmbPenghasilan.Items.AddRange(New String() {"< 4.5 Juta", "4.5 - 10 Juta", "10 - 20 Juta", "> 20 Juta"})
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(txtNIK.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Mohon lengkapi NIK, Nama, dan Password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate NIK (must be 16 digits)
        If Not IsValidNIK(txtNIK.Text) Then
            MessageBox.Show("NIK harus berisi 16 digit angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIK.Focus()
            Return
        End If

        ' Validate Email
        If Not String.IsNullOrWhiteSpace(txtEmail.Text) AndAlso Not IsValidEmail(txtEmail.Text) Then
            MessageBox.Show("Format email tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        ' Validate Phone Number (must be 12 digits)
        If Not String.IsNullOrWhiteSpace(txtNoHP.Text) Then
            Dim cleanPhone As String = txtNoHP.Text.Replace("-", "").Replace(" ", "").Replace("+", "")
            If cleanPhone.Length <> 12 OrElse Not IsNumeric(cleanPhone) Then
                MessageBox.Show("Nomor HP harus berisi 12 digit angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNoHP.Focus()
                Return
            End If
        End If

        ' Validate Password Length
        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Password minimal 6 karakter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        Try
            ' Create Model
            Dim wp As New WajibPajakModel()
            wp.NIK = txtNIK.Text
            wp.NPWP = txtNIK.Text ' NIK is used as NPWP per user request
            wp.NamaLengkap = txtNama.Text
            wp.Password = txtPassword.Text
            wp.Email = txtEmail.Text
            wp.TempatLahir = txtTempatLahir.Text
            wp.TempatLahir = txtTempatLahir.Text
            ' Parse Tanggal Lahir from DateTimePicker
            wp.TanggalLahir = txtTanggalLahir.Value
            wp.StatusPernikahan = If(cmbstatuspernikahan.SelectedItem IsNot Nothing, cmbstatuspernikahan.SelectedItem.ToString(), "")
            wp.StatusHubunganKeluarga = If(cmbStatusHubungan.SelectedItem IsNot Nothing, cmbStatusHubungan.SelectedItem.ToString(), "")
            wp.NegaraAsal = If(cmbNegaraAsal.SelectedItem IsNot Nothing, cmbNegaraAsal.SelectedItem.ToString(), "")
            wp.JenisKelamin = If(cmbJenisKelamin.SelectedItem IsNot Nothing, cmbJenisKelamin.SelectedItem.ToString(), "")
            wp.Pekerjaan = txtPekerjaan.Text
            wp.TempatKerja = txtTempatKerja.Text
            wp.Alamat = txtAlamat.Text
            wp.NoHandphone = txtNoHP.Text

            ' Map Income Range to Value
            Dim income As Decimal = 0
            If cmbPenghasilan.SelectedItem IsNot Nothing Then
                Select Case cmbPenghasilan.SelectedItem.ToString()
                    Case "< 4.5 Juta"
                        income = 4000000
                    Case "4.5 - 10 Juta"
                        income = 7500000
                    Case "10 - 20 Juta"
                        income = 15000000
                    Case "> 20 Juta"
                        income = 25000000
                End Select
            End If
            wp.PenghasilanPerBulan = income

            ' Save to Database
            Dim newId As Integer = SimpanWajibPajak(wp)

            If newId > 0 Then
                MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Registrasi gagal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Registrasi gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Reset controls
        txtNIK.Clear()
        txtNama.Clear()
        txtTempatLahir.Clear()
        txtTanggalLahir.Value = DateTime.Now
        txtNoHP.Clear()
        txtEmail.Clear()
        txtPekerjaan.Clear()
        txtTempatKerja.Clear()
        txtAlamat.Clear()
        txtPassword.Clear()
        cmbstatuspernikahan.SelectedIndex = -1
        cmbStatusHubungan.SelectedIndex = -1
        cmbNegaraAsal.SelectedIndex = -1
        cmbJenisKelamin.SelectedIndex = -1
        cmbPenghasilan.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class