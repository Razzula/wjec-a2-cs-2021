Public Class AddUser

    Dim usersFileHandler As FileHandling
    Dim userData As New GlobalVariables.user 'data of current customer
    Dim userList As New List(Of GlobalVariables.user) 'stores existing records fetched from file

    Dim validator = New Validation
    Dim toValidate 'list of fields to validate, and validation parameters (set AFTER load)

    Dim encryptor = New Encryption

    Dim vbRed As Color, vbDefault As Color

    Dim parentalForm As ManageFiles
    Dim inEditMode As Boolean = False, currentItem As Integer
    Dim userRawList

    'WHEN FORM LOADED
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usersFileHandler = New FileHandling("users.txt", "USERNAME    PASSWORD    ACCESSLVL")

        userRawList = usersFileHandler.GetFileContents()
        For x = 0 To userRawList.Length - 1
            userData.Username = Trim(Mid(userRawList(x), 1, 12))

            userList.Add(userData)
        Next

        'MISC.
        vbRed = errorLabel.ForeColor 'colour of error messages
        vbDefault = usernameLabel.ForeColor

        toValidate = {{usernameBox, passwordBox, passwordBox2, accessLevelBox}, {12, 12, 12, 5}} 'field, maxLength

    End Sub

    'WHEN 'ADD' BUTTON CLICKED, or ENTER KEY PRESSED
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        'VALIDATION
        Dim valid As Boolean
        valid = ValidateData()

        If valid Then
            If inEditMode Then
                'CLEAR FILE
                usersFileHandler.ClearFile()

                'WRITE DATA
                For x = 1 To userList.Count - 1
                    If x <> currentItem Then
                        usersFileHandler.WriteLineToFile(userRawList(x))
                    Else
                        usersFileHandler.WriteLineToFile(userData.Username & userData.Password & userData.AccessLevel)
                    End If
                Next
            Else
                'WRITE DATA
                usersFileHandler.WriteLineToFile(userData.Username & userData.Password & userData.AccessLevel)
            End If


            'if success
            MsgBox("User '" & usernameBox.Text & "' saved")

            'reset fields
            usernameBox.Text = ""
            passwordBox.Text = ""
            passwordBox2.Text = ""
            accessLevelBox.Text = ""

            If useParent Then
                parentalForm.Close()
                ManageFiles.Show()
                Me.Close()
            End If

        End If

    End Sub

    Private Sub addButton_MouseHover(sender As Object, e As EventArgs) Handles addButton.MouseHover 'when mouse hovers over button

        ValidateData()

    End Sub

    'VALIDATES DATA FROM toValidate ARRAY'S FIELDS AND PARAMETERS, USING Validation.vb CLASS
    Function ValidateData()

        Dim allIsValid = True

        'INPUT DATA FROM FIELDS
        userData.Username = LSet(encryptor.Encrypt(usernameBox.Text), 12)
        userData.Password = LSet(encryptor.Encrypt(passwordBox.Text), 12)
        userData.AccessLevel = accessLevelBox.Text

        Dim errorMessage = "Invalid Data"

        'VALIDATE REQUIRED FIELDS
        For x = 0 To (toValidate.Length / 2) - 1 'for each field
            Dim field = toValidate(0, x), dataIsValid = True

            'presence check
            dataIsValid = validator.PresenceCheck(field.Text) And dataIsValid

            'length check
            dataIsValid = validator.LengthCheck(field.Text, toValidate(1, x)) And dataIsValid

            If dataIsValid Then
                GetNextControl(field, False).ForeColor = vbDefault
            Else
                GetNextControl(field, False).ForeColor = vbRed 'highlight corresponding label
            End If

            allIsValid = dataIsValid And allIsValid
        Next

        'double-check verification
        If validator.Verifiy(passwordBox.Text, passwordBox2.Text) = False Then

            passwordLabel.ForeColor = vbRed
            passwordlabel2.ForeColor = vbRed
            errorMessage = "Passwords must match."
            allIsValid = False

        End If

        'check if username is unique
        If inEditMode = False Then 'do not perform this action in edit mode, as when editing items the IDs SHOULD match
            For x = 0 To userList.Count() - 1 'search list of users
                Dim currentUsername = Trim(userData.Username)
                If userList(x).Username = currentUsername Then 'compare IDs, if usernames match
                    'error message
                    usernameLabel.ForeColor = vbRed
                    errorMessage = "Username is taken."
                    allIsValid = False 'invalid data

                End If
            Next
        End If

        If allIsValid Then
            addButton.Cursor = Cursors.Default
            errorLabel.Text = ""
        Else
            addButton.Cursor = Cursors.No 'feedback to user
            errorLabel.Text = errorMessage
        End If

        Return allIsValid

    End Function

    Dim useParent As Boolean = False
    Sub SetParent(parent As Form)

        parentalForm = parent
        useParent = True

    End Sub

    Sub EnableEditMode(ID As String)

        inEditMode = True

        'search list for ID
        For x = 0 To userList.Count - 1
            If userList(x).Username = ID Then
                currentItem = x 'store location globally
            End If
        Next

        Dim encryptor As New Encryption
        usernameBox.Text = encryptor.Decrypt(ID)

        addButton.Text = "Update"

    End Sub

End Class