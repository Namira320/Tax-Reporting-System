<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register_PK
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.grpInfoPerusahaan = New System.Windows.Forms.GroupBox()
        Me.lblNamaPT = New System.Windows.Forms.Label()
        Me.txtNamaPT = New System.Windows.Forms.TextBox()
        Me.lblEmailPT = New System.Windows.Forms.Label()
        Me.txtEmailPT = New System.Windows.Forms.TextBox()
        Me.grpInfoKuasa = New System.Windows.Forms.GroupBox()
        Me.lblNIKKuasa = New System.Windows.Forms.Label()
        Me.txtNIKKuasa = New System.Windows.Forms.TextBox()
        Me.lblNamaKuasa = New System.Windows.Forms.Label()
        Me.txtNamaKuasa = New System.Windows.Forms.TextBox()
        Me.lblNoTelpKuasa = New System.Windows.Forms.Label()
        Me.txtNoTelpKuasa = New System.Windows.Forms.TextBox()
        Me.grpAlamat = New System.Windows.Forms.GroupBox()
        Me.lblAlamatLengkap = New System.Windows.Forms.Label()
        Me.txtAlamatLengkap = New System.Windows.Forms.TextBox()
        Me.lblProvinsi = New System.Windows.Forms.Label()
        Me.cmbProvinsi = New System.Windows.Forms.ComboBox()
        Me.lblKota = New System.Windows.Forms.Label()
        Me.cmbKota = New System.Windows.Forms.ComboBox()
        Me.lblKecamatan = New System.Windows.Forms.Label()
        Me.cmbKecamatan = New System.Windows.Forms.ComboBox()
        Me.lblKelurahan = New System.Windows.Forms.Label()
        Me.cmbKelurahan = New System.Windows.Forms.ComboBox()
        Me.lblKodePos = New System.Windows.Forms.Label()
        Me.txtKodePos = New System.Windows.Forms.TextBox()
        Me.grpKaryawan = New System.Windows.Forms.GroupBox()
        Me.lblDaftarKaryawan = New System.Windows.Forms.Label()
        Me.dgvKaryawan = New System.Windows.Forms.DataGridView()
        Me.colNIK_NPWP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNamaKaryawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlKaryawanInput = New System.Windows.Forms.Panel()
        Me.lblNIK_NPWP = New System.Windows.Forms.Label()
        Me.txtNIK_NPWP = New System.Windows.Forms.TextBox()
        Me.btnTambahKaryawan = New System.Windows.Forms.Button()
        Me.btnHapusKaryawan = New System.Windows.Forms.Button()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.grpInfoPerusahaan.SuspendLayout()
        Me.grpInfoKuasa.SuspendLayout()
        Me.grpAlamat.SuspendLayout()
        Me.grpKaryawan.SuspendLayout()
        CType(Me.dgvKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKaryawanInput.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1400, 100)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Dubai", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(30, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(450, 54)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pendaftaran Pemberi Kerja"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(35, 65)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(350, 25)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Silakan lengkapi informasi perusahaan Anda"
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.grpInfoPerusahaan)
        Me.pnlMain.Controls.Add(Me.grpInfoKuasa)
        Me.pnlMain.Controls.Add(Me.grpAlamat)
        Me.pnlMain.Controls.Add(Me.grpKaryawan)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 100)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlMain.Size = New System.Drawing.Size(1400, 700)
        Me.pnlMain.TabIndex = 1
        '
        'grpInfoPerusahaan
        '
        Me.grpInfoPerusahaan.BackColor = System.Drawing.Color.White
        Me.grpInfoPerusahaan.Controls.Add(Me.lblNamaPT)
        Me.grpInfoPerusahaan.Controls.Add(Me.txtNamaPT)
        Me.grpInfoPerusahaan.Controls.Add(Me.lblEmailPT)
        Me.grpInfoPerusahaan.Controls.Add(Me.txtEmailPT)
        Me.grpInfoPerusahaan.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpInfoPerusahaan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.grpInfoPerusahaan.Location = New System.Drawing.Point(30, 30)
        Me.grpInfoPerusahaan.Name = "grpInfoPerusahaan"
        Me.grpInfoPerusahaan.Padding = New System.Windows.Forms.Padding(20)
        Me.grpInfoPerusahaan.Size = New System.Drawing.Size(650, 180)
        Me.grpInfoPerusahaan.TabIndex = 0
        Me.grpInfoPerusahaan.TabStop = False
        Me.grpInfoPerusahaan.Text = "Informasi Perusahaan"
        '
        'lblNamaPT
        '
        Me.lblNamaPT.AutoSize = True
        Me.lblNamaPT.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblNamaPT.Location = New System.Drawing.Point(20, 40)
        Me.lblNamaPT.Name = "lblNamaPT"
        Me.lblNamaPT.Size = New System.Drawing.Size(150, 25)
        Me.lblNamaPT.TabIndex = 0
        Me.lblNamaPT.Text = "Nama Perusahaan *"
        '
        'txtNamaPT
        '
        Me.txtNamaPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPT.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.txtNamaPT.Location = New System.Drawing.Point(20, 65)
        Me.txtNamaPT.Name = "txtNamaPT"
        Me.txtNamaPT.Size = New System.Drawing.Size(600, 32)
        Me.txtNamaPT.TabIndex = 1
        '
        'lblEmailPT
        '
        Me.lblEmailPT.AutoSize = True
        Me.lblEmailPT.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblEmailPT.Location = New System.Drawing.Point(20, 105)
        Me.lblEmailPT.Name = "lblEmailPT"
        Me.lblEmailPT.Size = New System.Drawing.Size(150, 25)
        Me.lblEmailPT.TabIndex = 2
        Me.lblEmailPT.Text = "Email Perusahaan *"
        '
        'txtEmailPT
        '
        Me.txtEmailPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailPT.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.txtEmailPT.Location = New System.Drawing.Point(20, 130)
        Me.txtEmailPT.Name = "txtEmailPT"
        Me.txtEmailPT.Size = New System.Drawing.Size(600, 32)
        Me.txtEmailPT.TabIndex = 3
        '
        'grpInfoKuasa
        '
        Me.grpInfoKuasa.BackColor = System.Drawing.Color.White
        Me.grpInfoKuasa.Controls.Add(Me.lblNIKKuasa)
        Me.grpInfoKuasa.Controls.Add(Me.txtNIKKuasa)
        Me.grpInfoKuasa.Controls.Add(Me.lblNamaKuasa)
        Me.grpInfoKuasa.Controls.Add(Me.txtNamaKuasa)
        Me.grpInfoKuasa.Controls.Add(Me.lblNoTelpKuasa)
        Me.grpInfoKuasa.Controls.Add(Me.txtNoTelpKuasa)
        Me.grpInfoKuasa.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpInfoKuasa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.grpInfoKuasa.Location = New System.Drawing.Point(700, 30)
        Me.grpInfoKuasa.Name = "grpInfoKuasa"
        Me.grpInfoKuasa.Padding = New System.Windows.Forms.Padding(20)
        Me.grpInfoKuasa.Size = New System.Drawing.Size(650, 280)
        Me.grpInfoKuasa.TabIndex = 1
        Me.grpInfoKuasa.TabStop = False
        Me.grpInfoKuasa.Text = "Informasi Kuasa (Opsional)"
        '
        'lblNIKKuasa
        '
        Me.lblNIKKuasa.AutoSize = True
        Me.lblNIKKuasa.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblNIKKuasa.Location = New System.Drawing.Point(20, 40)
        Me.lblNIKKuasa.Name = "lblNIKKuasa"
        Me.lblNIKKuasa.Size = New System.Drawing.Size(85, 25)
        Me.lblNIKKuasa.TabIndex = 0
        Me.lblNIKKuasa.Text = "NIK Kuasa"
        '
        'txtNIKKuasa
        '
        Me.txtNIKKuasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNIKKuasa.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.txtNIKKuasa.Location = New System.Drawing.Point(20, 65)
        Me.txtNIKKuasa.MaxLength = 16
        Me.txtNIKKuasa.Name = "txtNIKKuasa"
        Me.txtNIKKuasa.Size = New System.Drawing.Size(600, 32)
        Me.txtNIKKuasa.TabIndex = 1
        '
        'lblNamaKuasa
        '
        Me.lblNamaKuasa.AutoSize = True
        Me.lblNamaKuasa.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblNamaKuasa.Location = New System.Drawing.Point(20, 105)
        Me.lblNamaKuasa.Name = "lblNamaKuasa"
        Me.lblNamaKuasa.Size = New System.Drawing.Size(100, 25)
        Me.lblNamaKuasa.TabIndex = 2
        Me.lblNamaKuasa.Text = "Nama Kuasa"
        '
        'txtNamaKuasa
        '
        Me.txtNamaKuasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaKuasa.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.txtNamaKuasa.Location = New System.Drawing.Point(20, 130)
        Me.txtNamaKuasa.Name = "txtNamaKuasa"
        Me.txtNamaKuasa.ReadOnly = True
        Me.txtNamaKuasa.Size = New System.Drawing.Size(600, 32)
        Me.txtNamaKuasa.TabIndex = 3
        '
        'lblNoTelpKuasa
        '
        Me.lblNoTelpKuasa.AutoSize = True
        Me.lblNoTelpKuasa.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblNoTelpKuasa.Location = New System.Drawing.Point(20, 170)
        Me.lblNoTelpKuasa.Name = "lblNoTelpKuasa"
        Me.lblNoTelpKuasa.Size = New System.Drawing.Size(130, 25)
        Me.lblNoTelpKuasa.TabIndex = 4
        Me.lblNoTelpKuasa.Text = "No. Telp Kuasa"
        '
        'txtNoTelpKuasa
        '
        Me.txtNoTelpKuasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoTelpKuasa.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.txtNoTelpKuasa.Location = New System.Drawing.Point(20, 195)
        Me.txtNoTelpKuasa.Name = "txtNoTelpKuasa"
        Me.txtNoTelpKuasa.Size = New System.Drawing.Size(600, 32)
        Me.txtNoTelpKuasa.TabIndex = 5
        '
        'grpAlamat
        '
        Me.grpAlamat.BackColor = System.Drawing.Color.White
        Me.grpAlamat.Controls.Add(Me.lblAlamatLengkap)
        Me.grpAlamat.Controls.Add(Me.txtAlamatLengkap)
        Me.grpAlamat.Controls.Add(Me.lblProvinsi)
        Me.grpAlamat.Controls.Add(Me.cmbProvinsi)
        Me.grpAlamat.Controls.Add(Me.lblKota)
        Me.grpAlamat.Controls.Add(Me.cmbKota)
        Me.grpAlamat.Controls.Add(Me.lblKecamatan)
        Me.grpAlamat.Controls.Add(Me.cmbKecamatan)
        Me.grpAlamat.Controls.Add(Me.lblKelurahan)
        Me.grpAlamat.Controls.Add(Me.cmbKelurahan)
        Me.grpAlamat.Controls.Add(Me.lblKodePos)
        Me.grpAlamat.Controls.Add(Me.txtKodePos)
        Me.grpAlamat.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.grpAlamat.Location = New System.Drawing.Point(30, 230)
        Me.grpAlamat.Name = "grpAlamat"
        Me.grpAlamat.Padding = New System.Windows.Forms.Padding(20)
        Me.grpAlamat.Size = New System.Drawing.Size(650, 480)
        Me.grpAlamat.TabIndex = 2
        Me.grpAlamat.TabStop = False
        Me.grpAlamat.Text = "Alamat Perusahaan"
        '
        'lblAlamatLengkap
        '
        Me.lblAlamatLengkap.AutoSize = True
        Me.lblAlamatLengkap.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblAlamatLengkap.Location = New System.Drawing.Point(20, 40)
        Me.lblAlamatLengkap.Name = "lblAlamatLengkap"
        Me.lblAlamatLengkap.Size = New System.Drawing.Size(180, 25)
        Me.lblAlamatLengkap.TabIndex = 0
        Me.lblAlamatLengkap.Text = "Alamat Lengkap (Jalan, RT/RW)"
        '
        'txtAlamatLengkap
        '
        Me.txtAlamatLengkap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlamatLengkap.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.txtAlamatLengkap.Location = New System.Drawing.Point(20, 65)
        Me.txtAlamatLengkap.Multiline = True
        Me.txtAlamatLengkap.Name = "txtAlamatLengkap"
        Me.txtAlamatLengkap.Size = New System.Drawing.Size(600, 60)
        Me.txtAlamatLengkap.TabIndex = 1
        '
        'lblProvinsi
        '
        Me.lblProvinsi.AutoSize = True
        Me.lblProvinsi.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblProvinsi.Location = New System.Drawing.Point(20, 135)
        Me.lblProvinsi.Name = "lblProvinsi"
        Me.lblProvinsi.Size = New System.Drawing.Size(70, 25)
        Me.lblProvinsi.TabIndex = 2
        Me.lblProvinsi.Text = "Provinsi"
        '
        'cmbProvinsi
        '
        Me.cmbProvinsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvinsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProvinsi.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.cmbProvinsi.FormattingEnabled = True
        Me.cmbProvinsi.Location = New System.Drawing.Point(20, 160)
        Me.cmbProvinsi.Name = "cmbProvinsi"
        Me.cmbProvinsi.Size = New System.Drawing.Size(600, 33)
        Me.cmbProvinsi.TabIndex = 3
        '
        'lblKota
        '
        Me.lblKota.AutoSize = True
        Me.lblKota.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblKota.Location = New System.Drawing.Point(20, 200)
        Me.lblKota.Name = "lblKota"
        Me.lblKota.Size = New System.Drawing.Size(100, 25)
        Me.lblKota.TabIndex = 4
        Me.lblKota.Text = "Kota/Kabupaten"
        '
        'cmbKota
        '
        Me.cmbKota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKota.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.cmbKota.FormattingEnabled = True
        Me.cmbKota.Location = New System.Drawing.Point(20, 225)
        Me.cmbKota.Name = "cmbKota"
        Me.cmbKota.Size = New System.Drawing.Size(600, 33)
        Me.cmbKota.TabIndex = 5
        '
        'lblKecamatan
        '
        Me.lblKecamatan.AutoSize = True
        Me.lblKecamatan.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblKecamatan.Location = New System.Drawing.Point(20, 265)
        Me.lblKecamatan.Name = "lblKecamatan"
        Me.lblKecamatan.Size = New System.Drawing.Size(85, 25)
        Me.lblKecamatan.TabIndex = 6
        Me.lblKecamatan.Text = "Kecamatan"
        '
        'cmbKecamatan
        '
        Me.cmbKecamatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKecamatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKecamatan.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.cmbKecamatan.FormattingEnabled = True
        Me.cmbKecamatan.Location = New System.Drawing.Point(20, 290)
        Me.cmbKecamatan.Name = "cmbKecamatan"
        Me.cmbKecamatan.Size = New System.Drawing.Size(600, 33)
        Me.cmbKecamatan.TabIndex = 7
        '
        'lblKelurahan
        '
        Me.lblKelurahan.AutoSize = True
        Me.lblKelurahan.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblKelurahan.Location = New System.Drawing.Point(20, 330)
        Me.lblKelurahan.Name = "lblKelurahan"
        Me.lblKelurahan.Size = New System.Drawing.Size(75, 25)
        Me.lblKelurahan.TabIndex = 8
        Me.lblKelurahan.Text = "Kelurahan"
        '
        'cmbKelurahan
        '
        Me.cmbKelurahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKelurahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKelurahan.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.cmbKelurahan.FormattingEnabled = True
        Me.cmbKelurahan.Location = New System.Drawing.Point(20, 355)
        Me.cmbKelurahan.Name = "cmbKelurahan"
        Me.cmbKelurahan.Size = New System.Drawing.Size(600, 33)
        Me.cmbKelurahan.TabIndex = 9
        '
        'lblKodePos
        '
        Me.lblKodePos.AutoSize = True
        Me.lblKodePos.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblKodePos.Location = New System.Drawing.Point(20, 395)
        Me.lblKodePos.Name = "lblKodePos"
        Me.lblKodePos.Size = New System.Drawing.Size(70, 25)
        Me.lblKodePos.TabIndex = 10
        Me.lblKodePos.Text = "Kode Pos"
        '
        'txtKodePos
        '
        Me.txtKodePos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodePos.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.txtKodePos.Location = New System.Drawing.Point(20, 420)
        Me.txtKodePos.MaxLength = 5
        Me.txtKodePos.Name = "txtKodePos"
        Me.txtKodePos.Size = New System.Drawing.Size(200, 32)
        Me.txtKodePos.TabIndex = 11
        '
        'grpKaryawan
        '
        Me.grpKaryawan.BackColor = System.Drawing.Color.White
        Me.grpKaryawan.Controls.Add(Me.lblDaftarKaryawan)
        Me.grpKaryawan.Controls.Add(Me.dgvKaryawan)
        Me.grpKaryawan.Controls.Add(Me.pnlKaryawanInput)
        Me.grpKaryawan.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpKaryawan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.grpKaryawan.Location = New System.Drawing.Point(700, 330)
        Me.grpKaryawan.Name = "grpKaryawan"
        Me.grpKaryawan.Padding = New System.Windows.Forms.Padding(20)
        Me.grpKaryawan.Size = New System.Drawing.Size(650, 550)
        Me.grpKaryawan.TabIndex = 3
        Me.grpKaryawan.TabStop = False
        Me.grpKaryawan.Text = "Daftar Karyawan"
        '
        'lblDaftarKaryawan
        '
        Me.lblDaftarKaryawan.AutoSize = True
        Me.lblDaftarKaryawan.Font = New System.Drawing.Font("Dubai", 10.0!)
        Me.lblDaftarKaryawan.Location = New System.Drawing.Point(20, 40)
        Me.lblDaftarKaryawan.Name = "lblDaftarKaryawan"
        Me.lblDaftarKaryawan.Size = New System.Drawing.Size(250, 23)
        Me.lblDaftarKaryawan.TabIndex = 0
        Me.lblDaftarKaryawan.Text = "Masukkan NIK/NPWP karyawan"
        '
        'dgvKaryawan
        '
        Me.dgvKaryawan.AllowUserToAddRows = False
        Me.dgvKaryawan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKaryawan.BackgroundColor = System.Drawing.Color.White
        Me.dgvKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNIK_NPWP, Me.colNamaKaryawan})
        Me.dgvKaryawan.Location = New System.Drawing.Point(20, 70)
        Me.dgvKaryawan.Name = "dgvKaryawan"
        Me.dgvKaryawan.ReadOnly = True
        Me.dgvKaryawan.RowHeadersVisible = False
        Me.dgvKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKaryawan.Size = New System.Drawing.Size(600, 300)
        Me.dgvKaryawan.TabIndex = 1
        '
        'colNIK_NPWP
        '
        Me.colNIK_NPWP.HeaderText = "NIK/NPWP"
        Me.colNIK_NPWP.Name = "colNIK_NPWP"
        Me.colNIK_NPWP.ReadOnly = True
        '
        'colNamaKaryawan
        '
        Me.colNamaKaryawan.HeaderText = "Nama Karyawan"
        Me.colNamaKaryawan.Name = "colNamaKaryawan"
        Me.colNamaKaryawan.ReadOnly = True

        '
        'pnlKaryawanInput
        '
        Me.pnlKaryawanInput.Controls.Add(Me.lblNIK_NPWP)
        Me.pnlKaryawanInput.Controls.Add(Me.txtNIK_NPWP)
        Me.pnlKaryawanInput.Controls.Add(Me.btnTambahKaryawan)
        Me.pnlKaryawanInput.Controls.Add(Me.btnHapusKaryawan)
        Me.pnlKaryawanInput.Location = New System.Drawing.Point(20, 380)
        Me.pnlKaryawanInput.Name = "pnlKaryawanInput"
        Me.pnlKaryawanInput.Size = New System.Drawing.Size(600, 150)
        Me.pnlKaryawanInput.TabIndex = 2
        '
        'lblNIK_NPWP
        '
        Me.lblNIK_NPWP.AutoSize = True
        Me.lblNIK_NPWP.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.lblNIK_NPWP.Location = New System.Drawing.Point(0, 5)
        Me.lblNIK_NPWP.Name = "lblNIK_NPWP"
        Me.lblNIK_NPWP.Size = New System.Drawing.Size(150, 25)
        Me.lblNIK_NPWP.TabIndex = 0
        Me.lblNIK_NPWP.Text = "NIK/NPWP Karyawan"
        '
        'txtNIK_NPWP
        '
        Me.txtNIK_NPWP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNIK_NPWP.Font = New System.Drawing.Font("Dubai", 11.0!)
        Me.txtNIK_NPWP.Location = New System.Drawing.Point(0, 30)
        Me.txtNIK_NPWP.Name = "txtNIK_NPWP"
        Me.txtNIK_NPWP.Size = New System.Drawing.Size(280, 32)
        Me.txtNIK_NPWP.TabIndex = 1

        '
        'btnTambahKaryawan
        '
        Me.btnTambahKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnTambahKaryawan.FlatAppearance.BorderSize = 0
        Me.btnTambahKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahKaryawan.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambahKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnTambahKaryawan.Location = New System.Drawing.Point(0, 80)
        Me.btnTambahKaryawan.Name = "btnTambahKaryawan"
        Me.btnTambahKaryawan.Size = New System.Drawing.Size(200, 45)
        Me.btnTambahKaryawan.TabIndex = 4
        Me.btnTambahKaryawan.Text = "➕ Tambah Karyawan"
        Me.btnTambahKaryawan.UseVisualStyleBackColor = False
        '
        'btnHapusKaryawan
        '
        Me.btnHapusKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnHapusKaryawan.FlatAppearance.BorderSize = 0
        Me.btnHapusKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusKaryawan.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapusKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnHapusKaryawan.Location = New System.Drawing.Point(220, 80)
        Me.btnHapusKaryawan.Name = "btnHapusKaryawan"
        Me.btnHapusKaryawan.Size = New System.Drawing.Size(200, 45)
        Me.btnHapusKaryawan.TabIndex = 5
        Me.btnHapusKaryawan.Text = "🗑️ Hapus Karyawan"
        Me.btnHapusKaryawan.UseVisualStyleBackColor = False
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.White
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.btnBatal)
        Me.pnlFooter.Controls.Add(Me.btnDaftar)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 800)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1400, 80)
        Me.pnlFooter.TabIndex = 2
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(1050, 15)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(150, 50)
        Me.btnBatal.TabIndex = 0
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnDaftar
        '
        Me.btnDaftar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnDaftar.FlatAppearance.BorderSize = 0
        Me.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaftar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDaftar.ForeColor = System.Drawing.Color.White
        Me.btnDaftar.Location = New System.Drawing.Point(1220, 15)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(150, 50)
        Me.btnDaftar.TabIndex = 1
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.UseVisualStyleBackColor = False
        '
        'Register_PK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 880)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.Name = "Register_PK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendaftaran Pemberi Kerja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.grpInfoPerusahaan.ResumeLayout(False)
        Me.grpInfoPerusahaan.PerformLayout()
        Me.grpInfoKuasa.ResumeLayout(False)
        Me.grpInfoKuasa.PerformLayout()
        Me.grpAlamat.ResumeLayout(False)
        Me.grpAlamat.PerformLayout()
        Me.grpKaryawan.ResumeLayout(False)
        Me.grpKaryawan.PerformLayout()
        CType(Me.dgvKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKaryawanInput.ResumeLayout(False)
        Me.pnlKaryawanInput.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents grpInfoPerusahaan As GroupBox
    Friend WithEvents lblNamaPT As Label
    Friend WithEvents txtNamaPT As TextBox
    Friend WithEvents lblEmailPT As Label
    Friend WithEvents txtEmailPT As TextBox
    Friend WithEvents grpInfoKuasa As GroupBox
    Friend WithEvents lblNIKKuasa As Label
    Friend WithEvents txtNIKKuasa As TextBox
    Friend WithEvents lblNamaKuasa As Label
    Friend WithEvents txtNamaKuasa As TextBox
    Friend WithEvents lblNoTelpKuasa As Label
    Friend WithEvents txtNoTelpKuasa As TextBox
    Friend WithEvents grpAlamat As GroupBox
    Friend WithEvents lblAlamatLengkap As Label
    Friend WithEvents txtAlamatLengkap As TextBox
    Friend WithEvents lblProvinsi As Label
    Friend WithEvents cmbProvinsi As ComboBox
    Friend WithEvents lblKota As Label
    Friend WithEvents cmbKota As ComboBox
    Friend WithEvents lblKecamatan As Label
    Friend WithEvents cmbKecamatan As ComboBox
    Friend WithEvents lblKelurahan As Label
    Friend WithEvents cmbKelurahan As ComboBox
    Friend WithEvents lblKodePos As Label
    Friend WithEvents txtKodePos As TextBox
    Friend WithEvents grpKaryawan As GroupBox
    Friend WithEvents lblDaftarKaryawan As Label
    Friend WithEvents dgvKaryawan As DataGridView
    Friend WithEvents colNIK_NPWP As DataGridViewTextBoxColumn
    Friend WithEvents colNamaKaryawan As DataGridViewTextBoxColumn
    Friend WithEvents pnlKaryawanInput As Panel
    Friend WithEvents lblNIK_NPWP As Label
    Friend WithEvents txtNIK_NPWP As TextBox
    Friend WithEvents btnTambahKaryawan As Button
    Friend WithEvents btnHapusKaryawan As Button
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnDaftar As Button
End Class
