-- Script untuk membuat tabel Profil jika belum ada
USE [Database1] -- Pastikan ini sesuai dengan nama database Anda jika diattach manual, atau jalankan Query ini di tabel yang aktif

-- 1. Tabel Informasi Umum
IF OBJECT_ID('dbo.tbl_Profil_InfoUmum', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tbl_Profil_InfoUmum (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        WajibPajakID INT,
        TempatLahir NVARCHAR(100),
        TanggalLahir DATE,
        StatusPernikahan NVARCHAR(50),
        NegaraAsal NVARCHAR(50),
        JenisKelamin NVARCHAR(20),
        StatusPekerjaan NVARCHAR(50),
        JenisWajibPajak NVARCHAR(50),
        NomorRegistrasi NVARCHAR(50),
        FOREIGN KEY (WajibPajakID) REFERENCES tbl_WajibPajak(ID) ON DELETE CASCADE
    )
    PRINT 'Tabel tbl_Profil_InfoUmum berhasil dibuat.'
END

-- 2. Tabel Alamat
IF OBJECT_ID('dbo.tbl_Profil_Alamat', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tbl_Profil_Alamat (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        WajibPajakID INT,
        AlamatLengkap NVARCHAR(255),
        Provinsi NVARCHAR(100),
        Kota NVARCHAR(100),
        KodePos NVARCHAR(10),
        FOREIGN KEY (WajibPajakID) REFERENCES tbl_WajibPajak(ID) ON DELETE CASCADE
    )
    PRINT 'Tabel tbl_Profil_Alamat berhasil dibuat.'
END

-- 3. Tabel Detail Kontak
IF OBJECT_ID('dbo.tbl_Profil_Kontak', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tbl_Profil_Kontak (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        WajibPajakID INT,
        Email NVARCHAR(100),
        Telepon NVARCHAR(20),
        FOREIGN KEY (WajibPajakID) REFERENCES tbl_WajibPajak(ID) ON DELETE CASCADE
    )
    PRINT 'Tabel tbl_Profil_Kontak berhasil dibuat.'
END

-- 4. Tabel Unit Keluarga (Header)
IF OBJECT_ID('dbo.tbl_Profil_Keluarga', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tbl_Profil_Keluarga (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        WajibPajakID INT,
        NamaPasangan NVARCHAR(100),
        JumlahTanggungan INT,
        FOREIGN KEY (WajibPajakID) REFERENCES tbl_WajibPajak(ID) ON DELETE CASCADE
    )
    PRINT 'Tabel tbl_Profil_Keluarga berhasil dibuat.'
END

-- 5. Tabel Unit Keluarga (Anak/Detail)
IF OBJECT_ID('dbo.tbl_Profil_Keluarga_Anak', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tbl_Profil_Keluarga_Anak (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        KeluargaID INT,
        NamaAnak NVARCHAR(100),
        TanggalLahir DATE,
        StatusTanggungan NVARCHAR(20),
        FOREIGN KEY (KeluargaID) REFERENCES tbl_Profil_Keluarga(ID) ON DELETE CASCADE
    )
    PRINT 'Tabel tbl_Profil_Keluarga_Anak berhasil dibuat.'
END

-- 6. Tabel Ikhtisar
IF OBJECT_ID('dbo.tbl_Profil_Ikhtisar', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tbl_Profil_Ikhtisar (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        WajibPajakID INT,
        StatusPTKP NVARCHAR(10),
        TahunPajak INT,
        FOREIGN KEY (WajibPajakID) REFERENCES tbl_WajibPajak(ID) ON DELETE CASCADE
    )
    PRINT 'Tabel tbl_Profil_Ikhtisar berhasil dibuat.'
END

PRINT 'Proses pembuatan tabel profil selesai.'
