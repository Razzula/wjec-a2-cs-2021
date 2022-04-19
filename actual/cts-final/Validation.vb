Public Class Validation
    Function PresenceCheck(variable) 'does variable exist?

        If variable.Trim() = String.Empty Then 'variable is blank
            Return False 'invalid
        Else
            Return True 'valid
        End If

    End Function

    Function datatypecheck(variable As String)

        Try 'attempt to convert variable to integer
            Dim variableInt As Integer = variable
        Catch ex As Exception 'if cannot perfrom this, due to it not being a number:

            Return False 'data is invalid

        End Try

        Return True 'otherwise, valid

    End Function

    Function LengthCheck(variable As String, maxLength As Integer) 'is variable small enough to fit into file?

        If variable.Length <= maxLength Then 'if variable shorter than / same length as limit
            Return True 'valid
        Else
            Return False 'invalid
        End If

    End Function

    Function ExactLengthCheck(variable As String, length As Integer) 'is variable a specific size?

        If variable.Length = length Then
            Return True
        Else
            Return False
        End If

    End Function

    Function RangeCheck(variable, minBound, maxBound) 'is variable within bounds?

        Dim value
        value = Convert.ToDouble(variable) 'convert value to number

        If value < minBound Or value > maxBound Then 'is value outside of accepted bounds?
            Return False 'invalid data
        Else
            Return True 'valid data
        End If

    End Function

    Function PhoneNumberFormatCheck(variable As String)

        Try 'check data is numerical
            'this is done by dividing the variable by itself, which should result in 1, however for non-numerical values will trigger an error
            'a normal data type check cannot be used as if the phone number begins with a 0, e.g. (07934...) it cannot be stores as an integer
            'and so will trigger as invalid, even though it should be valid
            Dim check As Integer = variable / variable

            Return ExactLengthCheck(variable, 11) 'valid if data also correct length, invalid if not

        Catch ex As Exception
            Return False 'invalid
        End Try

    End Function

    Function PostcodeFormat(variable As String)

        If ExactLengthCheck(variable, 7) Then 'check data is 7 characters
            For x = 0 To 1 '1st and 2nd characters
                If RangeCheck(Asc(variable(x)), 65, 90) Then 'between A and Z? (not a - Z !!!)
                Else
                    Return False 'invalid data
                End If
            Next

            If datatypecheck(LSet(Mid(variable, 3), 3)) Then 'check that the '000' section of AA000AAA is indeed numerical
            Else
                Return False 'invalid data
            End If

            For x = 5 To 6 'check 6th and 7th characters
                If RangeCheck(Asc(variable(x)), 65, 90) Then
                Else
                    Return False 'invalid data
                End If
            Next
        Else
            Return False 'invalid data
        End If

        Return True 'valid data

    End Function

    Function Verifiy(data, compareTo) 'are parameters the same?

        If data = compareTo Then 'are parameters same
            Return True 'valid data
        Else
            Return False 'invalid data
        End If

    End Function

End Class
