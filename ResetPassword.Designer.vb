<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelWrapper = New Panel()
        ButtonCancel = New Button()
        ButtonSubmit = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        LabelDescription = New Label()
        LabelTitle = New Label()
        PanelWrapper.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelWrapper
        ' 
        PanelWrapper.BackColor = Color.White
        PanelWrapper.Controls.Add(ButtonCancel)
        PanelWrapper.Controls.Add(ButtonSubmit)
        PanelWrapper.Controls.Add(TextBox4)
        PanelWrapper.Controls.Add(TextBox3)
        PanelWrapper.Controls.Add(TextBox2)
        PanelWrapper.Controls.Add(TextBox1)
        PanelWrapper.Controls.Add(Label4)
        PanelWrapper.Controls.Add(Label3)
        PanelWrapper.Controls.Add(Label2)
        PanelWrapper.Controls.Add(Label1)
        PanelWrapper.Controls.Add(LabelDescription)
        PanelWrapper.Controls.Add(LabelTitle)
        PanelWrapper.Dock = DockStyle.Fill
        PanelWrapper.Location = New Point(0, 0)
        PanelWrapper.Name = "PanelWrapper"
        PanelWrapper.Padding = New Padding(80, 60, 80, 60)
        PanelWrapper.Size = New Size(1023, 562)
        PanelWrapper.TabIndex = 0
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCancel.BackColor = Color.White
        ButtonCancel.Cursor = Cursors.Hand
        ButtonCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(214), CByte(224))
        ButtonCancel.FlatStyle = FlatStyle.Flat
        ButtonCancel.Font = New Font("Dubai", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonCancel.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        ButtonCancel.Location = New Point(580, 820)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(180, 60)
        ButtonCancel.TabIndex = 11
        ButtonCancel.Text = "Batal"
        ButtonCancel.UseVisualStyleBackColor = False
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonSubmit.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        ButtonSubmit.Cursor = Cursors.Hand
        ButtonSubmit.FlatAppearance.BorderSize = 0
        ButtonSubmit.FlatStyle = FlatStyle.Flat
        ButtonSubmit.Font = New Font("Dubai", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSubmit.ForeColor = Color.White
        ButtonSubmit.Location = New Point(780, 820)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(185, 60)
        ButtonSubmit.TabIndex = 10
        ButtonSubmit.Text = "Kirim tautan"
        ButtonSubmit.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Dubai", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(200, 675)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Konfirmasi password baru"
        TextBox4.Size = New Size(765, 45)
        TextBox4.TabIndex = 9
        TextBox4.UseSystemPasswordChar = True
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Dubai", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(200, 565)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Masukkan password baru"
        TextBox3.Size = New Size(765, 45)
        TextBox3.TabIndex = 8
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Dubai", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(200, 455)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Masukkan email terdaftar"
        TextBox2.Size = New Size(765, 45)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Dubai", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(200, 345)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Masukkan username"
        TextBox1.Size = New Size(765, 45)
        TextBox1.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Dubai", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label4.Location = New Point(200, 635)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 36)
        Label4.TabIndex = 5
        Label4.Text = "Konfirmasi password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Dubai", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label3.Location = New Point(200, 525)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 36)
        Label3.TabIndex = 4
        Label3.Text = "Password baru"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Dubai", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label2.Location = New Point(200, 415)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 36)
        Label2.TabIndex = 3
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label1.Location = New Point(200, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 36)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' LabelDescription
        ' 
        LabelDescription.Font = New Font("Dubai", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelDescription.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelDescription.Location = New Point(200, 160)
        LabelDescription.MaximumSize = New Size(765, 0)
        LabelDescription.Name = "LabelDescription"
        LabelDescription.Size = New Size(765, 75)
        LabelDescription.TabIndex = 0
        LabelDescription.Text = "Masukkan data yang terdaftar untuk mendapatkan tautan pemulihan password Anda."
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Dubai", 28.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelTitle.Location = New Point(200, 80)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(372, 95)
        LabelTitle.TabIndex = 1
        LabelTitle.Text = "Reset password"
        ' 
        ' ResetPassword
        ' 
        AcceptButton = ButtonSubmit
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(252))
        CancelButton = ButtonCancel
        ClientSize = New Size(1154, 1002)
        Controls.Add(PanelWrapper)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        FormBorderStyle = FormBorderStyle.Sizable
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = True
        MinimumSize = New Size(1154, 1002)
        Name = "ResetPassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Coretax | Reset Password"
        WindowState = FormWindowState.Maximized
        PanelWrapper.ResumeLayout(False)
        PanelWrapper.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonSubmit As Button
End Class
