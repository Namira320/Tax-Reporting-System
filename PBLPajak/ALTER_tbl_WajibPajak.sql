-- ========================================
-- ALTER TABLE tbl_WajibPajak
-- Menambahkan field baru untuk Form Profil
-- ========================================

USE [nama_database_anda];  -- Ganti dengan nama database yang sebenarnya
GO

-- Tambahkan 4 field baru
ALTER TABLE [dbo].[tbl_WajibPajak]
ADD 
    [StatusPTKP] NVARCHAR(10) NULL,
    [JenisWajibPajak] NVARCHAR(50) NULL,
    [StatusPekerjaan] NVARCHAR(50) NULL,
    [NamaTempatKerja] NVARCHAR(100) NULL;
GO

-- Verifikasi perubahan
SELECT 
    COLUMN_NAME,
    DATA_TYPE,
    CHARACTER_MAXIMUM_LENGTH,
    IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'tbl_WajibPajak'
    AND COLUMN_NAME IN ('StatusPTKP', 'JenisWajibPajak', 'StatusPekerjaan', 'NamaTempatKerja');
GO

PRINT 'Field baru berhasil ditambahkan ke tbl_WajibPajak!';
