Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics
Public Class Login
    ' 1. KONEKSI DATABASE
    ' Ganti 'Data Source' sesuai nama server SQL kamu (bisa dilihat di Server Explorer)
    Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ThinkPad\Downloads\projectpajak\project_pajak\project_pajak\Database1.mdf;Integrated Security=True"
    ' Variable untuk Placeholder text
    Dim userPlaceholder As String = "Masukkan username"
    Dim passPlaceholder As String = "Masukkan password"
    Private Sub SetupPlaceholder(txt As TextBox, placeText As String)
        txt.Text = placeText
        txt.ForeColor = Color.Gray
        ' Jika textbox password, matikan dulu bintang-bintangnya agar tulisan terbaca
        If txt Is txtpassword Then txt.PasswordChar = ControlChars.NullChar
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        If txtusername.Text = userPlaceholder Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.Black
        End If
    End Sub

    ' Event saat kursor keluar dari Username
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        If txtusername.Text = "" Then
            SetupPlaceholder(txtusername, userPlaceholder)
        End If
    End Sub

    ' Event saat Password diklik (Logic khusus karena ada karakter bintang *)
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
    Private Sub LabelHeroTitle_Click(sender As Object, e As EventArgs) Handles LabelHeroTitle.Click

    End Sub

    Private Sub PanelLogin_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogin.Paint

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Buka Form Registrasi Wajib Pajak di sini.", "Info")
        Dim frm As New Register()
        frm.ShowDialog()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text = "" Then
            SetupPlaceholder(txtpassword, passPlaceholder)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ' Validasi input kosong
        If txtusername.Text = userPlaceholder Or txtpassword.Text = passPlaceholder Then
            MessageBox.Show("Harap isi Username dan Password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' Query cek user, password, dan status aktif
                Dim query As String = "SELECT Role, NamaLengkap, IsActive FROM tbl_Users WHERE Username = @u AND Password = @p"

                Using cmd As New SqlCommand(query, conn)
                    ' Gunakan parameter untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("@u", txtusername.Text)
                    cmd.Parameters.AddWithValue("@p", txtpassword.Text)

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

                            Me.Hide() ' Sembunyikan form login

                            Select Case role
                                Case "ADMIN"
                                    ' Pastikan kamu sudah buat Form: frmAdmin_Main
                                    ' Dim frm As New frmAdmin_Main()
                                    ' frm.Show()
                                    MessageBox.Show("Masuk ke Dashboard Admin") ' Hapus ini jika form sudah ada

                                Case "WAJIBPAJAK"
                                    ' Pastikan kamu sudah buat Form: frmWP_Main
                                    Dim frm As New Dashboard()
                                    frm.Show()
                                    MessageBox.Show("Masuk ke Dashboard Wajib Pajak")

                                Case "PEMBERIKERJA"
                                    ' Pastikan kamu sudah buat Form: frmPK_Main
                                    ''Dim frm As New frmPK_Main()
                                    'frm.Show()
                                    MessageBox.Show("Masuk ke Dashboard Pemberi Kerja")
                            End Select

                        Else
                            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan koneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
