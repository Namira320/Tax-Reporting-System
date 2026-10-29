<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengaturan_AD
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
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.cmbStatusFilter = New System.Windows.Forms.ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.dgvMonitoring = New System.Windows.Forms.DataGridView()
        Me.colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKontak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPajak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatusBayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpNotifikasi = New System.Windows.Forms.GroupBox()
        Me.btnKirimNotifikasi = New System.Windows.Forms.Button()
        Me.rtbPesan = New System.Windows.Forms.RichTextBox()
        Me.lblPesan = New System.Windows.Forms.Label()
        Me.grpFilter.SuspendLayout()
        CType(Me.dgvMonitoring, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNotifikasi.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.btnTampilkan)
        Me.grpFilter.Controls.Add(Me.cmbStatusFilter)
        Me.grpFilter.Controls.Add(Me.lblFilter)
        Me.grpFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.grpFilter.Location = New System.Drawing.Point(0, 0)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Padding = New System.Windows.Forms.Padding(15)
        Me.grpFilter.Size = New System.Drawing.Size(900, 90)
        Me.grpFilter.TabIndex = 0
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter Status Pajak"
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTampilkan.FlatAppearance.BorderSize = 0
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.Location = New System.Drawing.Point(720, 37)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(150, 30)
        Me.btnTampilkan.TabIndex = 2
        Me.btnTampilkan.Text = "Tampilkan Data"
        Me.btnTampilkan.UseVisualStyleBackColor = False
        '
        'cmbStatusFilter
        '
        Me.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusFilter.FormattingEnabled = True
        Me.cmbStatusFilter.Items.AddRange(New Object() {"Semua User", "Kurang Bayar", "Lebih Bayar", "Nihil"})
        Me.cmbStatusFilter.Location = New System.Drawing.Point(160, 40)
        Me.cmbStatusFilter.Name = "cmbStatusFilter"
        Me.cmbStatusFilter.Size = New System.Drawing.Size(300, 23)
        Me.cmbStatusFilter.TabIndex = 1
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(18, 43)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(124, 15)
        Me.lblFilter.TabIndex = 0
        Me.lblFilter.Text = "Pilih Status Simulasi:"
        '
        'dgvMonitoring
        '
        Me.dgvMonitoring.AllowUserToAddRows = False
        Me.dgvMonitoring.AllowUserToDeleteRows = False
        Me.dgvMonitoring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonitoring.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNama, Me.colKontak, Me.colTotalPajak, Me.colStatusBayar})
        Me.dgvMonitoring.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMonitoring.Location = New System.Drawing.Point(0, 90)
        Me.dgvMonitoring.Name = "dgvMonitoring"
        Me.dgvMonitoring.ReadOnly = True
        Me.dgvMonitoring.RowHeadersVisible = False
        Me.dgvMonitoring.Size = New System.Drawing.Size(900, 360)
        Me.dgvMonitoring.TabIndex = 1
        '
        'colNama
        '
        Me.colNama.DataPropertyName = "NamaWP"
        Me.colNama.HeaderText = "Nama WP"
        Me.colNama.Name = "colNama"
        Me.colNama.ReadOnly = True
        Me.colNama.Width = 220
        '
        'colKontak
        '
        Me.colKontak.DataPropertyName = "Kontak"
        Me.colKontak.HeaderText = "Nomor HP / Email"
        Me.colKontak.Name = "colKontak"
        Me.colKontak.ReadOnly = True
        Me.colKontak.Width = 200
        '
        'colTotalPajak
        '
        Me.colTotalPajak.DataPropertyName = "TotalPajak"
        Me.colTotalPajak.HeaderText = "Total Pajak"
        Me.colTotalPajak.Name = "colTotalPajak"
        Me.colTotalPajak.ReadOnly = True
        Me.colTotalPajak.Width = 150
        '
        'colStatusBayar
        '
        Me.colStatusBayar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStatusBayar.DataPropertyName = "StatusBayar"
        Me.colStatusBayar.HeaderText = "Status Bayar"
        Me.colStatusBayar.Name = "colStatusBayar"
        Me.colStatusBayar.ReadOnly = True
        '
        'grpNotifikasi
        '
        Me.grpNotifikasi.Controls.Add(Me.btnKirimNotifikasi)
        Me.grpNotifikasi.Controls.Add(Me.rtbPesan)
        Me.grpNotifikasi.Controls.Add(Me.lblPesan)
        Me.grpNotifikasi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpNotifikasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.grpNotifikasi.Location = New System.Drawing.Point(0, 450)
        Me.grpNotifikasi.Name = "grpNotifikasi"
        Me.grpNotifikasi.Padding = New System.Windows.Forms.Padding(15)
        Me.grpNotifikasi.Size = New System.Drawing.Size(900, 200)
        Me.grpNotifikasi.TabIndex = 2
        Me.grpNotifikasi.TabStop = False
        Me.grpNotifikasi.Text = "Panel Notifikasi"
        '
        'btnKirimNotifikasi
        '
        Me.btnKirimNotifikasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKirimNotifikasi.AutoEllipsis = False
        Me.btnKirimNotifikasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnKirimNotifikasi.FlatAppearance.BorderSize = 0
        Me.btnKirimNotifikasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKirimNotifikasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKirimNotifikasi.ForeColor = System.Drawing.Color.White
        Me.btnKirimNotifikasi.Location = New System.Drawing.Point(660, 140)
        Me.btnKirimNotifikasi.Name = "btnKirimNotifikasi"
        Me.btnKirimNotifikasi.Size = New System.Drawing.Size(210, 40)
        Me.btnKirimNotifikasi.TabIndex = 2
        Me.btnKirimNotifikasi.Text = "Kirim Notifikasi"
        Me.btnKirimNotifikasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnKirimNotifikasi.UseVisualStyleBackColor = False
        '
        'rtbPesan
        '
        Me.rtbPesan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPesan.Location = New System.Drawing.Point(21, 60)
        Me.rtbPesan.Name = "rtbPesan"
        Me.rtbPesan.Size = New System.Drawing.Size(848, 70)
        Me.rtbPesan.TabIndex = 1
        Me.rtbPesan.Text = ""
        '
        'lblPesan
        '
        Me.lblPesan.AutoSize = True
        Me.lblPesan.Location = New System.Drawing.Point(18, 35)
        Me.lblPesan.Name = "lblPesan"
        Me.lblPesan.Size = New System.Drawing.Size(213, 15)
        Me.lblPesan.TabIndex = 0
        Me.lblPesan.Text = "Pesan Notifikasi (akan dikirim massal):"
        '
        'Pengaturan_AD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 650)
        Me.Controls.Add(Me.dgvMonitoring)
        Me.Controls.Add(Me.grpFilter)
        Me.Controls.Add(Me.grpNotifikasi)
        Me.MinimumSize = New System.Drawing.Size(850, 600)
        Me.Name = "Pengaturan_AD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring Status Simulasi & Notifikasi"
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        CType(Me.dgvMonitoring, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNotifikasi.ResumeLayout(False)
        Me.grpNotifikasi.PerformLayout()
        Me.ResumeLayout(False)

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
End Class

