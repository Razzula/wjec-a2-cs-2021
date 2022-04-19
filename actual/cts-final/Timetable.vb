Public Class Timetable

    Dim overflowID As Integer = 1

    Sub DisplayTimetableItem(timetableItem As GlobalVariables.timetableItem, customer As GlobalVariables.customer, job As GlobalVariables.job, viewTimetableForm As ViewTimetable)

        'CALCULATE SIZE AND CO-ORDS OF BUTTON, INSTANTIATE BUTTON

        Dim button = New TimetableButton 'instantiate button control
        Dim buttonSize As Size, buttonLocation As Point

        Dim jobLength = Convert.ToInt16(timetableItem.jobLength)
        Dim startTime = Convert.ToInt16(timetableItem.startTime)
        Dim day = Convert.ToInt16(timetableItem.day)

        buttonSize.Width = 152
        buttonSize.Height = 22 * (jobLength / 15)

        buttonLocation.X = 48 + (day * 150)
        buttonLocation.Y = 42 + (22 * (startTime / 15))

        Dim buttonText As String
        If buttonSize.Height <= 22 Then
            buttonText = customer.Name & StrDup(overflowID, "*")
            overflowBox.Text = overflowBox.Text & StrDup(overflowID, "*") & vbNewLine & customer.Name & vbNewLine & customer.Address & vbNewLine & customer.Area & ", " & customer.Postcode & vbNewLine & vbNewLine

            overflowID += 1
        Else
            buttonText = customer.Name & vbNewLine & customer.Address & vbNewLine & customer.Area & ", " & customer.Postcode
        End If

        button.SetButtonProperties(buttonText, buttonSize, buttonLocation, timetableItem, customer, job) 'initialise button

        Controls.Add(button) 'add button to form

        ViewTimetable.newButtonCreated(button)

    End Sub

    Sub ResetOverflowID()
        overflowID = 1
    End Sub
End Class
