Imports System.CodeDom.Compiler
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports PrjTekstiPooraja

Public Class formKasutajaAken

    Dim temp As Integer = 0
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
        If temp = 1 Then
            pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja
            pooraja.strTekst = txtSisendTekst.Text
            txtValjundTekst1.Text = pooraja.pooraTekst()
        End If
        If temp = 0 Then
            pooraja = New PrjTekstiPooraja.CTekstiPooraja
            pooraja.strTekst = txtSisendTekst.Text
            txtValjundTekst1.Text = pooraja.pooraTekst()
        End If

    End Sub

    Private Sub btn2Poora_Click(sender As Object, e As EventArgs) Handles btn2Poora.Click
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        If temp = 1 Then
            pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja
            pooraja.teisendaTekst(txtSisendTekst.Text)
            txtValjundTekst2.Text = pooraja.strTekst
        End If
        If temp = 0 Then
            pooraja = New PrjTekstiPooraja.CTekstiPooraja
            pooraja.teisendaTekst(txtSisendTekst.Text)
            txtValjundTekst2.Text = pooraja.strTekst
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        TimerUuenda.Enabled = True
        btnStart.Enabled = False
        btnStopp.Enabled = True
    End Sub

    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click
        TimerUuenda.Enabled = False
        btnStart.Enabled = True
        btnStopp.Enabled = False
    End Sub

    Private Sub TimerUuenda_Tick(sender As Object, e As EventArgs) Handles TimerUuenda.Tick
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja
        pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.pooraTekst
        txtValjundTekst2.Text = pooraja.pooraTekst
    End Sub

    Private Sub lblLength_Click(sender As Object, e As EventArgs) Handles lblLength.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Algoritmiline.CheckedChanged
        If Algoritmiline.CheckState Then
            temp = 1
        Else
            temp = 0
        End If
    End Sub
End Class
