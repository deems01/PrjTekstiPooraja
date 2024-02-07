Public Class CAlgoritmilinePooraja
    Implements ITeisendused

    Private Function ReverseString(ByVal input As String) As String
        Dim reversedString As String = ""

        ' Loop through the characters of the input string in reverse order
        For i As Integer = input.Length - 1 To 0 Step -1
            ' Append each character to the reversedString
            reversedString &= input(i)
        Next

        ' Return the reversed string
        Return reversedString
    End Function
    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst
        Throw New NotImplementedException()
    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Throw New NotImplementedException()
    End Function
End Class
