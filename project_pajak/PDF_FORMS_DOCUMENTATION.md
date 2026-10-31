# 📚 Dokumentasi Form PDF Viewer

## Form yang Dibuat

Saya telah membuat 2 form untuk menampilkan PDF:

### 1. **PanduanEBilling.vb** 📄
Form untuk menampilkan panduan pembayaran e-Billing

**Files:**
- `PanduanEBilling.vb` - Code-behind
- `PanduanEBilling.Designer.vb` - UI Design

**Features:**
- Header biru (RGB 15, 76, 129)
- PDF viewer menggunakan WebBrowser
- Button: Kembali, Refresh, Buka DJP Online
- Otomatis check file PDF existence
- Fallback ke website DJP jika PDF tidak ada

---

### 2. **Edukasi.vb** 📚
Form untuk menampilkan materi edukasi perpajakan

**Files:**
- `Edukasi.vb` - Code-behind
- `Edukasi.Designer.vb` - UI Design

**Features:**
- Header hijau (RGB 25, 135, 84)
- PDF viewer menggunakan WebBrowser
- Button: Kembali, Refresh, Buka Edukasi DJP
- Otomatis check file PDF existence
- Fallback ke website DJP jika PDF tidak ada

---

## 📁 Setup File PDF

### 1. Buat Folder Resources
```
project_pajak/
├── Resources/
│   ├── Panduan_eBilling.pdf
│   └── Materi_Edukasi_Pajak.pdf
```

### 2. Simpan PDF Files
- Letakkan file `Panduan_eBilling.pdf` di folder Resources
- Letakkan file `Materi_Edukasi_Pajak.pdf` di folder Resources

### 3. Set File Properties
Di Visual Studio:
1. Right-click pada file PDF
2. Properties
3. Set **Copy to Output Directory** = **Copy if newer**

---

## 🔗 Cara Memanggil Form

### Dari Form Lain (Contoh: Simulasi atau Pengisian SPT)

```vb
' Ketika status "Kurang Bayar", tampilkan link ke Panduan e-Billing
Private Sub ShowPanduanEBilling()
    Dim formPanduan As New PanduanEBilling()
    formPanduan.Show()
End Sub

' Atau jika ingin modal (blocking)
Private Sub ShowPanduanEBillingModal()
    Dim formPanduan As New PanduanEBilling()
    formPanduan.ShowDialog()
End Sub
```

### Contoh Implementasi di Form Simulasi

```vb
Private Sub ButtonLihatPanduan_Click(sender As Object, e As EventArgs) Handles ButtonLihatPanduan.Click
    ' Buka form Panduan e-Billing
    Dim formPanduan As New PanduanEBilling()
    formPanduan.Show()
End Sub
```

### Contoh Implementasi dengan Kondisi

```vb
Private Sub CekStatusPajak()
    If statusPajak = "Kurang Bayar" Then
        ' Tampilkan pesan dengan opsi buka panduan
        Dim result = MessageBox.Show(
            "Status: Kurang Bayar" & vbCrLf & vbCrLf & _
            "Anda perlu membayar pajak sebesar Rp " & FormatAngka(jumlahKurangBayar) & vbCrLf & vbCrLf & _
            "Apakah Anda ingin melihat panduan e-Billing?",
            "Kurang Bayar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information)
        
        If result = DialogResult.Yes Then
            Dim formPanduan As New PanduanEBilling()
            formPanduan.Show()
        End If
    End If
End Sub
```

---

## 🎨 Design Overview

### PanduanEBilling Form Layout:
```
┌─────────────────────────────────────────┐
│ 📄 Panduan e-Billing          [HEADER]  │ ← Blue (15,76,129)
│ Panduan lengkap pembayaran...            │
├─────────────────────────────────────────┤
│                                          │
│         [PDF CONTENT AREA]               │ ← WebBrowser
│                                          │
│                                          │
├─────────────────────────────────────────┤
│ [← Kembali] [🔄 Refresh] ... [🌐 DJP]  │ ← Bottom Panel
└─────────────────────────────────────────┘
```

### Edukasi Form Layout:
```
┌─────────────────────────────────────────┐
│ 📚 Materi Edukasi Pajak       [HEADER]  │ ← Green (25,135,84)
│ Pelajari lebih lanjut...                 │
├─────────────────────────────────────────┤
│                                          │
│         [PDF CONTENT AREA]               │ ← WebBrowser
│                                          │
│                                          │
├─────────────────────────────────────────┤
│ [← Kembali] [🔄 Refresh] ... [🌐 DJP]  │ ← Bottom Panel
└─────────────────────────────────────────┘
```

---

## 🔧 Customization

### Mengubah Path PDF:

**PanduanEBilling.vb:**
```vb
pdfPath = Path.Combine(Application.StartupPath, "Resources", "Panduan_eBilling.pdf")
' Ubah "Panduan_eBilling.pdf" sesuai nama file Anda
```

**Edukasi.vb:**
```vb
pdfPath = Path.Combine(Application.StartupPath, "Resources", "Materi_Edukasi_Pajak.pdf")
' Ubah "Materi_Edukasi_Pajak.pdf" sesuai nama file Anda
```

### Mengubah Warna Header:

**PanduanEBilling.Designer.vb:**
```vb
PanelTop.BackColor = Color.FromArgb(15, 76, 129)  ' Biru
```

**Edukasi.Designer.vb:**
```vb
PanelTop.BackColor = Color.FromArgb(25, 135, 84)  ' Hijau
```

---

## ⚠️ Troubleshooting

### PDF Tidak Muncul?

1. **Check file exists:**
   - Pastikan file PDF ada di folder Resources
   - Check spelling nama file

2. **Copy to Output Directory:**
   - Properties PDF file → Copy to Output Directory = Copy if newer

3. **Adobe Reader:**
   - WebBrowser memerlukan Adobe Reader terinstall
   - Atau PDF viewer default di sistem

### Alternative PDF Viewer:

Jika WebBrowser tidak bekerja, bisa gunakan:
1. AxAcroPDF (Adobe ActiveX)
2. PdfiumViewer (NuGet package)
3. External PDF viewer (Process.Start)

---

## 📋 Checklist Implementasi

- [ ] Copy file PanduanEBilling.vb ke project
- [ ] Copy file PanduanEBilling.Designer.vb ke project
- [ ] Copy file Edukasi.vb ke project
- [ ] Copy file Edukasi.Designer.vb ke project
- [ ] Buat folder Resources di project
- [ ] Simpan file Panduan_eBilling.pdf di Resources
- [ ] Simpan file Materi_Edukasi_Pajak.pdf di Resources
- [ ] Set PDF files → Copy to Output Directory
- [ ] Add form calls di Simulasi/Pengisian SPT
- [ ] Test PDF loading
- [ ] Test button Kembali
- [ ] Test button Refresh
- [ ] Test fallback URL jika PDF tidak ada

---

## 🚀 Ready to Use!

Kedua form sudah siap digunakan. Tinggal:
1. Tambahkan PDF files ke folder Resources
2. Panggil form dari tempat yang sesuai (Simulasi/SPT)
3. Enjoy! 🎉
