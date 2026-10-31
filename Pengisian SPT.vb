Imports System.Data.SqlClient

Public Class Pengisian_SPT
    ' Connection string - ensure Database1.mdf is in the output directory
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(TextBoxNPWP.Text) OrElse String.IsNullOrWhiteSpace(TextBoxNama.Text) Then
            MessageBox.Show("Mohon lengkapi NPWP dan Nama.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ComboBoxJenisSPT.SelectedIndex = -1 OrElse ComboBoxStatus.SelectedIndex = -1 Then
            MessageBox.Show("Mohon pilih Jenis SPT dan Status SPT.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO tbl_SPT (NPWP, TahunPajak, JenisSPT, StatusSPT, PenghasilanNeto, PPhTerutang, KreditPajak, TanggalLapor) VALUES (@NPWP, @TahunPajak, @JenisSPT, @StatusSPT, @PenghasilanNeto, @PPhTerutang, @KreditPajak, @TanggalLapor)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NPWP", TextBoxNPWP.Text)
                    cmd.Parameters.AddWithValue("@TahunPajak", NumericUpDownTahun.Value)
                    cmd.Parameters.AddWithValue("@JenisSPT", ComboBoxJenisSPT.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@StatusSPT", ComboBoxStatus.SelectedItem.ToString())

                    Dim penghasilan As Decimal = 0
                    Decimal.TryParse(TextBoxPenghasilan.Text, penghasilan)
                    cmd.Parameters.AddWithValue("@PenghasilanNeto", penghasilan)

                    Dim pph As Decimal = 0
                    Decimal.TryParse(TextBoxPPh.Text, pph)
                    cmd.Parameters.AddWithValue("@PPhTerutang", pph)

                    Dim kredit As Decimal = 0
                    Decimal.TryParse(TextBoxKredit.Text, kredit)
                    cmd.Parameters.AddWithValue("@KreditPajak", kredit)

                    cmd.Parameters.AddWithValue("@TanggalLapor", DateTimePickerLapor.Value)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data SPT berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                ' Tampilkan popup untuk navigasi
                Dim result As DialogResult = MessageBox.Show("Apakah Anda ingin melanjutkan ke Simulasi?", "Navigasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                
                If result = DialogResult.Yes Then
                    ' Pindah ke form Simulasi
                    Dim frmSimulasi As New Simulasi()
                    frmSimulasi.Show()
                    Me.Close()
                Else
                    ' Pindah ke form Dashboard
                    Dim frmDashboard As New Dashboard()
                    frmDashboard.Show()
                    Me.Close()
                End If

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
                                $"Penghasilan Neto: {TextBoxPenghasilan.Text}{vbCrLf}" &
                                $"PPh Terutang: {TextBoxPPh.Text}{vbCrLf}" &
                                $"Kredit Pajak: {TextBoxKredit.Text}{vbCrLf}" &
                                $"Tanggal Lapor: {DateTimePickerLapor.Value.ToShortDateString()}"

        MessageBox.Show(summary, "Preview SPT", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        ' Button Kembali - kembali ke Dashboard
        Dim frmDashboard As New Dashboard()
        frmDashboard.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Button Batal - reset/clear all fields
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin membatalkan dan mereset semua data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If result = DialogResult.Yes Then
            TextBoxNPWP.Clear()
            TextBoxNama.Clear()
            TextBoxPenghasilan.Clear()
            TextBoxPPh.Clear()
            TextBoxKredit.Clear()
            ComboBoxJenisSPT.SelectedIndex = -1
            ComboBoxStatus.SelectedIndex = -1
            NumericUpDownTahun.Value = 2024
            DateTimePickerLapor.Value = DateTime.Now
            TextBoxNPWP.Focus()
        End If
    End Sub
End Class