Public Class CAlgoritmilinePooraja
    Implements ITeisendused


    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String
    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSymbol
        End Get
        Set(value As Integer)
            intAlgusSymbol = value
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol
        End Get
        Set(value As Integer)
            intLoppSymbol = value
        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTekst = value
        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst
        strPooratavTekst = StrReverse(strSisendTekst)
    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Dim RevString As String = ""
        For i As Integer = strPooratavTekst.Length - 1 To 0 Step -1
            RevString &= strPooratavTekst(i)
        Next
        Return RevString
    End Function
End Class