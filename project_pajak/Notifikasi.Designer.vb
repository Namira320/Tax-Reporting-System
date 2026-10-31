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
        PanelWrapper = New Panel()
        SplitContainerMain = New SplitContainer()
        GroupBoxInbox = New GroupBox()
        DataGridViewInbox = New DataGridView()
        ColStatusIcon = New DataGridViewImageColumn()
        ColSubject = New DataGridViewTextBoxColumn()
        ColDate = New DataGridViewTextBoxColumn()
        GroupBoxReadingPane = New GroupBox()
        PanelActions = New FlowLayoutPanel()
        ButtonClose = New Button()
        ButtonDelete = New Button()
        ButtonMarkRead = New Button()
        RichTextBoxMessage = New RichTextBox()
        LabelMessageDate = New Label()
        LabelMessageTitle = New Label()
        LabelHeader = New Label()
        PanelWrapper.SuspendLayout()
        CType(SplitContainerMain, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerMain.Panel1.SuspendLayout()
        SplitContainerMain.Panel2.SuspendLayout()
        SplitContainerMain.SuspendLayout()
        GroupBoxInbox.SuspendLayout()
        CType(DataGridViewInbox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxReadingPane.SuspendLayout()
        PanelActions.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelWrapper
        ' 
        PanelWrapper.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        PanelWrapper.Controls.Add(SplitContainerMain)
        PanelWrapper.Controls.Add(LabelHeader)
        PanelWrapper.Dock = DockStyle.Fill
        PanelWrapper.Location = New Point(0, 0)
        PanelWrapper.Margin = New Padding(6, 8, 6, 8)
        PanelWrapper.Name = "PanelWrapper"
        PanelWrapper.Padding = New Padding(40, 40, 40, 40)
        PanelWrapper.Size = New Size(2501, 1065)
        PanelWrapper.TabIndex = 0
        ' 
        ' SplitContainerMain
        ' 
        SplitContainerMain.Dock = DockStyle.Fill
        SplitContainerMain.Location = New Point(40, 126)
        SplitContainerMain.Margin = New Padding(6, 8, 6, 8)
        SplitContainerMain.Name = "SplitContainerMain"
        ' 
        ' SplitContainerMain.Panel1
        ' 
        SplitContainerMain.Panel1.Controls.Add(GroupBoxInbox)
        ' 
        ' SplitContainerMain.Panel2
        ' 
        SplitContainerMain.Panel2.Controls.Add(GroupBoxReadingPane)
        SplitContainerMain.Size = New Size(2421, 899)
        SplitContainerMain.SplitterDistance = 825
        SplitContainerMain.SplitterWidth = 6
        SplitContainerMain.TabIndex = 1
        ' 
        ' GroupBoxInbox
        ' 
        GroupBoxInbox.BackColor = Color.White
        GroupBoxInbox.Controls.Add(DataGridViewInbox)
        GroupBoxInbox.Dock = DockStyle.Fill
        GroupBoxInbox.Font = New Font("Dubai", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxInbox.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxInbox.Location = New Point(0, 0)
        GroupBoxInbox.Margin = New Padding(0, 0, 27, 0)
        GroupBoxInbox.Name = "GroupBoxInbox"
        GroupBoxInbox.Padding = New Padding(27, 26, 27, 26)
        GroupBoxInbox.Size = New Size(825, 899)
        GroupBoxInbox.TabIndex = 0
        GroupBoxInbox.TabStop = False
        GroupBoxInbox.Text = "Daftar Pesan"
        ' 
        ' DataGridViewInbox
        ' 
        DataGridViewInbox.AllowUserToAddRows = False
        DataGridViewInbox.AllowUserToDeleteRows = False
        DataGridViewInbox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewInbox.BackgroundColor = Color.White
        DataGridViewInbox.BorderStyle = BorderStyle.None
        DataGridViewInbox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewInbox.Columns.AddRange(New DataGridViewColumn() {ColStatusIcon, ColSubject, ColDate})
        DataGridViewInbox.Dock = DockStyle.Fill
        DataGridViewInbox.EnableHeadersVisualStyles = False
        DataGridViewInbox.Location = New Point(27, 81)
        DataGridViewInbox.Margin = New Padding(5, 5, 5, 5)
        DataGridViewInbox.MultiSelect = False
        DataGridViewInbox.Name = "DataGridViewInbox"
        DataGridViewInbox.ReadOnly = True
        DataGridViewInbox.RowHeadersVisible = False
        DataGridViewInbox.RowHeadersWidth = 62
        DataGridViewInbox.RowTemplate.Height = 36
        DataGridViewInbox.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewInbox.Size = New Size(771, 792)
        DataGridViewInbox.TabIndex = 0
        ' 
        ' ColStatusIcon
        ' 
        ColStatusIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ColStatusIcon.FillWeight = 30F
        ColStatusIcon.HeaderText = ""
        ColStatusIcon.ImageLayout = DataGridViewImageCellLayout.Zoom
        ColStatusIcon.MinimumWidth = 40
        ColStatusIcon.Name = "ColStatusIcon"
        ColStatusIcon.ReadOnly = True
        ColStatusIcon.Resizable = DataGridViewTriState.False
        ColStatusIcon.Width = 40
        ' 
        ' ColSubject
        ' 
        ColSubject.DataPropertyName = "Title"
        ColSubject.FillWeight = 160F
        ColSubject.HeaderText = "Judul Pesan"
        ColSubject.MinimumWidth = 6
        ColSubject.Name = "ColSubject"
        ColSubject.ReadOnly = True
        ' 
        ' ColDate
        ' 
        ColDate.DataPropertyName = "SentAt"
        ColDate.FillWeight = 90F
        ColDate.HeaderText = "Tanggal"
        ColDate.MinimumWidth = 6
        ColDate.Name = "ColDate"
        ColDate.ReadOnly = True
        ' 
        ' GroupBoxReadingPane
        ' 
        GroupBoxReadingPane.BackColor = Color.White
        GroupBoxReadingPane.Controls.Add(PanelActions)
        GroupBoxReadingPane.Controls.Add(RichTextBoxMessage)
        GroupBoxReadingPane.Controls.Add(LabelMessageDate)
        GroupBoxReadingPane.Controls.Add(LabelMessageTitle)
        GroupBoxReadingPane.Dock = DockStyle.Fill
        GroupBoxReadingPane.Font = New Font("Dubai", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxReadingPane.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        GroupBoxReadingPane.Location = New Point(0, 0)
        GroupBoxReadingPane.Margin = New Padding(27, 0, 0, 0)
        GroupBoxReadingPane.Name = "GroupBoxReadingPane"
        GroupBoxReadingPane.Padding = New Padding(40, 40, 40, 40)
        GroupBoxReadingPane.Size = New Size(1590, 899)
        GroupBoxReadingPane.TabIndex = 0
        GroupBoxReadingPane.TabStop = False
        GroupBoxReadingPane.Text = "Isi Pesan"
        ' 
        ' PanelActions
        ' 
        PanelActions.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        PanelActions.Controls.Add(ButtonMarkRead)
        PanelActions.Controls.Add(ButtonDelete)
        PanelActions.Controls.Add(ButtonClose)
        PanelActions.Location = New Point(40, 655)
        PanelActions.Margin = New Padding(0)
        PanelActions.Name = "PanelActions"
        PanelActions.Padding = New Padding(0, 4, 0, 0)
        PanelActions.Size = New Size(1276, 142)
        PanelActions.TabIndex = 3
        PanelActions.WrapContents = False
        ' 
        ' ButtonClose
        ' 
        ButtonClose.AutoSize = True
        ButtonClose.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        ButtonClose.FlatAppearance.BorderSize = 0
        ButtonClose.FlatStyle = FlatStyle.Flat
        ButtonClose.Font = New Font("Dubai", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonClose.ForeColor = Color.White
        ButtonClose.Location = New Point(735, 8)
        ButtonClose.Margin = New Padding(16, 4, 0, 0)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Padding = New Padding(16, 5, 16, 5)
        ButtonClose.Size = New Size(182, 88)
        ButtonClose.TabIndex = 2
        ButtonClose.Text = "Tutup"
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.AutoSize = True
        ButtonDelete.BackColor = Color.FromArgb(CByte(255), CByte(242), CByte(239))
        ButtonDelete.FlatStyle = FlatStyle.Flat
        ButtonDelete.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonDelete.ForeColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        ButtonDelete.Location = New Point(438, 8)
        ButtonDelete.Margin = New Padding(16, 4, 0, 0)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Padding = New Padding(16, 5, 16, 5)
        ButtonDelete.Size = New Size(281, 91)
        ButtonDelete.TabIndex = 1
        ButtonDelete.Text = "Hapus Pesan"
        ButtonDelete.UseVisualStyleBackColor = False
        ' 
        ' ButtonMarkRead
        ' 
        ButtonMarkRead.AutoSize = True
        ButtonMarkRead.BackColor = Color.FromArgb(CByte(232), CByte(245), CByte(233))
        ButtonMarkRead.FlatStyle = FlatStyle.Flat
        ButtonMarkRead.Font = New Font("Dubai", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonMarkRead.ForeColor = Color.FromArgb(CByte(34), CByte(153), CByte(84))
        ButtonMarkRead.ImageAlign = ContentAlignment.TopCenter
        ButtonMarkRead.Location = New Point(16, 8)
        ButtonMarkRead.Margin = New Padding(16, 4, 0, 0)
        ButtonMarkRead.Name = "ButtonMarkRead"
        ButtonMarkRead.Padding = New Padding(16, 5, 16, 5)
        ButtonMarkRead.Size = New Size(406, 91)
        ButtonMarkRead.TabIndex = 0
        ButtonMarkRead.Text = "Tandai Sudah Dibaca"
        ButtonMarkRead.UseVisualStyleBackColor = False
        ' 
        ' RichTextBoxMessage
        ' 
        RichTextBoxMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBoxMessage.BackColor = Color.FromArgb(CByte(250), CByte(252), CByte(255))
        RichTextBoxMessage.BorderStyle = BorderStyle.None
        RichTextBoxMessage.Font = New Font("Segoe UI", 11F)
        RichTextBoxMessage.Location = New Point(40, 216)
        RichTextBoxMessage.Margin = New Padding(5, 5, 5, 5)
        RichTextBoxMessage.Name = "RichTextBoxMessage"
        RichTextBoxMessage.ReadOnly = True
        RichTextBoxMessage.Size = New Size(1510, 320)
        RichTextBoxMessage.TabIndex = 2
        RichTextBoxMessage.Text = ""
        ' 
        ' LabelMessageDate
        ' 
        LabelMessageDate.AutoSize = True
        LabelMessageDate.Font = New Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMessageDate.ForeColor = Color.FromArgb(CByte(105), CByte(112), CByte(125))
        LabelMessageDate.Location = New Point(40, 151)
        LabelMessageDate.Margin = New Padding(5, 0, 5, 0)
        LabelMessageDate.Name = "LabelMessageDate"
        LabelMessageDate.Size = New Size(311, 45)
        LabelMessageDate.TabIndex = 1
        LabelMessageDate.Text = "Pilih pesan terlebih dahulu"
        ' 
        ' LabelMessageTitle
        ' 
        LabelMessageTitle.AutoEllipsis = True
        LabelMessageTitle.Font = New Font("Dubai", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelMessageTitle.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        LabelMessageTitle.Location = New Point(26, 65)
        LabelMessageTitle.Margin = New Padding(5, 0, 5, 0)
        LabelMessageTitle.Name = "LabelMessageTitle"
        LabelMessageTitle.Size = New Size(1082, 69)
        LabelMessageTitle.TabIndex = 0
        LabelMessageTitle.Text = "Tidak ada pesan terpilih"
        ' 
        ' LabelHeader
        ' 
        LabelHeader.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        LabelHeader.Dock = DockStyle.Top
        LabelHeader.Font = New Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHeader.ForeColor = Color.White
        LabelHeader.Location = New Point(40, 40)
        LabelHeader.Margin = New Padding(6, 0, 6, 0)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(2421, 86)
        LabelHeader.TabIndex = 0
        LabelHeader.Text = "Notifikasi Wajib Pajak"
        LabelHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Notifikasi
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(2501, 1065)
        Controls.Add(PanelWrapper)
        Font = New Font("Segoe UI", 9F)
        ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        Margin = New Padding(6, 8, 6, 8)
        Name = "Notifikasi"
        StartPosition = FormStartPosition.CenterParent
        Text = "Notifikasi Wajib Pajak"
        WindowState = FormWindowState.Maximized
        PanelWrapper.ResumeLayout(False)
        SplitContainerMain.Panel1.ResumeLayout(False)
        SplitContainerMain.Panel2.ResumeLayout(False)
        CType(SplitContainerMain, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerMain.ResumeLayout(False)
        GroupBoxInbox.ResumeLayout(False)
        CType(DataGridViewInbox, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxReadingPane.ResumeLayout(False)
        GroupBoxReadingPane.PerformLayout()
        PanelActions.ResumeLayout(False)
        PanelActions.PerformLayout()
        ResumeLayout(False)

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
