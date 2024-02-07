Public Class formKasutajaAken
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPoora1_Click(sender As Object, e As EventArgs) Handles btnPoora1.Click
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja
        pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.pooraTekst()
    End Sub

    Private Sub btn2Poora_Click(sender As Object, e As EventArgs) Handles btn2Poora.Click
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja
        pooraja.teisendaTekst(txtSisendTekst.Text)
        txtValjundTekst2.Text = pooraja.strTekst
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        TimerUuenda.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click
        TimerUuenda.Enabled = False
        btnStart.Enabled = True
    End Sub

    Private Sub TimerUuenda_Tick(sender As Object, e As EventArgs) Handles TimerUuenda.Tick
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja
        pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.pooraTekst
    End Sub
End Class
