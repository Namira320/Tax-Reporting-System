<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PanelHero = New Panel()
        LabelHeroTagline = New Label()
        LabelHeroTitle = New Label()
        PanelLogin = New Panel()
        GroupBoxLogin = New GroupBox()
        LinkLabel2 = New LinkLabel()
        CheckBoxRemember = New CheckBox()
        ButtonLogin = New Button()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        LinkLabel1 = New LinkLabel()
        LabelTitle = New Label()
        PanelHero.SuspendLayout()
        PanelLogin.SuspendLayout()
        GroupBoxLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHero
        ' 
        PanelHero.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        PanelHero.Controls.Add(LabelHeroTagline)
        PanelHero.Controls.Add(LabelHeroTitle)
        PanelHero.Dock = DockStyle.Left
        PanelHero.Location = New Point(0, 0)
        PanelHero.Name = "PanelHero"
        PanelHero.Size = New Size(761, 946)
        PanelHero.TabIndex = 0
        ' 
        ' LabelHeroTagline
        ' 
        LabelHeroTagline.Anchor = AnchorStyles.None
        LabelHeroTagline.Font = New Font("Dubai", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelHeroTagline.ForeColor = Color.FromArgb(CByte(214), CByte(230), CByte(255))
        LabelHeroTagline.Location = New Point(120, 530)
        LabelHeroTagline.MaximumSize = New Size(520, 0)
        LabelHeroTagline.Name = "LabelHeroTagline"
        LabelHeroTagline.Size = New Size(520, 80)
        LabelHeroTagline.TabIndex = 1
        LabelHeroTagline.Text = "Sistem informasi pajak modern untuk memudahkan pelaporan dan pengelolaan perpajakan Anda."
        LabelHeroTagline.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelHeroTitle
        ' 
        LabelHeroTitle.Anchor = AnchorStyles.None
        LabelHeroTitle.Font = New Font("Dubai", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHeroTitle.ForeColor = Color.White
        LabelHeroTitle.Location = New Point(80, 380)
        LabelHeroTitle.Name = "LabelHeroTitle"
        LabelHeroTitle.Size = New Size(600, 120)
        LabelHeroTitle.TabIndex = 0
        LabelHeroTitle.Text = "Sistem Pajak CoreTax"
        LabelHeroTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelLogin.Controls.Add(LinkLabel1)
        PanelLogin.Controls.Add(Label4)
        PanelLogin.Controls.Add(GroupBoxLogin)
        PanelLogin.Controls.Add(LabelTitle)
        PanelLogin.Dock = DockStyle.Fill
        PanelLogin.Location = New Point(761, 0)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Padding = New Padding(60, 80, 60, 80)
        PanelLogin.Size = New Size(1141, 946)
        PanelLogin.TabIndex = 1
        ' 
        ' GroupBoxLogin
        ' 
        GroupBoxLogin.Anchor = AnchorStyles.None
        GroupBoxLogin.BackColor = Color.White
        GroupBoxLogin.Controls.Add(LinkLabel2)
        GroupBoxLogin.Controls.Add(CheckBoxRemember)
        GroupBoxLogin.Controls.Add(ButtonLogin)
        GroupBoxLogin.Controls.Add(txtpassword)
        GroupBoxLogin.Controls.Add(txtusername)
        GroupBoxLogin.Controls.Add(Label2)
        GroupBoxLogin.Controls.Add(Label1)
        GroupBoxLogin.Font = New Font("Dubai", 10.0F, FontStyle.Bold)
        GroupBoxLogin.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        GroupBoxLogin.Location = New Point(170, 320)
        GroupBoxLogin.Margin = New Padding(3, 4, 3, 4)
        GroupBoxLogin.Name = "GroupBoxLogin"
        GroupBoxLogin.Padding = New Padding(48, 35, 48, 35)
        GroupBoxLogin.Size = New Size(800, 410)
        GroupBoxLogin.TabIndex = 0
        GroupBoxLogin.TabStop = False
        GroupBoxLogin.Text = "Informasi Login"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Dubai", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel2.LinkColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        LinkLabel2.Location = New Point(600, 254)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(134, 30)
        LinkLabel2.TabIndex = 6
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Lupa password?"
        ' 
        ' CheckBoxRemember
        ' 
        CheckBoxRemember.AutoSize = True
        CheckBoxRemember.Font = New Font("Dubai", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBoxRemember.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        CheckBoxRemember.Location = New Point(48, 254)
        CheckBoxRemember.Name = "CheckBoxRemember"
        CheckBoxRemember.Size = New Size(112, 34)
        CheckBoxRemember.TabIndex = 5
        CheckBoxRemember.Text = "Ingat saya"
        CheckBoxRemember.UseVisualStyleBackColor = True
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        ButtonLogin.Cursor = Cursors.Hand
        ButtonLogin.FlatAppearance.BorderSize = 0
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.Font = New Font("Dubai", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonLogin.ForeColor = Color.White
        ButtonLogin.Location = New Point(48, 305)
        ButtonLogin.Margin = New Padding(3, 4, 3, 4)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(704, 60)
        ButtonLogin.TabIndex = 4
        ButtonLogin.Text = "Masuk"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.BorderStyle = BorderStyle.FixedSingle
        txtpassword.Font = New Font("Dubai", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(48, 199)
        txtpassword.Margin = New Padding(3, 4, 3, 4)
        txtpassword.Name = "txtpassword"
        txtpassword.PlaceholderText = "Masukkan password"
        txtpassword.Size = New Size(704, 41)
        txtpassword.TabIndex = 3
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' txtusername
        ' 
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.Font = New Font("Dubai", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtusername.Location = New Point(48, 103)
        txtusername.Margin = New Padding(3, 4, 3, 4)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Masukkan NPWP"
        txtusername.Size = New Size(704, 41)
        txtusername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label2.Location = New Point(48, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 30)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label1.Location = New Point(48, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 30)
        Label1.TabIndex = 0
        Label1.Text = "NPWP"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Font = New Font("Dubai", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label4.Location = New Point(393, 790)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 32)
        Label4.TabIndex = 1
        Label4.Text = "Belum punya akun?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        LinkLabel1.Anchor = AnchorStyles.Bottom
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Dubai", 9.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.LinkColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        LinkLabel1.Location = New Point(553, 790)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(135, 32)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Daftar sekarang"
        ' 
        ' LabelTitle
        ' 
        LabelTitle.Anchor = AnchorStyles.Top
        LabelTitle.Font = New Font("Dubai", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        LabelTitle.Location = New Point(320, 200)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(500, 70)
        LabelTitle.TabIndex = 3
        LabelTitle.Text = "Selamat Datang"
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Login
        ' 
        AcceptButton = ButtonLogin
        AutoScaleDimensions = New SizeF(10.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        ClientSize = New Size(1902, 946)
        Controls.Add(PanelLogin)
        Controls.Add(PanelHero)
        Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.Sizable
        Margin = New Padding(4)
        MaximizeBox = True
        MinimumSize = New Size(1480, 946)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Coretax | Login"
        WindowState = FormWindowState.Maximized
        PanelHero.ResumeLayout(False)
        PanelLogin.ResumeLayout(False)
        PanelLogin.PerformLayout()
        GroupBoxLogin.ResumeLayout(False)
        GroupBoxLogin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHero As Panel
    Friend WithEvents LabelHeroTitle As Label
    Friend WithEvents LabelHeroTagline As Label
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents GroupBoxLogin As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents CheckBoxRemember As CheckBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
