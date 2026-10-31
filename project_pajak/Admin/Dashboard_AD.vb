Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Data.SqlClient

Imports System.Drawing.Printing

Namespace Admin
    Public Class Dashboard_AD
        Private _kepatuhanData As New List(Of KepatuhanWP)
        Private _batasLaporTanggal As Date

        Public Sub New()
            InitializeComponent()
            _kepatuhanData = New List(Of KepatuhanWP)()
            _batasLaporTanggal = New Date(DateTime.Now.Year, DateTime.Now.Month, 20) ' Default: tanggal 20 tiap bulan
        End Sub


        Private Sub Dashboard_AD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                ' Add Logout Menu dynamically
                Dim menuLogout As New ToolStripMenuItem("Keluar")
                menuLogout.ForeColor = Color.White
                ' Font setup if needed, but default is fine or copy from others
                AddHandler menuLogout.Click, AddressOf MenuLogout_Click
                menuMain.Items.Add(menuLogout)

                ConfigureDataGrid()
                LoadPengaturan()
                RefreshDashboard()
            Catch ex As Exception
                MessageBox.Show("Gagal memuat dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub MenuLogout_Click(sender As Object, e As EventArgs)
            Dim result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim frm As New Login
                frm.Show()
                Me.Close()
            End If
        End Sub
        Private Sub ConfigureDataGrid()
            dgvKepatuhan.AutoGenerateColumns = False
            dgvKepatuhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvKepatuhan.MultiSelect = False
            dgvKepatuhan.AllowUserToResizeRows = False
            dgvKepatuhan.RowTemplate.Height = 35

            ' Styling
            dgvKepatuhan.EnableHeadersVisualStyles = False
            dgvKepatuhan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 81, 181)
            dgvKepatuhan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvKepatuhan.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            dgvKepatuhan.ColumnHeadersHeight = 40
            dgvKepatuhan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            dgvKepatuhan.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 149, 237)
            dgvKepatuhan.DefaultCellStyle.SelectionForeColor = Color.White
        End Sub

        Private Sub LoadPengaturan()
            ' Load batas tanggal dari database (Format: yyyy-MM-dd)
            Try
                Using conn As SqlConnection = GetConnection()
                    If OpenConnection(conn) Then
                        Dim query As String = "SELECT Value FROM tbl_Pengaturan WHERE [Key] = 'BatasLaporTanggal'"
                        Using cmd As New SqlCommand(query, conn)
                            Dim result = cmd.ExecuteScalar()
                            If result IsNot Nothing Then
                                Dim savedDate As Date
                                If Date.TryParse(result.ToString(), savedDate) Then
                                    _batasLaporTanggal = savedDate
                                Else
                                    ' Backward compatibility or invalid format
                                    ' Default to 31 March of current year
                                    _batasLaporTanggal = New Date(DateTime.Now.Year, 3, 31)
                                End If
                            Else
                                ' Default if not set
                                _batasLaporTanggal = New Date(DateTime.Now.Year, 3, 31)
                            End If
                        End Using
                    End If
                End Using
                dtpBatasLapor.Value = _batasLaporTanggal
            Catch ex As Exception
                ' Fallback to default
                dtpBatasLapor.Value = _batasLaporTanggal
            End Try
        End Sub

        Private Sub RefreshDashboard()
            LoadKepatuhanData()
            UpdateStatistik()
        End Sub

        Private Sub LoadKepatuhanData()
            _kepatuhanData.Clear()
            Dim dbData = GetKepatuhanDataFromDB()
            For Each item In dbData
                _kepatuhanData.Add(item)
            Next
            dgvKepatuhan.DataSource = _kepatuhanData
        End Sub

        Private Function GetKepatuhanDataFromDB() As List(Of KepatuhanWP)
            Dim data As New List(Of KepatuhanWP)
            Try
                Using conn As SqlConnection = GetConnection()
                    If OpenConnection(conn) Then
                        ' Query: Get All WP and their SPT for the TARGET TAX YEAR
                        ' Target Tax Year = Deadline Year - 1
                        Dim targetTaxYear As Integer = _batasLaporTanggal.Year - 1

                        Dim query As String = "
                            SELECT 0 as ID, u.Username, u.NamaLengkap, s.TanggalInput 
                            FROM tbl_Users u 
                            LEFT JOIN tbl_SPT s ON u.Username = s.NIK 
                                AND s.TahunPajak = @TargetTaxYear
                            WHERE u.Role = 'WAJIBPAJAK'"

                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@TargetTaxYear", targetTaxYear)

                            Using reader As SqlDataReader = cmd.ExecuteReader()
                                While reader.Read()
                                    Dim item As New KepatuhanWP()
                                    item.IdWP = Convert.ToInt32(reader("ID"))
                                    item.NPWP = reader("Username").ToString()
                                    item.NamaWP = reader("NamaLengkap").ToString()

                                    If Not IsDBNull(reader("TanggalInput")) Then
                                        item.TanggalLapor = Convert.ToDateTime(reader("TanggalInput"))
                                        
                                        ' Determine status based on Deadline
                                        If item.TanggalLapor.Value.Date <= _batasLaporTanggal.Date Then
                                            item.StatusKepatuhan = "Sudah Lapor"
                                        Else
                                            item.StatusKepatuhan = "Telat Lapor"
                                        End If
                                    Else
                                        item.TanggalLapor = Nothing
                                        item.StatusKepatuhan = "Belum Lapor"
                                    End If
                                    
                                    data.Add(item)
                                End While
                            End Using
                        End Using
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error mengambil data kepatuhan: " & ex.Message)
            End Try
            Return data
        End Function

        Private Sub UpdateStatistik()
            Dim listData As List(Of KepatuhanWP) = _kepatuhanData.ToList()
            Dim sudahLapor As Integer = 0
            Dim belumLapor As Integer = 0
            Dim telatLapor As Integer = 0

            For Each x In listData
                If x.StatusKepatuhan IsNot Nothing Then
                    If x.StatusKepatuhan.Contains("Sudah Lapor") Then
                        sudahLapor += 1
                    ElseIf x.StatusKepatuhan = "Belum Lapor" Then
                        belumLapor += 1
                    ElseIf x.StatusKepatuhan = "Telat Lapor" Then
                        telatLapor += 1
                    End If
                End If
            Next

            lblSudahCount.Text = $"{sudahLapor} Orang"
            lblBelumCount.Text = $"{belumLapor} Orang"
            lblTelatCount.Text = $"{telatLapor} Orang"

        End Sub



        Private Sub menuManajemenPengguna_Click(sender As Object, e As EventArgs) Handles menuManajemenPengguna.Click
            Try
                Dim formManajemen As New ManajemenPengguna()
                formManajemen.ShowDialog()
                RefreshDashboard() ' Refresh setelah kembali dari manajemen pengguna
            Catch ex As Exception
                MessageBox.Show("Gagal membuka form Manajemen Pengguna: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub menuPengaturanAdmin_Click(sender As Object, e As EventArgs) Handles menuPengaturanAdmin.Click
            Try
                Dim formPengaturan As New Pengaturan_AD()
                formPengaturan.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Gagal membuka form Pengaturan Admin: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnSimpanPengaturan_Click(sender As Object, e As EventArgs) Handles btnSimpanPengaturan.Click
            Try
                _batasLaporTanggal = dtpBatasLapor.Value

                ' Simpan ke database (Full Date)
                Using conn As SqlConnection = GetConnection()
                    If OpenConnection(conn) Then
                        ' Upsert (Merge or Check then Insert/Update)
                        Dim valStr As String = _batasLaporTanggal.ToString("yyyy-MM-dd")
                        
                        Dim updateQuery As String = "UPDATE tbl_Pengaturan SET Value = @val WHERE [Key] = 'BatasLaporTanggal'"
                        Using cmd As New SqlCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("@val", valStr)
                            Dim rows = cmd.ExecuteNonQuery()
                            If rows = 0 Then
                                Dim insertQuery As String = "INSERT INTO tbl_Pengaturan ([Key], [Value]) VALUES ('BatasLaporTanggal', @val)"
                                Using cmdInsert As New SqlCommand(insertQuery, conn)
                                    cmdInsert.Parameters.AddWithValue("@val", valStr)
                                    cmdInsert.ExecuteNonQuery()
                                End Using
                            End If
                        End Using
                    End If
                End Using

                MessageBox.Show($"Batas waktu berhasil disimpan: {_batasLaporTanggal:dd MMMM yyyy}." & vbCrLf & 
                                $"Sistem akan mengecek SPT Tahun Pajak {_batasLaporTanggal.Year - 1}.", 
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh dashboard untuk update status kepatuhan
                RefreshDashboard()
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan pengaturan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
            Try
                If _kepatuhanData.Count = 0 Then
                    MessageBox.Show("Tidak ada data untuk diekspor.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                Using sfd As New SaveFileDialog()
                    sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
                    sfd.FileName = $"Laporan_Kepatuhan_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
                    sfd.Title = "Export ke CSV (Excel)"

                    If sfd.ShowDialog() = DialogResult.OK Then
                        ExportToCSV(sfd.FileName)
                        MessageBox.Show("Data berhasil diekspor ke CSV!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Tanya apakah mau buka file
                        If MessageBox.Show("Apakah Anda ingin membuka file?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Process.Start(New ProcessStartInfo(sfd.FileName) With {.UseShellExecute = True})
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal mengekspor ke Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
            Try
                If _kepatuhanData.Count = 0 Then
                    MessageBox.Show("Tidak ada data untuk diekspor.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                Dim pd As New PrintDocument()
                pd.DefaultPageSettings.Landscape = False
                pd.DocumentName = "Laporan_Kepatuhan_WP_" & DateTime.Now.ToString("yyyyMMdd")
                AddHandler pd.PrintPage, AddressOf PrintPageHandler

                Dim ppd As New PrintPreviewDialog()
                ppd.Document = pd
                ppd.WindowState = FormWindowState.Maximized
                ppd.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("Gagal menyiapkan export PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
            Dim g As Graphics = e.Graphics
            Dim fontTitle As New Font("Segoe UI", 16, FontStyle.Bold)
            Dim fontHeader As New Font("Segoe UI", 10, FontStyle.Bold)
            Dim fontData As New Font("Segoe UI", 10, FontStyle.Regular)
            Dim brushBlack As New SolidBrush(Color.Black)
            
            Dim x As Integer = 50
            Dim y As Integer = 50
            Dim rowHeight As Integer = 30
            Dim colWidths As Integer() = {200, 150, 150, 150} ' Nama, NPWP, Tanggal, Status

            ' Title
            g.DrawString("Laporan Kepatuhan Wajib Pajak", fontTitle, brushBlack, x, y)
            y += 40
            g.DrawString("Periode Tahun Pajak: " & (_batasLaporTanggal.Year - 1).ToString(), fontHeader, brushBlack, x, y)
            y += 40

            ' Table Header
            Dim headers As String() = {"Nama WP", "NPWP", "Tanggal Lapor", "Status"}
            Dim currentX As Integer = x
            For i As Integer = 0 To headers.Length - 1
                g.FillRectangle(Brushes.LightGray, currentX, y, colWidths(i), rowHeight)
                g.DrawRectangle(Pens.Black, currentX, y, colWidths(i), rowHeight)
                g.DrawString(headers(i), fontHeader, brushBlack, currentX + 5, y + 5)
                currentX += colWidths(i)
            Next
            y += rowHeight

            ' Table Data
            For Each item In _kepatuhanData
                currentX = x
                
                ' Check page bounds
                If y + rowHeight > e.PageBounds.Height - 50 Then
                    e.HasMorePages = True
                    Return ' Simple pagination support
                End If

                Dim rects As Rectangle() = {
                    New Rectangle(currentX, y, colWidths(0), rowHeight),
                    New Rectangle(currentX + colWidths(0), y, colWidths(1), rowHeight),
                    New Rectangle(currentX + colWidths(0) + colWidths(1), y, colWidths(2), rowHeight),
                    New Rectangle(currentX + colWidths(0) + colWidths(1) + colWidths(2), y, colWidths(3), rowHeight)
                }

                Dim tglStr = If(item.TanggalLapor.HasValue, item.TanggalLapor.Value.ToString("dd/MM/yyyy"), "-")
                Dim vals As String() = {item.NamaWP, item.NPWP, tglStr, item.StatusKepatuhan}

                For i As Integer = 0 To 3
                    g.DrawRectangle(Pens.Black, rects(i))
                    g.DrawString(vals(i), fontData, brushBlack, rects(i).X + 5, rects(i).Y + 5)
                Next
                y += rowHeight
            Next
            
            e.HasMorePages = False
        End Sub
        Private Sub ExportToCSV(filePath As String)
            Using writer As New StreamWriter(filePath, False, System.Text.Encoding.UTF8)
                ' Header
                writer.WriteLine("Nama WP,NPWP,Tanggal Lapor,Status Kepatuhan")

                ' Data
                For Each item In _kepatuhanData
                    Dim tanggalStr = If(item.TanggalLapor.HasValue, item.TanggalLapor.Value.ToString("dd/MM/yyyy"), "-")
                    writer.WriteLine($"""{item.NamaWP}"",""{item.NPWP}"",""{tanggalStr}"",""{item.StatusKepatuhan}""")
                Next
            End Using
        End Sub

        ' ===== DataGridView Formatting =====
        Private Sub dgvKepatuhan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvKepatuhan.CellFormatting
            If e.RowIndex < 0 Then Return

            Dim item = TryCast(dgvKepatuhan.Rows(e.RowIndex).DataBoundItem, KepatuhanWP)
            If item Is Nothing Then Return

            ' Format tanggal
            If dgvKepatuhan.Columns(e.ColumnIndex).Name = "colTanggalLapor" Then
                If item.TanggalLapor.HasValue Then
                    e.Value = item.TanggalLapor.Value.ToString("dd MMMM yyyy")
                Else
                    e.Value = "-"
                End If
            End If

            ' Warna baris berdasarkan status
            If dgvKepatuhan.Columns(e.ColumnIndex).Name = "colStatus" Then
                If item.StatusKepatuhan.Contains("Sudah Lapor") Then
                    e.CellStyle.ForeColor = Color.FromArgb(56, 142, 60)
                    e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
                ElseIf item.StatusKepatuhan = "Belum Lapor" Then
                    e.CellStyle.ForeColor = Color.FromArgb(245, 124, 0)
                    e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
                ElseIf item.StatusKepatuhan = "Telat Lapor" Then
                    e.CellStyle.ForeColor = Color.FromArgb(211, 47, 47)
                    e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
                End If
            End If
        End Sub
    End Class
End Namespace