Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Module Module1
    Public CurrentUserNIK As String = ""

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danen\Tugas_Kuliah\Tugas_PNJ\Pemograman Visual\PBL\PBLPajak\PBLPajak (3)\PBLPajak\project_pajak\Database1.mdf;Integrated Security=True")
    End Function

    ' ========== FUNGSI BUKA KONEKSI ==========
    Public Function OpenConnection(conn As SqlConnection) As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Error membuka koneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ========== FUNGSI TUTUP KONEKSI ==========
    Public Sub CloseConnection(conn As SqlConnection)
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            ' Ignore error saat menutup koneksi
        End Try
    End Sub

    ' ========== FUNGSI HASH PASSWORD ==========
    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    ' ========== FUNGSI VALIDASI EMAIL ==========
    Public Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    ' ========== FUNGSI VALIDASI NIK ==========
    Public Function IsValidNIK(nik As String) As Boolean
        If String.IsNullOrEmpty(nik) OrElse nik.Length <> 16 Then Return False
        For Each c As Char In nik
            If Not Char.IsDigit(c) Then Return False
        Next
        Return True
    End Function

    ' ========== FUNGSI FORMAT ANGKA ==========
    Public Function FormatAngka(angka As Decimal) As String
        Return Format(angka, "N0")
    End Function

    ' ========== FUNGSI PARSE ANGKA ==========
    Public Function ParseAngka(angkaText As String) As Decimal
        Dim cleanText As String = angkaText.Replace(".", "").Replace(",", "")
        If IsNumeric(cleanText) Then
            Return Decimal.Parse(cleanText)
        Else
            Return 0
        End If
    End Function

    ' ========== FUNGSI VALIDASI NPWP ==========
    Public Function IsValidNPWP(npwp As String) As Boolean
        ' Format: XX.XXX.XXX.X-XXX.XXX (15 digit) atau 16 digit angka (format baru/NIK)
        Dim pattern15 As String = "^\d{2}\.\d{3}\.\d{3}\.\d{1}-\d{3}\.\d{3}$"
        Dim pattern16 As String = "^\d{16}$"
        
        Return Regex.IsMatch(npwp, pattern15) OrElse Regex.IsMatch(npwp, pattern16)
    End Function

    ' ========== FUNGSI GENERATE NOMOR SPT ==========
    Public Function GenerateNomorSPT(tahun As Integer, masa As Integer, npwp As String) As String
        ' Format: 00001/SPT/PPh21/2024/01
        Dim random As New Random()
        Dim nomor = random.Next(10000, 99999).ToString()
        Dim masaStr = masa.ToString("00")
        Return $"{nomor}/SPT/PPh21/{tahun}/{masaStr}"
    End Function
    Public Sub CheckAndFixDatabase()
        Using conn As SqlConnection = GetConnection()
            Try
                If OpenConnection(conn) Then
                    ' 1. Create tbl_PemberiKerja if not exists
                    Dim createTableQuery As String = "
                        IF OBJECT_ID('dbo.tbl_PemberiKerja', 'U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.tbl_PemberiKerja (
                                ID INT IDENTITY(1,1) PRIMARY KEY,
                                NomorSK NVARCHAR(50),
                                NamaPerusahaan NVARCHAR(100),
                                NoDokumenPendirian NVARCHAR(50),
                                NIKNotaris NVARCHAR(20),
                                JenisModal NVARCHAR(50),
                                ModalDasar DECIMAL(18,2),
                                ModalDitempatkan DECIMAL(18,2),
                                Email NVARCHAR(100),
                                NoHP NVARCHAR(20),
                                KodeKLU NVARCHAR(20),
                                MetodePembukuan NVARCHAR(50),
                                MemilikiPegawai BIT,
                                JumlahPegawai INT,
                                Jalan NVARCHAR(200),
                                Provinsi NVARCHAR(50),
                                Kota NVARCHAR(50),
                                Kecamatan NVARCHAR(50),
                                Kelurahan NVARCHAR(50),
                                StatusSewa BIT,
                                NamaPemilikSewa NVARCHAR(100),
                                TanggalRegistrasi DATETIME,
                                IsActive BIT
                            )
                        END"
                    Using cmd As New SqlCommand(createTableQuery, conn)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 1b. Create tbl_Pengaturan if not exists
                    Dim createPengaturanQuery As String = "
                        IF OBJECT_ID('dbo.tbl_Pengaturan', 'U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.tbl_Pengaturan (
                                [Key] NVARCHAR(50) PRIMARY KEY,
                                [Value] NVARCHAR(MAX)
                            )
                            -- Insert default default if not exists
                            INSERT INTO dbo.tbl_Pengaturan ([Key], [Value]) VALUES ('BatasLaporTanggal', '20')
                        END"
                    Using cmd As New SqlCommand(createPengaturanQuery, conn)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 1c. Create tbl_Gaji if not exists
                    Dim createGajiQuery As String = "
                        IF OBJECT_ID('dbo.tbl_Gaji', 'U') IS NULL
                        BEGIN
                            CREATE TABLE dbo.tbl_Gaji (
                                ID INT IDENTITY(1,1) PRIMARY KEY,
                                PemberiKerjaNPWP NVARCHAR(50),
                                NPWPPegawai NVARCHAR(50),
                                NamaPegawai NVARCHAR(100),
                                MasaPajak INT,
                                TahunPajak INT,
                                GajiBruto DECIMAL(18,2),
                                PPhDipotong DECIMAL(18,2),
                                TanggalInput DATETIME
                            )
                        END"
                    Using cmd As New SqlCommand(createGajiQuery, conn)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 2. Check and add columns to tbl_SPT based on User's Schema
                    Dim columnsToCheck As New Dictionary(Of String, String) From {
                        {"MasaPajak", "INT"},
                        {"StatusPembetulan", "INT"},
                        {"PenghasilanBruto", "DECIMAL(18, 2)"},
                        {"PenghasilanNetto", "DECIMAL(18, 2)"},
                        {"PPhTerutang", "DECIMAL(18, 2)"},
                        {"PPhDipotong", "DECIMAL(18, 2)"},
                        {"PPhKurangLebih", "DECIMAL(18, 2)"},
                        {"StatusBayar", "NVARCHAR(20)"},
                        {"TanggalInput", "DATETIME"},
                        {"TanggalUpdate", "DATETIME"}
                    }

                    For Each col As KeyValuePair(Of String, String) In columnsToCheck
                        Dim checkQuery As String = $"IF COL_LENGTH('tbl_SPT', '{col.Key}') IS NULL ALTER TABLE tbl_SPT ADD {col.Key} {col.Value}"
                        Using cmd As New SqlCommand(checkQuery, conn)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next
                End If
                ' Fix Profile Tables
                ModuleWajibPajak.CheckAndCreateProfileTables()
            Catch ex As Exception
                ' Log error or silently continue (don't block login)
                Debug.WriteLine("Database fix error: " & ex.Message)
            End Try
        End Using
    End Sub
End Module
