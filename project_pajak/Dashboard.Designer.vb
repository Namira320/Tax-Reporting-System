<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        MenuStrip1 = New MenuStrip()
        ProfilToolStripMenuItem = New ToolStripMenuItem()
        ProfilToolStripMenuItem1 = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem1 = New ToolStripMenuItem()
        SimulasiToolStripMenuItem = New ToolStripMenuItem()
        PengisianSPTToolStripMenuItem1 = New ToolStripMenuItem()
        RiwayatPelaporanToolStripMenuItem1 = New ToolStripMenuItem()
        SPTToolStripMenuItem = New ToolStripMenuItem()
        SimulasiToolStripMenuItem1 = New ToolStripMenuItem()
        PanduanEBillingToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        PanelContent = New Panel()
        GroupBoxRiwayat = New GroupBox()
        DataGridViewRiwayat = New DataGridView()
        ColTanggal = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        ColJumlah = New DataGridViewTextBoxColumn()
        ColStatus = New DataGridViewTextBoxColumn()
        TableCharts = New TableLayoutPanel()
        GroupBoxPerbandingan = New GroupBox()
        PanelChartPerbandingan = New Panel()
        GroupBoxTrenPembayaran = New GroupBox()
        PanelChartTren = New Panel()
        TableCards = New TableLayoutPanel()
        CardPajakTerutang = New Panel()
        LabelPajakTerutangValue = New Label()
        LabelPajakTerutangTitle = New Label()
        CardPajakDipotong = New Panel()
        LabelPajakDipotongValue = New Label()
        LabelPajakDipotongTitle = New Label()
        CardStatusPajak = New Panel()
        LabelStatusValue = New Label()
        LabelStatusTitle = New Label()
        LabelTitle = New Label()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        PanelContent.SuspendLayout()
        GroupBoxRiwayat.SuspendLayout()
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        TableCharts.SuspendLayout()
        GroupBoxPerbandingan.SuspendLayout()
        GroupBoxTrenPembayaran.SuspendLayout()
        TableCards.SuspendLayout()
        CardPajakTerutang.SuspendLayout()
        CardPajakDipotong.SuspendLayout()
        CardStatusPajak.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        MenuStrip1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProfilToolStripMenuItem, SimulasiToolStripMenuItem, SPTToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(20, 13, 0, 13)
        MenuStrip1.Size = New Size(2600, 71)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ProfilToolStripMenuItem
        ' 
        ProfilToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfilToolStripMenuItem1, KeluarToolStripMenuItem, KeluarToolStripMenuItem1})
        ProfilToolStripMenuItem.ForeColor = Color.White
        ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        ProfilToolStripMenuItem.Size = New Size(106, 45)
        ProfilToolStripMenuItem.Text = "&Profil"
        ' 
        ' ProfilToolStripMenuItem1
        ' 
        ProfilToolStripMenuItem1.Name = "ProfilToolStripMenuItem1"
        ProfilToolStripMenuItem1.Size = New Size(278, 50)
        ProfilToolStripMenuItem1.Text = "Profil"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(278, 50)
        KeluarToolStripMenuItem.Text = "Notifikasi"
        ' 
        ' KeluarToolStripMenuItem1
        ' 
        KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        KeluarToolStripMenuItem1.Size = New Size(278, 50)
        KeluarToolStripMenuItem1.Text = "Keluar"
        ' 
        ' SimulasiToolStripMenuItem
        ' 
        SimulasiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PengisianSPTToolStripMenuItem1, RiwayatPelaporanToolStripMenuItem1})
        SimulasiToolStripMenuItem.ForeColor = Color.White
        SimulasiToolStripMenuItem.Name = "SimulasiToolStripMenuItem"
        SimulasiToolStripMenuItem.Size = New Size(87, 45)
        SimulasiToolStripMenuItem.Text = "SPT"
        ' 
        ' PengisianSPTToolStripMenuItem1
        ' 
        PengisianSPTToolStripMenuItem1.Name = "PengisianSPTToolStripMenuItem1"
        PengisianSPTToolStripMenuItem1.Size = New Size(397, 50)
        PengisianSPTToolStripMenuItem1.Text = "Pengisian SPT"
        ' 
        ' RiwayatPelaporanToolStripMenuItem1
        ' 
        RiwayatPelaporanToolStripMenuItem1.Name = "RiwayatPelaporanToolStripMenuItem1"
        RiwayatPelaporanToolStripMenuItem1.Size = New Size(397, 50)
        RiwayatPelaporanToolStripMenuItem1.Text = "Riwayat Pelaporan"
        ' 
        ' SPTToolStripMenuItem
        ' 
        SPTToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SimulasiToolStripMenuItem1, PanduanEBillingToolStripMenuItem})
        SPTToolStripMenuItem.ForeColor = Color.White
        SPTToolStripMenuItem.Name = "SPTToolStripMenuItem"
        SPTToolStripMenuItem.Size = New Size(153, 45)
        SPTToolStripMenuItem.Text = "Panduan"
        ' 
        ' SimulasiToolStripMenuItem1
        ' 
        SimulasiToolStripMenuItem1.Name = "SimulasiToolStripMenuItem1"
        SimulasiToolStripMenuItem1.Size = New Size(385, 50)
        SimulasiToolStripMenuItem1.Text = "Edukasi"
        ' 
        ' PanduanEBillingToolStripMenuItem
        ' 
        PanduanEBillingToolStripMenuItem.Name = "PanduanEBillingToolStripMenuItem"
        PanduanEBillingToolStripMenuItem.Size = New Size(385, 50)
        PanduanEBillingToolStripMenuItem.Text = "Panduan E-Billing"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.White
        StatusStrip1.ImageScalingSize = New Size(32, 32)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 1398)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(2, 0, 23, 0)
        StatusStrip1.Size = New Size(2600, 42)
        StatusStrip1.TabIndex = 1
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(360, 32)
        ToolStripStatusLabel1.Text = "TaxEase - Dashboard Wajib Pajak"
        ' 
        ' PanelContent
        ' 
        PanelContent.AutoScroll = True
        PanelContent.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelContent.Controls.Add(GroupBoxRiwayat)
        PanelContent.Controls.Add(TableCharts)
        PanelContent.Controls.Add(TableCards)
        PanelContent.Controls.Add(LabelTitle)
        PanelContent.Dock = DockStyle.Fill
        PanelContent.Location = New Point(0, 71)
        PanelContent.Margin = New Padding(5)
        PanelContent.Name = "PanelContent"
        PanelContent.Padding = New Padding(49, 48, 49, 48)
        PanelContent.Size = New Size(2600, 1327)
        PanelContent.TabIndex = 2
        ' 
        ' GroupBoxRiwayat
        ' 
        GroupBoxRiwayat.BackColor = Color.White
        GroupBoxRiwayat.Controls.Add(DataGridViewRiwayat)
        GroupBoxRiwayat.Dock = DockStyle.Top
        GroupBoxRiwayat.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxRiwayat.Location = New Point(49, 966)
        GroupBoxRiwayat.Margin = New Padding(5, 32, 5, 5)
        GroupBoxRiwayat.Name = "GroupBoxRiwayat"
        GroupBoxRiwayat.Padding = New Padding(16)
        GroupBoxRiwayat.Size = New Size(2468, 400)
        GroupBoxRiwayat.TabIndex = 3
        GroupBoxRiwayat.TabStop = False
        GroupBoxRiwayat.Text = "Riwayat Pembayaran"
        ' 
        ' DataGridViewRiwayat
        ' 
        DataGridViewRiwayat.AllowUserToAddRows = False
        DataGridViewRiwayat.AllowUserToDeleteRows = False
        DataGridViewRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewRiwayat.BackgroundColor = Color.White
        DataGridViewRiwayat.BorderStyle = BorderStyle.None
        DataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewRiwayat.Columns.AddRange(New DataGridViewColumn() {ColTanggal, ColJenis, ColJumlah, ColStatus})
        DataGridViewRiwayat.Dock = DockStyle.Fill
        DataGridViewRiwayat.GridColor = Color.WhiteSmoke
        DataGridViewRiwayat.Location = New Point(16, 52)
        DataGridViewRiwayat.Margin = New Padding(5)
        DataGridViewRiwayat.Name = "DataGridViewRiwayat"
        DataGridViewRiwayat.ReadOnly = True
        DataGridViewRiwayat.RowHeadersVisible = False
        DataGridViewRiwayat.RowHeadersWidth = 82
        DataGridViewRiwayat.Size = New Size(2436, 332)
        DataGridViewRiwayat.TabIndex = 0
        ' 
        ' ColTanggal
        ' 
        ColTanggal.HeaderText = "Tanggal"
        ColTanggal.MinimumWidth = 10
        ColTanggal.Name = "ColTanggal"
        ColTanggal.ReadOnly = True
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis Pembayaran"
        ColJenis.MinimumWidth = 10
        ColJenis.Name = "ColJenis"
        ColJenis.ReadOnly = True
        ' 
        ' ColJumlah
        ' 
        ColJumlah.HeaderText = "Jumlah"
        ColJumlah.MinimumWidth = 10
        ColJumlah.Name = "ColJumlah"
        ColJumlah.ReadOnly = True
        ' 
        ' ColStatus
        ' 
        ColStatus.HeaderText = "Status"
        ColStatus.MinimumWidth = 10
        ColStatus.Name = "ColStatus"
        ColStatus.ReadOnly = True
        ' 
        ' TableCharts
        ' 
        TableCharts.ColumnCount = 2
        TableCharts.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableCharts.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableCharts.Controls.Add(GroupBoxPerbandingan, 0, 0)
        TableCharts.Controls.Add(GroupBoxTrenPembayaran, 1, 0)
        TableCharts.Dock = DockStyle.Top
        TableCharts.Location = New Point(49, 454)
        TableCharts.Margin = New Padding(5)
        TableCharts.Name = "TableCharts"
        TableCharts.RowCount = 1
        TableCharts.RowStyles.Add(New RowStyle(SizeType.Absolute, 512F))
        TableCharts.Size = New Size(2468, 512)
        TableCharts.TabIndex = 2
        ' 
        ' GroupBoxPerbandingan
        ' 
        GroupBoxPerbandingan.BackColor = Color.White
        GroupBoxPerbandingan.Controls.Add(PanelChartPerbandingan)
        GroupBoxPerbandingan.Dock = DockStyle.Fill
        GroupBoxPerbandingan.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxPerbandingan.Location = New Point(5, 32)
        GroupBoxPerbandingan.Margin = New Padding(5, 32, 16, 5)
        GroupBoxPerbandingan.Name = "GroupBoxPerbandingan"
        GroupBoxPerbandingan.Padding = New Padding(5)
        GroupBoxPerbandingan.Size = New Size(1213, 475)
        GroupBoxPerbandingan.TabIndex = 0
        GroupBoxPerbandingan.TabStop = False
        GroupBoxPerbandingan.Text = "Perbandingan Pajak"
        ' 
        ' PanelChartPerbandingan
        ' 
        PanelChartPerbandingan.Dock = DockStyle.Fill
        PanelChartPerbandingan.Location = New Point(5, 41)
        PanelChartPerbandingan.Margin = New Padding(5)
        PanelChartPerbandingan.Name = "PanelChartPerbandingan"
        PanelChartPerbandingan.Size = New Size(1203, 429)
        PanelChartPerbandingan.TabIndex = 0
        ' 
        ' GroupBoxTrenPembayaran
        ' 
        GroupBoxTrenPembayaran.BackColor = Color.White
        GroupBoxTrenPembayaran.Controls.Add(PanelChartTren)
        GroupBoxTrenPembayaran.Dock = DockStyle.Fill
        GroupBoxTrenPembayaran.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxTrenPembayaran.Location = New Point(1250, 32)
        GroupBoxTrenPembayaran.Margin = New Padding(16, 32, 5, 5)
        GroupBoxTrenPembayaran.Name = "GroupBoxTrenPembayaran"
        GroupBoxTrenPembayaran.Padding = New Padding(5)
        GroupBoxTrenPembayaran.Size = New Size(1213, 475)
        GroupBoxTrenPembayaran.TabIndex = 1
        GroupBoxTrenPembayaran.TabStop = False
        GroupBoxTrenPembayaran.Text = "Tren Pembayaran"
        ' 
        ' PanelChartTren
        ' 
        PanelChartTren.Dock = DockStyle.Fill
        PanelChartTren.Location = New Point(5, 41)
        PanelChartTren.Margin = New Padding(5)
        PanelChartTren.Name = "PanelChartTren"
        PanelChartTren.Size = New Size(1203, 429)
        PanelChartTren.TabIndex = 0
        ' 
        ' TableCards
        ' 
        TableCards.ColumnCount = 3
        TableCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        TableCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        TableCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        TableCards.Controls.Add(CardPajakTerutang, 0, 0)
        TableCards.Controls.Add(CardPajakDipotong, 1, 0)
        TableCards.Controls.Add(CardStatusPajak, 2, 0)
        TableCards.Dock = DockStyle.Top
        TableCards.Location = New Point(49, 166)
        TableCards.Margin = New Padding(5)
        TableCards.Name = "TableCards"
        TableCards.RowCount = 1
        TableCards.RowStyles.Add(New RowStyle(SizeType.Absolute, 288F))
        TableCards.Size = New Size(2468, 288)
        TableCards.TabIndex = 1
        ' 
        ' CardPajakTerutang
        ' 
        CardPajakTerutang.BackColor = Color.White
        CardPajakTerutang.Controls.Add(LabelPajakTerutangValue)
        CardPajakTerutang.Controls.Add(LabelPajakTerutangTitle)
        CardPajakTerutang.Dock = DockStyle.Fill
        CardPajakTerutang.Location = New Point(5, 5)
        CardPajakTerutang.Margin = New Padding(5, 5, 16, 5)
        CardPajakTerutang.Name = "CardPajakTerutang"
        CardPajakTerutang.Padding = New Padding(32)
        CardPajakTerutang.Size = New Size(801, 278)
        CardPajakTerutang.TabIndex = 0
        ' 
        ' LabelPajakTerutangValue
        ' 
        LabelPajakTerutangValue.AutoSize = True
        LabelPajakTerutangValue.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPajakTerutangValue.ForeColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        LabelPajakTerutangValue.Location = New Point(32, 96)
        LabelPajakTerutangValue.Margin = New Padding(5, 0, 5, 0)
        LabelPajakTerutangValue.Name = "LabelPajakTerutangValue"
        LabelPajakTerutangValue.Size = New Size(117, 59)
        LabelPajakTerutangValue.TabIndex = 1
        LabelPajakTerutangValue.Text = "Rp 0"
        ' 
        ' LabelPajakTerutangTitle
        ' 
        LabelPajakTerutangTitle.AutoSize = True
        LabelPajakTerutangTitle.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPajakTerutangTitle.ForeColor = Color.DimGray
        LabelPajakTerutangTitle.Location = New Point(32, 32)
        LabelPajakTerutangTitle.Margin = New Padding(5, 0, 5, 0)
        LabelPajakTerutangTitle.Name = "LabelPajakTerutangTitle"
        LabelPajakTerutangTitle.Size = New Size(189, 37)
        LabelPajakTerutangTitle.TabIndex = 0
        LabelPajakTerutangTitle.Text = "Pajak Terutang"
        ' 
        ' CardPajakDipotong
        ' 
        CardPajakDipotong.BackColor = Color.White
        CardPajakDipotong.Controls.Add(LabelPajakDipotongValue)
        CardPajakDipotong.Controls.Add(LabelPajakDipotongTitle)
        CardPajakDipotong.Dock = DockStyle.Fill
        CardPajakDipotong.Location = New Point(838, 5)
        CardPajakDipotong.Margin = New Padding(16, 5, 16, 5)
        CardPajakDipotong.Name = "CardPajakDipotong"
        CardPajakDipotong.Padding = New Padding(32)
        CardPajakDipotong.Size = New Size(790, 278)
        CardPajakDipotong.TabIndex = 1
        ' 
        ' LabelPajakDipotongValue
        ' 
        LabelPajakDipotongValue.AutoSize = True
        LabelPajakDipotongValue.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPajakDipotongValue.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        LabelPajakDipotongValue.Location = New Point(32, 96)
        LabelPajakDipotongValue.Margin = New Padding(5, 0, 5, 0)
        LabelPajakDipotongValue.Name = "LabelPajakDipotongValue"
        LabelPajakDipotongValue.Size = New Size(117, 59)
        LabelPajakDipotongValue.TabIndex = 1
        LabelPajakDipotongValue.Text = "Rp 0"
        ' 
        ' LabelPajakDipotongTitle
        ' 
        LabelPajakDipotongTitle.AutoSize = True
        LabelPajakDipotongTitle.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPajakDipotongTitle.ForeColor = Color.DimGray
        LabelPajakDipotongTitle.Location = New Point(32, 32)
        LabelPajakDipotongTitle.Margin = New Padding(5, 0, 5, 0)
        LabelPajakDipotongTitle.Name = "LabelPajakDipotongTitle"
        LabelPajakDipotongTitle.Size = New Size(200, 37)
        LabelPajakDipotongTitle.TabIndex = 0
        LabelPajakDipotongTitle.Text = "Pajak Dipotong"
        ' 
        ' CardStatusPajak
        ' 
        CardStatusPajak.BackColor = Color.White
        CardStatusPajak.Controls.Add(LabelStatusValue)
        CardStatusPajak.Controls.Add(LabelStatusTitle)
        CardStatusPajak.Dock = DockStyle.Fill
        CardStatusPajak.Location = New Point(1660, 5)
        CardStatusPajak.Margin = New Padding(16, 5, 5, 5)
        CardStatusPajak.Name = "CardStatusPajak"
        CardStatusPajak.Padding = New Padding(32)
        CardStatusPajak.Size = New Size(803, 278)
        CardStatusPajak.TabIndex = 2
        ' 
        ' LabelStatusValue
        ' 
        LabelStatusValue.AutoSize = True
        LabelStatusValue.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelStatusValue.ForeColor = Color.Green
        LabelStatusValue.Location = New Point(32, 96)
        LabelStatusValue.Margin = New Padding(5, 0, 5, 0)
        LabelStatusValue.Name = "LabelStatusValue"
        LabelStatusValue.Size = New Size(121, 59)
        LabelStatusValue.TabIndex = 1
        LabelStatusValue.Text = "Nihil"
        ' 
        ' LabelStatusTitle
        ' 
        LabelStatusTitle.AutoSize = True
        LabelStatusTitle.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelStatusTitle.ForeColor = Color.DimGray
        LabelStatusTitle.Location = New Point(32, 32)
        LabelStatusTitle.Margin = New Padding(5, 0, 5, 0)
        LabelStatusTitle.Name = "LabelStatusTitle"
        LabelStatusTitle.Size = New Size(157, 37)
        LabelStatusTitle.TabIndex = 0
        LabelStatusTitle.Text = "Status Pajak"
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Dock = DockStyle.Top
        LabelTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelTitle.Location = New Point(49, 48)
        LabelTitle.Margin = New Padding(5, 0, 5, 0)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Padding = New Padding(0, 0, 0, 32)
        LabelTitle.Size = New Size(362, 118)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Dashboard"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(2600, 1440)
        Controls.Add(PanelContent)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(5)
        Name = "Dashboard"
        Text = "TaxEase | Dashboard Wajib Pajak"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        PanelContent.ResumeLayout(False)
        PanelContent.PerformLayout()
        GroupBoxRiwayat.ResumeLayout(False)
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).EndInit()
        TableCharts.ResumeLayout(False)
        GroupBoxPerbandingan.ResumeLayout(False)
        GroupBoxTrenPembayaran.ResumeLayout(False)
        TableCards.ResumeLayout(False)
        CardPajakTerutang.ResumeLayout(False)
        CardPajakTerutang.PerformLayout()
        CardPajakDipotong.ResumeLayout(False)
        CardPajakDipotong.PerformLayout()
        CardStatusPajak.ResumeLayout(False)
        CardStatusPajak.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimulasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents TableCards As TableLayoutPanel
    Friend WithEvents CardPajakTerutang As Panel
    Friend WithEvents LabelPajakTerutangValue As Label
    Friend WithEvents LabelPajakTerutangTitle As Label
    Friend WithEvents CardPajakDipotong As Panel
    Friend WithEvents LabelPajakDipotongValue As Label
    Friend WithEvents LabelPajakDipotongTitle As Label
    Friend WithEvents CardStatusPajak As Panel
    Friend WithEvents LabelStatusValue As Label
    Friend WithEvents LabelStatusTitle As Label
    Friend WithEvents TableCharts As TableLayoutPanel
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
    Friend WithEvents ProfilToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PengisianSPTToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RiwayatPelaporanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SimulasiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PanduanEBillingToolStripMenuItem As ToolStripMenuItem
End Class
