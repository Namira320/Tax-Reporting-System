Imports System.Data.SqlClient

Module ModuleWajibPajak
    ' Model class matching tbl_WajibPajak
    Public Class WajibPajakModel
        Public Property ID As Integer
        Public Property NIK As String
        ' NPWP maps to NIK
        Public Property NPWP As String
            Get
                Return NIK
            End Get
            Set(value As String)
                ' Ignore or set NIK if needed, but NIK is primary
                NIK = value
            End Set
        End Property
        Public Property Email As String
        Public Property NamaLengkap As String
        Public Property Pekerjaan As String
        Public Property Jabatan As String ' New Field
        Public Property TempatLahir As String
        Public Property PenghasilanPerBulan As Decimal
        Public Property TanggalLahir As Date
        Public Property TempatKerja As String
        Public Property StatusPernikahan As String
        Public Property Alamat As String
        Public Property Provinsi As String
        Public Property Kota As String
        Public Property KodePos As String
        Public Property StatusHubunganKeluarga As String
        ' Password handled separately usually
        Public Property Password As String
        Public Property NegaraAsal As String
        Public Property JenisKelamin As String
        Public Property NoHandphone As String
        Public Property TanggalRegistrasi As DateTime
        Public Property StatusPTKP As String
        Public Property JenisWajibPajak As String
        Public Property StatusPekerjaan As String
        Public Property NamaTempatKerja As String
        Public Property NomorRegistrasi As String
        Public Property IsActive As Boolean
    End Class

    ' ========== FUNGSI CHECK & CREATE TABEL PROFIL ==========
    ' ========== FUNGSI CHECK & CREATE TABEL PROFIL ==========
    Public Sub CheckAndCreateProfileTables()
        Dim conn As SqlConnection = GetConnection()
        Try
            If OpenConnection(conn) Then
                ' Execute the Schema Update Logic directly here
                Dim sql As String = "
                    -- 1. DROP Obsolete Tables
                    IF OBJECT_ID('dbo.tbl_Profil_Alamat', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Alamat;
                    IF OBJECT_ID('dbo.tbl_Profil_Ikhtisar', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Ikhtisar;
                    IF OBJECT_ID('dbo.tbl_Profil_InfoUmum', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_InfoUmum;
                    IF OBJECT_ID('dbo.tbl_Profil_Kontak', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Kontak;
                    IF OBJECT_ID('dbo.tbl_Profil_Keluarga', 'U') IS NOT NULL 
                    BEGIN
                        DECLARE @sql NVARCHAR(MAX) = N'';
                        SELECT @sql += 'ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id)) + '.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + ' DROP CONSTRAINT ' + QUOTENAME(name) + ';'
                        FROM sys.foreign_keys WHERE referenced_object_id = OBJECT_ID('dbo.tbl_Profil_Keluarga');
                        EXEC sp_executesql @sql;
                        DROP TABLE dbo.tbl_Profil_Keluarga;
                    END

                    -- 2. Ensure Family Table Exists
                    IF OBJECT_ID('dbo.tbl_Profil_Keluarga_Anak', 'U') IS NULL
                    BEGIN
                        CREATE TABLE [dbo].[tbl_Profil_Keluarga_Anak] (
                            [ID] INT IDENTITY(1,1) PRIMARY KEY,
                            [WajibPajakID] INT NOT NULL,
                            [NamaAnak] NVARCHAR(100),
                            [TanggalLahir] DATE,
                            [StatusTanggungan] NVARCHAR(50),
                            [Pekerjaan] NVARCHAR(100),
                            CONSTRAINT [FK_Keluarga_WajibPajak] FOREIGN KEY ([WajibPajakID]) REFERENCES [dbo].[tbl_WajibPajak] ([ID]) ON DELETE CASCADE
                        );
                    END
                    
                    ELSE
                    BEGIN
                        -- If table exists, ensure columns exist
                        IF COL_LENGTH('dbo.tbl_Profil_Keluarga_Anak', 'WajibPajakID') IS NULL
                        BEGIN
                            ALTER TABLE dbo.tbl_Profil_Keluarga_Anak ADD WajibPajakID INT;
                        END
                        
                        IF COL_LENGTH('dbo.tbl_Profil_Keluarga_Anak', 'Pekerjaan') IS NULL
                        BEGIN
                            ALTER TABLE dbo.tbl_Profil_Keluarga_Anak ADD Pekerjaan NVARCHAR(100);
                        END
                    END

                    -- 2B. Ensure tbl_Gaji Exists and has Jabatan
                    IF OBJECT_ID('dbo.tbl_Gaji', 'U') IS NULL
                    BEGIN
                        CREATE TABLE [dbo].[tbl_Gaji] (
                            [ID] INT IDENTITY(1,1) PRIMARY KEY,
                            [PemberiKerjaNPWP] NVARCHAR(50),
                            [NPWPPegawai] NVARCHAR(50),
                            [NamaPegawai] NVARCHAR(100),
                            [Jabatan] NVARCHAR(100),
                            [MasaPajak] INT,
                            [TahunPajak] INT,
                            [GajiBruto] DECIMAL(18,2),
                            [PPhDipotong] DECIMAL(18,2),
                            [TanggalInput] DATETIME
                        );
                    END
                    ELSE
                    BEGIN
                        IF COL_LENGTH('dbo.tbl_Gaji', 'Jabatan') IS NULL 
                            ALTER TABLE dbo.tbl_Gaji ADD Jabatan NVARCHAR(100);
                    END

                    -- 3. Ensure tbl_WajibPajak Columns
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'Provinsi') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD Provinsi NVARCHAR(100);
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'Kota') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD Kota NVARCHAR(100);
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'KodePos') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD KodePos NVARCHAR(10);
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'NomorRegistrasi') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD NomorRegistrasi NVARCHAR(50);
                    
                    -- Force Ensure Size for StatusPTKP
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'StatusPTKP') IS NULL 
                        ALTER TABLE dbo.tbl_WajibPajak ADD StatusPTKP NVARCHAR(100);
                    ELSE
                        ALTER TABLE dbo.tbl_WajibPajak ALTER COLUMN StatusPTKP NVARCHAR(100);

                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'StatusPekerjaan') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD StatusPekerjaan NVARCHAR(50);
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'Jabatan') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD Jabatan NVARCHAR(100);
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'NamaPasangan') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD NamaPasangan NVARCHAR(100);
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'JumlahTanggungan') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD JumlahTanggungan INT DEFAULT 0;
                    IF COL_LENGTH('dbo.tbl_WajibPajak', 'NPWP') IS NOT NULL 
                    BEGIN
                        -- Remove Constraints on NPWP (Unique, Default, etc)
                        DECLARE @sqlDropConstraint NVARCHAR(MAX) = N'';
                        SELECT @sqlDropConstraint += 'ALTER TABLE tbl_WajibPajak DROP CONSTRAINT ' + QUOTENAME(name) + ';'
                        FROM sys.default_constraints
                        WHERE parent_object_id = OBJECT_ID('tbl_WajibPajak')
                        AND parent_column_id = COLUMNPROPERTY(OBJECT_ID('tbl_WajibPajak'), 'NPWP', 'ColumnId');

                        -- Also remove Unique Constraints / Indexes on NPWP
                        SELECT @sqlDropConstraint += 'ALTER TABLE tbl_WajibPajak DROP CONSTRAINT ' + QUOTENAME(name) + ';'
                        FROM sys.key_constraints
                        WHERE parent_object_id = OBJECT_ID('tbl_WajibPajak')
                        AND type = 'UQ'
                        AND EXISTS (
                            SELECT 1 FROM sys.index_columns ic 
                            WHERE ic.object_id = sys.key_constraints.parent_object_id
                            AND ic.index_id = sys.key_constraints.unique_index_id
                            AND ic.column_id = COLUMNPROPERTY(OBJECT_ID('tbl_WajibPajak'), 'NPWP', 'ColumnId')
                        );

                        EXEC sp_executesql @sqlDropConstraint;

                        -- Now safe to drop
                        ALTER TABLE dbo.tbl_WajibPajak DROP COLUMN NPWP;
                    END
                "
                Using cmd As New SqlCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            Debug.WriteLine("Error checking profile tables: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try
    End Sub

    Public Function IsNIKExist(nik As String) As Boolean
        Dim conn As SqlConnection = GetConnection()

        Try
            If Not OpenConnection(conn) Then Return False

            Dim query As String = "SELECT COUNT(*) FROM tbl_WajibPajak WHERE NIK = @NIK"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NIK", nik)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error cek NIK: " & ex.Message, "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection(conn)
        End Try
    End Function

    ' ========== FUNGSI GET DATA PENGHASILAN ==========
    Public Function GetListPenghasilan() As List(Of String)
        Dim listPenghasilan As New List(Of String)

        listPenghasilan.Add("Pilih Penghasilan")
        listPenghasilan.Add("Rp 0 - 2.000.000")
        listPenghasilan.Add("Rp 2.000.001 - 5.000.000")
        listPenghasilan.Add("Rp 5.000.001 - 10.000.000")
        listPenghasilan.Add("Rp 10.000.001 - 20.000.000")
        listPenghasilan.Add("Rp 20.000.001 - 50.000.000")
        listPenghasilan.Add("Rp 50.000.001 - 100.000.000")
        listPenghasilan.Add("Rp 100.000.001 - 200.000.000")
        listPenghasilan.Add("Rp 200.000.001 - 500.000.000")
        listPenghasilan.Add("Rp 500.000.001 - 1.000.000.000")
        listPenghasilan.Add("> Rp 1.000.000.000")

        Return listPenghasilan
    End Function

    ' ========== FUNGSI KONVERSI PENGHASILAN ==========
    Public Function ConvertPenghasilanToDecimal(penghasilanText As String) As Decimal
        Select Case penghasilanText
            Case "Rp 0 - 2.000.000"
                Return 1000000
            Case "Rp 2.000.001 - 5.000.000"
                Return 3500000
            Case "Rp 5.000.001 - 10.000.000"
                Return 7500000
            Case "Rp 10.000.001 - 20.000.000"
                Return 15000000
            Case "Rp 20.000.001 - 50.000.000"
                Return 35000000
            Case "Rp 50.000.001 - 100.000.000"
                Return 75000000
            Case "Rp 100.000.001 - 200.000.000"
                Return 150000000
            Case "Rp 200.000.001 - 500.000.000"
                Return 350000000
            Case "Rp 500.000.001 - 1.000.000.000"
                Return 750000000
            Case "> Rp 1.000.000.000"
                Return 1500000000
            Case Else
                Return 0
        End Select
    End Function

    ' ========== FUNGSI SIMPAN WAJIB PAJAK ==========
    Public Function SimpanWajibPajak(wp As WajibPajakModel) As Integer
        ' Auto-Fix Schema (Drop NPWP column if exists) before attempting insert
        CheckAndCreateProfileTables()

        Dim conn As SqlConnection = GetConnection()
        Dim transaction As SqlTransaction = Nothing
        Dim newId As Integer = 0

        Try
            If Not OpenConnection(conn) Then Return 0

            transaction = conn.BeginTransaction()

            ' 1. Insert into tbl_Users
            Dim queryUser As String = "INSERT INTO tbl_Users (Username, Password, Role, NamaLengkap, IsActive) VALUES (@Username, @Password, 'WAJIBPAJAK', @NamaLengkap, 1)"
            Using cmdUser As New SqlCommand(queryUser, conn, transaction)
                cmdUser.Parameters.AddWithValue("@Username", wp.NIK) ' NIK as Username
                cmdUser.Parameters.AddWithValue("@Password", HashPassword(wp.Password))
                cmdUser.Parameters.AddWithValue("@NamaLengkap", wp.NamaLengkap)
                cmdUser.ExecuteNonQuery()
            End Using

            ' 2. Insert into tbl_WajibPajak (Removed NPWP Column)
            Dim query As String = "
            INSERT INTO tbl_WajibPajak 
            (NIK, Email, NamaLengkap, Pekerjaan, TempatLahir, PenghasilanPerBulan, 
             TanggalLahir, TempatKerja, StatusPernikahan, Alamat, StatusHubunganKeluarga, 
             Password, NegaraAsal, JenisKelamin, NoHandphone, TanggalRegistrasi, IsActive)
            OUTPUT INSERTED.ID
            VALUES 
            (@NIK, @Email, @NamaLengkap, @Pekerjaan, @TempatLahir, @PenghasilanPerBulan,
             @TanggalLahir, @TempatKerja, @StatusPernikahan, @Alamat, @StatusHubunganKeluarga,
             @Password, @NegaraAsal, @JenisKelamin, @NoHandphone, @TanggalRegistrasi, @IsActive)"

            Using cmd As New SqlCommand(query, conn, transaction)
                cmd.Parameters.AddWithValue("@NIK", wp.NIK)
                ' Removed NPWP Param
                cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrEmpty(wp.Email), DBNull.Value, wp.Email))
                cmd.Parameters.AddWithValue("@NamaLengkap", wp.NamaLengkap)
                cmd.Parameters.AddWithValue("@Pekerjaan", If(String.IsNullOrEmpty(wp.Pekerjaan), DBNull.Value, wp.Pekerjaan))
                cmd.Parameters.AddWithValue("@TempatLahir", If(String.IsNullOrEmpty(wp.TempatLahir), DBNull.Value, wp.TempatLahir))
                cmd.Parameters.AddWithValue("@PenghasilanPerBulan", If(wp.PenghasilanPerBulan = 0, DBNull.Value, wp.PenghasilanPerBulan))
                cmd.Parameters.AddWithValue("@TanggalLahir", If(wp.TanggalLahir = Date.MinValue, DBNull.Value, wp.TanggalLahir))
                cmd.Parameters.AddWithValue("@TempatKerja", If(String.IsNullOrEmpty(wp.TempatKerja), DBNull.Value, wp.TempatKerja))
                cmd.Parameters.AddWithValue("@StatusPernikahan", If(String.IsNullOrEmpty(wp.StatusPernikahan), DBNull.Value, wp.StatusPernikahan))
                cmd.Parameters.AddWithValue("@Alamat", If(String.IsNullOrEmpty(wp.Alamat), DBNull.Value, wp.Alamat))
                cmd.Parameters.AddWithValue("@StatusHubunganKeluarga", If(String.IsNullOrEmpty(wp.StatusHubunganKeluarga), DBNull.Value, wp.StatusHubunganKeluarga))
                cmd.Parameters.AddWithValue("@Password", HashPassword(wp.Password))
                cmd.Parameters.AddWithValue("@NegaraAsal", If(String.IsNullOrEmpty(wp.NegaraAsal), DBNull.Value, wp.NegaraAsal))
                cmd.Parameters.AddWithValue("@JenisKelamin", If(String.IsNullOrEmpty(wp.JenisKelamin), DBNull.Value, wp.JenisKelamin))
                cmd.Parameters.AddWithValue("@NoHandphone", If(String.IsNullOrEmpty(wp.NoHandphone), DBNull.Value, wp.NoHandphone))
                cmd.Parameters.AddWithValue("@TanggalRegistrasi", DateTime.Now)
                cmd.Parameters.AddWithValue("@IsActive", 1)

                newId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            transaction.Commit()
            Return newId

        Catch ex As SqlException
            If transaction IsNot Nothing Then transaction.Rollback()
            If ex.Number = 2627 Then ' Duplicate key
                Throw New Exception("NIK atau NPWP sudah terdaftar!")
            Else
                Throw New Exception("Error database: " & ex.Message)
            End If
        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw New Exception("Error: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try
    End Function

    ' ========== FUNGSI GET DATA BY ID ==========
    Public Function GetWajibPajakById(id As Integer) As WajibPajakModel
        Dim wp As New WajibPajakModel()
        Dim conn As SqlConnection = GetConnection()

        Try
            If Not OpenConnection(conn) Then Return Nothing

            Dim query As String = "SELECT * FROM tbl_WajibPajak WHERE ID = @ID"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        wp.ID = Convert.ToInt32(reader("ID"))
                        wp.NIK = reader("NIK").ToString()
                        wp.NPWP = reader("NIK").ToString() ' Map to NIK since column gone
                        wp.Email = If(IsDBNull(reader("Email")), "", reader("Email").ToString())
                        wp.NamaLengkap = reader("NamaLengkap").ToString()
                        wp.Pekerjaan = If(IsDBNull(reader("Pekerjaan")), "", reader("Pekerjaan").ToString())
                        wp.TempatLahir = If(IsDBNull(reader("TempatLahir")), "", reader("TempatLahir").ToString())
                        wp.PenghasilanPerBulan = If(IsDBNull(reader("PenghasilanPerBulan")), 0, Convert.ToDecimal(reader("PenghasilanPerBulan")))
                        wp.TanggalLahir = If(IsDBNull(reader("TanggalLahir")), Date.MinValue, Convert.ToDateTime(reader("TanggalLahir")))
                        wp.TempatKerja = If(IsDBNull(reader("TempatKerja")), "", reader("TempatKerja").ToString())
                        wp.StatusPernikahan = If(IsDBNull(reader("StatusPernikahan")), "", reader("StatusPernikahan").ToString())
                        wp.Alamat = If(IsDBNull(reader("Alamat")), "", reader("Alamat").ToString())
                        wp.StatusHubunganKeluarga = If(IsDBNull(reader("StatusHubunganKeluarga")), "", reader("StatusHubunganKeluarga").ToString())
                        ' Password not retrieved for security
                        wp.NegaraAsal = If(IsDBNull(reader("NegaraAsal")), "", reader("NegaraAsal").ToString())
                        wp.JenisKelamin = If(IsDBNull(reader("JenisKelamin")), "", reader("JenisKelamin").ToString())
                        wp.NoHandphone = If(IsDBNull(reader("NoHandphone")), "", reader("NoHandphone").ToString())
                        wp.IsActive = Convert.ToBoolean(reader("IsActive"))
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error mengambil data: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection(conn)
        End Try

        Return wp
    End Function

    ' ========== FUNGSI UPDATE DATA ==========
    Public Function UpdateWajibPajak(wp As WajibPajakModel) As Boolean
        Dim conn As SqlConnection = GetConnection()
        Dim transaction As SqlTransaction = Nothing

        Try
            If Not OpenConnection(conn) Then Return False

            transaction = conn.BeginTransaction()

            Dim query As String = "
            UPDATE tbl_WajibPajak SET
                Email = @Email,
                NamaLengkap = @NamaLengkap,
                Pekerjaan = @Pekerjaan,
                TempatLahir = @TempatLahir,
                PenghasilanPerBulan = @PenghasilanPerBulan,
                TanggalLahir = @TanggalLahir,
                TempatKerja = @TempatKerja,
                StatusPernikahan = @StatusPernikahan,
                Alamat = @Alamat,
                StatusHubunganKeluarga = @StatusHubunganKeluarga,
                NegaraAsal = @NegaraAsal,
                JenisKelamin = @JenisKelamin,
                NoHandphone = @NoHandphone
            WHERE ID = @ID"

            Using cmd As New SqlCommand(query, conn, transaction)
                cmd.Parameters.AddWithValue("@ID", wp.ID)
                cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrEmpty(wp.Email), DBNull.Value, wp.Email))
                cmd.Parameters.AddWithValue("@NamaLengkap", wp.NamaLengkap)
                cmd.Parameters.AddWithValue("@Pekerjaan", If(String.IsNullOrEmpty(wp.Pekerjaan), DBNull.Value, wp.Pekerjaan))
                cmd.Parameters.AddWithValue("@TempatLahir", If(String.IsNullOrEmpty(wp.TempatLahir), DBNull.Value, wp.TempatLahir))
                cmd.Parameters.AddWithValue("@PenghasilanPerBulan", If(wp.PenghasilanPerBulan = 0, DBNull.Value, wp.PenghasilanPerBulan))
                cmd.Parameters.AddWithValue("@TanggalLahir", If(wp.TanggalLahir = Date.MinValue, DBNull.Value, wp.TanggalLahir))
                cmd.Parameters.AddWithValue("@TempatKerja", If(String.IsNullOrEmpty(wp.TempatKerja), DBNull.Value, wp.TempatKerja))
                cmd.Parameters.AddWithValue("@StatusPernikahan", If(String.IsNullOrEmpty(wp.StatusPernikahan), DBNull.Value, wp.StatusPernikahan))
                cmd.Parameters.AddWithValue("@Alamat", If(String.IsNullOrEmpty(wp.Alamat), DBNull.Value, wp.Alamat))
                cmd.Parameters.AddWithValue("@StatusHubunganKeluarga", If(String.IsNullOrEmpty(wp.StatusHubunganKeluarga), DBNull.Value, wp.StatusHubunganKeluarga))
                cmd.Parameters.AddWithValue("@NegaraAsal", If(String.IsNullOrEmpty(wp.NegaraAsal), DBNull.Value, wp.NegaraAsal))
                cmd.Parameters.AddWithValue("@JenisKelamin", If(String.IsNullOrEmpty(wp.JenisKelamin), DBNull.Value, wp.JenisKelamin))
                cmd.Parameters.AddWithValue("@NoHandphone", If(String.IsNullOrEmpty(wp.NoHandphone), DBNull.Value, wp.NoHandphone))

                cmd.ExecuteNonQuery()
            End Using

            transaction.Commit()
            Return True

        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            MessageBox.Show("Error update data: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection(conn)
        End Try
    End Function

    ' ========== FUNGSI DELETE DATA ==========
    Public Function DeleteWajibPajak(id As Integer) As Boolean
        Dim conn As SqlConnection = GetConnection()

        Try
            If Not OpenConnection(conn) Then Return False

            Dim query As String = "DELETE FROM tbl_WajibPajak WHERE ID = @ID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                Dim affectedRows As Integer = cmd.ExecuteNonQuery()
                Return affectedRows > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error hapus data: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection(conn)
        End Try
    End Function

    ' ========== FUNGSI GET ALL DATA ==========
    Public Function GetAllWajibPajak() As DataTable
        Dim dt As New DataTable
        Dim conn As SqlConnection = GetConnection()

        Try
            If Not OpenConnection(conn) Then Return dt

            Dim query As String = "SELECT ID, NIK, NamaLengkap, TanggalLahir, StatusPernikahan, NoHandphone, Email, Pekerjaan, PenghasilanPerBulan FROM tbl_WajibPajak ORDER BY NamaLengkap"

            Using da As New SqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error mengambil data: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection(conn)
        End Try

        Return dt
    End Function

    ' ========== FUNGSI NOTIFIKASI ==========
    Public Function KirimNotifikasi(judul As String, pesan As String, penerima As String) As Boolean
        Dim conn As SqlConnection = GetConnection()
        Try
            If OpenConnection(conn) Then
                Dim query As String = "INSERT INTO tbl_Notifikasi (Judul, Pesan, TanggalKirim, PenerimaNPWP, IsRead) VALUES (@Judul, @Pesan, @Tgl, @Penerima, 0)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Judul", judul)
                    cmd.Parameters.AddWithValue("@Pesan", pesan)
                    cmd.Parameters.AddWithValue("@Tgl", DateTime.Now)
                    cmd.Parameters.AddWithValue("@Penerima", penerima)
                    cmd.ExecuteNonQuery()
                End Using
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal kirim notifikasi: " & ex.Message)
        End Try
        Return False
    End Function

    Public Function GetNotifikasiByNPWP(npwp As String) As DataTable
        Dim dt As New DataTable()
        Dim conn As SqlConnection = GetConnection()
        Try
            If OpenConnection(conn) Then
                Dim query As String = "SELECT * FROM tbl_Notifikasi WHERE PenerimaNPWP = 'ALL' OR PenerimaNPWP = @NPWP ORDER BY TanggalKirim DESC"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NPWP", npwp)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End If
        Catch ex As Exception
             ' Silent catch or log
        End Try
        Return dt
    End Function

    ' ========== FUNGSI LOAD PROFIL DATA KOMPLIT (CONSOLIDATED) ==========
    Public Function LoadWajibPajakByNIK(nik As String) As Dictionary(Of String, Object)
        Dim data As New Dictionary(Of String, Object)
        Dim conn As SqlConnection = GetConnection()
        
        Try
            If OpenConnection(conn) Then
                Dim wpID As Integer = 0
                Dim queryWPFull As String = "SELECT * FROM tbl_WajibPajak WHERE NIK = @NIK"
                Using cmd As New SqlCommand(queryWPFull, conn)
                    cmd.Parameters.AddWithValue("@NIK", nik)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                         If reader.Read() Then
                            wpID = Convert.ToInt32(reader("ID"))
                            data("WajibPajakID") = wpID
                            data("NamaWajibPajak") = reader("NamaLengkap").ToString()
                            data("NPWP") = reader("NIK").ToString() ' Use NIK as NPWP
                            data("NIK") = reader("NIK").ToString()
                            
                            data("Email") = If(IsDBNull(reader("Email")), "", reader("Email").ToString())
                            data("Telepon") = If(IsDBNull(reader("NoHandphone")), "", reader("NoHandphone").ToString())
                            data("AlamatLengkap") = If(IsDBNull(reader("Alamat")), "", reader("Alamat").ToString())
                            data("Provinsi") = If(IsDBNull(reader("Provinsi")), "", reader("Provinsi").ToString())
                            data("Kota") = If(IsDBNull(reader("Kota")), "", reader("Kota").ToString())
                            data("KodePos") = If(IsDBNull(reader("KodePos")), "", reader("KodePos").ToString())
                            
                            data("StatusPekerjaan") = If(IsDBNull(reader("StatusPekerjaan")), "", reader("StatusPekerjaan").ToString())
                            If String.IsNullOrEmpty(data("StatusPekerjaan").ToString()) AndAlso Not IsDBNull(reader("Pekerjaan")) Then
                                data("StatusPekerjaan") = reader("Pekerjaan").ToString()
                            End If

                            data("Jabatan") = If(IsDBNull(reader("Jabatan")), "", reader("Jabatan").ToString())
                            
                            data("TempatKerja") = If(IsDBNull(reader("TempatKerja")), "", reader("TempatKerja").ToString())
                            data("TanggalLahir") = If(IsDBNull(reader("TanggalLahir")), DateTime.Now, Convert.ToDateTime(reader("TanggalLahir")))
                            data("StatusPernikahan") = If(IsDBNull(reader("StatusPernikahan")), "", reader("StatusPernikahan").ToString())
                            data("PenghasilanPerBulan") = If(IsDBNull(reader("PenghasilanPerBulan")), 0, Convert.ToDecimal(reader("PenghasilanPerBulan")))
                            
                            data("StatusPTKP") = If(IsDBNull(reader("StatusPTKP")), "", reader("StatusPTKP").ToString())
                            data("JenisWajibPajak") = If(IsDBNull(reader("JenisWajibPajak")), "", reader("JenisWajibPajak").ToString())
                            data("NomorRegistrasi") = If(IsDBNull(reader("NomorRegistrasi")), "", reader("NomorRegistrasi").ToString())
                            data("JenisKelamin") = If(IsDBNull(reader("JenisKelamin")), "", reader("JenisKelamin").ToString())
                            data("TempatLahir") = If(IsDBNull(reader("TempatLahir")), "", reader("TempatLahir").ToString())
                            data("NegaraAsal") = If(IsDBNull(reader("NegaraAsal")), "", reader("NegaraAsal").ToString())

                            ' Load Spouse/Tanggungan directly from WB (New Schema)
                            ' Fallback to 0/Empty if columns don't exist yet (Migration safety handled in CreateTable)
                            Try
                                data("NamaPasangan") = If(IsDBNull(reader("NamaPasangan")), "", reader("NamaPasangan").ToString())
                                data("JumlahTanggungan") = If(IsDBNull(reader("JumlahTanggungan")), "0", reader("JumlahTanggungan").ToString())
                            Catch
                                data("NamaPasangan") = ""
                                data("JumlahTanggungan") = "0"
                            End Try

                        Else
                            Return Nothing
                        End If
                    End Using
                End Using

                ' Load Family Members (Anak/Parents/Etc)
                ' Now links directly to WajibPajakID in tbl_Profil_Keluarga_Anak
                Dim listAnak As New List(Of Dictionary(Of String, String))
                Dim queryFamily As String = "SELECT * FROM tbl_Profil_Keluarga_Anak WHERE WajibPajakID = @WPID"
                Using cmd As New SqlCommand(queryFamily, conn)
                    cmd.Parameters.AddWithValue("@WPID", wpID)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim anak As New Dictionary(Of String, String)
                            anak("NamaAnak") = reader("NamaAnak").ToString()
                            anak("TanggalLahir") = Convert.ToDateTime(reader("TanggalLahir")).ToString("dd/MM/yyyy")
                            anak("StatusTanggungan") = reader("StatusTanggungan").ToString()
                            ' Optional: Pekerjaan
                            Try
                                anak("Pekerjaan") = reader("Pekerjaan").ToString()
                            Catch
                                anak("Pekerjaan") = "-"
                            End Try
                            listAnak.Add(anak)
                        End While
                    End Using
                End Using
                data("DataAnak") = listAnak

            End If
        Catch ex As Exception
            MessageBox.Show("Error loading profil: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try

        Return data
    End Function

    ' ========== FUNGSI SAVE PROFIL DATA (CONSOLIDATED) ==========
    Public Function SimpanProfilData(nik As String, dataProfil As Dictionary(Of String, Object)) As Boolean
        Dim conn As SqlConnection = GetConnection()
        Dim transaction As SqlTransaction = Nothing

        Try
            If OpenConnection(conn) Then
                transaction = conn.BeginTransaction()

                ' 1. Get WP ID
                Dim wpID As Integer = 0
                Dim queryGetID As String = "SELECT ID FROM tbl_WajibPajak WHERE NIK = @NIK"
                Using cmd As New SqlCommand(queryGetID, conn, transaction)
                    cmd.Parameters.AddWithValue("@NIK", nik)
                    Dim res = cmd.ExecuteScalar()
                    If res IsNot Nothing Then wpID = Convert.ToInt32(res)
                End Using

                If wpID = 0 Then Throw New Exception("User tidak ditemukan")

                ' 2. Update tbl_WajibPajak (Merged Data)
                Dim queryUpdate As String = "
                    UPDATE tbl_WajibPajak SET 
                        NamaLengkap = @Nama, 
                        TempatKerja = @TempatKerja,
                        StatusPTKP = @StatusPTKP,
                        TanggalLahir = @TglLahir,
                        StatusPekerjaan = @StatusPekerjaan,
                        Jabatan = @Jabatan,
                        JenisWajibPajak = @JenisWajibPajak,
                        NomorRegistrasi = @NoReg,
                        Alamat = @Alamat,
                        Provinsi = @Provinsi,
                        Kota = @Kota,
                        KodePos = @Pos,
                        Email = @Email,
                        NoHandphone = @Telepon,
                        TempatLahir = @TempatLahir,
                        JenisKelamin = @JenisKelamin,
                        StatusPernikahan = @StatusNikah,
                        NamaPasangan = @NamaPasangan,
                        JumlahTanggungan = @JumlahTanggungan
                    WHERE ID = @ID"

                Using cmd As New SqlCommand(queryUpdate, conn, transaction)
                    cmd.Parameters.AddWithValue("@ID", wpID)
                    cmd.Parameters.AddWithValue("@Nama", dataProfil("NamaWajibPajak"))
                    ' NPWP param removed
                    
                    ' ... (Same standard parameters)
                    cmd.Parameters.AddWithValue("@TempatKerja", If(dataProfil.ContainsKey("TempatKerja") AndAlso dataProfil("TempatKerja") IsNot Nothing, dataProfil("TempatKerja"), DBNull.Value))
                    Dim statusPTKPDirty As String = If(dataProfil.ContainsKey("StatusPTKP"), dataProfil("StatusPTKP").ToString(), "")
                    ' Truncation removed, column resized to 100
                    cmd.Parameters.AddWithValue("@StatusPTKP", If(String.IsNullOrEmpty(statusPTKPDirty), DBNull.Value, statusPTKPDirty))
                    cmd.Parameters.AddWithValue("@TglLahir", If(dataProfil.ContainsKey("TanggalLahir"), dataProfil("TanggalLahir"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@StatusPekerjaan", If(dataProfil.ContainsKey("StatusPekerjaan"), dataProfil("StatusPekerjaan"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@Jabatan", If(dataProfil.ContainsKey("Jabatan"), dataProfil("Jabatan"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@JenisWajibPajak", If(dataProfil.ContainsKey("JenisWajibPajak"), dataProfil("JenisWajibPajak"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@NoReg", If(dataProfil.ContainsKey("NomorRegistrasi"), dataProfil("NomorRegistrasi"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@Alamat", If(dataProfil.ContainsKey("AlamatLengkap"), dataProfil("AlamatLengkap"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@Provinsi", If(dataProfil.ContainsKey("Provinsi"), dataProfil("Provinsi"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@Kota", If(dataProfil.ContainsKey("Kota"), dataProfil("Kota"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@Pos", If(dataProfil.ContainsKey("KodePos"), dataProfil("KodePos"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@Email", If(dataProfil.ContainsKey("Email"), dataProfil("Email"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@Telepon", If(dataProfil.ContainsKey("Telepon"), dataProfil("Telepon"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@TempatLahir", If(dataProfil.ContainsKey("TempatLahir"), dataProfil("TempatLahir"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@JenisKelamin", If(dataProfil.ContainsKey("JenisKelamin"), dataProfil("JenisKelamin"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@StatusNikah", If(dataProfil.ContainsKey("StatusPernikahan"), dataProfil("StatusPernikahan"), DBNull.Value))
                    
                    ' New Merged Params
                    cmd.Parameters.AddWithValue("@NamaPasangan", If(dataProfil.ContainsKey("NamaPasangan"), dataProfil("NamaPasangan"), DBNull.Value))
                    cmd.Parameters.AddWithValue("@JumlahTanggungan", If(dataProfil.ContainsKey("JumlahTanggungan"), Convert.ToInt32(dataProfil("JumlahTanggungan")), 0))
                    
                    cmd.ExecuteNonQuery()
                End Using

                ' 3. Keluarga & Anak (Direct tbl_Profil_Keluarga_Anak)
                ' Delete all children for this WP to replace (Simplest sync strategy)
                Using cmd As New SqlCommand("DELETE FROM tbl_Profil_Keluarga_Anak WHERE WajibPajakID = @ID", conn, transaction)
                    cmd.Parameters.AddWithValue("@ID", wpID)
                    cmd.ExecuteNonQuery()
                End Using

                Dim listAnak As List(Of Dictionary(Of String, String)) = DirectCast(dataProfil("DataAnak"), List(Of Dictionary(Of String, String)))
                For Each anak As Dictionary(Of String, String) In listAnak
                    Dim queryAnak As String = "INSERT INTO tbl_Profil_Keluarga_Anak (WajibPajakID, NamaAnak, TanggalLahir, StatusTanggungan, Pekerjaan) VALUES (@ID, @Nama, @Tgl, @Status, @Pekerjaan)"
                    Using cmd As New SqlCommand(queryAnak, conn, transaction)
                        cmd.Parameters.AddWithValue("@ID", wpID)
                        cmd.Parameters.AddWithValue("@Nama", anak("NamaAnak"))
                        
                        Dim tglLahir As DateTime
                        Dim tglStr As String = anak("TanggalLahirAnak")
                        
                        Dim isValidDate As Boolean = False
                        If String.IsNullOrEmpty(tglStr) Then
                             isValidDate = False
                        ElseIf DateTime.TryParse(tglStr, tglLahir) Then
                             isValidDate = True
                        ElseIf DateTime.TryParseExact(tglStr, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, tglLahir) Then
                             isValidDate = True
                        Else
                             isValidDate = False
                        End If
                        
                        ' VALIDATION: Ensure date is within SQL Safe Range (1753 - 9999)
                        If isValidDate AndAlso (tglLahir.Year < 1753 OrElse tglLahir.Year > 9999) Then
                            isValidDate = False ' Treat as invalid if out of range
                        End If
                        
                        If isValidDate Then
                            cmd.Parameters.AddWithValue("@Tgl", tglLahir)
                        Else
                            cmd.Parameters.AddWithValue("@Tgl", DateTime.Now)
                        End If
                        
                        cmd.Parameters.AddWithValue("@Status", anak("StatusTanggungan"))
                        ' Optional Pekerjaan if available
                        If anak.ContainsKey("Pekerjaan") Then
                             cmd.Parameters.AddWithValue("@Pekerjaan", anak("Pekerjaan"))
                        Else
                             cmd.Parameters.AddWithValue("@Pekerjaan", "-")
                        End If
                        
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                transaction.Commit()
                Return True
            End If
        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            MessageBox.Show("Error saving data: " & ex.Message)
            Return False
        Finally
            CloseConnection(conn)
        End Try
        Return False
    End Function


    ' ========== DATABASE CLEANUP ==========
    Public Sub CleanupLegacyTables()
        Dim conn As SqlConnection = GetConnection()
        Try
            If OpenConnection(conn) Then
                Dim sql As String = "
                    IF OBJECT_ID('dbo.tbl_Profil_Alamat', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Alamat;
                    IF OBJECT_ID('dbo.tbl_Profil_Ikhtisar', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Ikhtisar;
                    IF OBJECT_ID('dbo.tbl_Profil_InfoUmum', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_InfoUmum;
                    IF OBJECT_ID('dbo.tbl_Profil_Kontak', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Kontak;
                    -- Drop Header Profil if exists (Dependencies should be gone or cascade)
                    IF OBJECT_ID('dbo.tbl_Profil_Keluarga', 'U') IS NOT NULL 
                    BEGIN
                       -- Drop FK from Anak if exists
                       IF EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_tbl_Profil_Keluarga_Anak_tbl_Profil_Keluarga')
                          ALTER TABLE tbl_Profil_Keluarga_Anak DROP CONSTRAINT FK_tbl_Profil_Keluarga_Anak_tbl_Profil_Keluarga;
                       DROP TABLE dbo.tbl_Profil_Keluarga;
                    END
                "
                Using cmd As New SqlCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            ' Ignore errors during cleanup to not block app
            Debug.WriteLine("Cleanup error: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try
    End Sub
End Module
