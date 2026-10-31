CREATE TABLE [dbo].[tbl_PemberiKerja] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [NamaPT] NVARCHAR(200) NOT NULL,
    [EmailPT] NVARCHAR(100) NOT NULL,
    [NIKKuasa] NVARCHAR(16),
    [NamaKuasa] NVARCHAR(200),
    [NoTelpKuasa] NVARCHAR(20),
    [AlamatLengkap] NVARCHAR(500),
    [Provinsi] NVARCHAR(100),
    [Kota] NVARCHAR(100),
    [Kecamatan] NVARCHAR(100),
    [Kelurahan] NVARCHAR(100),
    [KodePos] NVARCHAR(10),
    [JumlahKaryawan] INT DEFAULT 0,
    [TanggalRegistrasi] DATETIME DEFAULT GETDATE(),
    [IsActive] BIT DEFAULT 1
);

-- Tabel untuk menyimpan daftar karyawan
CREATE TABLE [dbo].[tbl_KaryawanPemberiKerja] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [PemberiKerjaID] INT NOT NULL,
    [NIK_NPWP] NVARCHAR(20) NOT NULL,
    [NamaKaryawan] NVARCHAR(200),
    [TanggalDitambahkan] DATETIME DEFAULT GETDATE(),
    FOREIGN KEY ([PemberiKerjaID]) REFERENCES [dbo].[tbl_PemberiKerja]([ID]) ON DELETE CASCADE
);
