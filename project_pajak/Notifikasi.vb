Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq

Public Class Notifikasi
    Private ReadOnly _userId As Integer
    Private ReadOnly _notifications As BindingList(Of NotificationItem)
    Private ReadOnly _statusIcons As Dictionary(Of Boolean, Image)

    Public Sub New(Optional userId As Integer = 0)
        InitializeComponent()
        _userId = userId
        _statusIcons = CreateStatusIcons()
        _notifications = New BindingList(Of NotificationItem)(NotificationRepository.GetNotificationsForUser(userId))

        ConfigureGrid()
        BindGrid()
        TrySelectInitialMessage()
    End Sub

    Private Sub ConfigureGrid()
        DataGridViewInbox.AutoGenerateColumns = False
        DataGridViewInbox.Columns("ColSubject").DefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        DataGridViewInbox.Columns("ColDate").DefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
        DataGridViewInbox.Columns("ColDate").DefaultCellStyle.Format = "dd MMM yyyy HH:mm"
        DataGridViewInbox.Columns("ColDate").DefaultCellStyle.ForeColor = Color.FromArgb(105, 112, 125)
        DataGridViewInbox.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        DataGridViewInbox.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252)
        DataGridViewInbox.EnableHeadersVisualStyles = False
    End Sub

    Private Sub BindGrid()
        DataGridViewInbox.DataSource = _notifications
    End Sub

    Private Sub TrySelectInitialMessage()
        If _notifications.Any() Then
            DataGridViewInbox.Rows(0).Selected = True
            DisplayMessage(_notifications.First())
        Else
            ClearReadingPane()
        End If
    End Sub

    Private Sub DisplayMessage(item As NotificationItem)
        If item Is Nothing Then
            ClearReadingPane()
            Return
        End If

        LabelMessageTitle.Text = item.Title
        LabelMessageDate.Text = item.SentAt.ToString("dddd, dd MMMM yyyy HH:mm")
        RichTextBoxMessage.Text = item.Body
        RichTextBoxMessage.SelectionStart = 0
        RichTextBoxMessage.ScrollToCaret()
    End Sub

    Private Sub ClearReadingPane()
        LabelMessageTitle.Text = "Tidak ada pesan terpilih"
        LabelMessageDate.Text = "Pilih pesan terlebih dahulu"
        RichTextBoxMessage.Clear()
    End Sub

    Private Function GetSelectedNotification() As NotificationItem
        If DataGridViewInbox.CurrentRow Is Nothing Then
            Return Nothing
        End If
        Return TryCast(DataGridViewInbox.CurrentRow.DataBoundItem, NotificationItem)
    End Function

    Private Sub DataGridViewInbox_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewInbox.SelectionChanged
        DisplayMessage(GetSelectedNotification())
    End Sub

    Private Sub DataGridViewInbox_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewInbox.CellFormatting
        If e.RowIndex < 0 Then Return
        If DataGridViewInbox.Columns(e.ColumnIndex).Name <> "ColStatusIcon" Then Return

        Dim item = TryCast(DataGridViewInbox.Rows(e.RowIndex).DataBoundItem, NotificationItem)
        If item Is Nothing Then Return

        e.Value = If(item.IsRead, _statusIcons(True), _statusIcons(False))
    End Sub

    Private Sub ButtonMarkRead_Click(sender As Object, e As EventArgs) Handles ButtonMarkRead.Click
        Dim selected = GetSelectedNotification()
        If selected Is Nothing Then Return

        selected.IsRead = True
        DataGridViewInbox.Refresh()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim selected = GetSelectedNotification()
        If selected Is Nothing Then Return

        Dim rowIndex = DataGridViewInbox.CurrentRow.Index
        _notifications.Remove(selected)

        If _notifications.Count = 0 Then
            ClearReadingPane()
            Return
        End If

        Dim nextIndex = Math.Min(rowIndex, _notifications.Count - 1)
        DataGridViewInbox.Rows(nextIndex).Selected = True
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Function CreateStatusIcons() As Dictionary(Of Boolean, Image)
        Dim readIcon = CreateIndicator(Color.FromArgb(189, 189, 189))
        Dim unreadIcon = CreateIndicator(Color.FromArgb(7, 71, 166))

        Return New Dictionary(Of Boolean, Image) From {
            {True, readIcon},
            {False, unreadIcon}
        }
    End Function

    Private Function CreateIndicator(color As Color) As Image
        Dim bmp As New Bitmap(16, 16)
        Using g = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(Color.Transparent)
            Using brush As New SolidBrush(color)
                g.FillEllipse(brush, 2, 2, 12, 12)
            End Using
        End Using
        Return bmp
    End Function

    Private Sub GroupBoxInbox_Enter(sender As Object, e As EventArgs) Handles GroupBoxInbox.Enter

    End Sub

    Private Sub PanelWrapper_Paint(sender As Object, e As PaintEventArgs) Handles PanelWrapper.Paint

    End Sub
End Class

Public Class NotificationItem
    Public Property Id As Integer
    Public Property Title As String
    Public Property Body As String
    Public Property SentAt As DateTime
    Public Property IsRead As Boolean
    Public Property IsUrgent As Boolean
End Class

Public Module NotificationRepository
    Public Function GetNotificationsForUser(userId As Integer) As List(Of NotificationItem)
        Dim list As New List(Of NotificationItem)

        ' 1. Cek Deadline SPT (Januari - Maret)
        If Date.Today.Month <= 3 Then
            list.Add(New NotificationItem With {
                .Id = 1,
                .Title = "⚠️ Reminder: Deadline SPT Tahunan",
                .Body = "Jangan lupa lapor SPT Tahunan Orang Pribadi Anda sebelum 31 Maret " & Date.Today.Year & "." & vbCrLf & 
                       "Keterlambatan pelaporan dapat dikenakan sanksi administrasi berupa denda.",
                .SentAt = Date.Today,
                .IsRead = False,
                .IsUrgent = True
            })
        End If

        ' 2. Cek Status Kurang Bayar dari Database
        Try
            If Not String.IsNullOrEmpty(Module1.CurrentUserNIK) Then
                Using conn = GetConnection()
                    If OpenConnection(conn) Then
                        Dim query = "SELECT TOP 5 TahunPajak, PPhKurangLebih, TanggalInput FROM tbl_SPT " &
                                   "WHERE NIK = @NIK AND StatusBayar = 'Kurang Bayar' " &
                                   "ORDER BY TanggalInput DESC"
                        
                        Using cmd As New SqlClient.SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)
                            Using reader = cmd.ExecuteReader()
                                Dim idCounter = 100
                                While reader.Read()
                                    Dim tahun = reader("TahunPajak").ToString()
                                    Dim kurang = If(IsDBNull(reader("PPhKurangLebih")), 0D, Convert.ToDecimal(reader("PPhKurangLebih")))
                                    Dim tgl = Convert.ToDateTime(reader("TanggalInput"))
                                    
                                    list.Add(New NotificationItem With {
                                        .Id = idCounter,
                                        .Title = "⚠️ Tagihan Pajak Belum Lunas",
                                        .Body = $"Laporan SPT Tahun {tahun} Anda tercatat memiliki status KURANG BAYAR sebesar Rp {FormatAngka(kurang)}." & vbCrLf & 
                                               "Mohon segera lakukan pembayaran melalui menu Panduan e-Billing agar tidak terkena bunga denda keterlambatan bayar.",
                                        .SentAt = tgl,
                                        .IsRead = False,
                                        .IsUrgent = True
                                    })
                                    idCounter += 1
                                End While
                            End Using
                        End Using
                    End If
                End Using
            End If

        Catch ex As Exception
            ' Silent fail, just don't add database notifications
        End Try

        ' 2.5 Ambil Notifikasi dari Admin (tbl_Notifikasi)
        Try
            If Not String.IsNullOrEmpty(Module1.CurrentUserNIK) Then
                Dim dt = ModuleWajibPajak.GetNotifikasiByNPWP(Module1.CurrentUserNIK)
                Dim idCounterAdmin = 2000
                For Each row As DataRow In dt.Rows
                    Dim notif As New NotificationItem()
                    notif.Id = Convert.ToInt32(row("ID")) ' Use real DB ID if needed, but here we mix sources
                    notif.Title = row("Judul").ToString()
                    notif.Body = row("Pesan").ToString()
                    notif.SentAt = Convert.ToDateTime(row("TanggalKirim"))
                    notif.IsRead = Convert.ToBoolean(row("IsRead"))
                    notif.IsUrgent = False ' Admin messages standard urgency
                    
                    list.Add(notif)
                Next
            End If
        Catch ex As Exception
        End Try

        ' 3. Info Umum Sistem
        list.Add(New NotificationItem With {
            .Id = 999,
            .Title = "👋 Selamat Datang di TaxEase",
            .Body = "Selamat datang di aplikasi perpajakan TaxEase. Silakan lengkapi Profil Anda terlebih dahulu untuk mendapatkan hasil perhitungan pajak yang akurat. Gunakan menu Simulasi untuk estimasi pajak dan Pengisian SPT untuk pelaporan tahunan.",
            .SentAt = Date.Today.AddDays(-1), ' Yesterday
            .IsRead = True,
            .IsUrgent = False
        })
        
        ' Sort: Urgent first, then by Date Descending
        Return list.OrderByDescending(Function(x) x.IsUrgent).ThenByDescending(Function(x) x.SentAt).ToList()
    End Function
End Module