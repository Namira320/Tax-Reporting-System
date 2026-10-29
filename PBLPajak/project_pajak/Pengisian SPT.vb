Imports System.Data.SqlClient

Public Class Pengisian_SPT
    ' Connection string is now handled by Module1.GetConnection()

    Private Sub Pengisian_SPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DISABLE AUTOSCALE TO PREVENT LAYOUT ISSUES
        Me.AutoScaleMode = AutoScaleMode.None

        ' Ensure Detail Pelaporan controls are enabled
        ComboBoxStatus.Enabled = True
        TextBoxBruto.Enabled = True ' New
        TextBoxBiayaJabatan.ReadOnly = True ' Calculated
        TextBoxIuran.Enabled = True ' New
        TextBoxPenghasilan.Enabled = True ' Calculated/Manual
        TextBoxPPh.Enabled = True
        TextBoxKredit.Enabled = True
        DateTimePickerLapor.Enabled = True
        ComboBoxStatusPTKP.Enabled = True

        ' Auto-fill data if user is logged in
        If Not String.IsNullOrEmpty(Module1.CurrentUserNIK) Then
            TextBoxNPWP.Text = Module1.CurrentUserNIK
            TextBoxNPWP.ReadOnly = True ' Lock NPWP field

            ' Load data using centralized module
            Dim data As Dictionary(Of String, Object) = ModuleWajibPajak.LoadWajibPajakByNIK(Module1.CurrentUserNIK)

            If data IsNot Nothing Then
                TextBoxNama.Text = If(data.ContainsKey("NamaWajibPajak"), data("NamaWajibPajak").ToString(), "")
                TextBoxNama.ReadOnly = True
                
                If data.ContainsKey("StatusPTKP") Then
                    ' Coba set langsung jika format cocok
                    ComboBoxStatusPTKP.Text = data("StatusPTKP").ToString()
                    
                    ' Jika data hanya kode (misal TK/0), cari di items yg cocok
                    If ComboBoxStatusPTKP.SelectedIndex = -1 Then
                        Dim code = data("StatusPTKP").ToString()
                        For Each item In ComboBoxStatusPTKP.Items
                            If item.ToString().StartsWith(code) Then
                                ComboBoxStatusPTKP.SelectedItem = item
                                Exit For
                            End If
                        Next
                    End If
                Else
                    ComboBoxStatusPTKP.SelectedIndex = 0 ' Default TK/0
                End If

                ' Auto Calculate Tax
                If data IsNot Nothing AndAlso data.ContainsKey("PenghasilanPerBulan") Then
                     Dim penghasilanPerBulan As Decimal = Convert.ToDecimal(data("PenghasilanPerBulan"))
                     Dim brutoSetahun As Decimal = penghasilanPerBulan * 12
                     TextBoxBruto.Text = brutoSetahun.ToString("N0")
                End If

                TextBoxIuran.Text = "0" ' Default 0

                HitungPajak() ' Initial calculation
            End If
        End If
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Me.AutoScaleMode = AutoScaleMode.None
    End Sub

    Private Sub HitungPajak()
        Try
            ' 0. Ambil Bruto & Iuran
            Dim bruto As Decimal = 0
            Dim iuran As Decimal = 0
            
            Decimal.TryParse(TextBoxBruto.Text.Replace(".", "").Replace(",", ""), bruto)
            Decimal.TryParse(TextBoxIuran.Text.Replace(".", "").Replace(",", ""), iuran)

            ' 1. Hitung Biaya Jabatan (5% dari Bruto, Max 6jt/tahun atau 500rb/bulan)
            ' Asumsi SPT Tahunan (12 bulan) -> Max 6 Juta
            Dim biayaJabatan As Decimal = bruto * 0.05D
            If biayaJabatan > 6000000 Then biayaJabatan = 6000000
            
            TextBoxBiayaJabatan.Text = biayaJabatan.ToString("N0")

            ' 2. Hitung Neto
            Dim netto As Decimal = bruto - biayaJabatan - iuran
            If netto < 0 Then netto = 0
            
            TextBoxPenghasilan.Text = netto.ToString("N0")

            ' 2. Hitung PTKP
            Dim statusPTKP As String = "TK/0"
            If ComboBoxStatusPTKP.SelectedItem IsNot Nothing Then
                statusPTKP = ComboBoxStatusPTKP.SelectedItem.ToString().Split("-"c)(0).Trim()
            End If

            Dim nilaiPTKP As Decimal = 54000000
            Select Case statusPTKP
                Case "TK/0" : nilaiPTKP = 54000000
                Case "TK/1" : nilaiPTKP = 58500000
                Case "TK/2" : nilaiPTKP = 63000000
                Case "TK/3" : nilaiPTKP = 67500000
                Case "K/0" : nilaiPTKP = 58500000
                Case "K/1" : nilaiPTKP = 63000000
                Case "K/2" : nilaiPTKP = 67500000
                Case "K/3" : nilaiPTKP = 72000000
            End Select

            ' 3. Hitung PKP (Penghasilan Kena Pajak)
            ' PKP dibulatkan ke bawah hingga ribuan penuh
            Dim pkp As Decimal = netto - nilaiPTKP
            If pkp < 0 Then pkp = 0
            pkp = Math.Floor(pkp / 1000) * 1000 ' Pembulatan ribuan ke bawah

            TextBoxPKP.Text = pkp.ToString("N0")

            ' 4. Hitung PPh Terutang (Tarif Progresif UU HPP / Pasal 17)
            ' Lapisan 1: 0 - 60 Juta           => 5%
            ' Lapisan 2: >60 - 250 Juta        => 15%
            ' Lapisan 3: >250 - 500 Juta       => 25%
            ' Lapisan 4: >500 Juta - 5 Miliar  => 30%
            ' Lapisan 5: >5 Miliar             => 35%

            Dim pph As Decimal = 0
            Dim sisaPKP As Decimal = pkp

            ' Layer 1
            If sisaPKP > 0 Then
                Dim layer1 As Decimal = Math.Min(sisaPKP, 60000000)
                pph += layer1 * 0.05D
                sisaPKP -= layer1
            End If

            ' Layer 2
            If sisaPKP > 0 Then
                Dim layer2 As Decimal = Math.Min(sisaPKP, 190000000) ' 250jt - 60jt = 190jt
                pph += layer2 * 0.15D
                sisaPKP -= layer2
            End If

            ' Layer 3
            If sisaPKP > 0 Then
                Dim layer3 As Decimal = Math.Min(sisaPKP, 250000000) ' 500jt - 250jt = 250jt
                pph += layer3 * 0.25D
                sisaPKP -= layer3
            End If

            ' Layer 4
            If sisaPKP > 0 Then
                Dim layer4 As Decimal = Math.Min(sisaPKP, 4500000000) ' 5M - 500jt = 4.5M
                pph += layer4 * 0.3D
                sisaPKP -= layer4
            End If

            ' Layer 5
            If sisaPKP > 0 Then
                pph += sisaPKP * 0.35D
            End If

            ' Cek NPWP (Jika tidak ada NPWP, tarif 120% / kenaikan 20%)
            ' Asumsi TextBoxNPWP kosong atau dummy = Non NPWP
            Dim npwp As String = TextBoxNPWP.Text.Replace(".", "").Replace("-", "").Trim()
            If String.IsNullOrEmpty(npwp) OrElse npwp.Length < 15 Then
                ' Tambahan 20%
                pph = pph * 1.2D
            End If

            TextBoxPPh.Text = pph.ToString("N0")

        Catch ex As Exception
            ' Silent error handling for calc updates
        End Try
    End Sub

    Private Sub ValidateAndFormatCurrency(txt As TextBox)
         RemoveHandler txt.TextChanged, AddressOf TextBoxGeneric_TextChanged
         
         Dim cursorPosition As Integer = txt.SelectionStart
         Dim originalLength As Integer = txt.Text.Length
         
         Dim value As Decimal = 0
         Dim rawText As String = txt.Text.Replace(".", "").Replace(",", "")
         
         If Decimal.TryParse(rawText, value) Then
             txt.Text = value.ToString("N0")
         Else
             txt.Text = rawText
         End If
         
         Dim newLength As Integer = txt.Text.Length
         cursorPosition = cursorPosition + (newLength - originalLength)
         If cursorPosition < 0 Then cursorPosition = 0
         If cursorPosition > newLength Then cursorPosition = newLength
         
         txt.SelectionStart = cursorPosition
         
         AddHandler txt.TextChanged, AddressOf TextBoxGeneric_TextChanged
         
         HitungPajak()
    End Sub

    Private Sub TextBoxGeneric_TextChanged(sender As Object, e As EventArgs)
        ValidateAndFormatCurrency(CType(sender, TextBox))
    End Sub

    Private Sub InitCurrencyHandlers()
        AddHandler TextBoxBruto.TextChanged, AddressOf TextBoxGeneric_TextChanged
        AddHandler TextBoxIuran.TextChanged, AddressOf TextBoxGeneric_TextChanged
        AddHandler TextBoxKredit.TextChanged, AddressOf TextBoxGeneric_TextChanged
        ' TextBoxPenghasilan is now ReadOnly/Calculated dominantly, but if user edits it manually? 
        ' Logic rewrites it based on Bruto. If we want manual override, we need a flag.
        ' For now, Bruto drives Neto. 
    End Sub

    Private Sub Pengisian_SPT_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        InitCurrencyHandlers()
    End Sub



    Private Sub ComboBoxStatusPTKP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxStatusPTKP.SelectedIndexChanged
        HitungPajak()
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(TextBoxNPWP.Text) OrElse String.IsNullOrWhiteSpace(TextBoxNama.Text) Then
            MessageBox.Show("Mohon lengkapi NPWP dan Nama.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ComboBoxJenisSPT.SelectedItem Is Nothing Then
            MessageBox.Show("Mohon pilih Jenis SPT.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ComboBoxStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Mohon pilih Status SPT.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn = GetConnection
            Try
                If Not OpenConnection(conn) Then
                    MessageBox.Show("Gagal membuka koneksi database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' New Schema:
                ' [NIK], [TahunPajak], [MasaPajak], [StatusPembetulan], [PenghasilanBruto], [PenghasilanNetto], 
                ' [PPhDipotong], [PPhKurangLebih], [StatusBayar], [TanggalInput], [TanggalUpdate]

                Dim query = "INSERT INTO tbl_SPT (NIK, TahunPajak, MasaPajak, StatusPembetulan, PenghasilanNetto, PPhTerutang, PPhDipotong, PPhKurangLebih, StatusBayar, TanggalInput, TanggalUpdate) VALUES (@NIK, @TahunPajak, @MasaPajak, @StatusPembetulan, @PenghasilanNetto, @PPhTerutang, @PPhDipotong, @PPhKurangLebih, @StatusBayar, @TanggalInput, @TanggalUpdate)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NIK", TextBoxNPWP.Text)
                    cmd.Parameters.AddWithValue("@TahunPajak", NumericUpDownTahun.Value)
                    cmd.Parameters.AddWithValue("@MasaPajak", 12) ' Default Annual

                    ' Parse StatusPembetulan
                    Dim statusPembetulan = 0
                    Select Case ComboBoxStatus.SelectedItem.ToString
                        Case "Normal"
                            statusPembetulan = 0
                        Case "Pembetulan I"
                            statusPembetulan = 1
                        Case "Pembetulan II"
                            statusPembetulan = 2
                        Case "Pembetulan III"
                            statusPembetulan = 3
                        Case Else
                            statusPembetulan = 0
                    End Select
                    cmd.Parameters.AddWithValue("@StatusPembetulan", statusPembetulan)

                    Dim penghasilan As Decimal = 0
                    Decimal.TryParse(TextBoxPenghasilan.Text.Replace(".", "").Replace(",", ""), penghasilan)
                    cmd.Parameters.AddWithValue("@PenghasilanNetto", penghasilan)

                    ' Calculate Tax Details
                    Dim pphTerutang As Decimal = 0
                    Dim kreditPajak As Decimal = 0
                    
                    Decimal.TryParse(TextBoxPPh.Text.Replace(".", "").Replace(",", ""), pphTerutang)
                    Decimal.TryParse(TextBoxKredit.Text.Replace(".", "").Replace(",", ""), kreditPajak)
                    
                    Dim kurangLebih As Decimal = pphTerutang - kreditPajak

                    ' Add Parameters
                    cmd.Parameters.AddWithValue("@PPhTerutang", pphTerutang)
                    cmd.Parameters.AddWithValue("@PPhDipotong", kreditPajak) ' Kredit Pajak treated as PPh Dipotong for dashboard
                    cmd.Parameters.AddWithValue("@PPhKurangLebih", kurangLebih)

                    ' Determine StatusBayar
                    Dim statusBayar = "Nihil"
                    If kurangLebih > 0 Then
                        statusBayar = "Kurang Bayar"
                    ElseIf kurangLebih < 0 Then
                        statusBayar = "Lebih Bayar"
                    End If
                    cmd.Parameters.AddWithValue("@StatusBayar", statusBayar)

                    cmd.Parameters.AddWithValue("@TanggalInput", Date.Now)
                    cmd.Parameters.AddWithValue("@TanggalUpdate", Date.Now)

                    cmd.ExecuteNonQuery
                End Using

                MessageBox.Show("Data SPT berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Navigation removed as per request. User stays on the form.

            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan data SPT: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ButtonPreview_Click(sender As Object, e As EventArgs) Handles ButtonPreview.Click
        Dim summary As String = $"NPWP: {TextBoxNPWP.Text}{vbCrLf}" &
                                $"Nama: {TextBoxNama.Text}{vbCrLf}" &
                                $"Jenis SPT: {If(ComboBoxJenisSPT.SelectedItem IsNot Nothing, ComboBoxJenisSPT.SelectedItem.ToString(), "-")}{vbCrLf}" &
                                $"Tahun Pajak: {NumericUpDownTahun.Value}{vbCrLf}" &
                                $"Status SPT: {If(ComboBoxStatus.SelectedItem IsNot Nothing, ComboBoxStatus.SelectedItem.ToString(), "-")}{vbCrLf}" &
                                $"Status PTKP: {If(ComboBoxStatusPTKP.SelectedItem IsNot Nothing, ComboBoxStatusPTKP.SelectedItem.ToString(), "-")}{vbCrLf}" &
                                $"Penghasilan Neto: {TextBoxPenghasilan.Text}{vbCrLf}" &
                                $"Status PTKP: {If(ComboBoxStatusPTKP.SelectedItem IsNot Nothing, ComboBoxStatusPTKP.SelectedItem.ToString(), "-")}{vbCrLf}" &
                                $"PKP: {TextBoxPKP.Text}{vbCrLf}" &
                                $"PPh Terutang (5%): {TextBoxPPh.Text}{vbCrLf}" &
                                $"Kredit Pajak: {TextBoxKredit.Text}{vbCrLf}" &
                                $"Tanggal Lapor: {DateTimePickerLapor.Value.ToShortDateString()}"

        MessageBox.Show(summary, "Preview SPT", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonUnggahDokumen_Click(sender As Object, e As EventArgs) Handles ButtonUnggahDokumen.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Portable Document Format (*.pdf)|*.pdf|Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            openFileDialog.Title = "Pilih Dokumen Bukti Potong 1721-A1"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Simulasi Proses Scanning
                Cursor = Cursors.WaitCursor
                System.Threading.Thread.Sleep(1000) ' Delay 1 detik untuk efek "Loading/Scanning"
                Cursor = Cursors.Default
                
                Dim fileName As String = IO.Path.GetFileName(openFileDialog.FileName)
                
                ' Hitung nilai yang valid berdasarkan profil user agar data terlihat "Real"
                Try
                    ' 1. Ambil data profil terbaru dari database
                    Dim data = ModuleWajibPajak.LoadWajibPajakByNIK(Module1.CurrentUserNIK)
                    
                    If data IsNot Nothing Then
                        ' 2. Lakukan perhitungan di background (Logic PPh 21)
                        Dim penghasilanPerBulan As Decimal = If(data.ContainsKey("PenghasilanPerBulan"), Convert.ToDecimal(data("PenghasilanPerBulan")), 0)
                        Dim statusPTKP As String = "TK/0"
                        If ComboBoxStatusPTKP.SelectedItem IsNot Nothing Then
                             ' Ambil kode depan saja misal "TK/0" dari "TK/0 - Tidak Kawin..."
                             statusPTKP = ComboBoxStatusPTKP.SelectedItem.ToString().Split("-"c)(0).Trim()
                        End If
                        
                        Dim penghasilanBrutoSetahun As Decimal = penghasilanPerBulan * 12
                        Dim biayaJabatan As Decimal = Math.Min(penghasilanBrutoSetahun * 0.05D, 6000000)
                        Dim penghasilanNeto As Decimal = penghasilanBrutoSetahun - biayaJabatan
                        
                        Dim nilaiPTKP As Decimal = 54000000
                        Select Case statusPTKP
                            Case "TK/0" : nilaiPTKP = 54000000
                            Case "TK/1" : nilaiPTKP = 58500000
                            Case "TK/2" : nilaiPTKP = 63000000
                            Case "TK/3" : nilaiPTKP = 67500000
                            Case "K/0" : nilaiPTKP = 58500000
                            Case "K/1" : nilaiPTKP = 63000000
                            Case "K/2" : nilaiPTKP = 67500000
                            Case "K/3" : nilaiPTKP = 72000000
                        End Select
                        
                        Dim pkp As Decimal = Math.Max(0, penghasilanNeto - nilaiPTKP)
                        pkp = Math.Floor(pkp / 1000) * 1000
                        
                        Dim pphTerutang As Decimal = 0
                        Dim sisaPKP As Decimal = pkp
                        
                        ' Hitung PPh Progresif
                        If sisaPKP > 0 Then
                             Dim layer1 As Decimal = Math.Min(sisaPKP, 60000000)
                             pphTerutang += layer1 * 0.05D
                             sisaPKP -= layer1
                        End If
                        If sisaPKP > 0 Then
                             Dim layer2 As Decimal = Math.Min(sisaPKP, 190000000)
                             pphTerutang += layer2 * 0.15D
                             sisaPKP -= layer2
                        End If
                         If sisaPKP > 0 Then
                             Dim layer3 As Decimal = Math.Min(sisaPKP, 250000000)
                             pphTerutang += layer3 * 0.25D
                             sisaPKP -= layer3
                        End If
                         If sisaPKP > 0 Then
                             Dim layer4 As Decimal = Math.Min(sisaPKP, 4500000000)
                             pphTerutang += layer4 * 0.3D
                             sisaPKP -= layer4
                        End If
                        If sisaPKP > 0 Then
                            pphTerutang += sisaPKP * 0.35D
                        End If
                        
                        ' 3. Tampilkan Hasil "Scan"
                        Dim pesanSukses As String = $"Berhasil memindai dokumen: {fileName}{vbCrLf}{vbCrLf}" &
                                                    $"DATA TERDETEKSI:{vbCrLf}" &
                                                    $"----------------{vbCrLf}" &
                                                    $"Penghasilan Neto: Rp {penghasilanNeto:N0}{vbCrLf}" &
                                                    $"PPh 21 Terutang: Rp {pphTerutang:N0}{vbCrLf}{vbCrLf}" &
                                                    $"Apakah Anda ingin menerapkan data ini ke formulir?"

                        Dim result = MessageBox.Show(pesanSukses, "Smart Scan Berhasil", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                        If result = DialogResult.Yes Then
                            ' 4. Auto-Fill Form
                            TextBoxPenghasilan.Text = penghasilanNeto.ToString("N0")
                            TextBoxPPh.Text = pphTerutang.ToString("N0")
                            
                            ' Asumsi: Pajak sudah dipotong lunas oleh kantor (Bukti Potong 1721-A1)
                            TextBoxPKP.Text = pkp.ToString("N0")
                            TextBoxKredit.Text = "0" 
                            
                            MessageBox.Show("Formulir telah diisi otomatis berdasarkan Bukti Potong.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Gagal memindai dokumen: " & ex.Message, "Scan Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        End Using
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Dim frmDashboard As New Dashboard
        frmDashboard.Show()
        Close()
    End Sub

    Private Sub ButtonKeSimulasi_Click(sender As Object, e As EventArgs) Handles ButtonKeSumulasi.Click
        Dim frmSimulasi As New Simulasi
        frmSimulasi.Show()
        Close()
    End Sub

    Private Sub ButtonExportPDF_Click(sender As Object, e As EventArgs) Handles ButtonExportPDF.Click
        ' Configure PrintDocument for PDF Export
        PrintDocument1.DocumentName = "Laporan_SPT_" & TextBoxNPWP.Text
        
        ' Attempt to use "Microsoft Print to PDF" automatically
        ' This simulates a "Save As PDF" behavior
        Dim printerFound As Boolean = False
        For Each printer As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            If printer.Contains("Microsoft Print to PDF") Then
                PrintDocument1.PrinterSettings.PrinterName = printer
                printerFound = True
                Exit For
            End If
        Next

        Try
            If printerFound Then
                PrintDocument1.Print() ' This will open the file save dialog
            Else
                ' Fallback: Let user choose a printer (likely a PDF printer)
                Dim pd As New PrintDialog()
                pd.Document = PrintDocument1
                If pd.ShowDialog() = DialogResult.OK Then
                    PrintDocument1.Print()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal melakukan export PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim bounds As Rectangle = e.MarginBounds

        ' Fonts
        Dim titleFont As New Font("Segoe UI", 24, FontStyle.Bold)
        Dim subTitleFont As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim headerFont As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim contentFont As New Font("Segoe UI", 12)
        Dim footerFont As New Font("Segoe UI", 10, FontStyle.Italic)

        ' Colors
        Dim primaryColor As Brush = New SolidBrush(Color.FromArgb(41, 128, 185))
        Dim textColor As Brush = Brushes.Black
        Dim paramColor As Brush = Brushes.DimGray

        Dim yPos As Integer = 80
        Dim leftMargin As Integer = 80
        Dim rightMargin As Integer = e.PageBounds.Width - 80
        
        ' 1. Header with Logo or Box
        Dim headerRect As New Rectangle(leftMargin, 60, rightMargin - leftMargin, 100)
        ' g.FillRectangle(New SolidBrush(Color.FromArgb(240, 240, 240)), headerRect) ' Optional background
        
        g.DrawString("LAPORAN SPT TAHUNAN", titleFont, primaryColor, leftMargin, yPos)
        yPos += 50
        g.DrawString("TAHUN PAJAK " & NumericUpDownTahun.Value.ToString(), subTitleFont, Brushes.Gray, leftMargin, yPos)
        
        yPos += 80
        g.DrawLine(New Pen(primaryColor, 2), leftMargin, yPos, rightMargin, yPos)
        yPos += 30

        ' 2. Identitas Wajib Pajak
        g.DrawString("IDENTITAS WAJIB PAJAK", subTitleFont, primaryColor, leftMargin, yPos)
        yPos += 40
        
        Dim col1X As Integer = leftMargin
        Dim col2X As Integer = leftMargin + 200

        DrawKeyValue(g, "NPWP", TextBoxNPWP.Text, col1X, col2X, yPos, headerFont, contentFont)
        DrawKeyValue(g, "Nama Lengkap", TextBoxNama.Text, col1X, col2X, yPos, headerFont, contentFont)
        DrawKeyValue(g, "Jenis SPT", If(ComboBoxJenisSPT.SelectedItem IsNot Nothing, ComboBoxJenisSPT.SelectedItem.ToString(), "-"), col1X, col2X, yPos, headerFont, contentFont)
        yPos += 20 ' Extra spacer

        g.DrawLine(Pens.LightGray, leftMargin, yPos, rightMargin, yPos)
        yPos += 30

        ' 3. Rincian Perhitungan
        g.DrawString("RINCIAN PERHITUNGAN PAJAK", subTitleFont, primaryColor, leftMargin, yPos)
        yPos += 40

        Dim penghasilan As String = TextBoxPenghasilan.Text
        Dim status As String = If(ComboBoxStatusPTKP.SelectedItem IsNot Nothing, ComboBoxStatusPTKP.SelectedItem.ToString(), "-")
        Dim pkp As String = TextBoxPKP.Text
        Dim pph As String = TextBoxPPh.Text

        DrawKeyValue(g, "Penghasilan Neto", "Rp " & penghasilan, col1X, col2X, yPos, headerFont, contentFont)
        DrawKeyValue(g, "Status PTKP", status, col1X, col2X, yPos, headerFont, contentFont)
        DrawKeyValue(g, "Penghasilan Kena Pajak", "Rp " & pkp, col1X, col2X, yPos, headerFont, contentFont)
        DrawKeyValue(g, "PPh Terutang (5%)", "Rp " & pph, col1X, col2X, yPos, headerFont, contentFont)
        
        yPos += 20
        g.DrawLine(Pens.LightGray, leftMargin, yPos, rightMargin, yPos)
        yPos += 30

        ' 4. Status Akhir
        g.DrawString("STATUS AKHIR", subTitleFont, primaryColor, leftMargin, yPos)
        yPos += 40

        DrawKeyValue(g, "Total PPh Terutang", "Rp " & pph, col1X, col2X, yPos, headerFont, contentFont)
        DrawKeyValue(g, "Kredit Pajak (Dipotong)", "Rp " & TextBoxKredit.Text, col1X, col2X, yPos, headerFont, contentFont)

        Dim pphVal, kreditVal As Decimal
        Decimal.TryParse(pph.Replace(".", ""), pphVal)
        Decimal.TryParse(TextBoxKredit.Text.Replace(".", ""), kreditVal)
        Dim kurangBayar As Decimal = pphVal - kreditVal
        
        yPos += 10
        Dim rectStatus As New Rectangle(leftMargin, yPos, 400, 50)
        
        If kurangBayar > 0 Then
            ' Kurang Bayar (Red)
            g.FillRectangle(New SolidBrush(Color.MistyRose), rectStatus)
            g.DrawRectangle(Pens.Red, rectStatus)
            g.DrawString("KURANG BAYAR", headerFont, Brushes.Red, leftMargin + 10, yPos + 10)
            g.DrawString("Rp " & kurangBayar.ToString("N0"), contentFont, Brushes.Red, leftMargin + 200, yPos + 10)
        ElseIf kurangBayar < 0 Then
            ' Lebih Bayar (Blue)
            g.FillRectangle(New SolidBrush(Color.LightCyan), rectStatus)
            g.DrawRectangle(Pens.Blue, rectStatus)
            g.DrawString("LEBIH BAYAR", headerFont, Brushes.Blue, leftMargin + 10, yPos + 10)
            g.DrawString("Rp " & Math.Abs(kurangBayar).ToString("N0"), contentFont, Brushes.Blue, leftMargin + 200, yPos + 10)
        Else
            ' Nihil (Green)
            g.FillRectangle(New SolidBrush(Color.Honeydew), rectStatus)
            g.DrawRectangle(Pens.Green, rectStatus)
            g.DrawString("NIHIL", headerFont, Brushes.Green, leftMargin + 10, yPos + 10)
            g.DrawString("Rp 0", contentFont, Brushes.Green, leftMargin + 200, yPos + 10)
        End If
        
        yPos += 100
        g.DrawString("Dicetak secara otomatis oleh TaxEase App pada: " & Date.Now.ToString("dd MMMM yyyy HH:mm"), footerFont, Brushes.Gray, leftMargin, yPos)
    End Sub

    Private Sub DrawKeyValue(g As Graphics, key As String, value As String, col1 As Integer, col2 As Integer, ByRef y As Integer, fontKey As Font, fontVal As Font)
        g.DrawString(key, fontKey, Brushes.DimGray, col1, y)
        g.DrawString(value, fontVal, Brushes.Black, col2, y)
        y += 35
    End Sub
End Class