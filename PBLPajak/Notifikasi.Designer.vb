<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notifikasi
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
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.GroupBoxInbox = New System.Windows.Forms.GroupBox()
        Me.DataGridViewInbox = New System.Windows.Forms.DataGridView()
        Me.ColStatusIcon = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxReadingPane = New System.Windows.Forms.GroupBox()
        Me.PanelActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonMarkRead = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.RichTextBoxMessage = New System.Windows.Forms.RichTextBox()
        Me.LabelMessageDate = New System.Windows.Forms.Label()
        Me.LabelMessageTitle = New System.Windows.Forms.Label()
        Me.PanelWrapper.SuspendLayout()
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        Me.GroupBoxInbox.SuspendLayout()
        CType(Me.DataGridViewInbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxReadingPane.SuspendLayout()
        Me.PanelActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelWrapper
        '
        Me.PanelWrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PanelWrapper.Controls.Add(Me.SplitContainerMain)
        Me.PanelWrapper.Controls.Add(Me.LabelHeader)
        Me.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapper.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapper.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelWrapper.Name = "PanelWrapper"
        Me.PanelWrapper.Padding = New System.Windows.Forms.Padding(24)
        Me.PanelWrapper.Size = New System.Drawing.Size(1100, 650)
        Me.PanelWrapper.TabIndex = 0
        '
        'LabelHeader
        '
        Me.LabelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LabelHeader.Location = New System.Drawing.Point(24, 24)
        Me.LabelHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(1052, 52)
        Me.LabelHeader.TabIndex = 0
        Me.LabelHeader.Text = "Notifikasi Wajib Pajak"
        Me.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainerMain
        '
        Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMain.Location = New System.Drawing.Point(24, 76)
        Me.SplitContainerMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainerMain.Name = "SplitContainerMain"
        '
        'SplitContainerMain.Panel1
        '
        Me.SplitContainerMain.Panel1.Controls.Add(Me.GroupBoxInbox)
        '
        'SplitContainerMain.Panel2
        '
        Me.SplitContainerMain.Panel2.Controls.Add(Me.GroupBoxReadingPane)
        Me.SplitContainerMain.Size = New System.Drawing.Size(1052, 550)
        Me.SplitContainerMain.SplitterDistance = 360
        Me.SplitContainerMain.TabIndex = 1
        '
        'GroupBoxInbox
        '
        Me.GroupBoxInbox.BackColor = System.Drawing.Color.White
        Me.GroupBoxInbox.Controls.Add(Me.DataGridViewInbox)
        Me.GroupBoxInbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxInbox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxInbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBoxInbox.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxInbox.Margin = New System.Windows.Forms.Padding(0, 0, 16, 0)
        Me.GroupBoxInbox.Name = "GroupBoxInbox"
        Me.GroupBoxInbox.Padding = New System.Windows.Forms.Padding(16)
        Me.GroupBoxInbox.Size = New System.Drawing.Size(360, 550)
        Me.GroupBoxInbox.TabIndex = 0
        Me.GroupBoxInbox.TabStop = False
        Me.GroupBoxInbox.Text = "Daftar Pesan"
        '
        'DataGridViewInbox
        '
        Me.DataGridViewInbox.AllowUserToAddRows = False
        Me.DataGridViewInbox.AllowUserToDeleteRows = False
        Me.DataGridViewInbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewInbox.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewInbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInbox.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColStatusIcon, Me.ColSubject, Me.ColDate})
        Me.DataGridViewInbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewInbox.EnableHeadersVisualStyles = False
        Me.DataGridViewInbox.Location = New System.Drawing.Point(16, 44)
        Me.DataGridViewInbox.MultiSelect = False
        Me.DataGridViewInbox.Name = "DataGridViewInbox"
        Me.DataGridViewInbox.ReadOnly = True
        Me.DataGridViewInbox.RowHeadersVisible = False
        Me.DataGridViewInbox.RowTemplate.Height = 36
        Me.DataGridViewInbox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInbox.Size = New System.Drawing.Size(328, 490)
        Me.DataGridViewInbox.TabIndex = 0
        '
        'ColStatusIcon
        '
        Me.ColStatusIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColStatusIcon.FillWeight = 30.0!
        Me.ColStatusIcon.HeaderText = ""
        Me.ColStatusIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ColStatusIcon.MinimumWidth = 40
        Me.ColStatusIcon.Name = "ColStatusIcon"
        Me.ColStatusIcon.ReadOnly = True
        Me.ColStatusIcon.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColStatusIcon.Width = 40
        '
        'ColSubject
        '
        Me.ColSubject.DataPropertyName = "Title"
        Me.ColSubject.FillWeight = 160.0!
        Me.ColSubject.HeaderText = "Judul Pesan"
        Me.ColSubject.MinimumWidth = 6
        Me.ColSubject.Name = "ColSubject"
        Me.ColSubject.ReadOnly = True
        '
        'ColDate
        '
        Me.ColDate.DataPropertyName = "SentAt"
        Me.ColDate.FillWeight = 90.0!
        Me.ColDate.HeaderText = "Tanggal"
        Me.ColDate.MinimumWidth = 6
        Me.ColDate.Name = "ColDate"
        Me.ColDate.ReadOnly = True
        '
        'GroupBoxReadingPane
        '
        Me.GroupBoxReadingPane.BackColor = System.Drawing.Color.White
        Me.GroupBoxReadingPane.Controls.Add(Me.PanelActions)
        Me.GroupBoxReadingPane.Controls.Add(Me.RichTextBoxMessage)
        Me.GroupBoxReadingPane.Controls.Add(Me.LabelMessageDate)
        Me.GroupBoxReadingPane.Controls.Add(Me.LabelMessageTitle)
        Me.GroupBoxReadingPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxReadingPane.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxReadingPane.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBoxReadingPane.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxReadingPane.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.GroupBoxReadingPane.Name = "GroupBoxReadingPane"
        Me.GroupBoxReadingPane.Padding = New System.Windows.Forms.Padding(24)
        Me.GroupBoxReadingPane.Size = New System.Drawing.Size(688, 550)
        Me.GroupBoxReadingPane.TabIndex = 0
        Me.GroupBoxReadingPane.TabStop = False
        Me.GroupBoxReadingPane.Text = "Isi Pesan"
        '
        'PanelActions
        '
        Me.PanelActions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.PanelActions.AutoSize = True
        Me.PanelActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelActions.Controls.Add(Me.ButtonClose)
        Me.PanelActions.Controls.Add(Me.ButtonDelete)
        Me.PanelActions.Controls.Add(Me.ButtonMarkRead)
        Me.PanelActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.PanelActions.Location = New System.Drawing.Point(24, 474)
        Me.PanelActions.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelActions.Name = "PanelActions"
        Me.PanelActions.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.PanelActions.Size = New System.Drawing.Size(640, 52)
        Me.PanelActions.TabIndex = 3
        Me.PanelActions.WrapContents = False
        '
        'ButtonMarkRead
        '
        Me.ButtonMarkRead.AutoSize = True
        Me.ButtonMarkRead.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ButtonMarkRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMarkRead.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonMarkRead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ButtonMarkRead.Location = New System.Drawing.Point(444, 12)
        Me.ButtonMarkRead.Margin = New System.Windows.Forms.Padding(12, 12, 0, 0)
        Me.ButtonMarkRead.Name = "ButtonMarkRead"
        Me.ButtonMarkRead.Padding = New System.Windows.Forms.Padding(12, 6, 12, 6)
        Me.ButtonMarkRead.Size = New System.Drawing.Size(196, 40)
        Me.ButtonMarkRead.TabIndex = 0
        Me.ButtonMarkRead.Text = "Tandai Sudah Dibaca"
        Me.ButtonMarkRead.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.AutoSize = True
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ButtonDelete.Location = New System.Drawing.Point(300, 12)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(12, 12, 0, 0)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Padding = New System.Windows.Forms.Padding(12, 6, 12, 6)
        Me.ButtonDelete.Size = New System.Drawing.Size(132, 40)
        Me.ButtonDelete.TabIndex = 1
        Me.ButtonDelete.Text = "Hapus Pesan"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.AutoSize = True
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(144, 12)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(12, 12, 0, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Padding = New System.Windows.Forms.Padding(12, 6, 12, 6)
        Me.ButtonClose.Size = New System.Drawing.Size(132, 40)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Tutup"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'RichTextBoxMessage
        '
        Me.RichTextBoxMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxMessage.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBoxMessage.Location = New System.Drawing.Point(24, 132)
        Me.RichTextBoxMessage.Name = "RichTextBoxMessage"
        Me.RichTextBoxMessage.ReadOnly = True
        Me.RichTextBoxMessage.Size = New System.Drawing.Size(640, 329)
        Me.RichTextBoxMessage.TabIndex = 2
        Me.RichTextBoxMessage.Text = ""
        '
        'LabelMessageDate
        '
        Me.LabelMessageDate.AutoSize = True
        Me.LabelMessageDate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMessageDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LabelMessageDate.Location = New System.Drawing.Point(24, 92)
        Me.LabelMessageDate.Name = "LabelMessageDate"
        Me.LabelMessageDate.Size = New System.Drawing.Size(196, 28)
        Me.LabelMessageDate.TabIndex = 1
        Me.LabelMessageDate.Text = "Pilih pesan terlebih dahulu"
        '
        'LabelMessageTitle
        '
        Me.LabelMessageTitle.AutoEllipsis = True
        Me.LabelMessageTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelMessageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LabelMessageTitle.Location = New System.Drawing.Point(24, 40)
        Me.LabelMessageTitle.Name = "LabelMessageTitle"
        Me.LabelMessageTitle.Size = New System.Drawing.Size(640, 42)
        Me.LabelMessageTitle.TabIndex = 0
        Me.LabelMessageTitle.Text = "Tidak ada pesan terpilih"
        '
        'Notifikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.PanelWrapper)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Notifikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Notifikasi Wajib Pajak"
        Me.PanelWrapper.ResumeLayout(False)
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.ResumeLayout(False)
        Me.GroupBoxInbox.ResumeLayout(False)
        CType(Me.DataGridViewInbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxReadingPane.ResumeLayout(False)
        Me.GroupBoxReadingPane.PerformLayout()
        Me.PanelActions.ResumeLayout(False)
        Me.PanelActions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents LabelHeader As Label
    Friend WithEvents SplitContainerMain As SplitContainer
    Friend WithEvents GroupBoxInbox As GroupBox
    Friend WithEvents DataGridViewInbox As DataGridView
    Friend WithEvents GroupBoxReadingPane As GroupBox
    Friend WithEvents LabelMessageTitle As Label
    Friend WithEvents LabelMessageDate As Label
    Friend WithEvents RichTextBoxMessage As RichTextBox
    Friend WithEvents PanelActions As FlowLayoutPanel
    Friend WithEvents ButtonMarkRead As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ColStatusIcon As DataGridViewImageColumn
    Friend WithEvents ColSubject As DataGridViewTextBoxColumn
    Friend WithEvents ColDate As DataGridViewTextBoxColumn

End Class
