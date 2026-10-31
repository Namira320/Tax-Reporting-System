<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        MenuStrip1 = New MenuStrip()
        ProfilToolStripMenuItem = New ToolStripMenuItem()
        SimulasiToolStripMenuItem = New ToolStripMenuItem()
        SPTToolStripMenuItem = New ToolStripMenuItem()
        PengisianSPTToolStripMenuItem = New ToolStripMenuItem()
        RiwayatPelaporanToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        PanelContent = New Panel()
        GroupBoxRiwayat = New GroupBox()
        DataGridViewRiwayat = New DataGridView()
        ColTanggal = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        ColJumlah = New DataGridViewTextBoxColumn()
        ColStatus = New DataGridViewTextBoxColumn()
        GroupBoxTrenPembayaran = New GroupBox()
        PanelChartTren = New Panel()
        GroupBoxPerbandingan = New GroupBox()
        PanelChartPerbandingan = New Panel()
        PanelCards = New Panel()
        CardStatusPajak = New Panel()
        LabelStatusValue = New Label()
        LabelStatusTitle = New Label()
        CardPajakDipotong = New Panel()
        LabelPajakDipotongValue = New Label()
        LabelPajakDipotongTitle = New Label()
        CardPajakTerutang = New Panel()
        LabelPajakTerutangValue = New Label()
        LabelPajakTerutangTitle = New Label()
        LabelTitle = New Label()
        ButtonNotification = New Button()
        LabelNotificationBadge = New Label()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem1 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        PanelContent.SuspendLayout()
        GroupBoxRiwayat.SuspendLayout()
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxTrenPembayaran.SuspendLayout()
        GroupBoxPerbandingan.SuspendLayout()
        PanelCards.SuspendLayout()
        CardStatusPajak.SuspendLayout()
        CardPajakDipotong.SuspendLayout()
        CardPajakTerutang.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProfilToolStripMenuItem, SimulasiToolStripMenuItem, SPTToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 4, 0, 4)
        MenuStrip1.Size = New Size(1400, 37)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ProfilToolStripMenuItem
        ' 
        ProfilToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {KeluarToolStripMenuItem, KeluarToolStripMenuItem1})
        ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        ProfilToolStripMenuItem.Size = New Size(69, 29)
        ProfilToolStripMenuItem.Text = "&Profil"
        ' 
        ' SimulasiToolStripMenuItem
        ' 
        SimulasiToolStripMenuItem.Name = "SimulasiToolStripMenuItem"
        SimulasiToolStripMenuItem.Size = New Size(93, 29)
        SimulasiToolStripMenuItem.Text = "&Simulasi"
        ' 
        ' SPTToolStripMenuItem
        ' 
        SPTToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PengisianSPTToolStripMenuItem, RiwayatPelaporanToolStripMenuItem})
        SPTToolStripMenuItem.Name = "SPTToolStripMenuItem"
        SPTToolStripMenuItem.Size = New Size(57, 29)
        SPTToolStripMenuItem.Text = "&SPT"
        ' 
        ' PengisianSPTToolStripMenuItem
        ' 
        PengisianSPTToolStripMenuItem.Name = "PengisianSPTToolStripMenuItem"
        PengisianSPTToolStripMenuItem.Size = New Size(270, 34)
        PengisianSPTToolStripMenuItem.Text = "&Pengisian SPT"
        ' 
        ' RiwayatPelaporanToolStripMenuItem
        ' 
        RiwayatPelaporanToolStripMenuItem.Name = "RiwayatPelaporanToolStripMenuItem"
        RiwayatPelaporanToolStripMenuItem.Size = New Size(270, 34)
        RiwayatPelaporanToolStripMenuItem.Text = "&Riwayat Pelaporan"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 868)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(2, 0, 23, 0)
        StatusStrip1.Size = New Size(1400, 32)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(270, 25)
        ToolStripStatusLabel1.Text = "TaxEase - Dashboard Wajib Pajak"
        ' 
        ' PanelContent
        ' 
        PanelContent.AutoScroll = True
        PanelContent.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(252))
        PanelContent.Controls.Add(LabelNotificationBadge)
        PanelContent.Controls.Add(ButtonNotification)
        PanelContent.Controls.Add(GroupBoxRiwayat)
        PanelContent.Controls.Add(GroupBoxTrenPembayaran)
        PanelContent.Controls.Add(GroupBoxPerbandingan)
        PanelContent.Controls.Add(PanelCards)
        PanelContent.Controls.Add(LabelTitle)
        PanelContent.Dock = DockStyle.Fill
        PanelContent.Location = New Point(0, 37)
        PanelContent.Name = "PanelContent"
        PanelContent.Padding = New Padding(40)
        PanelContent.Size = New Size(1400, 831)
        PanelContent.TabIndex = 2
        '
        'ButtonNotification
        '
        ButtonNotification.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonNotification.AutoSize = True
        ButtonNotification.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        ButtonNotification.FlatAppearance.BorderSize = 0
        ButtonNotification.FlatStyle = FlatStyle.Flat
        ButtonNotification.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonNotification.ForeColor = Color.White
        ButtonNotification.Location = New Point(1136, 40)
        ButtonNotification.Name = "ButtonNotification"
        ButtonNotification.Padding = New Padding(16, 6, 16, 6)
        ButtonNotification.Size = New Size(204, 44)
        ButtonNotification.TabIndex = 5
        ButtonNotification.Text = "Notifikasi"
        ButtonNotification.UseVisualStyleBackColor = False
        '
        'LabelNotificationBadge
        '
        LabelNotificationBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LabelNotificationBadge.AutoSize = True
        LabelNotificationBadge.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        LabelNotificationBadge.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelNotificationBadge.ForeColor = Color.White
        LabelNotificationBadge.Location = New Point(1334, 32)
        LabelNotificationBadge.MinimumSize = New Size(28, 28)
        LabelNotificationBadge.Name = "LabelNotificationBadge"
        LabelNotificationBadge.Padding = New Padding(4)
        LabelNotificationBadge.Size = New Size(28, 28)
        LabelNotificationBadge.TabIndex = 6
        LabelNotificationBadge.Text = "0"
        LabelNotificationBadge.TextAlign = ContentAlignment.MiddleCenter
        LabelNotificationBadge.Visible = False
        ' 
        ' GroupBoxRiwayat
        ' 
        GroupBoxRiwayat.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBoxRiwayat.BackColor = Color.White
        GroupBoxRiwayat.Controls.Add(DataGridViewRiwayat)
        GroupBoxRiwayat.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxRiwayat.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxRiwayat.Location = New Point(40, 680)
        GroupBoxRiwayat.Name = "GroupBoxRiwayat"
        GroupBoxRiwayat.Padding = New Padding(30)
        GroupBoxRiwayat.Size = New Size(1320, 350)
        GroupBoxRiwayat.TabIndex = 3
        GroupBoxRiwayat.TabStop = False
        GroupBoxRiwayat.Text = "Riwayat Pembayaran Terbaru"
        ' 
        ' DataGridViewRiwayat
        ' 
        DataGridViewRiwayat.AllowUserToAddRows = False
        DataGridViewRiwayat.AllowUserToDeleteRows = False
        DataGridViewRiwayat.BackgroundColor = Color.White
        DataGridViewRiwayat.BorderStyle = BorderStyle.None
        DataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewRiwayat.Columns.AddRange(New DataGridViewColumn() {ColTanggal, ColJenis, ColJumlah, ColStatus})
        DataGridViewRiwayat.Dock = DockStyle.Fill
        DataGridViewRiwayat.Location = New Point(30, 62)
        DataGridViewRiwayat.Name = "DataGridViewRiwayat"
        DataGridViewRiwayat.ReadOnly = True
        DataGridViewRiwayat.RowHeadersWidth = 51
        DataGridViewRiwayat.Size = New Size(1260, 208)
        DataGridViewRiwayat.TabIndex = 0
        ' 
        ' ColTanggal
        ' 
        ColTanggal.HeaderText = "Tanggal"
        ColTanggal.MinimumWidth = 6
        ColTanggal.Name = "ColTanggal"
        ColTanggal.ReadOnly = True
        ColTanggal.Width = 200
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis Pembayaran"
        ColJenis.MinimumWidth = 6
        ColJenis.Name = "ColJenis"
        ColJenis.ReadOnly = True
        ColJenis.Width = 400
        ' 
        ' ColJumlah
        ' 
        ColJumlah.HeaderText = "Jumlah"
        ColJumlah.MinimumWidth = 6
        ColJumlah.Name = "ColJumlah"
        ColJumlah.ReadOnly = True
        ColJumlah.Width = 300
        ' 
        ' ColStatus
        ' 
        ColStatus.HeaderText = "Status"
        ColStatus.MinimumWidth = 6
        ColStatus.Name = "ColStatus"
        ColStatus.ReadOnly = True
        ColStatus.Width = 200
        ' 
        ' GroupBoxTrenPembayaran
        ' 
        GroupBoxTrenPembayaran.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBoxTrenPembayaran.BackColor = Color.White
        GroupBoxTrenPembayaran.Controls.Add(PanelChartTren)
        GroupBoxTrenPembayaran.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxTrenPembayaran.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxTrenPembayaran.Location = New Point(700, 380)
        GroupBoxTrenPembayaran.Name = "GroupBoxTrenPembayaran"
        GroupBoxTrenPembayaran.Padding = New Padding(30)
        GroupBoxTrenPembayaran.Size = New Size(660, 280)
        GroupBoxTrenPembayaran.TabIndex = 2
        GroupBoxTrenPembayaran.TabStop = False
        GroupBoxTrenPembayaran.Text = "Tren Pembayaran Pajak"
        ' 
        ' PanelChartTren
        ' 
        PanelChartTren.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(252))
        PanelChartTren.Dock = DockStyle.Fill
        PanelChartTren.Location = New Point(30, 62)
        PanelChartTren.Name = "PanelChartTren"
        PanelChartTren.Size = New Size(600, 188)
        PanelChartTren.TabIndex = 1
        ' 
        ' GroupBoxPerbandingan
        ' 
        GroupBoxPerbandingan.BackColor = Color.White
        GroupBoxPerbandingan.Controls.Add(PanelChartPerbandingan)
        GroupBoxPerbandingan.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxPerbandingan.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxPerbandingan.Location = New Point(40, 380)
        GroupBoxPerbandingan.Name = "GroupBoxPerbandingan"
        GroupBoxPerbandingan.Padding = New Padding(30)
        GroupBoxPerbandingan.Size = New Size(640, 280)
        GroupBoxPerbandingan.TabIndex = 1
        GroupBoxPerbandingan.TabStop = False
        GroupBoxPerbandingan.Text = "Perbandingan Pajak"
        ' 
        ' PanelChartPerbandingan
        ' 
        PanelChartPerbandingan.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(252))
        PanelChartPerbandingan.Dock = DockStyle.Fill
        PanelChartPerbandingan.Location = New Point(30, 62)
        PanelChartPerbandingan.Name = "PanelChartPerbandingan"
        PanelChartPerbandingan.Size = New Size(580, 188)
        PanelChartPerbandingan.TabIndex = 1
        ' 
        ' PanelCards
        ' 
        PanelCards.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelCards.Controls.Add(CardStatusPajak)
        PanelCards.Controls.Add(CardPajakDipotong)
        PanelCards.Controls.Add(CardPajakTerutang)
        PanelCards.Location = New Point(40, 100)
        PanelCards.Name = "PanelCards"
        PanelCards.Size = New Size(1320, 260)
        PanelCards.TabIndex = 0
        ' 
        ' CardStatusPajak
        ' 
        CardStatusPajak.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CardStatusPajak.BackColor = Color.White
        CardStatusPajak.Controls.Add(LabelStatusValue)
        CardStatusPajak.Controls.Add(LabelStatusTitle)
        CardStatusPajak.Location = New Point(880, 0)
        CardStatusPajak.Name = "CardStatusPajak"
        CardStatusPajak.Padding = New Padding(30)
        CardStatusPajak.Size = New Size(440, 260)
        CardStatusPajak.TabIndex = 2
        ' 
        ' LabelStatusValue
        ' 
        LabelStatusValue.AutoSize = True
        LabelStatusValue.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelStatusValue.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelStatusValue.Location = New Point(30, 70)
        LabelStatusValue.Name = "LabelStatusValue"
        LabelStatusValue.Size = New Size(265, 108)
        LabelStatusValue.TabIndex = 1
        LabelStatusValue.Text = "Kurang Bayar" & vbCrLf & "Rp 500.000"
        ' 
        ' LabelStatusTitle
        ' 
        LabelStatusTitle.AutoSize = True
        LabelStatusTitle.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelStatusTitle.ForeColor = Color.FromArgb(CByte(105), CByte(112), CByte(125))
        LabelStatusTitle.Location = New Point(30, 30)
        LabelStatusTitle.Name = "LabelStatusTitle"
        LabelStatusTitle.Size = New Size(123, 30)
        LabelStatusTitle.TabIndex = 0
        LabelStatusTitle.Text = "Status Pajak"
        ' 
        ' CardPajakDipotong
        ' 
        CardPajakDipotong.BackColor = Color.White
        CardPajakDipotong.Controls.Add(LabelPajakDipotongValue)
        CardPajakDipotong.Controls.Add(LabelPajakDipotongTitle)
        CardPajakDipotong.Location = New Point(440, 0)
        CardPajakDipotong.Name = "CardPajakDipotong"
        CardPajakDipotong.Padding = New Padding(30)
        CardPajakDipotong.Size = New Size(440, 260)
        CardPajakDipotong.TabIndex = 1
        ' 
        ' LabelPajakDipotongValue
        ' 
        LabelPajakDipotongValue.AutoSize = True
        LabelPajakDipotongValue.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPajakDipotongValue.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelPajakDipotongValue.Location = New Point(30, 70)
        LabelPajakDipotongValue.Name = "LabelPajakDipotongValue"
        LabelPajakDipotongValue.Size = New Size(257, 54)
        LabelPajakDipotongValue.TabIndex = 1
        LabelPajakDipotongValue.Text = "Rp 2.000.000"
        ' 
        ' LabelPajakDipotongTitle
        ' 
        LabelPajakDipotongTitle.AutoSize = True
        LabelPajakDipotongTitle.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPajakDipotongTitle.ForeColor = Color.FromArgb(CByte(105), CByte(112), CByte(125))
        LabelPajakDipotongTitle.Location = New Point(30, 30)
        LabelPajakDipotongTitle.Name = "LabelPajakDipotongTitle"
        LabelPajakDipotongTitle.Size = New Size(204, 30)
        LabelPajakDipotongTitle.TabIndex = 0
        LabelPajakDipotongTitle.Text = "Total Pajak Dipotong"
        ' 
        ' CardPajakTerutang
        ' 
        CardPajakTerutang.BackColor = Color.White
        CardPajakTerutang.Controls.Add(LabelPajakTerutangValue)
        CardPajakTerutang.Controls.Add(LabelPajakTerutangTitle)
        CardPajakTerutang.Location = New Point(0, 0)
        CardPajakTerutang.Name = "CardPajakTerutang"
        CardPajakTerutang.Padding = New Padding(30)
        CardPajakTerutang.Size = New Size(440, 260)
        CardPajakTerutang.TabIndex = 0
        ' 
        ' LabelPajakTerutangValue
        ' 
        LabelPajakTerutangValue.AutoSize = True
        LabelPajakTerutangValue.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPajakTerutangValue.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelPajakTerutangValue.Location = New Point(30, 70)
        LabelPajakTerutangValue.Name = "LabelPajakTerutangValue"
        LabelPajakTerutangValue.Size = New Size(257, 54)
        LabelPajakTerutangValue.TabIndex = 1
        LabelPajakTerutangValue.Text = "Rp 2.500.000"
        ' 
        ' LabelPajakTerutangTitle
        ' 
        LabelPajakTerutangTitle.AutoSize = True
        LabelPajakTerutangTitle.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPajakTerutangTitle.ForeColor = Color.FromArgb(CByte(105), CByte(112), CByte(125))
        LabelPajakTerutangTitle.Location = New Point(30, 30)
        LabelPajakTerutangTitle.Name = "LabelPajakTerutangTitle"
        LabelPajakTerutangTitle.Size = New Size(198, 30)
        LabelPajakTerutangTitle.TabIndex = 0
        LabelPajakTerutangTitle.Text = "Total Pajak Terutang"
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelTitle.Location = New Point(40, 40)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(200, 48)
        LabelTitle.TabIndex = 4
        LabelTitle.Text = "Dashboard"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(270, 34)
        KeluarToolStripMenuItem.Text = "Notifikasi"
        ' 
        ' KeluarToolStripMenuItem1
        ' 
        KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        KeluarToolStripMenuItem1.Size = New Size(270, 34)
        KeluarToolStripMenuItem1.Text = "Keluar"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(252))
        ClientSize = New Size(1400, 900)
        Controls.Add(PanelContent)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TaxEase | Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        PanelContent.ResumeLayout(False)
        PanelContent.PerformLayout()
        GroupBoxRiwayat.ResumeLayout(False)
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxTrenPembayaran.ResumeLayout(False)
        GroupBoxPerbandingan.ResumeLayout(False)
        PanelCards.ResumeLayout(False)
        CardStatusPajak.ResumeLayout(False)
        CardStatusPajak.PerformLayout()
        CardPajakDipotong.ResumeLayout(False)
        CardPajakDipotong.PerformLayout()
        CardPajakTerutang.ResumeLayout(False)
        CardPajakTerutang.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimulasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengisianSPTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiwayatPelaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents PanelCards As Panel
    Friend WithEvents CardPajakTerutang As Panel
    Friend WithEvents LabelPajakTerutangTitle As Label
    Friend WithEvents LabelPajakTerutangValue As Label
    Friend WithEvents CardPajakDipotong As Panel
    Friend WithEvents LabelPajakDipotongTitle As Label
    Friend WithEvents LabelPajakDipotongValue As Label
    Friend WithEvents CardStatusPajak As Panel
    Friend WithEvents LabelStatusTitle As Label
    Friend WithEvents LabelStatusValue As Label
    Friend WithEvents GroupBoxPerbandingan As GroupBox
    Friend WithEvents PanelChartPerbandingan As Panel
    Friend WithEvents GroupBoxTrenPembayaran As GroupBox
    Friend WithEvents PanelChartTren As Panel
    Friend WithEvents GroupBoxRiwayat As GroupBox
    Friend WithEvents DataGridViewRiwayat As DataGridView
    Friend WithEvents ColTanggal As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents ColJumlah As DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As DataGridViewTextBoxColumn
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonNotification As Button
    Friend WithEvents LabelNotificationBadge As Label
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem

End Class
