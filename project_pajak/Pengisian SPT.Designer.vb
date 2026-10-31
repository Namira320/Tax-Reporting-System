<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pengisian_SPT
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
        PanelWrapper = New Panel()
        GroupBoxPelaporan = New GroupBox()
        DateTimePickerLapor = New DateTimePicker()
        LabelTanggal = New Label()
        TextBoxKredit = New TextBox()
        LabelKredit = New Label()
        TextBoxPPh = New TextBox()
        LabelPPh = New Label()
        TextBoxPenghasilan = New TextBox()
        LabelPenghasilan = New Label()

        ComboBoxStatus = New ComboBox()
        LabelStatus = New Label()
        TextBoxBruto = New TextBox() ' New
        LabelBruto = New Label() ' New
        TextBoxBiayaJabatan = New TextBox() ' New
        LabelBiayaJabatan = New Label() ' New
        TextBoxIuran = New TextBox() ' New
        LabelIuran = New Label() ' New
        TextBoxPKP = New TextBox()
        LabelPKP = New Label()
        GroupBoxIdentitas = New GroupBox()
        NumericUpDownTahun = New NumericUpDown()
        LabelTahun = New Label()
        ComboBoxJenisSPT = New ComboBox()
        LabelJenisSPT = New Label()
        TextBoxNama = New TextBox()
        LabelNama = New Label()
        TextBoxNPWP = New TextBox()
        LabelNPWP = New Label()
        ComboBoxStatusPTKP = New ComboBox()
        LabelStatusPTKP = New Label()
        ButtonUnggahDokumen = New Button()
        Label2 = New Label()
        Label1 = New Label()
        LabelTitle = New Label()
        PanelButtons = New FlowLayoutPanel()
        ButtonPreview = New Button()
        ButtonSimpan = New Button()
        ButtonKeSumulasi = New Button()
        ButtonExportPDF = New Button()
        ButtonBatal = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PanelWrapper.SuspendLayout()
        GroupBoxPelaporan.SuspendLayout()
        GroupBoxIdentitas.SuspendLayout()
        CType(NumericUpDownTahun, ComponentModel.ISupportInitialize).BeginInit()
        PanelButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelWrapper
        ' 
        PanelWrapper.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelWrapper.AutoScroll = True
        PanelWrapper.BackColor = Color.White
        PanelWrapper.Controls.Add(GroupBoxPelaporan)
        PanelWrapper.Controls.Add(GroupBoxIdentitas)
        PanelWrapper.Controls.Add(ButtonUnggahDokumen)
        PanelWrapper.Controls.Add(Label2)
        PanelWrapper.Controls.Add(Label1)
        PanelWrapper.Controls.Add(LabelTitle)
        PanelWrapper.Location = New Point(20, 20)
        PanelWrapper.Name = "PanelWrapper"
        PanelWrapper.Padding = New Padding(30)
        PanelWrapper.Size = New Size(1560, 760)
        PanelWrapper.TabIndex = 0
        ' 
        ' GroupBoxPelaporan
        ' 
        GroupBoxPelaporan.Controls.Add(DateTimePickerLapor)
        GroupBoxPelaporan.Controls.Add(LabelTanggal)
        GroupBoxPelaporan.Controls.Add(TextBoxKredit)
        GroupBoxPelaporan.Controls.Add(LabelKredit)
        GroupBoxPelaporan.Controls.Add(TextBoxPPh)
        GroupBoxPelaporan.Controls.Add(LabelPPh)
        GroupBoxPelaporan.Controls.Add(TextBoxPKP)
        GroupBoxPelaporan.Controls.Add(LabelPKP)
        GroupBoxPelaporan.Controls.Add(TextBoxPenghasilan)
        GroupBoxPelaporan.Controls.Add(LabelPenghasilan)
        GroupBoxPelaporan.Controls.Add(TextBoxIuran) ' New
        GroupBoxPelaporan.Controls.Add(LabelIuran) ' New
        GroupBoxPelaporan.Controls.Add(TextBoxBiayaJabatan) ' New
        GroupBoxPelaporan.Controls.Add(LabelBiayaJabatan) ' New
        GroupBoxPelaporan.Controls.Add(TextBoxBruto) ' New
        GroupBoxPelaporan.Controls.Add(LabelBruto) ' New
        GroupBoxPelaporan.Controls.Add(ComboBoxStatus)
        GroupBoxPelaporan.Controls.Add(LabelStatus)
        GroupBoxPelaporan.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        GroupBoxPelaporan.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxPelaporan.Location = New Point(30, 372)
        GroupBoxPelaporan.Name = "GroupBoxPelaporan"
        GroupBoxPelaporan.Size = New Size(1500, 430) ' Expanded Height
        GroupBoxPelaporan.TabIndex = 4
        GroupBoxPelaporan.TabStop = False
        GroupBoxPelaporan.Text = "Detail Pelaporan"
        '
        ' TextBoxBruto
        '
        TextBoxBruto.BackColor = Color.White
        TextBoxBruto.BorderStyle = BorderStyle.FixedSingle
        TextBoxBruto.Font = New Font("Segoe UI", 10F)
        TextBoxBruto.Location = New Point(250, 72)
        TextBoxBruto.Name = "TextBoxBruto"
        TextBoxBruto.PlaceholderText = "0"
        TextBoxBruto.Size = New Size(1200, 43)
        TextBoxBruto.TabIndex = 2
        TextBoxBruto.TextAlign = HorizontalAlignment.Right
        '
        ' LabelBruto
        '
        LabelBruto.AutoSize = True
        LabelBruto.Font = New Font("Segoe UI", 10F)
        LabelBruto.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelBruto.Location = New Point(30, 75)
        LabelBruto.Name = "LabelBruto"
        LabelBruto.Size = New Size(210, 37)
        LabelBruto.TabIndex = 2
        LabelBruto.Text = "Penghasilan Bruto"
        '
        ' TextBoxBiayaJabatan
        '
        TextBoxBiayaJabatan.BackColor = Color.White
        TextBoxBiayaJabatan.BorderStyle = BorderStyle.FixedSingle
        TextBoxBiayaJabatan.Font = New Font("Segoe UI", 10F)
        TextBoxBiayaJabatan.Location = New Point(250, 112)
        TextBoxBiayaJabatan.Name = "TextBoxBiayaJabatan"
        TextBoxBiayaJabatan.PlaceholderText = "0"
        TextBoxBiayaJabatan.ReadOnly = True
        TextBoxBiayaJabatan.Size = New Size(1200, 43)
        TextBoxBiayaJabatan.TabIndex = 3
        TextBoxBiayaJabatan.TextAlign = HorizontalAlignment.Right
        '
        ' LabelBiayaJabatan
        '
        LabelBiayaJabatan.AutoSize = True
        LabelBiayaJabatan.Font = New Font("Segoe UI", 10F)
        LabelBiayaJabatan.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelBiayaJabatan.Location = New Point(30, 115)
        LabelBiayaJabatan.Name = "LabelBiayaJabatan"
        LabelBiayaJabatan.Size = New Size(180, 37)
        LabelBiayaJabatan.TabIndex = 3
        LabelBiayaJabatan.Text = "Biaya Jabatan"
        '
        ' TextBoxIuran
        '
        TextBoxIuran.BackColor = Color.White
        TextBoxIuran.BorderStyle = BorderStyle.FixedSingle
        TextBoxIuran.Font = New Font("Segoe UI", 10F)
        TextBoxIuran.Location = New Point(250, 152)
        TextBoxIuran.Name = "TextBoxIuran"
        TextBoxIuran.PlaceholderText = "0"
        TextBoxIuran.Size = New Size(1200, 43)
        TextBoxIuran.TabIndex = 4
        TextBoxIuran.TextAlign = HorizontalAlignment.Right
        '
        ' LabelIuran
        '
        LabelIuran.AutoSize = True
        LabelIuran.Font = New Font("Segoe UI", 10F)
        LabelIuran.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelIuran.Location = New Point(30, 155)
        LabelIuran.Name = "LabelIuran"
        LabelIuran.Size = New Size(170, 37)
        LabelIuran.TabIndex = 4
        LabelIuran.Text = "Iuran Pensiun"
        ' 
        ' DateTimePickerLapor
        ' 
        DateTimePickerLapor.Font = New Font("Segoe UI", 10F)
        DateTimePickerLapor.Format = DateTimePickerFormat.Short
        DateTimePickerLapor.Location = New Point(250, 352)
        DateTimePickerLapor.Name = "DateTimePickerLapor"
        DateTimePickerLapor.Size = New Size(250, 43)
        DateTimePickerLapor.TabIndex = 11
        ' 
        ' LabelTanggal
        ' 
        LabelTanggal.AutoSize = True
        LabelTanggal.Font = New Font("Segoe UI", 10F)
        LabelTanggal.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelTanggal.Location = New Point(30, 355)
        LabelTanggal.Name = "LabelTanggal"
        LabelTanggal.Size = New Size(236, 37)
        LabelTanggal.TabIndex = 10
        LabelTanggal.Text = "Tanggal Pelaporan"
        ' 
        ' TextBoxKredit
        ' 
        TextBoxKredit.BackColor = Color.White
        TextBoxKredit.BorderStyle = BorderStyle.FixedSingle
        TextBoxKredit.Font = New Font("Segoe UI", 10F)
        TextBoxKredit.Location = New Point(250, 312)
        TextBoxKredit.Name = "TextBoxKredit"
        TextBoxKredit.PlaceholderText = "0"
        TextBoxKredit.Size = New Size(1200, 43)
        TextBoxKredit.TabIndex = 9
        TextBoxKredit.TextAlign = HorizontalAlignment.Right
        ' 
        ' LabelKredit
        ' 
        LabelKredit.AutoSize = True
        LabelKredit.Font = New Font("Segoe UI", 10F)
        LabelKredit.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelKredit.Location = New Point(30, 315)
        LabelKredit.Name = "LabelKredit"
        LabelKredit.Size = New Size(157, 37)
        LabelKredit.TabIndex = 8
        LabelKredit.Text = "Kredit Pajak"
        ' 
        ' TextBoxPPh
        ' 
        TextBoxPPh.BackColor = Color.White
        TextBoxPPh.BorderStyle = BorderStyle.FixedSingle
        TextBoxPPh.Font = New Font("Segoe UI", 10F)
        TextBoxPPh.Location = New Point(250, 272)
        TextBoxPPh.Name = "TextBoxPPh"
        TextBoxPPh.PlaceholderText = "0"
        TextBoxPPh.Size = New Size(1200, 43)
        TextBoxPPh.TabIndex = 7
        TextBoxPPh.TextAlign = HorizontalAlignment.Right
        ' 
        ' LabelPPh
        ' 
        LabelPPh.AutoSize = True
        LabelPPh.Font = New Font("Segoe UI", 10F)
        LabelPPh.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelPPh.Location = New Point(30, 275)
        LabelPPh.Name = "LabelPPh"
        LabelPPh.Size = New Size(172, 37)
        LabelPPh.TabIndex = 6
        LabelPPh.Text = "PPh Terutang"
        ' 
        ' TextBoxPenghasilan
        ' 
        TextBoxPenghasilan.BackColor = Color.White
        TextBoxPenghasilan.BorderStyle = BorderStyle.FixedSingle
        TextBoxPenghasilan.Font = New Font("Segoe UI", 10F)
        TextBoxPenghasilan.Location = New Point(250, 192)
        TextBoxPenghasilan.Name = "TextBoxPenghasilan"
        TextBoxPenghasilan.PlaceholderText = "0"
        TextBoxPenghasilan.ReadOnly = True
        TextBoxPenghasilan.Size = New Size(1200, 43)
        TextBoxPenghasilan.TabIndex = 5
        TextBoxPenghasilan.TextAlign = HorizontalAlignment.Right
        ' 
        ' LabelPenghasilan
        ' 
        LabelPenghasilan.AutoSize = True
        LabelPenghasilan.Font = New Font("Segoe UI", 10F)
        LabelPenghasilan.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelPenghasilan.Location = New Point(30, 195)
        LabelPenghasilan.Name = "LabelPenghasilan"
        LabelPenghasilan.Size = New Size(225, 37)
        LabelPenghasilan.TabIndex = 4
        LabelPenghasilan.Text = "Penghasilan Neto"
        ' 
        ' TextBoxPKP
        ' 
        TextBoxPKP.BackColor = Color.White
        TextBoxPKP.BorderStyle = BorderStyle.FixedSingle
        TextBoxPKP.Font = New Font("Segoe UI", 10F)
        TextBoxPKP.Location = New Point(250, 232)
        TextBoxPKP.Name = "TextBoxPKP"
        TextBoxPKP.PlaceholderText = "0"
        TextBoxPKP.ReadOnly = True
        TextBoxPKP.Size = New Size(1200, 43)
        TextBoxPKP.TabIndex = 6
        TextBoxPKP.TextAlign = HorizontalAlignment.Right
        ' 
        ' LabelPKP
        ' 
        LabelPKP.AutoSize = True
        LabelPKP.Font = New Font("Segoe UI", 10F)
        LabelPKP.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelPKP.Location = New Point(30, 235)
        LabelPKP.Name = "LabelPKP"
        LabelPKP.Size = New Size(230, 37)
        LabelPKP.TabIndex = 6
        LabelPKP.Text = "PKP"
        ' 
        ' ComboBoxStatus
        ' 
        ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxStatus.Font = New Font("Segoe UI", 10F)
        ComboBoxStatus.FormattingEnabled = True
        ComboBoxStatus.Items.AddRange(New Object() {"Normal", "Pembetulan I", "Pembetulan II", "Pembetulan III"})
        ComboBoxStatus.Location = New Point(250, 32)
        ComboBoxStatus.Name = "ComboBoxStatus"
        ComboBoxStatus.Size = New Size(1200, 45)
        ComboBoxStatus.TabIndex = 1
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Font = New Font("Segoe UI", 10F)
        LabelStatus.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelStatus.Location = New Point(30, 35)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(230, 37)
        LabelStatus.TabIndex = 0
        LabelStatus.Text = "Status SPT (N/T/L)"
        ' 
        ' GroupBoxIdentitas
        ' 
        GroupBoxIdentitas.Controls.Add(NumericUpDownTahun)
        GroupBoxIdentitas.Controls.Add(LabelTahun)
        GroupBoxIdentitas.Controls.Add(ComboBoxJenisSPT)
        GroupBoxIdentitas.Controls.Add(LabelJenisSPT)
        GroupBoxIdentitas.Controls.Add(TextBoxNama)
        GroupBoxIdentitas.Controls.Add(LabelNama)
        GroupBoxIdentitas.Controls.Add(ComboBoxStatusPTKP)
        GroupBoxIdentitas.Controls.Add(LabelStatusPTKP)
        GroupBoxIdentitas.Controls.Add(TextBoxNPWP)
        GroupBoxIdentitas.Controls.Add(LabelNPWP)
        GroupBoxIdentitas.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        GroupBoxIdentitas.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxIdentitas.Location = New Point(30, 146)
        GroupBoxIdentitas.Name = "GroupBoxIdentitas"
        GroupBoxIdentitas.Size = New Size(1500, 260)
        GroupBoxIdentitas.TabIndex = 3
        GroupBoxIdentitas.TabStop = False
        GroupBoxIdentitas.Text = "Data Wajib Pajak"
        ' 
        ' NumericUpDownTahun
        ' 
        NumericUpDownTahun.Font = New Font("Segoe UI", 10F)
        NumericUpDownTahun.Location = New Point(250, 152)
        NumericUpDownTahun.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        NumericUpDownTahun.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        NumericUpDownTahun.Name = "NumericUpDownTahun"
        NumericUpDownTahun.Size = New Size(150, 43)
        NumericUpDownTahun.TabIndex = 7
        NumericUpDownTahun.Value = New Decimal(New Integer() {2024, 0, 0, 0})
        ' 
        ' LabelTahun
        ' 
        LabelTahun.AutoSize = True
        LabelTahun.Font = New Font("Segoe UI", 10F)
        LabelTahun.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelTahun.Location = New Point(30, 155)
        LabelTahun.Name = "LabelTahun"
        LabelTahun.Size = New Size(156, 37)
        LabelTahun.TabIndex = 6
        LabelTahun.Text = "Tahun Pajak"
        ' 
        ' ComboBoxJenisSPT
        ' 
        ComboBoxJenisSPT.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxJenisSPT.Font = New Font("Segoe UI", 10F)
        ComboBoxJenisSPT.FormattingEnabled = True
        ComboBoxJenisSPT.Items.AddRange(New Object() {"SPT Tahunan OP 1770", "SPT Tahunan OP 1770 S", "SPT Tahunan OP 1770 SS", "SPT Masa"})
        ComboBoxJenisSPT.Location = New Point(250, 112)
        ComboBoxJenisSPT.Name = "ComboBoxJenisSPT"
        ComboBoxJenisSPT.Size = New Size(1200, 45)
        ComboBoxJenisSPT.TabIndex = 5
        ' 
        ' LabelJenisSPT
        ' 
        LabelJenisSPT.AutoSize = True
        LabelJenisSPT.Font = New Font("Segoe UI", 10F)
        LabelJenisSPT.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelJenisSPT.Location = New Point(30, 115)
        LabelJenisSPT.Name = "LabelJenisSPT"
        LabelJenisSPT.Size = New Size(124, 37)
        LabelJenisSPT.TabIndex = 4
        LabelJenisSPT.Text = "Jenis SPT"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.BackColor = Color.White
        TextBoxNama.BorderStyle = BorderStyle.FixedSingle
        TextBoxNama.Font = New Font("Segoe UI", 10F)
        TextBoxNama.Location = New Point(250, 72)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.PlaceholderText = "Nama sesuai NPWP"
        TextBoxNama.Size = New Size(1200, 43)
        TextBoxNama.TabIndex = 3
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Font = New Font("Segoe UI", 10F)
        LabelNama.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelNama.Location = New Point(30, 75)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(232, 37)
        LabelNama.TabIndex = 2
        LabelNama.Text = "Nama Wajib Pajak"
        ' 
        ' TextBoxNPWP
        ' 
        TextBoxNPWP.BackColor = Color.White
        TextBoxNPWP.BorderStyle = BorderStyle.FixedSingle
        TextBoxNPWP.Font = New Font("Segoe UI", 10F)
        TextBoxNPWP.Location = New Point(250, 32)
        TextBoxNPWP.MaxLength = 20
        TextBoxNPWP.Name = "TextBoxNPWP"
        TextBoxNPWP.PlaceholderText = "XX.XXX.XXX.X-XXX.XXX"
        TextBoxNPWP.Size = New Size(1200, 43)
        TextBoxNPWP.TabIndex = 1
        ' 
        ' ComboBoxStatusPTKP
        ' 
        ComboBoxStatusPTKP.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxStatusPTKP.FlatStyle = FlatStyle.Flat
        ComboBoxStatusPTKP.Font = New Font("Segoe UI", 10F)
        ComboBoxStatusPTKP.FormattingEnabled = True
        ComboBoxStatusPTKP.Items.AddRange(New Object() {"TK/0 - Tidak Kawin tanpa tanggungan", "TK/1 - Tidak Kawin 1 tanggungan", "TK/2 - Tidak Kawin 2 tanggungan", "TK/3 - Tidak Kawin 3 tanggungan", "K/0 - Kawin tanpa tanggungan", "K/1 - Kawin 1 tanggungan", "K/2 - Kawin 2 tanggungan", "K/3 - Kawin 3 tanggungan"})
        ComboBoxStatusPTKP.Location = New Point(250, 192)
        ComboBoxStatusPTKP.Name = "ComboBoxStatusPTKP"
        ComboBoxStatusPTKP.Size = New Size(1200, 43)
        ComboBoxStatusPTKP.TabIndex = 8
        ' 
        ' LabelStatusPTKP
        ' 
        LabelStatusPTKP.AutoSize = True
        LabelStatusPTKP.Font = New Font("Segoe UI", 10F)
        LabelStatusPTKP.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelStatusPTKP.Location = New Point(30, 195)
        LabelStatusPTKP.Name = "LabelStatusPTKP"
        LabelStatusPTKP.Size = New Size(92, 37)
        LabelStatusPTKP.TabIndex = 9
        LabelStatusPTKP.Text = "Status PTKP"
        ' 
        ' LabelNPWP
        ' 
        LabelNPWP.AutoSize = True
        LabelNPWP.Font = New Font("Segoe UI", 10F)
        LabelNPWP.ForeColor = Color.FromArgb(CByte(74), CByte(79), CByte(86))
        LabelNPWP.Location = New Point(30, 35)
        LabelNPWP.Name = "LabelNPWP"
        LabelNPWP.Size = New Size(92, 37)
        LabelNPWP.TabIndex = 0
        LabelNPWP.Text = "NPWP"
        ' 
        ' ButtonUnggahDokumen
        ' 
        ButtonUnggahDokumen.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        ButtonUnggahDokumen.Cursor = Cursors.Hand
        ButtonUnggahDokumen.FlatAppearance.BorderSize = 0
        ButtonUnggahDokumen.FlatStyle = FlatStyle.Flat
        ButtonUnggahDokumen.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonUnggahDokumen.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        ButtonUnggahDokumen.Location = New Point(1195, 33)
        ButtonUnggahDokumen.Name = "ButtonUnggahDokumen"
        ButtonUnggahDokumen.Size = New Size(200, 47)
        ButtonUnggahDokumen.TabIndex = 2
        ButtonUnggahDokumen.Text = "📄 Unggah Dokumen"
        ButtonUnggahDokumen.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F)
        Label2.ForeColor = Color.FromArgb(CByte(134), CByte(142), CByte(150))
        Label2.Location = New Point(1140, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(668, 32)
        Label2.TabIndex = 5
        Label2.Text = "💡 Unggah Bukti Potong Tahun Pajak Sebelumnya (Opsional)"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F)
        Label1.ForeColor = Color.FromArgb(CByte(134), CByte(142), CByte(150))
        Label1.Location = New Point(30, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(1043, 32)
        Label1.TabIndex = 1
        Label1.Text = "Lengkapi identitas wajib pajak dan data pelaporan SPT sebelum menyimpan atau mencetak draf."
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelTitle.Location = New Point(33, 21)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(456, 86)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Pengisian SPT"
        ' 
        ' PanelButtons
        ' 
        PanelButtons.Anchor = AnchorStyles.Bottom
        PanelButtons.BackColor = Color.Transparent
        PanelButtons.Controls.Add(ButtonPreview)
        PanelButtons.Controls.Add(ButtonSimpan)
        PanelButtons.Controls.Add(ButtonKeSumulasi)
        PanelButtons.Controls.Add(ButtonExportPDF)
        PanelButtons.Controls.Add(ButtonBatal)
        PanelButtons.Location = New Point(320, 800)
        PanelButtons.Name = "PanelButtons"
        PanelButtons.Size = New Size(950, 60)
        PanelButtons.TabIndex = 1
        ' 
        ' ButtonPreview
        ' 
        ButtonPreview.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        ButtonPreview.Cursor = Cursors.Hand
        ButtonPreview.FlatAppearance.BorderSize = 0
        ButtonPreview.FlatStyle = FlatStyle.Flat
        ButtonPreview.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        ButtonPreview.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        ButtonPreview.Location = New Point(5, 5)
        ButtonPreview.Margin = New Padding(5)
        ButtonPreview.Name = "ButtonPreview"
        ButtonPreview.Size = New Size(180, 45)
        ButtonPreview.TabIndex = 0
        ButtonPreview.Text = "👁 Pratinjau"
        ButtonPreview.UseVisualStyleBackColor = False
        ' 
        ' ButtonSimpan
        ' 
        ButtonSimpan.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        ButtonSimpan.Cursor = Cursors.Hand
        ButtonSimpan.FlatAppearance.BorderSize = 0
        ButtonSimpan.FlatStyle = FlatStyle.Flat
        ButtonSimpan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        ButtonSimpan.ForeColor = Color.White
        ButtonSimpan.Location = New Point(195, 5)
        ButtonSimpan.Margin = New Padding(5)
        ButtonSimpan.Name = "ButtonSimpan"
        ButtonSimpan.Size = New Size(180, 45)
        ButtonSimpan.TabIndex = 1
        ButtonSimpan.Text = "💾 Simpan"
        ButtonSimpan.UseVisualStyleBackColor = False
        ' 
        ' ButtonKeSumulasi
        ' 
        ButtonKeSumulasi.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        ButtonKeSumulasi.Cursor = Cursors.Hand
        ButtonKeSumulasi.FlatAppearance.BorderSize = 0
        ButtonKeSumulasi.FlatStyle = FlatStyle.Flat
        ButtonKeSumulasi.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        ButtonKeSumulasi.ForeColor = Color.White
        ButtonKeSumulasi.Location = New Point(385, 5)
        ButtonKeSumulasi.Margin = New Padding(5)
        ButtonKeSumulasi.Name = "ButtonKeSumulasi"
        ButtonKeSumulasi.Size = New Size(180, 45)
        ButtonKeSumulasi.TabIndex = 2
        ButtonKeSumulasi.Text = ChrW(55358) & ChrW(56814) & " Lihat Simulasi"
        ButtonKeSumulasi.UseVisualStyleBackColor = False
        ' 
        ' ButtonExportPDF
        ' 
        ButtonExportPDF.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        ButtonExportPDF.Cursor = Cursors.Hand
        ButtonExportPDF.FlatAppearance.BorderSize = 0
        ButtonExportPDF.FlatStyle = FlatStyle.Flat
        ButtonExportPDF.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        ButtonExportPDF.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        ButtonExportPDF.Location = New Point(575, 5)
        ButtonExportPDF.Margin = New Padding(5)
        ButtonExportPDF.Name = "ButtonExportPDF"
        ButtonExportPDF.Size = New Size(180, 45)
        ButtonExportPDF.TabIndex = 3
        ButtonExportPDF.Text = "📄 Export PDF"
        ButtonExportPDF.UseVisualStyleBackColor = False
        ' 
        ' ButtonBatal
        ' 
        ButtonBatal.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        ButtonBatal.Cursor = Cursors.Hand
        ButtonBatal.FlatAppearance.BorderSize = 0
        ButtonBatal.FlatStyle = FlatStyle.Flat
        ButtonBatal.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        ButtonBatal.ForeColor = Color.White
        ButtonBatal.Location = New Point(765, 5)
        ButtonBatal.Margin = New Padding(5)
        ButtonBatal.Name = "ButtonBatal"
        ButtonBatal.Size = New Size(180, 45)
        ButtonBatal.TabIndex = 4
        ButtonBatal.Text = "❌ Batal"
        ButtonBatal.UseVisualStyleBackColor = False
        ' 
        ' Pengisian_SPT
        ' 
        AcceptButton = ButtonSimpan
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        ClientSize = New Size(1600, 900)
        Controls.Add(PanelButtons)
        Controls.Add(PanelWrapper)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MinimumSize = New Size(1600, 900)
        Name = "Pengisian_SPT"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TaxEase | Pengisian SPT"
        WindowState = FormWindowState.Maximized
        PanelWrapper.ResumeLayout(False)
        PanelWrapper.PerformLayout()
        GroupBoxPelaporan.ResumeLayout(False)
        GroupBoxPelaporan.PerformLayout()
        GroupBoxIdentitas.ResumeLayout(False)
        GroupBoxIdentitas.PerformLayout()
        CType(NumericUpDownTahun, ComponentModel.ISupportInitialize).EndInit()
        PanelButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonUnggahDokumen As Button
    Friend WithEvents GroupBoxIdentitas As GroupBox
    Friend WithEvents LabelNPWP As Label
    Friend WithEvents TextBoxNPWP As TextBox
    Friend WithEvents LabelNama As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents LabelJenisSPT As Label
    Friend WithEvents ComboBoxJenisSPT As ComboBox
    Friend WithEvents LabelTahun As Label
    Friend WithEvents NumericUpDownTahun As NumericUpDown
    Friend WithEvents GroupBoxPelaporan As GroupBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents LabelStatusPTKP As Label
    Friend WithEvents ComboBoxStatusPTKP As ComboBox
    Friend WithEvents LabelPenghasilan As Label
    Friend WithEvents TextBoxPenghasilan As TextBox
    Friend WithEvents LabelPPh As Label
    Friend WithEvents TextBoxPPh As TextBox
    Friend WithEvents LabelKredit As Label
    Friend WithEvents TextBoxKredit As TextBox
    Friend WithEvents LabelPKP As Label
    Friend WithEvents TextBoxPKP As TextBox
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents DateTimePickerLapor As DateTimePicker
    Friend WithEvents PanelButtons As FlowLayoutPanel
    Friend WithEvents ButtonPreview As Button
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents ButtonKeSumulasi As Button
    Friend WithEvents ButtonExportPDF As Button
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    ' New Controls
    Friend WithEvents TextBoxBruto As TextBox
    Friend WithEvents LabelBruto As Label
    Friend WithEvents TextBoxBiayaJabatan As TextBox
    Friend WithEvents LabelBiayaJabatan As Label
    Friend WithEvents TextBoxIuran As TextBox
    Friend WithEvents LabelIuran As Label
End Class
