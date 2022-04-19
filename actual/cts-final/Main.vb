Public Class Main

    Public Sub SetAccessLevel(accessLevel As String, username As String)
        If accessLevel = "Admin" Then 'if admin
            Me.Text += " (Admin)" 'update form title
        Else
            'remove/disable admin-only buttons
            managefilesButton.Dispose()
            graphButton.Dispose()
            userNavigateButton.Enabled = False
        End If
        greetingLabel.Text += username
    End Sub

    Private Sub CustomerNavigateButton_Click(sender As Object, e As EventArgs) Handles customerNavigateButton.Click

        AddCustomer.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim timetableCalculator As TimetableCalculations
        timetableCalculator = New TimetableCalculations
        timetableCalculator.GenerateTimetable()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles userNavigateButton.Click

        AddUser.Show()

    End Sub

    Private Sub BookingNavigateButton_Click(sender As Object, e As EventArgs) Handles bookingNavigateButton.Click

        AddBooking.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ViewTimetable.Show()

    End Sub

    Private Sub managefilesButton_Click(sender As Object, e As EventArgs) Handles managefilesButton.Click

        ManageFiles.Show()

    End Sub

    Private Sub addMaterialButton_Click(sender As Object, e As EventArgs) Handles addMaterialButton.Click

        AddMaterial.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        AddJob.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles graphButton.Click

        Graph.Show()

    End Sub
End Class
