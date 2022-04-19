Public Class Graph

    Dim origin As Point
    Dim timetableItemsList As New List(Of GlobalVariables.timetableItem), bookingsList As New List(Of GlobalVariables.booking), jobsList As New List(Of GlobalVariables.job)


    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        origin.X = 42 'constant x co-ordinate of graph origin, used in calculations

        'LOAD DATA FROM FILES
        'COMPLETEDJOBS.TXT
        Dim timetableFileHandler = New FileHandling("completedJobs.txt", "ID bID Day Srt Len Week")
        Dim timetableRawList = timetableFileHandler.GetFileContents() 'used for the order and positioning of timetable items

        For timetableItemsCounter = 1 To timetableRawList.Length - 1
            Dim tempTimetableItem As GlobalVariables.timetableItem
            'read data from pastTimetable file
            tempTimetableItem.ID = Trim(Mid(timetableRawList(timetableItemsCounter), 1, 3))
            tempTimetableItem.bookingID = Trim(Mid(timetableRawList(timetableItemsCounter), 4, 3))
            tempTimetableItem.day = Trim(Mid(timetableRawList(timetableItemsCounter), 8, 3))
            tempTimetableItem.startTime = Trim(Mid(timetableRawList(timetableItemsCounter), 12, 3))
            tempTimetableItem.jobLength = Trim(Mid(timetableRawList(timetableItemsCounter), 16, 3))
            tempTimetableItem.week = Trim(Mid(timetableRawList(timetableItemsCounter), 19, 11))

            timetableItemsList.Add(tempTimetableItem)
        Next

        'BOOKINGS.TXT
        Dim bookingsFileHandler = New FileHandling("bookings.txt", "TEMP")
        Dim bookingsRawList() As String = bookingsFileHandler.GetFileContents() 'used to find the job name and prices

        For bookingsItemCounter = 1 To bookingsRawList.Length - 1
            Dim tempBookingRecord As GlobalVariables.booking
            'fetch data from corresponding job file
            tempBookingRecord.ID = Trim(Mid(bookingsRawList(bookingsItemCounter), 1, 3))
            tempBookingRecord.jobID = Trim(Mid(bookingsRawList(bookingsItemCounter), 8, 3))

            bookingsList.Add(tempBookingRecord) 'add the record to the list
        Next

        'JOBS.TXT
        Dim jobsFileHandler = New FileHandling("jobs.txt", "TEMP")
        Dim jobsRawList() As String = jobsFileHandler.GetFileContents() 'used to find the job name and prices

        For jobsItemCounter = 1 To jobsRawList.Length - 1
            Dim tempJobRecord As GlobalVariables.job
            'fetch data from corresponding job file
            tempJobRecord.ID = Trim(Mid(jobsRawList(jobsItemCounter), 1, 3))
            tempJobRecord.Name = Trim(Mid(jobsRawList(jobsItemCounter), 4, 25))
            tempJobRecord.RP = Trim(Mid(jobsRawList(jobsItemCounter), 29, 3))
            tempJobRecord.LP = Trim(Mid(jobsRawList(jobsItemCounter), 32, 3))

            jobsList.Add(tempJobRecord) 'add the record to the list
        Next

        endDateBBox.Text = Date.Now.Day & " " & MonthName(Date.Now.Month) & " " & Date.Now.Year

    End Sub

    Dim startDateA As Date, endDateA As Date, startdateB As Date, endDateB As Date, deltaDays As Integer

    Private Sub DateBox_ValueChanged(sender As Object, e As EventArgs) Handles endDateABox.ValueChanged, startDateABox.ValueChanged, startDateBBox.ValueChanged, comparatorSelectionBox.TextChanged, Me.SizeChanged
        If comparatorSelectionBox.Text = "" Then
            Return
        End If

        'get data from boxes
        startDateA = startDateABox.Value.Date
        endDateA = endDateABox.Value.Date
        deltaDays = (endDateA - startDateA).Days + 2

        startdateB = startDateBBox.Value.Date
        endDateB = startdateB.AddDays(deltaDays)
        endDateBBox.Text = endDateB.Day & " " & MonthName(endDateB.Month) & " " & endDateB.Year

        If deltaDays <= 2 Then 'error will occur if delta days is <=0
            MsgBox("Error: End date must be after start date")
            Return
        End If

        If comparatorSelectionBox.Text = "Earnings" Then
            GetValuesForGraph()
        End If

    End Sub

    Sub GetValuesForGraph()

        Dim valuesA(deltaDays) As Double
        Dim valuesB(deltaDays) As Double

        Dim maxValue As Double = 0

        For x = 0 To timetableItemsList.Count - 1

            Dim currentDate As DateTime = Convert.ToDateTime(timetableItemsList(x).week).AddDays(timetableItemsList(x).day)

            'A
            If currentDate >= startDateA And currentDate <= endDateA Then 'is timetable item valid?
                Dim daysSinceStart = (currentDate - startDateA).Days
                Dim bookingID = timetableItemsList(x).bookingID

                For y = 0 To bookingsList.Count - 1 'fine booking related to ttb item
                    If bookingsList(y).ID = bookingID Then
                        Dim jobID = bookingsList(y).jobID

                        For z = 0 To jobsList.Count - 1 'find job related to booking
                            If jobsList(z).ID = jobID Then

                                Dim price = jobsList(z).RP + (jobsList(z).LP * (timetableItemsList(x).jobLength / 60)) 'calculate earnings of ttb item
                                valuesA(daysSinceStart) += price

                                If valuesA(daysSinceStart) > maxValue Then 'keep track of the largest value, this will be the upper limit of the y axis
                                    maxValue = valuesA(daysSinceStart)
                                End If

                            End If
                        Next

                    End If
                Next

            End If

            'B (same process as A, but for the B values)
            If currentDate >= startdateB And currentDate <= endDateB Then
                Dim daysSinceStart = (currentDate - startdateB).Days
                Dim bookingID = timetableItemsList(x).bookingID

                For y = 0 To bookingsList.Count - 1
                    If bookingsList(y).ID = bookingID Then
                        Dim jobID = bookingsList(y).jobID

                        For z = 0 To jobsList.Count - 1
                            If jobsList(z).ID = jobID Then

                                Dim price = jobsList(z).RP + (jobsList(z).LP * (timetableItemsList(x).jobLength / 60))
                                valuesB(daysSinceStart) += price

                                If valuesB(daysSinceStart) > maxValue Then
                                    maxValue = valuesB(daysSinceStart)
                                End If

                            End If
                        Next

                    End If
                Next

            End If

        Next

        If (maxValue > 0) Then
            GenerateGraph(valuesA, valuesB, maxValue)
        Else
            MsgBox("No data in the given range.") 'graph is empty
        End If

    End Sub

    Dim surface As Object = CreateGraphics()
    Sub GenerateGraph(valuesA() As Double, valuesB() As Double, maxValue As Double)

        For x = 0 To labelsList.Count - 1
            labelsList(x).Dispose()
        Next

        Dim surface As Graphics = CreateGraphics()
        Me.surface.Clear(Me.BackColor)
        Me.surface = surface
        Dim penA As Pen = New Pen(Color.Blue, 2)
        Dim penB As Pen = New Pen(Color.Red, 2)
        Dim penBase As Pen = New Pen(Color.Black, 2)

        origin.Y = Me.Size.Height - 80 '61

        Dim deltaX = (Me.Size.Width - 85) / deltaDays '38
        Dim deltaY As Single = ((Me.Size.Height - 150) / maxValue) '131 not 150

        surface.DrawLine(penBase, origin.X, origin.Y, Me.Size.Width - 85, origin.Y)
        surface.DrawLine(penBase, origin.X, origin.Y, origin.X, 70)

        For x = 0 To deltaDays
            'A
            If valuesA(x) <> 0 Then

                Dim crdX As Single = origin.X + (x * deltaX)
                Dim peakY As Single = origin.Y - (valuesA(x) * deltaY)
                surface.DrawLine(penA, crdX, origin.Y, crdX, peakY)

            End If

            'B
            If valuesB(x) <> 0 Then

                Dim crdX As Single = origin.X + (x * deltaX)
                Dim peakY As Single = origin.Y - (valuesB(x) * deltaY)
                surface.DrawLine(penB, crdX, origin.Y, crdX, peakY)

            End If
        Next

        'label x axis
        For x = 0 To 5
            'maths
            Dim value = x * (deltaDays) / 5

            Dim newPosition As Point
            newPosition.X = (deltaX * value)
            newPosition.Y = origin.Y + 4

            'A
            Dim newLabelA As New Label

            newLabelA.Text = startDateA.AddDays(value - 2).Date
            newLabelA.ForeColor = Color.Blue
            newLabelA.Location = newPosition
            newLabelA.AutoSize = True
            Controls.Add(newLabelA)
            labelsList.Add(newLabelA)

            'B
            Dim newLabelB = New Label
            newPosition.Y += 20

            newLabelB.Text = startdateB.AddDays(value - 2).Date
            newLabelB.ForeColor = Color.Red
            newLabelB.Location = newPosition
            newLabelB.AutoSize = True
            Controls.Add(newLabelB)
            labelsList.Add(newLabelB)

            surface.DrawLine(penBase, newPosition.X, origin.Y + 3, newPosition.X, origin.Y - 3) 'notch
        Next

        'label y axis
        For y = 0 To 5
            'maths
            Dim multiplier = (maxValue / 5)
            Dim value As Integer = y * (maxValue / 5)

            Dim newPosition As Point
            newPosition.Y = origin.Y - (deltaY * value) - 8
            newPosition.X = 0

            'CREATE LABEL
            Dim newLabel As New Label

            newLabel.Text = "£" & y * (maxValue / 5)
            newLabel.ForeColor = Color.Black
            newLabel.Location = newPosition
            newLabel.AutoSize = True
            Controls.Add(newLabel)
            labelsList.Add(newLabel)

            surface.DrawLine(penBase, origin.X - 3, newPosition.Y + 8, origin.X + 3, newPosition.Y + 8) 'notch
        Next

    End Sub
    Dim labelsList As New List(Of Label)
End Class