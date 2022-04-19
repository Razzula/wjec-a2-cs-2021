Public Class AddCustomer

    Dim customersFileHandler As FileHandling
    Dim CustomerData As New GlobalVariables.customer 'data of current customer
    Dim CustomerList As New List(Of GlobalVariables.customer) 'stores existing records fetched from file

    Dim toValidate 'list of fields to validate, and validation parameters (set AFTER load)

    Dim vbRed As Color, vbDefault As Color

    Dim parentalForm As ManageFiles

    'WHEN FORM LOADED
    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        customersFileHandler = New FileHandling("customers.txt", "ID NAME                     PONUMBER   ADDRESS                  AREA        POSTCODE")

        'SETUP
        IDBox.Text = customersFileHandler.GenerateID()

        'MISC.
        vbRed = errorLabel.ForeColor 'colour of error messages
        vbDefault = IDLabel.ForeColor

        toValidate = {{IDBox, nameBox, numberBox, addressBox, areaBox, postcodeBox}, {3, 25, 11, 25, 12, 7}} 'field, maxLength

    End Sub

    'WHEN 'ADD' BUTTON CLICKED, or ENTER KEY PRESSED
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        'VALIDATION
        Dim valid As Boolean
        valid = ValidateData()

        If valid Then
            If inEditMode Then
                'CLEAR FILE
                Dim customersRawList() As String = customersFileHandler.GetFileContents()
                customersFileHandler.ClearFile()

                'WRITE DATA
                For x = 1 To customersRawList.Length - 1
                    If LSet(IDBox.Text, 3) <> LSet(customersRawList(x), 3) Then
                        customersFileHandler.WriteLineToFile(customersRawList(x))
                    Else
                        customersFileHandler.WriteLineToFile(CustomerData.ID & CustomerData.Name & CustomerData.Number & CustomerData.Address & CustomerData.Area & CustomerData.Postcode)
                    End If
                Next
            Else
                'WRITE DATA
                customersFileHandler.WriteLineToFile(CustomerData.ID & CustomerData.Name & CustomerData.Number & CustomerData.Address & CustomerData.Area & CustomerData.Postcode)
            End If

            'if success
            MsgBox("Customer " & nameBox.Text & " saved")
            customersFileHandler.IncrementID() 'ensure unique ID for next customer

            'reset fields
            IDBox.Text = customersFileHandler.GetID()
            nameBox.Text = ""
            numberBox.Text = ""
            addressBox.Text = ""
            areaBox.SelectedIndex = -1
            postcodeBox.Text = ""

            If useParent Then
                parentalForm.Close()
                ManageFiles.Show()
                Me.Close()
            End If

        End If

    End Sub

    Private Sub addButton_MouseHover(sender As Object, e As EventArgs) Handles addButton.MouseHover

        ValidateData()

    End Sub

    'VALIDATES DATA FROM toValidate ARRAY'S FIELDS AND PARAMETERS, USING Validation.vb CLASS
    Function ValidateData()

        Dim validation = New Validation, allIsValid = True

        'INPUT DATA FROM FIELDS
        CustomerData.ID = LSet(IDBox.Text, 3)
        CustomerData.Name = LSet(nameBox.Text, 25)
        CustomerData.Number = LSet(numberBox.Text, 11)
        CustomerData.Address = LSet(addressBox.Text, 25)
        CustomerData.Area = LSet(areaBox.Text, 12)
        CustomerData.Postcode = LSet(postcodeBox.Text, 7)

        'VALIDATE REQUIRED FIELDS
        For x = 0 To (toValidate.Length / 2) - 1 'for each field
            Dim field = toValidate(0, x), dataIsValid = True

            'presence check
            dataIsValid = validation.PresenceCheck(field.Text) And dataIsValid

            'length check
            dataIsValid = validation.LengthCheck(field.Text, toValidate(1, x)) And dataIsValid

            If dataIsValid Then
                GetNextControl(field, False).ForeColor = vbDefault
            Else
                GetNextControl(field, False).ForeColor = vbRed 'highlight corresponding label
            End If

            allIsValid = dataIsValid And allIsValid
        Next

        'format (phone number)
        If validation.PhoneNumberFormatCheck(numberBox.Text) Then
            numberLabel.ForeColor = vbDefault
        Else
            allIsValid = False
            numberLabel.ForeColor = vbRed
        End If

        'format (postcode)
        If validation.PostcodeFormat(postcodeBox.Text) Then
            postcodeLabel.ForeColor = vbDefault
        Else
            allIsValid = False
            postcodeLabel.ForeColor = vbRed
        End If

        If allIsValid Then
            addButton.Cursor = Cursors.Default
            errorLabel.Text = ""
        Else
            addButton.Cursor = Cursors.No 'feedback to user
            errorLabel.Text = "Invalid Data"
        End If

        Return allIsValid

    End Function

    Dim useParent As Boolean = False
    Sub SetParent(parent As Form)

        parentalForm = parent
        useParent = True

    End Sub

    Dim inEditMode As Boolean
    Sub EnableEditMode(item As GlobalVariables.customer)

        inEditMode = True

        IDBox.Text = item.ID
        nameBox.Text = item.Name
        numberBox.Text = item.Number
        addressBox.Text = item.Address
        areaBox.Text = item.Area
        postcodeBox.Text = item.Postcode

        addButton.Text = "Update"

    End Sub
End Class