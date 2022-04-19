Public Class ManageFiles

    Dim fileHandler As FileHandling
    Dim fileData() As String
    Dim dimensions() As Integer, columns() As String, header As String, foreignKeys()

    'ONCE FILE HAS BEEN SELECTED
    Private Sub filenameBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filenameBox.SelectedIndexChanged

        'DATA ABOUT FILES (number of columns, name of columns)
        If filenameBox.Text = "Users.txt" Then
            dimensions = {12, 12, 5}
            columns = {"USERNAME", "PASSWORD", "ACCESS LEVEL"}
            header = "USERNAME    PASSWORD    ACCESSLVL"
            foreignKeys = {"", "", ""}

        ElseIf filenameBox.Text = "Customers.txt" Then
            dimensions = {3, 25, 11, 25, 12, 7}
            columns = {"ID", "NAME", "PHONE NUMBER", "ADDRESS", "AREA", "POSTCODE"}
            header = "ID NAME                     PONUMBER   ADDRESS                  AREA        POSTCODE"
            foreignKeys = {"", "", "", "", "", ""}

        ElseIf filenameBox.Text = "Bookings.txt" Then
            dimensions = {3, 3, 5, 3}
            columns = {"ID", "CUSTOMER", "JOB", "JOB LENGTH"}
            header = "ID cID jID Len"
            foreignKeys = {"", "customers.txt", "jobs.txt", ""}

        ElseIf filenameBox.Text = "Jobs.txt" Then
            dimensions = {3, 25, 3, 3}
            columns = {"ID", "NAME", "RESOURCE PRICE", "LABOUR PRICE"}
            header = "ID NAME                     £R £L"
            foreignKeys = {"", "", "", ""}

        ElseIf filenameBox.Text = "Materials.txt" Then
            dimensions = {3, 25, 8, 3}
            columns = {"ID", "NAME", "TYPE", "PRICE PER UNIT"}
            header = "ID NAME                     TYPE    PPU"
            foreignKeys = {"", "", "", ""}

        End If

        'READS FILE, SPLITS INTO ITEMS, OUTPUTS VIA LISTVIEW
        fileHandler = New FileHandling(filenameBox.Text, header)
        DisplayContents()

        addItemButton.Enabled = True
        clearFileButton.Enabled = True
        editItemButton.Enabled = False
        deleteItemButton.Enabled = False

        searchBox.Enabled = True

    End Sub

    'OUTPUTS THE CONTENTS OF SELECTED FILE INTO LISTVIEW
    Public Sub DisplayContents()

        fileContents.Clear()
        fileData = fileHandler.GetFileContents()

        'COLUMNS (headers)
        For x = 0 To dimensions.Length - 1
            Dim newColumn = fileContents.Columns.Add(columns(x))

            If dimensions(x) > columns(x).Length Then
                newColumn.Width = 20 + (6 * dimensions(x))
            Else
                newColumn.Width = 20 + (8 * columns(x).Length)
            End If

        Next

        'ROWS
        For x = 1 To fileData.Count - 1

            Dim sum = dimensions(0)
            Dim newItem = fileContents.Items.Add(Trim(Mid(fileData(x), 1, sum))) 'first column

            For n = 1 To dimensions.Length - 1

                If foreignKeys(n) = "" Then 'if this is not a foreign key, output data
                    newItem.SubItems.Add(Trim(Mid(fileData(x), sum + 1, dimensions(n)))) 'nth column
                    sum += dimensions(n)

                Else 'if this data is a foreign key, locate the data it refers to
                    Dim foreignKey = Trim(Mid(fileData(x), sum + 1, 3)) 'key to locate

                    'read primary data
                    Dim tempFileHandler As New FileHandling(foreignKeys(n), header)
                    Dim tempData() As String = tempFileHandler.GetFileContents()

                    For y = 1 To tempData.Count - 1 'search for foreign key
                        Dim tempID = Trim(Mid(tempData(y), 1, 3))
                        If tempID = foreignKey Then
                            newItem.SubItems.Add(Trim(Mid(tempData(y), 4, 25))) 'nth column
                            sum += dimensions(n)

                            fileContents.Columns(n).Width = 20 + (6 * 25)
                        End If
                    Next
                End If

            Next

        Next

        If filenameBox.Text = "Users.txt" Then
            DecryptFields()
        End If

    End Sub

    Sub DecryptFields()
        Dim encryptor = New Encryption

        For x = 0 To fileContents.Items.Count - 1
            fileContents.Items(x).Text = encryptor.Decrypt(fileContents.Items(x).Text)
            fileContents.Items(x).SubItems(1).Text = encryptor.Decrypt(fileContents.Items(x).SubItems(1).Text)
        Next

    End Sub

    Private Sub addItemButton_Click(sender As Object, e As EventArgs) Handles addItemButton.Click

        Dim form 'get form from user's selection
        If filenameBox.Text = "Users.txt" Then
            form = New AddUser

        ElseIf filenameBox.Text = "Customers.txt" Then
            form = New AddCustomer

        ElseIf filenameBox.Text = "Bookings.txt" Then
            form = New AddBooking

        ElseIf filenameBox.Text = "Jobs.txt" Then
            form = New AddJob

        ElseIf filenameBox.Text = "Materials.txt" Then
            form = New AddMaterial

        End If

        form.Show() 'open form
        form.SetParent(Me) 'feeds this form to the new form as a parameter, so the form knows whcih form to alter

    End Sub

    Private Sub editItemButton_Click(sender As Object, e As EventArgs) Handles editItemButton.Click

        Dim form 'get form from user's selection
        Dim ID As String
        If filenameBox.Text = "Users.txt" Then
            form = New AddUser
            Dim encryptor As New Encryption 'encrypts the username, so the file record can be found
            ID = encryptor.Encrypt(fileContents.SelectedItems(0).Text)

            form.Show() 'open form
            form.SetParent(Me) 'feeds this form to the new form as a parameter, so the form knows whcih form to alter
            form.EnableEditMode(ID)

        ElseIf filenameBox.Text = "Customers.txt" Then
            form = New AddCustomer

            Dim currentItem As GlobalVariables.customer 'feeds the selected data into the form so the fields can be filled
            currentItem.ID = fileContents.SelectedItems(0).Text
            currentItem.Name = fileContents.SelectedItems(0).SubItems(1).Text
            currentItem.Number = fileContents.SelectedItems(0).SubItems(2).Text
            currentItem.Address = fileContents.SelectedItems(0).SubItems(3).Text
            currentItem.Area = fileContents.SelectedItems(0).SubItems(4).Text
            currentItem.Postcode = fileContents.SelectedItems(0).SubItems(5).Text

            form.Show()
            form.SetParent(Me)
            form.EnableEditMode(currentItem) 'feeds the selected data into the form so the fields can be filled

        ElseIf filenameBox.Text = "Bookings.txt" Then
            form = New AddBooking

            Dim currentItem As GlobalVariables.booking
            currentItem.ID = fileContents.SelectedItems(0).Text
            currentItem.customerID = fileContents.SelectedItems(0).SubItems(1).Text
            currentItem.jobID = fileContents.SelectedItems(0).SubItems(2).Text
            currentItem.jobLength = fileContents.SelectedItems(0).SubItems(3).Text

            form.Show()
            form.SetParent(Me)
            form.EnableEditMode(currentItem)

        ElseIf filenameBox.Text = "Materials.txt" Then
            form = New AddMaterial

            Dim currentItem As GlobalVariables.material
            currentItem.ID = fileContents.SelectedItems(0).Text
            currentItem.name = fileContents.SelectedItems(0).SubItems(1).Text
            currentItem.type = fileContents.SelectedItems(0).SubItems(2).Text
            currentItem.pricePerUnit = fileContents.SelectedItems(0).SubItems(3).Text

            form.Show()
            form.SetParent(Me)
            form.EnableEditMode(currentItem)

        End If

    End Sub

    Private Sub fileContents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fileContents.SelectedIndexChanged

        If filenameBox.Text <> "Jobs.txt" Then
            editItemButton.Enabled = True
        End If
        deleteItemButton.Enabled = True

    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged

        Dim searchFor As String = LCase(searchBox.Text) 'text to search for (vonverted to upper case)
        Dim tempList As New List(Of Object) 'stores items that match the search

        DisplayContents()

        For x = 0 To fileContents.Items.Count - 1 'go through whole list
            Dim currentItem = fileContents.Items.Item(x)
            For y = 0 To fileContents.Items.Item(0).SubItems.Count - 1 'search all columns of selected item

                If LCase(currentItem.SubItems.Item(y).Text).Contains(searchFor) Then 'if searchFor is within the text in question
                    If tempList.Contains(currentItem) = False Then 'if item not already in list(prevents duplicates)
                        tempList.Add(currentItem) 'add item to list
                    End If
                End If

            Next
        Next

        fileContents.Items.Clear()

            For x = 0 To tempList.Count - 1
            fileContents.Items.Add(tempList(x)) 'add items from the list into the listview
        Next

    End Sub

    Private Sub clearFileButton_Click(sender As Object, e As EventArgs) Handles clearFileButton.Click

        Dim confirmation As DialogResult 'confirmation prompt
        confirmation = MessageBox.Show("Are you sure you wish to erase " & filenameBox.Text & "? This cannot be undone.", "Confirmation Requried", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmation = vbYes Then
            fileHandler.ClearFile() 'clear file
            fileContents.Clear() 'clear listview

            editItemButton.Enabled = False 'prevents using these buttons when no items are present
            deleteItemButton.Enabled = False

            If filenameBox.Text = "Users.txt" Then
                fileHandler.WriteLineToFile("ÖÙâÞã       çääé        1") 'adds a default user login, to ensure the system can be accessed
            End If

            If filenameBox.Text = "Bookings.txt" Then 'updates timetable if neccesary
                Dim timetableCalculator As New TimetableCalculations
                timetableCalculator.GenerateTimetable()
                MsgBox("Timetable updated.")
            End If
        End If

    End Sub

    Private Sub deleteItemButton_Click(sender As Object, e As EventArgs) Handles deleteItemButton.Click

        Dim confirmation As DialogResult 'confirmation prompt
        confirmation = MessageBox.Show("Are you sure you wish to delete this item? This cannot be undone.", "Confirmation Requried", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmation = vbYes Then
            Dim currentItem = fileContents.Items.IndexOf(fileContents.SelectedItems.Item(0)) + 1 'item to delete

            fileHandler.ClearFile() 'clears file
            For x = 1 To fileData.Count - 1

                If x = currentItem Then
                Else
                    fileHandler.WriteLineToFile(fileData(x)) 'adds items back tolist, except for the item 
                End If

            Next

            fileContents.Items(currentItem - 1).Remove()
            'DisplayContents() 'OLD

            If filenameBox.Text = "Bookings.txt" Then 'updates timetable if neccesary
                Dim timetableCalculator As New TimetableCalculations
                timetableCalculator.GenerateTimetable()
                MsgBox("Timetable updated.")
            End If

            editItemButton.Enabled = False 'prevents usingthese buttons when no items are present
            deleteItemButton.Enabled = False
        End If

    End Sub

    Private Sub ManageFiles_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        fileContents.Width = Me.Width - 124
        fileContents.Height = Me.Height - 84
    End Sub
End Class