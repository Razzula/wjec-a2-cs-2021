Public Class AddMaterial

    Dim materialsFileHandler As FileHandling
    Dim MaterialData As New GlobalVariables.material 'data of current customer
    Dim MaterialList As New List(Of GlobalVariables.material) 'stores existing records fetched from file

    Dim toValidate 'list of fields to validate, and validation parameters (set AFTER load)

    Dim vbRed As Color, vbDefault As Color
    Dim parentalForm As ManageFiles

    'WHEN FORM LOADED
    Private Sub AddMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        materialsFileHandler = New FileHandling("materials.txt", "ID NAME                     TYPE  PPU")

        'SETUP
        IDBox.Text = materialsFileHandler.GenerateID()

        'MISC.
        vbRed = errorLabel.ForeColor 'colour of error messages
        vbDefault = IDLabel.ForeColor

        toValidate = {{IDBox, nameBox, typeBox, priceBox}, {3, 25, 8, 3}} 'field, maxLength

    End Sub

    'WHEN TYPE IS SELECTED
    Private Sub typeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeBox.SelectedIndexChanged

        priceBox.Enabled = True
        If typeBox.Text = "Resource" Then
            unitTypeLabel.Text = "per Item"
        Else
            unitTypeLabel.Text = "per Hour"
        End If

    End Sub

    'WHEN ADD BUTTON SELECTED
    Private Sub addButton_MouseHover(sender As Object, e As EventArgs) Handles addButton.MouseHover

        ValidateData()

    End Sub

    'WHEN 'ADD' BUTTON CLICKED, or ENTER KEY PRESSED
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        'VALIDATION
        Dim valid As Boolean
        valid = ValidateData()

        If valid Then
            If inEditMode Then
                'CLEAR FILE
                Dim materialsRawList() As String = materialsFileHandler.GetFileContents()
                materialsFileHandler.ClearFile()

                'WRITE DATA
                For x = 1 To materialsRawList.Length - 1
                    If LSet(IDBox.Text, 3) <> LSet(materialsRawList(x), 3) Then
                        materialsFileHandler.WriteLineToFile(materialsRawList(x))
                    Else
                        'WRITE DATA
                        materialsFileHandler.WriteLineToFile(MaterialData.ID & MaterialData.name & MaterialData.type & MaterialData.pricePerUnit)
                    End If
                Next
            Else
                'WRITE DATA
                materialsFileHandler.WriteLineToFile(MaterialData.ID & MaterialData.name & MaterialData.type & MaterialData.pricePerUnit)
            End If

            'if success
            MsgBox("Material " & nameBox.Text & " saved")
            materialsFileHandler.IncrementID() 'ensure unique ID for next customer

            'reset fields
            IDBox.Text = materialsFileHandler.GetID()
            nameBox.Text = ""
            typeBox.Text = ""
            priceBox.Text = ""

            If useParent Then
                parentalForm.Close()
                ManageFiles.Show()
                Me.Close()
            End If

        End If

    End Sub

    'VALIDATES DATA FROM toValidate ARRAY'S FIELDS AND PARAMETERS, USING Validation.vb CLASS
    Function ValidateData()

        Dim validation = New Validation, allIsValid = True

        'INPUT DATA FROM FIELDS
        MaterialData.ID = LSet(IDBox.Text, 3)
        MaterialData.name = LSet(nameBox.Text, 25)
        MaterialData.type = LSet(typeBox.Text, 8)
        MaterialData.pricePerUnit = LSet(priceBox.Text, 3)


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

        'data check
        If validation.datatypecheck(priceBox.Text) Then

            'range check
            If validation.RangeCheck(priceBox.Text, 1, 999) Then
                allIsValid = allIsValid And True
                priceLabel.ForeColor = vbDefault
            Else
                allIsValid = False
                priceLabel.ForeColor = vbRed
            End If

        Else
            allIsValid = False
            priceLabel.ForeColor = vbRed
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
    Sub EnableEditMode(item As GlobalVariables.material)

        inEditMode = True

        IDBox.Text = item.ID
        nameBox.Text = item.name
        typeBox.Text = item.type
        priceBox.Text = item.pricePerUnit

        addButton.Text = "Update"

    End Sub

End Class