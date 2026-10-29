Imports System.Data.SqlClient

Public Class Login
    ' Variable untuk Placeholder text
    Dim userPlaceholder As String = "Masukkan username"
    Dim passPlaceholder As String = "Masukkan password"

    Private Sub SetupPlaceholder(txt As TextBox, placeText As String)
        txt.Text = placeText
        txt.ForeColor = Color.Gray
        ' Jika textbox password, matikan dulu bintang-bintangnya agar tulisan terbaca
        If txt Is txtpassword Then txt.PasswordChar = ControlChars.NullChar
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Auto-fix database schema if needed
        Module1.CheckAndFixDatabase()

        SetupPlaceholder(txtusername, userPlaceholder)
        SetupPlaceholder(txtpassword, passPlaceholder)
        LabelHeroTagline.Focus() ' Focus away from textboxes
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        If txtusername.Text = userPlaceholder Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        If txtusername.Text = "" Then
            SetupPlaceholder(txtusername, userPlaceholder)
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        If txtpassword.Text = passPlaceholder Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.Black
            txtpassword.PasswordChar = "*"c ' Nyalakan bintang password
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        If txtpassword.Text = "" Then
            SetupPlaceholder(txtpassword, passPlaceholder)
        End If
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ' Validasi input kosong
        If txtusername.Text = userPlaceholder Or txtpassword.Text = passPlaceholder Then
            MessageBox.Show("Harap isi Username dan Password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As SqlConnection = GetConnection()
                If OpenConnection(conn) Then
                    ' Query cek user, password, dan status aktif
                    ' Cek password plain text ATAU password hash
                    Dim query As String = "SELECT Role, NamaLengkap, IsActive FROM tbl_Users WHERE Username = @u AND (Password = @p OR Password = @hp)"

                    Using cmd As New SqlCommand(query, conn)
                        ' Gunakan parameter untuk mencegah SQL Injection
                        cmd.Parameters.AddWithValue("@u", txtusername.Text)
                        cmd.Parameters.AddWithValue("@p", txtpassword.Text) ' Plain text check
                        cmd.Parameters.AddWithValue("@hp", Module1.HashPassword(txtpassword.Text)) ' Hashed check

                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Ambil data user
                                Dim role As String = reader("Role").ToString()
                                Dim nama As String = reader("NamaLengkap").ToString()
                                Dim isActive As Boolean = Convert.ToBoolean(reader("IsActive"))

                                ' 1. Cek apakah akun aktif?
                                If Not isActive Then
                                    MessageBox.Show("Akun Anda telah dinonaktifkan. Hubungi Admin.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If

                                ' 2. Login Berhasil - Arahkan sesuai Role
                                MessageBox.Show("Selamat Datang, " & nama, "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                Module1.CurrentUserNIK = txtusername.Text ' Simpan NIK user yang login
                                Me.Hide() ' Sembunyikan form login

                                Select Case role
                                    Case "ADMIN"
                                        Dim frm As New Admin.Dashboard_AD()
                                        frm.Show()
                                    Case "WAJIBPAJAK"
                                        Dim frm As New Dashboard()
                                        frm.Show()
                                    Case "PEMBERIKERJA"
                                        Dim frm As New Dashboard_PK()
                                        frm.Show()
                                End Select

                            Else
                                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan koneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New Kategori_Register()
        frm.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim frm As New ResetPassword()
        frm.ShowDialog()
    End Sub
End Class
