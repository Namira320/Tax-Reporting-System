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
        PanelHeader = New Panel()
        LabelSubtitle = New Label()
        LabelTitle = New Label()
        PanelMain = New Panel()
        PanelInputCard = New Panel()
        btnHitungSimulasi = New Button()
        TableQuestions = New TableLayoutPanel()
        LabelQ1 = New Label()
        PanelQ1 = New Panel()
        rbQ1No = New RadioButton()
        rbQ1Yes = New RadioButton()
        LabelQ2 = New Label()
        PanelQ2 = New Panel()
        rbQ2No = New RadioButton()
        rbQ2Yes = New RadioButton()
        LabelQ3 = New Label()
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
        LabelInputSubtitle = New Label()
        LabelInputTitle = New Label()
        PanelSide = New Panel()
        PanelHistory = New Panel()
        ListBoxHistory = New ListBox()
        LabelHistoryTitle = New Label()
        PanelStatusCard = New Panel()
        lblPanduanBilling = New Label()
        pnlStatus = New Panel()
        lblStatusDetail = New Label()
        lblStatusResult = New Label()
        LabelStatusTitle = New Label()
        PanelHeader.SuspendLayout()
        PanelMain.SuspendLayout()
        PanelInputCard.SuspendLayout()
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
        PanelHistory.SuspendLayout()
        PanelStatusCard.SuspendLayout()
        pnlStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.White
        PanelHeader.Controls.Add(LabelSubtitle)
        PanelHeader.Controls.Add(LabelTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Padding = New Padding(32)
        PanelHeader.Size = New Size(1320, 140)
        PanelHeader.TabIndex = 0
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.AutoSize = True
        LabelSubtitle.Font = New Font("Segoe UI", 10F)
        LabelSubtitle.ForeColor = Color.FromArgb(CByte(99), CByte(105), CByte(118))
        LabelSubtitle.Location = New Point(36, 96)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Size = New Size(641, 28)
        LabelSubtitle.TabIndex = 1
        LabelSubtitle.Text = "Hitung kewajiban, prediksi status bayar, dan siapkan langkah berikutnya."
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        LabelTitle.Location = New Point(30, 32)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(277, 54)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Simulasi Pajak"
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(252))
        PanelMain.Controls.Add(PanelInputCard)
        PanelMain.Controls.Add(PanelSide)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 140)
        PanelMain.Name = "PanelMain"
        PanelMain.Padding = New Padding(32)
        PanelMain.Size = New Size(1320, 680)
        PanelMain.TabIndex = 1
        ' 
        ' PanelInputCard
        ' 
        PanelInputCard.BackColor = Color.White
        PanelInputCard.Controls.Add(btnHitungSimulasi)
        PanelInputCard.Controls.Add(TableQuestions)
        PanelInputCard.Controls.Add(LabelInputSubtitle)
        PanelInputCard.Controls.Add(LabelInputTitle)
        PanelInputCard.Dock = DockStyle.Fill
        PanelInputCard.Location = New Point(32, 32)
        PanelInputCard.Name = "PanelInputCard"
        PanelInputCard.Padding = New Padding(32)
        PanelInputCard.Size = New Size(856, 616)
        PanelInputCard.TabIndex = 0
        ' 
        ' btnHitungSimulasi
        ' 
        btnHitungSimulasi.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnHitungSimulasi.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        btnHitungSimulasi.Cursor = Cursors.Hand
        btnHitungSimulasi.FlatAppearance.BorderSize = 0
        btnHitungSimulasi.FlatStyle = FlatStyle.Flat
        btnHitungSimulasi.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnHitungSimulasi.ForeColor = Color.White
        btnHitungSimulasi.Location = New Point(598, 532)
        btnHitungSimulasi.Name = "btnHitungSimulasi"
        btnHitungSimulasi.Size = New Size(214, 50)
        btnHitungSimulasi.TabIndex = 3
        btnHitungSimulasi.Text = "Hitung Simulasi"
        btnHitungSimulasi.UseVisualStyleBackColor = False
        ' 
        ' TableQuestions
        ' 
        TableQuestions.ColumnCount = 2
        TableQuestions.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableQuestions.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableQuestions.Controls.Add(LabelQ1, 0, 0)
        TableQuestions.Controls.Add(PanelQ1, 1, 0)
        TableQuestions.Controls.Add(LabelQ2, 0, 1)
        TableQuestions.Controls.Add(PanelQ2, 1, 1)
        TableQuestions.Controls.Add(LabelQ3, 0, 2)
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
        TableQuestions.Location = New Point(32, 134)
        TableQuestions.Name = "TableQuestions"
        TableQuestions.RowCount = 8
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableQuestions.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableQuestions.Size = New Size(780, 480)
        TableQuestions.TabIndex = 2
        ' 
        ' LabelQ1
        ' 
        LabelQ1.AutoSize = True
        LabelQ1.Font = New Font("Segoe UI", 10F)
        LabelQ1.ForeColor = Color.FromArgb(CByte(64), CByte(72), CByte(86))
        LabelQ1.Location = New Point(3, 0)
        LabelQ1.Margin = New Padding(3, 0, 10, 0)
        LabelQ1.Name = "LabelQ1"
        LabelQ1.Size = New Size(388, 28)
        LabelQ1.TabIndex = 0
        LabelQ1.Text = "1. Apakah memiliki bukti potong 1721-A1?"
        ' 
        ' PanelQ1
        ' 
        PanelQ1.Controls.Add(rbQ1No)
        PanelQ1.Controls.Add(rbQ1Yes)
        PanelQ1.Dock = DockStyle.Fill
        PanelQ1.Location = New Point(510, 3)
        PanelQ1.Name = "PanelQ1"
        PanelQ1.Size = New Size(267, 54)
        PanelQ1.TabIndex = 1
        ' 
        ' rbQ1No
        ' 
        rbQ1No.AutoSize = True
        rbQ1No.Checked = True
        rbQ1No.Font = New Font("Segoe UI", 9F)
        rbQ1No.Location = New Point(122, 12)
        rbQ1No.Name = "rbQ1No"
        rbQ1No.Size = New Size(79, 29)
        rbQ1No.TabIndex = 1
        rbQ1No.TabStop = True
        rbQ1No.Text = "Tidak"
        rbQ1No.UseVisualStyleBackColor = True
        ' 
        ' rbQ1Yes
        ' 
        rbQ1Yes.AutoSize = True
        rbQ1Yes.Font = New Font("Segoe UI", 9F)
        rbQ1Yes.Location = New Point(16, 12)
        rbQ1Yes.Name = "rbQ1Yes"
        rbQ1Yes.Size = New Size(54, 29)
        rbQ1Yes.TabIndex = 0
        rbQ1Yes.Text = "Ya"
        rbQ1Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ2
        ' 
        LabelQ2.AutoSize = True
        LabelQ2.Font = New Font("Segoe UI", 10F)
        LabelQ2.ForeColor = Color.FromArgb(CByte(64), CByte(72), CByte(86))
        LabelQ2.Location = New Point(3, 60)
        LabelQ2.Margin = New Padding(3, 0, 10, 0)
        LabelQ2.Name = "LabelQ2"
        LabelQ2.Size = New Size(440, 56)
        LabelQ2.TabIndex = 2
        LabelQ2.Text = "2. Apakah semua penghasilan tercantum di bukti potong?"
        ' 
        ' PanelQ2
        ' 
        PanelQ2.Controls.Add(rbQ2No)
        PanelQ2.Controls.Add(rbQ2Yes)
        PanelQ2.Dock = DockStyle.Fill
        PanelQ2.Location = New Point(510, 63)
        PanelQ2.Name = "PanelQ2"
        PanelQ2.Size = New Size(267, 54)
        PanelQ2.TabIndex = 3
        ' 
        ' rbQ2No
        ' 
        rbQ2No.AutoSize = True
        rbQ2No.Checked = True
        rbQ2No.Font = New Font("Segoe UI", 9F)
        rbQ2No.Location = New Point(122, 12)
        rbQ2No.Name = "rbQ2No"
        rbQ2No.Size = New Size(79, 29)
        rbQ2No.TabIndex = 1
        rbQ2No.TabStop = True
        rbQ2No.Text = "Tidak"
        rbQ2No.UseVisualStyleBackColor = True
        ' 
        ' rbQ2Yes
        ' 
        rbQ2Yes.AutoSize = True
        rbQ2Yes.Font = New Font("Segoe UI", 9F)
        rbQ2Yes.Location = New Point(16, 12)
        rbQ2Yes.Name = "rbQ2Yes"
        rbQ2Yes.Size = New Size(54, 29)
        rbQ2Yes.TabIndex = 0
        rbQ2Yes.Text = "Ya"
        rbQ2Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ3
        ' 
        LabelQ3.Location = New Point(3, 120)
        LabelQ3.Name = "LabelQ3"
        LabelQ3.Size = New Size(100, 23)
        LabelQ3.TabIndex = 4
        ' 
        ' PanelQ3
        ' 
        PanelQ3.Controls.Add(rbQ3No)
        PanelQ3.Controls.Add(rbQ3Yes)
        PanelQ3.Dock = DockStyle.Fill
        PanelQ3.Location = New Point(510, 123)
        PanelQ3.Name = "PanelQ3"
        PanelQ3.Size = New Size(267, 54)
        PanelQ3.TabIndex = 5
        ' 
        ' rbQ3No
        ' 
        rbQ3No.AutoSize = True
        rbQ3No.Checked = True
        rbQ3No.Font = New Font("Segoe UI", 9F)
        rbQ3No.Location = New Point(122, 12)
        rbQ3No.Name = "rbQ3No"
        rbQ3No.Size = New Size(79, 29)
        rbQ3No.TabIndex = 1
        rbQ3No.TabStop = True
        rbQ3No.Text = "Tidak"
        rbQ3No.UseVisualStyleBackColor = True
        ' 
        ' rbQ3Yes
        ' 
        rbQ3Yes.AutoSize = True
        rbQ3Yes.Font = New Font("Segoe UI", 9F)
        rbQ3Yes.Location = New Point(16, 12)
        rbQ3Yes.Name = "rbQ3Yes"
        rbQ3Yes.Size = New Size(54, 29)
        rbQ3Yes.TabIndex = 0
        rbQ3Yes.Text = "Ya"
        rbQ3Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ4
        ' 
        LabelQ4.AutoSize = True
        LabelQ4.Font = New Font("Segoe UI", 10F)
        LabelQ4.ForeColor = Color.FromArgb(CByte(64), CByte(72), CByte(86))
        LabelQ4.Location = New Point(3, 180)
        LabelQ4.Margin = New Padding(3, 0, 10, 0)
        LabelQ4.Name = "LabelQ4"
        LabelQ4.Size = New Size(442, 28)
        LabelQ4.TabIndex = 6
        LabelQ4.Text = "4. Apakah PTKP dan status keluarga sudah benar?"
        ' 
        ' PanelQ4
        ' 
        PanelQ4.Controls.Add(rbQ4No)
        PanelQ4.Controls.Add(rbQ4Yes)
        PanelQ4.Dock = DockStyle.Fill
        PanelQ4.Location = New Point(510, 183)
        PanelQ4.Name = "PanelQ4"
        PanelQ4.Size = New Size(267, 54)
        PanelQ4.TabIndex = 7
        ' 
        ' rbQ4No
        ' 
        rbQ4No.AutoSize = True
        rbQ4No.Checked = True
        rbQ4No.Font = New Font("Segoe UI", 9F)
        rbQ4No.Location = New Point(122, 12)
        rbQ4No.Name = "rbQ4No"
        rbQ4No.Size = New Size(79, 29)
        rbQ4No.TabIndex = 1
        rbQ4No.TabStop = True
        rbQ4No.Text = "Tidak"
        rbQ4No.UseVisualStyleBackColor = True
        ' 
        ' rbQ4Yes
        ' 
        rbQ4Yes.AutoSize = True
        rbQ4Yes.Font = New Font("Segoe UI", 9F)
        rbQ4Yes.Location = New Point(16, 12)
        rbQ4Yes.Name = "rbQ4Yes"
        rbQ4Yes.Size = New Size(54, 29)
        rbQ4Yes.TabIndex = 0
        rbQ4Yes.Text = "Ya"
        rbQ4Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ5
        ' 
        LabelQ5.AutoSize = True
        LabelQ5.Font = New Font("Segoe UI", 10F)
        LabelQ5.ForeColor = Color.FromArgb(CByte(64), CByte(72), CByte(86))
        LabelQ5.Location = New Point(3, 240)
        LabelQ5.Margin = New Padding(3, 0, 10, 0)
        LabelQ5.Name = "LabelQ5"
        LabelQ5.Size = New Size(411, 28)
        LabelQ5.TabIndex = 8
        LabelQ5.Text = "5. Apakah setelah isi SPT muncul selisih pajak?"
        ' 
        ' PanelQ5
        ' 
        PanelQ5.Controls.Add(rbQ5No)
        PanelQ5.Controls.Add(rbQ5Yes)
        PanelQ5.Dock = DockStyle.Fill
        PanelQ5.Location = New Point(510, 243)
        PanelQ5.Name = "PanelQ5"
        PanelQ5.Size = New Size(267, 54)
        PanelQ5.TabIndex = 9
        ' 
        ' rbQ5No
        ' 
        rbQ5No.AutoSize = True
        rbQ5No.Checked = True
        rbQ5No.Font = New Font("Segoe UI", 9F)
        rbQ5No.Location = New Point(122, 12)
        rbQ5No.Name = "rbQ5No"
        rbQ5No.Size = New Size(79, 29)
        rbQ5No.TabIndex = 1
        rbQ5No.TabStop = True
        rbQ5No.Text = "Tidak"
        rbQ5No.UseVisualStyleBackColor = True
        ' 
        ' rbQ5Yes
        ' 
        rbQ5Yes.AutoSize = True
        rbQ5Yes.Font = New Font("Segoe UI", 9F)
        rbQ5Yes.Location = New Point(16, 12)
        rbQ5Yes.Name = "rbQ5Yes"
        rbQ5Yes.Size = New Size(54, 29)
        rbQ5Yes.TabIndex = 0
        rbQ5Yes.Text = "Ya"
        rbQ5Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ6
        ' 
        LabelQ6.AutoSize = True
        LabelQ6.Font = New Font("Segoe UI", 10F)
        LabelQ6.ForeColor = Color.FromArgb(CByte(64), CByte(72), CByte(86))
        LabelQ6.Location = New Point(3, 300)
        LabelQ6.Margin = New Padding(3, 0, 10, 0)
        LabelQ6.Name = "LabelQ6"
        LabelQ6.Size = New Size(440, 56)
        LabelQ6.TabIndex = 10
        LabelQ6.Text = "6. Apakah pajak yang dipotong lebih BESAR dari terutang?"
        ' 
        ' PanelQ6
        ' 
        PanelQ6.Controls.Add(rbQ6No)
        PanelQ6.Controls.Add(rbQ6Yes)
        PanelQ6.Dock = DockStyle.Fill
        PanelQ6.Location = New Point(510, 303)
        PanelQ6.Name = "PanelQ6"
        PanelQ6.Size = New Size(267, 54)
        PanelQ6.TabIndex = 11
        ' 
        ' rbQ6No
        ' 
        rbQ6No.AutoSize = True
        rbQ6No.Checked = True
        rbQ6No.Font = New Font("Segoe UI", 9F)
        rbQ6No.Location = New Point(122, 12)
        rbQ6No.Name = "rbQ6No"
        rbQ6No.Size = New Size(79, 29)
        rbQ6No.TabIndex = 1
        rbQ6No.TabStop = True
        rbQ6No.Text = "Tidak"
        rbQ6No.UseVisualStyleBackColor = True
        ' 
        ' rbQ6Yes
        ' 
        rbQ6Yes.AutoSize = True
        rbQ6Yes.Font = New Font("Segoe UI", 9F)
        rbQ6Yes.Location = New Point(16, 12)
        rbQ6Yes.Name = "rbQ6Yes"
        rbQ6Yes.Size = New Size(54, 29)
        rbQ6Yes.TabIndex = 0
        rbQ6Yes.Text = "Ya"
        rbQ6Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ7
        ' 
        LabelQ7.AutoSize = True
        LabelQ7.Font = New Font("Segoe UI", 10F)
        LabelQ7.ForeColor = Color.FromArgb(CByte(64), CByte(72), CByte(86))
        LabelQ7.Location = New Point(3, 360)
        LabelQ7.Margin = New Padding(3, 0, 10, 0)
        LabelQ7.Name = "LabelQ7"
        LabelQ7.Size = New Size(431, 56)
        LabelQ7.TabIndex = 12
        LabelQ7.Text = "7. Apakah pajak yang dipotong lebih KECIL dari terutang?"
        ' 
        ' PanelQ7
        ' 
        PanelQ7.Controls.Add(rbQ7No)
        PanelQ7.Controls.Add(rbQ7Yes)
        PanelQ7.Dock = DockStyle.Fill
        PanelQ7.Location = New Point(510, 363)
        PanelQ7.Name = "PanelQ7"
        PanelQ7.Size = New Size(267, 54)
        PanelQ7.TabIndex = 13
        ' 
        ' rbQ7No
        ' 
        rbQ7No.AutoSize = True
        rbQ7No.Checked = True
        rbQ7No.Font = New Font("Segoe UI", 9F)
        rbQ7No.Location = New Point(122, 12)
        rbQ7No.Name = "rbQ7No"
        rbQ7No.Size = New Size(79, 29)
        rbQ7No.TabIndex = 1
        rbQ7No.TabStop = True
        rbQ7No.Text = "Tidak"
        rbQ7No.UseVisualStyleBackColor = True
        ' 
        ' rbQ7Yes
        ' 
        rbQ7Yes.AutoSize = True
        rbQ7Yes.Font = New Font("Segoe UI", 9F)
        rbQ7Yes.Location = New Point(16, 12)
        rbQ7Yes.Name = "rbQ7Yes"
        rbQ7Yes.Size = New Size(54, 29)
        rbQ7Yes.TabIndex = 0
        rbQ7Yes.Text = "Ya"
        rbQ7Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelQ8
        ' 
        LabelQ8.AutoSize = True
        LabelQ8.Font = New Font("Segoe UI", 10F)
        LabelQ8.ForeColor = Color.FromArgb(CByte(64), CByte(72), CByte(86))
        LabelQ8.Location = New Point(3, 420)
        LabelQ8.Margin = New Padding(3, 0, 10, 0)
        LabelQ8.Name = "LabelQ8"
        LabelQ8.Size = New Size(435, 56)
        LabelQ8.TabIndex = 14
        LabelQ8.Text = "8. Jika ada kurang bayar, apakah sudah lunas via e-Billing?"
        ' 
        ' PanelQ8
        ' 
        PanelQ8.Controls.Add(rbQ8No)
        PanelQ8.Controls.Add(rbQ8Yes)
        PanelQ8.Dock = DockStyle.Fill
        PanelQ8.Location = New Point(510, 423)
        PanelQ8.Name = "PanelQ8"
        PanelQ8.Size = New Size(267, 54)
        PanelQ8.TabIndex = 15
        ' 
        ' rbQ8No
        ' 
        rbQ8No.AutoSize = True
        rbQ8No.Checked = True
        rbQ8No.Font = New Font("Segoe UI", 9F)
        rbQ8No.Location = New Point(122, 12)
        rbQ8No.Name = "rbQ8No"
        rbQ8No.Size = New Size(79, 29)
        rbQ8No.TabIndex = 1
        rbQ8No.TabStop = True
        rbQ8No.Text = "Tidak"
        rbQ8No.UseVisualStyleBackColor = True
        ' 
        ' rbQ8Yes
        ' 
        rbQ8Yes.AutoSize = True
        rbQ8Yes.Font = New Font("Segoe UI", 9F)
        rbQ8Yes.Location = New Point(16, 12)
        rbQ8Yes.Name = "rbQ8Yes"
        rbQ8Yes.Size = New Size(54, 29)
        rbQ8Yes.TabIndex = 0
        rbQ8Yes.Text = "Ya"
        rbQ8Yes.UseVisualStyleBackColor = True
        ' 
        ' LabelInputSubtitle
        ' 
        LabelInputSubtitle.AutoSize = True
        LabelInputSubtitle.Font = New Font("Segoe UI", 10F)
        LabelInputSubtitle.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        LabelInputSubtitle.Location = New Point(32, 92)
        LabelInputSubtitle.Name = "LabelInputSubtitle"
        LabelInputSubtitle.Size = New Size(390, 28)
        LabelInputSubtitle.TabIndex = 1
        LabelInputSubtitle.Text = "Masukkan komponen penghasilan tahunan."
        ' 
        ' LabelInputTitle
        ' 
        LabelInputTitle.AutoSize = True
        LabelInputTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        LabelInputTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelInputTitle.Location = New Point(28, 36)
        LabelInputTitle.Name = "LabelInputTitle"
        LabelInputTitle.Size = New Size(311, 38)
        LabelInputTitle.TabIndex = 0
        LabelInputTitle.Text = "Data Penghasilan Anda"
        ' 
        ' PanelSide
        ' 
        PanelSide.BackColor = Color.Transparent
        PanelSide.Controls.Add(PanelHistory)
        PanelSide.Controls.Add(PanelStatusCard)
        PanelSide.Dock = DockStyle.Right
        PanelSide.Location = New Point(888, 32)
        PanelSide.Name = "PanelSide"
        PanelSide.Padding = New Padding(24, 0, 0, 0)
        PanelSide.Size = New Size(400, 616)
        PanelSide.TabIndex = 1
        ' 
        ' PanelHistory
        ' 
        PanelHistory.BackColor = Color.White
        PanelHistory.Controls.Add(ListBoxHistory)
        PanelHistory.Controls.Add(LabelHistoryTitle)
        PanelHistory.Dock = DockStyle.Fill
        PanelHistory.Location = New Point(24, 276)
        PanelHistory.Name = "PanelHistory"
        PanelHistory.Padding = New Padding(24)
        PanelHistory.Size = New Size(376, 340)
        PanelHistory.TabIndex = 1
        ' 
        ' ListBoxHistory
        ' 
        ListBoxHistory.BorderStyle = BorderStyle.None
        ListBoxHistory.Dock = DockStyle.Fill
        ListBoxHistory.Font = New Font("Segoe UI", 9F)
        ListBoxHistory.FormattingEnabled = True
        ListBoxHistory.ItemHeight = 25
        ListBoxHistory.Location = New Point(24, 54)
        ListBoxHistory.Name = "ListBoxHistory"
        ListBoxHistory.Size = New Size(328, 262)
        ListBoxHistory.TabIndex = 1
        ' 
        ' LabelHistoryTitle
        ' 
        LabelHistoryTitle.AutoSize = True
        LabelHistoryTitle.Dock = DockStyle.Top
        LabelHistoryTitle.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        LabelHistoryTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelHistoryTitle.Location = New Point(24, 24)
        LabelHistoryTitle.Name = "LabelHistoryTitle"
        LabelHistoryTitle.Size = New Size(179, 30)
        LabelHistoryTitle.TabIndex = 0
        LabelHistoryTitle.Text = "Riwayat Simulasi"
        ' 
        ' PanelStatusCard
        ' 
        PanelStatusCard.BackColor = Color.White
        PanelStatusCard.Controls.Add(lblPanduanBilling)
        PanelStatusCard.Controls.Add(pnlStatus)
        PanelStatusCard.Controls.Add(LabelStatusTitle)
        PanelStatusCard.Dock = DockStyle.Top
        PanelStatusCard.Location = New Point(24, 0)
        PanelStatusCard.Name = "PanelStatusCard"
        PanelStatusCard.Padding = New Padding(24)
        PanelStatusCard.Size = New Size(376, 276)
        PanelStatusCard.TabIndex = 0
        ' 
        ' lblPanduanBilling
        ' 
        lblPanduanBilling.AutoSize = True
        lblPanduanBilling.Cursor = Cursors.Hand
        lblPanduanBilling.Font = New Font("Segoe UI", 9F, FontStyle.Underline)
        lblPanduanBilling.ForeColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        lblPanduanBilling.Location = New Point(27, 232)
        lblPanduanBilling.Name = "lblPanduanBilling"
        lblPanduanBilling.Size = New Size(275, 25)
        lblPanduanBilling.TabIndex = 2
        lblPanduanBilling.Text = "Panduan membuat kode e-Billing"
        lblPanduanBilling.Visible = False
        ' 
        ' pnlStatus
        ' 
        pnlStatus.BackColor = Color.FromArgb(CByte(226), CByte(232), CByte(255))
        pnlStatus.Controls.Add(lblStatusDetail)
        pnlStatus.Controls.Add(lblStatusResult)
        pnlStatus.Location = New Point(27, 84)
        pnlStatus.Name = "pnlStatus"
        pnlStatus.Padding = New Padding(20)
        pnlStatus.Size = New Size(322, 140)
        pnlStatus.TabIndex = 1
        ' 
        ' lblStatusDetail
        ' 
        lblStatusDetail.Dock = DockStyle.Fill
        lblStatusDetail.Font = New Font("Segoe UI", 9F)
        lblStatusDetail.ForeColor = Color.FromArgb(CByte(53), CByte(63), CByte(86))
        lblStatusDetail.Location = New Point(20, 58)
        lblStatusDetail.Name = "lblStatusDetail"
        lblStatusDetail.Size = New Size(282, 62)
        lblStatusDetail.TabIndex = 1
        lblStatusDetail.Text = "Hitung simulasi untuk melihat status terbaru."
        ' 
        ' lblStatusResult
        ' 
        lblStatusResult.Dock = DockStyle.Top
        lblStatusResult.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblStatusResult.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        lblStatusResult.Location = New Point(20, 20)
        lblStatusResult.Name = "lblStatusResult"
        lblStatusResult.Size = New Size(282, 38)
        lblStatusResult.TabIndex = 0
        lblStatusResult.Text = "Belum dihitung"
        ' 
        ' LabelStatusTitle
        ' 
        LabelStatusTitle.AutoSize = True
        LabelStatusTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelStatusTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelStatusTitle.Location = New Point(21, 24)
        LabelStatusTitle.Name = "LabelStatusTitle"
        LabelStatusTitle.Size = New Size(223, 32)
        LabelStatusTitle.TabIndex = 0
        LabelStatusTitle.Text = "Status Pembayaran"
        ' 
        ' Simulasi
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(252))
        ClientSize = New Size(1320, 820)
        Controls.Add(PanelMain)
        Controls.Add(PanelHeader)
        Font = New Font("Segoe UI", 9F)
        Name = "Simulasi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Simulasi Pajak"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelMain.ResumeLayout(False)
        PanelInputCard.ResumeLayout(False)
        PanelInputCard.PerformLayout()
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
        PanelHistory.ResumeLayout(False)
        PanelHistory.PerformLayout()
        PanelStatusCard.ResumeLayout(False)
        PanelStatusCard.PerformLayout()
        pnlStatus.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelInputCard As Panel
    Friend WithEvents LabelInputTitle As Label
    Friend WithEvents LabelInputSubtitle As Label
    Friend WithEvents TableQuestions As TableLayoutPanel
    Friend WithEvents LabelQ1 As Label
    Friend WithEvents LabelQ2 As Label
    Friend WithEvents LabelQ3 As Label
    Friend WithEvents LabelQ4 As Label
    Friend WithEvents LabelQ5 As Label
    Friend WithEvents LabelQ6 As Label
    Friend WithEvents LabelQ7 As Label
    Friend WithEvents LabelQ8 As Label
    Friend WithEvents PanelQ1 As Panel
    Friend WithEvents PanelQ2 As Panel
    Friend WithEvents PanelQ3 As Panel
    Friend WithEvents PanelQ4 As Panel
    Friend WithEvents PanelQ5 As Panel
    Friend WithEvents PanelQ6 As Panel
    Friend WithEvents PanelQ7 As Panel
    Friend WithEvents PanelQ8 As Panel
    Friend WithEvents rbQ1No As RadioButton
    Friend WithEvents rbQ1Yes As RadioButton
    Friend WithEvents rbQ2No As RadioButton
    Friend WithEvents rbQ2Yes As RadioButton
    Friend WithEvents rbQ3No As RadioButton
    Friend WithEvents rbQ3Yes As RadioButton
    Friend WithEvents rbQ4No As RadioButton
    Friend WithEvents rbQ4Yes As RadioButton
    Friend WithEvents rbQ5No As RadioButton
    Friend WithEvents rbQ5Yes As RadioButton
    Friend WithEvents rbQ6No As RadioButton
    Friend WithEvents rbQ6Yes As RadioButton
    Friend WithEvents rbQ7No As RadioButton
    Friend WithEvents rbQ7Yes As RadioButton
    Friend WithEvents rbQ8No As RadioButton
    Friend WithEvents rbQ8Yes As RadioButton
    Friend WithEvents btnHitungSimulasi As Button
    Friend WithEvents PanelSide As Panel
    Friend WithEvents PanelStatusCard As Panel
    Friend WithEvents LabelStatusTitle As Label
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblStatusResult As Label
    Friend WithEvents lblStatusDetail As Label
    Friend WithEvents lblPanduanBilling As Label
    Friend WithEvents PanelHistory As Panel
    Friend WithEvents LabelHistoryTitle As Label
    Friend WithEvents ListBoxHistory As ListBox
End Class
