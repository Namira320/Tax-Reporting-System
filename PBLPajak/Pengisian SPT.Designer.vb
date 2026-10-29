<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengisian_SPT
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
        Label1 = New Label()
        PanelButtons = New FlowLayoutPanel()
        ButtonBatal = New Button()
        Button1 = New Button()
        ButtonSimpan = New Button()
        ButtonPreview = New Button()
        GroupBoxPelaporan = New GroupBox()
        TableLayoutPanelPelaporan = New TableLayoutPanel()
        LabelStatus = New Label()
        LabelPenghasilan = New Label()
        LabelPPh = New Label()
        LabelKredit = New Label()
        LabelTanggal = New Label()
        ComboBoxStatus = New ComboBox()
        TextBoxPenghasilan = New TextBox()
        TextBoxPPh = New TextBox()
        TextBoxKredit = New TextBox()
        DateTimePickerLapor = New DateTimePicker()
        GroupBoxIdentitas = New GroupBox()
        TableLayoutPanelIdentitas = New TableLayoutPanel()
        LabelNPWP = New Label()
        LabelNama = New Label()
        LabelJenisSPT = New Label()
        LabelTahun = New Label()
        TextBoxNPWP = New TextBox()
        TextBoxNama = New TextBox()
        ComboBoxJenisSPT = New ComboBox()
        NumericUpDownTahun = New NumericUpDown()
        LabelTitle = New Label()
        PanelWrapper.SuspendLayout()
        PanelButtons.SuspendLayout()
        GroupBoxPelaporan.SuspendLayout()
        TableLayoutPanelPelaporan.SuspendLayout()
        GroupBoxIdentitas.SuspendLayout()
        TableLayoutPanelIdentitas.SuspendLayout()
        CType(NumericUpDownTahun, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelWrapper
        ' 
        PanelWrapper.Anchor = AnchorStyles.None
        PanelWrapper.BackColor = Color.White
        PanelWrapper.Controls.Add(Label1)
        PanelWrapper.Controls.Add(PanelButtons)
        PanelWrapper.Controls.Add(GroupBoxPelaporan)
        PanelWrapper.Controls.Add(GroupBoxIdentitas)
        PanelWrapper.Controls.Add(LabelTitle)
        PanelWrapper.ForeColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelWrapper.Location = New Point(29, 20)
        PanelWrapper.Margin = New Padding(3, 4, 3, 4)
        PanelWrapper.Name = "PanelWrapper"
        PanelWrapper.Padding = New Padding(32, 38, 32, 38)
        PanelWrapper.Size = New Size(1856, 874)
        PanelWrapper.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(102), CByte(108), CByte(122))
        Label1.Location = New Point(40, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(1160, 49)
        Label1.TabIndex = 5
        Label1.Text = "Lengkapi identitas wajib pajak dan data pelaporan SPT sebelum menyimpan atau mencetak draf."
        ' 
        ' PanelButtons
        ' 
        PanelButtons.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PanelButtons.BackColor = Color.White
        PanelButtons.Controls.Add(ButtonBatal)
        PanelButtons.Controls.Add(Button1)
        PanelButtons.Controls.Add(ButtonSimpan)
        PanelButtons.Controls.Add(ButtonPreview)
        PanelButtons.FlowDirection = FlowDirection.RightToLeft
        PanelButtons.Location = New Point(1207, 782)
        PanelButtons.Margin = New Padding(3, 4, 3, 4)
        PanelButtons.Name = "PanelButtons"
        PanelButtons.Padding = New Padding(0, 19, 0, 0)
        PanelButtons.Size = New Size(614, 94)
        PanelButtons.TabIndex = 4
        ' 
        ' ButtonBatal
        ' 
        ButtonBatal.BackColor = Color.White
        ButtonBatal.Cursor = Cursors.Hand
        ButtonBatal.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(214), CByte(224))
        ButtonBatal.FlatStyle = FlatStyle.Flat
        ButtonBatal.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonBatal.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        ButtonBatal.Location = New Point(493, 23)
        ButtonBatal.Margin = New Padding(8, 4, 8, 4)
        ButtonBatal.Name = "ButtonBatal"
        ButtonBatal.Size = New Size(113, 58)
        ButtonBatal.TabIndex = 2
        ButtonBatal.Text = "Tutup"
        ButtonBatal.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(214), CByte(224))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        Button1.Location = New Point(364, 23)
        Button1.Margin = New Padding(8, 4, 8, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 58)
        Button1.TabIndex = 3
        Button1.Text = "Batal"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ButtonSimpan
        ' 
        ButtonSimpan.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        ButtonSimpan.Cursor = Cursors.Hand
        ButtonSimpan.FlatAppearance.BorderSize = 0
        ButtonSimpan.FlatStyle = FlatStyle.Flat
        ButtonSimpan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSimpan.ForeColor = Color.White
        ButtonSimpan.Location = New Point(232, 23)
        ButtonSimpan.Margin = New Padding(0, 4, 8, 4)
        ButtonSimpan.Name = "ButtonSimpan"
        ButtonSimpan.Size = New Size(116, 58)
        ButtonSimpan.TabIndex = 0
        ButtonSimpan.Text = "Simpan"
        ButtonSimpan.UseVisualStyleBackColor = False
        ' 
        ' ButtonPreview
        ' 
        ButtonPreview.BackColor = Color.FromArgb(CByte(238), CByte(244), CByte(255))
        ButtonPreview.Cursor = Cursors.Hand
        ButtonPreview.FlatAppearance.BorderSize = 0
        ButtonPreview.FlatStyle = FlatStyle.Flat
        ButtonPreview.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonPreview.ForeColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
        ButtonPreview.Location = New Point(58, 23)
        ButtonPreview.Margin = New Padding(8, 4, 8, 4)
        ButtonPreview.Name = "ButtonPreview"
        ButtonPreview.Size = New Size(166, 58)
        ButtonPreview.TabIndex = 1
        ButtonPreview.Text = "Pratinjau"
        ButtonPreview.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxPelaporan
        ' 
        GroupBoxPelaporan.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBoxPelaporan.Controls.Add(TableLayoutPanelPelaporan)
        GroupBoxPelaporan.Font = New Font("Dubai", 10F, FontStyle.Bold)
        GroupBoxPelaporan.Location = New Point(40, 436)
        GroupBoxPelaporan.Margin = New Padding(3, 4, 3, 4)
        GroupBoxPelaporan.Name = "GroupBoxPelaporan"
        GroupBoxPelaporan.Padding = New Padding(16, 19, 16, 19)
        GroupBoxPelaporan.Size = New Size(1776, 337)
        GroupBoxPelaporan.TabIndex = 3
        GroupBoxPelaporan.TabStop = False
        GroupBoxPelaporan.Text = "Detail Pelaporan"
        ' 
        ' TableLayoutPanelPelaporan
        ' 
        TableLayoutPanelPelaporan.ColumnCount = 2
        TableLayoutPanelPelaporan.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanelPelaporan.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanelPelaporan.Controls.Add(LabelStatus, 0, 0)
        TableLayoutPanelPelaporan.Controls.Add(LabelPenghasilan, 0, 1)
        TableLayoutPanelPelaporan.Controls.Add(LabelPPh, 0, 2)
        TableLayoutPanelPelaporan.Controls.Add(LabelKredit, 0, 3)
        TableLayoutPanelPelaporan.Controls.Add(LabelTanggal, 0, 4)
        TableLayoutPanelPelaporan.Controls.Add(ComboBoxStatus, 1, 0)
        TableLayoutPanelPelaporan.Controls.Add(TextBoxPenghasilan, 1, 1)
        TableLayoutPanelPelaporan.Controls.Add(TextBoxPPh, 1, 2)
        TableLayoutPanelPelaporan.Controls.Add(TextBoxKredit, 1, 3)
        TableLayoutPanelPelaporan.Controls.Add(DateTimePickerLapor, 1, 4)
        TableLayoutPanelPelaporan.Dock = DockStyle.Fill
        TableLayoutPanelPelaporan.Location = New Point(16, 65)
        TableLayoutPanelPelaporan.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanelPelaporan.Name = "TableLayoutPanelPelaporan"
        TableLayoutPanelPelaporan.RowCount = 5
        TableLayoutPanelPelaporan.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelPelaporan.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelPelaporan.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelPelaporan.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelPelaporan.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelPelaporan.Size = New Size(1744, 253)
        TableLayoutPanelPelaporan.TabIndex = 0
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelStatus.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelStatus.Location = New Point(3, 0)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(219, 40)
        LabelStatus.TabIndex = 0
        LabelStatus.Text = "Status SPT (N/T/L)"
        ' 
        ' LabelPenghasilan
        ' 
        LabelPenghasilan.AutoSize = True
        LabelPenghasilan.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPenghasilan.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelPenghasilan.Location = New Point(3, 50)
        LabelPenghasilan.Name = "LabelPenghasilan"
        LabelPenghasilan.Size = New Size(182, 40)
        LabelPenghasilan.TabIndex = 1
        LabelPenghasilan.Text = "Penghasilan neto"
        ' 
        ' LabelPPh
        ' 
        LabelPPh.AutoSize = True
        LabelPPh.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPPh.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelPPh.Location = New Point(3, 100)
        LabelPPh.Name = "LabelPPh"
        LabelPPh.Size = New Size(148, 40)
        LabelPPh.TabIndex = 2
        LabelPPh.Text = "PPh terutang"
        ' 
        ' LabelKredit
        ' 
        LabelKredit.AutoSize = True
        LabelKredit.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelKredit.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelKredit.Location = New Point(3, 150)
        LabelKredit.Name = "LabelKredit"
        LabelKredit.Size = New Size(133, 40)
        LabelKredit.TabIndex = 3
        LabelKredit.Text = "Kredit pajak"
        ' 
        ' LabelTanggal
        ' 
        LabelTanggal.AutoSize = True
        LabelTanggal.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTanggal.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelTanggal.Location = New Point(3, 200)
        LabelTanggal.Name = "LabelTanggal"
        LabelTanggal.Size = New Size(195, 40)
        LabelTanggal.TabIndex = 4
        LabelTanggal.Text = "Tanggal pelaporan"
        ' 
        ' ComboBoxStatus
        ' 
        ComboBoxStatus.Dock = DockStyle.Fill
        ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxStatus.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxStatus.FormattingEnabled = True
        ComboBoxStatus.Items.AddRange(New Object() {"Normal", "Pembetulan I", "Pembetulan II", "Pembetulan III"})
        ComboBoxStatus.Location = New Point(526, 4)
        ComboBoxStatus.Margin = New Padding(3, 4, 3, 4)
        ComboBoxStatus.Name = "ComboBoxStatus"
        ComboBoxStatus.Size = New Size(1215, 53)
        ComboBoxStatus.TabIndex = 5
        ' 
        ' TextBoxPenghasilan
        ' 
        TextBoxPenghasilan.BorderStyle = BorderStyle.FixedSingle
        TextBoxPenghasilan.Dock = DockStyle.Fill
        TextBoxPenghasilan.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPenghasilan.Location = New Point(526, 54)
        TextBoxPenghasilan.Margin = New Padding(3, 4, 3, 4)
        TextBoxPenghasilan.Name = "TextBoxPenghasilan"
        TextBoxPenghasilan.PlaceholderText = "0"
        TextBoxPenghasilan.Size = New Size(1215, 53)
        TextBoxPenghasilan.TabIndex = 6
        TextBoxPenghasilan.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxPPh
        ' 
        TextBoxPPh.BorderStyle = BorderStyle.FixedSingle
        TextBoxPPh.Dock = DockStyle.Fill
        TextBoxPPh.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPPh.Location = New Point(526, 104)
        TextBoxPPh.Margin = New Padding(3, 4, 3, 4)
        TextBoxPPh.Name = "TextBoxPPh"
        TextBoxPPh.PlaceholderText = "0"
        TextBoxPPh.Size = New Size(1215, 53)
        TextBoxPPh.TabIndex = 7
        TextBoxPPh.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxKredit
        ' 
        TextBoxKredit.BorderStyle = BorderStyle.FixedSingle
        TextBoxKredit.Dock = DockStyle.Fill
        TextBoxKredit.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxKredit.Location = New Point(526, 154)
        TextBoxKredit.Margin = New Padding(3, 4, 3, 4)
        TextBoxKredit.Name = "TextBoxKredit"
        TextBoxKredit.PlaceholderText = "0"
        TextBoxKredit.Size = New Size(1215, 53)
        TextBoxKredit.TabIndex = 8
        TextBoxKredit.TextAlign = HorizontalAlignment.Right
        ' 
        ' DateTimePickerLapor
        ' 
        DateTimePickerLapor.Dock = DockStyle.Left
        DateTimePickerLapor.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePickerLapor.Format = DateTimePickerFormat.Short
        DateTimePickerLapor.Location = New Point(526, 204)
        DateTimePickerLapor.Margin = New Padding(3, 4, 3, 4)
        DateTimePickerLapor.Name = "DateTimePickerLapor"
        DateTimePickerLapor.Size = New Size(200, 53)
        DateTimePickerLapor.TabIndex = 9
        ' 
        ' GroupBoxIdentitas
        ' 
        GroupBoxIdentitas.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBoxIdentitas.Controls.Add(TableLayoutPanelIdentitas)
        GroupBoxIdentitas.Font = New Font("Dubai", 10F, FontStyle.Bold)
        GroupBoxIdentitas.Location = New Point(40, 177)
        GroupBoxIdentitas.Margin = New Padding(3, 4, 3, 4)
        GroupBoxIdentitas.Name = "GroupBoxIdentitas"
        GroupBoxIdentitas.Padding = New Padding(16, 19, 16, 19)
        GroupBoxIdentitas.Size = New Size(1776, 267)
        GroupBoxIdentitas.TabIndex = 2
        GroupBoxIdentitas.TabStop = False
        GroupBoxIdentitas.Text = "Data Wajib Pajak"
        ' 
        ' TableLayoutPanelIdentitas
        ' 
        TableLayoutPanelIdentitas.ColumnCount = 2
        TableLayoutPanelIdentitas.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanelIdentitas.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanelIdentitas.Controls.Add(LabelNPWP, 0, 0)
        TableLayoutPanelIdentitas.Controls.Add(LabelNama, 0, 1)
        TableLayoutPanelIdentitas.Controls.Add(LabelJenisSPT, 0, 2)
        TableLayoutPanelIdentitas.Controls.Add(LabelTahun, 0, 3)
        TableLayoutPanelIdentitas.Controls.Add(TextBoxNPWP, 1, 0)
        TableLayoutPanelIdentitas.Controls.Add(TextBoxNama, 1, 1)
        TableLayoutPanelIdentitas.Controls.Add(ComboBoxJenisSPT, 1, 2)
        TableLayoutPanelIdentitas.Controls.Add(NumericUpDownTahun, 1, 3)
        TableLayoutPanelIdentitas.Dock = DockStyle.Fill
        TableLayoutPanelIdentitas.Location = New Point(16, 65)
        TableLayoutPanelIdentitas.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanelIdentitas.Name = "TableLayoutPanelIdentitas"
        TableLayoutPanelIdentitas.RowCount = 4
        TableLayoutPanelIdentitas.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanelIdentitas.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanelIdentitas.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanelIdentitas.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanelIdentitas.Size = New Size(1744, 183)
        TableLayoutPanelIdentitas.TabIndex = 0
        ' 
        ' LabelNPWP
        ' 
        LabelNPWP.AutoSize = True
        LabelNPWP.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNPWP.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelNPWP.Location = New Point(3, 0)
        LabelNPWP.Name = "LabelNPWP"
        LabelNPWP.Size = New Size(84, 40)
        LabelNPWP.TabIndex = 0
        LabelNPWP.Text = "NPWP"
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNama.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelNama.Location = New Point(3, 45)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(186, 40)
        LabelNama.TabIndex = 1
        LabelNama.Text = "Nama wajib pajak"
        ' 
        ' LabelJenisSPT
        ' 
        LabelJenisSPT.AutoSize = True
        LabelJenisSPT.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelJenisSPT.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelJenisSPT.Location = New Point(3, 90)
        LabelJenisSPT.Name = "LabelJenisSPT"
        LabelJenisSPT.Size = New Size(113, 40)
        LabelJenisSPT.TabIndex = 2
        LabelJenisSPT.Text = "Jenis SPT"
        ' 
        ' LabelTahun
        ' 
        LabelTahun.AutoSize = True
        LabelTahun.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTahun.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelTahun.Location = New Point(3, 135)
        LabelTahun.Name = "LabelTahun"
        LabelTahun.Size = New Size(134, 40)
        LabelTahun.TabIndex = 3
        LabelTahun.Text = "Tahun pajak"
        ' 
        ' TextBoxNPWP
        ' 
        TextBoxNPWP.BorderStyle = BorderStyle.FixedSingle
        TextBoxNPWP.Dock = DockStyle.Fill
        TextBoxNPWP.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxNPWP.Location = New Point(526, 4)
        TextBoxNPWP.Margin = New Padding(3, 4, 3, 4)
        TextBoxNPWP.MaxLength = 20
        TextBoxNPWP.Name = "TextBoxNPWP"
        TextBoxNPWP.PlaceholderText = "XX.XXX.XXX.X-XXX.XXX"
        TextBoxNPWP.Size = New Size(1215, 53)
        TextBoxNPWP.TabIndex = 4
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.BorderStyle = BorderStyle.FixedSingle
        TextBoxNama.Dock = DockStyle.Fill
        TextBoxNama.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxNama.Location = New Point(526, 49)
        TextBoxNama.Margin = New Padding(3, 4, 3, 4)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.PlaceholderText = "Nama sesuai NPWP"
        TextBoxNama.Size = New Size(1215, 53)
        TextBoxNama.TabIndex = 5
        ' 
        ' ComboBoxJenisSPT
        ' 
        ComboBoxJenisSPT.Dock = DockStyle.Fill
        ComboBoxJenisSPT.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxJenisSPT.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxJenisSPT.FormattingEnabled = True
        ComboBoxJenisSPT.Items.AddRange(New Object() {"SPT Tahunan OP 1770", "SPT Tahunan OP 1770 S", "SPT Tahunan OP 1770 SS", "SPT Masa"})
        ComboBoxJenisSPT.Location = New Point(526, 94)
        ComboBoxJenisSPT.Margin = New Padding(3, 4, 3, 4)
        ComboBoxJenisSPT.Name = "ComboBoxJenisSPT"
        ComboBoxJenisSPT.Size = New Size(1215, 45)
        ComboBoxJenisSPT.TabIndex = 6
        ' 
        ' NumericUpDownTahun
        ' 
        NumericUpDownTahun.Dock = DockStyle.Left
        NumericUpDownTahun.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NumericUpDownTahun.Location = New Point(526, 139)
        NumericUpDownTahun.Margin = New Padding(3, 4, 3, 4)
        NumericUpDownTahun.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        NumericUpDownTahun.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        NumericUpDownTahun.Name = "NumericUpDownTahun"
        NumericUpDownTahun.Size = New Size(120, 53)
        NumericUpDownTahun.TabIndex = 7
        NumericUpDownTahun.Value = New Decimal(New Integer() {2024, 0, 0, 0})
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Dubai", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(44))
        LabelTitle.Location = New Point(33, 28)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(399, 100)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Pengisian SPT"
        ' 
        ' Pengisian_SPT
        ' 
        AcceptButton = ButtonSimpan
        AutoScaleDimensions = New SizeF(13F, 40F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        ClientSize = New Size(1902, 946)
        Controls.Add(PanelWrapper)
        Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "Pengisian_SPT"
        Padding = New Padding(40, 48, 40, 48)
        StartPosition = FormStartPosition.CenterParent
        Text = "Coretax | Pengisian SPT"
        PanelWrapper.ResumeLayout(False)
        PanelWrapper.PerformLayout()
        PanelButtons.ResumeLayout(False)
        GroupBoxPelaporan.ResumeLayout(False)
        TableLayoutPanelPelaporan.ResumeLayout(False)
        TableLayoutPanelPelaporan.PerformLayout()
        GroupBoxIdentitas.ResumeLayout(False)
        TableLayoutPanelIdentitas.ResumeLayout(False)
        TableLayoutPanelIdentitas.PerformLayout()
        CType(NumericUpDownTahun, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents GroupBoxIdentitas As GroupBox
    Friend WithEvents TableLayoutPanelIdentitas As TableLayoutPanel
    Friend WithEvents LabelNPWP As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelJenisSPT As Label
    Friend WithEvents LabelTahun As Label
    Friend WithEvents TextBoxNPWP As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents ComboBoxJenisSPT As ComboBox
    Friend WithEvents NumericUpDownTahun As NumericUpDown
    Friend WithEvents GroupBoxPelaporan As GroupBox
    Friend WithEvents TableLayoutPanelPelaporan As TableLayoutPanel
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelPenghasilan As Label
    Friend WithEvents LabelPPh As Label
    Friend WithEvents LabelKredit As Label
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents TextBoxPenghasilan As TextBox
    Friend WithEvents TextBoxPPh As TextBox
    Friend WithEvents TextBoxKredit As TextBox
    Friend WithEvents DateTimePickerLapor As DateTimePicker
    Friend WithEvents PanelButtons As FlowLayoutPanel
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonPreview As Button
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
