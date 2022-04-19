Public Class TimetableButton

    Dim bookingData As GlobalVariables.timetableItem, customerData As GlobalVariables.customer, jobData As GlobalVariables.job

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button.Click

        ViewTimetable.UpdateFields(bookingData, customerData, jobData)

    End Sub

    Sub SetButtonProperties(text As String, size As Size, position As Point, bookingData As GlobalVariables.timetableItem, customerData As GlobalVariables.customer, jobData As GlobalVariables.job)

        'object properties
        Me.Size = size
        button.Size = size

        Me.Location = position

        button.Text = text

        If customerData.Name = "Not Found" Then
            button.Text = "Not Found"
            button.ForeColor = Color.Red
            button.Enabled = False
            Return
        End If

        'data for click event
        Me.bookingData = bookingData
        Me.customerData = customerData
        Me.jobData = jobData

        Dim currentWeek As String = Now.Date
        If bookingData.week <> "" Then
            If bookingData.week <= currentWeek Then
                button.ForeColor = Color.Gray
            End If
        End If

    End Sub

End Class
