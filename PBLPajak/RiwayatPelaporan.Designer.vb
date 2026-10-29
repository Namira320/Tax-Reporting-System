<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Riwayat_Pelaporan
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
        PanelActions = New FlowLayoutPanel()
        ButtonDetail = New Button()
        ButtonExport = New Button()
        btnKembali = New Button()
        DataGridViewRiwayat = New DataGridView()
        PanelSummary = New Panel()
        LabelSummaryValue = New Label()
        LabelSummaryTitle = New Label()
        PanelFilters = New Panel()
        ButtonReset = New Button()
        ButtonCari = New Button()
        ComboBoxStatus = New ComboBox()
        LabelStatus = New Label()
        ComboBoxTahun = New ComboBox()
        LabelTahun = New Label()
        TextBoxNPWP = New TextBox()
        LabelNPWP = New Label()
        LabelDescription = New Label()
        LabelTitle = New Label()
        PanelWrapper.SuspendLayout()
        PanelActions.SuspendLayout()
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        PanelSummary.SuspendLayout()
        PanelFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelWrapper
        ' 
        PanelWrapper.Anchor = AnchorStyles.None
        PanelWrapper.BackColor = Color.White
        PanelWrapper.Controls.Add(PanelActions)
        PanelWrapper.Controls.Add(DataGridViewRiwayat)
        PanelWrapper.Controls.Add(PanelSummary)
        PanelWrapper.Controls.Add(PanelFilters)
        PanelWrapper.Controls.Add(LabelDescription)
        PanelWrapper.Controls.Add(LabelTitle)
        PanelWrapper.Location = New Point(80, 40)
        PanelWrapper.Name = "PanelWrapper"
        PanelWrapper.Padding = New Padding(32)
        PanelWrapper.Size = New Size(960, 640)
        PanelWrapper.TabIndex = 0
        ' 
        ' PanelActions
        ' 
        PanelActions.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PanelActions.Controls.Add(ButtonDetail)
        PanelActions.Controls.Add(ButtonExport)
        PanelActions.Controls.Add(btnKembali)
        PanelActions.FlowDirection = FlowDirection.RightToLeft
        PanelActions.Location = New Point(400, 566)
        PanelActions.Name = "PanelActions"
        PanelActions.Padding = New Padding(0, 16, 0, 0)
        PanelActions.Size = New Size(520, 64)
        PanelActions.TabIndex = 6
        ' 
        ' ButtonDetail
        ' 
        ButtonDetail.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        ButtonDetail.Cursor = Cursors.Hand
        ButtonDetail.FlatAppearance.BorderSize = 0
        ButtonDetail.FlatStyle = FlatStyle.Flat
        ButtonDetail.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonDetail.ForeColor = Color.White
        ButtonDetail.Location = New Point(224, 19)
        ButtonDetail.Margin = New Padding(8, 3, 8, 3)
        ButtonDetail.Name = "ButtonDetail"
        ButtonDetail.Size = New Size(128, 40)
        ButtonDetail.TabIndex = 0
        ButtonDetail.Text = "Detail"
        ButtonDetail.UseVisualStyleBackColor = False
        ' 
        ' ButtonExport
        ' 
        ButtonExport.BackColor = Color.White
        ButtonExport.Cursor = Cursors.Hand
        ButtonExport.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(214), CByte(224))
        ButtonExport.FlatStyle = FlatStyle.Flat
        ButtonExport.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonExport.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        ButtonExport.Location = New Point(80, 19)
        ButtonExport.Margin = New Padding(8, 3, 8, 3)
        ButtonExport.Name = "ButtonExport"
        ButtonExport.Size = New Size(128, 40)
        ButtonExport.TabIndex = 1
        ButtonExport.Text = "Ekspor Excel"
        ButtonExport.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.White
        btnKembali.Cursor = Cursors.Hand
        btnKembali.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(214), CByte(224))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        btnKembali.Location = New Point(200, 19)
        btnKembali.Margin = New Padding(8, 3, 8, 3)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(140, 40)
        btnKembali.TabIndex = 2
        btnKembali.Text = "← Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewRiwayat
        ' 
        DataGridViewRiwayat.AllowUserToAddRows = False
        DataGridViewRiwayat.AllowUserToDeleteRows = False
        DataGridViewRiwayat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewRiwayat.BackgroundColor = Color.White
        DataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewRiwayat.Location = New Point(40, 296)
        DataGridViewRiwayat.MultiSelect = False
        DataGridViewRiwayat.Name = "DataGridViewRiwayat"
        DataGridViewRiwayat.ReadOnly = True
        DataGridViewRiwayat.RowHeadersVisible = False
        DataGridViewRiwayat.RowTemplate.Height = 32
        DataGridViewRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewRiwayat.Size = New Size(880, 264)
        DataGridViewRiwayat.TabIndex = 5
        ' 
        ' PanelSummary
        ' 
        PanelSummary.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PanelSummary.BackColor = Color.FromArgb(CByte(238), CByte(244), CByte(255))
        PanelSummary.Controls.Add(LabelSummaryValue)
        PanelSummary.Controls.Add(LabelSummaryTitle)
        PanelSummary.Location = New Point(720, 40)
        PanelSummary.Name = "PanelSummary"
        PanelSummary.Size = New Size(200, 88)
        PanelSummary.TabIndex = 4
        ' 
        ' LabelSummaryValue
        ' 
        LabelSummaryValue.AutoSize = True
        LabelSummaryValue.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSummaryValue.ForeColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        LabelSummaryValue.Location = New Point(24, 30)
        LabelSummaryValue.Name = "LabelSummaryValue"
        LabelSummaryValue.Size = New Size(74, 32)
        LabelSummaryValue.TabIndex = 1
        LabelSummaryValue.Text = "0 SPT"
        ' 
        ' LabelSummaryTitle
        ' 
        LabelSummaryTitle.AutoSize = True
        LabelSummaryTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSummaryTitle.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelSummaryTitle.Location = New Point(24, 8)
        LabelSummaryTitle.Name = "LabelSummaryTitle"
        LabelSummaryTitle.Size = New Size(88, 15)
        LabelSummaryTitle.TabIndex = 0
        LabelSummaryTitle.Text = "Total pelaporan"
        ' 
        ' PanelFilters
        ' 
        PanelFilters.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelFilters.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(252))
        PanelFilters.Controls.Add(ButtonReset)
        PanelFilters.Controls.Add(ButtonCari)
        PanelFilters.Controls.Add(ComboBoxStatus)
        PanelFilters.Controls.Add(LabelStatus)
        PanelFilters.Controls.Add(ComboBoxTahun)
        PanelFilters.Controls.Add(LabelTahun)
        PanelFilters.Controls.Add(TextBoxNPWP)
        PanelFilters.Controls.Add(LabelNPWP)
        PanelFilters.Location = New Point(40, 144)
        PanelFilters.Name = "PanelFilters"
        PanelFilters.Padding = New Padding(16)
        PanelFilters.Size = New Size(880, 128)
        PanelFilters.TabIndex = 3
        ' 
        ' ButtonReset
        ' 
        ButtonReset.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonReset.BackColor = Color.White
        ButtonReset.Cursor = Cursors.Hand
        ButtonReset.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(214), CByte(224))
        ButtonReset.FlatStyle = FlatStyle.Flat
        ButtonReset.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonReset.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        ButtonReset.Location = New Point(744, 72)
        ButtonReset.Name = "ButtonReset"
        ButtonReset.Size = New Size(104, 40)
        ButtonReset.TabIndex = 7
        ButtonReset.Text = "Reset"
        ButtonReset.UseVisualStyleBackColor = False
        ' 
        ' ButtonCari
        ' 
        ButtonCari.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonCari.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        ButtonCari.Cursor = Cursors.Hand
        ButtonCari.FlatAppearance.BorderSize = 0
        ButtonCari.FlatStyle = FlatStyle.Flat
        ButtonCari.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCari.ForeColor = Color.White
        ButtonCari.Location = New Point(616, 72)
        ButtonCari.Name = "ButtonCari"
        ButtonCari.Size = New Size(120, 40)
        ButtonCari.TabIndex = 6
        ButtonCari.Text = "Cari"
        ButtonCari.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxStatus
        ' 
        ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxStatus.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxStatus.FormattingEnabled = True
        ComboBoxStatus.Items.AddRange(New Object() {"Semua status", "Normal", "Pembetulan", "Terlambat"})
        ComboBoxStatus.Location = New Point(432, 72)
        ComboBoxStatus.Name = "ComboBoxStatus"
        ComboBoxStatus.Size = New Size(168, 25)
        ComboBoxStatus.TabIndex = 5
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelStatus.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelStatus.Location = New Point(432, 32)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(95, 15)
        LabelStatus.TabIndex = 4
        LabelStatus.Text = "Status pelaporan"
        ' 
        ' ComboBoxTahun
        ' 
        ComboBoxTahun.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxTahun.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxTahun.FormattingEnabled = True
        ComboBoxTahun.Items.AddRange(New Object() {"2025", "2024", "2023", "2022"})
        ComboBoxTahun.Location = New Point(240, 72)
        ComboBoxTahun.Name = "ComboBoxTahun"
        ComboBoxTahun.Size = New Size(168, 25)
        ComboBoxTahun.TabIndex = 3
        ' 
        ' LabelTahun
        ' 
        LabelTahun.AutoSize = True
        LabelTahun.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTahun.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelTahun.Location = New Point(240, 32)
        LabelTahun.Name = "LabelTahun"
        LabelTahun.Size = New Size(70, 15)
        LabelTahun.TabIndex = 2
        LabelTahun.Text = "Tahun pajak"
        ' 
        ' TextBoxNPWP
        ' 
        TextBoxNPWP.BorderStyle = BorderStyle.FixedSingle
        TextBoxNPWP.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxNPWP.Location = New Point(24, 72)
        TextBoxNPWP.Name = "TextBoxNPWP"
        TextBoxNPWP.PlaceholderText = "Cari berdasarkan NPWP / nama"
        TextBoxNPWP.Size = New Size(192, 25)
        TextBoxNPWP.TabIndex = 1
        ' 
        ' LabelNPWP
        ' 
        LabelNPWP.AutoSize = True
        LabelNPWP.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNPWP.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelNPWP.Location = New Point(24, 32)
        LabelNPWP.Name = "LabelNPWP"
        LabelNPWP.Size = New Size(131, 15)
        LabelNPWP.TabIndex = 0
        LabelNPWP.Text = "Pencarian NPWP/nama"
        ' 
        ' LabelDescription
        ' 
        LabelDescription.AutoSize = True
        LabelDescription.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelDescription.ForeColor = Color.FromArgb(CByte(102), CByte(108), CByte(122))
        LabelDescription.Location = New Point(40, 96)
        LabelDescription.MaximumSize = New Size(560, 0)
        LabelDescription.Name = "LabelDescription"
        LabelDescription.Size = New Size(340, 15)
        LabelDescription.TabIndex = 2
        LabelDescription.Text = "Lacak riwayat pengajuan SPT Anda dan status penyelesaiannya."
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        LabelTitle.Location = New Point(40, 40)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(263, 32)
        LabelTitle.TabIndex = 1
        LabelTitle.Text = "Riwayat Pelaporan SPT"
        ' 
        ' Riwayat_Pelaporan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(252))
        ClientSize = New Size(1120, 720)
        Controls.Add(PanelWrapper)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "Riwayat_Pelaporan"
        Padding = New Padding(40)
        StartPosition = FormStartPosition.CenterParent
        Text = "Coretax | Riwayat Pelaporan"
        PanelWrapper.ResumeLayout(False)
        PanelWrapper.PerformLayout()
        PanelActions.ResumeLayout(False)
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).EndInit()
        PanelSummary.ResumeLayout(False)
        PanelSummary.PerformLayout()
        PanelFilters.ResumeLayout(False)
        PanelFilters.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PanelFilters As Panel
    Friend WithEvents TextBoxNPWP As TextBox
    Friend WithEvents LabelNPWP As Label
    Friend WithEvents ComboBoxTahun As ComboBox
    Friend WithEvents LabelTahun As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonCari As Button
    Friend WithEvents PanelSummary As Panel
    Friend WithEvents LabelSummaryValue As Label
    Friend WithEvents LabelSummaryTitle As Label
    Friend WithEvents DataGridViewRiwayat As DataGridView
    Friend WithEvents PanelActions As FlowLayoutPanel
    Friend WithEvents ButtonDetail As Button
    Friend WithEvents ButtonExport As Button
    Friend WithEvents btnKembali As Button
End Class
