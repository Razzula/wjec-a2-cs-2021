Public Class AddJob

    Dim jobHandler As New FileHandling("jobs.txt", "TEMP")

    Dim resourcePrice As Integer = 0
    Dim labourPrice As Integer = 0

    Dim jobData As GlobalVariables.job

    Dim vbRed As Color, vbDefault As Color
    Dim parentalForm As ManageFiles

    Private Sub AddJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IDBox.Text = jobHandler.GenerateID

        'MISC.
        vbRed = errorLabel.ForeColor 'colour of error messages
        vbDefault = IDLabel.ForeColor

    End Sub

    'OPENS THE SELECT MATERIALS FORM, AND LINKS IT TO THE CURRENT ONE, so that the items can be added to the current ListView
    Private Sub addMaterialButton_Click(sender As Object, e As EventArgs) Handles addMaterialButton.Click

        Dim childForm = New SelectMaterial
        childForm.Show()
        childForm.SetParent(Me)

    End Sub

    'ADDS THE MATERIAL FROM THE SLSECT MATERIAL FORM TO THIS ONE
    Public Sub AddMaterialToList(material As GlobalVariables.material)

        Dim newMaterial = materialsList.Items.Add(material.name) 'adds material to list
        newMaterial.SubItems.Add(material.pricePerUnit)
        newMaterial.SubItems.Add(material.type)

        'enables buttons
        removeMaterialButton.Enabled = True
        clearButton.Enabled = True

        'maths
        If material.type = "Resource" Then
            resourcePrice += material.pricePerUnit
            resourcePriceBox.Text = resourcePrice
        Else
            labourPrice += material.pricePerUnit
            labourPriceBox.Text = labourPrice
        End If

    End Sub

    'REMOVES THE CURRENT SELECTED MATERIAL
    Private Sub removeMaterialButton_Click(sender As Object, e As EventArgs) Handles removeMaterialButton.Click

        If materialsList.SelectedItems().Item(0).SubItems(2).Text = "Resource" Then
            resourcePrice -= materialsList.SelectedItems().Item(0).SubItems(1).Text
            resourcePriceBox.Text = resourcePrice
        Else
            labourPrice -= materialsList.SelectedItems().Item(0).SubItems(1).Text
            labourPriceBox.Text = labourPrice
        End If

        materialsList.Items.Remove(materialsList.SelectedItems().Item(0)) 'removes item from listview

        If materialsList.Items.Count = 0 Then 'if all items have been removed
            removeMaterialButton.Enabled = False 'disable the buttons, as no items can be selected
            clearButton.Enabled = False
        End If

    End Sub

    'REMOVES ALL MATERIALS FROM LIST
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        materialsList.Items.Clear()

        removeMaterialButton.Enabled = False
        clearButton.Enabled = False

        resourcePrice = 0
        labourPrice = 0
        resourcePriceBox.Text = 0
        labourPriceBox.Text = 0

    End Sub

    Private Sub newMaterialButton_Click(sender As Object, e As EventArgs) Handles newMaterialButton.Click

        AddMaterial.Show()

    End Sub

    'VALIDATES DATA FROM toValidate ARRAY'S FIELDS AND PARAMETERS, USING Validation.vb CLASS
    Function ValidateData()

        Dim validator = New Validation, allIsValid = True

        'INPUT DATA FROM FIELDS
        jobData.ID = LSet(IDBox.Text, 3)
        jobData.Name = LSet(nameBox.Text, 25)
        jobData.RP = LSet(resourcePrice, 3)
        jobData.LP = LSet(labourPrice, 3)

        'VALIDATE REQUIRED FIELDS

        Dim errorMessage As String = ""
        'presence check
        If validator.PresenceCheck(jobData.Name) Then
            nameLabel.ForeColor = vbDefault
        Else
            allIsValid = False
            nameLabel.ForeColor = vbRed
            errorMessage = "Name required"
        End If

        If resourcePrice + labourPrice = 0 Then
            allIsValid = False
            materialsLabel.ForeColor = vbRed
            errorMessage = "Job cannot be blank"
        Else
            materialsLabel.ForeColor = vbDefault
        End If

        If allIsValid Then
            addButton.Cursor = Cursors.Default
        Else
            addButton.Cursor = Cursors.No
        End If
        errorLabel.Text = errorMessage
        Return allIsValid

    End Function

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        Dim valid = ValidateData()

        If valid Then

            'WRITE DATA

            jobHandler.WriteLineToFile(jobData.ID & jobData.Name & jobData.RP & jobData.LP)

            'if success
            MsgBox("Job " & nameBox.Text & " saved")
            jobHandler.IncrementID() 'ensure unique ID for next customer

            'reset fields
            IDBox.Text = jobHandler.GetID()
            nameBox.Text = ""
            clearButton_Click(sender, e)

            If asChild Then
                parentalForm.DisplayContents()
                Me.Close()
            End If

        End If

    End Sub

    Private Sub addButton_MouseHover(sender As Object, e As EventArgs) Handles addButton.MouseHover

        ValidateData()

    End Sub

    Dim asChild As Boolean = False
    Sub SetParent(parent As Form)

        asChild = True
        parentalForm = parent

    End Sub

End Class