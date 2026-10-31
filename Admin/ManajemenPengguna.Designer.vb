<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManajemenPengguna
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components Is Not Nothing Then
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
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.grpDataAkun = New System.Windows.Forms.GroupBox()
        Me.btnNonAktifkan = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNPWP = New System.Windows.Forms.TextBox()
        Me.lblNPWP = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dgvPengguna = New System.Windows.Forms.DataGridView()
        Me.colNPWP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlLeft.SuspendLayout()
        Me.grpDataAkun.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.grpDataAkun)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlLeft.Size = New System.Drawing.Size(320, 500)
        Me.pnlLeft.TabIndex = 0
        '
        'grpDataAkun
        '
        Me.grpDataAkun.Controls.Add(Me.btnNonAktifkan)
        Me.grpDataAkun.Controls.Add(Me.btnReset)
        Me.grpDataAkun.Controls.Add(Me.btnSimpan)
        Me.grpDataAkun.Controls.Add(Me.cmbStatus)
        Me.grpDataAkun.Controls.Add(Me.lblStatus)
        Me.grpDataAkun.Controls.Add(Me.txtPassword)
        Me.grpDataAkun.Controls.Add(Me.lblPassword)
        Me.grpDataAkun.Controls.Add(Me.txtNama)
        Me.grpDataAkun.Controls.Add(Me.lblNama)
        Me.grpDataAkun.Controls.Add(Me.txtNPWP)
        Me.grpDataAkun.Controls.Add(Me.lblNPWP)
        Me.grpDataAkun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDataAkun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDataAkun.Location = New System.Drawing.Point(15, 15)
        Me.grpDataAkun.Name = "grpDataAkun"
        Me.grpDataAkun.Size = New System.Drawing.Size(290, 470)
        Me.grpDataAkun.TabIndex = 0
        Me.grpDataAkun.TabStop = False
        Me.grpDataAkun.Text = "Data Akun"
        '
        'btnNonAktifkan
        '
        Me.btnNonAktifkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnNonAktifkan.FlatAppearance.BorderSize = 0
        Me.btnNonAktifkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNonAktifkan.ForeColor = System.Drawing.Color.White
        Me.btnNonAktifkan.Location = New System.Drawing.Point(19, 304)
        Me.btnNonAktifkan.Name = "btnNonAktifkan"
        Me.btnNonAktifkan.Size = New System.Drawing.Size(250, 35)
        Me.btnNonAktifkan.TabIndex = 10
        Me.btnNonAktifkan.Text = "Non-aktifkan / Hapus"
        Me.btnNonAktifkan.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(159, 259)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 35)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(19, 259)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(130, 35)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Aktif", "Resign", "Pensiun"})
        Me.cmbStatus.Location = New System.Drawing.Point(19, 215)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(250, 23)
        Me.cmbStatus.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(16, 196)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(107, 15)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status Keanggotaan"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(19, 162)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(250, 21)
        Me.txtPassword.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(16, 143)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 15)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(19, 109)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(250, 21)
        Me.txtNama.TabIndex = 3
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(16, 90)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(83, 15)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama Lengkap"
        '
        'txtNPWP
        '
        Me.txtNPWP.Location = New System.Drawing.Point(19, 56)
        Me.txtNPWP.Name = "txtNPWP"
        Me.txtNPWP.Size = New System.Drawing.Size(250, 21)
        Me.txtNPWP.TabIndex = 1
        '
        'lblNPWP
        '
        Me.lblNPWP.AutoSize = True
        Me.lblNPWP.Location = New System.Drawing.Point(16, 37)
        Me.lblNPWP.Name = "lblNPWP"
        Me.lblNPWP.Size = New System.Drawing.Size(92, 15)
        Me.lblNPWP.TabIndex = 0
        Me.lblNPWP.Text = "NPWP / NIK (ID)"
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.lblCari)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.dgvPengguna)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(320, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlRight.Size = New System.Drawing.Size(640, 500)
        Me.pnlRight.TabIndex = 1
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblCari.Location = New System.Drawing.Point(18, 22)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(119, 15)
        Me.lblCari.TabIndex = 0
        Me.lblCari.Text = "Pencarian Wajib Pajak"
        '
        'txtCari
        '
        Me.txtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCari.Location = New System.Drawing.Point(21, 40)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(500, 20)
        Me.txtCari.TabIndex = 1
        '
        'btnCari
        '
        Me.btnCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(527, 36)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(90, 27)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'dgvPengguna
        '
        Me.dgvPengguna.AllowUserToAddRows = False
        Me.dgvPengguna.AllowUserToDeleteRows = False
        Me.dgvPengguna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPengguna.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNPWP, Me.colNama, Me.colStatus})
        Me.dgvPengguna.Location = New System.Drawing.Point(21, 80)
        Me.dgvPengguna.Name = "dgvPengguna"
        Me.dgvPengguna.ReadOnly = True
        Me.dgvPengguna.RowHeadersVisible = False
        Me.dgvPengguna.Size = New System.Drawing.Size(596, 396)
        Me.dgvPengguna.TabIndex = 3
        '
        'colNPWP
        '
        Me.colNPWP.DataPropertyName = "NPWP"
        Me.colNPWP.HeaderText = "NPWP / NIK"
        Me.colNPWP.Name = "colNPWP"
        Me.colNPWP.ReadOnly = True
        Me.colNPWP.Width = 180
        '
        'colNama
        '
        Me.colNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNama.DataPropertyName = "NamaLengkap"
        Me.colNama.HeaderText = "Nama Lengkap"
        Me.colNama.Name = "colNama"
        Me.colNama.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.DataPropertyName = "Status"
        Me.colStatus.HeaderText = "Status Akun"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 120
        '
        'ManajemenPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 500)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "ManajemenPengguna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Pengguna Wajib Pajak"
        Me.pnlLeft.ResumeLayout(False)
        Me.grpDataAkun.ResumeLayout(False)
        Me.grpDataAkun.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class

