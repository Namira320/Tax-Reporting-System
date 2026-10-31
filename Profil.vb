Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Drawing

Public Class Profil

    Private navMap As Dictionary(Of Button, GroupBox)
    Private navButtons As List(Of Button)

    Private Sub Profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi form
        InitializeDataGridView()
        UpdateJumlahTanggungan()
        InitializeNavigation()
    End Sub

    Private Sub InitializeDataGridView()
        ' Setup DataGridView untuk anak
        DataGridViewAnak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewAnak.AllowUserToResizeRows = False
        DataGridViewAnak.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewAnak.MultiSelect = False
    End Sub

    ' Event Handler untuk Button Simpan
    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        If ValidasiForm() Then
            If SimpanData() Then
                MessageBox.Show("Data profil wajib pajak berhasil disimpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Gagal menyimpan data. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    ' Event Handler untuk Button Batal
    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin membatalkan? Perubahan yang belum disimpan akan hilang.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' Event Handler untuk Button Tambah Anak
    Private Sub ButtonTambahAnak_Click(sender As Object, e As EventArgs) Handles ButtonTambahAnak.Click
        ' Tambah baris baru ke DataGridView
        Dim rowIndex As Integer = DataGridViewAnak.Rows.Add()
        DataGridViewAnak.Rows(rowIndex).Cells(0).Value = "" ' Nama Anak
        DataGridViewAnak.Rows(rowIndex).Cells(1).Value = DateTime.Now.ToString("dd/MM/yyyy") ' Tanggal Lahir
        DataGridViewAnak.Rows(rowIndex).Cells(2).Value = "Ya" ' Status Tanggungan
        
        ' Update jumlah tanggungan
        UpdateJumlahTanggungan()
        UpdateStatusPTKP()
    End Sub

    ' Event Handler untuk Button Hapus Anak
    Private Sub ButtonHapusAnak_Click(sender As Object, e As EventArgs) Handles ButtonHapusAnak.Click
        If DataGridViewAnak.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data anak ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridViewAnak.Rows.RemoveAt(DataGridViewAnak.SelectedRows(0).Index)
                UpdateJumlahTanggungan()
                UpdateStatusPTKP()
            End If
        Else
            MessageBox.Show("Pilih baris yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event Handler untuk perubahan data yang mempengaruhi PTKP
    Private Sub TextBoxNamaPasangan_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNamaPasangan.TextChanged
        UpdateStatusPTKP()
    End Sub

    Private Sub DataGridViewAnak_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAnak.CellValueChanged
        If e.RowIndex >= 0 Then
            UpdateJumlahTanggungan()
            UpdateStatusPTKP()
        End If
    End Sub

    ' Fungsi untuk update jumlah tanggungan otomatis
    Private Sub UpdateJumlahTanggungan()
        Dim jumlahTanggungan As Integer = 0
        
        ' Hitung jumlah anak yang status tanggungannya "Ya"
        For Each row As DataGridViewRow In DataGridViewAnak.Rows
            If Not row.IsNewRow Then
                Dim statusTanggungan As String = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
                If statusTanggungan = "Ya" Then
                    jumlahTanggungan += 1
                End If
            End If
        Next
        
        TextBoxJumlahTanggungan.Text = jumlahTanggungan.ToString()
    End Sub

    ' Fungsi untuk update Status PTKP otomatis berdasarkan data keluarga
    Private Sub UpdateStatusPTKP()
        Dim adaPasangan As Boolean = Not String.IsNullOrWhiteSpace(TextBoxNamaPasangan.Text)
        Dim jumlahAnakTanggungan As Integer = 0
        
        ' Hitung jumlah anak yang status tanggungannya "Ya"
        For Each row As DataGridViewRow In DataGridViewAnak.Rows
            If Not row.IsNewRow Then
                Dim statusTanggungan As String = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
                If statusTanggungan = "Ya" Then
                    jumlahAnakTanggungan += 1
                End If
            End If
        Next
        
        ' Tentukan Status PTKP berdasarkan data
        Dim statusPTKP As String = ""
        If Not adaPasangan Then
            ' Tidak Kawin
            If jumlahAnakTanggungan = 0 Then
                statusPTKP = "TK/0"
            Else
                ' Jika ada anak tapi tidak kawin, tetap TK/0 (sesuai aturan pajak)
                statusPTKP = "TK/0"
            End If
        Else
            ' Kawin
            If jumlahAnakTanggungan = 0 Then
                statusPTKP = "K/0"
            ElseIf jumlahAnakTanggungan = 1 Then
                statusPTKP = "K/1"
            ElseIf jumlahAnakTanggungan = 2 Then
                statusPTKP = "K/2"
            ElseIf jumlahAnakTanggungan >= 3 Then
                statusPTKP = "K/3"
            End If
        End If
        
        ' Update ComboBox jika status berubah
        If ComboBoxStatusPTKP.Items.Contains(statusPTKP) Then
            If ComboBoxStatusPTKP.SelectedItem Is Nothing OrElse ComboBoxStatusPTKP.SelectedItem.ToString() <> statusPTKP Then
                ComboBoxStatusPTKP.SelectedItem = statusPTKP
            End If
        End If
    End Sub

    ' Validasi Form
    Private Function ValidasiForm() As Boolean
        ' Validasi Nama Wajib Pajak
        If String.IsNullOrWhiteSpace(TextBoxNamaWajibPajak.Text) Then
            MessageBox.Show("Nama Wajib Pajak harus diisi!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNamaWajibPajak.Focus()
            Return False
        End If

        ' Validasi NPWP
        If String.IsNullOrWhiteSpace(TextBoxNPWP.Text) Then
            MessageBox.Show("NPWP harus diisi!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNPWP.Focus()
            Return False
        End If

        ' Validasi format NPWP (15 digit)
        Dim npwpClean As String = TextBoxNPWP.Text.Replace(".", "").Replace("-", "")
        If npwpClean.Length <> 15 Then
            MessageBox.Show("NPWP harus terdiri dari 15 digit!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNPWP.Focus()
            Return False
        End If

        ' Validasi NIK
        If String.IsNullOrWhiteSpace(TextBoxNIK.Text) Then
            MessageBox.Show("NIK harus diisi!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNIK.Focus()
            Return False
        End If

        ' Validasi format NIK (16 digit)
        If TextBoxNIK.Text.Length <> 16 Then
            MessageBox.Show("NIK harus terdiri dari 16 digit!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNIK.Focus()
            Return False
        End If

        ' Validasi Status PTKP
        If ComboBoxStatusPTKP.SelectedItem Is Nothing Then
            MessageBox.Show("Status PTKP harus dipilih!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxStatusPTKP.Focus()
            Return False
        End If

        ' Validasi Status Pekerjaan
        If ComboBoxStatusPekerjaan.SelectedItem Is Nothing Then
            MessageBox.Show("Status Pekerjaan harus dipilih!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxStatusPekerjaan.Focus()
            Return False
        End If

        ' Validasi Jenis Wajib Pajak
        If ComboBoxJenisWajibPajak.SelectedItem Is Nothing Then
            MessageBox.Show("Jenis Wajib Pajak harus dipilih!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxJenisWajibPajak.Focus()
            Return False
        End If

        ' Validasi Email
        If Not String.IsNullOrWhiteSpace(TextBoxEmail.Text) Then
            If Not IsValidEmail(TextBoxEmail.Text) Then
                MessageBox.Show("Format email tidak valid!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBoxEmail.Focus()
                Return False
            End If
        End If

        ' Validasi Alamat Lengkap
        If String.IsNullOrWhiteSpace(TextBoxAlamatLengkap.Text) Then
            MessageBox.Show("Alamat Lengkap harus diisi!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxAlamatLengkap.Focus()
            Return False
        End If

        Return True
    End Function

    ' Fungsi validasi email
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim regex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
            Return regex.IsMatch(email)
        Catch
            Return False
        End Try
    End Function

    ' Fungsi untuk menyimpan data (disini bisa disesuaikan dengan database atau file storage)
    Private Function SimpanData() As Boolean
        Try
            ' TODO: Implementasi penyimpanan data ke database atau file
            ' Contoh struktur data yang bisa disimpan:
            Dim dataProfil As New Dictionary(Of String, Object)
            dataProfil("NamaWajibPajak") = TextBoxNamaWajibPajak.Text
            dataProfil("NPWP") = TextBoxNPWP.Text
            dataProfil("NIK") = TextBoxNIK.Text
            dataProfil("StatusPTKP") = ComboBoxStatusPTKP.SelectedItem.ToString()
            dataProfil("TanggalLahir") = DateTimePickerTanggalLahir.Value
            dataProfil("StatusPekerjaan") = ComboBoxStatusPekerjaan.SelectedItem.ToString()
            dataProfil("JenisWajibPajak") = ComboBoxJenisWajibPajak.SelectedItem.ToString()
            dataProfil("NomorRegistrasi") = TextBoxNomorRegistrasi.Text
            dataProfil("AlamatLengkap") = TextBoxAlamatLengkap.Text
            dataProfil("Provinsi") = TextBoxProvinsi.Text
            dataProfil("Kota") = TextBoxKota.Text
            dataProfil("KodePos") = TextBoxKodePos.Text
            dataProfil("Email") = TextBoxEmail.Text
            dataProfil("Telepon") = TextBoxTelepon.Text
            dataProfil("NamaPasangan") = TextBoxNamaPasangan.Text
            dataProfil("JumlahTanggungan") = TextBoxJumlahTanggungan.Text

            ' Simpan data anak
            Dim listAnak As New List(Of Dictionary(Of String, String))
            For Each row As DataGridViewRow In DataGridViewAnak.Rows
                If Not row.IsNewRow Then
                    Dim dataAnak As New Dictionary(Of String, String)
                    dataAnak("NamaAnak") = If(row.Cells(0).Value IsNot Nothing, row.Cells(0).Value.ToString(), "")
                    dataAnak("TanggalLahirAnak") = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
                    dataAnak("StatusTanggungan") = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
                    listAnak.Add(dataAnak)
                End If
            Next
            dataProfil("DataAnak") = listAnak

            ' TODO: Simpan ke database atau file
            ' Contoh: SaveToDatabase(dataProfil) atau SaveToFile(dataProfil)

            Return True
        Catch ex As Exception
            MessageBox.Show("Error saat menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Event Handler untuk format NPWP (auto-format)
    Private Sub TextBoxNPWP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNPWP.TextChanged
        ' Format NPWP: XX.XXX.XXX.X-XXX.XXX
        Dim npwp As String = TextBoxNPWP.Text.Replace(".", "").Replace("-", "")
        If npwp.Length > 0 AndAlso npwp.Length <= 15 Then
            Dim formatted As String = ""
            If npwp.Length > 0 Then formatted &= npwp.Substring(0, Math.Min(2, npwp.Length))
            If npwp.Length > 2 Then formatted &= "." & npwp.Substring(2, Math.Min(3, npwp.Length - 2))
            If npwp.Length > 5 Then formatted &= "." & npwp.Substring(5, Math.Min(3, npwp.Length - 5))
            If npwp.Length > 8 Then formatted &= "." & npwp.Substring(8, Math.Min(1, npwp.Length - 8))
            If npwp.Length > 9 Then formatted &= "-" & npwp.Substring(9, Math.Min(3, npwp.Length - 9))
            If npwp.Length > 12 Then formatted &= "." & npwp.Substring(12, Math.Min(3, npwp.Length - 12))
            
            ' Update textbox tanpa trigger event
            RemoveHandler TextBoxNPWP.TextChanged, AddressOf TextBoxNPWP_TextChanged
            TextBoxNPWP.Text = formatted
            TextBoxNPWP.SelectionStart = TextBoxNPWP.Text.Length
            AddHandler TextBoxNPWP.TextChanged, AddressOf TextBoxNPWP_TextChanged
        End If
    End Sub

    ' Event Handler untuk format NIK (hanya angka)
    Private Sub TextBoxNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNIK.KeyPress
        ' Hanya allow angka
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Event Handler untuk format NPWP (hanya angka)
    Private Sub TextBoxNPWP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNPWP.KeyPress
        ' Hanya allow angka
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Event Handler untuk format Telepon (hanya angka)
    Private Sub TextBoxTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelepon.KeyPress
        ' Hanya allow angka, +, dan -
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "+" AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub

    ' Navigasi antar section
    Private Sub InitializeNavigation()
        navMap = New Dictionary(Of Button, GroupBox) From {
            {ButtonNavIkhtisar, GroupBoxIkhtisar},
            {ButtonNavInformasi, GroupBoxInformasiUmum},
            {ButtonNavAlamat, GroupBoxAlamat},
            {ButtonNavKontak, GroupBoxKontak},
            {ButtonNavKeluarga, GroupBoxKeluarga}
        }

        navButtons = New List(Of Button)(navMap.Keys)

        PanelDetail.SuspendLayout()
        PanelDetail.Controls.Clear()
        For Each section As GroupBox In navMap.Values
            section.Visible = False
            section.Dock = DockStyle.Fill
        Next
        PanelDetail.ResumeLayout()

        ShowSection(ButtonNavIkhtisar)
    End Sub

    Private Sub ShowSection(targetButton As Button)
        If navMap Is Nothing OrElse Not navMap.ContainsKey(targetButton) Then
            Return
        End If

        PanelDetail.SuspendLayout()
        PanelDetail.Controls.Clear()

        For Each btn As Button In navButtons
            btn.BackColor = Color.Transparent
            btn.ForeColor = Color.FromArgb(105, 112, 125)
            btn.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        Next

        targetButton.BackColor = Color.FromArgb(7, 71, 166)
        targetButton.ForeColor = Color.White
        targetButton.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)

        Dim selectedSection As GroupBox = navMap(targetButton)
        selectedSection.Visible = True
        PanelDetail.Controls.Add(selectedSection)
        selectedSection.BringToFront()
        PanelDetail.ResumeLayout()
    End Sub

    Private Sub ButtonNavIkhtisar_Click(sender As Object, e As EventArgs) Handles ButtonNavIkhtisar.Click
        ShowSection(ButtonNavIkhtisar)
    End Sub

    Private Sub ButtonNavInformasi_Click(sender As Object, e As EventArgs) Handles ButtonNavInformasi.Click
        ShowSection(ButtonNavInformasi)
    End Sub

    Private Sub ButtonNavAlamat_Click(sender As Object, e As EventArgs) Handles ButtonNavAlamat.Click
        ShowSection(ButtonNavAlamat)
    End Sub

    Private Sub ButtonNavKontak_Click(sender As Object, e As EventArgs) Handles ButtonNavKontak.Click
        ShowSection(ButtonNavKontak)
    End Sub

    Private Sub ButtonNavKeluarga_Click(sender As Object, e As EventArgs) Handles ButtonNavKeluarga.Click
        ShowSection(ButtonNavKeluarga)
    End Sub

End Class
