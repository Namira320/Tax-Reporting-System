-- ========================================
-- CREATE TABLE tbl_UnitKeluarga
-- Tabel untuk menyimpan data unit keluarga
-- ========================================

CREATE TABLE [dbo].[tbl_UnitKeluarga] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [WajibPajakID] INT NOT NULL,
    [NamaAnggota] NVARCHAR(100) NOT NULL,
    [NIKAnggota] NVARCHAR(20),
    [StatusHubungan] NVARCHAR(50),
    [Pekerjaan] NVARCHAR(100),
    [TanggalLahir] DATE,
    [CreatedDate] DATETIME DEFAULT GETDATE(),
    [UpdatedDate] DATETIME,
    CONSTRAINT [FK_UnitKeluarga_WajibPajak] 
        FOREIGN KEY ([WajibPajakID]) 
        REFERENCES [dbo].[tbl_WajibPajak]([ID])
        ON DELETE CASCADE
);
GO

-- Buat index untuk performa query
CREATE INDEX IX_UnitKeluarga_WajibPajakID 
ON [dbo].[tbl_UnitKeluarga]([WajibPajakID]);
GO

PRINT 'Tabel tbl_UnitKeluarga berhasil dibuat!';
