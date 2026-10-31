-- Bersihkan data lama
ALTER TABLE tbl_Users ALTER COLUMN Username NVARCHAR(100);

-- 1. ADMIN (Login pakai NIP atau Username biasa)
INSERT INTO [dbo].[tbl_Users] (Username, Password, Role, NamaLengkap, IsActive)
VALUES ('admin', 'admin123', 'ADMIN', 'Petugas Pajak (Fiskus)', 1);

-- 2. WAJIB PAJAK (Login pakai NPWP Pribadi - Contoh: 11.222.333.4-555.000)
-- Kita simpan angkanya saja agar mudah diketik saat login
INSERT INTO [dbo].[tbl_Users] (Username, Password, Role, NamaLengkap, IsActive)
VALUES ('112223334555000', 'user123', 'WAJIBPAJAK', 'Budi Santoso', 1);

-- 3. PEMBERI KERJA (Login pakai NPWP Perusahaan - Contoh: 99.888.777.6-555.000)
INSERT INTO [dbo].[tbl_Users] (Username, Password, Role, NamaLengkap, IsActive)
VALUES ('pt_maju@example.com', 'PT123', 'PEMBERIKERJA', 'PT. Maju Mundur', 1);

-- 4. CONTOH USER NON-AKTIF (Misal sudah resign/tutup usaha)
INSERT INTO [dbo].[tbl_Users] (Username, Password, Role, NamaLengkap, IsActive)
VALUES ('000000000000000', 'pass123', 'WAJIBPAJAK', 'User Sudah Tidak Aktif', 0);