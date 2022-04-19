Imports System.IO

Public Class TimetableCalculations

    Dim BookingList As New List(Of GlobalVariables.booking), tempBookingList As New List(Of GlobalVariables.booking), finalTimetable As New List(Of GlobalVariables.timetableItem)
    Dim areas = New String(3) {"Borras", "Brymbo", "Marford", "Gresford"} 'IDENTIFIER OF BELOW ARRAY
    Dim distances = New Integer(3, 3) {{999, 13, 10, 9}, {14, 999, 15, 14}, {10, 15, 999, 5}, {7, 14, 5, 999}} 'HARD CODED TABLE OF DISTANCES BETWEEN AREAS

    Dim ID As Integer = 1

    Sub GenerateTimetable()

        Dim bookingsFileHandler = New FileHandling("bookings.txt", "ID cID jID Len Day Start")
        Dim customersFileHandler = New FileHandling("customers.txt", "ID NAME                     PONUMBER   ADDRESS                  AREA        POSTCODE")

        'load data 
        Dim BookingData() As String = bookingsFileHandler.GetFileContents()
        Dim CustomerData() As String = customersFileHandler.GetFileContents()

        For bookingsCounter = 1 To BookingData.Count - 1
            Dim temprecord As GlobalVariables.booking
            'read data from booking file
            temprecord.ID = Trim(Mid(BookingData(bookingsCounter), 1, 3))
            temprecord.customerID = Trim(Mid(BookingData(bookingsCounter), 4, 3))
            temprecord.jobID = Trim(Mid(BookingData(bookingsCounter), 8, 3))
            temprecord.jobLength = Trim(Mid(BookingData(bookingsCounter), 12, 3))

            'search customer file for customerID
            For customersCounter = 1 To CustomerData.Count - 1
                If Trim(Mid(CustomerData(customersCounter), 1, 3)) = temprecord.customerID Then
                    'fetch data from corresponding customer file
                    temprecord.area = Trim(Mid(CustomerData(customersCounter), 65, 12))
                    temprecord.postcode = Trim(Mid(CustomerData(customersCounter), 77, 7))

                End If
            Next

            BookingList.Add(temprecord) 'add the record to the list
        Next

        'find first area
        Dim initialArea As String = BookingList(0).area 'CHANGE THIS TO "Wrexham" WHEN WREXHAM IS ADDED TO LIST

        'SORT data
        Sort(initialArea) 'will recurse until whole booking list is grouped and sorted

        'SLOT data into timetable slots
        currentArea = initialArea 'set initial area
        distances = {{999, 13, 10, 9}, {14, 999, 15, 14}, {10, 15, 999, 5}, {7, 14, 5, 999}} 'reform the now nullified distances array 'TEMP

        For x = 0 To tempBookingList.Count - 1
            currentJobLength = Convert.ToInt16(tempBookingList(x).jobLength) 'required for calculations
            DriveTimeSpacer(x)
            LunchOverlapCheck(x)
            DayOverlapCheck(x)
            CreateItem(x, currentJobLength)
        Next

        'store back into file
        Dim timetableFileHandler = New FileHandling("timetable.txt", "ID bID Day Srt Len")
        Dim tempBooking As GlobalVariables.timetableItem

        timetableFileHandler.ClearFile() 'wipe file

        For x = 0 To finalTimetable.Count - 1

            tempBooking.ID = LSet(finalTimetable(x).ID, 3)
            tempBooking.bookingID = LSet(finalTimetable(x).bookingID, 4)
            tempBooking.day = LSet(finalTimetable(x).day, 4)
            tempBooking.startTime = LSet(finalTimetable(x).startTime, 4)
            tempBooking.jobLength = finalTimetable(x).jobLength

            timetableFileHandler.WriteLineToFile(tempBooking.ID & tempBooking.bookingID & tempBooking.day & tempBooking.startTime & tempBooking.jobLength)
        Next

        'MsgBox("Timetable successfully generated.") 'TEMP

    End Sub

    Private Sub Sort(currentArea As String) 'this function sorts the BookingList two-fold, grouping the bookings by area recursively, and then sorting the bookings by postcode, within their groupings

        'FIND ALL OF CURRENT AREA
        Dim tempList As New List(Of GlobalVariables.booking)

        Dim x As Integer, listLength = BookingList.Count
        While x < listLength

            If BookingList(x).area = currentArea Then
                tempList.Add(BookingList(x))

                BookingList.Remove(BookingList(x)) 'remove from temp list to prevent re-checking it in later recursions
                x -= 1
                listLength -= 1
            End If

            x += 1
        End While

        'ORDER TEMP LIST BASED OFF OF POSTCODES
        'bubble sort
        Dim flag = True
        While flag = True 'repeat until sorted
            flag = False

            For x = 0 To tempList.Count - 2 'run through whole list

                If tempList(x).postcode > tempList(x + 1).postcode Then 'compare each item
                    Dim temp = tempList(x)
                    tempList(x) = tempList(x + 1)
                    tempList(x + 1) = temp

                    flag = True
                End If
            Next
        End While

        'ADD TEMP LIST TO NEW LIST
        'unload data
        For x = 0 To tempList.Count - 1 'run through whole list

            tempBookingList.Add(tempList(x))

        Next

        'FIND NEAREST AREA
        'search array for current area
        Dim counter = 0
        flag = False
        While flag = False

            If areas(counter) = currentArea Then
                flag = True
            Else
                counter += 1
            End If

        End While
        'search current area for lowest distance
        Dim lowestValue = 999, y = 0
        For x = 0 To 3

            If distances(counter, x) < lowestValue Then
                lowestValue = distances(counter, x)
                y = x
            End If

            'remove current area from list, to prevent double-bookings
            distances(counter, x) = 999
            distances(x, counter) = 999

        Next
        'locate name of nearest area
        If lowestValue = 999 Then 'all areas have been nullified, meaning they are already sorted
            'MsgBox("Bookings sorted") 'TEMP
        Else
            Dim nextArea = areas(y)
            Sort(nextArea) 'recursion, sort nearest area
        End If

    End Sub

    Dim currentBooking As GlobalVariables.timetableItem
    Dim startTime As Integer, endTime As Integer 'time is in minutes, with 0 = 08:00, (600 = 15:00)
    Dim day = 0, currentJobLength As Integer '0 = Monday, (4 = Friday)
    Dim paddingTEMP As Integer

    Dim currentArea As String
    Sub DriveTimeSpacer(x As Integer)

        'if change of area occurs
        If tempBookingList(x).area = currentArea Then
        Else

            'find distance between old and new areas
            Dim newArea = tempBookingList(x).area
            Dim distancesX As Integer, distancesY As Integer

            For areasCounter = 0 To areas.Length - 1

                If areas(areasCounter) = currentArea Then
                    distancesX = areasCounter
                ElseIf areas(areasCounter) = newArea Then
                    distancesY = areasCounter
                End If

            Next

            'add driving time to timetable
            Dim distance = distances(distancesX, distancesY)
            endTime += Math.Ceiling(distance / 5) * 5 'round UP to nearest 5, add to endtime (just to make it nicer on the timetable)
            currentArea = newArea
        End If

    End Sub

    Sub LunchOverlapCheck(x As Integer)

        If endTime < 240 And endTime + currentJobLength > 240 Then 'if overlaps with lunch break
            If endTime + currentJobLength - 240 <= 30 Then 'if small overlap

                'add hour gap after booking
                paddingTEMP = 60

            Else

                'split
                Dim partOneLength = 240 - endTime

                CreateItem(x, partOneLength)

                currentJobLength -= partOneLength
                endTime += 60

                DayOverlapCheck(x)

            End If

        ElseIf endTime = 240 Then

            endTime += 60

        End If

    End Sub

    Sub DayOverlapCheck(x As Integer)

        If endTime + currentJobLength > 600 Then 'if job does not fit into current day
            If (endTime + currentJobLength - 600 > 30) And (endTime < 570) Then 'if large overlap 'IF OVERHANG >30 AND UNDERHANG >30

                'split
                Dim partOneLength = 600 - endTime

                CreateItem(x, partOneLength)

                currentJobLength -= partOneLength
                day += 1
                endTime = 0

            Else

                day += 1
                endTime = 0

            End If

            LunchOverlapCheck(x)

            'If day > 4 Then 'TEMP
            'MsgBox("Error: Ran out of days.")
            'Return
            'End If

        End If

    End Sub

    Sub CreateItem(x As Integer, jobLength As Integer)

        'create timetable item
        startTime = endTime

        currentBooking.ID = ID
        currentBooking.bookingID = tempBookingList(x).ID
        currentBooking.day = day
        currentBooking.startTime = startTime
        currentBooking.jobLength = jobLength 'remains same unless split has occured

        finalTimetable.Add(currentBooking) 'loads the now sorted and timestamped items back into the original list

        endTime = startTime + jobLength + paddingTEMP
        paddingTEMP = 0
        ID += 1

    End Sub

End Class