<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResetPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelWrapper = New Panel()
        PanelContent = New Panel()
        ButtonCancel = New Button()
        ButtonSubmit = New Button()
        txtConfirmPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtEmail = New TextBox()
        txtNIK = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        LabelDescription = New Label()
        LabelTitle = New Label()
        PanelWrapper.SuspendLayout()
        PanelContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelWrapper
        ' 
        PanelWrapper.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelWrapper.Controls.Add(PanelContent)
        PanelWrapper.Dock = DockStyle.Fill
        PanelWrapper.Location = New Point(0, 0)
        PanelWrapper.Name = "PanelWrapper"
        PanelWrapper.Size = New Size(1154, 1002)
        PanelWrapper.TabIndex = 0
        ' 
        ' PanelContent
        ' 
        PanelContent.BackColor = Color.Transparent
        PanelContent.Controls.Add(ButtonCancel)
        PanelContent.Controls.Add(ButtonSubmit)
        PanelContent.Controls.Add(txtConfirmPassword)
        PanelContent.Controls.Add(txtNewPassword)
        PanelContent.Controls.Add(txtEmail)
        PanelContent.Controls.Add(txtNIK)
        PanelContent.Controls.Add(Label4)
        PanelContent.Controls.Add(Label3)
        PanelContent.Controls.Add(Label2)
        PanelContent.Controls.Add(Label1)
        PanelContent.Controls.Add(LabelDescription)
        PanelContent.Controls.Add(LabelTitle)
        PanelContent.Location = New Point(177, 60)
        PanelContent.Name = "PanelContent"
        PanelContent.Size = New Size(800, 850)
        PanelContent.TabIndex = 0
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.BackColor = Color.White
        ButtonCancel.Cursor = Cursors.Hand
        ButtonCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        ButtonCancel.FlatAppearance.BorderSize = 2
        ButtonCancel.FlatStyle = FlatStyle.Flat
        ButtonCancel.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        ButtonCancel.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        ButtonCancel.Location = New Point(390, 700)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(180, 50)
        ButtonCancel.TabIndex = 11
        ButtonCancel.Text = "Batal"
        ButtonCancel.UseVisualStyleBackColor = False
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        ButtonSubmit.Cursor = Cursors.Hand
        ButtonSubmit.FlatAppearance.BorderSize = 0
        ButtonSubmit.FlatStyle = FlatStyle.Flat
        ButtonSubmit.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        ButtonSubmit.ForeColor = Color.White
        ButtonSubmit.Location = New Point(590, 700)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(180, 50)
        ButtonSubmit.TabIndex = 10
        ButtonSubmit.Text = "Kirim"
        ButtonSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BackColor = Color.White
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Font("Segoe UI", 12.0F)
        txtConfirmPassword.Location = New Point(30, 600)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Ulangi password baru"
        txtConfirmPassword.Size = New Size(740, 39)
        txtConfirmPassword.TabIndex = 9
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.BackColor = Color.White
        txtNewPassword.BorderStyle = BorderStyle.FixedSingle
        txtNewPassword.Font = New Font("Segoe UI", 12.0F)
        txtNewPassword.Location = New Point(30, 490)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PlaceholderText = "Masukkan password baru"
        txtNewPassword.Size = New Size(740, 39)
        txtNewPassword.TabIndex = 8
        txtNewPassword.UseSystemPasswordChar = True
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 12.0F)
        txtEmail.Location = New Point(30, 380)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Masukkan email terdaftar (contoh: user@mail.com)"
        txtEmail.Size = New Size(740, 39)
        txtEmail.TabIndex = 7
        ' 
        ' txtNIK
        ' 
        txtNIK.BackColor = Color.White
        txtNIK.BorderStyle = BorderStyle.FixedSingle
        txtNIK.Font = New Font("Segoe UI", 12.0F)
        txtNIK.Location = New Point(30, 270)
        txtNIK.Name = "txtNIK"
        txtNIK.PlaceholderText = "Masukkan NIK / Username"
        txtNIK.Size = New Size(740, 39)
        txtNIK.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Label4.Location = New Point(30, 565)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 30)
        Label4.TabIndex = 5
        Label4.Text = "Konfirmasi Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Label3.Location = New Point(30, 455)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 30)
        Label3.TabIndex = 4
        Label3.Text = "Password Baru"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Label2.Location = New Point(30, 345)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 30)
        Label2.TabIndex = 3
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Label1.Location = New Point(30, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 30)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' LabelDescription
        ' 
        LabelDescription.AutoSize = True
        LabelDescription.Font = New Font("Segoe UI", 11.0F)
        LabelDescription.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        LabelDescription.Location = New Point(30, 150)
        LabelDescription.MaximumSize = New Size(740, 0)
        LabelDescription.Name = "LabelDescription"
        LabelDescription.Size = New Size(684, 30)
        LabelDescription.TabIndex = 0
        LabelDescription.Text = "Masukkan data yang terdaftar untuk mendapatkan tautan pemulihan password Anda."
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        LabelTitle.Location = New Point(20, 50)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(434, 74)
        LabelTitle.TabIndex = 1
        LabelTitle.Text = "Reset Password"
        ' 
        ' ResetPassword
        ' 
        AcceptButton = ButtonSubmit
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = ButtonCancel
        ClientSize = New Size(1154, 1002)
        Controls.Add(PanelWrapper)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        Margin = New Padding(4, 3, 4, 3)
        MinimumSize = New Size(800, 800)
        Name = "ResetPassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TaxEase | Reset Password"
        WindowState = FormWindowState.Maximized
        PanelWrapper.ResumeLayout(False)
        PanelContent.ResumeLayout(False)
        PanelContent.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonSubmit As Button
End Class
