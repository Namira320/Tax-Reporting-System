<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanduanEBilling
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelTop = New Panel()
        Me.TableTop = New TableLayoutPanel()
        Me.LabelTitle = New Label()
        Me.LabelSubtitle = New Label()
        Me.PanelBottom = New Panel()
        Me.TableButtons = New TableLayoutPanel()
        Me.ButtonKembali = New Button()
        Me.ButtonRefresh = New Button()
        Me.ButtonPrint = New Button()
        Me.ButtonBukaDJP = New Button()
        Me.WebBrowserPDF = New WebBrowser()
        Me.PanelTop.SuspendLayout()
        Me.TableTop.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.TableButtons.SuspendLayout()
        Me.SuspendLayout()
        
        ' 
        ' PanelTop
        ' 
        Me.PanelTop.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Me.PanelTop.Controls.Add(Me.TableTop)
        Me.PanelTop.Dock = DockStyle.Top
        Me.PanelTop.Location = New Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Padding = New Padding(20)
        Me.PanelTop.Size = New Size(1200, 120)
        Me.PanelTop.TabIndex = 0
        ' 
        ' TableTop
        ' 
        Me.TableTop.ColumnCount = 1
        Me.TableTop.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))
        Me.TableTop.Controls.Add(Me.LabelTitle, 0, 0)
        Me.TableTop.Controls.Add(Me.LabelSubtitle, 0, 1)
        Me.TableTop.Dock = DockStyle.Fill
        Me.TableTop.Location = New Point(20, 20)
        Me.TableTop.Name = "TableTop"
        Me.TableTop.RowCount = 2
        Me.TableTop.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Me.TableTop.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0!))
        Me.TableTop.Size = New Size(1160, 80)
        Me.TableTop.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Dock = DockStyle.Fill
        Me.LabelTitle.Font = New Font("Segoe UI", 24.0!, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.LabelTitle.ForeColor = Color.White
        Me.LabelTitle.Location = New Point(3, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New Size(1154, 48)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "📄 Panduan e-Billing"
        Me.LabelTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelSubtitle
        ' 
        Me.LabelSubtitle.AutoSize = True
        Me.LabelSubtitle.Dock = DockStyle.Fill
        Me.LabelSubtitle.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.LabelSubtitle.ForeColor = Color.White
        Me.LabelSubtitle.Location = New Point(3, 48)
        Me.LabelSubtitle.Name = "LabelSubtitle"
        Me.LabelSubtitle.Size = New Size(1154, 32)
        Me.LabelSubtitle.TabIndex = 1
        Me.LabelSubtitle.Text = "Panduan lengkap pembayaran pajak melalui e-Billing"
        Me.LabelSubtitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelBottom
        ' 
        Me.PanelBottom.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(205))
        Me.PanelBottom.Controls.Add(Me.TableButtons)
        Me.PanelBottom.Dock = DockStyle.Bottom
        Me.PanelBottom.Location = New Point(0, 680)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Padding = New Padding(20)
        Me.PanelBottom.Size = New Size(1200, 80)
        Me.PanelBottom.TabIndex = 1
        ' 
        ' 
        ' TableButtons
        ' 
        Me.TableButtons.ColumnCount = 5
        Me.TableButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 240.0!))
        Me.TableButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 140.0!))
        Me.TableButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 140.0!))
        Me.TableButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))
        Me.TableButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 260.0!))
        Me.TableButtons.Controls.Add(Me.ButtonKembali, 0, 0)
        Me.TableButtons.Controls.Add(Me.ButtonRefresh, 1, 0)
        Me.TableButtons.Controls.Add(Me.ButtonPrint, 2, 0)
        Me.TableButtons.Controls.Add(Me.ButtonBukaDJP, 4, 0)
        Me.TableButtons.Dock = DockStyle.Fill
        Me.TableButtons.Location = New Point(20, 20)
        Me.TableButtons.Name = "TableButtons"
        Me.TableButtons.RowCount = 1
        Me.TableButtons.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0!))
        Me.TableButtons.Size = New Size(1160, 40)
        Me.TableButtons.TabIndex = 0
        ' 
        ' ButtonKembali
        ' 
        Me.ButtonKembali.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Me.ButtonKembali.Cursor = Cursors.Hand
        Me.ButtonKembali.Dock = DockStyle.Fill
        Me.ButtonKembali.FlatAppearance.BorderSize = 0
        Me.ButtonKembali.FlatStyle = FlatStyle.Flat
        Me.ButtonKembali.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.ButtonKembali.ForeColor = Color.White
        Me.ButtonKembali.Location = New Point(3, 3)
        Me.ButtonKembali.Name = "ButtonKembali"
        Me.ButtonKembali.Size = New Size(234, 34)
        Me.ButtonKembali.TabIndex = 0
        Me.ButtonKembali.Text = "🏠 Kembali ke Dashboard"
        Me.ButtonKembali.UseVisualStyleBackColor = False
        ' 
        ' ButtonRefresh
        ' 
        Me.ButtonRefresh.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Me.ButtonRefresh.Cursor = Cursors.Hand
        Me.ButtonRefresh.Dock = DockStyle.Fill
        Me.ButtonRefresh.FlatAppearance.BorderSize = 0
        Me.ButtonRefresh.FlatStyle = FlatStyle.Flat
        Me.ButtonRefresh.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.ButtonRefresh.ForeColor = Color.White
        Me.ButtonRefresh.Location = New Point(163, 3)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New Size(134, 34)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "🔄 Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        ' 
        ' ButtonPrint
        ' 
        Me.ButtonPrint.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        Me.ButtonPrint.Cursor = Cursors.Hand
        Me.ButtonPrint.Dock = DockStyle.Fill
        Me.ButtonPrint.FlatAppearance.BorderSize = 0
        Me.ButtonPrint.FlatStyle = FlatStyle.Flat
        Me.ButtonPrint.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.ButtonPrint.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(40))
        Me.ButtonPrint.Location = New Point(303, 3)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New Size(134, 34)
        Me.ButtonPrint.TabIndex = 3
        Me.ButtonPrint.Text = "📄 Print PDF"
        Me.ButtonPrint.UseVisualStyleBackColor = False
        ' 
        ' ButtonBukaDJP
        ' 
        Me.ButtonBukaDJP.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Me.ButtonBukaDJP.Cursor = Cursors.Hand
        Me.ButtonBukaDJP.Dock = DockStyle.Fill
        Me.ButtonBukaDJP.FlatAppearance.BorderSize = 0
        Me.ButtonBukaDJP.FlatStyle = FlatStyle.Flat
        Me.ButtonBukaDJP.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.ButtonBukaDJP.ForeColor = Color.White
        Me.ButtonBukaDJP.Location = New Point(903, 3)
        Me.ButtonBukaDJP.Name = "ButtonBukaDJP"
        Me.ButtonBukaDJP.Size = New Size(254, 34)
        Me.ButtonBukaDJP.TabIndex = 2
        Me.ButtonBukaDJP.Text = "🌐 Buka Panduan Online DJP"
        Me.ButtonBukaDJP.UseVisualStyleBackColor = False
        Me.ButtonBukaDJP.Visible = False
        ' 
        ' WebBrowserPDF
        ' 
        Me.WebBrowserPDF.Dock = DockStyle.Fill
        Me.WebBrowserPDF.Location = New Point(0, 120)
        Me.WebBrowserPDF.MinimumSize = New Size(20, 20)
        Me.WebBrowserPDF.Name = "WebBrowserPDF"
        Me.WebBrowserPDF.Size = New Size(1200, 560)
        Me.WebBrowserPDF.TabIndex = 2
        ' 
        ' PanduanEBilling
        ' 
        Me.AutoScaleDimensions = New SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.White
        Me.ClientSize = New Size(1200, 760)
        Me.Controls.Add(Me.WebBrowserPDF)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.Name = "PanduanEBilling"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "TaxEase - Panduan e-Billing"
        Me.WindowState = FormWindowState.Maximized
        Me.PanelTop.ResumeLayout(False)
        Me.TableTop.ResumeLayout(False)
        Me.TableTop.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.TableButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents TableTop As TableLayoutPanel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents TableButtons As TableLayoutPanel
    Friend WithEvents ButtonKembali As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ButtonBukaDJP As Button
    Friend WithEvents WebBrowserPDF As WebBrowser
End Class
