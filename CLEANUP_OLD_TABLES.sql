USE [c:\Users\danen\Tugas_Kuliah\Tugas_PNJ\Pemograman Visual\PBL\PBLPajak\PBLPajak (3)\PBLPajak\Database1.mdf]; -- Assuming this is the DB name from context, or we can look it up dynamically if needed.
-- But usually for these scripts we just run plain SQL.

-- 1. DROP old obsolete tables
IF OBJECT_ID('dbo.tbl_Profil_Alamat', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Alamat;
IF OBJECT_ID('dbo.tbl_Profil_Ikhtisar', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Ikhtisar;
IF OBJECT_ID('dbo.tbl_Profil_InfoUmum', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_InfoUmum;
IF OBJECT_ID('dbo.tbl_Profil_Kontak', 'U') IS NOT NULL DROP TABLE dbo.tbl_Profil_Kontak;

-- 2. DROP tbl_Profil_Keluarga (Header) as we now use tbl_Profil_Keluarga_Anak linked directly to WajibPajak
-- Check if any Foreign Key depends on it first, though our new logic uses WajibPajakID in Anak table.
-- We previously updated Anak table to link to WajibPajakID.
-- Let's enable aggressive cleanup.
IF OBJECT_ID('dbo.tbl_Profil_Keluarga_Anak', 'U') IS NOT NULL
BEGIN
    -- Check if it still has FK to tbl_Profil_Keluarga
    IF EXISTS (SELECT * FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID('dbo.tbl_Profil_Keluarga_Anak') AND referenced_object_id = OBJECT_ID('dbo.tbl_Profil_Keluarga'))
    BEGIN
        ALTER TABLE dbo.tbl_Profil_Keluarga_Anak DROP CONSTRAINT FK_tbl_Profil_Keluarga_Anak_tbl_Profil_Keluarga; 
        -- (Name is guess, finding by schema is safer in code, but here we just drop table if no constraints block)
    END
END

IF OBJECT_ID('dbo.tbl_Profil_Keluarga', 'U') IS NOT NULL 
BEGIN
    -- Drop constraint on Anak if it exists unnamed/named differently
    DECLARE @sql NVARCHAR(MAX) = N'';
    SELECT @sql += 'ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id))
        + '.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + 
        ' DROP CONSTRAINT ' + QUOTENAME(name) + ';'
    FROM sys.foreign_keys
    WHERE referenced_object_id = OBJECT_ID('dbo.tbl_Profil_Keluarga');
    
    EXEC sp_executesql @sql;
    
    DROP TABLE dbo.tbl_Profil_Keluarga;
END

-- 3. Verify tbl_WajibPajak has all needed columns (Redundant check but good for safety)
-- This was done in CheckAndCreateProfileTables, so we assume it's good.
