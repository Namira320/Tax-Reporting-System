# Rencana Desain Ulang Aplikasi Pajak TaxEase

## Status: Dalam Proses

### Tujuan
Merapihkan seluruh desain aplikasi pajak dengan skema warna yang konsisten (Biru #0747A6 dan Kuning #FFC107), typography yang modern, dan layout yang lebih profesional.

---

## ✅ Selesai

### 1. ModuleDesign.vb
- [x] Membuat modul desain terpusat dengan konstanta warna, font, spacing
- [x] Menyediakan metode styling untuk semua komponen (Button, TextBox, DataGridView, dll)
- [x] Dokumentasi lengkap untuk setiap metode

### 2. Login.Designer.vb
- [x] Layout modern dengan card-based design
- [x] Spacing yang lebih baik dan konsisten
- [x] Warna yang sesuai dengan skema (Biru dan Krem)
- [x] Typography yang lebih rapi

### 3. Dashboard.Designer.vb (Wajib Pajak)
- [x] Card-based design untuk statistik pajak
- [x] DataGridView dengan styling modern
- [x] MenuStrip dengan warna biru konsisten
- [x] Responsive layout dengan anchor
- [x] Spacing yang konsisten

---

## 🔄 Perlu Dikerjakan

### Form Wajib Pajak
1. **Profil.Designer.vb**
   - Layout form profil yang lebih rapi
   - Grouping field yang lebih baik
   - Button styling konsisten

2. **Pengisian SPT.Designer.vb**
   - Form wizard style dengan step indicator
   - Field grouping yang jelas
   - Validation visual yang lebih baik

3. **Simulasi.Designer.vb**
   - Layout hasil simulasi yang lebih menarik
   - Chart/visualization yang lebih baik
   - Summary card yang informatif

4. **RiwayatPelaporan.Designer.vb**
   - DataGridView dengan styling modern
   - Filter dan search yang lebih baik
   - Detail view yang informatif

5. **Notifikasi.Designer.vb**
   - List view notifikasi yang modern
   - Badge untuk unread notifications
   - Action buttons yang jelas

### Form Registrasi
6. **Kategori_Register.Designer.vb**
   - Card-based selection untuk kategori
   - Icon yang menarik untuk setiap kategori
   - Hover effect yang smooth

7. **Register.Designer.vb** (Wajib Pajak)
   - Multi-step form dengan progress indicator
   - Field validation visual
   - Helper text yang jelas

8. **Register_PK.Designer.vb** (Pemberi Kerja)
   - Layout yang konsisten dengan Register.vb
   - Field grouping yang baik
   - Validation yang jelas

9. **ResetPassword.Designer.vb**
   - Simple dan clean layout
   - Clear instructions
   - Success/error feedback

### Form Admin
10. **Dashboard_AD.Designer.vb**
    - Admin dashboard dengan statistik
    - Chart untuk data visualization
    - Quick action cards

11. **ManajemenPengguna.Designer.vb**
    - DataGridView dengan action buttons
    - Search dan filter yang powerful
    - User detail panel

12. **Pengaturan_AD.Designer.vb**
    - Tabbed interface untuk berbagai pengaturan
    - Toggle switches untuk settings
    - Save/Cancel buttons yang jelas

### Form Pemberi Kerja
13. **Dashboard_PK.Designer.vb**
    - Dashboard untuk pemberi kerja
    - Statistik karyawan dan pajak
    - Quick actions

14. **ImportGaji.Designer.vb**
    - Drag & drop area untuk CSV
    - Preview data sebelum import
    - Progress indicator

15. **CetakBuktiPotong.Designer.vb**
    - Preview bukti potong
    - Filter karyawan
    - Export options

---

## Prinsip Desain yang Digunakan

### Warna
- **Primary Blue**: `#0747A6` (7, 71, 166)
- **Secondary Yellow**: `#FFC107` (255, 193, 7)
- **Background**: `#F8F9FA` (248, 249, 250)
- **White**: `#FFFFFF`
- **Text Primary**: `#1C2128` (28, 33, 40)
- **Text Secondary**: `#4A4F56` (74, 79, 86)

### Typography
- **Font Family**: Segoe UI (primary)
- **Heading 1**: 28pt Bold
- **Heading 2**: 24pt Bold
- **Heading 3**: 18pt Bold
- **Body**: 11pt Regular
- **Small**: 9.5pt Regular

### Spacing
- **XS**: 4px
- **S**: 8px
- **M**: 16px
- **L**: 24px
- **XL**: 32px
- **XXL**: 48px

### Components
- **Buttons**: Flat style, no border, bold text, hover effect
- **TextBox**: Fixed single border, focus effect
- **DataGridView**: No row headers, alternating colors, single horizontal border
- **Cards**: White background, padding 24px
- **Forms**: Background #F8F9FA, padding 40px

---

## Catatan Implementasi

1. Semua form harus menggunakan konstanta dari `ModuleDesign.vb`
2. Gunakan metode styling yang sudah disediakan untuk konsistensi
3. Pastikan responsive dengan menggunakan Anchor dan Dock
4. Minimum size untuk semua form: 1200x800
5. Start position: CenterScreen
6. Window state: Maximized (untuk dashboard)

---

## Timeline Estimasi

- Form Wajib Pajak (5 form): 2-3 jam
- Form Registrasi (4 form): 1-2 jam
- Form Admin (3 form): 1-2 jam
- Form Pemberi Kerja (3 form): 1-2 jam
- Testing dan refinement: 1 jam

**Total**: 6-10 jam

---

## Prioritas

### High Priority (Harus segera)
1. Profil.Designer.vb
2. Pengisian SPT.Designer.vb
3. Simulasi.Designer.vb
4. Register.Designer.vb

### Medium Priority
5. Dashboard_AD.Designer.vb
6. Dashboard_PK.Designer.vb
7. ManajemenPengguna.Designer.vb
8. ImportGaji.Designer.vb

### Low Priority
9. Notifikasi.Designer.vb
10. ResetPassword.Designer.vb
11. Kategori_Register.Designer.vb
12. CetakBuktiPotong.Designer.vb
