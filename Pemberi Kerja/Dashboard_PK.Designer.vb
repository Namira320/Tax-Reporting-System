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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        DataGajiToolStripMenuItem = New ToolStripMenuItem()
        ImporDataCSVToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        CetakBuktiPotongToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        PanelContent = New Panel()
        GroupBoxDataKaryawan = New GroupBox()
        DataGridViewKaryawan = New DataGridView()
        ColNama = New DataGridViewTextBoxColumn()
        ColNPWP = New DataGridViewTextBoxColumn()
        ColGaji = New DataGridViewTextBoxColumn()
        ColStatus = New DataGridViewTextBoxColumn()
        PanelCards = New Panel()
        CardTotalPajak = New Panel()
        LabelTotalPajakValue = New Label()
        LabelTotalPajakTitle = New Label()
        CardTotalGaji = New Panel()
        LabelTotalGajiValue = New Label()
        LabelTotalGajiTitle = New Label()
        CardTotalKaryawan = New Panel()
        LabelTotalKaryawanValue = New Label()
        LabelTotalKaryawanTitle = New Label()
        LabelTitle = New Label()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        PanelContent.SuspendLayout()
        GroupBoxDataKaryawan.SuspendLayout()
        CType(DataGridViewKaryawan, ComponentModel.ISupportInitialize).BeginInit()
        PanelCards.SuspendLayout()
        CardTotalPajak.SuspendLayout()
        CardTotalGaji.SuspendLayout()
        CardTotalKaryawan.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, DataGajiToolStripMenuItem, LaporanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 4, 0, 4)
        MenuStrip1.Size = New Size(1400, 37)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem})
        FileToolStripMenuItem.ForeColor = Color.White
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "Keluar"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(270, 34)
        LogoutToolStripMenuItem.Text = "&Logout"
        ' 
        ' DataGajiToolStripMenuItem
        ' 
        DataGajiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ImporDataCSVToolStripMenuItem})
        DataGajiToolStripMenuItem.ForeColor = Color.White
        DataGajiToolStripMenuItem.Name = "DataGajiToolStripMenuItem"
        DataGajiToolStripMenuItem.Size = New Size(99, 29)
        DataGajiToolStripMenuItem.Text = "Data Gaji"
        ' 
        ' ImporDataCSVToolStripMenuItem
        ' 
        ImporDataCSVToolStripMenuItem.Name = "ImporDataCSVToolStripMenuItem"
        ImporDataCSVToolStripMenuItem.Size = New Size(270, 34)
        ImporDataCSVToolStripMenuItem.Text = "&Impor Data (CSV)"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CetakBuktiPotongToolStripMenuItem})
        LaporanToolStripMenuItem.ForeColor = Color.White
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(92, 29)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' CetakBuktiPotongToolStripMenuItem
        ' 
        CetakBuktiPotongToolStripMenuItem.Name = "CetakBuktiPotongToolStripMenuItem"
        CetakBuktiPotongToolStripMenuItem.Size = New Size(270, 34)
        CetakBuktiPotongToolStripMenuItem.Text = "Cetak Bukti Potong"
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
        ToolStripStatusLabel1.Size = New Size(288, 25)
        ToolStripStatusLabel1.Text = "TaxEase - Dashboard Pemberi Kerja"
        ' 
        ' PanelContent
        ' 
        PanelContent.AutoScroll = True
        PanelContent.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        PanelContent.Controls.Add(GroupBoxDataKaryawan)
        PanelContent.Controls.Add(PanelCards)
        PanelContent.Controls.Add(LabelTitle)
        PanelContent.Dock = DockStyle.Fill
        PanelContent.Location = New Point(0, 37)
        PanelContent.Name = "PanelContent"
        PanelContent.Size = New Size(1400, 831)
        PanelContent.TabIndex = 2
        ' 
        ' GroupBoxDataKaryawan
        ' 
        GroupBoxDataKaryawan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBoxDataKaryawan.BackColor = Color.White
        GroupBoxDataKaryawan.Controls.Add(DataGridViewKaryawan)
        GroupBoxDataKaryawan.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        GroupBoxDataKaryawan.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxDataKaryawan.Location = New Point(30, 230)
        GroupBoxDataKaryawan.Name = "GroupBoxDataKaryawan"
        GroupBoxDataKaryawan.Padding = New Padding(20)
        GroupBoxDataKaryawan.Size = New Size(1340, 571)
        GroupBoxDataKaryawan.TabIndex = 2
        GroupBoxDataKaryawan.TabStop = False
        GroupBoxDataKaryawan.Text = "Data Karyawan"
        ' 
        ' DataGridViewKaryawan
        ' 
        DataGridViewKaryawan.AllowUserToAddRows = False
        DataGridViewKaryawan.AllowUserToDeleteRows = False
        DataGridViewKaryawan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewKaryawan.BackgroundColor = Color.White
        DataGridViewKaryawan.BorderStyle = BorderStyle.None
        DataGridViewKaryawan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewKaryawan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewKaryawan.ColumnHeadersHeight = 35
        DataGridViewKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewKaryawan.Columns.AddRange(New DataGridViewColumn() {ColNama, ColNPWP, ColGaji, ColStatus})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(232), CByte(244), CByte(253))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewKaryawan.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewKaryawan.EnableHeadersVisualStyles = False
        DataGridViewKaryawan.GridColor = Color.FromArgb(CByte(222), CByte(226), CByte(230))
        DataGridViewKaryawan.Location = New Point(20, 50)
        DataGridViewKaryawan.Name = "DataGridViewKaryawan"
        DataGridViewKaryawan.ReadOnly = True
        DataGridViewKaryawan.RowHeadersVisible = False
        DataGridViewKaryawan.RowHeadersWidth = 51
        DataGridViewKaryawan.RowTemplate.Height = 32
        DataGridViewKaryawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewKaryawan.Size = New Size(1300, 501)
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
        ' ColNPWP
        ' 
        ColNPWP.HeaderText = "NPWP"
        ColNPWP.MinimumWidth = 6
        ColNPWP.Name = "ColNPWP"
        ColNPWP.ReadOnly = True
        ColNPWP.Width = 300
        ' 
        ' ColGaji
        ' 
        ColGaji.HeaderText = "Gaji Bulanan"
        ColGaji.MinimumWidth = 6
        ColGaji.Name = "ColGaji"
        ColGaji.ReadOnly = True
        ColGaji.Width = 300
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
        PanelCards.BackColor = Color.Transparent
        PanelCards.Controls.Add(CardTotalPajak)
        PanelCards.Controls.Add(CardTotalGaji)
        PanelCards.Controls.Add(CardTotalKaryawan)
        PanelCards.Location = New Point(30, 70)
        PanelCards.Name = "PanelCards"
        PanelCards.Size = New Size(1340, 140)
        PanelCards.TabIndex = 1
        ' 
        ' CardTotalPajak
        ' 
        CardTotalPajak.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        CardTotalPajak.Controls.Add(LabelTotalPajakValue)
        CardTotalPajak.Controls.Add(LabelTotalPajakTitle)
        CardTotalPajak.Location = New Point(920, 0)
        CardTotalPajak.Name = "CardTotalPajak"
        CardTotalPajak.Size = New Size(400, 120)
        CardTotalPajak.TabIndex = 2
        ' 
        ' LabelTotalPajakValue
        ' 
        LabelTotalPajakValue.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        LabelTotalPajakValue.ForeColor = Color.White
        LabelTotalPajakValue.Location = New Point(20, 60)
        LabelTotalPajakValue.Name = "LabelTotalPajakValue"
        LabelTotalPajakValue.Size = New Size(360, 50)
        LabelTotalPajakValue.TabIndex = 1
        LabelTotalPajakValue.Text = "Rp 0"
        ' 
        ' LabelTotalPajakTitle
        ' 
        LabelTotalPajakTitle.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelTotalPajakTitle.ForeColor = Color.White
        LabelTotalPajakTitle.Location = New Point(20, 15)
        LabelTotalPajakTitle.Name = "LabelTotalPajakTitle"
        LabelTotalPajakTitle.Size = New Size(360, 30)
        LabelTotalPajakTitle.TabIndex = 0
        LabelTotalPajakTitle.Text = "📊 Total Pajak"
        ' 
        ' CardTotalGaji
        ' 
        CardTotalGaji.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        CardTotalGaji.Controls.Add(LabelTotalGajiValue)
        CardTotalGaji.Controls.Add(LabelTotalGajiTitle)
        CardTotalGaji.Location = New Point(470, 0)
        CardTotalGaji.Name = "CardTotalGaji"
        CardTotalGaji.Size = New Size(400, 120)
        CardTotalGaji.TabIndex = 1
        ' 
        ' LabelTotalGajiValue
        ' 
        LabelTotalGajiValue.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        LabelTotalGajiValue.ForeColor = Color.White
        LabelTotalGajiValue.Location = New Point(20, 60)
        LabelTotalGajiValue.Name = "LabelTotalGajiValue"
        LabelTotalGajiValue.Size = New Size(360, 50)
        LabelTotalGajiValue.TabIndex = 1
        LabelTotalGajiValue.Text = "Rp 0"
        ' 
        ' LabelTotalGajiTitle
        ' 
        LabelTotalGajiTitle.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelTotalGajiTitle.ForeColor = Color.White
        LabelTotalGajiTitle.Location = New Point(20, 15)
        LabelTotalGajiTitle.Name = "LabelTotalGajiTitle"
        LabelTotalGajiTitle.Size = New Size(360, 30)
        LabelTotalGajiTitle.TabIndex = 0
        LabelTotalGajiTitle.Text = "💰 Total Gaji"
        ' 
        ' CardTotalKaryawan
        ' 
        CardTotalKaryawan.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        CardTotalKaryawan.Controls.Add(LabelTotalKaryawanValue)
        CardTotalKaryawan.Controls.Add(LabelTotalKaryawanTitle)
        CardTotalKaryawan.Location = New Point(20, 0)
        CardTotalKaryawan.Name = "CardTotalKaryawan"
        CardTotalKaryawan.Size = New Size(400, 120)
        CardTotalKaryawan.TabIndex = 0
        ' 
        ' LabelTotalKaryawanValue
        ' 
        LabelTotalKaryawanValue.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        LabelTotalKaryawanValue.ForeColor = Color.White
        LabelTotalKaryawanValue.Location = New Point(20, 60)
        LabelTotalKaryawanValue.Name = "LabelTotalKaryawanValue"
        LabelTotalKaryawanValue.Size = New Size(360, 50)
        LabelTotalKaryawanValue.TabIndex = 1
        LabelTotalKaryawanValue.Text = "0"
        ' 
        ' LabelTotalKaryawanTitle
        ' 
        LabelTotalKaryawanTitle.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelTotalKaryawanTitle.ForeColor = Color.White
        LabelTotalKaryawanTitle.Location = New Point(20, 15)
        LabelTotalKaryawanTitle.Name = "LabelTotalKaryawanTitle"
        LabelTotalKaryawanTitle.Size = New Size(360, 30)
        LabelTotalKaryawanTitle.TabIndex = 0
        LabelTotalKaryawanTitle.Text = "👥 Total Karyawan"
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelTitle.Location = New Point(30, 20)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(396, 41)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Selamat Datang, Pemberi Kerja"
        ' 
        ' Dashboard_PK
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        ClientSize = New Size(1400, 900)
        Controls.Add(PanelContent)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.Sizable
        MainMenuStrip = MenuStrip1
        MaximizeBox = True
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
        GroupBoxDataKaryawan.ResumeLayout(False)
        CType(DataGridViewKaryawan, ComponentModel.ISupportInitialize).EndInit()
        PanelCards.ResumeLayout(False)
        CardTotalPajak.ResumeLayout(False)
        CardTotalGaji.ResumeLayout(False)
        CardTotalKaryawan.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGajiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImporDataCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakBuktiPotongToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PanelCards As Panel
    Friend WithEvents CardTotalKaryawan As Panel
    Friend WithEvents LabelTotalKaryawanTitle As Label
    Friend WithEvents LabelTotalKaryawanValue As Label
    Friend WithEvents CardTotalGaji As Panel
    Friend WithEvents LabelTotalGajiTitle As Label
    Friend WithEvents LabelTotalGajiValue As Label
    Friend WithEvents CardTotalPajak As Panel
    Friend WithEvents LabelTotalPajakTitle As Label
    Friend WithEvents LabelTotalPajakValue As Label
    Friend WithEvents GroupBoxDataKaryawan As GroupBox
    Friend WithEvents DataGridViewKaryawan As DataGridView
    Friend WithEvents ColNama As DataGridViewTextBoxColumn
    Friend WithEvents ColNPWP As DataGridViewTextBoxColumn
    Friend WithEvents ColGaji As DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As DataGridViewTextBoxColumn

End Class
