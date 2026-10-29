Imports System.Data.SqlClient

Public Class ResetPassword
    ' Connection string handled by Module1

    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterPanel()
    End Sub

    Private Sub ResetPassword_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterPanel()
    End Sub

    Private Sub CenterPanel()
        If PanelContent IsNot Nothing Then
            PanelContent.Location = New Point((Me.ClientSize.Width - PanelContent.Width) \ 2, (Me.ClientSize.Height - PanelContent.Height) \ 2)
        End If
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        ' 1. Validate inputs
        If String.IsNullOrWhiteSpace(txtNIK.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtNewPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MessageBox.Show("Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password baru dan konfirmasi password tidak cocok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Verify User and Update Password
        Using conn As SqlConnection = GetConnection()
            Try
                If OpenConnection(conn) Then
                    ' Check if NIK and Email match a user
                    ' Join tbl_Users and tbl_WajibPajak
                    ' u.Username = wp.NIK (because NIK is Username)
                    Dim queryVerify As String = "SELECT COUNT(*) FROM tbl_Users u " &
                                                "JOIN tbl_WajibPajak wp ON u.Username = wp.NIK " &
                                                "WHERE u.Username = @Username AND wp.Email = @Email"

                    Using cmdVerify As New SqlCommand(queryVerify, conn)
                        cmdVerify.Parameters.AddWithValue("@Username", txtNIK.Text)
                        cmdVerify.Parameters.AddWithValue("@Email", txtEmail.Text)

                        Dim count As Integer = Convert.ToInt32(cmdVerify.ExecuteScalar())

                        If count = 0 Then
                            MessageBox.Show("Data tidak ditemukan. Pastikan Username (NIK) dan Email benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using

                    ' Update Password
                    Dim queryUpdate As String = "UPDATE tbl_Users SET Password = @Password WHERE Username = @Username"
                    Using cmdUpdate As New SqlCommand(queryUpdate, conn)
                        ' Use HashPassword for security
                        cmdUpdate.Parameters.AddWithValue("@Password", Module1.HashPassword(txtNewPassword.Text))
                        cmdUpdate.Parameters.AddWithValue("@Username", txtNIK.Text)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Password berhasil direset. Silakan login dengan password baru.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LabelDescription_Click(sender As Object, e As EventArgs) Handles LabelDescription.Click

    End Sub
End Class