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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        PanelHero = New Panel()
        PictureBox1 = New PictureBox()
        LabelHeroTagline = New Label()
        LabelHeroTitle = New Label()
        PanelLogin = New Panel()
        PanelLoginCard = New Panel()
        ButtonLogin = New Button()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        txtpassword = New TextBox()
        Label2 = New Label()
        txtusername = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        PanelHero.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelLogin.SuspendLayout()
        PanelLoginCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHero
        ' 
        PanelHero.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        PanelHero.Controls.Add(PictureBox1)
        PanelHero.Controls.Add(LabelHeroTagline)
        PanelHero.Controls.Add(LabelHeroTitle)
        PanelHero.Dock = DockStyle.Left
        PanelHero.Location = New Point(0, 0)
        PanelHero.Name = "PanelHero"
        PanelHero.Padding = New Padding(40)
        PanelHero.Size = New Size(1173, 900)
        PanelHero.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(302, 311)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(359, 314)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' LabelHeroTagline
        ' 
        LabelHeroTagline.Anchor = AnchorStyles.None
        LabelHeroTagline.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelHeroTagline.ForeColor = Color.FromArgb(CByte(214), CByte(230), CByte(255))
        LabelHeroTagline.Location = New Point(302, 763)
        LabelHeroTagline.Name = "LabelHeroTagline"
        LabelHeroTagline.Size = New Size(420, 80)
        LabelHeroTagline.TabIndex = 2
        LabelHeroTagline.Text = "Kelola pajak Anda dengan mudah, cepat, dan efisien"
        LabelHeroTagline.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelHeroTitle
        ' 
        LabelHeroTitle.Anchor = AnchorStyles.None
        LabelHeroTitle.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHeroTitle.ForeColor = Color.White
        LabelHeroTitle.Location = New Point(242, 605)
        LabelHeroTitle.Name = "LabelHeroTitle"
        LabelHeroTitle.Size = New Size(533, 158)
        LabelHeroTitle.TabIndex = 1
        LabelHeroTitle.Text = "TaxEase"
        LabelHeroTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelLogin.Controls.Add(PanelLoginCard)
        PanelLogin.Dock = DockStyle.Fill
        PanelLogin.Location = New Point(1173, 0)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Padding = New Padding(80, 100, 80, 100)
        PanelLogin.Size = New Size(487, 900)
        PanelLogin.TabIndex = 1
        ' 
        ' PanelLoginCard
        ' 
        PanelLoginCard.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelLoginCard.Controls.Add(ButtonLogin)
        PanelLoginCard.Controls.Add(LinkLabel2)
        PanelLoginCard.Controls.Add(LinkLabel1)
        PanelLoginCard.Controls.Add(Label4)
        PanelLoginCard.Controls.Add(txtpassword)
        PanelLoginCard.Controls.Add(Label2)
        PanelLoginCard.Controls.Add(txtusername)
        PanelLoginCard.Controls.Add(Label1)
        PanelLoginCard.Controls.Add(Label3)
        PanelLoginCard.Dock = DockStyle.Fill
        PanelLoginCard.Location = New Point(80, 100)
        PanelLoginCard.Name = "PanelLoginCard"
        PanelLoginCard.Padding = New Padding(50)
        PanelLoginCard.Size = New Size(327, 700)
        PanelLoginCard.TabIndex = 0
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ButtonLogin.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        ButtonLogin.Cursor = Cursors.Hand
        ButtonLogin.FlatAppearance.BorderSize = 0
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonLogin.ForeColor = Color.White
        ButtonLogin.Location = New Point(53, 600)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(191, 50)
        ButtonLogin.TabIndex = 4
        ButtonLogin.Text = "Masuk"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        LinkLabel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel2.LinkColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        LinkLabel2.Location = New Point(30, 545)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(214, 37)
        LinkLabel2.TabIndex = 8
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Lupa kata sandi?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.LinkColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        LinkLabel1.Location = New Point(34, 710)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(223, 37)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Daftar sekarang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label4.Location = New Point(34, 670)
        Label4.Name = "Label4"
        Label4.Size = New Size(247, 37)
        Label4.TabIndex = 5
        Label4.Text = "Belum punya akun?"
        ' 
        ' txtpassword
        ' 
        txtpassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtpassword.BorderStyle = BorderStyle.FixedSingle
        txtpassword.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(50, 480)
        txtpassword.Name = "txtpassword"
        txtpassword.PlaceholderText = "Masukkan kata sandi"
        txtpassword.Size = New Size(191, 47)
        txtpassword.TabIndex = 2
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        Label2.Location = New Point(34, 430)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 37)
        Label2.TabIndex = 2
        Label2.Text = "Kata Sandi"
        ' 
        ' txtusername
        ' 
        txtusername.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtusername.Location = New Point(50, 370)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Masukkan username atau NIK"
        txtusername.Size = New Size(191, 47)
        txtusername.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        Label1.Location = New Point(34, 330)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 37)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        Label3.Location = New Point(12, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(600, 100)
        Label3.TabIndex = 9
        Label3.Text = "Selamat Datang"
        ' 
        ' Login
        ' 
        AcceptButton = ButtonLogin
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        ClientSize = New Size(1660, 900)
        Controls.Add(PanelLogin)
        Controls.Add(PanelHero)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MinimumSize = New Size(1200, 900)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login | Sistem Pajak TaxEase"
        WindowState = FormWindowState.Maximized
        PanelHero.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelLogin.ResumeLayout(False)
        PanelLoginCard.ResumeLayout(False)
        PanelLoginCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelHero As Panel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents LabelHeroTagline As Label
    Friend WithEvents LabelHeroTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelLoginCard As Panel

End Class
