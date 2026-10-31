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
    'TODO: Ganti implementasi dummy ini dengan query database sebenarnya.
    Public Function GetNotificationsForUser(userId As Integer) As List(Of NotificationItem)
        Return New List(Of NotificationItem) From {
            New NotificationItem With {
                .Id = 1,
                .Title = "Peringatan Kurang Bayar",
                .Body = "Halo WP, kami mendeteksi kekurangan pembayaran pajak sebesar Rp 500.000 untuk periode Januari. Mohon selesaikan sebelum 5 Februari agar terhindar dari denda.",
                .SentAt = DateTime.Now.AddHours(-3),
                .IsRead = False,
                .IsUrgent = True
            },
            New NotificationItem With {
                .Id = 2,
                .Title = "Pengingat Pembaruan Profil",
                .Body = "Mohon lengkapi data profil Anda agar proses pelaporan pajak lebih cepat dan akurat.",
                .SentAt = DateTime.Now.AddDays(-2),
                .IsRead = False,
                .IsUrgent = False
            },
            New NotificationItem With {
                .Id = 3,
                .Title = "Terima kasih telah melapor",
                .Body = "Laporan pajak bulan sebelumnya telah kami terima. Simpan bukti penerimaan untuk arsip Anda.",
                .SentAt = DateTime.Now.AddDays(-7),
                .IsRead = True,
                .IsUrgent = False
            }
        }
    End Function
End Module