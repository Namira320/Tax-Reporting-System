<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportGaji
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
        lblPilihFile = New Label()
        txtFilePath = New TextBox()
        btnBrowse = New Button()
        btnDownloadTemplate = New Button()
        dgvPreview = New DataGridView()
        lblStatus = New Label()
        btnSimpanDatabase = New Button()
        btnCetakSPT = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        CType(dgvPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblPilihFile
        ' 
        lblPilihFile.AutoSize = True
        lblPilihFile.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPilihFile.Location = New Point(20, 29)
        lblPilihFile.Margin = New Padding(5, 0, 5, 0)
        lblPilihFile.Name = "lblPilihFile"
        lblPilihFile.Size = New Size(246, 37)
        lblPilihFile.TabIndex = 0
        lblPilihFile.Text = "Pilih File Gaji (.csv / .xlsx):"
        ' 
        ' txtFilePath
        ' 
        txtFilePath.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFilePath.Location = New Point(20, 67)
        txtFilePath.Margin = New Padding(5, 6, 5, 6)
        txtFilePath.Name = "txtFilePath"
        txtFilePath.ReadOnly = True
        txtFilePath.Size = New Size(667, 31)
        txtFilePath.TabIndex = 1
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBrowse.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204), CByte(255))
        btnBrowse.Font = New Font("Dubai", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(700, 63)
        btnBrowse.Margin = New Padding(5, 6, 5, 6)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(151, 44)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Cari File..."
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnDownloadTemplate
        ' 
        btnDownloadTemplate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDownloadTemplate.Font = New Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDownloadTemplate.Location = New Point(860, 63)
        btnDownloadTemplate.Margin = New Padding(5, 6, 5, 6)
        btnDownloadTemplate.Name = "btnDownloadTemplate"
        btnDownloadTemplate.Size = New Size(250, 44)
        btnDownloadTemplate.TabIndex = 3
        btnDownloadTemplate.Text = "Download Template Baku"
        btnDownloadTemplate.UseVisualStyleBackColor = True
        ' 
        ' dgvPreview
        ' 
        dgvPreview.AllowUserToAddRows = False
        dgvPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPreview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPreview.GridColor = Color.FromArgb(CByte(238), CByte(244), CByte(255))
        dgvPreview.Location = New Point(20, 173)
        dgvPreview.Margin = New Padding(5, 6, 5, 6)
        dgvPreview.Name = "dgvPreview"
        dgvPreview.ReadOnly = True
        dgvPreview.RowHeadersWidth = 62
        dgvPreview.Size = New Size(1090, 581)
        dgvPreview.TabIndex = 4
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Dubai", 11.999999F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(20, 127)
        lblStatus.Margin = New Padding(5, 0, 5, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(86, 40)
        lblStatus.TabIndex = 5
        lblStatus.Text = "Status:"
        ' 
        ' btnSimpanDatabase
        ' 
        btnSimpanDatabase.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSimpanDatabase.Enabled = False
        btnSimpanDatabase.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpanDatabase.Location = New Point(700, 766)
        btnSimpanDatabase.Margin = New Padding(5, 6, 5, 6)
        btnSimpanDatabase.Name = "btnSimpanDatabase"
        btnSimpanDatabase.Size = New Size(200, 46)
        btnSimpanDatabase.TabIndex = 6
        btnSimpanDatabase.Text = "Simpan ke Database"
        btnSimpanDatabase.UseVisualStyleBackColor = True
        ' 
        ' btnCetakSPT
        ' 
        btnCetakSPT.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCetakSPT.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetakSPT.Location = New Point(910, 766)
        btnCetakSPT.Margin = New Padding(5, 6, 5, 6)
        btnCetakSPT.Name = "btnCetakSPT"
        btnCetakSPT.Size = New Size(200, 46)
        btnCetakSPT.TabIndex = 7
        btnCetakSPT.Text = "Cetak Form 1721-A1 (PDF)"
        btnCetakSPT.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "Excel Files|*.xlsx;*.xls|CSV Files|*.csv|All Files|*.*"
        OpenFileDialog1.Title = "Pilih File Gaji"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "xlsx"
        SaveFileDialog1.Filter = "Excel Files|*.xlsx|All Files|*.*"
        SaveFileDialog1.Title = "Simpan Template Baku"
        ' 
        ' ImportGaji
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        ClientSize = New Size(1130, 820)
        Controls.Add(btnCetakSPT)
        Controls.Add(btnSimpanDatabase)
        Controls.Add(lblStatus)
        Controls.Add(dgvPreview)
        Controls.Add(btnDownloadTemplate)
        Controls.Add(btnBrowse)
        Controls.Add(txtFilePath)
        Controls.Add(lblPilihFile)
        Margin = New Padding(5, 6, 5, 6)
        MinimumSize = New Size(1151, 798)
        Name = "ImportGaji"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Import Gaji - Form 1721-A1"
        WindowState = FormWindowState.Maximized
        CType(dgvPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblPilihFile As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnDownloadTemplate As System.Windows.Forms.Button
    Friend WithEvents dgvPreview As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnSimpanDatabase As System.Windows.Forms.Button
    Friend WithEvents btnCetakSPT As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
