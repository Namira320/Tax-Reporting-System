Namespace Admin
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Pengaturan_AD
        Inherits System.Windows.Forms.Form

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            grpFilter = New GroupBox()
            btnTampilkan = New Button()
            cmbStatusFilter = New ComboBox()
            lblFilter = New Label()
            dgvMonitoring = New DataGridView()
            colNama = New DataGridViewTextBoxColumn()
            colKontak = New DataGridViewTextBoxColumn()
            colTotalPajak = New DataGridViewTextBoxColumn()
            colStatusBayar = New DataGridViewTextBoxColumn()
            grpNotifikasi = New GroupBox()
            btnKirimNotifikasi = New Button()
            btnKembali = New Button()
            rtbPesan = New RichTextBox()
            lblPesan = New Label()
            Panel1 = New Panel()
            grpFilter.SuspendLayout()
            CType(dgvMonitoring, ComponentModel.ISupportInitialize).BeginInit()
            grpNotifikasi.SuspendLayout()
            Panel1.SuspendLayout()
            SuspendLayout()
            ' 
            ' grpFilter
            ' 
            grpFilter.BackColor = Color.FromArgb(CByte(28), CByte(110), CByte(164))
            grpFilter.Controls.Add(btnTampilkan)
            grpFilter.Controls.Add(cmbStatusFilter)
            grpFilter.Controls.Add(lblFilter)
            grpFilter.Dock = DockStyle.Top
            grpFilter.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            grpFilter.ForeColor = Color.White
            grpFilter.Location = New Point(0, 0)
            grpFilter.Margin = New Padding(5, 6, 5, 6)
            grpFilter.Name = "grpFilter"
            grpFilter.Padding = New Padding(25, 29, 25, 29)
            grpFilter.Size = New Size(1480, 173)
            grpFilter.TabIndex = 0
            grpFilter.TabStop = False
            grpFilter.Text = "Filter Status Pajak"
            ' 
            ' btnTampilkan
            ' 
            btnTampilkan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnTampilkan.BackColor = Color.FromArgb(CByte(67), CByte(160), CByte(71))
            btnTampilkan.FlatAppearance.BorderSize = 0
            btnTampilkan.FlatStyle = FlatStyle.Flat
            btnTampilkan.ForeColor = Color.White
            btnTampilkan.Location = New Point(1180, 77)
            btnTampilkan.Margin = New Padding(5, 6, 5, 6)
            btnTampilkan.Name = "btnTampilkan"
            btnTampilkan.Size = New Size(250, 52)
            btnTampilkan.TabIndex = 2
            btnTampilkan.Text = "Tampilkan Data"
            btnTampilkan.UseVisualStyleBackColor = False
            ' 
            ' cmbStatusFilter
            ' 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
            cmbStatusFilter.FormattingEnabled = True
            cmbStatusFilter.Items.AddRange(New Object() {"Semua User", "Kurang Bayar", "Lebih Bayar", "Nihil"})
            cmbStatusFilter.Location = New Point(267, 77)
            cmbStatusFilter.Margin = New Padding(5, 6, 5, 6)
            cmbStatusFilter.Name = "cmbStatusFilter"
            cmbStatusFilter.Size = New Size(497, 45)
            cmbStatusFilter.TabIndex = 1
            ' 
            ' lblFilter
            ' 
            lblFilter.AutoSize = True
            lblFilter.ForeColor = Color.White
            lblFilter.Location = New Point(30, 83)
            lblFilter.Margin = New Padding(5, 0, 5, 0)
            lblFilter.Name = "lblFilter"
            lblFilter.Size = New Size(201, 37)
            lblFilter.TabIndex = 0
            lblFilter.Text = "Pilih Status Simulasi:"
            ' 
            ' dgvMonitoring
            ' 
            dgvMonitoring.AllowUserToAddRows = False
            dgvMonitoring.AllowUserToDeleteRows = False
            dgvMonitoring.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgvMonitoring.Columns.AddRange(New DataGridViewColumn() {colNama, colKontak, colTotalPajak, colStatusBayar})
            dgvMonitoring.Dock = DockStyle.Fill
            dgvMonitoring.Location = New Point(0, 173)
            dgvMonitoring.Margin = New Padding(5, 6, 5, 6)
            dgvMonitoring.Name = "dgvMonitoring"
            dgvMonitoring.ReadOnly = True
            dgvMonitoring.RowHeadersVisible = False
            dgvMonitoring.RowHeadersWidth = 62
            dgvMonitoring.Size = New Size(1480, 262)
            dgvMonitoring.TabIndex = 1
            ' 
            ' colNama
            ' 
            colNama.DataPropertyName = "NamaWP"
            colNama.HeaderText = "Nama WP"
            colNama.MinimumWidth = 8
            colNama.Name = "colNama"
            colNama.ReadOnly = True
            colNama.Width = 220
            ' 
            ' colKontak
            ' 
            colKontak.DataPropertyName = "Kontak"
            colKontak.HeaderText = "Nomor HP / Email"
            colKontak.MinimumWidth = 8
            colKontak.Name = "colKontak"
            colKontak.ReadOnly = True
            colKontak.Width = 200
            ' 
            ' colTotalPajak
            ' 
            colTotalPajak.DataPropertyName = "TotalPajak"
            colTotalPajak.HeaderText = "Total Pajak"
            colTotalPajak.MinimumWidth = 8
            colTotalPajak.Name = "colTotalPajak"
            colTotalPajak.ReadOnly = True
            colTotalPajak.Width = 150
            ' 
            ' colStatusBayar
            ' 
            colStatusBayar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            colStatusBayar.DataPropertyName = "StatusBayar"
            colStatusBayar.HeaderText = "Status Bayar"
            colStatusBayar.MinimumWidth = 8
            colStatusBayar.Name = "colStatusBayar"
            colStatusBayar.ReadOnly = True
            ' 
            ' grpNotifikasi
            ' 
            grpNotifikasi.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
            grpNotifikasi.BackgroundImageLayout = ImageLayout.Stretch
            grpNotifikasi.Controls.Add(Panel1)
            grpNotifikasi.Controls.Add(rtbPesan)
            grpNotifikasi.Controls.Add(lblPesan)
            grpNotifikasi.Dock = DockStyle.Bottom
            grpNotifikasi.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            grpNotifikasi.Location = New Point(0, 435)
            grpNotifikasi.Margin = New Padding(5, 6, 5, 6)
            grpNotifikasi.Name = "grpNotifikasi"
            grpNotifikasi.Padding = New Padding(25, 29, 25, 29)
            grpNotifikasi.Size = New Size(1480, 385)
            grpNotifikasi.TabIndex = 2
            grpNotifikasi.TabStop = False
            grpNotifikasi.Text = "Panel Notifikasi"
            ' 
            ' btnKirimNotifikasi
            ' 
            btnKirimNotifikasi.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            btnKirimNotifikasi.BackColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
            btnKirimNotifikasi.FlatAppearance.BorderSize = 0
            btnKirimNotifikasi.FlatStyle = FlatStyle.Flat
            btnKirimNotifikasi.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btnKirimNotifikasi.ForeColor = Color.White
            btnKirimNotifikasi.Location = New Point(5, 6)
            btnKirimNotifikasi.Margin = New Padding(5, 6, 5, 6)
            btnKirimNotifikasi.Name = "btnKirimNotifikasi"
            btnKirimNotifikasi.Size = New Size(328, 60)
            btnKirimNotifikasi.TabIndex = 2
            btnKirimNotifikasi.Text = "Kirim Notifikasi ke Daftar Terpilih"
            btnKirimNotifikasi.UseVisualStyleBackColor = False
            ' 
            ' btnKembali
            ' 
            btnKembali.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            btnKembali.BackColor = Color.FromArgb(CByte(7), CByte(71), CByte(166))
            btnKembali.Cursor = Cursors.Hand
            btnKembali.FlatAppearance.BorderSize = 0
            btnKembali.FlatStyle = FlatStyle.Flat
            btnKembali.Font = New Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btnKembali.ForeColor = Color.White
            btnKembali.Location = New Point(347, 5)
            btnKembali.Name = "btnKembali"
            btnKembali.Size = New Size(282, 60)
            btnKembali.TabIndex = 3
            btnKembali.Text = "Kembali ke Dashboard"
            btnKembali.UseVisualStyleBackColor = False
            ' 
            ' rtbPesan
            ' 
            rtbPesan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            rtbPesan.Location = New Point(35, 115)
            rtbPesan.Margin = New Padding(5, 6, 5, 6)
            rtbPesan.Name = "rtbPesan"
            rtbPesan.Size = New Size(1415, 131)
            rtbPesan.TabIndex = 1
            rtbPesan.Text = ""
            ' 
            ' lblPesan
            ' 
            lblPesan.AutoSize = True
            lblPesan.Location = New Point(30, 67)
            lblPesan.Margin = New Padding(5, 0, 5, 0)
            lblPesan.Name = "lblPesan"
            lblPesan.Size = New Size(325, 34)
            lblPesan.TabIndex = 0
            lblPesan.Text = "Pesan Notifikasi (akan dikirim massal):"
            ' 
            ' Panel1
            ' 
            Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            Panel1.Controls.Add(btnKirimNotifikasi)
            Panel1.Controls.Add(btnKembali)
            Panel1.Location = New Point(826, 255)
            Panel1.Name = "Panel1"
            Panel1.Size = New Size(642, 68)
            Panel1.TabIndex = 4
            ' 
            ' Pengaturan_AD
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(1480, 820)
            Controls.Add(dgvMonitoring)
            Controls.Add(grpFilter)
            Controls.Add(grpNotifikasi)
            Margin = New Padding(5, 6, 5, 6)
            MinimumSize = New Size(1401, 798)
            Name = "Pengaturan_AD"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Monitoring Status Simulasi & Notifikasi"
            WindowState = FormWindowState.Maximized
            grpFilter.ResumeLayout(False)
            grpFilter.PerformLayout()
            CType(dgvMonitoring, ComponentModel.ISupportInitialize).EndInit()
            grpNotifikasi.ResumeLayout(False)
            grpNotifikasi.PerformLayout()
            Panel1.ResumeLayout(False)
            ResumeLayout(False)

        End Sub

        Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
        Friend WithEvents btnTampilkan As System.Windows.Forms.Button
        Friend WithEvents cmbStatusFilter As System.Windows.Forms.ComboBox
        Friend WithEvents lblFilter As System.Windows.Forms.Label
        Friend WithEvents dgvMonitoring As System.Windows.Forms.DataGridView
        Friend WithEvents grpNotifikasi As System.Windows.Forms.GroupBox
        Friend WithEvents btnKirimNotifikasi As System.Windows.Forms.Button
        Friend WithEvents rtbPesan As System.Windows.Forms.RichTextBox
        Friend WithEvents lblPesan As System.Windows.Forms.Label
        Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colKontak As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colTotalPajak As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colStatusBayar As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnKembali As Button
        Friend WithEvents Panel1 As Panel
    End Class
End Namespace

