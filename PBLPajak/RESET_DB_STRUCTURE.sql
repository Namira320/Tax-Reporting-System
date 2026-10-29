-- 1. DROP Obsolete Tables (The "tbl_Profil_*" mess)
IF OBJECT_ID('dbo.tbl_Profil_Alamat', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Alamat;
IF OBJECT_ID('dbo.tbl_Profil_Ikhtisar', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Ikhtisar;
IF OBJECT_ID('dbo.tbl_Profil_InfoUmum', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_InfoUmum;
IF OBJECT_ID('dbo.tbl_Profil_Kontak', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Kontak;
IF OBJECT_ID('dbo.tbl_Profil_Keluarga', 'U') IS NOT NULL 
BEGIN
    -- Drop FKs referencing this table first
    DECLARE @sql NVARCHAR(MAX) = N'';
    SELECT @sql += 'ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id))
        + '.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + 
        ' DROP CONSTRAINT ' + QUOTENAME(name) + ';'
    FROM sys.foreign_keys
    WHERE referenced_object_id = OBJECT_ID('dbo.tbl_Profil_Keluarga');
    EXEC sp_executesql @sql;
    DROP TABLE dbo.tbl_Profil_Keluarga;
END

-- 2. Clean and Recreate Family Table (tbl_Profil_Keluarga_Anak)
-- We drop it to ensure it perfectly matches the new structure
IF OBJECT_ID('dbo.tbl_Profil_Keluarga_Anak', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Keluarga_Anak;

CREATE TABLE [dbo].[tbl_Profil_Keluarga_Anak] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [WajibPajakID] INT NOT NULL,
    [NamaAnak] NVARCHAR(100), -- Used for any family member name in code
    [TanggalLahir] DATE,
    [StatusTanggungan] NVARCHAR(50), -- Istri, Suami, Anak, dll
    [Pekerjaan] NVARCHAR(100),
    CONSTRAINT [FK_Keluarga_WajibPajak] FOREIGN KEY ([WajibPajakID]) REFERENCES [dbo].[tbl_WajibPajak] ([ID]) ON DELETE CASCADE
);

-- 3. Ensure tbl_WajibPajak has all fields from Profil Form
-- Base fields (NIK, Email, Nama, etc) are already there. We add the extended profile fields.
IF COL_LENGTH('dbo.tbl_WajibPajak', 'Provinsi') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD Provinsi NVARCHAR(100);
IF COL_LENGTH('dbo.tbl_WajibPajak', 'Kota') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD Kota NVARCHAR(100);
IF COL_LENGTH('dbo.tbl_WajibPajak', 'KodePos') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD KodePos NVARCHAR(10);
IF COL_LENGTH('dbo.tbl_WajibPajak', 'NomorRegistrasi') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD NomorRegistrasi NVARCHAR(50);
IF COL_LENGTH('dbo.tbl_WajibPajak', 'StatusPTKP') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD StatusPTKP NVARCHAR(20);
IF COL_LENGTH('dbo.tbl_WajibPajak', 'StatusPekerjaan') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD StatusPekerjaan NVARCHAR(50);
IF COL_LENGTH('dbo.tbl_WajibPajak', 'Jabatan') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD Jabatan NVARCHAR(100);
IF COL_LENGTH('dbo.tbl_WajibPajak', 'NamaPasangan') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD NamaPasangan NVARCHAR(100);
IF COL_LENGTH('dbo.tbl_WajibPajak', 'JumlahTanggungan') IS NULL ALTER TABLE dbo.tbl_WajibPajak ADD JumlahTanggungan INT DEFAULT 0;
IF COL_LENGTH('dbo.tbl_WajibPajak', 'NPWP') IS NOT NULL ALTER TABLE dbo.tbl_WajibPajak DROP COLUMN NPWP; -- Ensure NPWP is gone as requested before
