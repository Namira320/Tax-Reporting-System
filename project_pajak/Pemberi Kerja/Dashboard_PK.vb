Imports System.Drawing
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Dashboard_PK

    Private Sub Dashboard_PK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi data
        ModuleWajibPajak.CheckAndCreateProfileTables()
        LoadDashboardData()
        LabelTitle.Text = "Selamat Datang, Pemberi Kerja"

        ' Add icon placeholders for better visual
        AddIconPlaceholders()

        ' Setup responsive layout
        AddHandler Me.Resize, AddressOf Dashboard_PK_Resize
        AdjustCardLayout()
    End Sub

    Private Sub Dashboard_PK_Resize(sender As Object, e As EventArgs)
        ' Adjust layout when form is resized
        AdjustCardLayout()
    End Sub

    Private Sub AdjustCardLayout()
        ' Prevent layout during initialization
        If PanelCards.Width < 100 Then Return

        ' Get available width from PanelCards
        Dim availableWidth As Integer = PanelCards.Width
        Dim cardSpacing As Integer = 18  ' Consistent spacing
        Dim numberOfCards As Integer = 3
        Dim cardHeight As Integer = 160

        ' Calculate total spacing needed
        Dim totalSpacing As Integer = cardSpacing * (numberOfCards - 1)

        ' Calculate card width - distribute remaining space equally
        Dim cardWidth As Integer = (availableWidth - totalSpacing) \ numberOfCards

        ' Minimum and maximum card width constraints
        If cardWidth < 280 Then cardWidth = 280
        If cardWidth > 480 Then cardWidth = 480

        ' Cards always start from left edge (0,0) for consistent alignment
        Dim startX As Integer = 0

        ' Adjust card sizes and positions with equal spacing - ALWAYS FROM LEFT
        CardTotalKaryawan.Location = New Point(startX, 0)
        CardTotalKaryawan.Size = New Size(cardWidth, cardHeight)

        CardTotalGaji.Location = New Point(startX + cardWidth + cardSpacing, 0)
        CardTotalGaji.Size = New Size(cardWidth, cardHeight)

        CardTotalPajak.Location = New Point(startX + (cardWidth + cardSpacing) * 2, 0)
        CardTotalPajak.Size = New Size(cardWidth, cardHeight)

        ' Table width fills ENTIRE available width (not just card width)
        ' Get full width from PanelMainContent minus margins
        If PanelMainContent.Width > 0 Then
            Dim tableWidth As Integer = PanelMainContent.Width - 40  ' 20px margin on each side
            GroupBoxDataKaryawan.Width = tableWidth
            GroupBoxDataKaryawan.Location = New Point(20, GroupBoxDataKaryawan.Location.Y)
        End If
    End Sub

    Private Sub AddIconPlaceholders()
        ' Create temporary icon labels for PictureBoxes
        Dim iconKaryawan As New Label With {
            .Text = "👥",
            .Font = New Font("Segoe UI Emoji", 30.0!, FontStyle.Regular),
            .ForeColor = Color.White,
            .BackColor = Color.Transparent,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Fill
        }
        PictureBoxKaryawan.Controls.Add(iconKaryawan)

        Dim iconGaji As New Label With {
            .Text = "💰",
            .Font = New Font("Segoe UI Emoji", 30.0!, FontStyle.Regular),
            .ForeColor = Color.White,
            .BackColor = Color.Transparent,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Fill
        }
        PictureBoxGaji.Controls.Add(iconGaji)

        Dim iconPajak As New Label With {
            .Text = "📊",
            .Font = New Font("Segoe UI Emoji", 30.0!, FontStyle.Regular),
            .ForeColor = Color.White,
            .BackColor = Color.Transparent,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Fill
        }
        PictureBoxPajak.Controls.Add(iconPajak)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Login
            frm.Show
            Close
        End If
    End Sub

    Private Sub LoadDashboardData()
        ' Setup DataGridView - Modern Professional Styling
        DataGridViewKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewKaryawan.AllowUserToAddRows = False
        DataGridViewKaryawan.AllowUserToDeleteRows = False
        DataGridViewKaryawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewKaryawan.MultiSelect = False
        DataGridViewKaryawan.ReadOnly = True
        DataGridViewKaryawan.RowHeadersVisible = False

        ' Enhanced modern styling
        DataGridViewKaryawan.BorderStyle = BorderStyle.None
        DataGridViewKaryawan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewKaryawan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewKaryawan.EnableHeadersVisualStyles = False
        DataGridViewKaryawan.GridColor = Color.FromArgb(233, 236, 239)
        DataGridViewKaryawan.BackgroundColor = Color.White

        ' Row height for better readability
        DataGridViewKaryawan.RowTemplate.Height = 40
        DataGridViewKaryawan.ColumnHeadersHeight = 45

        ' Modern header styling
        DataGridViewKaryawan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64)
        DataGridViewKaryawan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridViewKaryawan.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        DataGridViewKaryawan.ColumnHeadersDefaultCellStyle.Padding = New Padding(10, 8, 10, 8)
        DataGridViewKaryawan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        ' Cell styling
        DataGridViewKaryawan.DefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        DataGridViewKaryawan.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41)
        DataGridViewKaryawan.DefaultCellStyle.BackColor = Color.White
        DataGridViewKaryawan.DefaultCellStyle.SelectionBackColor = Color.FromArgb(13, 110, 253)
        DataGridViewKaryawan.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridViewKaryawan.DefaultCellStyle.Padding = New Padding(10, 5, 10, 5)

        ' Alternating row styling for better readability
        DataGridViewKaryawan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250)
        DataGridViewKaryawan.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41)

        DataGridViewKaryawan.Rows.Clear()

        Dim totalKaryawan As Integer = 0
        Dim totalGaji As Decimal = 0
        Dim totalPajak As Decimal = 0

        Try
            Using conn As SqlConnection = Module1.GetConnection()
                If Module1.OpenConnection(conn) Then
                    ' 1. Get Nama Perusahaan (Employer Name) based on CurrentUserNIK
                    Dim namaPerusahaan As String = ""
                    Dim queryEmp As String = "SELECT NamaLengkap FROM tbl_WajibPajak WHERE NIK = @NIK"
                    Using cmdEmp As New SqlCommand(queryEmp, conn)
                        cmdEmp.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)
                        Dim res = cmdEmp.ExecuteScalar()
                        If res IsNot Nothing Then namaPerusahaan = res.ToString()
                    End Using

                    ' HashSet to track NPWPs already added to grid to avoid duplicates
                    Dim addedNPWPs As New HashSet(Of String)

                    ' 2. Query data gaji (Approved/Processed Employees) from tbl_Gaji
                    Dim queryGaji As String = "SELECT NamaPegawai, Jabatan, NPWPPegawai, GajiBruto, PPhDipotong FROM tbl_Gaji WHERE PemberiKerjaNPWP = @pkNpwp AND TahunPajak = @year"

                    Using cmd As New SqlCommand(queryGaji, conn)
                        cmd.Parameters.AddWithValue("@pkNpwp", Module1.CurrentUserNIK)
                        cmd.Parameters.AddWithValue("@year", DateTime.Now.Year)

                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                Dim nama = reader("NamaPegawai").ToString()
                                Dim jabatan = If(IsDBNull(reader("Jabatan")), "", reader("Jabatan").ToString())
                                Dim npwp = reader("NPWPPegawai").ToString()
                                Dim gaji = Convert.ToDecimal(reader("GajiBruto"))
                                Dim pajak = Convert.ToDecimal(reader("PPhDipotong"))

                                DataGridViewKaryawan.Rows.Add(nama, jabatan, npwp, Module1.FormatAngka(gaji), "Aktif")
                                addedNPWPs.Add(npwp)

                                totalKaryawan += 1
                                totalGaji += gaji
                                totalPajak += pajak
                            End While
                        End Using
                    End Using

                    ' 3. Query NEW/Potential Employees via TempatKerja match
                    If Not String.IsNullOrEmpty(namaPerusahaan) Then
                        ' Modified to get StatusPekerjaan and Jabatan
                        Dim queryPotensial As String = "SELECT NamaLengkap, Jabatan, NIK, NPWP, StatusPekerjaan FROM tbl_WajibPajak WHERE TempatKerja LIKE @TempatKerja AND NIK <> @MyNIK"
                         
                        Using cmdPot As New SqlCommand(queryPotensial, conn)
                            cmdPot.Parameters.AddWithValue("@TempatKerja", namaPerusahaan)
                            cmdPot.Parameters.AddWithValue("@MyNIK", Module1.CurrentUserNIK) ' Don't list self

                            Using reader As SqlDataReader = cmdPot.ExecuteReader()
                                While reader.Read()
                                    Dim npwp = reader("NPWP").ToString()
                                     
                                    ' Only add if not already in grid
                                    If Not addedNPWPs.Contains(npwp) Then
                                        Dim nama = reader("NamaLengkap").ToString()
                                        Dim jabatan = If(IsDBNull(reader("Jabatan")), "", reader("Jabatan").ToString())
                                        Dim statusKerja = If(IsDBNull(reader("StatusPekerjaan")), "", reader("StatusPekerjaan").ToString())

                                        Dim statusDisplay As String = "Menunggu Data Gaji"
                                        If statusKerja.Equals("Pensiun", StringComparison.OrdinalIgnoreCase) Then
                                            statusDisplay = "Pensiun (Non-Aktif)"
                                        End If

                                        Dim rowIndex = DataGridViewKaryawan.Rows.Add(nama, jabatan, npwp, "0", statusDisplay)
                                        
                                        ' Highlight if Pensiun
                                        If statusDisplay.Contains("Pensiun") Then
                                            DataGridViewKaryawan.Rows(rowIndex).DefaultCellStyle.ForeColor = Color.Red
                                            DataGridViewKaryawan.Rows(rowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
                                        End If
                                        
                                        totalKaryawan += 1
                                    End If
                                End While
                            End Using
                        End Using
                    End If

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data dashboard: " & ex.Message)
        End Try

        ' Update card values
        LabelTotalKaryawanValue.Text = totalKaryawan.ToString()
        LabelTotalGajiValue.Text = "Rp " & Module1.FormatAngka(totalGaji)
        LabelTotalPajakValue.Text = "Rp " & Module1.FormatAngka(totalPajak)
    End Sub

    ' Menu Events
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Login
            frm.Show()
            Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub ImporDataCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporDataCSVToolStripMenuItem.Click
        Dim frm As New ImportGaji()
        frm.ShowDialog()
    End Sub

    Private Sub CetakBuktiPotongToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakBuktiPotongToolStripMenuItem.Click
        Dim frm As New CetakBuktiPotong()
        frm.ShowDialog()
    End Sub
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
    End Sub
End Class
