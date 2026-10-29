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
        pnlFilter = New Panel()
        btnExport = New Button()
        btnTampilkan = New Button()
        cmbKaryawan = New ComboBox()
        lblPilihKaryawan = New Label()
        cmbTahun = New ComboBox()
        lblTahunPajak = New Label()
        pnlFilter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlFilter
        ' 
        pnlFilter.BackColor = Color.FromArgb(CByte(28), CByte(110), CByte(164))
        pnlFilter.BorderStyle = BorderStyle.FixedSingle
        pnlFilter.Controls.Add(btnExport)
        pnlFilter.Controls.Add(btnTampilkan)
        pnlFilter.Controls.Add(cmbKaryawan)
        pnlFilter.Controls.Add(lblPilihKaryawan)
        pnlFilter.Controls.Add(cmbTahun)
        pnlFilter.Controls.Add(lblTahunPajak)
        pnlFilter.Dock = DockStyle.Top
        pnlFilter.Location = New Point(0, 0)
        pnlFilter.Margin = New Padding(5, 8, 5, 8)
        pnlFilter.Name = "pnlFilter"
        pnlFilter.Padding = New Padding(17, 26, 17, 26)
        pnlFilter.Size = New Size(1500, 192)
        pnlFilter.TabIndex = 0
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExport.BackColor = Color.FromArgb(CByte(183), CByte(28), CByte(28))
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(1278, 86)
        btnExport.Margin = New Padding(5, 8, 5, 8)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(185, 68)
        btnExport.TabIndex = 5
        btnExport.Text = "Export PDF"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTampilkan.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        btnTampilkan.FlatAppearance.BorderSize = 0
        btnTampilkan.FlatStyle = FlatStyle.Flat
        btnTampilkan.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkan.ForeColor = Color.White
        btnTampilkan.Location = New Point(1035, 86)
        btnTampilkan.Margin = New Padding(5, 8, 5, 8)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(217, 68)
        btnTampilkan.TabIndex = 4
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = False
        ' 
        ' cmbKaryawan
        ' 
        cmbKaryawan.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbKaryawan.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbKaryawan.FormattingEnabled = True
        cmbKaryawan.Location = New Point(215, 105)
        cmbKaryawan.Margin = New Padding(5, 8, 5, 8)
        cmbKaryawan.Name = "cmbKaryawan"
        cmbKaryawan.Size = New Size(798, 30)
        cmbKaryawan.TabIndex = 3
        ' 
        ' lblPilihKaryawan
        ' 
        lblPilihKaryawan.AutoSize = True
        lblPilihKaryawan.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPilihKaryawan.ForeColor = Color.White
        lblPilihKaryawan.Location = New Point(22, 102)
        lblPilihKaryawan.Margin = New Padding(5, 0, 5, 0)
        lblPilihKaryawan.Name = "lblPilihKaryawan"
        lblPilihKaryawan.Size = New Size(138, 34)
        lblPilihKaryawan.TabIndex = 2
        lblPilihKaryawan.Text = "Pilih Karyawan:"
        ' 
        ' cmbTahun
        ' 
        cmbTahun.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTahun.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbTahun.FormattingEnabled = True
        cmbTahun.Location = New Point(214, 35)
        cmbTahun.Margin = New Padding(5, 8, 5, 8)
        cmbTahun.Name = "cmbTahun"
        cmbTahun.Size = New Size(197, 30)
        cmbTahun.TabIndex = 1
        ' 
        ' lblTahunPajak
        ' 
        lblTahunPajak.AutoSize = True
        lblTahunPajak.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTahunPajak.ForeColor = Color.White
        lblTahunPajak.Location = New Point(22, 34)
        lblTahunPajak.Margin = New Padding(5, 0, 5, 0)
        lblTahunPajak.Name = "lblTahunPajak"
        lblTahunPajak.Size = New Size(118, 34)
        lblTahunPajak.TabIndex = 0
        lblTahunPajak.Text = "Tahun Pajak:"
        ' 
        ' CetakBuktiPotong
        ' 
        AutoScaleDimensions = New SizeF(10F, 34F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(238), CByte(244), CByte(255))
        ClientSize = New Size(1500, 1050)
        Controls.Add(pnlFilter)
        Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlLight
        Margin = New Padding(5, 8, 5, 8)
        MinimumSize = New Size(1319, 1006)
        Name = "CetakBuktiPotong"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cetak Bukti Potong PPh Pasal 21 - Form 1721-A1"
        WindowState = FormWindowState.Maximized
        pnlFilter.ResumeLayout(False)
        pnlFilter.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents lblTahunPajak As System.Windows.Forms.Label
    Friend WithEvents cmbTahun As System.Windows.Forms.ComboBox
    Friend WithEvents lblPilihKaryawan As System.Windows.Forms.Label
    Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents btnExport As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnTampilkan As Button
End Class
