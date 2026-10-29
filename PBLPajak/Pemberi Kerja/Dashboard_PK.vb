Imports System.Windows.Forms
Imports System.Drawing

Public Class Dashboard_PK

    Private Sub Dashboard_PK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi data
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        ' Setup DataGridView
        DataGridViewKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewKaryawan.AllowUserToAddRows = False
        DataGridViewKaryawan.AllowUserToDeleteRows = False
        DataGridViewKaryawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewKaryawan.MultiSelect = False
        DataGridViewKaryawan.ReadOnly = True
        DataGridViewKaryawan.RowHeadersVisible = False
        DataGridViewKaryawan.DefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
        DataGridViewKaryawan.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        DataGridViewKaryawan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252)
        DataGridViewKaryawan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252)

        ' Load data karyawan (contoh)
        DataGridViewKaryawan.Rows.Clear()
        DataGridViewKaryawan.Rows.Add("Budi Santoso", "01.234.567.8-901.000", "Rp 10.000.000", "Aktif")
        DataGridViewKaryawan.Rows.Add("Siti Nurhaliza", "01.234.567.8-902.000", "Rp 12.000.000", "Aktif")
        DataGridViewKaryawan.Rows.Add("Ahmad Dahlan", "01.234.567.8-903.000", "Rp 8.000.000", "Aktif")

        ' Update card values
        LabelTotalKaryawanValue.Text = "150"
        LabelTotalGajiValue.Text = "Rp 1.5 M"
        LabelTotalPajakValue.Text = "Rp 150 Jt"
    End Sub

    ' Menu Events
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit
    End Sub

    Private Sub ImporDataCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporDataCSVToolStripMenuItem.Click
        MessageBox.Show("Fitur Impor Data CSV akan segera hadir!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CetakBuktiPotongToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakBuktiPotongToolStripMenuItem.Click
        MessageBox.Show("Fitur Cetak Bukti Potong (1721-A1) akan segera hadir!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
