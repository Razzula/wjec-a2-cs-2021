Public Class AddBooking

    Dim bookingsFileHandler As FileHandling
    Dim bookingsList As New List(Of GlobalVariables.booking) 'stores existing records fetched from file

    Dim customersList As New List(Of GlobalVariables.customer) 'stores existing records fetched from file

    Dim bookingData As GlobalVariables.booking

    Dim jobsList As New List(Of GlobalVariables.job)

    Dim currentCustomer As Integer, currentJob As Integer

    Dim toValidate
    Dim vbRed As Color, vbDefault As Color

    Dim parentalForm As ManageFiles

    'WHEN FORM LOADED
    Private Sub AddBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bookingsFileHandler = New FileHandling("bookings.txt", "ID cID jID Len Day Start")

        'CUSTOMER HANDLING
        Dim customersFileHandler = New FileHandling("customers.txt", "ID NAME                     PONUMBER   ADDRESS                  AREA        POSTCODE")
        Dim customersRawList() As String
        customersRawList = customersFileHandler.GetFileContents()

        'split file contents into components
        For x = 1 To customersRawList.Length - 1

            Dim customerData As GlobalVariables.customer

            customerData.ID = Trim(Mid(customersRawList(x), 1, 3))
            customerData.Name = Trim(Mid(customersRawList(x), 4, 25))
            customerData.Number = Trim(Mid(customersRawList(x), 29, 11))
            customerData.Address = Trim(Mid(customersRawList(x), 40, 25))
            customerData.Area = Trim(Mid(customersRawList(x), 65, 12))
            customerData.Postcode = Trim(Mid(customersRawList(x), 77, 7))

            customersList.Add(customerData)
            customerBox.Items.Add(customerData.Name) 'adds customer's name to dropdown box

        Next

        'JOB HANDLING
        Dim jobsFileHandler = New FileHandling("jobs.txt", "ID NAME                     £R £L")
        Dim jobsRawList() As String
        jobsRawList = jobsFileHandler.GetFileContents()

        'split file contents into components
        For x = 1 To jobsRawList.Length - 1

            Dim jobData As GlobalVariables.job

            jobData.ID = Trim(Mid(jobsRawList(x), 1, 3))
            jobData.Name = Trim(Mid(jobsRawList(x), 4, 25))

            jobsList.Add(jobData)
            jobBox.Items.Add(jobData.Name) 'adds customer's name to dropdown box

        Next

        'SETUP
        IDBox.Text = bookingsFileHandler.GenerateID()
        toValidate = {{IDBox, customerBox, hourBox, minuteBox, jobBox}, {3, 25, 2, 2, 25}}

        'MISC.
        vbRed = errorLabel.ForeColor 'colour of error messages
        vbDefault = IDLabel.ForeColor

    End Sub

    'WHEN 'ADD' BUTTON CLICKED, or ENTER KEY PRESSED
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        'VALIDATION
        Dim valid As Boolean
        valid = ValidateData()

        If valid Then
            If inEditMode Then
                'CLEAR FILE
                Dim bookingsRawList() As String = bookingsFileHandler.GetFileContents()
                bookingsFileHandler.ClearFile()

                'WRITE DATA
                For x = 1 To bookingsRawList.Length - 1
                    If LSet(IDBox.Text, 3) <> LSet(bookingsRawList(x), 3) Then
                        bookingsFileHandler.WriteLineToFile(bookingsRawList(x))
                    Else
                        bookingsFileHandler.WriteLineToFile(bookingData.ID & bookingData.customerID & bookingData.jobID & bookingData.jobLength)
                    End If
                Next
            Else
                'WRITE DATA
                bookingsFileHandler.WriteLineToFile(bookingData.ID & bookingData.customerID & bookingData.jobID & bookingData.jobLength)
            End If

            'if success
            MsgBox("Booking " & IDBox.Text & " saved")
            bookingsFileHandler.IncrementID()

            'reset fields
            IDBox.Text = bookingsFileHandler.GetID() 'ensure unique ID for next customer
            customerBox.Text = ""
            addressBox.Text = ""
            areaBox.Text = ""
            postcodeBox.Text = ""
            jobBox.Text = ""
            hourBox.Text = ""
            minuteBox.Text = ""

            'UPDATE TIMETABLE
            Dim timetableCalculator As TimetableCalculations
            timetableCalculator = New TimetableCalculations
            timetableCalculator.GenerateTimetable()
            MsgBox("Timetable has been updated.")

            If useParent Then
                parentalForm.Close()
                ManageFiles.Show()
                Me.Close()
            End If

        End If

    End Sub

    'WHEN CUSTOMER SELECTED
    Private Sub customerBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles customerBox.SelectedValueChanged

        'linear search
        For x = 0 To customersList.Count - 1

            If customerBox.Text = customersList(x).Name Then

                currentCustomer = x

                addressBox.Text = customersList(x).Address
                areaBox.Text = customersList(x).Area
                postcodeBox.Text = customersList(x).Postcode

                Return 'halt search - item found, no need to carry on looking

            End If

        Next

        MsgBox("Error: Customer details not found.") 'should never be called, as the above Return should always be used.

    End Sub

    'WHEN JOB SELECTED
    Private Sub jobBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles jobBox.SelectedValueChanged

        'linear search
        For x = 0 To jobsList.Count - 1

            If jobBox.Text = jobsList(x).Name Then

                currentJob = x

                Return 'halt search - item found, no need to carry on looking

            End If

        Next

        MsgBox("Error: Job details not found.") 'should never be called, as the above Return should always be used.

    End Sub

    Private Sub addButton_MouseHover(sender As Object, e As EventArgs) Handles addButton.MouseHover

        ValidateData()

    End Sub

    'VALIDATES DATA FROM toValidate ARRAY'S FIELDS AND PARAMETERS, USING Validation.vb CLASS
    Function ValidateData()

        Dim validation = New Validation, allIsValid = True

        'INPUT DATA FROM FIELDS
        bookingData.ID = LSet(IDBox.Text, 3)
        bookingData.customerID = LSet(customersList(currentCustomer).ID, 4)
        bookingData.jobID = LSet(jobsList(currentJob).ID, 4)

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

        'data type
        If validation.datatypecheck(hourBox.Text) And validation.datatypecheck(minuteBox.Text) Then

            'range check
            If validation.RangeCheck(hourBox.Text, 0, 24) And validation.RangeCheck(minuteBox.Text, 0, 60) Then
                jobLengthLabel.ForeColor = vbDefault
            Else
                allIsValid = False
                jobLengthLabel.ForeColor = vbRed
            End If

        Else
            allIsValid = False
            jobLengthLabel.ForeColor = vbRed
        End If


        'convert hmm to mmm
        If allIsValid Then
            Dim hour As Integer = Convert.ToInt16(hourBox.Text), minute As Integer = Convert.ToInt16(minuteBox.Text)

            If (hour * 60) + minute <= 0 Then
                jobLengthLabel.ForeColor = vbRed
                allIsValid = False
            Else
                bookingData.jobLength = (hour * 60) + minute
            End If


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
    Sub EnableEditMode(item As GlobalVariables.booking)

        inEditMode = True

        IDBox.Text = item.ID
        customerBox.Text = item.customerID
        jobBox.Text = item.jobID
        hourBox.Text = Math.Floor(item.jobLength / 60)
        minuteBox.Text = ((item.jobLength / 60) - Math.Floor(item.jobLength / 60)) * 60

        addButton.Text = "Update"

    End Sub

End Class