Public Class ViewTimetable

    Dim timetableItemsList As New List(Of GlobalVariables.timetableItem), pastTimetableItemsList As New List(Of GlobalVariables.timetableItem), bookingsList As New List(Of GlobalVariables.booking), customersList As New List(Of GlobalVariables.customer), jobsList As New List(Of GlobalVariables.job)
    Dim currentWeek As Date, presentWeek As Date

    Dim currentDay As Integer = Date.Now.Date.DayOfWeek


    Private Sub ViewTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        calculateMondayOfWeek(Date.Now.Date)
        presentWeek = currentWeek

        If currentDay = 0 Then
            currentDay = 6
        Else
            currentDay -= 1
        End If

        'LOAD DATA FROM FILES
        'TIMETABLE.TXT
        Dim timetableFileHandler = New FileHandling("timetable.txt", "ID bID Day Srt Len")
        Dim timetableRawList() As String = timetableFileHandler.GetFileContents() 'used for the order and positioning of timetable items

        For timetableItemsCounter = 1 To timetableRawList.Count - 1
            Dim tempTimetableItem As GlobalVariables.timetableItem
            'read data from timetable file
            tempTimetableItem.ID = Trim(Mid(timetableRawList(timetableItemsCounter), 1, 3))
            tempTimetableItem.bookingID = Trim(Mid(timetableRawList(timetableItemsCounter), 4, 3))
            tempTimetableItem.day = Trim(Mid(timetableRawList(timetableItemsCounter), 8, 3))
            tempTimetableItem.startTime = Trim(Mid(timetableRawList(timetableItemsCounter), 12, 3))
            tempTimetableItem.jobLength = Trim(Mid(timetableRawList(timetableItemsCounter), 16, 3))
            'tempTimetableItem.week = presentWeek

            timetableItemsList.Add(tempTimetableItem)
        Next

        'COMPLETEDJOBS.TXT
        timetableFileHandler = New FileHandling("completedJobs.txt", "ID bID Day Srt Len Week")
        timetableRawList = timetableFileHandler.GetFileContents() 'used for the order and positioning of timetable items

        For timetableItemsCounter = 1 To timetableRawList.Count - 1
            Dim tempTimetableItem As GlobalVariables.timetableItem
            'read data from pastTimetable file
            tempTimetableItem.ID = Trim(Mid(timetableRawList(timetableItemsCounter), 1, 3))
            tempTimetableItem.bookingID = Trim(Mid(timetableRawList(timetableItemsCounter), 4, 3))
            tempTimetableItem.day = Trim(Mid(timetableRawList(timetableItemsCounter), 8, 3))
            tempTimetableItem.startTime = Trim(Mid(timetableRawList(timetableItemsCounter), 12, 3))
            tempTimetableItem.jobLength = Trim(Mid(timetableRawList(timetableItemsCounter), 16, 3))
            tempTimetableItem.week = Trim(Mid(timetableRawList(timetableItemsCounter), 19, 11))

            pastTimetableItemsList.Add(tempTimetableItem)
        Next

        'BOOKINGS.TXT
        Dim bookingsFilehandler = New FileHandling("bookings.txt", "ID cID jID Len Day Start")
        Dim bookingsRawList() As String = bookingsFilehandler.GetFileContents() 'used to find the corresponding customer

        For bookingsItemCounter = 1 To bookingsRawList.Count - 1
            Dim tempBookingRecord As GlobalVariables.booking
            'read data from pastTimetable file
            tempBookingRecord.ID = Trim(Mid(bookingsRawList(bookingsItemCounter), 1, 3))
            tempBookingRecord.customerID = Trim(Mid(bookingsRawList(bookingsItemCounter), 4, 4))
            tempBookingRecord.jobID = Trim(Mid(bookingsRawList(bookingsItemCounter), 8, 4))

            bookingsList.Add(tempBookingRecord)
        Next

        'CUSTOMERS.TXT
        Dim customersFileHandler = New FileHandling("customers.txt", "ID NAME                     PONUMBER   ADDRESS                  AREA        POSTCODE")
        Dim customersRawList() As String = customersFileHandler.GetFileContents() 'used to find the customer's name and address details

        For customersItemCounter = 1 To customersRawList.Count - 1
            Dim tempCustomerRecord As GlobalVariables.customer
            'fetch data from corresponding customer file
            tempCustomerRecord.ID = Trim(Mid(customersRawList(customersItemCounter), 1, 3))
            tempCustomerRecord.Name = Trim(Mid(customersRawList(customersItemCounter), 4, 25))
            tempCustomerRecord.Address = Trim(Mid(customersRawList(customersItemCounter), 40, 25))
            tempCustomerRecord.Area = Trim(Mid(customersRawList(customersItemCounter), 65, 12))
            tempCustomerRecord.Postcode = Trim(Mid(customersRawList(customersItemCounter), 77, 7))

            customersList.Add(tempCustomerRecord) 'add the record to the list
        Next

        'JOBS.TXT
        Dim jobsFileHandler = New FileHandling("jobs.txt", "TEMP")
        Dim jobsRawList() As String = jobsFileHandler.GetFileContents() 'used to find the job name and prices

        For jobsItemCounter = 1 To jobsRawList.Count - 1
            Dim tempJobRecord As GlobalVariables.job
            'fetch data from corresponding job file
            tempJobRecord.ID = Trim(Mid(jobsRawList(jobsItemCounter), 1, 3))
            tempJobRecord.Name = Trim(Mid(jobsRawList(jobsItemCounter), 4, 25))
            tempJobRecord.RP = Trim(Mid(jobsRawList(jobsItemCounter), 29, 3))
            tempJobRecord.LP = Trim(Mid(jobsRawList(jobsItemCounter), 32, 3))

            jobsList.Add(tempJobRecord) 'add the record to the list
        Next

        DisplayTimetable()

    End Sub

    Sub DisplayTimetable()

        'DISPLAY
        Dim timetable As Timetable = timetableDsiplay
        timetable.ResetOverflowID()

        Dim currentWeekString As String = currentWeek

        Dim projectedEarnings = 0, earnings = 0

        projectedEarningsBox.Show()
        projectedEarningsLabel.Show()

        'PRESENT  WEEK
        If currentWeek = presentWeek Then

            'search through past timetable items
            For x = 0 To pastTimetableItemsList.Count - 1

                If pastTimetableItemsList(x).week = currentWeekString And pastTimetableItemsList(x).day < currentDay Then 'if a valid item
                    Dim timetableItem As GlobalVariables.timetableItem, customer As GlobalVariables.customer, job As GlobalVariables.job
                    customer.Name = "Not Found"
                    timetableItem = pastTimetableItemsList(x)

                    'search through bookings for corresponding item
                    Dim bookingID = pastTimetableItemsList(x).bookingID
                    For y = 0 To bookingsList.Count - 1
                        If bookingsList(y).ID = bookingID Then

                            'search through customers for corresponding item
                            Dim customerID = bookingsList(y).customerID
                            For z = 0 To customersList.Count - 1
                                If customersList(z).ID = customerID Then
                                    customer = customersList(z)
                                End If
                            Next

                            'search through jobs for corresponding item
                            Dim jobID = bookingsList(y).jobID
                            For z = 0 To jobsList.Count - 1
                                If jobsList(z).ID = jobID Then
                                    job = jobsList(z)
                                End If
                            Next

                        End If
                    Next

                    earnings += (job.LP * timetableItem.jobLength / 60) + job.RP
                    projectedEarnings += (job.LP * timetableItem.jobLength / 60) + job.RP
                    timetable.DisplayTimetableItem(timetableItem, customer, job, Me)
                End If

            Next

            'search through timetable items
            For x = 0 To timetableItemsList.Count - 1

                If timetableItemsList(x).day >= currentDay Then 'if a valid item
                    Dim timetableItem As GlobalVariables.timetableItem, customer As GlobalVariables.customer, job As GlobalVariables.job
                    customer.Name = "Not Found"
                    timetableItem = timetableItemsList(x)

                    'search through bookings for corresponding item
                    Dim bookingID = timetableItemsList(x).bookingID
                    For y = 0 To bookingsList.Count - 1
                        If bookingsList(y).ID = bookingID Then

                            'search through customers for corresponding item
                            Dim customerID = bookingsList(y).customerID
                            For z = 0 To customersList.Count - 1
                                If customersList(z).ID = customerID Then
                                    customer = customersList(z)
                                End If
                            Next

                            'search through jobs for corresponding item
                            Dim jobID = bookingsList(y).jobID
                            For z = 0 To jobsList.Count - 1
                                If jobsList(z).ID = jobID Then
                                    job = jobsList(z)
                                End If
                            Next

                        End If
                    Next

                    projectedEarnings += (job.LP * timetableItem.jobLength / 60) + job.RP
                    timetable.DisplayTimetableItem(timetableItem, customer, job, Me)
                End If

            Next

            'PAST  WEEK
        ElseIf currentWeek < presentWeek Then

            'search through past timetable items
            For x = 0 To pastTimetableItemsList.Count - 1

                If pastTimetableItemsList(x).week = currentWeekString Then 'if a valid item
                    Dim timetableItem As GlobalVariables.timetableItem, customer As GlobalVariables.customer, job As GlobalVariables.job
                    customer.Name = "Not Found"
                    timetableItem = pastTimetableItemsList(x)

                    'search through bookings for corresponding item
                    Dim bookingID = pastTimetableItemsList(x).bookingID
                    For y = 0 To bookingsList.Count - 1
                        If bookingsList(y).ID = bookingID Then

                            'search through customers for corresponding item
                            Dim customerID = bookingsList(y).customerID
                            For z = 0 To customersList.Count - 1
                                If customersList(z).ID = customerID Then
                                    customer = customersList(z)
                                End If
                            Next

                            'search through jobs for corresponding item
                            Dim jobID = bookingsList(y).jobID
                            For z = 0 To jobsList.Count - 1
                                If jobsList(z).ID = jobID Then
                                    job = jobsList(z)
                                End If
                            Next

                        End If
                    Next

                    earnings += (job.LP * timetableItem.jobLength / 60) + job.RP
                    timetable.DisplayTimetableItem(timetableItem, customer, job, Me)
                End If

            Next

            projectedEarningsBox.Hide()
            projectedEarningsLabel.Hide()

            'FUTURE  WEEK
        ElseIf currentWeek > presentWeek Then

            'search through timetable items
            For x = 0 To timetableItemsList.Count - 1

                Dim timetableItem As GlobalVariables.timetableItem, customer As GlobalVariables.customer, job As GlobalVariables.job
                customer.Name = "Not Found"
                timetableItem = timetableItemsList(x)

                'search through bookings for corresponding item
                Dim bookingID = timetableItemsList(x).bookingID
                For y = 0 To bookingsList.Count - 1
                    If bookingsList(y).ID = bookingID Then

                        'search through customers for corresponding item
                        Dim customerID = bookingsList(y).customerID
                        For z = 0 To customersList.Count - 1
                            If customersList(z).ID = customerID Then
                                customer = customersList(z)
                            End If
                        Next

                        'search through jobs for corresponding item
                        Dim jobID = bookingsList(y).jobID
                        For z = 0 To jobsList.Count - 1
                            If jobsList(z).ID = jobID Then
                                job = jobsList(z)
                            End If
                        Next

                    End If
                Next

                projectedEarnings += (job.LP * timetableItem.jobLength / 60) + job.RP
                timetable.DisplayTimetableItem(timetableItem, customer, job, Me)

            Next

        End If

        'LABELS
        mondayLabel.Text = currentWeek
        tuesdayLabel.Text = currentWeek.AddDays(1)
        wednesddayLabel.Text = currentWeek.AddDays(2)
        thursdayLabel.Text = currentWeek.AddDays(3)
        fridayLabel.Text = currentWeek.AddDays(4)

        projectedEarningsBox.Text = projectedEarnings
        earningsBox.Text = earnings

    End Sub

    Dim timetableItems As New List(Of Control)

    Sub newButtonCreated(newButton As Control)

        timetableItems.Add(newButton)

    End Sub

    Dim days() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

    Dim currentCustomerID, currentJobID, currentJobLength, currentTime

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Dim oldMondayOfWeek = currentWeek
        calculateMondayOfWeek(DateTimePicker1.Value.Date)

        If currentWeek = oldMondayOfWeek Then 'if value has significantly chnaged
        Else
            'remove all items
            Dim numberOfItems = timetableItems.Count - 1
            For i = 0 To numberOfItems

                timetableItems(i).Dispose()
                numberOfItems -= 1

            Next

            'reset right-hand boxes
            nameBox.Text = ""
            addressBox.Text = ""
            areaBox.Text = ""
            postcodeBox.Text = ""
            jobBox.Text = ""
            priceBox.Text = ""
            dayBox.Text = ""
            startTimeBox.Text = ""
            endTimeBox.Text = ""
            completedButton.Enabled = False
            dayCompletedButton.Enabled = False

            DisplayTimetable()
        End If

    End Sub

    Sub calculateMondayOfWeek(selectedDate As Date)

        Dim d As Integer = DateTimePicker1.Value.DayOfWeek - 1
        If d = -1 Then
            d = 6
        End If

        currentWeek = selectedDate.AddDays(-d)
        'mondayOfWeek = currentWeek

        Me.Text = "Timetable (" & currentWeek & " - " & currentWeek.AddDays(4) & ")"
    End Sub

    Private Sub completedButton_Click(sender As Object, e As EventArgs) Handles completedButton.Click

        Dim completedJobsHandler As New FileHandling("completedJobs.txt", "ID bID Day Srt Len Week")
        Dim ID = completedJobsHandler.GenerateID()

        completedJobsHandler.WriteLineToFile(LSet(ID, 3) & LSet(currentSelectedItem.bookingID, 4) & LSet(currentSelectedItem.day, 4) & LSet(currentSelectedItem.startTime, 4) & LSet(currentSelectedItem.jobLength, 4) & currentWeek)

        completedButton.Enabled = False
        MsgBox("Done.", vbExclamation, "Warning!")

    End Sub

    Private Sub dayCompletedButton_Click(sender As Object, e As EventArgs) Handles dayCompletedButton.Click

        Dim completedJobsHandler As New FileHandling("completedJobs.txt", "ID bID Day Srt Len Week")
        Dim currentWeekString As String = currentWeek

        For x = 0 To timetableItemsList.Count - 1 'search timetable items

            If timetableItemsList(x).day = currentSelectedItem.day Then 'if selected day, within current week
                'add item to file
                Dim ID As Integer = completedJobsHandler.GenerateID()
                completedJobsHandler.WriteLineToFile(LSet(ID, 3) & LSet(timetableItemsList(x).bookingID, 4) & LSet(timetableItemsList(x).day, 4) & LSet(timetableItemsList(x).startTime, 4) & LSet(timetableItemsList(x).jobLength, 4) & currentWeek)
            End If

        Next

        completedButton.Enabled = False
        dayCompletedButton.Enabled = False
        MsgBox("All items from " & currentWeek & " marked as complete.", vbExclamation, "Warning!")

    End Sub

    Dim currentSelectedItem As GlobalVariables.timetableItem

    Sub UpdateFields(bookingData As GlobalVariables.timetableItem, customerData As GlobalVariables.customer, jobData As GlobalVariables.job)

        'displays booking data; has to convert some of that data into standard form (e.g time as 08:00, not 0) (18:00, not 600)
        currentSelectedItem = bookingData

        nameBox.Text = customerData.Name
        addressBox.Text = customerData.Address
        areaBox.Text = customerData.Area
        postcodeBox.Text = customerData.Postcode

        Dim startTime = CInt(bookingData.startTime)
        Dim jobLength = CInt(bookingData.jobLength)

        dayBox.Text = days(bookingData.day)
        startTimeBox.Text = TimeFormOf(startTime)
        endTimeBox.Text = TimeFormOf(startTime + jobLength)

        jobBox.Text = jobData.Name
        priceBox.Text = (jobData.LP * (bookingData.jobLength / 60)) + jobData.RP

        'non-displayed, but still important data
        currentCustomerID = customerData.ID
        currentJobID = jobData.ID
        currentJobLength = bookingData.jobLength
        'currentTime = bookingData.startTime

        'enable controls
        If currentWeek = presentWeek And bookingData.day = currentDay Then
            completedButton.Enabled = True
            dayCompletedButton.Enabled = True
        Else
            completedButton.Enabled = False
            dayCompletedButton.Enabled = False
        End If


    End Sub

    Function TimeFormOf(numericalTime)

        Dim hour As String = Math.Floor(numericalTime / 60) + 8
        Dim minute As String = numericalTime - (Math.Floor(numericalTime / 60) * 60)
        If hour.Count = 1 Then
            hour = "0" + hour
        End If
        If minute.Count = 1 Then
            minute = "0" + minute
        End If

        Return hour + ":" + minute

    End Function

End Class