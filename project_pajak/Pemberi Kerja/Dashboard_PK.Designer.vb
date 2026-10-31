<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_PK
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
        FileToolStripMenuItem = New ToolStripMenuItem()
        DataGajiToolStripMenuItem = New ToolStripMenuItem()
        ImporDataCSVToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        CetakBuktiPotongToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        LabelTitle = New Label()
        LabelSubtitle = New Label()
        PanelContent = New Panel()
        PanelMainContent = New Panel()
        GroupBoxDataKaryawan = New GroupBox()
        DataGridViewKaryawan = New DataGridView()
        ColNama = New DataGridViewTextBoxColumn()
        ColJabatan = New DataGridViewTextBoxColumn()
        ColNPWP = New DataGridViewTextBoxColumn()
        ColGaji = New DataGridViewTextBoxColumn()
        ColStatus = New DataGridViewTextBoxColumn()
        PanelCards = New Panel()
        CardTotalKaryawan = New Panel()
        PanelCardKaryawanInner = New Panel()
        LabelTotalKaryawanValue = New Label()
        LabelTotalKaryawanTitle = New Label()
        PictureBoxKaryawan = New PictureBox()
        CardTotalGaji = New Panel()
        PanelCardGajiInner = New Panel()
        LabelTotalGajiValue = New Label()
        LabelTotalGajiTitle = New Label()
        PictureBoxGaji = New PictureBox()
        CardTotalPajak = New Panel()
        PanelCardPajakInner = New Panel()
        LabelTotalPajakValue = New Label()
        LabelTotalPajakTitle = New Label()
        PictureBoxPajak = New PictureBox()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        PanelContent.SuspendLayout()
        PanelMainContent.SuspendLayout()
        GroupBoxDataKaryawan.SuspendLayout()
        CType(DataGridViewKaryawan, ComponentModel.ISupportInitialize).BeginInit()
        PanelCards.SuspendLayout()
        CardTotalKaryawan.SuspendLayout()
        PanelCardKaryawanInner.SuspendLayout()
        CType(PictureBoxKaryawan, ComponentModel.ISupportInitialize).BeginInit()
        CardTotalGaji.SuspendLayout()
        PanelCardGajiInner.SuspendLayout()
        CType(PictureBoxGaji, ComponentModel.ISupportInitialize).BeginInit()
        CardTotalPajak.SuspendLayout()
        PanelCardPajakInner.SuspendLayout()
        CType(PictureBoxPajak, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(15), CByte(76), CByte(129))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, DataGajiToolStripMenuItem, LaporanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(15, 8, 0, 8)
        MenuStrip1.Size = New Size(1993, 73)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FileToolStripMenuItem.ForeColor = Color.White
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Padding = New Padding(12, 6, 12, 6)
        FileToolStripMenuItem.Size = New Size(183, 57)
        FileToolStripMenuItem.Text = "🚪 Keluar"
        ' 
        ' DataGajiToolStripMenuItem
        ' 
        DataGajiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ImporDataCSVToolStripMenuItem})
        DataGajiToolStripMenuItem.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGajiToolStripMenuItem.ForeColor = Color.White
        DataGajiToolStripMenuItem.Name = "DataGajiToolStripMenuItem"
        DataGajiToolStripMenuItem.Padding = New Padding(12, 6, 12, 6)
        DataGajiToolStripMenuItem.Size = New Size(222, 57)
        DataGajiToolStripMenuItem.Text = "📊 &Data Gaji"
        ' 
        ' ImporDataCSVToolStripMenuItem
        ' 
        ImporDataCSVToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ImporDataCSVToolStripMenuItem.Name = "ImporDataCSVToolStripMenuItem"
        ImporDataCSVToolStripMenuItem.Padding = New Padding(10, 5, 10, 5)
        ImporDataCSVToolStripMenuItem.Size = New Size(423, 52)
        ImporDataCSVToolStripMenuItem.Text = "📥 &Impor Data (CSV)"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CetakBuktiPotongToolStripMenuItem})
        LaporanToolStripMenuItem.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LaporanToolStripMenuItem.ForeColor = Color.White
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Padding = New Padding(12, 6, 12, 6)
        LaporanToolStripMenuItem.Size = New Size(208, 57)
        LaporanToolStripMenuItem.Text = "📄 &Laporan"
        ' 
        ' CetakBuktiPotongToolStripMenuItem
        ' 
        CetakBuktiPotongToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CetakBuktiPotongToolStripMenuItem.Name = "CetakBuktiPotongToolStripMenuItem"
        CetakBuktiPotongToolStripMenuItem.Padding = New Padding(10, 5, 10, 5)
        CetakBuktiPotongToolStripMenuItem.Size = New Size(444, 52)
        CetakBuktiPotongToolStripMenuItem.Text = "🖨️ Cetak Bukti Potong"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 986)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(25, 8, 25, 8)
        StatusStrip1.Size = New Size(1993, 58)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel1.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(474, 32)
        ToolStripStatusLabel1.Text = "TaxEase © 2024 - Dashboard Pemberi Kerja"
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(23), CByte(43), CByte(77))
        LabelTitle.Location = New Point(20, 15)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(1299, 114)
        LabelTitle.TabIndex = 5
        LabelTitle.Text = "Selamat Datang, Pemberi Kerja"
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.AutoSize = True
        LabelSubtitle.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSubtitle.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        LabelSubtitle.Location = New Point(23, 100)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Size = New Size(697, 41)
        LabelSubtitle.TabIndex = 6
        LabelSubtitle.Text = "Kelola data gaji dan pajak karyawan dengan mudah"
        ' 
        ' PanelContent
        ' 
        PanelContent.AutoScroll = True
        PanelContent.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelContent.Controls.Add(PanelMainContent)
        PanelContent.Dock = DockStyle.Fill
        PanelContent.Location = New Point(0, 73)
        PanelContent.Name = "PanelContent"
        PanelContent.Padding = New Padding(50, 35, 50, 35)
        PanelContent.Size = New Size(1993, 913)
        PanelContent.TabIndex = 21
        ' 
        ' PanelMainContent
        ' 
        PanelMainContent.AutoSize = True
        PanelMainContent.Controls.Add(LabelTitle)
        PanelMainContent.Controls.Add(LabelSubtitle)
        PanelMainContent.Controls.Add(GroupBoxDataKaryawan)
        PanelMainContent.Controls.Add(PanelCards)
        PanelMainContent.Dock = DockStyle.Fill
        PanelMainContent.Location = New Point(50, 35)
        PanelMainContent.Name = "PanelMainContent"
        PanelMainContent.Size = New Size(1893, 843)
        PanelMainContent.TabIndex = 1
        ' 
        ' GroupBoxDataKaryawan
        ' 
        GroupBoxDataKaryawan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBoxDataKaryawan.BackColor = Color.White
        GroupBoxDataKaryawan.Controls.Add(DataGridViewKaryawan)
        GroupBoxDataKaryawan.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxDataKaryawan.ForeColor = Color.FromArgb(CByte(23), CByte(43), CByte(77))
        GroupBoxDataKaryawan.Location = New Point(20, 434)
        GroupBoxDataKaryawan.Name = "GroupBoxDataKaryawan"
        GroupBoxDataKaryawan.Padding = New Padding(25, 15, 25, 25)
        GroupBoxDataKaryawan.Size = New Size(1327, 409)
        GroupBoxDataKaryawan.TabIndex = 1
        GroupBoxDataKaryawan.TabStop = False
        GroupBoxDataKaryawan.Text = "📋 Data Karyawan"
        ' 
        ' DataGridViewKaryawan
        ' 
        DataGridViewKaryawan.AllowUserToAddRows = False
        DataGridViewKaryawan.AllowUserToDeleteRows = False
        DataGridViewKaryawan.BackgroundColor = Color.White
        DataGridViewKaryawan.BorderStyle = BorderStyle.None
        DataGridViewKaryawan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewKaryawan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewKaryawan.ColumnHeadersHeight = 45
        DataGridViewKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewKaryawan.Columns.AddRange(New DataGridViewColumn() {ColNama, ColJabatan, ColNPWP, ColGaji, ColStatus})
        DataGridViewKaryawan.Dock = DockStyle.Fill
        DataGridViewKaryawan.EnableHeadersVisualStyles = False
        DataGridViewKaryawan.GridColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        DataGridViewKaryawan.Location = New Point(25, 62)
        DataGridViewKaryawan.Name = "DataGridViewKaryawan"
        DataGridViewKaryawan.ReadOnly = True
        DataGridViewKaryawan.RowHeadersVisible = False
        DataGridViewKaryawan.RowHeadersWidth = 51
        DataGridViewKaryawan.RowTemplate.Height = 40
        DataGridViewKaryawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewKaryawan.Size = New Size(1277, 322)
        DataGridViewKaryawan.TabIndex = 0
        ' 
        ' ColNama
        ' 
        ColNama.HeaderText = "Nama Karyawan"
        ColNama.MinimumWidth = 6
        ColNama.Name = "ColNama"
        ColNama.ReadOnly = True
        ColNama.Width = 400
        ' 
        ' ColJabatan
        ' 
        ColJabatan.HeaderText = "Jabatan"
        ColJabatan.MinimumWidth = 6
        ColJabatan.Name = "ColJabatan"
        ColJabatan.ReadOnly = True
        ColJabatan.Width = 250
        ' 
        ' ColNPWP
        ' 
        ColNPWP.HeaderText = "NPWP"
        ColNPWP.MinimumWidth = 6
        ColNPWP.Name = "ColNPWP"
        ColNPWP.ReadOnly = True
        ColNPWP.Width = 320
        ' 
        ' ColGaji
        ' 
        ColGaji.HeaderText = "Gaji Bulanan"
        ColGaji.MinimumWidth = 6
        ColGaji.Name = "ColGaji"
        ColGaji.ReadOnly = True
        ColGaji.Width = 350
        ' 
        ' ColStatus
        ' 
        ColStatus.HeaderText = "Status"
        ColStatus.MinimumWidth = 6
        ColStatus.Name = "ColStatus"
        ColStatus.ReadOnly = True
        ColStatus.Width = 200
        ' 
        ' PanelCards
        ' 
        PanelCards.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelCards.Controls.Add(CardTotalKaryawan)
        PanelCards.Controls.Add(CardTotalGaji)
        PanelCards.Controls.Add(CardTotalPajak)
        PanelCards.Location = New Point(20, 155)
        PanelCards.Name = "PanelCards"
        PanelCards.Size = New Size(1394, 170)
        PanelCards.TabIndex = 0
        ' 
        ' CardTotalKaryawan
        ' 
        CardTotalKaryawan.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        CardTotalKaryawan.Controls.Add(PanelCardKaryawanInner)
        CardTotalKaryawan.Location = New Point(0, 0)
        CardTotalKaryawan.Name = "CardTotalKaryawan"
        CardTotalKaryawan.Padding = New Padding(4)
        CardTotalKaryawan.Size = New Size(445, 160)
        CardTotalKaryawan.TabIndex = 0
        ' 
        ' PanelCardKaryawanInner
        ' 
        PanelCardKaryawanInner.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        PanelCardKaryawanInner.Controls.Add(LabelTotalKaryawanValue)
        PanelCardKaryawanInner.Controls.Add(LabelTotalKaryawanTitle)
        PanelCardKaryawanInner.Controls.Add(PictureBoxKaryawan)
        PanelCardKaryawanInner.Dock = DockStyle.Fill
        PanelCardKaryawanInner.Location = New Point(4, 4)
        PanelCardKaryawanInner.Name = "PanelCardKaryawanInner"
        PanelCardKaryawanInner.Padding = New Padding(25, 20, 25, 20)
        PanelCardKaryawanInner.Size = New Size(437, 152)
        PanelCardKaryawanInner.TabIndex = 0
        ' 
        ' LabelTotalKaryawanValue
        ' 
        LabelTotalKaryawanValue.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotalKaryawanValue.ForeColor = Color.White
        LabelTotalKaryawanValue.Location = New Point(20, 60)
        LabelTotalKaryawanValue.Name = "LabelTotalKaryawanValue"
        LabelTotalKaryawanValue.Size = New Size(250, 75)
        LabelTotalKaryawanValue.TabIndex = 1
        LabelTotalKaryawanValue.Text = "0"
        ' 
        ' LabelTotalKaryawanTitle
        ' 
        LabelTotalKaryawanTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotalKaryawanTitle.ForeColor = Color.FromArgb(CByte(220), CByte(230), CByte(255))
        LabelTotalKaryawanTitle.Location = New Point(20, 20)
        LabelTotalKaryawanTitle.Name = "LabelTotalKaryawanTitle"
        LabelTotalKaryawanTitle.Size = New Size(250, 32)
        LabelTotalKaryawanTitle.TabIndex = 0
        LabelTotalKaryawanTitle.Text = "Total Karyawan"
        ' 
        ' PictureBoxKaryawan
        ' 
        PictureBoxKaryawan.BackColor = Color.FromArgb(CByte(40), CByte(130), CByte(255))
        PictureBoxKaryawan.BorderStyle = BorderStyle.FixedSingle
        PictureBoxKaryawan.Location = New Point(340, 50)
        PictureBoxKaryawan.Name = "PictureBoxKaryawan"
        PictureBoxKaryawan.Size = New Size(75, 75)
        PictureBoxKaryawan.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxKaryawan.TabIndex = 2
        PictureBoxKaryawan.TabStop = False
        ' 
        ' CardTotalGaji
        ' 
        CardTotalGaji.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        CardTotalGaji.Controls.Add(PanelCardGajiInner)
        CardTotalGaji.Location = New Point(470, 0)
        CardTotalGaji.Name = "CardTotalGaji"
        CardTotalGaji.Padding = New Padding(4)
        CardTotalGaji.Size = New Size(445, 160)
        CardTotalGaji.TabIndex = 1
        ' 
        ' PanelCardGajiInner
        ' 
        PanelCardGajiInner.BackColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
        PanelCardGajiInner.Controls.Add(LabelTotalGajiValue)
        PanelCardGajiInner.Controls.Add(LabelTotalGajiTitle)
        PanelCardGajiInner.Controls.Add(PictureBoxGaji)
        PanelCardGajiInner.Dock = DockStyle.Fill
        PanelCardGajiInner.Location = New Point(4, 4)
        PanelCardGajiInner.Name = "PanelCardGajiInner"
        PanelCardGajiInner.Padding = New Padding(25, 20, 25, 20)
        PanelCardGajiInner.Size = New Size(437, 152)
        PanelCardGajiInner.TabIndex = 0
        ' 
        ' LabelTotalGajiValue
        ' 
        LabelTotalGajiValue.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotalGajiValue.ForeColor = Color.White
        LabelTotalGajiValue.Location = New Point(20, 65)
        LabelTotalGajiValue.Name = "LabelTotalGajiValue"
        LabelTotalGajiValue.Size = New Size(300, 70)
        LabelTotalGajiValue.TabIndex = 1
        LabelTotalGajiValue.Text = "Rp 0"
        ' 
        ' LabelTotalGajiTitle
        ' 
        LabelTotalGajiTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotalGajiTitle.ForeColor = Color.FromArgb(CByte(200), CByte(255), CByte(230))
        LabelTotalGajiTitle.Location = New Point(20, 20)
        LabelTotalGajiTitle.Name = "LabelTotalGajiTitle"
        LabelTotalGajiTitle.Size = New Size(250, 32)
        LabelTotalGajiTitle.TabIndex = 0
        LabelTotalGajiTitle.Text = "Total Gaji"
        ' 
        ' PictureBoxGaji
        ' 
        PictureBoxGaji.BackColor = Color.FromArgb(CByte(46), CByte(160), CByte(110))
        PictureBoxGaji.BorderStyle = BorderStyle.FixedSingle
        PictureBoxGaji.Location = New Point(340, 50)
        PictureBoxGaji.Name = "PictureBoxGaji"
        PictureBoxGaji.Size = New Size(75, 75)
        PictureBoxGaji.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxGaji.TabIndex = 2
        PictureBoxGaji.TabStop = False
        ' 
        ' CardTotalPajak
        ' 
        CardTotalPajak.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        CardTotalPajak.Controls.Add(PanelCardPajakInner)
        CardTotalPajak.Location = New Point(940, 0)
        CardTotalPajak.Name = "CardTotalPajak"
        CardTotalPajak.Padding = New Padding(4)
        CardTotalPajak.Size = New Size(445, 160)
        CardTotalPajak.TabIndex = 2
        ' 
        ' PanelCardPajakInner
        ' 
        PanelCardPajakInner.BackColor = Color.FromArgb(CByte(255), CByte(159), CByte(10))
        PanelCardPajakInner.Controls.Add(LabelTotalPajakValue)
        PanelCardPajakInner.Controls.Add(LabelTotalPajakTitle)
        PanelCardPajakInner.Controls.Add(PictureBoxPajak)
        PanelCardPajakInner.Dock = DockStyle.Fill
        PanelCardPajakInner.Location = New Point(4, 4)
        PanelCardPajakInner.Name = "PanelCardPajakInner"
        PanelCardPajakInner.Padding = New Padding(25, 20, 25, 20)
        PanelCardPajakInner.Size = New Size(437, 152)
        PanelCardPajakInner.TabIndex = 0
        ' 
        ' LabelTotalPajakValue
        ' 
        LabelTotalPajakValue.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotalPajakValue.ForeColor = Color.White
        LabelTotalPajakValue.Location = New Point(20, 65)
        LabelTotalPajakValue.Name = "LabelTotalPajakValue"
        LabelTotalPajakValue.Size = New Size(300, 70)
        LabelTotalPajakValue.TabIndex = 1
        LabelTotalPajakValue.Text = "Rp 0"
        ' 
        ' LabelTotalPajakTitle
        ' 
        LabelTotalPajakTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotalPajakTitle.ForeColor = Color.FromArgb(CByte(255), CByte(245), CByte(220))
        LabelTotalPajakTitle.Location = New Point(20, 20)
        LabelTotalPajakTitle.Name = "LabelTotalPajakTitle"
        LabelTotalPajakTitle.Size = New Size(250, 32)
        LabelTotalPajakTitle.TabIndex = 0
        LabelTotalPajakTitle.Text = "Total Pajak"
        ' 
        ' PictureBoxPajak
        ' 
        PictureBoxPajak.BackColor = Color.FromArgb(CByte(255), CByte(180), CByte(50))
        PictureBoxPajak.BorderStyle = BorderStyle.FixedSingle
        PictureBoxPajak.Location = New Point(340, 50)
        PictureBoxPajak.Name = "PictureBoxPajak"
        PictureBoxPajak.Size = New Size(75, 75)
        PictureBoxPajak.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxPajak.TabIndex = 2
        PictureBoxPajak.TabStop = False
        ' 
        ' Dashboard_PK
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1993, 1044)
        Controls.Add(PanelContent)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Dashboard_PK"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TaxEase | Dashboard Pemberi Kerja"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        PanelContent.ResumeLayout(False)
        PanelContent.PerformLayout()
        PanelMainContent.ResumeLayout(False)
        PanelMainContent.PerformLayout()
        GroupBoxDataKaryawan.ResumeLayout(False)
        CType(DataGridViewKaryawan, ComponentModel.ISupportInitialize).EndInit()
        PanelCards.ResumeLayout(False)
        CardTotalKaryawan.ResumeLayout(False)
        PanelCardKaryawanInner.ResumeLayout(False)
        CType(PictureBoxKaryawan, ComponentModel.ISupportInitialize).EndInit()
        CardTotalGaji.ResumeLayout(False)
        PanelCardGajiInner.ResumeLayout(False)
        CType(PictureBoxGaji, ComponentModel.ISupportInitialize).EndInit()
        CardTotalPajak.ResumeLayout(False)
        PanelCardPajakInner.ResumeLayout(False)
        CType(PictureBoxPajak, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGajiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImporDataCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakBuktiPotongToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents PanelMainContent As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents GroupBoxDataKaryawan As GroupBox
    Friend WithEvents DataGridViewKaryawan As DataGridView
    Friend WithEvents ColNama As DataGridViewTextBoxColumn
    Friend WithEvents ColJabatan As DataGridViewTextBoxColumn
    Friend WithEvents ColNPWP As DataGridViewTextBoxColumn
    Friend WithEvents ColGaji As DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As DataGridViewTextBoxColumn
    Friend WithEvents PanelCards As Panel
    Friend WithEvents CardTotalKaryawan As Panel
    Friend WithEvents PanelCardKaryawanInner As Panel
    Friend WithEvents LabelTotalKaryawanValue As Label
    Friend WithEvents LabelTotalKaryawanTitle As Label
    Friend WithEvents PictureBoxKaryawan As PictureBox
    Friend WithEvents CardTotalGaji As Panel
    Friend WithEvents PanelCardGajiInner As Panel
    Friend WithEvents LabelTotalGajiValue As Label
    Friend WithEvents LabelTotalGajiTitle As Label
    Friend WithEvents PictureBoxGaji As PictureBox
    Friend WithEvents CardTotalPajak As Panel
    Friend WithEvents PanelCardPajakInner As Panel
    Friend WithEvents LabelTotalPajakValue As Label
    Friend WithEvents LabelTotalPajakTitle As Label
    Friend WithEvents PictureBoxPajak As PictureBox

End Class
