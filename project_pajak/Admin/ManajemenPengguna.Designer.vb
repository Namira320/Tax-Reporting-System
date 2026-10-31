Namespace Admin
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ManajemenPengguna
        Inherits System.Windows.Forms.Form

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            pnlLeft = New Panel()
            grpDataAkun = New GroupBox()
            btnKembali = New Button()
            btnNonAktifkan = New Button()
            btnReset = New Button()
            btnSimpan = New Button()
            cmbStatus = New ComboBox()
            lblStatus = New Label()
            txtPassword = New TextBox()
            lblPassword = New Label()
            txtNama = New TextBox()
            lblNama = New Label()
            txtNPWP = New TextBox()
            lblNPWP = New Label()
            pnlRight = New Panel()
            lblCari = New Label()
            txtCari = New TextBox()
            btnCari = New Button()
            dgvPengguna = New DataGridView()
            colNPWP = New DataGridViewTextBoxColumn()
            colNama = New DataGridViewTextBoxColumn()
            colStatus = New DataGridViewTextBoxColumn()
            pnlLeft.SuspendLayout()
            grpDataAkun.SuspendLayout()
            pnlRight.SuspendLayout()
            CType(dgvPengguna, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' pnlLeft
            ' 
            pnlLeft.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
            pnlLeft.Controls.Add(grpDataAkun)
            pnlLeft.Dock = DockStyle.Left
            pnlLeft.Location = New Point(0, 0)
            pnlLeft.Margin = New Padding(5, 6, 5, 6)
            pnlLeft.Name = "pnlLeft"
            pnlLeft.Padding = New Padding(25, 29, 25, 29)
            pnlLeft.Size = New Size(533, 820)
            pnlLeft.TabIndex = 0
            ' 
            ' grpDataAkun
            ' 
            grpDataAkun.Controls.Add(btnKembali)
            grpDataAkun.Controls.Add(btnNonAktifkan)
            grpDataAkun.Controls.Add(btnReset)
            grpDataAkun.Controls.Add(btnSimpan)
            grpDataAkun.Controls.Add(cmbStatus)
            grpDataAkun.Controls.Add(lblStatus)
            grpDataAkun.Controls.Add(txtPassword)
            grpDataAkun.Controls.Add(lblPassword)
            grpDataAkun.Controls.Add(txtNama)
            grpDataAkun.Controls.Add(lblNama)
            grpDataAkun.Controls.Add(txtNPWP)
            grpDataAkun.Controls.Add(lblNPWP)
            grpDataAkun.Dock = DockStyle.Fill
            grpDataAkun.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            grpDataAkun.Location = New Point(25, 29)
            grpDataAkun.Margin = New Padding(5, 6, 5, 6)
            grpDataAkun.Name = "grpDataAkun"
            grpDataAkun.Padding = New Padding(5, 6, 5, 6)
            grpDataAkun.Size = New Size(483, 762)
            grpDataAkun.TabIndex = 0
            grpDataAkun.TabStop = False
            grpDataAkun.Text = "Data Akun"
            ' 
            ' btnKembali
            ' 
            btnKembali.BackColor = Color.WhiteSmoke
            btnKembali.FlatStyle = FlatStyle.Flat
            btnKembali.Location = New Point(32, 648)
            btnKembali.Margin = New Padding(5, 6, 5, 6)
            btnKembali.Name = "btnKembali"
            btnKembali.Size = New Size(419, 67)
            btnKembali.TabIndex = 11
            btnKembali.Text = "Kembali"
            btnKembali.UseVisualStyleBackColor = False
            ' 
            ' btnNonAktifkan
            ' 
            btnNonAktifkan.BackColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
            btnNonAktifkan.FlatAppearance.BorderSize = 0
            btnNonAktifkan.FlatStyle = FlatStyle.Flat
            btnNonAktifkan.ForeColor = Color.White
            btnNonAktifkan.Location = New Point(32, 566)
            btnNonAktifkan.Margin = New Padding(5, 6, 5, 6)
            btnNonAktifkan.Name = "btnNonAktifkan"
            btnNonAktifkan.Size = New Size(417, 70)
            btnNonAktifkan.TabIndex = 10
            btnNonAktifkan.Text = "Non-aktifkan / Hapus"
            btnNonAktifkan.UseVisualStyleBackColor = False
            ' 
            ' btnReset
            ' 
            btnReset.BackColor = Color.WhiteSmoke
            btnReset.FlatStyle = FlatStyle.Flat
            btnReset.Location = New Point(265, 491)
            btnReset.Margin = New Padding(5, 6, 5, 6)
            btnReset.Name = "btnReset"
            btnReset.Size = New Size(183, 63)
            btnReset.TabIndex = 9
            btnReset.Text = "Setel Ulang"
            btnReset.UseVisualStyleBackColor = False
            ' 
            ' btnSimpan
            ' 
            btnSimpan.BackColor = Color.FromArgb(CByte(2), CByte(136), CByte(209))
            btnSimpan.FlatAppearance.BorderSize = 0
            btnSimpan.FlatStyle = FlatStyle.Flat
            btnSimpan.ForeColor = Color.White
            btnSimpan.Location = New Point(32, 491)
            btnSimpan.Margin = New Padding(5, 6, 5, 6)
            btnSimpan.Name = "btnSimpan"
            btnSimpan.Size = New Size(217, 63)
            btnSimpan.TabIndex = 8
            btnSimpan.Text = "Simpan"
            btnSimpan.UseVisualStyleBackColor = False
            ' 
            ' cmbStatus
            ' 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
            cmbStatus.FormattingEnabled = True
            cmbStatus.Items.AddRange(New Object() {"Aktif", "Resign", "Pensiun"})
            cmbStatus.Location = New Point(32, 413)
            cmbStatus.Margin = New Padding(5, 6, 5, 6)
            cmbStatus.Name = "cmbStatus"
            cmbStatus.Size = New Size(414, 45)
            cmbStatus.TabIndex = 7
            ' 
            ' lblStatus
            ' 
            lblStatus.AutoSize = True
            lblStatus.Location = New Point(27, 377)
            lblStatus.Margin = New Padding(5, 0, 5, 0)
            lblStatus.Name = "lblStatus"
            lblStatus.Size = New Size(196, 37)
            lblStatus.TabIndex = 6
            lblStatus.Text = "Status Keanggotaan"
            ' 
            ' txtPassword
            ' 
            txtPassword.Location = New Point(32, 312)
            txtPassword.Margin = New Padding(5, 6, 5, 6)
            txtPassword.Name = "txtPassword"
            txtPassword.PasswordChar = "*"c
            txtPassword.Size = New Size(414, 45)
            txtPassword.TabIndex = 5
            ' 
            ' lblPassword
            ' 
            lblPassword.AutoSize = True
            lblPassword.Location = New Point(27, 275)
            lblPassword.Margin = New Padding(5, 0, 5, 0)
            lblPassword.Name = "lblPassword"
            lblPassword.Size = New Size(102, 37)
            lblPassword.TabIndex = 4
            lblPassword.Text = "Password"
            ' 
            ' txtNama
            ' 
            txtNama.Location = New Point(32, 210)
            txtNama.Margin = New Padding(5, 6, 5, 6)
            txtNama.Name = "txtNama"
            txtNama.Size = New Size(414, 45)
            txtNama.TabIndex = 3
            ' 
            ' lblNama
            ' 
            lblNama.AutoSize = True
            lblNama.Location = New Point(27, 173)
            lblNama.Margin = New Padding(5, 0, 5, 0)
            lblNama.Name = "lblNama"
            lblNama.Size = New Size(148, 37)
            lblNama.TabIndex = 2
            lblNama.Text = "Nama Lengkap"
            ' 
            ' txtNPWP
            ' 
            txtNPWP.Location = New Point(32, 108)
            txtNPWP.Margin = New Padding(5, 6, 5, 6)
            txtNPWP.Name = "txtNPWP"
            txtNPWP.Size = New Size(414, 45)
            txtNPWP.TabIndex = 1
            ' 
            ' lblNPWP
            ' 
            lblNPWP.AutoSize = True
            lblNPWP.Location = New Point(27, 71)
            lblNPWP.Margin = New Padding(5, 0, 5, 0)
            lblNPWP.Name = "lblNPWP"
            lblNPWP.Size = New Size(173, 37)
            lblNPWP.TabIndex = 0
            lblNPWP.Text = "NPWP / NIK (ID)"
            ' 
            ' pnlRight
            ' 
            pnlRight.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
            pnlRight.Controls.Add(lblCari)
            pnlRight.Controls.Add(txtCari)
            pnlRight.Controls.Add(btnCari)
            pnlRight.Controls.Add(dgvPengguna)
            pnlRight.Dock = DockStyle.Fill
            pnlRight.Location = New Point(533, 0)
            pnlRight.Margin = New Padding(5, 6, 5, 6)
            pnlRight.Name = "pnlRight"
            pnlRight.Padding = New Padding(25, 29, 25, 29)
            pnlRight.Size = New Size(930, 820)
            pnlRight.TabIndex = 1
            ' 
            ' lblCari
            ' 
            lblCari.AutoSize = True
            lblCari.Font = New Font("Dubai", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            lblCari.Location = New Point(30, 34)
            lblCari.Margin = New Padding(5, 0, 5, 0)
            lblCari.Name = "lblCari"
            lblCari.Size = New Size(231, 40)
            lblCari.TabIndex = 0
            lblCari.Text = "Pencarian Wajib Pajak"
            ' 
            ' txtCari
            ' 
            txtCari.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            txtCari.Location = New Point(35, 77)
            txtCari.Margin = New Padding(5, 6, 5, 6)
            txtCari.Name = "txtCari"
            txtCari.Size = New Size(694, 31)
            txtCari.TabIndex = 1
            ' 
            ' btnCari
            ' 
            btnCari.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnCari.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
            btnCari.FlatAppearance.BorderSize = 0
            btnCari.FlatStyle = FlatStyle.Flat
            btnCari.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btnCari.ForeColor = Color.White
            btnCari.Location = New Point(739, 70)
            btnCari.Margin = New Padding(5, 6, 5, 6)
            btnCari.Name = "btnCari"
            btnCari.Size = New Size(134, 48)
            btnCari.TabIndex = 2
            btnCari.Text = "Cari"
            btnCari.UseVisualStyleBackColor = False
            ' 
            ' dgvPengguna
            ' 
            dgvPengguna.AllowUserToAddRows = False
            dgvPengguna.AllowUserToDeleteRows = False
            dgvPengguna.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            dgvPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgvPengguna.Columns.AddRange(New DataGridViewColumn() {colNPWP, colNama, colStatus})
            dgvPengguna.Location = New Point(35, 154)
            dgvPengguna.Margin = New Padding(5, 6, 5, 6)
            dgvPengguna.Name = "dgvPengguna"
            dgvPengguna.ReadOnly = True
            dgvPengguna.RowHeadersVisible = False
            dgvPengguna.RowHeadersWidth = 62
            dgvPengguna.Size = New Size(856, 620)
            dgvPengguna.TabIndex = 3
            ' 
            ' colNPWP
            ' 
            colNPWP.DataPropertyName = "NPWP"
            colNPWP.HeaderText = "NPWP / NIK"
            colNPWP.MinimumWidth = 8
            colNPWP.Name = "colNPWP"
            colNPWP.ReadOnly = True
            colNPWP.Width = 180
            ' 
            ' colNama
            ' 
            colNama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            colNama.DataPropertyName = "NamaLengkap"
            colNama.HeaderText = "Nama Lengkap"
            colNama.MinimumWidth = 8
            colNama.Name = "colNama"
            colNama.ReadOnly = True
            ' 
            ' colStatus
            ' 
            colStatus.DataPropertyName = "Status"
            colStatus.HeaderText = "Status Akun"
            colStatus.MinimumWidth = 8
            colStatus.Name = "colStatus"
            colStatus.ReadOnly = True
            colStatus.Width = 120
            ' 
            ' ManajemenPengguna
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(1463, 820)
            Controls.Add(pnlRight)
            Controls.Add(pnlLeft)
            Margin = New Padding(5, 6, 5, 6)
            MinimumSize = New Size(1480, 798)
            Name = "ManajemenPengguna"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Manajemen Pengguna Wajib Pajak"
            WindowState = FormWindowState.Maximized
            pnlLeft.ResumeLayout(False)
            grpDataAkun.ResumeLayout(False)
            grpDataAkun.PerformLayout()
            pnlRight.ResumeLayout(False)
            pnlRight.PerformLayout()
            CType(dgvPengguna, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

        Friend WithEvents pnlLeft As System.Windows.Forms.Panel
        Friend WithEvents grpDataAkun As System.Windows.Forms.GroupBox
        Friend WithEvents btnNonAktifkan As System.Windows.Forms.Button
        Friend WithEvents btnReset As System.Windows.Forms.Button
        Friend WithEvents btnSimpan As System.Windows.Forms.Button
        Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
        Friend WithEvents lblStatus As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtNama As System.Windows.Forms.TextBox
        Friend WithEvents lblNama As System.Windows.Forms.Label
        Friend WithEvents txtNPWP As System.Windows.Forms.TextBox
        Friend WithEvents lblNPWP As System.Windows.Forms.Label
        Friend WithEvents pnlRight As System.Windows.Forms.Panel
        Friend WithEvents lblCari As System.Windows.Forms.Label
        Friend WithEvents txtCari As System.Windows.Forms.TextBox
        Friend WithEvents btnCari As System.Windows.Forms.Button
        Friend WithEvents dgvPengguna As System.Windows.Forms.DataGridView
        Friend WithEvents colNPWP As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnKembali As Button
    End Class
End Namespace

