Public Class Simulasi
    Private Sub Simulasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatePenghasilanLengkapState()
        ResetOutput()
    End Sub

    Private Sub ResetOutput()
        lblStatusResult.Text = ""
        lblStatusResult.BackColor = Color.Transparent
        lblStatusDetail.Text = ""
        lblPanduanBilling.Text = ""
    End Sub

    ' ==========================
    '   GATE LOGIC P1 → P2
    ' ==========================
    Private Sub rbQ1Yes_CheckedChanged(sender As Object, e As EventArgs) Handles rbQ1Yes.CheckedChanged, rbQ1No.CheckedChanged
        UpdatePenghasilanLengkapState()
    End Sub

    Private Sub UpdatePenghasilanLengkapState()
        If rbQ1Yes.Checked Then
            rbQ2Yes.Enabled = True
            rbQ2No.Enabled = True
        Else
            rbQ2Yes.Enabled = False
            rbQ2No.Enabled = False
            rbQ2Yes.Checked = False
            rbQ2No.Checked = False
        End If
    End Sub


    ' ==========================
    '   BUTTON SIMULASI
    ' ==========================
    Private Sub btnHitungSimulasi_Click(sender As Object, e As EventArgs) Handles btnHitungSimulasi.Click
        Dim hasil = EvaluasiRule()

        Select Case True
            Case hasil.StartsWith("NIHIL")
                SetResult("NIHIL", Color.Green)

            Case hasil.StartsWith("KURANG BAYAR")
                SetResult("KURANG BAYAR", Color.Red)

            Case hasil.StartsWith("LEBIH BAYAR")
                SetResult("LEBIH BAYAR", Color.Blue)

            Case hasil.StartsWith("ERROR")
                SetResult("ERROR", Color.Orange)
        End Select
    End Sub

    Private Sub SetResult(text As String, color As Color)
        lblStatusResult.Text = text
        lblStatusResult.BackColor = color
        lblStatusResult.ForeColor = Color.White
    End Sub


    ' ==========================
    '   RULE ENGINE PROLOG → VB
    ' ==========================
    Private Function EvaluasiRule() As String
        ResetOutput()

        Dim punya_bukti = rbQ1Yes.Checked
        Dim penghasilan_lengkap = rbQ2Yes.Checked
        Dim penghasilan_lain = rbQ3Yes.Checked
        Dim ptkp_sesuai = rbQ4Yes.Checked
        Dim ada_selisih = rbQ5Yes.Checked
        Dim lebih_bayar = rbQ6Yes.Checked
        Dim kurang_bayar = rbQ7Yes.Checked
        Dim sudah_bayar = rbQ8Yes.Checked

        ' ==========================
        ' RULE 1 – Tidak ada bukti potong
        ' ==========================
        If Not punya_bukti Then
            lblStatusDetail.Text = "Rule: Tidak punya bukti potong. SPT tidak dapat dihitung."
            Return "ERROR: Tidak punya bukti potong"
        End If

        ' ==========================
        ' RULE 2 – Penghasilan lain tapi tidak tercantum
        ' ==========================
        If penghasilan_lain And Not penghasilan_lengkap Then
            lblStatusDetail.Text = "Rule: Ada penghasilan lain tetapi tidak dicantumkan di bukti potong."
            Return "ERROR: Penghasilan lain tidak tercantum"
        End If

        ' ==========================
        ' RULE 3 – PTKP salah
        ' ==========================
        If Not ptkp_sesuai Then
            lblStatusDetail.Text = "Rule: PTKP salah input. Perhitungan pajak tidak valid."
            Return "ERROR: PTKP salah"
        End If

        ' ==========================
        ' RULE 4 – Tidak ada selisih
        ' ==========================
        If Not ada_selisih Then
            lblStatusDetail.Text = "Rule: Pajak sesuai. Tidak ada selisih pajak."
            Return "NIHIL: Tidak ada selisih"
        End If

        ' ==========================
        ' RULE 5 – Ada selisih tapi LB/KB tidak ditentukan
        ' ==========================
        If ada_selisih And Not lebih_bayar And Not kurang_bayar Then
            lblStatusDetail.Text = "Rule: Ada selisih pajak, tetapi tidak menentukan LB/KB."
            Return "ERROR: Tidak menentukan LB/KB"
        End If

        ' ==========================
        ' RULE 6 – LB dan KB sekaligus
        ' ==========================
        If lebih_bayar And kurang_bayar Then
            lblStatusDetail.Text = "Rule: Input LB dan KB bersamaan (mustahil matematis)."
            Return "ERROR: LB dan KB bersamaan"
        End If

        ' ==========================
        ' RULE 7 – Lebih Bayar
        ' ==========================
        If lebih_bayar And Not kurang_bayar Then
            lblStatusDetail.Text = "Rule: Lebih Bayar (pajak dipotong lebih besar)."
            Return "LEBIH BAYAR: Pajak dipotong terlalu besar"
        End If

        ' ==========================
        ' RULE 8 – Kurang Bayar & belum dibayar
        ' ==========================
        If kurang_bayar And Not sudah_bayar Then
            lblStatusDetail.Text = "Rule: Kurang Bayar & belum dilunasi."
            lblPanduanBilling.Text =
                "Panduan Billing:" & vbCrLf &
                "- Pilih Kode Pajak 411125" & vbCrLf &
                "- Pilih PPh Pasal 29" & vbCrLf &
                "- Generate Kode Billing" & vbCrLf &
                "- Bayar via bank/ATM"

            Return "KURANG BAYAR: Belum bayar"
        End If

        ' ==========================
        ' RULE 9 – KB sudah dilunasi → Nihil
        ' ==========================
        If kurang_bayar And sudah_bayar Then
            lblStatusDetail.Text = "Rule: Kurang Bayar tetapi sudah dilunasi."
            Return "NIHIL: KB sudah lunas"
        End If

        ' ==========================
        ' RULE 10 – Lebih Bayar tetapi data tidak lengkap
        ' ==========================
        If lebih_bayar And Not penghasilan_lengkap Then
            lblStatusDetail.Text = "Rule: Mengaku LB tetapi data di bukti potong tidak lengkap."
            Return "ERROR: LB tidak valid"
        End If

        ' ==========================
        ' RULE 11 – KB karena penghasilan lain (belum dibayar)
        ' ==========================
        If penghasilan_lain And kurang_bayar And Not sudah_bayar Then
            lblStatusDetail.Text = "Rule: Penghasilan tambahan menyebabkan Kurang Bayar."
            lblPanduanBilling.Text =
                "Panduan Billing:" & vbCrLf &
                "- Kode Pajak: 411125" & vbCrLf &
                "- Generate billing" & vbCrLf &
                "- Bayar via bank"

            Return "KURANG BAYAR: KB karena penghasilan lain"
        End If

        ' ==========================
        ' RULE 12 – KB karena penghasilan lain tapi sudah dibayar → Nihil
        ' ==========================
        If penghasilan_lain And kurang_bayar And sudah_bayar Then
            lblStatusDetail.Text = "Rule: KB dari penghasilan lain tetapi sudah dilunasi."
            Return "NIHIL: KB sudah dilunasi (penghasilan lain)"
        End If

        lblStatusDetail.Text = "Tidak ada rule cocok."
        Return "ERROR: Rule tidak ditemukan"

    End Function
End Class