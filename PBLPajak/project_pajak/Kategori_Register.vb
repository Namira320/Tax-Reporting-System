Public Class Kategori_Register

    Private Sub Kategori_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, Label1.Click, Label3.Click, PictureBox1.Click
        ' Handle click event untuk card Perorangan
        MessageBox.Show("Anda memilih registrasi untuk Perorangan", "Pilihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim frm As New Register()
        frm.ShowDialog()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click, Label2.Click, PictureBox2.Click
        ' Handle click event untuk card Badan
        MessageBox.Show("Anda memilih registrasi untuk Badan", "Pilihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim frm As New Register_PK
        frm.ShowDialog
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Me.Close()
    End Sub
End Class