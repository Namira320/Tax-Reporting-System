<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profil
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.GroupBoxKeluarga = New System.Windows.Forms.GroupBox()
        Me.DataGridViewAnak = New System.Windows.Forms.DataGridView()
        Me.ColNamaAnak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTanggalLahirAnak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatusTanggungan = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ButtonTambahAnak = New System.Windows.Forms.Button()
        Me.ButtonHapusAnak = New System.Windows.Forms.Button()
        Me.LabelJumlahTanggungan = New System.Windows.Forms.Label()
        Me.TextBoxJumlahTanggungan = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaPasangan = New System.Windows.Forms.TextBox()
        Me.LabelNamaPasangan = New System.Windows.Forms.Label()
        Me.GroupBoxKontak = New System.Windows.Forms.GroupBox()
        Me.TextBoxTelepon = New System.Windows.Forms.TextBox()
        Me.LabelTelepon = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.GroupBoxAlamat = New System.Windows.Forms.GroupBox()
        Me.TextBoxKodePos = New System.Windows.Forms.TextBox()
        Me.LabelKodePos = New System.Windows.Forms.Label()
        Me.TextBoxKota = New System.Windows.Forms.TextBox()
        Me.LabelKota = New System.Windows.Forms.Label()
        Me.TextBoxProvinsi = New System.Windows.Forms.TextBox()
        Me.LabelProvinsi = New System.Windows.Forms.Label()
        Me.TextBoxAlamatLengkap = New System.Windows.Forms.TextBox()
        Me.LabelAlamatLengkap = New System.Windows.Forms.Label()
        Me.GroupBoxInformasiUmum = New System.Windows.Forms.GroupBox()
        Me.TextBoxNomorRegistrasi = New System.Windows.Forms.TextBox()
        Me.LabelNomorRegistrasi = New System.Windows.Forms.Label()
        Me.ComboBoxJenisWajibPajak = New System.Windows.Forms.ComboBox()
        Me.LabelJenisWajibPajak = New System.Windows.Forms.Label()
        Me.ComboBoxStatusPekerjaan = New System.Windows.Forms.ComboBox()
        Me.LabelStatusPekerjaan = New System.Windows.Forms.Label()
        Me.GroupBoxIkhtisar = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxStatusPTKP = New System.Windows.Forms.ComboBox()
        Me.LabelStatusPTKP = New System.Windows.Forms.Label()
        Me.LabelTanggalLahir = New System.Windows.Forms.Label()
        Me.TextBoxNIK = New System.Windows.Forms.TextBox()
        Me.LabelNIK = New System.Windows.Forms.Label()
        Me.TextBoxNPWP = New System.Windows.Forms.TextBox()
        Me.LabelNPWP = New System.Windows.Forms.Label()
        Me.TextBoxNamaWajibPajak = New System.Windows.Forms.TextBox()
        Me.LabelNamaWajibPajak = New System.Windows.Forms.Label()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.ButtonNavKeluarga = New System.Windows.Forms.Button()
        Me.ButtonNavKontak = New System.Windows.Forms.Button()
        Me.ButtonNavAlamat = New System.Windows.Forms.Button()
        Me.ButtonNavInformasi = New System.Windows.Forms.Button()
        Me.ButtonNavIkhtisar = New System.Windows.Forms.Button()
        Me.LabelNavigationTitle = New System.Windows.Forms.Label()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        Me.GroupBoxKeluarga.SuspendLayout()
        CType(Me.DataGridViewAnak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxKontak.SuspendLayout()
        Me.GroupBoxAlamat.SuspendLayout()
        Me.GroupBoxInformasiUmum.SuspendLayout()
        Me.GroupBoxIkhtisar.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.White
        Me.PanelHeader.Controls.Add(Me.LabelTitle)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(280, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Padding = New System.Windows.Forms.Padding(40, 20, 40, 20)
        Me.PanelHeader.Size = New System.Drawing.Size(1120, 80)
        Me.PanelHeader.TabIndex = 0
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LabelTitle.Location = New System.Drawing.Point(40, 20)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(310, 48)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Profil Wajib Pajak"
        '
        'PanelContent
        '
        Me.PanelContent.AutoScroll = True
        Me.PanelContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PanelContent.Controls.Add(Me.PanelDetail)
        Me.PanelContent.Controls.Add(Me.PanelHeader)
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(280, 0)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1120, 880)
        Me.PanelContent.TabIndex = 1
        '
        'PanelDetail
        '
        Me.PanelDetail.AutoScroll = True
        Me.PanelDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PanelDetail.Controls.Add(Me.GroupBoxKeluarga)
        Me.PanelDetail.Controls.Add(Me.GroupBoxKontak)
        Me.PanelDetail.Controls.Add(Me.GroupBoxAlamat)
        Me.PanelDetail.Controls.Add(Me.GroupBoxInformasiUmum)
        Me.PanelDetail.Controls.Add(Me.GroupBoxIkhtisar)
        Me.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetail.Location = New System.Drawing.Point(0, 80)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Padding = New System.Windows.Forms.Padding(40)
        Me.PanelDetail.Size = New System.Drawing.Size(1120, 800)
        Me.PanelDetail.TabIndex = 6
        '
        'GroupBoxKeluarga
        '
        Me.GroupBoxKeluarga.BackColor = System.Drawing.Color.White
        Me.GroupBoxKeluarga.Controls.Add(Me.DataGridViewAnak)
        Me.GroupBoxKeluarga.Controls.Add(Me.ButtonTambahAnak)
        Me.GroupBoxKeluarga.Controls.Add(Me.ButtonHapusAnak)
        Me.GroupBoxKeluarga.Controls.Add(Me.LabelJumlahTanggungan)
        Me.GroupBoxKeluarga.Controls.Add(Me.TextBoxJumlahTanggungan)
        Me.GroupBoxKeluarga.Controls.Add(Me.TextBoxNamaPasangan)
        Me.GroupBoxKeluarga.Controls.Add(Me.LabelNamaPasangan)
        Me.GroupBoxKeluarga.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxKeluarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBoxKeluarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxKeluarga.Location = New System.Drawing.Point(40, 40)
        Me.GroupBoxKeluarga.Name = "GroupBoxKeluarga"
        Me.GroupBoxKeluarga.Padding = New System.Windows.Forms.Padding(30)
        Me.GroupBoxKeluarga.Size = New System.Drawing.Size(1040, 720)
        Me.GroupBoxKeluarga.TabIndex = 4
        Me.GroupBoxKeluarga.TabStop = False
        Me.GroupBoxKeluarga.Text = "5. Data Unit Keluarga"
        '
        'DataGridViewAnak
        '
        Me.DataGridViewAnak.AllowUserToAddRows = False
        Me.DataGridViewAnak.AllowUserToDeleteRows = False
        Me.DataGridViewAnak.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewAnak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAnak.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNamaAnak, Me.ColTanggalLahirAnak, Me.ColStatusTanggungan})
        Me.DataGridViewAnak.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right) _
            Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAnak.Location = New System.Drawing.Point(30, 180)
        Me.DataGridViewAnak.Name = "DataGridViewAnak"
        Me.DataGridViewAnak.RowHeadersWidth = 51
        Me.DataGridViewAnak.Size = New System.Drawing.Size(980, 480)
        Me.DataGridViewAnak.TabIndex = 5
        '
        'ColNamaAnak
        '
        Me.ColNamaAnak.HeaderText = "Nama Anak"
        Me.ColNamaAnak.MinimumWidth = 6
        Me.ColNamaAnak.Name = "ColNamaAnak"
        Me.ColNamaAnak.Width = 400
        '
        'ColTanggalLahirAnak
        '
        Me.ColTanggalLahirAnak.HeaderText = "Tanggal Lahir"
        Me.ColTanggalLahirAnak.MinimumWidth = 6
        Me.ColTanggalLahirAnak.Name = "ColTanggalLahirAnak"
        Me.ColTanggalLahirAnak.Width = 250
        '
        'ColStatusTanggungan
        '
        Me.ColStatusTanggungan.HeaderText = "Status Tanggungan"
        Me.ColStatusTanggungan.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.ColStatusTanggungan.MinimumWidth = 6
        Me.ColStatusTanggungan.Name = "ColStatusTanggungan"
        Me.ColStatusTanggungan.Width = 200
        '
        'ButtonTambahAnak
        '
        Me.ButtonTambahAnak.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ButtonTambahAnak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTambahAnak.FlatAppearance.BorderSize = 0
        Me.ButtonTambahAnak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTambahAnak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambahAnak.ForeColor = System.Drawing.Color.White
        Me.ButtonTambahAnak.Location = New System.Drawing.Point(30, 140)
        Me.ButtonTambahAnak.Name = "ButtonTambahAnak"
        Me.ButtonTambahAnak.Size = New System.Drawing.Size(150, 35)
        Me.ButtonTambahAnak.TabIndex = 4
        Me.ButtonTambahAnak.Text = "Tambah Anak"
        Me.ButtonTambahAnak.UseVisualStyleBackColor = False
        '
        'ButtonHapusAnak
        '
        Me.ButtonHapusAnak.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ButtonHapusAnak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHapusAnak.FlatAppearance.BorderSize = 0
        Me.ButtonHapusAnak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHapusAnak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapusAnak.ForeColor = System.Drawing.Color.White
        Me.ButtonHapusAnak.Location = New System.Drawing.Point(190, 140)
        Me.ButtonHapusAnak.Name = "ButtonHapusAnak"
        Me.ButtonHapusAnak.Size = New System.Drawing.Size(150, 35)
        Me.ButtonHapusAnak.TabIndex = 6
        Me.ButtonHapusAnak.Text = "Hapus Anak"
        Me.ButtonHapusAnak.UseVisualStyleBackColor = False
        '
        'LabelJumlahTanggungan
        '
        Me.LabelJumlahTanggungan.AutoSize = True
        Me.LabelJumlahTanggungan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJumlahTanggungan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelJumlahTanggungan.Location = New System.Drawing.Point(30, 100)
        Me.LabelJumlahTanggungan.Name = "LabelJumlahTanggungan"
        Me.LabelJumlahTanggungan.Size = New System.Drawing.Size(168, 25)
        Me.LabelJumlahTanggungan.TabIndex = 3
        Me.LabelJumlahTanggungan.Text = "Jumlah Tanggungan"
        '
        'TextBoxJumlahTanggungan
        '
        Me.TextBoxJumlahTanggungan.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxJumlahTanggungan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxJumlahTanggungan.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJumlahTanggungan.Location = New System.Drawing.Point(30, 125)
        Me.TextBoxJumlahTanggungan.Name = "TextBoxJumlahTanggungan"
        Me.TextBoxJumlahTanggungan.ReadOnly = True
        Me.TextBoxJumlahTanggungan.Size = New System.Drawing.Size(200, 34)
        Me.TextBoxJumlahTanggungan.TabIndex = 2
        '
        'TextBoxNamaPasangan
        '
        Me.TextBoxNamaPasangan.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxNamaPasangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNamaPasangan.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNamaPasangan.Location = New System.Drawing.Point(30, 60)
        Me.TextBoxNamaPasangan.Name = "TextBoxNamaPasangan"
        Me.TextBoxNamaPasangan.Size = New System.Drawing.Size(480, 34)
        Me.TextBoxNamaPasangan.TabIndex = 1
        '
        'LabelNamaPasangan
        '
        Me.LabelNamaPasangan.AutoSize = True
        Me.LabelNamaPasangan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNamaPasangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelNamaPasangan.Location = New System.Drawing.Point(30, 35)
        Me.LabelNamaPasangan.Name = "LabelNamaPasangan"
        Me.LabelNamaPasangan.Size = New System.Drawing.Size(140, 25)
        Me.LabelNamaPasangan.TabIndex = 0
        Me.LabelNamaPasangan.Text = "Nama Pasangan"
        '
        'GroupBoxKontak
        '
        Me.GroupBoxKontak.BackColor = System.Drawing.Color.White
        Me.GroupBoxKontak.Controls.Add(Me.TextBoxTelepon)
        Me.GroupBoxKontak.Controls.Add(Me.LabelTelepon)
        Me.GroupBoxKontak.Controls.Add(Me.TextBoxEmail)
        Me.GroupBoxKontak.Controls.Add(Me.LabelEmail)
        Me.GroupBoxKontak.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxKontak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBoxKontak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxKontak.Location = New System.Drawing.Point(40, 40)
        Me.GroupBoxKontak.Name = "GroupBoxKontak"
        Me.GroupBoxKontak.Padding = New System.Windows.Forms.Padding(30)
        Me.GroupBoxKontak.Size = New System.Drawing.Size(1040, 720)
        Me.GroupBoxKontak.TabIndex = 3
        Me.GroupBoxKontak.TabStop = False
        Me.GroupBoxKontak.Text = "4. Detail Kontak"
        '
        'TextBoxTelepon
        '
        Me.TextBoxTelepon.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxTelepon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTelepon.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelepon.Location = New System.Drawing.Point(520, 60)
        Me.TextBoxTelepon.Name = "TextBoxTelepon"
        Me.TextBoxTelepon.Size = New System.Drawing.Size(490, 34)
        Me.TextBoxTelepon.TabIndex = 3
        '
        'LabelTelepon
        '
        Me.LabelTelepon.AutoSize = True
        Me.LabelTelepon.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelepon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelTelepon.Location = New System.Drawing.Point(520, 35)
        Me.LabelTelepon.Name = "LabelTelepon"
        Me.LabelTelepon.Size = New System.Drawing.Size(75, 25)
        Me.LabelTelepon.TabIndex = 2
        Me.LabelTelepon.Text = "Telepon"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEmail.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(30, 60)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(480, 34)
        Me.TextBoxEmail.TabIndex = 1
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelEmail.Location = New System.Drawing.Point(30, 35)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(54, 25)
        Me.LabelEmail.TabIndex = 0
        Me.LabelEmail.Text = "Email"
        '
        'GroupBoxAlamat
        '
        Me.GroupBoxAlamat.BackColor = System.Drawing.Color.White
        Me.GroupBoxAlamat.Controls.Add(Me.TextBoxKodePos)
        Me.GroupBoxAlamat.Controls.Add(Me.LabelKodePos)
        Me.GroupBoxAlamat.Controls.Add(Me.TextBoxKota)
        Me.GroupBoxAlamat.Controls.Add(Me.LabelKota)
        Me.GroupBoxAlamat.Controls.Add(Me.TextBoxProvinsi)
        Me.GroupBoxAlamat.Controls.Add(Me.LabelProvinsi)
        Me.GroupBoxAlamat.Controls.Add(Me.TextBoxAlamatLengkap)
        Me.GroupBoxAlamat.Controls.Add(Me.LabelAlamatLengkap)
        Me.GroupBoxAlamat.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBoxAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxAlamat.Location = New System.Drawing.Point(40, 40)
        Me.GroupBoxAlamat.Name = "GroupBoxAlamat"
        Me.GroupBoxAlamat.Padding = New System.Windows.Forms.Padding(30)
        Me.GroupBoxAlamat.Size = New System.Drawing.Size(1040, 720)
        Me.GroupBoxAlamat.TabIndex = 2
        Me.GroupBoxAlamat.TabStop = False
        Me.GroupBoxAlamat.Text = "3. Alamat"
        '
        'TextBoxKodePos
        '
        Me.TextBoxKodePos.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxKodePos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxKodePos.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKodePos.Location = New System.Drawing.Point(770, 140)
        Me.TextBoxKodePos.Name = "TextBoxKodePos"
        Me.TextBoxKodePos.Size = New System.Drawing.Size(240, 34)
        Me.TextBoxKodePos.TabIndex = 7
        '
        'LabelKodePos
        '
        Me.LabelKodePos.AutoSize = True
        Me.LabelKodePos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKodePos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelKodePos.Location = New System.Drawing.Point(770, 115)
        Me.LabelKodePos.Name = "LabelKodePos"
        Me.LabelKodePos.Size = New System.Drawing.Size(90, 25)
        Me.LabelKodePos.TabIndex = 6
        Me.LabelKodePos.Text = "Kode Pos"
        '
        'TextBoxKota
        '
        Me.TextBoxKota.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxKota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxKota.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKota.Location = New System.Drawing.Point(520, 140)
        Me.TextBoxKota.Name = "TextBoxKota"
        Me.TextBoxKota.Size = New System.Drawing.Size(240, 34)
        Me.TextBoxKota.TabIndex = 5
        '
        'LabelKota
        '
        Me.LabelKota.AutoSize = True
        Me.LabelKota.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelKota.Location = New System.Drawing.Point(520, 115)
        Me.LabelKota.Name = "LabelKota"
        Me.LabelKota.Size = New System.Drawing.Size(50, 25)
        Me.LabelKota.TabIndex = 4
        Me.LabelKota.Text = "Kota"
        '
        'TextBoxProvinsi
        '
        Me.TextBoxProvinsi.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxProvinsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxProvinsi.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProvinsi.Location = New System.Drawing.Point(30, 140)
        Me.TextBoxProvinsi.Name = "TextBoxProvinsi"
        Me.TextBoxProvinsi.Size = New System.Drawing.Size(480, 34)
        Me.TextBoxProvinsi.TabIndex = 3
        '
        'LabelProvinsi
        '
        Me.LabelProvinsi.AutoSize = True
        Me.LabelProvinsi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProvinsi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelProvinsi.Location = New System.Drawing.Point(30, 115)
        Me.LabelProvinsi.Name = "LabelProvinsi"
        Me.LabelProvinsi.Size = New System.Drawing.Size(75, 25)
        Me.LabelProvinsi.TabIndex = 2
        Me.LabelProvinsi.Text = "Provinsi"
        '
        'TextBoxAlamatLengkap
        '
        Me.TextBoxAlamatLengkap.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxAlamatLengkap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAlamatLengkap.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlamatLengkap.Location = New System.Drawing.Point(30, 60)
        Me.TextBoxAlamatLengkap.Multiline = True
        Me.TextBoxAlamatLengkap.Name = "TextBoxAlamatLengkap"
        Me.TextBoxAlamatLengkap.Size = New System.Drawing.Size(980, 50)
        Me.TextBoxAlamatLengkap.TabIndex = 1
        '
        'LabelAlamatLengkap
        '
        Me.LabelAlamatLengkap.AutoSize = True
        Me.LabelAlamatLengkap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlamatLengkap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelAlamatLengkap.Location = New System.Drawing.Point(30, 35)
        Me.LabelAlamatLengkap.Name = "LabelAlamatLengkap"
        Me.LabelAlamatLengkap.Size = New System.Drawing.Size(139, 25)
        Me.LabelAlamatLengkap.TabIndex = 0
        Me.LabelAlamatLengkap.Text = "Alamat Lengkap"
        '
        'GroupBoxInformasiUmum
        '
        Me.GroupBoxInformasiUmum.BackColor = System.Drawing.Color.White
        Me.GroupBoxInformasiUmum.Controls.Add(Me.TextBoxNomorRegistrasi)
        Me.GroupBoxInformasiUmum.Controls.Add(Me.LabelNomorRegistrasi)
        Me.GroupBoxInformasiUmum.Controls.Add(Me.ComboBoxJenisWajibPajak)
        Me.GroupBoxInformasiUmum.Controls.Add(Me.LabelJenisWajibPajak)
        Me.GroupBoxInformasiUmum.Controls.Add(Me.ComboBoxStatusPekerjaan)
        Me.GroupBoxInformasiUmum.Controls.Add(Me.LabelStatusPekerjaan)
        Me.GroupBoxInformasiUmum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInformasiUmum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBoxInformasiUmum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxInformasiUmum.Location = New System.Drawing.Point(40, 40)
        Me.GroupBoxInformasiUmum.Name = "GroupBoxInformasiUmum"
        Me.GroupBoxInformasiUmum.Padding = New System.Windows.Forms.Padding(30)
        Me.GroupBoxInformasiUmum.Size = New System.Drawing.Size(1040, 720)
        Me.GroupBoxInformasiUmum.TabIndex = 1
        Me.GroupBoxInformasiUmum.TabStop = False
        Me.GroupBoxInformasiUmum.Text = "2. Informasi Umum"
        '
        'TextBoxNomorRegistrasi
        '
        Me.TextBoxNomorRegistrasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxNomorRegistrasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNomorRegistrasi.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomorRegistrasi.Location = New System.Drawing.Point(580, 60)
        Me.TextBoxNomorRegistrasi.Name = "TextBoxNomorRegistrasi"
        Me.TextBoxNomorRegistrasi.Size = New System.Drawing.Size(430, 34)
        Me.TextBoxNomorRegistrasi.TabIndex = 5
        '
        'LabelNomorRegistrasi
        '
        Me.LabelNomorRegistrasi.AutoSize = True
        Me.LabelNomorRegistrasi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomorRegistrasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelNomorRegistrasi.Location = New System.Drawing.Point(580, 35)
        Me.LabelNomorRegistrasi.Name = "LabelNomorRegistrasi"
        Me.LabelNomorRegistrasi.Size = New System.Drawing.Size(170, 25)
        Me.LabelNomorRegistrasi.TabIndex = 4
        Me.LabelNomorRegistrasi.Text = "Nomor Registrasi Dasar"
        '
        'ComboBoxJenisWajibPajak
        '
        Me.ComboBoxJenisWajibPajak.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ComboBoxJenisWajibPajak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxJenisWajibPajak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxJenisWajibPajak.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxJenisWajibPajak.FormattingEnabled = True
        Me.ComboBoxJenisWajibPajak.Items.AddRange(New Object() {"Karyawan Tetap", "Karyawan Tidak Tetap"})
        Me.ComboBoxJenisWajibPajak.Location = New System.Drawing.Point(30, 120)
        Me.ComboBoxJenisWajibPajak.Name = "ComboBoxJenisWajibPajak"
        Me.ComboBoxJenisWajibPajak.Size = New System.Drawing.Size(510, 36)
        Me.ComboBoxJenisWajibPajak.TabIndex = 3
        '
        'LabelJenisWajibPajak
        '
        Me.LabelJenisWajibPajak.AutoSize = True
        Me.LabelJenisWajibPajak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJenisWajibPajak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelJenisWajibPajak.Location = New System.Drawing.Point(30, 95)
        Me.LabelJenisWajibPajak.Name = "LabelJenisWajibPajak"
        Me.LabelJenisWajibPajak.Size = New System.Drawing.Size(149, 25)
        Me.LabelJenisWajibPajak.TabIndex = 2
        Me.LabelJenisWajibPajak.Text = "Jenis Wajib Pajak"
        '
        'ComboBoxStatusPekerjaan
        '
        Me.ComboBoxStatusPekerjaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ComboBoxStatusPekerjaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatusPekerjaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxStatusPekerjaan.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxStatusPekerjaan.FormattingEnabled = True
        Me.ComboBoxStatusPekerjaan.Items.AddRange(New Object() {"Pegawai Tetap", "Pegawai Tidak Tetap", "Pensiunan", "Wiraswasta", "Lainnya"})
        Me.ComboBoxStatusPekerjaan.Location = New System.Drawing.Point(30, 60)
        Me.ComboBoxStatusPekerjaan.Name = "ComboBoxStatusPekerjaan"
        Me.ComboBoxStatusPekerjaan.Size = New System.Drawing.Size(510, 36)
        Me.ComboBoxStatusPekerjaan.TabIndex = 1
        '
        'LabelStatusPekerjaan
        '
        Me.LabelStatusPekerjaan.AutoSize = True
        Me.LabelStatusPekerjaan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatusPekerjaan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelStatusPekerjaan.Location = New System.Drawing.Point(30, 35)
        Me.LabelStatusPekerjaan.Name = "LabelStatusPekerjaan"
        Me.LabelStatusPekerjaan.Size = New System.Drawing.Size(144, 25)
        Me.LabelStatusPekerjaan.TabIndex = 0
        Me.LabelStatusPekerjaan.Text = "Status Pekerjaan"
        '
        'GroupBoxIkhtisar
        '
        Me.GroupBoxIkhtisar.BackColor = System.Drawing.Color.White
        Me.GroupBoxIkhtisar.Controls.Add(Me.DateTimePickerTanggalLahir)
        Me.GroupBoxIkhtisar.Controls.Add(Me.ComboBoxStatusPTKP)
        Me.GroupBoxIkhtisar.Controls.Add(Me.LabelStatusPTKP)
        Me.GroupBoxIkhtisar.Controls.Add(Me.LabelTanggalLahir)
        Me.GroupBoxIkhtisar.Controls.Add(Me.TextBoxNIK)
        Me.GroupBoxIkhtisar.Controls.Add(Me.LabelNIK)
        Me.GroupBoxIkhtisar.Controls.Add(Me.TextBoxNPWP)
        Me.GroupBoxIkhtisar.Controls.Add(Me.LabelNPWP)
        Me.GroupBoxIkhtisar.Controls.Add(Me.TextBoxNamaWajibPajak)
        Me.GroupBoxIkhtisar.Controls.Add(Me.LabelNamaWajibPajak)
        Me.GroupBoxIkhtisar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxIkhtisar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBoxIkhtisar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxIkhtisar.Location = New System.Drawing.Point(40, 40)
        Me.GroupBoxIkhtisar.Name = "GroupBoxIkhtisar"
        Me.GroupBoxIkhtisar.Padding = New System.Windows.Forms.Padding(30)
        Me.GroupBoxIkhtisar.Size = New System.Drawing.Size(1040, 720)
        Me.GroupBoxIkhtisar.TabIndex = 0
        Me.GroupBoxIkhtisar.TabStop = False
        Me.GroupBoxIkhtisar.Text = "1. Ikhtisar Profil Wajib Pajak (Paling Penting)"
        '
        'DateTimePickerTanggalLahir
        '
        Me.DateTimePickerTanggalLahir.CalendarFont = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerTanggalLahir.Location = New System.Drawing.Point(580, 180)
        Me.DateTimePickerTanggalLahir.Name = "DateTimePickerTanggalLahir"
        Me.DateTimePickerTanggalLahir.Size = New System.Drawing.Size(510, 34)
        Me.DateTimePickerTanggalLahir.TabIndex = 9
        '
        'ComboBoxStatusPTKP
        '
        Me.ComboBoxStatusPTKP.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ComboBoxStatusPTKP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatusPTKP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxStatusPTKP.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxStatusPTKP.FormattingEnabled = True
        Me.ComboBoxStatusPTKP.Items.AddRange(New Object() {"TK/0", "K/0", "K/1", "K/2", "K/3"})
        Me.ComboBoxStatusPTKP.Location = New System.Drawing.Point(30, 180)
        Me.ComboBoxStatusPTKP.Name = "ComboBoxStatusPTKP"
        Me.ComboBoxStatusPTKP.Size = New System.Drawing.Size(510, 36)
        Me.ComboBoxStatusPTKP.TabIndex = 8
        '
        'LabelStatusPTKP
        '
        Me.LabelStatusPTKP.AutoSize = True
        Me.LabelStatusPTKP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatusPTKP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelStatusPTKP.Location = New System.Drawing.Point(30, 155)
        Me.LabelStatusPTKP.Name = "LabelStatusPTKP"
        Me.LabelStatusPTKP.Size = New System.Drawing.Size(103, 25)
        Me.LabelStatusPTKP.TabIndex = 7
        Me.LabelStatusPTKP.Text = "Status PTKP"
        '
        'LabelTanggalLahir
        '
        Me.LabelTanggalLahir.AutoSize = True
        Me.LabelTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTanggalLahir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelTanggalLahir.Location = New System.Drawing.Point(580, 155)
        Me.LabelTanggalLahir.Name = "LabelTanggalLahir"
        Me.LabelTanggalLahir.Size = New System.Drawing.Size(110, 25)
        Me.LabelTanggalLahir.TabIndex = 6
        Me.LabelTanggalLahir.Text = "Tanggal Lahir"
        '
        'TextBoxNIK
        '
        Me.TextBoxNIK.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxNIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNIK.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNIK.Location = New System.Drawing.Point(580, 120)
        Me.TextBoxNIK.Name = "TextBoxNIK"
        Me.TextBoxNIK.Size = New System.Drawing.Size(510, 34)
        Me.TextBoxNIK.TabIndex = 5
        '
        'LabelNIK
        '
        Me.LabelNIK.AutoSize = True
        Me.LabelNIK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNIK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelNIK.Location = New System.Drawing.Point(580, 95)
        Me.LabelNIK.Name = "LabelNIK"
        Me.LabelNIK.Size = New System.Drawing.Size(40, 25)
        Me.LabelNIK.TabIndex = 4
        Me.LabelNIK.Text = "NIK"
        '
        'TextBoxNPWP
        '
        Me.TextBoxNPWP.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxNPWP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNPWP.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNPWP.Location = New System.Drawing.Point(30, 120)
        Me.TextBoxNPWP.Name = "TextBoxNPWP"
        Me.TextBoxNPWP.Size = New System.Drawing.Size(510, 34)
        Me.TextBoxNPWP.TabIndex = 3
        '
        'LabelNPWP
        '
        Me.LabelNPWP.AutoSize = True
        Me.LabelNPWP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNPWP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelNPWP.Location = New System.Drawing.Point(30, 95)
        Me.LabelNPWP.Name = "LabelNPWP"
        Me.LabelNPWP.Size = New System.Drawing.Size(60, 25)
        Me.LabelNPWP.TabIndex = 2
        Me.LabelNPWP.Text = "NPWP"
        '
        'TextBoxNamaWajibPajak
        '
        Me.TextBoxNamaWajibPajak.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxNamaWajibPajak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNamaWajibPajak.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNamaWajibPajak.Location = New System.Drawing.Point(30, 60)
        Me.TextBoxNamaWajibPajak.Name = "TextBoxNamaWajibPajak"
        Me.TextBoxNamaWajibPajak.Size = New System.Drawing.Size(980, 34)
        Me.TextBoxNamaWajibPajak.TabIndex = 1
        '
        'LabelNamaWajibPajak
        '
        Me.LabelNamaWajibPajak.AutoSize = True
        Me.LabelNamaWajibPajak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNamaWajibPajak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelNamaWajibPajak.Location = New System.Drawing.Point(30, 35)
        Me.LabelNamaWajibPajak.Name = "LabelNamaWajibPajak"
        Me.LabelNamaWajibPajak.Size = New System.Drawing.Size(150, 25)
        Me.LabelNamaWajibPajak.TabIndex = 0
        Me.LabelNamaWajibPajak.Text = "Nama Wajib Pajak"
        '
        'PanelNavigation
        '
        Me.PanelNavigation.BackColor = System.Drawing.Color.White
        Me.PanelNavigation.Controls.Add(Me.ButtonNavKeluarga)
        Me.PanelNavigation.Controls.Add(Me.ButtonNavKontak)
        Me.PanelNavigation.Controls.Add(Me.ButtonNavAlamat)
        Me.PanelNavigation.Controls.Add(Me.ButtonNavInformasi)
        Me.PanelNavigation.Controls.Add(Me.ButtonNavIkhtisar)
        Me.PanelNavigation.Controls.Add(Me.LabelNavigationTitle)
        Me.PanelNavigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNavigation.Location = New System.Drawing.Point(0, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Padding = New System.Windows.Forms.Padding(30, 20, 30, 20)
        Me.PanelNavigation.Size = New System.Drawing.Size(280, 880)
        Me.PanelNavigation.TabIndex = 5
        '
        'ButtonNavKeluarga
        '
        Me.ButtonNavKeluarga.BackColor = System.Drawing.Color.Transparent
        Me.ButtonNavKeluarga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNavKeluarga.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonNavKeluarga.FlatAppearance.BorderSize = 0
        Me.ButtonNavKeluarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNavKeluarga.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNavKeluarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonNavKeluarga.Location = New System.Drawing.Point(30, 470)
        Me.ButtonNavKeluarga.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ButtonNavKeluarga.Name = "ButtonNavKeluarga"
        Me.ButtonNavKeluarga.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonNavKeluarga.Size = New System.Drawing.Size(220, 50)
        Me.ButtonNavKeluarga.TabIndex = 5
        Me.ButtonNavKeluarga.Text = "5. Unit Keluarga"
        Me.ButtonNavKeluarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNavKeluarga.UseVisualStyleBackColor = False
        '
        'ButtonNavKontak
        '
        Me.ButtonNavKontak.BackColor = System.Drawing.Color.Transparent
        Me.ButtonNavKontak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNavKontak.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonNavKontak.FlatAppearance.BorderSize = 0
        Me.ButtonNavKontak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNavKontak.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNavKontak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonNavKontak.Location = New System.Drawing.Point(30, 420)
        Me.ButtonNavKontak.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ButtonNavKontak.Name = "ButtonNavKontak"
        Me.ButtonNavKontak.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonNavKontak.Size = New System.Drawing.Size(220, 50)
        Me.ButtonNavKontak.TabIndex = 4
        Me.ButtonNavKontak.Text = "4. Detail Kontak"
        Me.ButtonNavKontak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNavKontak.UseVisualStyleBackColor = False
        '
        'ButtonNavAlamat
        '
        Me.ButtonNavAlamat.BackColor = System.Drawing.Color.Transparent
        Me.ButtonNavAlamat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNavAlamat.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonNavAlamat.FlatAppearance.BorderSize = 0
        Me.ButtonNavAlamat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNavAlamat.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNavAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonNavAlamat.Location = New System.Drawing.Point(30, 370)
        Me.ButtonNavAlamat.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ButtonNavAlamat.Name = "ButtonNavAlamat"
        Me.ButtonNavAlamat.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonNavAlamat.Size = New System.Drawing.Size(220, 50)
        Me.ButtonNavAlamat.TabIndex = 3
        Me.ButtonNavAlamat.Text = "3. Alamat"
        Me.ButtonNavAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNavAlamat.UseVisualStyleBackColor = False
        '
        'ButtonNavInformasi
        '
        Me.ButtonNavInformasi.BackColor = System.Drawing.Color.Transparent
        Me.ButtonNavInformasi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNavInformasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonNavInformasi.FlatAppearance.BorderSize = 0
        Me.ButtonNavInformasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNavInformasi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNavInformasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonNavInformasi.Location = New System.Drawing.Point(30, 320)
        Me.ButtonNavInformasi.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ButtonNavInformasi.Name = "ButtonNavInformasi"
        Me.ButtonNavInformasi.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonNavInformasi.Size = New System.Drawing.Size(220, 50)
        Me.ButtonNavInformasi.TabIndex = 2
        Me.ButtonNavInformasi.Text = "2. Informasi Umum"
        Me.ButtonNavInformasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNavInformasi.UseVisualStyleBackColor = False
        '
        'ButtonNavIkhtisar
        '
        Me.ButtonNavIkhtisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ButtonNavIkhtisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNavIkhtisar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonNavIkhtisar.FlatAppearance.BorderSize = 0
        Me.ButtonNavIkhtisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNavIkhtisar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNavIkhtisar.ForeColor = System.Drawing.Color.White
        Me.ButtonNavIkhtisar.Location = New System.Drawing.Point(30, 220)
        Me.ButtonNavIkhtisar.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ButtonNavIkhtisar.Name = "ButtonNavIkhtisar"
        Me.ButtonNavIkhtisar.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonNavIkhtisar.Size = New System.Drawing.Size(220, 50)
        Me.ButtonNavIkhtisar.TabIndex = 1
        Me.ButtonNavIkhtisar.Text = "1. Ikhtisar"
        Me.ButtonNavIkhtisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNavIkhtisar.UseVisualStyleBackColor = False
        '
        'LabelNavigationTitle
        '
        Me.LabelNavigationTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelNavigationTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNavigationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LabelNavigationTitle.Location = New System.Drawing.Point(30, 20)
        Me.LabelNavigationTitle.Name = "LabelNavigationTitle"
        Me.LabelNavigationTitle.Size = New System.Drawing.Size(220, 200)
        Me.LabelNavigationTitle.TabIndex = 0
        Me.LabelNavigationTitle.Text = "TaxEase"
        Me.LabelNavigationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelFooter
        '
        Me.PanelFooter.BackColor = System.Drawing.Color.White
        Me.PanelFooter.Controls.Add(Me.ButtonBatal)
        Me.PanelFooter.Controls.Add(Me.ButtonSimpan)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(280, 780)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Padding = New System.Windows.Forms.Padding(40, 20, 40, 20)
        Me.PanelFooter.Size = New System.Drawing.Size(1120, 100)
        Me.PanelFooter.TabIndex = 2
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.White
        Me.ButtonBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ButtonBatal.FlatAppearance.BorderSize = 1
        Me.ButtonBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBatal.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonBatal.Location = New System.Drawing.Point(920, 20)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(120, 50)
        Me.ButtonBatal.TabIndex = 1
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ButtonSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSimpan.FlatAppearance.BorderSize = 0
        Me.ButtonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.ForeColor = System.Drawing.Color.White
        Me.ButtonSimpan.Location = New System.Drawing.Point(1060, 20)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(120, 50)
        Me.ButtonSimpan.TabIndex = 0
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'Profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 880)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Profil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TaxEase | Profil Wajib Pajak"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelContent.ResumeLayout(False)
        Me.GroupBoxKeluarga.ResumeLayout(False)
        Me.GroupBoxKeluarga.PerformLayout()
        CType(Me.DataGridViewAnak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxKontak.ResumeLayout(False)
        Me.GroupBoxKontak.PerformLayout()
        Me.GroupBoxAlamat.ResumeLayout(False)
        Me.GroupBoxAlamat.PerformLayout()
        Me.GroupBoxInformasiUmum.ResumeLayout(False)
        Me.GroupBoxInformasiUmum.PerformLayout()
        Me.GroupBoxIkhtisar.ResumeLayout(False)
        Me.GroupBoxIkhtisar.PerformLayout()
        Me.PanelFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PanelContent As Panel
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents GroupBoxIkhtisar As GroupBox
    Friend WithEvents TextBoxNamaWajibPajak As TextBox
    Friend WithEvents LabelNamaWajibPajak As Label
    Friend WithEvents TextBoxNPWP As TextBox
    Friend WithEvents LabelNPWP As Label
    Friend WithEvents TextBoxNIK As TextBox
    Friend WithEvents LabelNIK As Label
    Friend WithEvents ComboBoxStatusPTKP As ComboBox
    Friend WithEvents LabelStatusPTKP As Label
    Friend WithEvents DateTimePickerTanggalLahir As DateTimePicker
    Friend WithEvents LabelTanggalLahir As Label
    Friend WithEvents GroupBoxInformasiUmum As GroupBox
    Friend WithEvents ComboBoxStatusPekerjaan As ComboBox
    Friend WithEvents LabelStatusPekerjaan As Label
    Friend WithEvents ComboBoxJenisWajibPajak As ComboBox
    Friend WithEvents LabelJenisWajibPajak As Label
    Friend WithEvents TextBoxNomorRegistrasi As TextBox
    Friend WithEvents LabelNomorRegistrasi As Label
    Friend WithEvents GroupBoxAlamat As GroupBox
    Friend WithEvents TextBoxAlamatLengkap As TextBox
    Friend WithEvents LabelAlamatLengkap As Label
    Friend WithEvents TextBoxProvinsi As TextBox
    Friend WithEvents LabelProvinsi As Label
    Friend WithEvents TextBoxKota As TextBox
    Friend WithEvents LabelKota As Label
    Friend WithEvents TextBoxKodePos As TextBox
    Friend WithEvents LabelKodePos As Label
    Friend WithEvents GroupBoxKontak As GroupBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxTelepon As TextBox
    Friend WithEvents LabelTelepon As Label
    Friend WithEvents GroupBoxKeluarga As GroupBox
    Friend WithEvents TextBoxNamaPasangan As TextBox
    Friend WithEvents LabelNamaPasangan As Label
    Friend WithEvents TextBoxJumlahTanggungan As TextBox
    Friend WithEvents LabelJumlahTanggungan As Label
    Friend WithEvents DataGridViewAnak As DataGridView
    Friend WithEvents ColNamaAnak As DataGridViewTextBoxColumn
    Friend WithEvents ColTanggalLahirAnak As DataGridViewTextBoxColumn
    Friend WithEvents ColStatusTanggungan As DataGridViewComboBoxColumn
    Friend WithEvents ButtonTambahAnak As Button
    Friend WithEvents ButtonHapusAnak As Button
    Friend WithEvents ButtonNavIkhtisar As Button
    Friend WithEvents ButtonNavInformasi As Button
    Friend WithEvents ButtonNavAlamat As Button
    Friend WithEvents ButtonNavKontak As Button
    Friend WithEvents ButtonNavKeluarga As Button
    Friend WithEvents LabelNavigationTitle As Label
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents ButtonBatal As Button

End Class
