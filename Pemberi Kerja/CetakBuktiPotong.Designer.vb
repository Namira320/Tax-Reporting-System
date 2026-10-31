<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CetakBuktiPotong
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.cmbKaryawan = New System.Windows.Forms.ComboBox()
        Me.lblPilihKaryawan = New System.Windows.Forms.Label()
        Me.cmbTahun = New System.Windows.Forms.ComboBox()
        Me.lblTahunPajak = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilter.Controls.Add(Me.btnExport)
        Me.pnlFilter.Controls.Add(Me.btnTampilkan)
        Me.pnlFilter.Controls.Add(Me.cmbKaryawan)
        Me.pnlFilter.Controls.Add(Me.lblPilihKaryawan)
        Me.pnlFilter.Controls.Add(Me.cmbTahun)
        Me.pnlFilter.Controls.Add(Me.lblTahunPajak)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlFilter.Size = New System.Drawing.Size(900, 75)
        Me.pnlFilter.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(750, 38)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(130, 30)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Export PDF"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTampilkan.FlatAppearance.BorderSize = 0
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.Location = New System.Drawing.Point(614, 38)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(130, 30)
        Me.btnTampilkan.TabIndex = 4
        Me.btnTampilkan.Text = "Tampilkan / Preview"
        Me.btnTampilkan.UseVisualStyleBackColor = False
        '
        'cmbKaryawan
        '
        Me.cmbKaryawan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cmbKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKaryawan.FormattingEnabled = True
        Me.cmbKaryawan.Location = New System.Drawing.Point(120, 40)
        Me.cmbKaryawan.Name = "cmbKaryawan"
        Me.cmbKaryawan.Size = New System.Drawing.Size(480, 23)
        Me.cmbKaryawan.TabIndex = 3
        '
        'lblPilihKaryawan
        '
        Me.lblPilihKaryawan.AutoSize = True
        Me.lblPilihKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPilihKaryawan.Location = New System.Drawing.Point(13, 43)
        Me.lblPilihKaryawan.Name = "lblPilihKaryawan"
        Me.lblPilihKaryawan.Size = New System.Drawing.Size(95, 15)
        Me.lblPilihKaryawan.TabIndex = 2
        Me.lblPilihKaryawan.Text = "Pilih Karyawan:"
        '
        'cmbTahun
        '
        Me.cmbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTahun.FormattingEnabled = True
        Me.cmbTahun.Location = New System.Drawing.Point(120, 10)
        Me.cmbTahun.Name = "cmbTahun"
        Me.cmbTahun.Size = New System.Drawing.Size(120, 23)
        Me.cmbTahun.TabIndex = 1
        '
        'lblTahunPajak
        '
        Me.lblTahunPajak.AutoSize = True
        Me.lblTahunPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTahunPajak.Location = New System.Drawing.Point(13, 13)
        Me.lblTahunPajak.Name = "lblTahunPajak"
        Me.lblTahunPajak.Size = New System.Drawing.Size(81, 15)
        Me.lblTahunPajak.TabIndex = 0
        Me.lblTahunPajak.Text = "Tahun Pajak:"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 75)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(900, 525)
        Me.ReportViewer1.TabIndex = 1
        '
        'CetakBuktiPotong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.pnlFilter)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "CetakBuktiPotong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Bukti Potong PPh Pasal 21 - Form 1721-A1"
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents lblTahunPajak As System.Windows.Forms.Label
    Friend WithEvents cmbTahun As System.Windows.Forms.ComboBox
    Friend WithEvents lblPilihKaryawan As System.Windows.Forms.Label
    Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
