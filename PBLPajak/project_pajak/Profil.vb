Public Class Profil
    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Flag to prevent loop
    Private _isLoading As Boolean = True

    ' Hidden fields preservation
    Private _currentNPWP As String = ""
    Private _currentAlamat As String = ""
    Private _currentProvinsi As String = ""
    Private _currentKota As String = ""
    Private _currentKodePos As String = ""
    Private _currentNomorRegistrasi As String = ""
    Private _currentNegaraAsal As String = ""

    Private Sub ProfilNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply Design Tokens
        ApplyDesign()
    
        ' 1. Remove " (Dapat Diubah)" from GroupBoxes
        ' 1. Update Titles
        GroupBoxDataPribadi.Text = "1. Data Pribadi & Perpajakan"
        ' GroupBoxStatusPajak removed
        GroupBoxKeluarga.Text = "2. Data Unit Keluarga"

        ' Remove Jenis Wajib Pajak UI
        LabelJenisWajibPajak.Visible = False
        cmbJenisWajibPajak.Visible = False

        ' Ensure DB Schema is correct (Call BEFORE loading data)
        ModuleWajibPajak.CheckAndCreateProfileTables()
        ModuleWajibPajak.CleanupLegacyTables()

        ' 2. Load data wajib pajak
        LoadProfilData()
        
        _isLoading = False
        HitungStatusPTKP() ' Calculate once on load
    End Sub

    Private Sub ApplyDesign()
        ' Header
        PanelHeader.BackColor = ModuleDesign.PrimaryBlue
        LabelPageTitle.ForeColor = ModuleDesign.TextWhite
        LabelPageSubtitle.ForeColor = ModuleDesign.AccentBlue

        ' Content
        PanelContent.BackColor = ModuleDesign.BackgroundLight
        
        ' Buttons
        ModuleDesign.StylePrimaryButton(ButtonTambahKeluarga)
        ButtonTambahKeluarga.Padding = New Padding(5) ' Reduce padding
        ButtonTambahKeluarga.Text = "➕ Tambah"

        ModuleDesign.StyleSecondaryButton(ButtonEditKeluarga)
        ButtonEditKeluarga.Padding = New Padding(5)
        ButtonEditKeluarga.Text = "✏️ Edit"

        ModuleDesign.StyleOutlineButton(ButtonHapusKeluarga)
        ButtonHapusKeluarga.BackColor = ModuleDesign.AccentDanger
        ButtonHapusKeluarga.ForeColor = Color.White
        ButtonHapusKeluarga.Padding = New Padding(5)
        ButtonHapusKeluarga.Text = "🗑️ Hapus"
        
        ModuleDesign.StyleOutlineButton(ButtonKembali)
        ModuleDesign.StyleOutlineButton(ButtonBatal)
        ModuleDesign.StylePrimaryButton(ButtonSimpan)
        
        ' Grid
        ModuleDesign.StyleDataGridView(DataGridViewKeluarga)
        ' Override ReadOnly to allow editing family members
        DataGridViewKeluarga.ReadOnly = False
        DataGridViewKeluarga.AllowUserToAddRows = False ' Keep false, we use button
        DataGridViewKeluarga.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub

    Private Sub LoadProfilData()
        Try
            If String.IsNullOrEmpty(Module1.CurrentUserNIK) Then
                MessageBox.Show("User tidak login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If

            Dim data = ModuleWajibPajak.LoadWajibPajakByNIK(Module1.CurrentUserNIK)
            If data IsNot Nothing Then
                ' === 1. Data Pribadi (Auto-fill from Registration) ===
                If data.ContainsKey("NIK") Then txtNIK.Text = data("NIK").ToString()
                If data.ContainsKey("NamaWajibPajak") Then txtNama.Text = data("NamaWajibPajak").ToString()
                If data.ContainsKey("Email") Then txtEmail.Text = data("Email").ToString()
                If data.ContainsKey("TempatLahir") Then txtTempatLahir.Text = data("TempatLahir").ToString()
                If data.ContainsKey("TanggalLahir") AndAlso Not IsDBNull(data("TanggalLahir")) Then dtpTanggalLahir.Value = Convert.ToDateTime(data("TanggalLahir"))
                If data.ContainsKey("JenisKelamin") Then cmbJenisKelamin.Text = data("JenisKelamin").ToString()
                If data.ContainsKey("StatusPernikahan") Then cmbStatusPernikahan.Text = data("StatusPernikahan").ToString()
                If data.ContainsKey("NoHandphone") Then txtNoHP.Text = data("NoHandphone").ToString()
                ' Note: StatusPernikahan is critical for PTKP

                ' === 2. Status Perpajakan ===
                If data.ContainsKey("StatusPTKP") AndAlso Not IsDBNull(data("StatusPTKP")) Then cmbStatusPTKP.Text = data("StatusPTKP").ToString()
                ' Jenis Wajib Pajak removed per request
                ' If data.ContainsKey("JenisWajibPajak") AndAlso Not IsDBNull(data("JenisWajibPajak")) Then cmbJenisWajibPajak.Text = data("JenisWajibPajak").ToString()

                ' Auto-fill Status Pekerjaan from Registration if available
                Dim pekerjaanReg As String = ""
                If data.ContainsKey("Pekerjaan") Then pekerjaanReg = data("Pekerjaan").ToString()

                If data.ContainsKey("StatusPekerjaan") AndAlso Not String.IsNullOrEmpty(data("StatusPekerjaan").ToString()) Then
                    cmbStatusPekerjaan.Text = data("StatusPekerjaan").ToString()
                ElseIf Not String.IsNullOrEmpty(pekerjaanReg) Then
                    ' Map free text 'Pekerjaan' to 'Status Pekerjaan' options if possible, or just set it
                    cmbStatusPekerjaan.Text = pekerjaanReg
                End If

                If data.ContainsKey("TempatKerja") Then txtNamaTempatKerja.Text = data("TempatKerja").ToString()
                If data.ContainsKey("Jabatan") Then txtJabatan.Text = data("Jabatan").ToString()
                If data.ContainsKey("AlamatLengkap") Then txtAlamat.Text = data("AlamatLengkap").ToString() ' New: Display Address

                ' Store hidden fields
                If data.ContainsKey("NPWP") Then _currentNPWP = data("NPWP").ToString()
                ' _currentAlamat is now synced with txtAlamat, but we keep it for reference or just use txtAlamat directly
                If data.ContainsKey("AlamatLengkap") Then _currentAlamat = data("AlamatLengkap").ToString() 

                If data.ContainsKey("Provinsi") Then _currentProvinsi = data("Provinsi").ToString()
                If data.ContainsKey("Kota") Then _currentKota = data("Kota").ToString()
                If data.ContainsKey("KodePos") Then _currentKodePos = data("KodePos").ToString()
                If data.ContainsKey("NomorRegistrasi") Then _currentNomorRegistrasi = data("NomorRegistrasi").ToString()
                If data.ContainsKey("NegaraAsal") Then _currentNegaraAsal = data("NegaraAsal").ToString()

                ' === 3. Data Unit Keluarga ===
                ' Populate Grid from 'DataAnak' List
                If data.ContainsKey("DataAnak") Then
                    Dim listAnak = DirectCast(data("DataAnak"), List(Of Dictionary(Of String, String)))
                    DataGridViewKeluarga.Rows.Clear()
                    For Each anak In listAnak
                        Dim rowIndex = DataGridViewKeluarga.Rows.Add()
                        Dim row = DataGridViewKeluarga.Rows(rowIndex)
                        row.Cells("ColNamaAnggota").Value = anak("NamaAnak")
                        row.Cells("ColTanggalLahir").Value = anak("TanggalLahir")
                        
                        ' Safe Set ComboBox Value
                        Dim statusTanggungan As String = anak("StatusTanggungan")
                        Try
                            row.Cells("ColStatusHubungan").Value = statusTanggungan
                        Catch
                            ' If value not in list, default to "Anak" or empty
                            row.Cells("ColStatusHubungan").Value = "Anak" 
                        End Try
                        
                        row.Cells("ColPekerjaan").Value = If(anak.ContainsKey("Pekerjaan"), anak("Pekerjaan"), "-")
                    Next
                End If

                ' Jika ada Pasangan (Header Table), masukan ke Grid juga jika belum ada
                If data.ContainsKey("NamaPasangan") AndAlso Not String.IsNullOrEmpty(data("NamaPasangan").ToString()) Then
                    ' Check if already in grid (simple check)
                    Dim found As Boolean = False
                    For Each row As DataGridViewRow In DataGridViewKeluarga.Rows
                        If row.Cells("StatusHubungan").Value IsNot Nothing AndAlso
                           (row.Cells("StatusHubungan").Value.ToString().Contains("Suami") OrElse
                            row.Cells("StatusHubungan").Value.ToString().Contains("Istri")) Then
                            found = True
                            Exit For
                        End If
                    Next

                    If Not found Then
                        Dim role As String = "Suami/Istri" ' Simplification
                        If cmbJenisKelamin.Text = "Laki-laki" Then role = "Istri"
                        If cmbJenisKelamin.Text = "Perempuan" Then role = "Suami"

                        ' Try Catch for Pasangan too
                        Try
                             DataGridViewKeluarga.Rows.Add(data("NamaPasangan").ToString(), "", role, "-", "")
                        Catch
                             DataGridViewKeluarga.Rows.Add(data("NamaPasangan").ToString(), "", Nothing, "-", "")
                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading profil: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update PTKP saat Status Pernikahan berubah
    Private Sub cmbStatusPernikahan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatusPernikahan.SelectedIndexChanged
        If Not _isLoading Then HitungStatusPTKP()
    End Sub

    ' Update PTKP saat Data Keluarga berubah
    Private Sub ButtonTambahKeluarga_Click(sender As Object, e As EventArgs) Handles ButtonTambahKeluarga.Click
        ' Logic tambah baris (biasanya user input manual di grid atau popup form)
        ' Disini kita asumsi user edit langsung di grid atau kita add row kosong
        DataGridViewKeluarga.Rows.Add("", "", "Anak", "", "")
        HitungStatusPTKP()
    End Sub

    Private Sub DataGridViewKeluarga_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKeluarga.CellValueChanged
        If Not _isLoading Then HitungStatusPTKP()
    End Sub

    Private Sub DataGridViewKeluarga_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridViewKeluarga.RowsRemoved
        If Not _isLoading Then HitungStatusPTKP()
    End Sub

    Private Sub HitungStatusPTKP()
        Try
            Dim statusKawin As String = "TK" ' Default Tidak Kawin
            Dim jumlahTanggungan As Integer = 0

            ' 1. Cek Status Pernikahan (Base)
            Dim statusNikahInput As String = If(cmbStatusPernikahan.SelectedItem IsNot Nothing, cmbStatusPernikahan.SelectedItem.ToString(), cmbStatusPernikahan.Text)

            If statusNikahInput.ToLower().Contains("menikah") OrElse statusNikahInput.ToLower().Contains("kawin") Then
                statusKawin = "K"
            End If

            ' 2. Cek Grid Keluarga
            Dim hasSpouseInGrid As Boolean = False

            For Each row As DataGridViewRow In DataGridViewKeluarga.Rows
                If row.IsNewRow Then Continue For

                Dim hubungan As String = ""
                If row.Cells("ColStatusHubungan").Value IsNot Nothing Then
                    hubungan = row.Cells("ColStatusHubungan").Value.ToString().ToLower()
                End If

                If hubungan.Contains("suami") OrElse hubungan.Contains("istri") Then
                    hasSpouseInGrid = True
                ElseIf hubungan.Contains("anak") Then
                    jumlahTanggungan += 1
                End If
            Next

            ' Jika ada pasangan di grid, otomatis K
            If hasSpouseInGrid Then statusKawin = "K"

            ' Max tanggungan 3
            If jumlahTanggungan > 3 Then jumlahTanggungan = 3

            ' Set UI
            Dim resultCode As String = statusKawin & "/" & jumlahTanggungan

            ' Cari item di combobox yg match
            Dim found As Boolean = False
            For Each item As String In cmbStatusPTKP.Items
                If item.StartsWith(resultCode) Then
                    cmbStatusPTKP.SelectedItem = item
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                cmbStatusPTKP.Text = resultCode ' Set text directly if not found in standard list
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        ' Validasi input
        If Not ValidateInput() Then
            Return
        End If

        ' Simpan data profil
        If SimpanProfil() Then
            MessageBox.Show("Profil berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Gagal menyimpan profil!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        ' Validasi Status PTKP wajib diisi
        If cmbStatusPTKP.SelectedIndex = -1 Then
            MessageBox.Show("Status PTKP harus dipilih!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatusPTKP.Focus()
            Return False
        End If

        ' Validasi Jenis Wajib Pajak REMOVED
        ' If cmbJenisWajibPajak.SelectedIndex = -1 Then
        '     MessageBox.Show("Jenis Wajib Pajak harus dipilih!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '     cmbJenisWajibPajak.Focus()
        '     Return False
        ' End If

        ' Validasi Status Pekerjaan
        If cmbStatusPekerjaan.SelectedIndex = -1 Then
            MessageBox.Show("Status Pekerjaan harus dipilih!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatusPekerjaan.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function SimpanProfil() As Boolean
        Try
            ' Collect Data from Grid for Child
            Dim listAnak As New List(Of Dictionary(Of String, String))
            Dim namaPasangan As String = ""
            Dim jumlahTanggungan As Integer = 0

            For Each row As DataGridViewRow In DataGridViewKeluarga.Rows
                If row.IsNewRow Then Continue For

                Dim nama As String = If(row.Cells("ColNamaAnggota").Value IsNot Nothing, row.Cells("ColNamaAnggota").Value.ToString(), "")
                Dim hubungan As String = If(row.Cells("ColStatusHubungan").Value IsNot Nothing, row.Cells("ColStatusHubungan").Value.ToString(), "")
                
                If String.IsNullOrEmpty(nama) Then Continue For

                If hubungan.ToLower().Contains("suami") OrElse hubungan.ToLower().Contains("istri") Then
                    namaPasangan = nama
                ElseIf hubungan.ToLower().Contains("anak") Then
                    Dim anak As New Dictionary(Of String, String)
                    anak("NamaAnak") = nama
                    anak("TanggalLahirAnak") = If(row.Cells("ColTanggalLahir").Value IsNot Nothing, row.Cells("ColTanggalLahir").Value.ToString(), "")
                    anak("StatusTanggungan") = hubungan
                    anak("Pekerjaan") = If(row.Cells("ColPekerjaan").Value IsNot Nothing, row.Cells("ColPekerjaan").Value.ToString(), "-")
                    listAnak.Add(anak)
                    jumlahTanggungan += 1
                End If
            Next

            ' Prep Data for Save
            Dim dataProfil As New Dictionary(Of String, Object)
            dataProfil("StatusPTKP") = cmbStatusPTKP.Text
            dataProfil("JenisWajibPajak") = "" ' Default empty as UI removed
            dataProfil("StatusPekerjaan") = cmbStatusPekerjaan.Text
            dataProfil("TempatKerja") = txtNamaTempatKerja.Text
            dataProfil("Jabatan") = txtJabatan.Text ' New

            ' Core Data Update (Allowed fields)
            dataProfil("NamaWajibPajak") = txtNama.Text
            ' dataProfil("NPWP") = _currentNPWP ' Removed, NIK used
            dataProfil("TanggalLahir") = dtpTanggalLahir.Value
            dataProfil("JenisKelamin") = cmbJenisKelamin.Text
            dataProfil("StatusPernikahan") = cmbStatusPernikahan.Text
            dataProfil("TempatLahir") = txtTempatLahir.Text
            dataProfil("NegaraAsal") = _currentNegaraAsal

            ' Family Data
            dataProfil("NamaPasangan") = namaPasangan
            dataProfil("JumlahTanggungan") = jumlahTanggungan.ToString()
            dataProfil("DataAnak") = listAnak

            ' Address & Contact 
            dataProfil("AlamatLengkap") = txtAlamat.Text ' Updated from UI
            dataProfil("Provinsi") = _currentProvinsi
            dataProfil("Kota") = _currentKota
            dataProfil("KodePos") = _currentKodePos
            dataProfil("Email") = txtEmail.Text
            dataProfil("Telepon") = txtNoHP.Text
            dataProfil("NomorRegistrasi") = _currentNomorRegistrasi

            Return ModuleWajibPajak.SimpanProfilData(Module1.CurrentUserNIK, dataProfil)

        Catch ex As Exception
            MessageBox.Show("Error saving profil: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Dim result = MessageBox.Show("Batalkan perubahan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            LoadProfilData() ' Reload data asli
        End If
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Dim frm As New Dashboard()
        frm.Show()
        Me.Close()
    End Sub
End Class
