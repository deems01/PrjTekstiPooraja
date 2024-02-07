Public Class formKasutajaAken
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPoora1_Click(sender As Object, e As EventArgs) Handles btnPoora1.Click
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja
        pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.pooraTekst()
    End Sub
End Class
