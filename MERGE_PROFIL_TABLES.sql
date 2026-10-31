-- 1. Add all profile columns to tbl_WajibPajak (Table 1 of 2)
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'tbl_WajibPajak' AND COLUMN_NAME = 'Provinsi')
BEGIN
    ALTER TABLE tbl_WajibPajak ADD Provinsi NVARCHAR(100);
    ALTER TABLE tbl_WajibPajak ADD Kota NVARCHAR(100);
    ALTER TABLE tbl_WajibPajak ADD KodePos NVARCHAR(10);
    ALTER TABLE tbl_WajibPajak ADD NomorRegistrasi NVARCHAR(50);
    ALTER TABLE tbl_WajibPajak ADD StatusPTKP NVARCHAR(50);
    ALTER TABLE tbl_WajibPajak ADD JenisWajibPajak NVARCHAR(50);
    ALTER TABLE tbl_WajibPajak ADD StatusPekerjaan NVARCHAR(50);
    ALTER TABLE tbl_WajibPajak ADD NamaTempatKerja NVARCHAR(100);
    ALTER TABLE tbl_WajibPajak ADD Jabatan NVARCHAR(100); -- Fixes the "Jabatan" error
    ALTER TABLE tbl_WajibPajak ADD NamaPasangan NVARCHAR(100); -- Merged from tbl_Profil_Keluarga
    ALTER TABLE tbl_WajibPajak ADD JumlahTanggungan INT DEFAULT 0; -- Merged from tbl_Profil_Keluarga
END

-- 2. Create/Update tbl_Profil_Keluarga_Anak (Table 2 of 2 - Used for Family Grid)
-- This table will store all additional family members (Children, etc.)
IF OBJECT_ID('dbo.tbl_Profil_Keluarga_Anak', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.tbl_Profil_Keluarga_Anak (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        WajibPajakID INT, -- Direct link to WajibPajak, removing intermediate table
        NamaAnak NVARCHAR(100), -- Can serve as "NamaAnggota"
        TanggalLahir DATE,
        StatusTanggungan NVARCHAR(50), -- Hubungan
        Pekerjaan NVARCHAR(100),
        FOREIGN KEY (WajibPajakID) REFERENCES tbl_WajibPajak(ID) ON DELETE CASCADE
    )
END
ELSE
BEGIN
    -- If it exists, ensure it links directly to WajibPajak if we want to remove the intermediate table
    -- For now, we will assume code handles the logic, but let's add columns if missing
    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'tbl_Profil_Keluarga_Anak' AND COLUMN_NAME = 'WajibPajakID')
    BEGIN
        ALTER TABLE tbl_Profil_Keluarga_Anak ADD WajibPajakID INT;
        ALTER TABLE tbl_Profil_Keluarga_Anak ADD Pekerjaan NVARCHAR(100);
    END
END

-- Note: tbl_Profil_Keluarga (the header table) is now redundant as its fields are in tbl_WajibPajak.
-- We will ignore it in the simplified 2-table logic.
