Public Class Gate

    Dim UserList As New List(Of GlobalVariables.user)
    Dim encryptor As New Encryption

    Private Sub Gate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fileHandler = New FileHandling("users.txt", "USERNAME    PASSWORD    ACCESSLVL")

        Dim UserData() As String = fileHandler.GetFileContents()
        If UserData.Length = 1 Then
            fileHandler.WriteLineToFile("ÖÙâÞã       çääé        Admin") 'adds a default user login, to ensure the system can be accessed
            UserData(0) = "ÖÙâÞã       çääé        Admin" 'TEMP
        End If

        For x = 0 To UserData.Count - 1
            Dim temprecord As GlobalVariables.user
            temprecord.Username = Trim(Mid(UserData(x), 1, 12))
            temprecord.Password = Trim(Mid(UserData(x), 13, 12))
            temprecord.AccessLevel = Trim(Mid(UserData(x), 25, 5))
            UserList.Add(temprecord) 'add the record to the list
        Next

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click

        Dim attemptedID As String = encryptor.Encrypt(usernameBox.Text)
        Dim attemptedPass As String = encryptor.Encrypt(passwordBox.Text) 'encrypt contents of password box
        Dim accessLevel

        Dim validID As Boolean = False, counter As Integer, listLength = UserList.Count
        While counter < listLength

            If UserList(counter).Username = attemptedID Then 'search for user
                If UserList(counter).Password = attemptedPass Then 'check pass of user
                    validID = True
                    accessLevel = UserList(counter).AccessLevel
                End If
            End If

            counter += 1
        End While

        If validID Then

            Dim mainForm = New Main
            mainForm.Show()
            My.Application.DoEvents()
            mainForm.SetAccessLevel(accessLevel, usernameBox.Text)
            Me.Close()

        Else

            errorLabel.Text = "Incorrect credentials. Please try again." 'error message

        End If

    End Sub

    Private Sub passwordBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passwordBox.KeyPress, usernameBox.KeyPress

        If e.KeyChar = vbCr Then 'if enter key pressed
            LoginButton_Click(sender, e)
        End If

    End Sub

End Class