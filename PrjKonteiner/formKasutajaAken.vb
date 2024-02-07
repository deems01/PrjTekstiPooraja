Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formKasutajaAken
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged
        lblLength.Text = txtSisendTekst.Text.Length.ToString()

        Dim vowelCount As Integer = CountVowels(txtSisendTekst.Text)

        lblVowels.Text = "Taishaalikud: " & vowelCount.ToString()
    End Sub

    Private Function CountVowels(text As String) As Integer
        Dim cnt As Integer = 0
        For Each taht As Char In text
            If "AEIOUaeiou".Contains(taht) Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    Private Sub btnPoora1_Click(sender As Object, e As EventArgs) Handles btnPoora1.Click
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja 'CTekstiPooraja
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

    Private Sub lblLength_Click(sender As Object, e As EventArgs) Handles lblLength.Click

    End Sub

    Private Sub btnTekst_Click(sender As Object, e As EventArgs) Handles btnTekst.Click

    End Sub
End Class
