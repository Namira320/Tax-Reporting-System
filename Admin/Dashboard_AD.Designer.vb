<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_AD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If Not disposing OrElse components IsNot Not Nothing Then
                Return
            End If
                components.Dispose()
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
        menuMain = New MenuStrip()
        menuManajemenPengguna = New ToolStripMenuItem()
        menuPengaturanAdmin = New ToolStripMenuItem()
        pnlStats = New Panel()
        pnlTelat = New Panel()
        lblTelatDesc = New Label()
        lblTelatCount = New Label()
        pnlBelum = New Panel()
        lblBelumDesc = New Label()
        lblBelumCount = New Label()
        pnlSudah = New Panel()
        lblSudahDesc = New Label()
        lblSudahCount = New Label()
        grpDetail = New GroupBox()
        btnExportPDF = New Button()
        btnExportExcel = New Button()
        dgvKepatuhan = New DataGridView()
        colNamaWP = New DataGridViewTextBoxColumn()
        colTanggalLapor = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        grpPengaturan = New GroupBox()
        btnSimpanPengaturan = New Button()
        dtpBatasLapor = New DateTimePicker()
        lblBatasTanggal = New Label()
        menuMain.SuspendLayout()
        pnlStats.SuspendLayout()
        pnlTelat.SuspendLayout()
        pnlBelum.SuspendLayout()
        pnlSudah.SuspendLayout()
        grpDetail.SuspendLayout()
        CType(dgvKepatuhan, ComponentModel.ISupportInitialize).BeginInit()
        grpPengaturan.SuspendLayout()
        SuspendLayout()
        '
        'menuMain
        '
        menuMain.ImageScalingSize = New Size(24, 24)
        menuMain.Items.AddRange(New ToolStripItem() {menuManajemenPengguna, menuPengaturanAdmin})
        menuMain.Location = New Point(0, 0)
        menuMain.Name = "menuMain"
        menuMain.Padding = New Padding(9, 3, 0, 3)
        menuMain.Size = New Size(1600, 35)
        menuMain.TabIndex = 0
        menuMain.Text = "MenuStrip1"
        '
        'menuManajemenPengguna
        '
        menuManajemenPengguna.Name = "menuManajemenPengguna"
        menuManajemenPengguna.Size = New Size(226, 29)
        menuManajemenPengguna.Text = "Manajemen Pengguna"
        '
        'menuPengaturanAdmin
        '
        menuPengaturanAdmin.Name = "menuPengaturanAdmin"
        menuPengaturanAdmin.Size = New Size(188, 29)
        menuPengaturanAdmin.Text = "Pengaturan Admin"
        ' 
        ' pnlStats
        ' 
        pnlStats.Controls.Add(pnlTelat)
        pnlStats.Controls.Add(pnlBelum)
        pnlStats.Controls.Add(pnlSudah)
        pnlStats.Dock = DockStyle.Top
        pnlStats.Location = New Point(0, 35)
        pnlStats.Margin = New Padding(5, 6, 5, 6)
        pnlStats.Name = "pnlStats"
        pnlStats.Padding = New Padding(25, 29, 25, 10)
        pnlStats.Size = New Size(1600, 250)
        pnlStats.TabIndex = 0
        ' 
        ' pnlTelat
        ' 
        pnlTelat.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTelat.BackColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        pnlTelat.Controls.Add(lblTelatDesc)
        pnlTelat.Controls.Add(lblTelatCount)
        pnlTelat.Location = New Point(1070, 29)
        pnlTelat.Margin = New Padding(5, 6, 5, 6)
        pnlTelat.Name = "pnlTelat"
        pnlTelat.Size = New Size(505, 192)
        pnlTelat.TabIndex = 2
        ' 
        ' lblTelatDesc
        ' 
        lblTelatDesc.AutoSize = True
        lblTelatDesc.Font = New Font("Microsoft Sans Serif", 9F)
        lblTelatDesc.ForeColor = Color.White
        lblTelatDesc.Location = New Point(27, 119)
        lblTelatDesc.Margin = New Padding(5, 0, 5, 0)
        lblTelatDesc.Name = "lblTelatDesc"
        lblTelatDesc.Size = New Size(102, 22)
        lblTelatDesc.TabIndex = 1
        lblTelatDesc.Text = "Telat Lapor"
        ' 
        ' lblTelatCount
        ' 
        lblTelatCount.AutoSize = True
        lblTelatCount.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblTelatCount.ForeColor = Color.White
        lblTelatCount.Location = New Point(20, 33)
        lblTelatCount.Margin = New Padding(5, 0, 5, 0)
        lblTelatCount.Name = "lblTelatCount"
        lblTelatCount.Size = New Size(209, 65)
        lblTelatCount.TabIndex = 0
        lblTelatCount.Text = "0 Orang"
        ' 
        ' pnlBelum
        ' 
        pnlBelum.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlBelum.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        pnlBelum.Controls.Add(lblBelumDesc)
        pnlBelum.Controls.Add(lblBelumCount)
        pnlBelum.Location = New Point(548, 29)
        pnlBelum.Margin = New Padding(5, 6, 5, 6)
        pnlBelum.Name = "pnlBelum"
        pnlBelum.Size = New Size(505, 192)
        pnlBelum.TabIndex = 1
        ' 
        ' lblBelumDesc
        ' 
        lblBelumDesc.AutoSize = True
        lblBelumDesc.Font = New Font("Microsoft Sans Serif", 9F)
        lblBelumDesc.ForeColor = Color.Black
        lblBelumDesc.Location = New Point(28, 119)
        lblBelumDesc.Margin = New Padding(5, 0, 5, 0)
        lblBelumDesc.Name = "lblBelumDesc"
        lblBelumDesc.Size = New Size(111, 22)
        lblBelumDesc.TabIndex = 1
        lblBelumDesc.Text = "Belum Lapor"
        ' 
        ' lblBelumCount
        ' 
        lblBelumCount.AutoSize = True
        lblBelumCount.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblBelumCount.ForeColor = Color.Black
        lblBelumCount.Location = New Point(22, 33)
        lblBelumCount.Margin = New Padding(5, 0, 5, 0)
        lblBelumCount.Name = "lblBelumCount"
        lblBelumCount.Size = New Size(209, 65)
        lblBelumCount.TabIndex = 0
        lblBelumCount.Text = "0 Orang"
        ' 
        ' pnlSudah
        ' 
        pnlSudah.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSudah.BackColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        pnlSudah.Controls.Add(lblSudahDesc)
        pnlSudah.Controls.Add(lblSudahCount)
        pnlSudah.Location = New Point(25, 29)
        pnlSudah.Margin = New Padding(5, 6, 5, 6)
        pnlSudah.Name = "pnlSudah"
        pnlSudah.Size = New Size(505, 192)
        pnlSudah.TabIndex = 0
        ' 
        ' lblSudahDesc
        ' 
        lblSudahDesc.AutoSize = True
        lblSudahDesc.Font = New Font("Microsoft Sans Serif", 9F)
        lblSudahDesc.ForeColor = Color.White
        lblSudahDesc.Location = New Point(30, 119)
        lblSudahDesc.Margin = New Padding(5, 0, 5, 0)
        lblSudahDesc.Name = "lblSudahDesc"
        lblSudahDesc.Size = New Size(113, 22)
        lblSudahDesc.TabIndex = 1
        lblSudahDesc.Text = "Sudah Lapor"
        ' 
        ' lblSudahCount
        ' 
        lblSudahCount.AutoSize = True
        lblSudahCount.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblSudahCount.ForeColor = Color.White
        lblSudahCount.Location = New Point(23, 33)
        lblSudahCount.Margin = New Padding(5, 0, 5, 0)
        lblSudahCount.Name = "lblSudahCount"
        lblSudahCount.Size = New Size(209, 65)
        lblSudahCount.TabIndex = 0
        lblSudahCount.Text = "0 Orang"
        ' 
        ' grpDetail
        ' 
        grpDetail.Controls.Add(btnExportPDF)
        grpDetail.Controls.Add(btnExportExcel)
        grpDetail.Controls.Add(dgvKepatuhan)
        grpDetail.Dock = DockStyle.Fill
        grpDetail.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpDetail.Location = New Point(0, 285)
        grpDetail.Margin = New Padding(5, 6, 5, 6)
        grpDetail.Name = "grpDetail"
        grpDetail.Padding = New Padding(25, 29, 25, 10)
        grpDetail.Size = New Size(1600, 627)
        grpDetail.TabIndex = 1
        grpDetail.TabStop = False
        grpDetail.Text = "Detail Kepatuhan"
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExportPDF.BackColor = Color.FromArgb(CByte(183), CByte(28), CByte(28))
        btnExportPDF.FlatAppearance.BorderSize = 0
        btnExportPDF.FlatStyle = FlatStyle.Flat
        btnExportPDF.ForeColor = Color.White
        btnExportPDF.Location = New Point(1382, 42)
        btnExportPDF.Margin = New Padding(5, 6, 5, 6)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(177, 58)
        btnExportPDF.TabIndex = 2
        btnExportPDF.Text = "Export PDF"
        btnExportPDF.UseVisualStyleBackColor = False
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExportExcel.BackColor = Color.FromArgb(CByte(2), CByte(136), CByte(209))
        btnExportExcel.FlatAppearance.BorderSize = 0
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.ForeColor = Color.White
        btnExportExcel.Location = New Point(1188, 42)
        btnExportExcel.Margin = New Padding(5, 6, 5, 6)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(183, 58)
        btnExportExcel.TabIndex = 1
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' dgvKepatuhan
        ' 
        dgvKepatuhan.AllowUserToAddRows = False
        dgvKepatuhan.AllowUserToDeleteRows = False
        dgvKepatuhan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvKepatuhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKepatuhan.Columns.AddRange(New DataGridViewColumn() {colNamaWP, colTanggalLapor, colStatus})
        dgvKepatuhan.Location = New Point(30, 112)
        dgvKepatuhan.Margin = New Padding(5, 6, 5, 6)
        dgvKepatuhan.Name = "dgvKepatuhan"
        dgvKepatuhan.ReadOnly = True
        dgvKepatuhan.RowHeadersVisible = False
        dgvKepatuhan.RowHeadersWidth = 62
        dgvKepatuhan.Size = New Size(1528, 481)
        dgvKepatuhan.TabIndex = 0
        ' 
        ' colNamaWP
        ' 
        colNamaWP.DataPropertyName = "NamaWP"
        colNamaWP.HeaderText = "Nama WP"
        colNamaWP.MinimumWidth = 8
        colNamaWP.Name = "colNamaWP"
        colNamaWP.ReadOnly = True
        colNamaWP.Width = 250
        ' 
        ' colTanggalLapor
        ' 
        colTanggalLapor.DataPropertyName = "TanggalLapor"
        colTanggalLapor.HeaderText = "Tanggal Lapor"
        colTanggalLapor.MinimumWidth = 8
        colTanggalLapor.Name = "colTanggalLapor"
        colTanggalLapor.ReadOnly = True
        colTanggalLapor.Width = 150
        ' 
        ' colStatus
        ' 
        colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colStatus.DataPropertyName = "StatusKepatuhan"
        colStatus.HeaderText = "Status Kepatuhan"
        colStatus.MinimumWidth = 8
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' grpPengaturan
        ' 
        grpPengaturan.Controls.Add(btnSimpanPengaturan)
        grpPengaturan.Controls.Add(dtpBatasLapor)
        grpPengaturan.Controls.Add(lblBatasTanggal)
        grpPengaturan.Dock = DockStyle.Bottom
        grpPengaturan.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpPengaturan.Location = New Point(0, 912)
        grpPengaturan.Margin = New Padding(5, 6, 5, 6)
        grpPengaturan.Name = "grpPengaturan"
        grpPengaturan.Padding = New Padding(25, 29, 25, 29)
        grpPengaturan.Size = New Size(1600, 173)
        grpPengaturan.TabIndex = 2
        grpPengaturan.TabStop = False
        grpPengaturan.Text = "Pengaturan Batas Waktu"
        ' 
        ' btnSimpanPengaturan
        ' 
        btnSimpanPengaturan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSimpanPengaturan.BackColor = Color.FromArgb(CByte(67), CByte(160), CByte(71))
        btnSimpanPengaturan.FlatAppearance.BorderSize = 0
        btnSimpanPengaturan.FlatStyle = FlatStyle.Flat
        btnSimpanPengaturan.ForeColor = Color.White
        btnSimpanPengaturan.Location = New Point(1362, 67)
        btnSimpanPengaturan.Margin = New Padding(5, 6, 5, 6)
        btnSimpanPengaturan.Name = "btnSimpanPengaturan"
        btnSimpanPengaturan.Size = New Size(230, 58)
        btnSimpanPengaturan.TabIndex = 2
        btnSimpanPengaturan.Text = "Simpan Pengaturan"
        btnSimpanPengaturan.UseVisualStyleBackColor = False
        ' 
        ' dtpBatasLapor
        ' 
        dtpBatasLapor.CustomFormat = "dd MMMM yyyy"
        dtpBatasLapor.Font = New Font("Microsoft Sans Serif", 9.75F)
        dtpBatasLapor.Format = DateTimePickerFormat.Custom
        dtpBatasLapor.Location = New Point(265, 73)
        dtpBatasLapor.Margin = New Padding(5, 6, 5, 6)
        dtpBatasLapor.Name = "dtpBatasLapor"
        dtpBatasLapor.Size = New Size(364, 30)
        dtpBatasLapor.TabIndex = 1
        dtpBatasLapor.Value = New Date(2024, 3, 31, 0, 0, 0, 0)
        ' 
        ' lblBatasTanggal
        ' 
        lblBatasTanggal.AutoSize = True
        lblBatasTanggal.Location = New Point(30, 79)
        lblBatasTanggal.Margin = New Padding(5, 0, 5, 0)
        lblBatasTanggal.Name = "lblBatasTanggal"
        lblBatasTanggal.Size = New Size(183, 22)
        lblBatasTanggal.TabIndex = 0
        lblBatasTanggal.Text = "Batas Tanggal Lapor:"
        ' 
        ' Dashboard_AD
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1600, 1050)
        Controls.Add(grpDetail)
        Controls.Add(grpPengaturan)
        Controls.Add(pnlStats)
        Controls.Add(menuMain)
        MainMenuStrip = menuMain
        Margin = New Padding(5, 6, 5, 6)
        MinimumSize = New Size(1485, 1006)
        Name = "Dashboard_AD"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard Monitoring Kepatuhan"
        menuMain.ResumeLayout(False)
        menuMain.PerformLayout()
        pnlStats.ResumeLayout(False)
        pnlTelat.ResumeLayout(False)
        pnlTelat.PerformLayout()
        pnlBelum.ResumeLayout(False)
        pnlBelum.PerformLayout()
        pnlSudah.ResumeLayout(False)
        pnlSudah.PerformLayout()
        grpDetail.ResumeLayout(False)
        CType(dgvKepatuhan, ComponentModel.ISupportInitialize).EndInit()
        grpPengaturan.ResumeLayout(False)
        grpPengaturan.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents menuManajemenPengguna As ToolStripMenuItem
    Friend WithEvents menuPengaturanAdmin As ToolStripMenuItem
    Friend WithEvents pnlStats As System.Windows.Forms.Panel
    Friend WithEvents pnlTelat As System.Windows.Forms.Panel
    Friend WithEvents lblTelatDesc As System.Windows.Forms.Label
    Friend WithEvents lblTelatCount As System.Windows.Forms.Label
    Friend WithEvents pnlBelum As System.Windows.Forms.Panel
    Friend WithEvents lblBelumDesc As System.Windows.Forms.Label
    Friend WithEvents lblBelumCount As System.Windows.Forms.Label
    Friend WithEvents pnlSudah As System.Windows.Forms.Panel
    Friend WithEvents lblSudahDesc As System.Windows.Forms.Label
    Friend WithEvents lblSudahCount As System.Windows.Forms.Label
    Friend WithEvents grpDetail As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportPDF As System.Windows.Forms.Button
    Friend WithEvents btnExportExcel As System.Windows.Forms.Button
    Friend WithEvents dgvKepatuhan As System.Windows.Forms.DataGridView
    Friend WithEvents grpPengaturan As System.Windows.Forms.GroupBox
    Friend WithEvents btnSimpanPengaturan As System.Windows.Forms.Button
    Friend WithEvents dtpBatasLapor As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBatasTanggal As System.Windows.Forms.Label
    Friend WithEvents colNamaWP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTanggalLapor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

