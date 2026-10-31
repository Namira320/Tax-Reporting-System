Imports System.Data.SqlClient

Public Class Riwayat_Pelaporan
    ' Removed local currentNIK, using Module1.CurrentUserNIK

    Private Sub Riwayat_Pelaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDataGridView()
        LoadRiwayatPelaporan()
    End Sub

    Private Sub InitializeDataGridView()
        ' Setup DataGridView untuk riwayat SPT
        DataGridViewRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewRiwayat.AllowUserToAddRows = False
        DataGridViewRiwayat.AllowUserToDeleteRows = False
        DataGridViewRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewRiwayat.MultiSelect = False
        DataGridViewRiwayat.ReadOnly = True
        DataGridViewRiwayat.RowHeadersVisible = False
        DataGridViewRiwayat.DefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
        DataGridViewRiwayat.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        DataGridViewRiwayat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252)
        DataGridViewRiwayat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252)

        ' Add Columns if they don't exist (Designer might not have them)
        DataGridViewRiwayat.Columns.Clear()
        DataGridViewRiwayat.Columns.Add("ColID", "ID")
        DataGridViewRiwayat.Columns("ColID").Visible = False
        DataGridViewRiwayat.Columns.Add("ColTahun", "Tahun")
        DataGridViewRiwayat.Columns.Add("ColMasa", "Masa Pajak")
        DataGridViewRiwayat.Columns.Add("ColPembetulan", "Pembetulan")
        DataGridViewRiwayat.Columns.Add("ColStatus", "Status")
        DataGridViewRiwayat.Columns.Add("ColTanggal", "Tanggal Lapor")
        DataGridViewRiwayat.Columns.Add("ColPenghasilan", "Penghasilan Netto")
        DataGridViewRiwayat.Columns.Add("ColPPh", "PPh Kurang/Lebih")
    End Sub

    Private Sub LoadRiwayatPelaporan()
        If String.IsNullOrEmpty(Module1.CurrentUserNIK) Then Exit Sub

        Using conn As SqlConnection = GetConnection()
            Try
                If OpenConnection(conn) Then
                    Dim query = "SELECT ID, TahunPajak, MasaPajak, StatusPembetulan, StatusBayar, " &
                               "TanggalInput, PenghasilanNetto, PPhKurangLebih " &
                               "FROM tbl_SPT WHERE NIK = @NIK ORDER BY TanggalInput DESC"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)

                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            DataGridViewRiwayat.Rows.Clear()
                            While reader.Read()
                                Dim rowIndex = DataGridViewRiwayat.Rows.Add()
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColID").Value = reader("ID")
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColTahun").Value = reader("TahunPajak")
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColMasa").Value = GetNamaBulan(Convert.ToInt32(reader("MasaPajak")))
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColPembetulan").Value = "Ke-" & reader("StatusPembetulan").ToString()
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColStatus").Value = reader("StatusBayar").ToString()
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColTanggal").Value = Convert.ToDateTime(reader("TanggalInput")).ToString("dd MMM yyyy")
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColPenghasilan").Value = Module1.FormatAngka(Convert.ToDecimal(reader("PenghasilanNetto")))
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColPPh").Value = Module1.FormatAngka(Convert.ToDecimal(reader("PPhKurangLebih")))
                            End While
                        End Using
                    End Using

                    ' Update label jumlah SPT
                    LabelSummaryValue.Text = $"{DataGridViewRiwayat.Rows.Count} SPT"
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading riwayat: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function GetNamaBulan(masa As Integer) As String
        Dim namaBulan = {"Januari", "Februari", "Maret", "April", "Mei", "Juni",
                        "Juli", "Agustus", "September", "Oktober", "November", "Desember"}
        If masa >= 1 AndAlso masa <= 12 Then
            Return namaBulan(masa - 1)
        Else
            Return "Tahunan"
        End If
    End Function

    Private Sub ButtonCari_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
        FilterRiwayat()
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ComboBoxTahun.SelectedIndex = -1
        ComboBoxStatus.SelectedIndex = -1
        TextBoxNPWP.Clear()
        LoadRiwayatPelaporan()
    End Sub

    Private Sub FilterRiwayat()
        If String.IsNullOrEmpty(Module1.CurrentUserNIK) Then Exit Sub

        Using conn As SqlConnection = GetConnection()
            Try
                If OpenConnection(conn) Then
                    Dim query = "SELECT ID, TahunPajak, MasaPajak, StatusPembetulan, StatusBayar, " &
                               "TanggalInput, PenghasilanNetto, PPhKurangLebih " &
                               "FROM tbl_SPT WHERE NIK = @NIK"

                    ' Add filters
                    Dim filters As New List(Of String)
                    If ComboBoxTahun.SelectedIndex >= 0 Then
                        filters.Add("TahunPajak = @Tahun")
                    End If
                    If ComboBoxStatus.SelectedIndex > 0 Then ' Index 0 is "Semua status"
                        filters.Add("StatusBayar = @Status")
                    End If

                    If filters.Count > 0 Then
                        query &= " AND " & String.Join(" AND ", filters)
                    End If

                    query &= " ORDER BY TanggalInput DESC"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@NIK", Module1.CurrentUserNIK)

                        If ComboBoxTahun.SelectedIndex >= 0 Then
                            cmd.Parameters.AddWithValue("@Tahun", ComboBoxTahun.SelectedItem)
                        End If
                        If ComboBoxStatus.SelectedIndex > 0 Then
                            cmd.Parameters.AddWithValue("@Status", ComboBoxStatus.SelectedItem)
                        End If

                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            DataGridViewRiwayat.Rows.Clear()
                            While reader.Read()
                                Dim rowIndex = DataGridViewRiwayat.Rows.Add()
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColID").Value = reader("ID")
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColTahun").Value = reader("TahunPajak")
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColMasa").Value = GetNamaBulan(Convert.ToInt32(reader("MasaPajak")))
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColPembetulan").Value = "Ke-" & reader("StatusPembetulan").ToString()
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColStatus").Value = reader("StatusBayar").ToString()
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColTanggal").Value = Convert.ToDateTime(reader("TanggalInput")).ToString("dd MMM yyyy")
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColPenghasilan").Value = Module1.FormatAngka(Convert.ToDecimal(reader("PenghasilanNetto")))
                                DataGridViewRiwayat.Rows(rowIndex).Cells("ColPPh").Value = Module1.FormatAngka(Convert.ToDecimal(reader("PPhKurangLebih")))
                            End While
                        End Using
                    End Using
                    LabelSummaryValue.Text = $"{DataGridViewRiwayat.Rows.Count} SPT"
                End If
            Catch ex As Exception
                MessageBox.Show("Error filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ButtonDetail_Click(sender As Object, e As EventArgs) Handles ButtonDetail.Click
        If DataGridViewRiwayat.SelectedRows.Count > 0 Then
            MessageBox.Show("Fitur Detail belum tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Pilih data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Dim frm As New Dashboard()
        frm.Show()
        Close()
    End Sub
End Class