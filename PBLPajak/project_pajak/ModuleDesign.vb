Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Modul untuk menyimpan konstanta desain aplikasi pajak
''' Menyediakan warna, font, dan styling yang konsisten di seluruh aplikasi
''' </summary>
Public Module ModuleDesign

#Region "Color Palette"
    ' Primary Colors
    Public ReadOnly PrimaryBlue As Color = Color.FromArgb(7, 71, 166)
    Public ReadOnly PrimaryBlueDark As Color = Color.FromArgb(5, 53, 125)
    Public ReadOnly PrimaryBlueLight As Color = Color.FromArgb(25, 118, 210)
    
    ' Secondary Colors
    Public ReadOnly SecondaryYellow As Color = Color.FromArgb(255, 193, 7)
    Public ReadOnly SecondaryYellowLight As Color = Color.FromArgb(255, 213, 79)
    Public ReadOnly SecondaryYellowDark As Color = Color.FromArgb(245, 166, 35)
    
    ' Neutral Colors
    Public ReadOnly BackgroundLight As Color = Color.FromArgb(245, 240, 205)
    Public ReadOnly BackgroundWhite As Color = Color.White
    Public ReadOnly BackgroundCream As Color = Color.FromArgb(255, 252, 245)
    
    ' Text Colors
    Public ReadOnly TextPrimary As Color = Color.FromArgb(28, 33, 40)
    Public ReadOnly TextSecondary As Color = Color.FromArgb(74, 79, 86)
    Public ReadOnly TextLight As Color = Color.FromArgb(134, 142, 150)
    Public ReadOnly TextWhite As Color = Color.White
    
    ' Accent Colors
    Public ReadOnly AccentBlue As Color = Color.FromArgb(214, 230, 255)
    Public ReadOnly AccentSuccess As Color = Color.FromArgb(40, 167, 69)
    Public ReadOnly AccentWarning As Color = Color.FromArgb(255, 193, 7)
    Public ReadOnly AccentDanger As Color = Color.FromArgb(220, 53, 69)
    Public ReadOnly AccentInfo As Color = Color.FromArgb(23, 162, 184)
    
    ' Border Colors
    Public ReadOnly BorderLight As Color = Color.FromArgb(222, 226, 230)
    Public ReadOnly BorderMedium As Color = Color.FromArgb(206, 212, 218)
    Public ReadOnly BorderDark As Color = Color.FromArgb(173, 181, 189)
    
    ' Shadow Colors
    Public ReadOnly ShadowLight As Color = Color.FromArgb(30, 0, 0, 0)
    Public ReadOnly ShadowMedium As Color = Color.FromArgb(50, 0, 0, 0)
#End Region

#Region "Typography"
    ' Font Families
    Public ReadOnly FontPrimary As String = "Segoe UI"
    Public ReadOnly FontSecondary As String = "Dubai"
    
    ' Font Sizes
    Public Const FontSizeH1 As Single = 32.0F
    Public Const FontSizeH2 As Single = 24.0F
    Public Const FontSizeH3 As Single = 18.0F
    Public Const FontSizeH4 As Single = 16.0F
    Public Const FontSizeBody As Single = 11.0F
    Public Const FontSizeSmall As Single = 9.5F
    Public Const FontSizeCaption As Single = 8.5F
#End Region

#Region "Spacing"
    Public Const SpacingXS As Integer = 4
    Public Const SpacingS As Integer = 8
    Public Const SpacingM As Integer = 16
    Public Const SpacingL As Integer = 24
    Public Const SpacingXL As Integer = 32
    Public Const SpacingXXL As Integer = 48
#End Region

#Region "Border Radius"
    Public Const RadiusSmall As Integer = 4
    Public Const RadiusMedium As Integer = 8
    Public Const RadiusLarge As Integer = 12
    Public Const RadiusXLarge As Integer = 16
#End Region

#Region "Component Styling Methods"
    
    ''' <summary>
    ''' Menerapkan styling untuk button primary
    ''' </summary>
    Public Sub StylePrimaryButton(btn As Button)
        btn.BackColor = PrimaryBlue
        btn.ForeColor = TextWhite
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font = New Font(FontPrimary, FontSizeBody, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
        btn.Padding = New Padding(SpacingM, SpacingS, SpacingM, SpacingS)
        
        ' Add hover effect handler
        AddHandler btn.MouseEnter, Sub(sender, e)
                                        btn.BackColor = PrimaryBlueDark
                                    End Sub
        AddHandler btn.MouseLeave, Sub(sender, e)
                                        btn.BackColor = PrimaryBlue
                                    End Sub
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk button secondary
    ''' </summary>
    Public Sub StyleSecondaryButton(btn As Button)
        btn.BackColor = SecondaryYellow
        btn.ForeColor = TextPrimary
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font = New Font(FontPrimary, FontSizeBody, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
        btn.Padding = New Padding(SpacingM, SpacingS, SpacingM, SpacingS)
        
        AddHandler btn.MouseEnter, Sub(sender, e)
                                        btn.BackColor = SecondaryYellowDark
                                    End Sub
        AddHandler btn.MouseLeave, Sub(sender, e)
                                        btn.BackColor = SecondaryYellow
                                    End Sub
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk button outline
    ''' </summary>
    Public Sub StyleOutlineButton(btn As Button)
        btn.BackColor = BackgroundWhite
        btn.ForeColor = PrimaryBlue
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderColor = PrimaryBlue
        btn.FlatAppearance.BorderSize = 2
        btn.Font = New Font(FontPrimary, FontSizeBody, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
        btn.Padding = New Padding(SpacingM, SpacingS, SpacingM, SpacingS)
        
        AddHandler btn.MouseEnter, Sub(sender, e)
                                        btn.BackColor = AccentBlue
                                    End Sub
        AddHandler btn.MouseLeave, Sub(sender, e)
                                        btn.BackColor = BackgroundWhite
                                    End Sub
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk TextBox
    ''' </summary>
    Public Sub StyleTextBox(txt As TextBox)
        txt.BorderStyle = BorderStyle.FixedSingle
        txt.Font = New Font(FontPrimary, FontSizeBody)
        txt.BackColor = BackgroundWhite
        txt.ForeColor = TextPrimary
        
        ' Add focus effect
        AddHandler txt.Enter, Sub(sender, e)
                                  txt.BackColor = AccentBlue
                              End Sub
        AddHandler txt.Leave, Sub(sender, e)
                                  txt.BackColor = BackgroundWhite
                              End Sub
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk ComboBox
    ''' </summary>
    Public Sub StyleComboBox(cmb As ComboBox)
        cmb.FlatStyle = FlatStyle.Flat
        cmb.Font = New Font(FontPrimary, FontSizeBody)
        cmb.BackColor = BackgroundWhite
        cmb.ForeColor = TextPrimary
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk DataGridView
    ''' </summary>
    Public Sub StyleDataGridView(dgv As DataGridView)
        ' Header styling
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryBlue
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextWhite
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font(FontPrimary, FontSizeBody, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.Padding = New Padding(SpacingS)
        dgv.ColumnHeadersHeight = 45
        
        ' Cell styling
        dgv.DefaultCellStyle.BackColor = BackgroundWhite
        dgv.DefaultCellStyle.ForeColor = TextPrimary
        dgv.DefaultCellStyle.Font = New Font(FontPrimary, FontSizeBody)
        dgv.DefaultCellStyle.SelectionBackColor = AccentBlue
        dgv.DefaultCellStyle.SelectionForeColor = TextPrimary
        dgv.DefaultCellStyle.Padding = New Padding(SpacingS)
        
        ' Alternating row color
        dgv.AlternatingRowsDefaultCellStyle.BackColor = BackgroundLight
        
        ' Grid styling
        dgv.GridColor = BorderLight
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.RowHeadersVisible = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.ReadOnly = True
        dgv.RowTemplate.Height = 40
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk Label heading
    ''' </summary>
    Public Sub StyleHeading(lbl As Label, level As Integer)
        lbl.ForeColor = TextPrimary
        
        Select Case level
            Case 1
                lbl.Font = New Font(FontPrimary, FontSizeH1, FontStyle.Bold)
            Case 2
                lbl.Font = New Font(FontPrimary, FontSizeH2, FontStyle.Bold)
            Case 3
                lbl.Font = New Font(FontPrimary, FontSizeH3, FontStyle.Bold)
            Case 4
                lbl.Font = New Font(FontPrimary, FontSizeH4, FontStyle.Bold)
            Case Else
                lbl.Font = New Font(FontPrimary, FontSizeBody, FontStyle.Bold)
        End Select
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk Label body text
    ''' </summary>
    Public Sub StyleBodyText(lbl As Label)
        lbl.Font = New Font(FontPrimary, FontSizeBody)
        lbl.ForeColor = TextSecondary
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk Panel card
    ''' </summary>
    Public Sub StyleCard(pnl As Panel)
        pnl.BackColor = BackgroundWhite
        pnl.Padding = New Padding(SpacingL)
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk Panel sidebar
    ''' </summary>
    Public Sub StyleSidebar(pnl As Panel)
        pnl.BackColor = PrimaryBlue
        pnl.Padding = New Padding(SpacingM)
    End Sub
    
    ''' <summary>
    ''' Menerapkan styling untuk LinkLabel
    ''' </summary>
    Public Sub StyleLinkLabel(lnk As LinkLabel)
        lnk.LinkColor = PrimaryBlue
        lnk.ActiveLinkColor = PrimaryBlueDark
        lnk.VisitedLinkColor = PrimaryBlue
        lnk.LinkBehavior = LinkBehavior.HoverUnderline
        lnk.Font = New Font(FontPrimary, FontSizeBody)
    End Sub
    
#End Region

#Region "Helper Methods"
    
    ''' <summary>
    ''' Membuat gradient brush untuk background
    ''' </summary>
    Public Function CreateGradientBrush(rect As Rectangle, color1 As Color, color2 As Color) As Drawing2D.LinearGradientBrush
        Return New Drawing2D.LinearGradientBrush(rect, color1, color2, Drawing2D.LinearGradientMode.Vertical)
    End Function
    
    ''' <summary>
    ''' Menambahkan shadow effect ke control
    ''' </summary>
    Public Sub AddShadow(ctrl As Control)
        ' Note: WinForms doesn't support native shadows, this is a placeholder
        ' You would need to implement custom painting for true shadow effects
    End Sub
    
#End Region

End Module
