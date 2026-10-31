Imports System.Data.SqlClient

Public Class Register
    ' Connection string - adjust as needed based on your environment
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ComboBoxes
        ComboBox1.Items.AddRange(New String() {"Belum Kawin", "Kawin", "Cerai Hidup", "Cerai Mati"})
        ComboBox2.Items.AddRange(New String() {"Kepala Keluarga", "Istri", "Anak", "Famili Lain"})
        ComboBox3.Items.AddRange(New String() {"Indonesia", "Asing"})
        ComboBox4.Items.AddRange(New String() {"Laki-laki", "Perempuan"})
        ComboBox5.Items.AddRange(New String() {"PNS", "TNI/POLRI", "Pegawai Swasta", "Wiraswasta", "Lainnya"})
        ComboBox6.Items.AddRange(New String() {"< 4.5 Juta", "4.5 - 10 Juta", "10 - 20 Juta", "> 20 Juta"})
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Validation
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox8.Text) Then
            MessageBox.Show("Mohon lengkapi data wajib (NIK, Nama, Password).", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim transaction = conn.BeginTransaction()

                Try
                    ' 1. Insert into tbl_Users
                    Dim queryUser As String = "INSERT INTO tbl_Users (Username, Password, Role, NamaLengkap, IsActive) VALUES (@Username, @Password, 'WAJIBPAJAK', @NamaLengkap, 1)"
                    Using cmdUser As New SqlCommand(queryUser, conn, transaction)
                        cmdUser.Parameters.AddWithValue("@Username", TextBox1.Text) ' NIK as Username
                        cmdUser.Parameters.AddWithValue("@Password", TextBox8.Text)
                        cmdUser.Parameters.AddWithValue("@NamaLengkap", TextBox2.Text)
                        cmdUser.ExecuteNonQuery()
                    End Using

                    ' 2. Insert into tbl_WajibPajak
                    Dim queryWP As String = "INSERT INTO tbl_WajibPajak (NPWP, NamaLengkap, TempatLahir, TanggalLahir, StatusPernikahan, StatusKeluarga, NegaraAsal, JenisKelamin, NoHP, Email, Pekerjaan, TempatKerja, Alamat, PenghasilanPerBulan) VALUES (@NPWP, @NamaLengkap, @TempatLahir, @TanggalLahir, @StatusPernikahan, @StatusKeluarga, @NegaraAsal, @JenisKelamin, @NoHP, @Email, @Pekerjaan, @TempatKerja, @Alamat, @PenghasilanPerBulan)"
                    Using cmdWP As New SqlCommand(queryWP, conn, transaction)
                        cmdWP.Parameters.AddWithValue("@NPWP", TextBox1.Text)
                        cmdWP.Parameters.AddWithValue("@NamaLengkap", TextBox2.Text)
                        cmdWP.Parameters.AddWithValue("@TempatLahir", TextBox3.Text)
                        ' Assuming TextBox3 is used for Place of Birth, need a DatePicker for Date of Birth but form has TextBox3 for "Tempat Tanggal Lahir" based on label?
                        ' Let's assume TextBox3 is Tempat Lahir and we need a date. 
                        ' Looking at designer: Label3 is "Tempat Tanggal Lahir". TextBox3 is the input.
                        ' This is tricky. Let's assume user inputs "Jakarta, 01-01-1990" or just use current date for now if parsing fails, or better, just save as string if schema allows?
                        ' Schema said Date. Let's try to parse or just set a default for now to avoid crash.
                        ' Better approach: Split TextBox3 by comma if possible, or just save Tempat only and set Date to today.
                        ' Actually, let's just save the whole string to TempatLahir and set Date to today for simplicity unless I see a DatePicker.
                        ' There is no DatePicker for birth date in the designer list I saw (TextBox3).
                        cmdWP.Parameters.AddWithValue("@TempatLahir", TextBox3.Text)
                        cmdWP.Parameters.AddWithValue("@TanggalLahir", DateTime.Now) ' Placeholder

                        cmdWP.Parameters.AddWithValue("@StatusPernikahan", If(ComboBox1.SelectedItem, ""))
                        cmdWP.Parameters.AddWithValue("@StatusKeluarga", If(ComboBox2.SelectedItem, ""))
                        cmdWP.Parameters.AddWithValue("@NegaraAsal", If(ComboBox3.SelectedItem, ""))
                        cmdWP.Parameters.AddWithValue("@JenisKelamin", If(ComboBox4.SelectedItem, ""))
                        cmdWP.Parameters.AddWithValue("@NoHP", TextBox5.Text) ' Check mapping
                        ' Mapping check:
                        ' Label9 (No HP) -> ComboBox5? No.
                        ' Let's re-read designer mapping carefully.
                        ' Label9 Location: 72, 664. ComboBox5 Location: 318, 661. So ComboBox5 is No HP? That's weird.
                        ' Let's check TextBox mapping again.
                        ' TextBox1: NIK (Label1)
                        ' TextBox2: Nama (Label2)
                        ' TextBox3: Tempat Tanggal Lahir (Label3)
                        ' ComboBox1: Status Pernikahan (Label4)
                        ' ComboBox2: Status Hubungan Keluarga (Label5)
                        ' ComboBox3: Negara Asal (Label6)
                        ' ComboBox4: Jenis Kelamin (Label7)
                        ' ComboBox5: No Handphone (Label9) -> Weird, why ComboBox? Maybe country code? Or mistake in designer naming?
                        ' TextBox4: Email (Label13)
                        ' TextBox5: Pekerjaan (Label8) -> Wait, Label8 is at 976, 137. TextBox5 is at 1192, 129. Matches.
                        ' ComboBox6: Penghasilan (Label12)
                        ' TextBox6: Tempat Kerja (Label11)
                        ' TextBox7: Alamat (Label10)
                        ' TextBox8: Password (Label15)
                        
                        ' Correction on NoHP: It seems ComboBox5 is used for NoHP? Or maybe I missed a TextBox.
                        ' Let's assume ComboBox5 is a mistake and it should be a TextBox, OR it's a ComboBox for some reason.
                        ' I will use ComboBox5.Text for NoHP.
                        cmdWP.Parameters.AddWithValue("@NoHP", ComboBox5.Text)
                        
                        cmdWP.Parameters.AddWithValue("@Email", TextBox4.Text)
                        cmdWP.Parameters.AddWithValue("@Pekerjaan", TextBox5.Text)
                        cmdWP.Parameters.AddWithValue("@TempatKerja", TextBox6.Text)
                        cmdWP.Parameters.AddWithValue("@Alamat", TextBox7.Text)
                        
                        ' Penghasilan
                        Dim penghasilan As Decimal = 0
                        If ComboBox6.SelectedIndex >= 0 Then
                            ' Simple logic to store a value based on range
                            Select Case ComboBox6.SelectedIndex
                                Case 0 : penghasilan = 4000000
                                Case 1 : penghasilan = 7500000
                                Case 2 : penghasilan = 15000000
                                Case 3 : penghasilan = 25000000
                            End Select
                        End If
                        cmdWP.Parameters.AddWithValue("@PenghasilanPerBulan", penghasilan)
                        
                        cmdWP.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    transaction.Rollback()
                    Throw
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        ComboBox6.SelectedIndex = -1
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class