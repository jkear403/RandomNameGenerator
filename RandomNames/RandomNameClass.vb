Public Class RandomNameClass

    Dim mName As String


    Public Sub GenerateName()
        Dim random As New Random()
        Dim length As Integer
        Dim vowels() As String = {"", "a", "e", "i", "o", "u"}
        Dim consonants() As String = {"", "b", "c", "d", "f", "g", "s", "t", "p", "h", "j", "k", "l", "m", "n", "r"}
        Dim doubleCons() As String = {"", "l", "r", "h"}
        Dim nameArray(60) As String
        Dim ct1 As Integer = 2

        'Creates a random length for the name
        length = random.Next(5, 11)

        'Intializes the name
        mName = ""

        'sets the first letter to a random consonant
        nameArray(1) = consonants(random.Next(1, 15))


        'A for loop the keeps going for 100 times or until ct1 it greater then length
        'for added randomness there is a possiblity for ct1 to exceed the length but when printing out
        '   it will cut off some letters so there is a possiblity of it ending in a vowel or a consonant
        'Has a possibilty for a double consonant
        For ct3 As Integer = 1 To 100
            For ct2 As Integer = 1 To 8
                If nameArray(ct1 - 1) = consonants(ct2) Then
                    nameArray(ct1) = doubleCons(random.Next(0, 4))
                    If nameArray(ct1) <> "" Then
                        ct1 += 1
                        nameArray(ct1) = vowels(random.Next(1, 6))
                        ct1 += 1
                        nameArray(ct1) = consonants(random.Next(1, 16))
                        ct1 += 1
                    Else
                        nameArray(ct1) = vowels(random.Next(1, 6))
                        ct1 += 1
                        nameArray(ct1) = consonants(random.Next(1, 16))
                        ct1 += 1
                    End If
                    Exit For
                ElseIf ct2 < 8 Then
                    If nameArray(ct1 - 1) = consonants(ct2 + 8) Then
                        nameArray(ct1) = vowels(random.Next(1, 6))
                        ct1 += 1
                        nameArray(ct1) = consonants(random.Next(1, 16))
                        ct1 += 1
                        Exit For
                    End If

                End If
            Next

            'When ct1 is greater then the length it exits the for loop
            If ct1 > length Then
                Exit For
            End If
        Next


        nameArray(1) = nameArray(1).ToUpper()

        For ct As Integer = 1 To length
            mName &= nameArray(ct)
        Next
    End Sub

    Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

End Class
