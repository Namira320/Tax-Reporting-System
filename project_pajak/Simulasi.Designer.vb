<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Simulasi
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelHeader = New Panel()
        LabelSubtitle = New Label()
        LabelTitle = New Label()
        PanelMain = New Panel()
        PanelInputCard = New Panel()
        PanelHistory = New Panel()
        DataGridViewRiwayat = New DataGridView()
        ColTanggal = New DataGridViewTextBoxColumn()
        ColStatus = New DataGridViewTextBoxColumn()
        ColKeterangan = New DataGridViewTextBoxColumn()
        LabelHistoryTitle = New Label()
        TableQuestions = New TableLayoutPanel()
        LabelQ1 = New Label()
        PanelQ1 = New Panel()
        rbQ1No = New RadioButton()
        rbQ1Yes = New RadioButton()
        LabelQ2 = New Label()
        PanelQ2 = New Panel()
        rbQ2No = New RadioButton()
        rbQ2Yes = New RadioButton()
        Label1 = New Label()
        PanelQ3 = New Panel()
        rbQ3No = New RadioButton()
        rbQ3Yes = New RadioButton()
        LabelQ4 = New Label()
        PanelQ4 = New Panel()
        rbQ4No = New RadioButton()
        rbQ4Yes = New RadioButton()
        LabelQ5 = New Label()
        PanelQ5 = New Panel()
        rbQ5No = New RadioButton()
        rbQ5Yes = New RadioButton()
        LabelQ6 = New Label()
        PanelQ6 = New Panel()
        rbQ6No = New RadioButton()
        rbQ6Yes = New RadioButton()
        LabelQ7 = New Label()
        PanelQ7 = New Panel()
        rbQ7No = New RadioButton()
        rbQ7Yes = New RadioButton()
        LabelQ8 = New Label()
        PanelQ8 = New Panel()
        rbQ8No = New RadioButton()
        rbQ8Yes = New RadioButton()
        btnHitungSimulasi = New Button()
        LabelInputSubtitle = New Label()
        LabelInputTitle = New Label()
        PanelSide = New Panel()
        btnKembaliDashboard = New Button()
        btnExportPDF = New Button()
        PanelStatusCard = New Panel()
        lblPanduanBilling = New Label()
        pnlStatus = New Panel()
        keterangan = New Label()
        lblStatusDetail = New Label()
        lblStatusResult = New Label()
        LabelStatusTitle = New Label()
        PanelHeader.SuspendLayout()
        PanelMain.SuspendLayout()
        PanelInputCard.SuspendLayout()
        PanelHistory.SuspendLayout()
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        TableQuestions.SuspendLayout()
        PanelQ1.SuspendLayout()
        PanelQ2.SuspendLayout()
        PanelQ3.SuspendLayout()
        PanelQ4.SuspendLayout()
        PanelQ5.SuspendLayout()
        PanelQ6.SuspendLayout()
        PanelQ7.SuspendLayout()
        PanelQ8.SuspendLayout()
        PanelSide.SuspendLayout()
        PanelStatusCard.SuspendLayout()
        pnlStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        PanelHeader.Controls.Add(LabelSubtitle)
        PanelHeader.Controls.Add(LabelTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Margin = New Padding(8)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Padding = New Padding(49, 32, 49, 32)
        PanelHeader.Size = New Size(1664, 128)
        PanelHeader.TabIndex = 0
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.AutoSize = True
        LabelSubtitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSubtitle.ForeColor = Color.FromArgb(CByte(214), CByte(230), CByte(255))
        LabelSubtitle.Location = New Point(49, 80)
        LabelSubtitle.Margin = New Padding(5, 0, 5, 0)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Size = New Size(779, 32)
        LabelSubtitle.TabIndex = 1
        LabelSubtitle.Text = "Hitung kewajiban, prediksi status bayar, dan siapkan langkah berikutnya"
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.White
        LabelTitle.Location = New Point(41, 24)
        LabelTitle.Margin = New Padding(5, 0, 5, 0)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(311, 59)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Simulasi Pajak"
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        PanelMain.Controls.Add(PanelInputCard)
        PanelMain.Controls.Add(PanelSide)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 128)
        PanelMain.Margin = New Padding(5)
        PanelMain.Name = "PanelMain"
        PanelMain.Padding = New Padding(32)
        PanelMain.Size = New Size(1664, 1101)
        PanelMain.TabIndex = 1
        ' 
        ' PanelInputCard
        ' 
        PanelInputCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelInputCard.AutoScroll = True
        PanelInputCard.BackColor = Color.White
        PanelInputCard.Controls.Add(PanelHistory)
        PanelInputCard.Controls.Add(TableQuestions)
        PanelInputCard.Controls.Add(LabelInputSubtitle)
        PanelInputCard.Controls.Add(LabelInputTitle)
        PanelInputCard.Location = New Point(32, 24)
        PanelInputCard.Margin = New Padding(5)
        PanelInputCard.Name = "PanelInputCard"
        PanelInputCard.Padding = New Padding(32)
        PanelInputCard.Size = New Size(1105, 1053)
        PanelInputCard.TabIndex = 0
        ' 
        ' PanelHistory
        ' 
        PanelHistory.BackColor = Color.White
        PanelHistory.Controls.Add(DataGridViewRiwayat)
        PanelHistory.Controls.Add(LabelHistoryTitle)
        PanelHistory.Location = New Point(32, 816)
        PanelHistory.Margin = New Padding(5)
        PanelHistory.Name = "PanelHistory"
        PanelHistory.Padding = New Padding(24)
        PanelHistory.Size = New Size(1040, 384)
        PanelHistory.TabIndex = 3
        ' 
        ' DataGridViewRiwayat
        ' 
        DataGridViewRiwayat.AllowUserToAddRows = False
        DataGridViewRiwayat.AllowUserToDeleteRows = False
        DataGridViewRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewRiwayat.BackgroundColor = Color.White
        DataGridViewRiwayat.BorderStyle = BorderStyle.None
        DataGridViewRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewRiwayat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewRiwayat.ColumnHeadersHeight = 40
        DataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewRiwayat.Columns.AddRange(New DataGridViewColumn() {ColTanggal, ColStatus, ColKeterangan})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(214), CByte(230), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewRiwayat.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewRiwayat.EnableHeadersVisualStyles = False
        DataGridViewRiwayat.GridColor = Color.FromArgb(CByte(222), CByte(226), CByte(230))
        DataGridViewRiwayat.Location = New Point(24, 72)
        DataGridViewRiwayat.Margin = New Padding(5)
        DataGridViewRiwayat.Name = "DataGridViewRiwayat"
        DataGridViewRiwayat.ReadOnly = True
        DataGridViewRiwayat.RowHeadersVisible = False
        DataGridViewRiwayat.RowHeadersWidth = 51
        DataGridViewRiwayat.RowTemplate.Height = 25
        DataGridViewRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewRiwayat.Size = New Size(991, 288)
        DataGridViewRiwayat.TabIndex = 1
        ' 
        ' ColTanggal
        ' 
        ColTanggal.HeaderText = "Tanggal"
        ColTanggal.MinimumWidth = 6
        ColTanggal.Name = "ColTanggal"
        ColTanggal.ReadOnly = True
        ' 
        ' ColStatus
        ' 
        ColStatus.HeaderText = "Status"
        ColStatus.MinimumWidth = 6
        ColStatus.Name = "ColStatus"
        ColStatus.ReadOnly = True
        ' 
        ' ColKeterangan
        ' 
        ColKeterangan.HeaderText = "Keterangan"
        ColKeterangan.MinimumWidth = 6
        ColKeterangan.Name = "ColKeterangan"
        ColKeterangan.ReadOnly = True
        ' 
        ' LabelHistoryTitle
        ' 
        LabelHistoryTitle.AutoSize = True
        LabelHistoryTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelHistoryTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelHistoryTitle.Location = New Point(24, 24)
        LabelHistoryTitle.Margin = New Padding(5, 0, 5, 0)
        LabelHistoryTitle.Name = "LabelHistoryTitle"
        LabelHistoryTitle.Size = New Size(235, 37)
        LabelHistoryTitle.TabIndex = 0
        LabelHistoryTitle.Text = "Riwayat Simulasi"
        ' 
        ' TableQuestions
        ' 
        TableQuestions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableQuestions.ColumnCount = 2
        TableQuestions.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableQuestions.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableQuestions.Controls.Add(LabelQ1, 0, 0)
        TableQuestions.Controls.Add(PanelQ1, 1, 0)
        TableQuestions.Controls.Add(LabelQ2, 0, 1)
        TableQuestions.Controls.Add(PanelQ2, 1, 1)
        TableQuestions.Controls.Add(Label1, 0, 2)
        TableQuestions.Controls.Add(PanelQ3, 1, 2)
        TableQuestions.Controls.Add(LabelQ4, 0, 3)
        TableQuestions.Controls.Add(PanelQ4, 1, 3)
        TableQuestions.Controls.Add(LabelQ5, 0, 4)
        TableQuestions.Controls.Add(PanelQ5, 1, 4)
        TableQuestions.Controls.Add(LabelQ6, 0, 5)
        TableQuestions.Controls.Add(PanelQ6, 1, 5)
        TableQuestions.Controls.Add(LabelQ7, 0, 6)
        TableQuestions.Controls.Add(PanelQ7, 1, 6)
        TableQuestions.Controls.Add(LabelQ8, 0, 7)
        TableQuestions.Controls.Add(PanelQ8, 1, 7)
        TableQuestions.Controls.Add(btnHitungSimulasi, 1, 8)
        TableQuestions.Location = New Point(32, 128)
        TableQuestions.Margin = New Padding(5)
        TableQuestions.Name = "TableQuestions"
        TableQuestions.RowCount = 9
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 80F))
        TableQuestions.Size = New Size(1040, 750)
        TableQuestions.TabIndex = 2
        ' 
        ' LabelQ1
        ' 
        LabelQ1.Anchor = AnchorStyles.Left
        LabelQ1.AutoSize = True
        LabelQ1.Font = New Font("Segoe UI", 10F)
        LabelQ1.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelQ1.Location = New Point(8, 17)
        LabelQ1.Margin = New Padding(8, 0, 8, 0)
        LabelQ1.Name = "LabelQ1"
        LabelQ1.Size = New Size(526, 37)
        LabelQ1.TabIndex = 0
        LabelQ1.Text = "1. Apakah memiliki bukti potong 1721-A1?"
        ' 
        ' PanelQ1
        ' 
        PanelQ1.Anchor = AnchorStyles.Left
        PanelQ1.Controls.Add(rbQ1No)
        PanelQ1.Controls.Add(rbQ1Yes)
        PanelQ1.Location = New Point(978, 8)
        PanelQ1.Margin = New Padding(8)
        PanelQ1.Name = "PanelQ1"
        PanelQ1.Size = New Size(286, 56)
        PanelQ1.TabIndex = 1
        ' 
        ' rbQ1No
        ' 
        rbQ1No.AutoSize = True
        rbQ1No.Checked = True
        rbQ1No.Font = New Font("Segoe UI", 10F)
        rbQ1No.Location = New Point(150, 13)
        rbQ1No.Margin = New Padding(8)
        rbQ1No.Name = "rbQ1No"
        rbQ1No.Size = New Size(112, 41)
        rbQ1No.TabIndex = 1
        rbQ1No.TabStop = True
        rbQ1No.Text = "Tidak"
        rbQ1No.UseVisualStyleBackColor = True
        ' 
        ' rbQ1Yes
        ' 
        rbQ1Yes.AutoSize = True
        rbQ1Yes.Font = New Font("Segoe UI", 10F)
        rbQ1Yes.Location = New Point(26, 13)
        rbQ1Yes.Margin = New Padding(8)
        rbQ1Yes.Name = "rbQ1Yes"
        rbQ1Yes.Size = New Size(75, 41)
        rbQ1Yes.TabIndex = 0
        rbQ1Yes.Text = "Ya"
        rbQ1Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ2
        ' 
        LabelQ2.Anchor = AnchorStyles.Left
        LabelQ2.AutoSize = True
        LabelQ2.Font = New Font("Segoe UI", 10F)
        LabelQ2.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelQ2.Location = New Point(8, 89)
        LabelQ2.Margin = New Padding(8, 0, 8, 0)
        LabelQ2.Name = "LabelQ2"
        LabelQ2.Size = New Size(700, 37)
        LabelQ2.TabIndex = 2
        LabelQ2.Text = "2. Apakah semua penghasilan tercantum di bukti potong?"
        ' 
        ' PanelQ2
        ' 
        PanelQ2.Anchor = AnchorStyles.Left
        PanelQ2.Controls.Add(rbQ2No)
        PanelQ2.Controls.Add(rbQ2Yes)
        PanelQ2.Location = New Point(978, 80)
        PanelQ2.Margin = New Padding(8)
        PanelQ2.Name = "PanelQ2"
        PanelQ2.Size = New Size(286, 56)
        PanelQ2.TabIndex = 3
        ' 
        ' rbQ2No
        ' 
        rbQ2No.AutoSize = True
        rbQ2No.Checked = True
        rbQ2No.Font = New Font("Segoe UI", 10F)
        rbQ2No.Location = New Point(150, 13)
        rbQ2No.Margin = New Padding(8)
        rbQ2No.Name = "rbQ2No"
        rbQ2No.Size = New Size(112, 41)
        rbQ2No.TabIndex = 1
        rbQ2No.TabStop = True
        rbQ2No.Text = "Tidak"
        rbQ2No.UseVisualStyleBackColor = True
        ' 
        ' rbQ2Yes
        ' 
        rbQ2Yes.AutoSize = True
        rbQ2Yes.Font = New Font("Segoe UI", 10F)
        rbQ2Yes.Location = New Point(26, 13)
        rbQ2Yes.Margin = New Padding(8)
        rbQ2Yes.Name = "rbQ2Yes"
        rbQ2Yes.Size = New Size(75, 41)
        rbQ2Yes.TabIndex = 0
        rbQ2Yes.Text = "Ya"
        rbQ2Yes.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Label1.Location = New Point(8, 161)
        Label1.Margin = New Padding(8, 0, 8, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(811, 37)
        Label1.TabIndex = 16
        Label1.Text = "3. Apakah Anda memiliki penghasilan lain di luar pekerjaan utama?"
        ' 
        ' PanelQ3
        ' 
        PanelQ3.Anchor = AnchorStyles.Left
        PanelQ3.Controls.Add(rbQ3No)
        PanelQ3.Controls.Add(rbQ3Yes)
        PanelQ3.Location = New Point(978, 152)
        PanelQ3.Margin = New Padding(8)
        PanelQ3.Name = "PanelQ3"
        PanelQ3.Size = New Size(286, 56)
        PanelQ3.TabIndex = 5
        ' 
        ' rbQ3No
        ' 
        rbQ3No.AutoSize = True
        rbQ3No.Checked = True
        rbQ3No.Font = New Font("Segoe UI", 10F)
        rbQ3No.Location = New Point(150, 13)
        rbQ3No.Margin = New Padding(8)
        rbQ3No.Name = "rbQ3No"
        rbQ3No.Size = New Size(112, 41)
        rbQ3No.TabIndex = 1
        rbQ3No.TabStop = True
        rbQ3No.Text = "Tidak"
        rbQ3No.UseVisualStyleBackColor = True
        ' 
        ' rbQ3Yes
        ' 
        rbQ3Yes.AutoSize = True
        rbQ3Yes.Font = New Font("Segoe UI", 10F)
        rbQ3Yes.Location = New Point(26, 13)
        rbQ3Yes.Margin = New Padding(8)
        rbQ3Yes.Name = "rbQ3Yes"
        rbQ3Yes.Size = New Size(75, 41)
        rbQ3Yes.TabIndex = 0
        rbQ3Yes.Text = "Ya"
        rbQ3Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ4
        ' 
        LabelQ4.Anchor = AnchorStyles.Left
        LabelQ4.AutoSize = True
        LabelQ4.Font = New Font("Segoe UI", 10F)
        LabelQ4.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelQ4.Location = New Point(8, 233)
        LabelQ4.Margin = New Padding(8, 0, 8, 0)
        LabelQ4.Name = "LabelQ4"
        LabelQ4.Size = New Size(603, 37)
        LabelQ4.TabIndex = 6
        LabelQ4.Text = "4. Apakah PTKP dan status keluarga sudah benar?"
        ' 
        ' PanelQ4
        ' 
        PanelQ4.Anchor = AnchorStyles.Left
        PanelQ4.Controls.Add(rbQ4No)
        PanelQ4.Controls.Add(rbQ4Yes)
        PanelQ4.Location = New Point(978, 224)
        PanelQ4.Margin = New Padding(8)
        PanelQ4.Name = "PanelQ4"
        PanelQ4.Size = New Size(286, 56)
        PanelQ4.TabIndex = 7
        ' 
        ' rbQ4No
        ' 
        rbQ4No.AutoSize = True
        rbQ4No.Checked = True
        rbQ4No.Font = New Font("Segoe UI", 10F)
        rbQ4No.Location = New Point(150, 13)
        rbQ4No.Margin = New Padding(8)
        rbQ4No.Name = "rbQ4No"
        rbQ4No.Size = New Size(112, 41)
        rbQ4No.TabIndex = 1
        rbQ4No.TabStop = True
        rbQ4No.Text = "Tidak"
        rbQ4No.UseVisualStyleBackColor = True
        ' 
        ' rbQ4Yes
        ' 
        rbQ4Yes.AutoSize = True
        rbQ4Yes.Font = New Font("Segoe UI", 10F)
        rbQ4Yes.Location = New Point(26, 13)
        rbQ4Yes.Margin = New Padding(8)
        rbQ4Yes.Name = "rbQ4Yes"
        rbQ4Yes.Size = New Size(75, 41)
        rbQ4Yes.TabIndex = 0
        rbQ4Yes.Text = "Ya"
        rbQ4Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ5
        ' 
        LabelQ5.Anchor = AnchorStyles.Left
        LabelQ5.AutoSize = True
        LabelQ5.Font = New Font("Segoe UI", 10F)
        LabelQ5.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelQ5.Location = New Point(8, 305)
        LabelQ5.Margin = New Padding(8, 0, 8, 0)
        LabelQ5.Name = "LabelQ5"
        LabelQ5.Size = New Size(563, 37)
        LabelQ5.TabIndex = 8
        LabelQ5.Text = "5. Apakah setelah isi SPT muncul selisih pajak?"
        ' 
        ' PanelQ5
        ' 
        PanelQ5.Anchor = AnchorStyles.Left
        PanelQ5.Controls.Add(rbQ5No)
        PanelQ5.Controls.Add(rbQ5Yes)
        PanelQ5.Location = New Point(978, 296)
        PanelQ5.Margin = New Padding(8)
        PanelQ5.Name = "PanelQ5"
        PanelQ5.Size = New Size(286, 56)
        PanelQ5.TabIndex = 9
        ' 
        ' rbQ5No
        ' 
        rbQ5No.AutoSize = True
        rbQ5No.Checked = True
        rbQ5No.Font = New Font("Segoe UI", 10F)
        rbQ5No.Location = New Point(150, 13)
        rbQ5No.Margin = New Padding(8)
        rbQ5No.Name = "rbQ5No"
        rbQ5No.Size = New Size(112, 41)
        rbQ5No.TabIndex = 1
        rbQ5No.TabStop = True
        rbQ5No.Text = "Tidak"
        rbQ5No.UseVisualStyleBackColor = True
        ' 
        ' rbQ5Yes
        ' 
        rbQ5Yes.AutoSize = True
        rbQ5Yes.Font = New Font("Segoe UI", 10F)
        rbQ5Yes.Location = New Point(26, 13)
        rbQ5Yes.Margin = New Padding(8)
        rbQ5Yes.Name = "rbQ5Yes"
        rbQ5Yes.Size = New Size(75, 41)
        rbQ5Yes.TabIndex = 0
        rbQ5Yes.Text = "Ya"
        rbQ5Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ6
        ' 
        LabelQ6.Anchor = AnchorStyles.Left
        LabelQ6.AutoSize = True
        LabelQ6.Font = New Font("Segoe UI", 10F)
        LabelQ6.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelQ6.Location = New Point(8, 377)
        LabelQ6.Margin = New Padding(8, 0, 8, 0)
        LabelQ6.Name = "LabelQ6"
        LabelQ6.Size = New Size(710, 37)
        LabelQ6.TabIndex = 10
        LabelQ6.Text = "6. Apakah pajak yang dipotong lebih BESAR dari terutang?"
        ' 
        ' PanelQ6
        ' 
        PanelQ6.Anchor = AnchorStyles.Left
        PanelQ6.Controls.Add(rbQ6No)
        PanelQ6.Controls.Add(rbQ6Yes)
        PanelQ6.Location = New Point(978, 368)
        PanelQ6.Margin = New Padding(8)
        PanelQ6.Name = "PanelQ6"
        PanelQ6.Size = New Size(286, 56)
        PanelQ6.TabIndex = 11
        ' 
        ' rbQ6No
        ' 
        rbQ6No.AutoSize = True
        rbQ6No.Checked = True
        rbQ6No.Font = New Font("Segoe UI", 10F)
        rbQ6No.Location = New Point(150, 13)
        rbQ6No.Margin = New Padding(8)
        rbQ6No.Name = "rbQ6No"
        rbQ6No.Size = New Size(112, 41)
        rbQ6No.TabIndex = 1
        rbQ6No.TabStop = True
        rbQ6No.Text = "Tidak"
        rbQ6No.UseVisualStyleBackColor = True
        ' 
        ' rbQ6Yes
        ' 
        rbQ6Yes.AutoSize = True
        rbQ6Yes.Font = New Font("Segoe UI", 10F)
        rbQ6Yes.Location = New Point(26, 13)
        rbQ6Yes.Margin = New Padding(8)
        rbQ6Yes.Name = "rbQ6Yes"
        rbQ6Yes.Size = New Size(75, 41)
        rbQ6Yes.TabIndex = 0
        rbQ6Yes.Text = "Ya"
        rbQ6Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ7
        ' 
        LabelQ7.Anchor = AnchorStyles.Left
        LabelQ7.AutoSize = True
        LabelQ7.Font = New Font("Segoe UI", 10F)
        LabelQ7.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelQ7.Location = New Point(8, 449)
        LabelQ7.Margin = New Padding(8, 0, 8, 0)
        LabelQ7.Name = "LabelQ7"
        LabelQ7.Size = New Size(701, 37)
        LabelQ7.TabIndex = 12
        LabelQ7.Text = "7. Apakah pajak yang dipotong lebih KECIL dari terutang?"
        ' 
        ' PanelQ7
        ' 
        PanelQ7.Anchor = AnchorStyles.Left
        PanelQ7.Controls.Add(rbQ7No)
        PanelQ7.Controls.Add(rbQ7Yes)
        PanelQ7.Location = New Point(978, 440)
        PanelQ7.Margin = New Padding(8)
        PanelQ7.Name = "PanelQ7"
        PanelQ7.Size = New Size(286, 56)
        PanelQ7.TabIndex = 13
        ' 
        ' rbQ7No
        ' 
        rbQ7No.AutoSize = True
        rbQ7No.Checked = True
        rbQ7No.Font = New Font("Segoe UI", 10F)
        rbQ7No.Location = New Point(150, 13)
        rbQ7No.Margin = New Padding(8)
        rbQ7No.Name = "rbQ7No"
        rbQ7No.Size = New Size(112, 41)
        rbQ7No.TabIndex = 1
        rbQ7No.TabStop = True
        rbQ7No.Text = "Tidak"
        rbQ7No.UseVisualStyleBackColor = True
        ' 
        ' rbQ7Yes
        ' 
        rbQ7Yes.AutoSize = True
        rbQ7Yes.Font = New Font("Segoe UI", 10F)
        rbQ7Yes.Location = New Point(26, 13)
        rbQ7Yes.Margin = New Padding(8)
        rbQ7Yes.Name = "rbQ7Yes"
        rbQ7Yes.Size = New Size(75, 41)
        rbQ7Yes.TabIndex = 0
        rbQ7Yes.Text = "Ya"
        rbQ7Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ8
        ' 
        LabelQ8.Anchor = AnchorStyles.Left
        LabelQ8.AutoSize = True
        LabelQ8.Font = New Font("Segoe UI", 10F)
        LabelQ8.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelQ8.Location = New Point(8, 521)
        LabelQ8.Margin = New Padding(8, 0, 8, 0)
        LabelQ8.Name = "LabelQ8"
        LabelQ8.Size = New Size(707, 37)
        LabelQ8.TabIndex = 14
        LabelQ8.Text = "8. Jika ada kurang bayar, apakah sudah lunas via e-Billing?"
        ' 
        ' PanelQ8
        ' 
        PanelQ8.Anchor = AnchorStyles.Left
        PanelQ8.Controls.Add(rbQ8No)
        PanelQ8.Controls.Add(rbQ8Yes)
        PanelQ8.Location = New Point(978, 512)
        PanelQ8.Margin = New Padding(8)
        PanelQ8.Name = "PanelQ8"
        PanelQ8.Size = New Size(286, 56)
        PanelQ8.TabIndex = 15
        ' 
        ' rbQ8No
        ' 
        rbQ8No.AutoSize = True
        rbQ8No.Checked = True
        rbQ8No.Font = New Font("Segoe UI", 10F)
        rbQ8No.Location = New Point(150, 13)
        rbQ8No.Margin = New Padding(8)
        rbQ8No.Name = "rbQ8No"
        rbQ8No.Size = New Size(112, 41)
        rbQ8No.TabIndex = 1
        rbQ8No.TabStop = True
        rbQ8No.Text = "Tidak"
        rbQ8No.UseVisualStyleBackColor = True
        ' 
        ' rbQ8Yes
        ' 
        rbQ8Yes.AutoSize = True
        rbQ8Yes.Font = New Font("Segoe UI", 10F)
        rbQ8Yes.Location = New Point(26, 13)
        rbQ8Yes.Margin = New Padding(8)
        rbQ8Yes.Name = "rbQ8Yes"
        rbQ8Yes.Size = New Size(75, 41)
        rbQ8Yes.TabIndex = 0
        rbQ8Yes.Text = "Ya"
        rbQ8Yes.UseVisualStyleBackColor = True
        ' 
        ' btnHitungSimulasi
        ' 
        btnHitungSimulasi.Anchor = AnchorStyles.None
        btnHitungSimulasi.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnHitungSimulasi.Cursor = Cursors.Hand
        btnHitungSimulasi.FlatAppearance.BorderSize = 0
        btnHitungSimulasi.FlatStyle = FlatStyle.Flat
        btnHitungSimulasi.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnHitungSimulasi.ForeColor = Color.White
        btnHitungSimulasi.Location = New Point(1035, 631)
        btnHitungSimulasi.Margin = New Padding(8)
        btnHitungSimulasi.Name = "btnHitungSimulasi"
        btnHitungSimulasi.Size = New Size(286, 64)
        btnHitungSimulasi.TabIndex = 3
        btnHitungSimulasi.Text = ChrW(55358) & ChrW(56814) & " Hitung Simulasi"
        btnHitungSimulasi.UseVisualStyleBackColor = False
        ' 
        ' LabelInputSubtitle
        ' 
        LabelInputSubtitle.AutoSize = True
        LabelInputSubtitle.Font = New Font("Segoe UI", 8F)
        LabelInputSubtitle.ForeColor = Color.FromArgb(CByte(134), CByte(142), CByte(150))
        LabelInputSubtitle.Location = New Point(32, 77)
        LabelInputSubtitle.Margin = New Padding(5, 0, 5, 0)
        LabelInputSubtitle.Name = "LabelInputSubtitle"
        LabelInputSubtitle.Size = New Size(581, 30)
        LabelInputSubtitle.TabIndex = 1
        LabelInputSubtitle.Text = "Jawab pertanyaan berikut untuk menghitung simulasi pajak"
        ' 
        ' LabelInputTitle
        ' 
        LabelInputTitle.AutoSize = True
        LabelInputTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LabelInputTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelInputTitle.Location = New Point(32, 32)
        LabelInputTitle.Margin = New Padding(5, 0, 5, 0)
        LabelInputTitle.Name = "LabelInputTitle"
        LabelInputTitle.Size = New Size(258, 45)
        LabelInputTitle.TabIndex = 0
        LabelInputTitle.Text = "Kuesioner Pajak"
        ' 
        ' PanelSide
        ' 
        PanelSide.BackColor = Color.Transparent
        PanelSide.Controls.Add(btnKembaliDashboard)
        PanelSide.Controls.Add(btnExportPDF)
        PanelSide.Controls.Add(PanelStatusCard)
        PanelSide.Dock = DockStyle.Right
        PanelSide.Location = New Point(1170, 32)
        PanelSide.Margin = New Padding(5)
        PanelSide.Name = "PanelSide"
        PanelSide.Padding = New Padding(24, 0, 0, 0)
        PanelSide.Size = New Size(462, 1037)
        PanelSide.TabIndex = 1
        ' 
        ' btnKembaliDashboard
        ' 
        btnKembaliDashboard.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnKembaliDashboard.Cursor = Cursors.Hand
        btnKembaliDashboard.FlatAppearance.BorderSize = 0
        btnKembaliDashboard.FlatStyle = FlatStyle.Flat
        btnKembaliDashboard.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnKembaliDashboard.ForeColor = Color.White
        btnKembaliDashboard.Location = New Point(24, 80)
        btnKembaliDashboard.Margin = New Padding(5)
        btnKembaliDashboard.Name = "btnKembaliDashboard"
        btnKembaliDashboard.Size = New Size(413, 56)
        btnKembaliDashboard.TabIndex = 4
        btnKembaliDashboard.Text = "🏠 Kembali ke Dashboard"
        btnKembaliDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        btnExportPDF.Cursor = Cursors.Hand
        btnExportPDF.FlatAppearance.BorderSize = 0
        btnExportPDF.FlatStyle = FlatStyle.Flat
        btnExportPDF.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnExportPDF.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        btnExportPDF.Location = New Point(24, 0)
        btnExportPDF.Margin = New Padding(5)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(413, 56)
        btnExportPDF.TabIndex = 3
        btnExportPDF.Text = "📄 Export PDF"
        btnExportPDF.UseVisualStyleBackColor = False
        ' 
        ' PanelStatusCard
        ' 
        PanelStatusCard.BackColor = Color.White
        PanelStatusCard.Controls.Add(lblPanduanBilling)
        PanelStatusCard.Controls.Add(pnlStatus)
        PanelStatusCard.Controls.Add(LabelStatusTitle)
        PanelStatusCard.Location = New Point(24, 160)
        PanelStatusCard.Margin = New Padding(5)
        PanelStatusCard.Name = "PanelStatusCard"
        PanelStatusCard.Padding = New Padding(24)
        PanelStatusCard.Size = New Size(413, 480)
        PanelStatusCard.TabIndex = 0
        ' 
        ' lblPanduanBilling
        ' 
        lblPanduanBilling.AutoSize = True
        lblPanduanBilling.Cursor = Cursors.Hand
        lblPanduanBilling.Font = New Font("Segoe UI", 10F, FontStyle.Underline)
        lblPanduanBilling.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        lblPanduanBilling.Location = New Point(63, 934)
        lblPanduanBilling.Margin = New Padding(8, 0, 8, 0)
        lblPanduanBilling.Name = "lblPanduanBilling"
        lblPanduanBilling.Size = New Size(391, 37)
        lblPanduanBilling.TabIndex = 2
        lblPanduanBilling.Text = "📄 Panduan membuat e-Billing"
        lblPanduanBilling.Visible = False
        ' 
        ' pnlStatus
        ' 
        pnlStatus.BackColor = Color.FromArgb(CByte(214), CByte(230), CByte(255))
        pnlStatus.Controls.Add(keterangan)
        pnlStatus.Controls.Add(lblStatusDetail)
        pnlStatus.Controls.Add(lblStatusResult)
        pnlStatus.Location = New Point(24, 80)
        pnlStatus.Margin = New Padding(5)
        pnlStatus.Name = "pnlStatus"
        pnlStatus.Padding = New Padding(16)
        pnlStatus.Size = New Size(364, 376)
        pnlStatus.TabIndex = 1
        ' 
        ' keterangan
        ' 
        keterangan.Font = New Font("Segoe UI", 7F)
        keterangan.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        keterangan.Location = New Point(16, 224)
        keterangan.Margin = New Padding(5, 0, 5, 0)
        keterangan.Name = "keterangan"
        keterangan.Size = New Size(332, 128)
        keterangan.TabIndex = 2
        keterangan.Text = "Jawab pertanyaan di atas untuk mendapatkan hasil simulasi."
        ' 
        ' lblStatusDetail
        ' 
        lblStatusDetail.Font = New Font("Segoe UI", 8F)
        lblStatusDetail.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        lblStatusDetail.Location = New Point(16, 128)
        lblStatusDetail.Margin = New Padding(5, 0, 5, 0)
        lblStatusDetail.Name = "lblStatusDetail"
        lblStatusDetail.Size = New Size(332, 80)
        lblStatusDetail.TabIndex = 1
        ' 
        ' lblStatusResult
        ' 
        lblStatusResult.AutoSize = True
        lblStatusResult.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblStatusResult.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        lblStatusResult.Location = New Point(16, 16)
        lblStatusResult.Margin = New Padding(5, 0, 5, 0)
        lblStatusResult.Name = "lblStatusResult"
        lblStatusResult.Size = New Size(251, 45)
        lblStatusResult.TabIndex = 0
        lblStatusResult.Text = "Belum dihitung"
        ' 
        ' LabelStatusTitle
        ' 
        LabelStatusTitle.AutoSize = True
        LabelStatusTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelStatusTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelStatusTitle.Location = New Point(24, 24)
        LabelStatusTitle.Margin = New Padding(5, 0, 5, 0)
        LabelStatusTitle.Name = "LabelStatusTitle"
        LabelStatusTitle.Size = New Size(195, 37)
        LabelStatusTitle.TabIndex = 0
        LabelStatusTitle.Text = "Hasil Simulasi"
        ' 
        ' Simulasi
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        ClientSize = New Size(1664, 1229)
        Controls.Add(PanelMain)
        Controls.Add(PanelHeader)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(5)
        MinimumSize = New Size(1648, 1186)
        Name = "Simulasi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TaxEase | Simulasi Pajak"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelMain.ResumeLayout(False)
        PanelInputCard.ResumeLayout(False)
        PanelInputCard.PerformLayout()
        PanelHistory.ResumeLayout(False)
        PanelHistory.PerformLayout()
        CType(DataGridViewRiwayat, ComponentModel.ISupportInitialize).EndInit()
        TableQuestions.ResumeLayout(False)
        TableQuestions.PerformLayout()
        PanelQ1.ResumeLayout(False)
        PanelQ1.PerformLayout()
        PanelQ2.ResumeLayout(False)
        PanelQ2.PerformLayout()
        PanelQ3.ResumeLayout(False)
        PanelQ3.PerformLayout()
        PanelQ4.ResumeLayout(False)
        PanelQ4.PerformLayout()
        PanelQ5.ResumeLayout(False)
        PanelQ5.PerformLayout()
        PanelQ6.ResumeLayout(False)
        PanelQ6.PerformLayout()
        PanelQ7.ResumeLayout(False)
        PanelQ7.PerformLayout()
        PanelQ8.ResumeLayout(False)
        PanelQ8.PerformLayout()
        PanelSide.ResumeLayout(False)
        PanelStatusCard.ResumeLayout(False)
        PanelStatusCard.PerformLayout()
        pnlStatus.ResumeLayout(False)
        pnlStatus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelInputCard As Panel
    Friend WithEvents TableQuestions As TableLayoutPanel
    Friend WithEvents LabelQ1 As Label
    Friend WithEvents PanelQ1 As Panel
    Friend WithEvents rbQ1No As RadioButton
    Friend WithEvents rbQ1Yes As RadioButton
    Friend WithEvents LabelQ2 As Label
    Friend WithEvents PanelQ2 As Panel
    Friend WithEvents rbQ2No As RadioButton
    Friend WithEvents rbQ2Yes As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelQ3 As Panel
    Friend WithEvents rbQ3No As RadioButton
    Friend WithEvents rbQ3Yes As RadioButton
    Friend WithEvents LabelQ4 As Label
    Friend WithEvents PanelQ4 As Panel
    Friend WithEvents rbQ4No As RadioButton
    Friend WithEvents rbQ4Yes As RadioButton
    Friend WithEvents LabelQ5 As Label
    Friend WithEvents PanelQ5 As Panel
    Friend WithEvents rbQ5No As RadioButton
    Friend WithEvents rbQ5Yes As RadioButton
    Friend WithEvents LabelQ6 As Label
    Friend WithEvents PanelQ6 As Panel
    Friend WithEvents rbQ6No As RadioButton
    Friend WithEvents rbQ6Yes As RadioButton
    Friend WithEvents LabelQ7 As Label
    Friend WithEvents PanelQ7 As Panel
    Friend WithEvents rbQ7No As RadioButton
    Friend WithEvents rbQ7Yes As RadioButton
    Friend WithEvents LabelQ8 As Label
    Friend WithEvents PanelQ8 As Panel
    Friend WithEvents rbQ8No As RadioButton
    Friend WithEvents rbQ8Yes As RadioButton
    Friend WithEvents btnHitungSimulasi As Button
    Friend WithEvents LabelInputSubtitle As Label
    Friend WithEvents LabelInputTitle As Label
    Friend WithEvents PanelSide As Panel
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents btnKembaliDashboard As Button
    Friend WithEvents PanelHistory As Panel
    Friend WithEvents DataGridViewRiwayat As DataGridView
    Friend WithEvents ColTanggal As DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As DataGridViewTextBoxColumn
    Friend WithEvents ColKeterangan As DataGridViewTextBoxColumn
    Friend WithEvents LabelHistoryTitle As Label
    Friend WithEvents PanelStatusCard As Panel
    Friend WithEvents lblPanduanBilling As Label
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents keterangan As Label
    Friend WithEvents lblStatusDetail As Label
    Friend WithEvents lblStatusResult As Label
    Friend WithEvents LabelStatusTitle As Label

End Class
