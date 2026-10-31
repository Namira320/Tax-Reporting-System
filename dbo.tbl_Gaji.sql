CREATE TABLE [dbo].[tbl_Gaji] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [PemberiKerjaNPWP] NVARCHAR(50) NOT NULL,
    [NPWPPegawai] NVARCHAR(50) NOT NULL,
    [NamaPegawai] NVARCHAR(100) NOT NULL,
    [MasaPajak] INT NOT NULL,
    [TahunPajak] INT NOT NULL,
    [GajiBruto] DECIMAL(18, 2) NOT NULL,
    [PPhDipotong] DECIMAL(18, 2) NOT NULL,
    [TanggalInput] DATETIME DEFAULT GETDATE()
);
