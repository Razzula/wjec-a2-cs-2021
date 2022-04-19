Public Class Encryption

    Dim key As Integer = 117

    'encrypts the parmater data using a Caesear Cypher method
    Function Encrypt(data As String)

        'split data into an array of numbers
        Dim encryptedData As String = ""
        For x = 0 To data.Count - 1
            Dim charValue = Asc(Trim(Mid(data, x + 1, 1)))

            'shift characters
            If charValue + key <= 255 Then

                charValue += key

            Else

                charValue = key - (255 - charValue)

            End If

            encryptedData += Chr(charValue) 'reconvert to character and place back into string
        Next

        Return encryptedData

    End Function

    'decrypts the parmater data using a Caesear Cypher method
    Function Decrypt(data As String)

        'split data into an array of numbers
        Dim encryptedData As String = ""
        For x = 0 To data.Count - 1
            Dim charValue = Asc(Trim(Mid(data, x + 1, 1)))

            'shift characters
            If charValue - key >= 1 Then

                charValue -= key

            Else

                charValue = 255 + (charValue - key)

            End If

            encryptedData += Chr(charValue) 'reconvert to character and place back into string
        Next

        Return encryptedData

    End Function

End Class
