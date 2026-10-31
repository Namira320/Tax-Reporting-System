# 📄 Cara Convert HTML ke PDF

Saya telah membuat 2 file HTML yang berisi panduan lengkap:

## 📁 File yang Dibuat

### 1. **Panduan_eBilling.html**
   - Panduan lengkap e-Billing
   - Cara membuat kode billing
   - Cara melakukan pembayaran
   - FAQ

### 2. **Materi_Edukasi_Pajak.html**
   - Penjelasan status pajak (Nihil, Kurang Bayar, Lebih Bayar)
   - Kepatuhan pajak
   - Cara menggunakan aplikasi TaxEase
   - Tips & best practices

---

## 🔄 Cara 1: Print to PDF dari Browser (TERMUDAH)

### Langkah-langkah:

1. **Buka File HTML:**
   - Double-click file HTML
   - Akan terbuka di browser (Chrome/Edge/Firefox)

2. **Print to PDF:**
   - Tekan `Ctrl + P` (Windows) atau `Cmd + P` (Mac)
   - Atau klik ⋮ (menu) → Print

3. **Pilih "Save as PDF":**
   - Destination: **Save as PDF** atau **Microsoft Print to PDF**
   - Layout: **Portrait** (tegak)
   - Margins: **Default** atau **Small**
   - Options: ✅ Background graphics

4. **Save:**
   - Klik **Save**
   - Beri nama:
     * `Panduan_eBilling.pdf`
     * `Materi_Edukasi_Pajak.pdf`

---

## 🔄 Cara 2: Menggunakan Website Online

### Rekomendasi Website:
- https://www.html2pdf.com/
- https://pdfcrowd.com/
- https://cloudconvert.com/html-to-pdf

### Langkah-langkah:
1. Upload file HTML
2. Convert
3. Download PDF

---

## 🔄 Cara 3: Menggunakan Microsoft Word

### Langkah-langkah:

1. **Buka file HTML dengan Word:**
   - Right-click file HTML
   - Open With → Microsoft Word

2. **Save as PDF:**
   - File → Save As
   - Format: **PDF**
   - Save

---

## 📋 Hasil yang Diharapkan

### Panduan_eBilling.pdf harus berisi:
- ✅ Cover dengan title "Panduan e-Billing"
- ✅ Penjelasan apa itu e-Billing
- ✅ Langkah-langkah membuat kode billing
- ✅ Cara pembayaran (ATM, Internet Banking, dll)
- ✅ FAQ
- ✅ Kontak bantuan

### Materi_Edukasi_Pajak.pdf harus berisi:
- ✅ Cover dengan title "Materi Edukasi Pajak"  
- ✅ Penjelasan 3 status pajak (Nihil, Kurang Bayar, Lebih Bayar)
- ✅ Contoh perhitungan untuk setiap status
- ✅ Kepatuhan pajak
- ✅ Cara menggunakan aplikasi TaxEase step-by-step
- ✅ Tips & best practices
- ✅ Kontak bantuan

---

## ⚙️ Setting Optimal untuk Print to PDF

**Chrome/Edge:**
```
Destination: Save as PDF
Layout: Portrait
Pages: All
Color: Color
Margins: Small
Scale: Default (100%)
Options:
  ✅ Background graphics
  ✅ Headers and footers (optional)
```

---

## 📝 Checklist Setelah Convert

- [ ] File PDF terbuat
- [ ] Buka dan cek semua halaman terlihat bagus
- [ ] Text jelas terbaca
- [ ] Warna dan styling terlihat
- [ ] Table terformat dengan baik
- [ ] Simpan di folder `Resources/`
- [ ] Test load PDF di WebBrowser form

---

## 🎯 Lokasi File PDF

Setelah convert, simpan file PDF di:
```
project_pajak/
└── Resources/
    ├── Panduan_eBilling.pdf       ← PDF hasil convert
    └── Materi_Edukasi_Pajak.pdf   ← PDF hasil convert
```

---

## ✅ Verifikasi

Setelah PDF dibuat, pastikan:

1. **File size reasonable:**
   - Panduan e-Billing: ~500KB - 2MB
   - Edukasi: ~800KB - 3MB

2. **Kualitas bagus:**
   - Text sharp dan jelas
   - Color konsisten
   - Layout rapi

3. **Navigasi mudah:**
   - Semua section terlihat
   - Table of contents (jika ada) berfungsi

---

## 🚀 Quick Test

Setelah PDF ready:

1. **Test di aplikasi:**
   ```vb
   Dim formPanduan As New PanduanEBilling()
   formPanduan.Show()
   ```

2. **Check apakah PDF load dengan benar**

3. **Test button Refresh**

4. **Test button Kembali**

---

## 💡 Tips

- 📄 Gunakan Chrome untuk hasil terbaik
- 🎨 Pastikan "Background graphics" di-check
- 📏 Pilih margin "Small" untuk lebih banyak content
- 💾 Save PDF dengan nama yang exact sesuai code
- 🔍 Zoom PDF untuk cek quality

---

**Happy converting! 🎉**
