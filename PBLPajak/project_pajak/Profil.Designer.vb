<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profil
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
        LabelPageSubtitle = New Label()
        LabelPageTitle = New Label()
        PanelContent = New Panel()
        MainTableLayout = New TableLayoutPanel()
        GroupBoxDataPribadi = New GroupBox()
        TableLayoutPribadi = New TableLayoutPanel()
        LabelNIK = New Label()
        LabelNama = New Label()
        txtNIK = New TextBox()
        txtNama = New TextBox()
        LabelEmail = New Label()
        LabelNoHP = New Label()
        txtEmail = New TextBox()
        txtNoHP = New TextBox()
        LabelTempatLahir = New Label()
        LabelTanggalLahir = New Label()
        txtTempatLahir = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        LabelJenisKelamin = New Label()
        LabelStatusPernikahan = New Label()
        cmbJenisKelamin = New ComboBox()
        cmbStatusPernikahan = New ComboBox()
        LabelTanggalTerdaftar = New Label()
        LabelStatusPTKP = New Label()
        dtpTanggalTerdaftar = New DateTimePicker()
        cmbStatusPTKP = New ComboBox()
        LabelStatusPekerjaan = New Label()
        LabelNamaTempatKerja = New Label()
        cmbStatusPekerjaan = New ComboBox()
        txtNamaTempatKerja = New TextBox()
        LabelJabatan = New Label()
        txtJabatan = New TextBox()
        LabelAlamat = New Label()
        txtAlamat = New TextBox()
        LabelJenisWajibPajak = New Label()
        cmbJenisWajibPajak = New ComboBox()
        GroupBoxKeluarga = New GroupBox()
        PanelKeluargaContent = New Panel()
        DataGridViewKeluarga = New DataGridView()
        ColNamaAnggota = New DataGridViewTextBoxColumn()
        ColNIKAnggota = New DataGridViewTextBoxColumn()
        ColStatusHubungan = New DataGridViewComboBoxColumn()
        ColPekerjaan = New DataGridViewTextBoxColumn()
        ColTanggalLahir = New DataGridViewTextBoxColumn()
        PanelButtonKeluarga = New Panel()
        ButtonTambahKeluarga = New Button()
        ButtonEditKeluarga = New Button()
        ButtonHapusKeluarga = New Button()
        PanelFooter = New Panel()
        ButtonKembali = New Button()
        ButtonBatal = New Button()
        ButtonSimpan = New Button()
        PanelHeader.SuspendLayout()
        PanelContent.SuspendLayout()
        MainTableLayout.SuspendLayout()
        GroupBoxDataPribadi.SuspendLayout()
        TableLayoutPribadi.SuspendLayout()
        GroupBoxKeluarga.SuspendLayout()
        PanelKeluargaContent.SuspendLayout()
        CType(DataGridViewKeluarga, ComponentModel.ISupportInitialize).BeginInit()
        PanelButtonKeluarga.SuspendLayout()
        PanelFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        PanelHeader.Controls.Add(LabelPageSubtitle)
        PanelHeader.Controls.Add(LabelPageTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Padding = New Padding(40)
        PanelHeader.Size = New Size(2275, 150)
        PanelHeader.TabIndex = 2
        ' 
        ' LabelPageSubtitle
        ' 
        LabelPageSubtitle.AutoSize = True
        LabelPageSubtitle.Font = New Font("Segoe UI", 11F)
        LabelPageSubtitle.ForeColor = Color.FromArgb(CByte(214), CByte(230), CByte(255))
        LabelPageSubtitle.Location = New Point(40, 80)
        LabelPageSubtitle.Name = "LabelPageSubtitle"
        LabelPageSubtitle.Size = New Size(660, 41)
        LabelPageSubtitle.TabIndex = 0
        LabelPageSubtitle.Text = "Kelola informasi profil dan data perpajakan Anda"
        ' 
        ' LabelPageTitle
        ' 
        LabelPageTitle.AutoSize = True
        LabelPageTitle.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        LabelPageTitle.ForeColor = Color.White
        LabelPageTitle.Location = New Point(35, 20)
        LabelPageTitle.Name = "LabelPageTitle"
        LabelPageTitle.Size = New Size(664, 100)
        LabelPageTitle.TabIndex = 1
        LabelPageTitle.Text = "Profil Wajib Pajak"
        ' 
        ' PanelContent
        ' 
        PanelContent.AutoScroll = True
        PanelContent.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelContent.Controls.Add(MainTableLayout)
        PanelContent.Dock = DockStyle.Fill
        PanelContent.Location = New Point(0, 150)
        PanelContent.Name = "PanelContent"
        PanelContent.Padding = New Padding(40)
        PanelContent.Size = New Size(2275, 1130)
        PanelContent.TabIndex = 0
        ' 
        ' MainTableLayout
        ' 
        MainTableLayout.AutoSize = True
        MainTableLayout.ColumnCount = 1
        MainTableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        MainTableLayout.Controls.Add(GroupBoxDataPribadi, 0, 0)
        MainTableLayout.Controls.Add(GroupBoxKeluarga, 0, 1)
        MainTableLayout.Dock = DockStyle.Top
        MainTableLayout.Location = New Point(40, 40)
        MainTableLayout.Name = "MainTableLayout"
        MainTableLayout.RowCount = 2
        MainTableLayout.RowStyles.Add(New RowStyle())
        MainTableLayout.RowStyles.Add(New RowStyle())
        MainTableLayout.Size = New Size(2161, 1557)
        MainTableLayout.TabIndex = 0
        ' 
        ' GroupBoxDataPribadi
        ' 
        GroupBoxDataPribadi.AutoSize = True
        GroupBoxDataPribadi.BackColor = Color.White
        GroupBoxDataPribadi.Controls.Add(TableLayoutPribadi)
        GroupBoxDataPribadi.Dock = DockStyle.Top
        GroupBoxDataPribadi.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBoxDataPribadi.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxDataPribadi.Location = New Point(0, 0)
        GroupBoxDataPribadi.Margin = New Padding(0, 0, 0, 30)
        GroupBoxDataPribadi.Name = "GroupBoxDataPribadi"
        GroupBoxDataPribadi.Padding = New Padding(20)
        GroupBoxDataPribadi.Size = New Size(2161, 1021)
        GroupBoxDataPribadi.TabIndex = 0
        GroupBoxDataPribadi.TabStop = False
        GroupBoxDataPribadi.Text = "1. Data Pribadi & Perpajakan"
        ' 
        ' TableLayoutPribadi
        ' 
        TableLayoutPribadi.AutoSize = True
        TableLayoutPribadi.ColumnCount = 2
        TableLayoutPribadi.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPribadi.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPribadi.Controls.Add(LabelNIK, 0, 0)
        TableLayoutPribadi.Controls.Add(LabelNama, 1, 0)
        TableLayoutPribadi.Controls.Add(txtNIK, 0, 1)
        TableLayoutPribadi.Controls.Add(txtNama, 1, 1)
        TableLayoutPribadi.Controls.Add(LabelEmail, 0, 2)
        TableLayoutPribadi.Controls.Add(LabelNoHP, 1, 2)
        TableLayoutPribadi.Controls.Add(txtEmail, 0, 3)
        TableLayoutPribadi.Controls.Add(txtNoHP, 1, 3)
        TableLayoutPribadi.Controls.Add(LabelTempatLahir, 0, 4)
        TableLayoutPribadi.Controls.Add(LabelTanggalLahir, 1, 4)
        TableLayoutPribadi.Controls.Add(txtTempatLahir, 0, 5)
        TableLayoutPribadi.Controls.Add(dtpTanggalLahir, 1, 5)
        TableLayoutPribadi.Controls.Add(LabelJenisKelamin, 0, 6)
        TableLayoutPribadi.Controls.Add(LabelStatusPernikahan, 1, 6)
        TableLayoutPribadi.Controls.Add(cmbJenisKelamin, 0, 7)
        TableLayoutPribadi.Controls.Add(cmbStatusPernikahan, 1, 7)
        TableLayoutPribadi.Controls.Add(LabelTanggalTerdaftar, 0, 8)
        TableLayoutPribadi.Controls.Add(LabelStatusPTKP, 1, 8)
        TableLayoutPribadi.Controls.Add(dtpTanggalTerdaftar, 0, 9)
        TableLayoutPribadi.Controls.Add(cmbStatusPTKP, 1, 9)
        TableLayoutPribadi.Controls.Add(LabelStatusPekerjaan, 0, 10)
        TableLayoutPribadi.Controls.Add(LabelNamaTempatKerja, 1, 10)
        TableLayoutPribadi.Controls.Add(cmbStatusPekerjaan, 0, 11)
        TableLayoutPribadi.Controls.Add(txtNamaTempatKerja, 1, 11)
        TableLayoutPribadi.Controls.Add(LabelJabatan, 0, 12)
        TableLayoutPribadi.Controls.Add(txtJabatan, 0, 13)
        TableLayoutPribadi.Controls.Add(LabelAlamat, 1, 12)
        TableLayoutPribadi.Controls.Add(txtAlamat, 1, 13)
        TableLayoutPribadi.Controls.Add(LabelJenisWajibPajak, 0, 14)
        TableLayoutPribadi.Controls.Add(cmbJenisWajibPajak, 0, 15)
        TableLayoutPribadi.Dock = DockStyle.Top
        TableLayoutPribadi.Location = New Point(20, 63)
        TableLayoutPribadi.Name = "TableLayoutPribadi"
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.RowStyles.Add(New RowStyle())
        TableLayoutPribadi.Size = New Size(2121, 938)
        TableLayoutPribadi.TabIndex = 0
        ' 
        ' LabelNIK
        ' 
        LabelNIK.AutoSize = True
        LabelNIK.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelNIK.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelNIK.Location = New Point(3, 15)
        LabelNIK.Margin = New Padding(3, 15, 3, 5)
        LabelNIK.Name = "LabelNIK"
        LabelNIK.Size = New Size(444, 37)
        LabelNIK.TabIndex = 0
        LabelNIK.Text = "NIK (Nomor Induk Kependudukan)"
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelNama.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelNama.Location = New Point(1063, 15)
        LabelNama.Margin = New Padding(3, 15, 3, 5)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(200, 37)
        LabelNama.TabIndex = 1
        LabelNama.Text = "Nama Lengkap"
        ' 
        ' txtNIK
        ' 
        txtNIK.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        txtNIK.BorderStyle = BorderStyle.FixedSingle
        txtNIK.Dock = DockStyle.Top
        txtNIK.Font = New Font("Segoe UI", 11F)
        txtNIK.Location = New Point(3, 60)
        txtNIK.Margin = New Padding(3, 3, 30, 3)
        txtNIK.Name = "txtNIK"
        txtNIK.ReadOnly = True
        txtNIK.Size = New Size(1027, 47)
        txtNIK.TabIndex = 2
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.White
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Dock = DockStyle.Top
        txtNama.Font = New Font("Segoe UI", 11F)
        txtNama.Location = New Point(1063, 60)
        txtNama.Margin = New Padding(3, 3, 30, 3)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(1028, 47)
        txtNama.TabIndex = 3
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelEmail.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelEmail.Location = New Point(3, 125)
        LabelEmail.Margin = New Padding(3, 15, 3, 5)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(177, 37)
        LabelEmail.TabIndex = 4
        LabelEmail.Text = "Alamat Email"
        ' 
        ' LabelNoHP
        ' 
        LabelNoHP.AutoSize = True
        LabelNoHP.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelNoHP.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelNoHP.Location = New Point(1063, 125)
        LabelNoHP.Margin = New Padding(3, 15, 3, 5)
        LabelNoHP.Name = "LabelNoHP"
        LabelNoHP.Size = New Size(316, 37)
        LabelNoHP.TabIndex = 5
        LabelNoHP.Text = "Nomor Handphone (HP)"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Dock = DockStyle.Top
        txtEmail.Font = New Font("Segoe UI", 11F)
        txtEmail.Location = New Point(3, 170)
        txtEmail.Margin = New Padding(3, 3, 30, 3)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(1027, 47)
        txtEmail.TabIndex = 6
        ' 
        ' txtNoHP
        ' 
        txtNoHP.BackColor = Color.White
        txtNoHP.BorderStyle = BorderStyle.FixedSingle
        txtNoHP.Dock = DockStyle.Top
        txtNoHP.Font = New Font("Segoe UI", 11F)
        txtNoHP.Location = New Point(1063, 170)
        txtNoHP.Margin = New Padding(3, 3, 30, 3)
        txtNoHP.Name = "txtNoHP"
        txtNoHP.Size = New Size(1028, 47)
        txtNoHP.TabIndex = 7
        ' 
        ' LabelTempatLahir
        ' 
        LabelTempatLahir.AutoSize = True
        LabelTempatLahir.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelTempatLahir.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelTempatLahir.Location = New Point(3, 235)
        LabelTempatLahir.Margin = New Padding(3, 15, 3, 5)
        LabelTempatLahir.Name = "LabelTempatLahir"
        LabelTempatLahir.Size = New Size(174, 37)
        LabelTempatLahir.TabIndex = 8
        LabelTempatLahir.Text = "Tempat Lahir"
        ' 
        ' LabelTanggalLahir
        ' 
        LabelTanggalLahir.AutoSize = True
        LabelTanggalLahir.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelTanggalLahir.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelTanggalLahir.Location = New Point(1063, 235)
        LabelTanggalLahir.Margin = New Padding(3, 15, 3, 5)
        LabelTanggalLahir.Name = "LabelTanggalLahir"
        LabelTanggalLahir.Size = New Size(179, 37)
        LabelTanggalLahir.TabIndex = 9
        LabelTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' txtTempatLahir
        ' 
        txtTempatLahir.BackColor = Color.White
        txtTempatLahir.BorderStyle = BorderStyle.FixedSingle
        txtTempatLahir.Dock = DockStyle.Top
        txtTempatLahir.Font = New Font("Segoe UI", 11F)
        txtTempatLahir.Location = New Point(3, 280)
        txtTempatLahir.Margin = New Padding(3, 3, 30, 3)
        txtTempatLahir.Name = "txtTempatLahir"
        txtTempatLahir.Size = New Size(1027, 47)
        txtTempatLahir.TabIndex = 10
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Dock = DockStyle.Top
        dtpTanggalLahir.Font = New Font("Segoe UI", 11F)
        dtpTanggalLahir.Format = DateTimePickerFormat.Short
        dtpTanggalLahir.Location = New Point(1063, 280)
        dtpTanggalLahir.Margin = New Padding(3, 3, 30, 3)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(1028, 47)
        dtpTanggalLahir.TabIndex = 11
        ' 
        ' LabelJenisKelamin
        ' 
        LabelJenisKelamin.AutoSize = True
        LabelJenisKelamin.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelJenisKelamin.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelJenisKelamin.Location = New Point(3, 345)
        LabelJenisKelamin.Margin = New Padding(3, 15, 3, 5)
        LabelJenisKelamin.Name = "LabelJenisKelamin"
        LabelJenisKelamin.Size = New Size(183, 37)
        LabelJenisKelamin.TabIndex = 12
        LabelJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' LabelStatusPernikahan
        ' 
        LabelStatusPernikahan.AutoSize = True
        LabelStatusPernikahan.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelStatusPernikahan.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelStatusPernikahan.Location = New Point(1063, 345)
        LabelStatusPernikahan.Margin = New Padding(3, 15, 3, 5)
        LabelStatusPernikahan.Name = "LabelStatusPernikahan"
        LabelStatusPernikahan.Size = New Size(236, 37)
        LabelStatusPernikahan.TabIndex = 13
        LabelStatusPernikahan.Text = "Status Pernikahan"
        ' 
        ' cmbJenisKelamin
        ' 
        cmbJenisKelamin.BackColor = Color.White
        cmbJenisKelamin.Dock = DockStyle.Top
        cmbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJenisKelamin.FlatStyle = FlatStyle.System
        cmbJenisKelamin.Font = New Font("Segoe UI", 11F)
        cmbJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        cmbJenisKelamin.Location = New Point(3, 390)
        cmbJenisKelamin.Margin = New Padding(3, 3, 30, 3)
        cmbJenisKelamin.Name = "cmbJenisKelamin"
        cmbJenisKelamin.Size = New Size(1027, 48)
        cmbJenisKelamin.TabIndex = 14
        ' 
        ' cmbStatusPernikahan
        ' 
        cmbStatusPernikahan.BackColor = Color.White
        cmbStatusPernikahan.Dock = DockStyle.Top
        cmbStatusPernikahan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatusPernikahan.FlatStyle = FlatStyle.System
        cmbStatusPernikahan.Font = New Font("Segoe UI", 11F)
        cmbStatusPernikahan.Items.AddRange(New Object() {"Belum Menikah", "Menikah", "Cerai Hidup", "Cerai Mati"})
        cmbStatusPernikahan.Location = New Point(1063, 390)
        cmbStatusPernikahan.Margin = New Padding(3, 3, 30, 3)
        cmbStatusPernikahan.Name = "cmbStatusPernikahan"
        cmbStatusPernikahan.Size = New Size(1028, 48)
        cmbStatusPernikahan.TabIndex = 15
        ' 
        ' LabelTanggalTerdaftar
        ' 
        LabelTanggalTerdaftar.AutoSize = True
        LabelTanggalTerdaftar.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelTanggalTerdaftar.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelTanggalTerdaftar.Location = New Point(3, 456)
        LabelTanggalTerdaftar.Margin = New Padding(3, 15, 3, 5)
        LabelTanggalTerdaftar.Name = "LabelTanggalTerdaftar"
        LabelTanggalTerdaftar.Size = New Size(229, 37)
        LabelTanggalTerdaftar.TabIndex = 16
        LabelTanggalTerdaftar.Text = "Tanggal Terdaftar"
        ' 
        ' LabelStatusPTKP
        ' 
        LabelStatusPTKP.AutoSize = True
        LabelStatusPTKP.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelStatusPTKP.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelStatusPTKP.Location = New Point(1063, 456)
        LabelStatusPTKP.Margin = New Padding(3, 15, 3, 5)
        LabelStatusPTKP.Name = "LabelStatusPTKP"
        LabelStatusPTKP.Size = New Size(164, 37)
        LabelStatusPTKP.TabIndex = 17
        LabelStatusPTKP.Text = "Status PTKP"
        ' 
        ' dtpTanggalTerdaftar
        ' 
        dtpTanggalTerdaftar.Dock = DockStyle.Top
        dtpTanggalTerdaftar.Enabled = False
        dtpTanggalTerdaftar.Font = New Font("Segoe UI", 11F)
        dtpTanggalTerdaftar.Format = DateTimePickerFormat.Short
        dtpTanggalTerdaftar.Location = New Point(3, 501)
        dtpTanggalTerdaftar.Margin = New Padding(3, 3, 30, 3)
        dtpTanggalTerdaftar.Name = "dtpTanggalTerdaftar"
        dtpTanggalTerdaftar.Size = New Size(1027, 47)
        dtpTanggalTerdaftar.TabIndex = 18
        ' 
        ' cmbStatusPTKP
        ' 
        cmbStatusPTKP.BackColor = Color.White
        cmbStatusPTKP.Dock = DockStyle.Top
        cmbStatusPTKP.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatusPTKP.FlatStyle = FlatStyle.System
        cmbStatusPTKP.Font = New Font("Segoe UI", 11F)
        cmbStatusPTKP.Items.AddRange(New Object() {"TK/0 - Tidak Kawin tanpa tanggungan", "TK/1 - Tidak Kawin 1 tanggungan", "TK/2 - Tidak Kawin 2 tanggungan", "TK/3 - Tidak Kawin 3 tanggungan", "K/0 - Kawin tanpa tanggungan", "K/1 - Kawin 1 tanggungan", "K/2 - Kawin 2 tanggungan", "K/3 - Kawin 3 tanggungan"})
        cmbStatusPTKP.Location = New Point(1063, 501)
        cmbStatusPTKP.Margin = New Padding(3, 3, 30, 3)
        cmbStatusPTKP.Name = "cmbStatusPTKP"
        cmbStatusPTKP.Size = New Size(1028, 48)
        cmbStatusPTKP.TabIndex = 19
        ' 
        ' LabelStatusPekerjaan
        ' 
        LabelStatusPekerjaan.AutoSize = True
        LabelStatusPekerjaan.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelStatusPekerjaan.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelStatusPekerjaan.Location = New Point(3, 567)
        LabelStatusPekerjaan.Margin = New Padding(3, 15, 3, 5)
        LabelStatusPekerjaan.Name = "LabelStatusPekerjaan"
        LabelStatusPekerjaan.Size = New Size(218, 37)
        LabelStatusPekerjaan.TabIndex = 20
        LabelStatusPekerjaan.Text = "Status Pekerjaan"
        ' 
        ' LabelNamaTempatKerja
        ' 
        LabelNamaTempatKerja.AutoSize = True
        LabelNamaTempatKerja.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelNamaTempatKerja.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelNamaTempatKerja.Location = New Point(1063, 567)
        LabelNamaTempatKerja.Margin = New Padding(3, 15, 3, 5)
        LabelNamaTempatKerja.Name = "LabelNamaTempatKerja"
        LabelNamaTempatKerja.Size = New Size(256, 37)
        LabelNamaTempatKerja.TabIndex = 21
        LabelNamaTempatKerja.Text = "Nama Tempat Kerja"
        ' 
        ' cmbStatusPekerjaan
        ' 
        cmbStatusPekerjaan.BackColor = Color.White
        cmbStatusPekerjaan.Dock = DockStyle.Top
        cmbStatusPekerjaan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatusPekerjaan.FlatStyle = FlatStyle.System
        cmbStatusPekerjaan.Font = New Font("Segoe UI", 11F)
        cmbStatusPekerjaan.Items.AddRange(New Object() {"Pegawai Tetap", "Pegawai Tidak Tetap", "Pensiunan", "Wiraswasta", "Profesional", "Lainnya"})
        cmbStatusPekerjaan.Location = New Point(3, 612)
        cmbStatusPekerjaan.Margin = New Padding(3, 3, 30, 3)
        cmbStatusPekerjaan.Name = "cmbStatusPekerjaan"
        cmbStatusPekerjaan.Size = New Size(1027, 48)
        cmbStatusPekerjaan.TabIndex = 22
        ' 
        ' txtNamaTempatKerja
        ' 
        txtNamaTempatKerja.BackColor = Color.White
        txtNamaTempatKerja.BorderStyle = BorderStyle.FixedSingle
        txtNamaTempatKerja.Dock = DockStyle.Top
        txtNamaTempatKerja.Font = New Font("Segoe UI", 11F)
        txtNamaTempatKerja.Location = New Point(1063, 612)
        txtNamaTempatKerja.Margin = New Padding(3, 3, 30, 3)
        txtNamaTempatKerja.Name = "txtNamaTempatKerja"
        txtNamaTempatKerja.Size = New Size(1028, 47)
        txtNamaTempatKerja.TabIndex = 23
        ' 
        ' LabelJabatan
        ' 
        LabelJabatan.AutoSize = True
        LabelJabatan.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelJabatan.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelJabatan.Location = New Point(3, 678)
        LabelJabatan.Margin = New Padding(3, 15, 3, 5)
        LabelJabatan.Name = "LabelJabatan"
        LabelJabatan.Size = New Size(112, 37)
        LabelJabatan.TabIndex = 24
        LabelJabatan.Text = "Jabatan"
        ' 
        ' txtJabatan
        ' 
        txtJabatan.BackColor = Color.White
        txtJabatan.BorderStyle = BorderStyle.FixedSingle
        txtJabatan.Dock = DockStyle.Top
        txtJabatan.Font = New Font("Segoe UI", 11F)
        txtJabatan.Location = New Point(3, 723)
        txtJabatan.Margin = New Padding(3, 3, 30, 3)
        txtJabatan.Name = "txtJabatan"
        txtJabatan.Size = New Size(1027, 47)
        txtJabatan.TabIndex = 25
        ' 
        ' LabelAlamat
        ' 
        LabelAlamat.AutoSize = True
        LabelAlamat.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelAlamat.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelAlamat.Location = New Point(1063, 678)
        LabelAlamat.Margin = New Padding(3, 15, 3, 5)
        LabelAlamat.Name = "LabelAlamat"
        LabelAlamat.Size = New Size(214, 37)
        LabelAlamat.TabIndex = 28
        LabelAlamat.Text = "Alamat Lengkap"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.White
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.Dock = DockStyle.Top
        txtAlamat.Font = New Font("Segoe UI", 11F)
        txtAlamat.Location = New Point(1063, 723)
        txtAlamat.Margin = New Padding(3, 3, 30, 3)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(1028, 100)
        txtAlamat.TabIndex = 29
        ' 
        ' LabelJenisWajibPajak
        ' 
        LabelJenisWajibPajak.AutoSize = True
        LabelJenisWajibPajak.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LabelJenisWajibPajak.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        LabelJenisWajibPajak.Location = New Point(3, 841)
        LabelJenisWajibPajak.Margin = New Padding(3, 15, 3, 5)
        LabelJenisWajibPajak.Name = "LabelJenisWajibPajak"
        LabelJenisWajibPajak.Size = New Size(224, 37)
        LabelJenisWajibPajak.TabIndex = 26
        LabelJenisWajibPajak.Text = "Jenis Wajib Pajak"
        LabelJenisWajibPajak.Visible = False
        ' 
        ' cmbJenisWajibPajak
        ' 
        cmbJenisWajibPajak.Dock = DockStyle.Top
        cmbJenisWajibPajak.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJenisWajibPajak.FlatStyle = FlatStyle.System
        cmbJenisWajibPajak.Font = New Font("Segoe UI", 11F)
        cmbJenisWajibPajak.Location = New Point(3, 886)
        cmbJenisWajibPajak.Margin = New Padding(3, 3, 30, 3)
        cmbJenisWajibPajak.Name = "cmbJenisWajibPajak"
        cmbJenisWajibPajak.Size = New Size(1027, 48)
        cmbJenisWajibPajak.TabIndex = 27
        cmbJenisWajibPajak.Visible = False
        ' 
        ' GroupBoxKeluarga
        ' 
        GroupBoxKeluarga.BackColor = Color.White
        GroupBoxKeluarga.Controls.Add(PanelKeluargaContent)
        GroupBoxKeluarga.Controls.Add(PanelButtonKeluarga)
        GroupBoxKeluarga.Dock = DockStyle.Top
        GroupBoxKeluarga.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBoxKeluarga.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxKeluarga.Location = New Point(3, 1054)
        GroupBoxKeluarga.Name = "GroupBoxKeluarga"
        GroupBoxKeluarga.Padding = New Padding(20)
        GroupBoxKeluarga.Size = New Size(2155, 500)
        GroupBoxKeluarga.TabIndex = 1
        GroupBoxKeluarga.TabStop = False
        GroupBoxKeluarga.Text = "2. Data Unit Keluarga"
        ' 
        ' PanelKeluargaContent
        ' 
        PanelKeluargaContent.Controls.Add(DataGridViewKeluarga)
        PanelKeluargaContent.Dock = DockStyle.Fill
        PanelKeluargaContent.Location = New Point(20, 123)
        PanelKeluargaContent.Name = "PanelKeluargaContent"
        PanelKeluargaContent.Padding = New Padding(0, 10, 0, 0)
        PanelKeluargaContent.Size = New Size(2115, 357)
        PanelKeluargaContent.TabIndex = 0
        ' 
        ' DataGridViewKeluarga
        ' 
        DataGridViewKeluarga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewKeluarga.BackgroundColor = Color.White
        DataGridViewKeluarga.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(252))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(120))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewKeluarga.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewKeluarga.ColumnHeadersHeight = 40
        DataGridViewKeluarga.Columns.AddRange(New DataGridViewColumn() {ColNamaAnggota, ColNIKAnggota, ColStatusHubungan, ColPekerjaan, ColTanggalLahir})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(235), CByte(245), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewKeluarga.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewKeluarga.Dock = DockStyle.Fill
        DataGridViewKeluarga.EnableHeadersVisualStyles = False
        DataGridViewKeluarga.Location = New Point(0, 10)
        DataGridViewKeluarga.Name = "DataGridViewKeluarga"
        DataGridViewKeluarga.RowHeadersWidth = 82
        DataGridViewKeluarga.RowTemplate.Height = 35
        DataGridViewKeluarga.Size = New Size(2115, 347)
        DataGridViewKeluarga.TabIndex = 0
        ' 
        ' ColNamaAnggota
        ' 
        ColNamaAnggota.HeaderText = "Nama Anggota"
        ColNamaAnggota.MinimumWidth = 10
        ColNamaAnggota.Name = "ColNamaAnggota"
        ' 
        ' ColNIKAnggota
        ' 
        ColNIKAnggota.HeaderText = "NIK"
        ColNIKAnggota.MinimumWidth = 10
        ColNIKAnggota.Name = "ColNIKAnggota"
        ' 
        ' ColStatusHubungan
        ' 
        ColStatusHubungan.HeaderText = "Status Hubungan"
        ColStatusHubungan.Items.AddRange(New Object() {"Suami", "Istri", "Anak", "Anak Kandung", "Anak Tiri", "Anak Angkat"})
        ColStatusHubungan.MinimumWidth = 10
        ColStatusHubungan.Name = "ColStatusHubungan"
        ' 
        ' ColPekerjaan
        ' 
        ColPekerjaan.HeaderText = "Pekerjaan"
        ColPekerjaan.MinimumWidth = 10
        ColPekerjaan.Name = "ColPekerjaan"
        ' 
        ' ColTanggalLahir
        ' 
        ColTanggalLahir.HeaderText = "Tanggal Lahir"
        ColTanggalLahir.MinimumWidth = 10
        ColTanggalLahir.Name = "ColTanggalLahir"
        ' 
        ' PanelButtonKeluarga
        ' 
        PanelButtonKeluarga.Controls.Add(ButtonTambahKeluarga)
        PanelButtonKeluarga.Controls.Add(ButtonEditKeluarga)
        PanelButtonKeluarga.Controls.Add(ButtonHapusKeluarga)
        PanelButtonKeluarga.Dock = DockStyle.Top
        PanelButtonKeluarga.Location = New Point(20, 63)
        PanelButtonKeluarga.Name = "PanelButtonKeluarga"
        PanelButtonKeluarga.Size = New Size(2115, 60)
        PanelButtonKeluarga.TabIndex = 1
        ' 
        ' 
        ' ButtonTambahKeluarga
        ' 
        ButtonTambahKeluarga.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        ButtonTambahKeluarga.Cursor = Cursors.Hand
        ButtonTambahKeluarga.FlatAppearance.BorderSize = 0
        ButtonTambahKeluarga.FlatStyle = FlatStyle.Flat
        ButtonTambahKeluarga.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonTambahKeluarga.ForeColor = Color.White
        ButtonTambahKeluarga.Location = New Point(0, 5)
        ButtonTambahKeluarga.Name = "ButtonTambahKeluarga"
        ButtonTambahKeluarga.Size = New Size(160, 50)
        ButtonTambahKeluarga.TabIndex = 0
        ButtonTambahKeluarga.Text = "➕ Tambah"
        ButtonTambahKeluarga.UseVisualStyleBackColor = False
        ' 
        ' ButtonEditKeluarga
        ' 
        ButtonEditKeluarga.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        ButtonEditKeluarga.Cursor = Cursors.Hand
        ButtonEditKeluarga.FlatAppearance.BorderSize = 0
        ButtonEditKeluarga.FlatStyle = FlatStyle.Flat
        ButtonEditKeluarga.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonEditKeluarga.ForeColor = Color.White
        ButtonEditKeluarga.Location = New Point(170, 5)
        ButtonEditKeluarga.Name = "ButtonEditKeluarga"
        ButtonEditKeluarga.Size = New Size(140, 50)
        ButtonEditKeluarga.TabIndex = 1
        ButtonEditKeluarga.Text = "✏️ Edit"
        ButtonEditKeluarga.UseVisualStyleBackColor = False
        ' 
        ' ButtonHapusKeluarga
        ' 
        ButtonHapusKeluarga.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        ButtonHapusKeluarga.Cursor = Cursors.Hand
        ButtonHapusKeluarga.FlatAppearance.BorderSize = 0
        ButtonHapusKeluarga.FlatStyle = FlatStyle.Flat
        ButtonHapusKeluarga.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonHapusKeluarga.ForeColor = Color.White
        ButtonHapusKeluarga.Location = New Point(320, 5)
        ButtonHapusKeluarga.Name = "ButtonHapusKeluarga"
        ButtonHapusKeluarga.Size = New Size(140, 50)
        ButtonHapusKeluarga.TabIndex = 2
        ButtonHapusKeluarga.Text = "🗑️ Hapus"
        ButtonHapusKeluarga.UseVisualStyleBackColor = False
        ' 
        ' PanelFooter
        ' 
        PanelFooter.BackColor = Color.White
        PanelFooter.Controls.Add(ButtonKembali)
        PanelFooter.Controls.Add(ButtonBatal)
        PanelFooter.Controls.Add(ButtonSimpan)
        PanelFooter.Dock = DockStyle.Bottom
        PanelFooter.Location = New Point(0, 1280)
        PanelFooter.Name = "PanelFooter"
        PanelFooter.Size = New Size(2275, 80)
        PanelFooter.TabIndex = 1
        ' 
        ' ButtonKembali
        ' 
        ButtonKembali.BackColor = Color.White
        ButtonKembali.FlatAppearance.BorderColor = Color.LightGray
        ButtonKembali.FlatStyle = FlatStyle.Flat
        ButtonKembali.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        ButtonKembali.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ButtonKembali.Location = New Point(40, 15)
        ButtonKembali.Name = "ButtonKembali"
        ButtonKembali.Size = New Size(150, 50)
        ButtonKembali.TabIndex = 0
        ButtonKembali.Text = "Kembali"
        ButtonKembali.UseVisualStyleBackColor = False
        ' 
        ' ButtonBatal
        ' 
        ButtonBatal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonBatal.BackColor = Color.White
        ButtonBatal.FlatAppearance.BorderColor = Color.LightGray
        ButtonBatal.FlatStyle = FlatStyle.Flat
        ButtonBatal.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        ButtonBatal.ForeColor = Color.DimGray
        ButtonBatal.Location = New Point(1885, 15)
        ButtonBatal.Name = "ButtonBatal"
        ButtonBatal.Size = New Size(150, 60)
        ButtonBatal.TabIndex = 1
        ButtonBatal.Text = "Batal"
        ButtonBatal.UseVisualStyleBackColor = False
        ' 
        ' ButtonSimpan
        ' 
        ButtonSimpan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonSimpan.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        ButtonSimpan.FlatAppearance.BorderSize = 0
        ButtonSimpan.FlatStyle = FlatStyle.Flat
        ButtonSimpan.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        ButtonSimpan.ForeColor = Color.White
        ButtonSimpan.Location = New Point(2055, 15)
        ButtonSimpan.Name = "ButtonSimpan"
        ButtonSimpan.Size = New Size(200, 60)
        ButtonSimpan.TabIndex = 2
        ButtonSimpan.Text = "Simpan Data"
        ButtonSimpan.UseVisualStyleBackColor = False
        ' 
        ' Profil
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        ClientSize = New Size(2275, 1360)
        Controls.Add(PanelContent)
        Controls.Add(PanelFooter)
        Controls.Add(PanelHeader)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(5)
        MinimumSize = New Size(2259, 1317)
        Name = "Profil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Profil Wajib Pajak | TaxEase"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelContent.ResumeLayout(False)
        PanelContent.PerformLayout()
        MainTableLayout.ResumeLayout(False)
        MainTableLayout.PerformLayout()
        GroupBoxDataPribadi.ResumeLayout(False)
        GroupBoxDataPribadi.PerformLayout()
        TableLayoutPribadi.ResumeLayout(False)
        TableLayoutPribadi.PerformLayout()
        GroupBoxKeluarga.ResumeLayout(False)
        PanelKeluargaContent.ResumeLayout(False)
        CType(DataGridViewKeluarga, ComponentModel.ISupportInitialize).EndInit()
        PanelButtonKeluarga.ResumeLayout(False)
        PanelFooter.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    ' Variables declaration
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents LabelPageTitle As System.Windows.Forms.Label
    Friend WithEvents LabelPageSubtitle As System.Windows.Forms.Label
    Friend WithEvents PanelContent As System.Windows.Forms.Panel
    Friend WithEvents MainTableLayout As System.Windows.Forms.TableLayoutPanel
    
    Friend WithEvents GroupBoxDataPribadi As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPribadi As System.Windows.Forms.TableLayoutPanel
    
    Friend WithEvents txtNIK As System.Windows.Forms.TextBox
    Friend WithEvents LabelNIK As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LabelEmail As System.Windows.Forms.Label
    Friend WithEvents txtTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents LabelTempatLahir As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelTanggalLahir As System.Windows.Forms.Label
    Friend WithEvents cmbJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents LabelJenisKelamin As System.Windows.Forms.Label
    Friend WithEvents cmbStatusPernikahan As System.Windows.Forms.ComboBox
    Friend WithEvents LabelStatusPernikahan As System.Windows.Forms.Label
    Friend WithEvents txtNoHP As System.Windows.Forms.TextBox
    Friend WithEvents LabelNoHP As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalTerdaftar As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelTanggalTerdaftar As System.Windows.Forms.Label
    Friend WithEvents cmbStatusPTKP As System.Windows.Forms.ComboBox
    Friend WithEvents LabelStatusPTKP As System.Windows.Forms.Label
    Friend WithEvents cmbJenisWajibPajak As System.Windows.Forms.ComboBox
    Friend WithEvents LabelJenisWajibPajak As System.Windows.Forms.Label
    Friend WithEvents cmbStatusPekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents LabelStatusPekerjaan As System.Windows.Forms.Label
    Friend WithEvents txtNamaTempatKerja As System.Windows.Forms.TextBox
    Friend WithEvents LabelNamaTempatKerja As System.Windows.Forms.Label
    Friend WithEvents LabelJabatan As System.Windows.Forms.Label ' New
    Friend WithEvents txtJabatan As System.Windows.Forms.TextBox ' New
    Friend WithEvents LabelAlamat As System.Windows.Forms.Label ' New
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox ' New
    
    Friend WithEvents GroupBoxKeluarga As System.Windows.Forms.GroupBox
    Friend WithEvents PanelKeluargaContent As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewKeluarga As System.Windows.Forms.DataGridView
    Friend WithEvents ColNamaAnggota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNIKAnggota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatusHubungan As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ColPekerjaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTanggalLahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelButtonKeluarga As System.Windows.Forms.Panel
    Friend WithEvents ButtonTambahKeluarga As System.Windows.Forms.Button
    Friend WithEvents ButtonEditKeluarga As System.Windows.Forms.Button
    Friend WithEvents ButtonHapusKeluarga As System.Windows.Forms.Button
    
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonKembali As System.Windows.Forms.Button

End Class
