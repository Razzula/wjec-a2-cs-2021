<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewTimetable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTimetable))
        Me.printButton = New System.Windows.Forms.Button()
        Me.completedButton = New System.Windows.Forms.Button()
        Me.dayCompletedButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dayBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.endTimeBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startTimeBox = New System.Windows.Forms.TextBox()
        Me.postcodeBox = New System.Windows.Forms.TextBox()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.areaBox = New System.Windows.Forms.TextBox()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jobBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.priceBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.mondayLabel = New System.Windows.Forms.Label()
        Me.tuesdayLabel = New System.Windows.Forms.Label()
        Me.wednesddayLabel = New System.Windows.Forms.Label()
        Me.thursdayLabel = New System.Windows.Forms.Label()
        Me.fridayLabel = New System.Windows.Forms.Label()
        Me.earnedLabel = New System.Windows.Forms.Label()
        Me.projectedEarningsLabel = New System.Windows.Forms.Label()
        Me.earningsBox = New System.Windows.Forms.TextBox()
        Me.projectedEarningsBox = New System.Windows.Forms.TextBox()
        Me.timetableDsiplay = New cts_alpha.Timetable()
        Me.SuspendLayout()
        '
        'printButton
        '
        Me.printButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printButton.Enabled = False
        Me.printButton.Location = New System.Drawing.Point(987, 900)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 1
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'completedButton
        '
        Me.completedButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.completedButton.Enabled = False
        Me.completedButton.Location = New System.Drawing.Point(837, 260)
        Me.completedButton.Name = "completedButton"
        Me.completedButton.Size = New System.Drawing.Size(102, 31)
        Me.completedButton.TabIndex = 2
        Me.completedButton.Text = "Job Completed"
        Me.completedButton.UseVisualStyleBackColor = True
        '
        'dayCompletedButton
        '
        Me.dayCompletedButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dayCompletedButton.Enabled = False
        Me.dayCompletedButton.Location = New System.Drawing.Point(945, 260)
        Me.dayCompletedButton.Name = "dayCompletedButton"
        Me.dayCompletedButton.Size = New System.Drawing.Size(102, 31)
        Me.dayCompletedButton.TabIndex = 3
        Me.dayCompletedButton.Text = "Day Completed"
        Me.dayCompletedButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(866, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Day:"
        '
        'dayBox
        '
        Me.dayBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dayBox.Location = New System.Drawing.Point(901, 200)
        Me.dayBox.Name = "dayBox"
        Me.dayBox.ReadOnly = True
        Me.dayBox.Size = New System.Drawing.Size(100, 20)
        Me.dayBox.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(862, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Time:"
        '
        'endTimeBox
        '
        Me.endTimeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.endTimeBox.Location = New System.Drawing.Point(960, 219)
        Me.endTimeBox.Name = "endTimeBox"
        Me.endTimeBox.ReadOnly = True
        Me.endTimeBox.Size = New System.Drawing.Size(38, 20)
        Me.endTimeBox.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(942, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "to"
        '
        'startTimeBox
        '
        Me.startTimeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startTimeBox.Location = New System.Drawing.Point(901, 219)
        Me.startTimeBox.Name = "startTimeBox"
        Me.startTimeBox.ReadOnly = True
        Me.startTimeBox.Size = New System.Drawing.Size(38, 20)
        Me.startTimeBox.TabIndex = 73
        '
        'postcodeBox
        '
        Me.postcodeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.postcodeBox.Location = New System.Drawing.Point(901, 129)
        Me.postcodeBox.Name = "postcodeBox"
        Me.postcodeBox.ReadOnly = True
        Me.postcodeBox.Size = New System.Drawing.Size(161, 20)
        Me.postcodeBox.TabIndex = 72
        '
        'addressBox
        '
        Me.addressBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addressBox.Location = New System.Drawing.Point(901, 91)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.ReadOnly = True
        Me.addressBox.Size = New System.Drawing.Size(161, 20)
        Me.addressBox.TabIndex = 70
        '
        'passwordLabel
        '
        Me.passwordLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(847, 94)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(48, 13)
        Me.passwordLabel.TabIndex = 69
        Me.passwordLabel.Text = "Address:"
        '
        'areaBox
        '
        Me.areaBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.areaBox.Location = New System.Drawing.Point(901, 110)
        Me.areaBox.Name = "areaBox"
        Me.areaBox.ReadOnly = True
        Me.areaBox.Size = New System.Drawing.Size(161, 20)
        Me.areaBox.TabIndex = 71
        '
        'usernameLabel
        '
        Me.usernameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(841, 68)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(54, 13)
        Me.usernameLabel.TabIndex = 67
        Me.usernameLabel.Text = "Customer:"
        '
        'nameBox
        '
        Me.nameBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameBox.Location = New System.Drawing.Point(901, 65)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.ReadOnly = True
        Me.nameBox.Size = New System.Drawing.Size(161, 20)
        Me.nameBox.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(868, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Job:"
        '
        'jobBox
        '
        Me.jobBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jobBox.Location = New System.Drawing.Point(901, 155)
        Me.jobBox.Name = "jobBox"
        Me.jobBox.ReadOnly = True
        Me.jobBox.Size = New System.Drawing.Size(161, 20)
        Me.jobBox.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(861, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Price: £"
        '
        'priceBox
        '
        Me.priceBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.priceBox.Location = New System.Drawing.Point(901, 174)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.ReadOnly = True
        Me.priceBox.Size = New System.Drawing.Size(38, 20)
        Me.priceBox.TabIndex = 86
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(826, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(236, 20)
        Me.DateTimePicker1.TabIndex = 88
        '
        'mondayLabel
        '
        Me.mondayLabel.AutoSize = True
        Me.mondayLabel.Location = New System.Drawing.Point(95, 2)
        Me.mondayLabel.Name = "mondayLabel"
        Me.mondayLabel.Size = New System.Drawing.Size(65, 13)
        Me.mondayLabel.TabIndex = 89
        Me.mondayLabel.Text = "dd/mm/yyyy"
        '
        'tuesdayLabel
        '
        Me.tuesdayLabel.AutoSize = True
        Me.tuesdayLabel.Location = New System.Drawing.Point(247, 2)
        Me.tuesdayLabel.Name = "tuesdayLabel"
        Me.tuesdayLabel.Size = New System.Drawing.Size(65, 13)
        Me.tuesdayLabel.TabIndex = 90
        Me.tuesdayLabel.Text = "dd/mm/yyyy"
        '
        'wednesddayLabel
        '
        Me.wednesddayLabel.AutoSize = True
        Me.wednesddayLabel.Location = New System.Drawing.Point(398, 2)
        Me.wednesddayLabel.Name = "wednesddayLabel"
        Me.wednesddayLabel.Size = New System.Drawing.Size(65, 13)
        Me.wednesddayLabel.TabIndex = 91
        Me.wednesddayLabel.Text = "dd/mm/yyyy"
        '
        'thursdayLabel
        '
        Me.thursdayLabel.AutoSize = True
        Me.thursdayLabel.Location = New System.Drawing.Point(546, 2)
        Me.thursdayLabel.Name = "thursdayLabel"
        Me.thursdayLabel.Size = New System.Drawing.Size(65, 13)
        Me.thursdayLabel.TabIndex = 92
        Me.thursdayLabel.Text = "dd/mm/yyyy"
        '
        'fridayLabel
        '
        Me.fridayLabel.AutoSize = True
        Me.fridayLabel.Location = New System.Drawing.Point(701, 2)
        Me.fridayLabel.Name = "fridayLabel"
        Me.fridayLabel.Size = New System.Drawing.Size(65, 13)
        Me.fridayLabel.TabIndex = 93
        Me.fridayLabel.Text = "dd/mm/yyyy"
        '
        'earnedLabel
        '
        Me.earnedLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.earnedLabel.AutoSize = True
        Me.earnedLabel.Location = New System.Drawing.Point(841, 325)
        Me.earnedLabel.Name = "earnedLabel"
        Me.earnedLabel.Size = New System.Drawing.Size(60, 13)
        Me.earnedLabel.TabIndex = 94
        Me.earnedLabel.Text = "Earnings: £"
        '
        'projectedEarningsLabel
        '
        Me.projectedEarningsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.projectedEarningsLabel.AutoSize = True
        Me.projectedEarningsLabel.Location = New System.Drawing.Point(837, 351)
        Me.projectedEarningsLabel.Name = "projectedEarningsLabel"
        Me.projectedEarningsLabel.Size = New System.Drawing.Size(64, 13)
        Me.projectedEarningsLabel.TabIndex = 96
        Me.projectedEarningsLabel.Text = "Projected: £"
        '
        'earningsBox
        '
        Me.earningsBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.earningsBox.Location = New System.Drawing.Point(901, 322)
        Me.earningsBox.Name = "earningsBox"
        Me.earningsBox.ReadOnly = True
        Me.earningsBox.Size = New System.Drawing.Size(38, 20)
        Me.earningsBox.TabIndex = 97
        '
        'projectedEarningsBox
        '
        Me.projectedEarningsBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.projectedEarningsBox.Location = New System.Drawing.Point(901, 348)
        Me.projectedEarningsBox.Name = "projectedEarningsBox"
        Me.projectedEarningsBox.ReadOnly = True
        Me.projectedEarningsBox.Size = New System.Drawing.Size(38, 20)
        Me.projectedEarningsBox.TabIndex = 98
        '
        'timetableDsiplay
        '
        Me.timetableDsiplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.timetableDsiplay.Location = New System.Drawing.Point(-2, -2)
        Me.timetableDsiplay.Name = "timetableDsiplay"
        Me.timetableDsiplay.Size = New System.Drawing.Size(822, 938)
        Me.timetableDsiplay.TabIndex = 0
        '
        'ViewTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 933)
        Me.Controls.Add(Me.projectedEarningsBox)
        Me.Controls.Add(Me.earningsBox)
        Me.Controls.Add(Me.projectedEarningsLabel)
        Me.Controls.Add(Me.earnedLabel)
        Me.Controls.Add(Me.fridayLabel)
        Me.Controls.Add(Me.thursdayLabel)
        Me.Controls.Add(Me.wednesddayLabel)
        Me.Controls.Add(Me.tuesdayLabel)
        Me.Controls.Add(Me.mondayLabel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.jobBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dayBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.endTimeBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.startTimeBox)
        Me.Controls.Add(Me.postcodeBox)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.areaBox)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.dayCompletedButton)
        Me.Controls.Add(Me.completedButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.timetableDsiplay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1090, 726)
        Me.Name = "ViewTimetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timetable - dd/mm/yyyy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timetableDsiplay As Timetable
    Friend WithEvents printButton As Button
    Friend WithEvents completedButton As Button
    Friend WithEvents dayCompletedButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dayBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents endTimeBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents startTimeBox As TextBox
    Friend WithEvents postcodeBox As TextBox
    Friend WithEvents addressBox As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents areaBox As TextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents jobBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents priceBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents mondayLabel As Label
    Friend WithEvents tuesdayLabel As Label
    Friend WithEvents wednesddayLabel As Label
    Friend WithEvents thursdayLabel As Label
    Friend WithEvents fridayLabel As Label
    Friend WithEvents earnedLabel As Label
    Friend WithEvents projectedEarningsLabel As Label
    Friend WithEvents earningsBox As TextBox
    Friend WithEvents projectedEarningsBox As TextBox
End Class
