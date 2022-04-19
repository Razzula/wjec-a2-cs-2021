Public Class SelectMaterial

    Dim parentForm As AddJob
    Dim materialsHandler As FileHandling

    Dim materials As New List(Of GlobalVariables.material)

    'GETS DATA FROM FILE AND LOADS IT INTO LISTVIEW
    Private Sub SelectMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        materialsHandler = New FileHandling("materials.txt", "ID NAME                     TYPE  PPU")
        Dim fileData() As String = materialsHandler.GetFileContents()

        For x = 1 To fileData.Count - 1

            Dim tempMaterial As GlobalVariables.material
            tempMaterial.name = Trim(Mid(fileData(x), 4, 25))
            tempMaterial.type = Trim(Mid(fileData(x), 29, 8))
            tempMaterial.pricePerUnit = Trim(Mid(fileData(x), 37, 3))

            Dim newItem = materialsList.Items.Add(tempMaterial.name)
            newItem.SubItems.Add(tempMaterial.type)
            newItem.SubItems.Add(tempMaterial.pricePerUnit)

            materials.Add(tempMaterial)
        Next


    End Sub

    'LINKS FORM TO ADDJOB FORM
    Public Sub SetParent(parent As AddJob)
        parentForm = parent
    End Sub

    'ADD BUTTON CAN ONLY BE USED ONCE A MATERIAL IS SELECTED
    Private Sub materialsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles materialsList.SelectedIndexChanged

        addButton.Enabled = True

    End Sub

    'GETS DATA FROM CURRENT ITEM, SENDS IT TO ADDJOB FORM
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        Dim material As GlobalVariables.material
        material.name = materialsList.SelectedItems().Item(0).Text
        material.type = materialsList.SelectedItems().Item(0).SubItems(1).Text
        material.pricePerUnit = materialsList.SelectedItems().Item(0).SubItems(2).Text
        parentForm.AddMaterialToList(material)
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim text As String = LCase(TextBox1.Text)

        materialsList.Items.Clear()

        For x = 0 To materials.Count - 1
            If LCase(materials(x).name).Contains(text) Then
                Dim newItem = materialsList.Items.Add(materials(x).name)
                newItem.SubItems.Add(materials(x).type)
                newItem.SubItems.Add(materials(x).pricePerUnit)
            End If
        Next

    End Sub
End Class