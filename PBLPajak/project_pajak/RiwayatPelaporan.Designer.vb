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
        ButtonKembali = New Button()
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
        Button1 = New Button()
        PanelWrapper.SuspendLayout()
        PanelActions.SuspendLayout()
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        PanelSummary.SuspendLayout()
        PanelFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelWrapper
        ' 
        PanelWrapper.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelWrapper.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelWrapper.Controls.Add(PanelActions)
        PanelWrapper.Controls.Add(DataGridViewRiwayat)
        PanelWrapper.Controls.Add(PanelSummary)
        PanelWrapper.Controls.Add(PanelFilters)
        PanelWrapper.Controls.Add(LabelDescription)
        PanelWrapper.Controls.Add(LabelTitle)
        PanelWrapper.Location = New Point(4, 2)
        PanelWrapper.Name = "PanelWrapper"
        PanelWrapper.Padding = New Padding(32)
        PanelWrapper.Size = New Size(1924, 1002)
        PanelWrapper.TabIndex = 0
        ' 
        ' PanelActions
        ' 
        PanelActions.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PanelActions.Controls.Add(ButtonKembali)
        PanelActions.Controls.Add(ButtonDetail)
        PanelActions.Controls.Add(Button1)
        PanelActions.FlowDirection = FlowDirection.RightToLeft
        PanelActions.Location = New Point(1335, 852)
        PanelActions.Name = "PanelActions"
        PanelActions.Padding = New Padding(0, 16, 0, 0)
        PanelActions.Size = New Size(554, 90)
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
        ButtonDetail.Location = New Point(218, 19)
        ButtonDetail.Margin = New Padding(8, 3, 8, 3)
        ButtonDetail.Name = "ButtonDetail"
        ButtonDetail.Size = New Size(166, 56)
        ButtonDetail.TabIndex = 0
        ButtonDetail.Text = "Detail"
        ButtonDetail.UseVisualStyleBackColor = False
        ' 
        ' ButtonKembali
        ' 
        ButtonKembali.BackColor = Color.White
        ButtonKembali.Cursor = Cursors.Hand
        ButtonKembali.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(214), CByte(224))
        ButtonKembali.FlatStyle = FlatStyle.Flat
        ButtonKembali.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonKembali.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        ButtonKembali.Location = New Point(400, 19)
        ButtonKembali.Margin = New Padding(8, 3, 8, 3)
        ButtonKembali.Name = "ButtonKembali"
        ButtonKembali.Size = New Size(146, 56)
        ButtonKembali.TabIndex = 1
        ButtonKembali.Text = "Kembali"
        ButtonKembali.UseVisualStyleBackColor = False
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
        DataGridViewRiwayat.RowHeadersWidth = 62
        DataGridViewRiwayat.RowTemplate.Height = 32
        DataGridViewRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewRiwayat.Size = New Size(1844, 550)
        DataGridViewRiwayat.TabIndex = 5
        ' 
        ' PanelSummary
        ' 
        PanelSummary.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PanelSummary.BackColor = Color.FromArgb(CByte(238), CByte(244), CByte(255))
        PanelSummary.Controls.Add(LabelSummaryValue)
        PanelSummary.Controls.Add(LabelSummaryTitle)
        PanelSummary.Location = New Point(1684, 16)
        PanelSummary.Name = "PanelSummary"
        PanelSummary.Size = New Size(200, 112)
        PanelSummary.TabIndex = 4
        ' 
        ' LabelSummaryValue
        ' 
        LabelSummaryValue.AutoSize = True
        LabelSummaryValue.Font = New Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSummaryValue.ForeColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        LabelSummaryValue.Location = New Point(43, 38)
        LabelSummaryValue.Name = "LabelSummaryValue"
        LabelSummaryValue.Size = New Size(116, 61)
        LabelSummaryValue.TabIndex = 1
        LabelSummaryValue.Text = "0 SPT"
        ' 
        ' LabelSummaryTitle
        ' 
        LabelSummaryTitle.AutoSize = True
        LabelSummaryTitle.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSummaryTitle.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelSummaryTitle.Location = New Point(31, 8)
        LabelSummaryTitle.Name = "LabelSummaryTitle"
        LabelSummaryTitle.Size = New Size(125, 30)
        LabelSummaryTitle.TabIndex = 0
        LabelSummaryTitle.Text = "Total pelaporan"
        ' 
        ' PanelFilters
        ' 
        PanelFilters.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelFilters.BackColor = Color.White
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
        PanelFilters.Size = New Size(1844, 128)
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
        ButtonReset.Location = New Point(1654, 63)
        ButtonReset.Name = "ButtonReset"
        ButtonReset.Size = New Size(171, 51)
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
        ButtonCari.Location = New Point(1475, 62)
        ButtonCari.Name = "ButtonCari"
        ButtonCari.Size = New Size(163, 51)
        ButtonCari.TabIndex = 6
        ButtonCari.Text = "Cari"
        ButtonCari.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxStatus
        ' 
        ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxStatus.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxStatus.FormattingEnabled = True
        ComboBoxStatus.Items.AddRange(New Object() {"Semua status", "Normal", "Pembetulan", "Terlambat"})
        ComboBoxStatus.Location = New Point(511, 72)
        ComboBoxStatus.Name = "ComboBoxStatus"
        ComboBoxStatus.Size = New Size(168, 42)
        ComboBoxStatus.TabIndex = 5
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelStatus.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelStatus.Location = New Point(512, 32)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(167, 37)
        LabelStatus.TabIndex = 4
        LabelStatus.Text = "Status pelaporan"
        ' 
        ' ComboBoxTahun
        ' 
        ComboBoxTahun.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxTahun.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxTahun.FormattingEnabled = True
        ComboBoxTahun.Items.AddRange(New Object() {"2025", "2024", "2023", "2022"})
        ComboBoxTahun.Location = New Point(299, 74)
        ComboBoxTahun.Name = "ComboBoxTahun"
        ComboBoxTahun.Size = New Size(168, 42)
        ComboBoxTahun.TabIndex = 3
        ' 
        ' LabelTahun
        ' 
        LabelTahun.AutoSize = True
        LabelTahun.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTahun.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelTahun.Location = New Point(319, 32)
        LabelTahun.Name = "LabelTahun"
        LabelTahun.Size = New Size(124, 37)
        LabelTahun.TabIndex = 2
        LabelTahun.Text = "Tahun pajak"
        ' 
        ' TextBoxNPWP
        ' 
        TextBoxNPWP.BorderStyle = BorderStyle.FixedSingle
        TextBoxNPWP.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxNPWP.Location = New Point(24, 72)
        TextBoxNPWP.Name = "TextBoxNPWP"
        TextBoxNPWP.PlaceholderText = "Cari berdasarkan NPWP / nama"
        TextBoxNPWP.Size = New Size(232, 41)
        TextBoxNPWP.TabIndex = 1
        ' 
        ' LabelNPWP
        ' 
        LabelNPWP.AutoSize = True
        LabelNPWP.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNPWP.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelNPWP.Location = New Point(24, 32)
        LabelNPWP.Name = "LabelNPWP"
        LabelNPWP.Size = New Size(226, 37)
        LabelNPWP.TabIndex = 0
        LabelNPWP.Text = "Pencarian NPWP/nama"
        ' 
        ' LabelDescription
        ' 
        LabelDescription.AutoSize = True
        LabelDescription.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelDescription.ForeColor = Color.FromArgb(CByte(102), CByte(108), CByte(122))
        LabelDescription.Location = New Point(40, 96)
        LabelDescription.MaximumSize = New Size(560, 0)
        LabelDescription.Name = "LabelDescription"
        LabelDescription.Size = New Size(467, 30)
        LabelDescription.TabIndex = 2
        LabelDescription.Text = "Lacak riwayat pengajuan SPT Anda dan status penyelesaiannya."
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Dubai", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        LabelTitle.Location = New Point(30, 29)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(425, 67)
        LabelTitle.TabIndex = 1
        LabelTitle.Text = "Riwayat Pelaporan SPT"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(214), CByte(224))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Button1.Location = New Point(56, 19)
        Button1.Margin = New Padding(8, 3, 8, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 56)
        Button1.TabIndex = 2
        Button1.Text = "Ekspor Excel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Riwayat_Pelaporan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(252))
        ClientSize = New Size(1902, 946)
        Controls.Add(PanelWrapper)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Riwayat_Pelaporan"
        Padding = New Padding(40)
        StartPosition = FormStartPosition.CenterParent
        Text = "Coretax | Riwayat Pelaporan"
        WindowState = FormWindowState.Maximized
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
    Friend WithEvents ButtonKembali As Button
    Friend WithEvents Button1 As Button
End Class
