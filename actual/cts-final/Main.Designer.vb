<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.customerNavigateButton = New System.Windows.Forms.Button()
        Me.userNavigateButton = New System.Windows.Forms.Button()
        Me.bookingNavigateButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.managefilesButton = New System.Windows.Forms.Button()
        Me.addMaterialButton = New System.Windows.Forms.Button()
        Me.graphButton = New System.Windows.Forms.Button()
        Me.greetingLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'customerNavigateButton
        '
        Me.customerNavigateButton.BackColor = System.Drawing.SystemColors.Control
        Me.customerNavigateButton.Location = New System.Drawing.Point(71, 312)
        Me.customerNavigateButton.Name = "customerNavigateButton"
        Me.customerNavigateButton.Size = New System.Drawing.Size(82, 23)
        Me.customerNavigateButton.TabIndex = 1
        Me.customerNavigateButton.Text = "Add Customer"
        Me.customerNavigateButton.UseVisualStyleBackColor = False
        '
        'userNavigateButton
        '
        Me.userNavigateButton.BackColor = System.Drawing.SystemColors.Control
        Me.userNavigateButton.Location = New System.Drawing.Point(247, 312)
        Me.userNavigateButton.Name = "userNavigateButton"
        Me.userNavigateButton.Size = New System.Drawing.Size(67, 23)
        Me.userNavigateButton.TabIndex = 3
        Me.userNavigateButton.Text = "Add User"
        Me.userNavigateButton.UseVisualStyleBackColor = False
        '
        'bookingNavigateButton
        '
        Me.bookingNavigateButton.BackColor = System.Drawing.SystemColors.Control
        Me.bookingNavigateButton.Location = New System.Drawing.Point(159, 312)
        Me.bookingNavigateButton.Name = "bookingNavigateButton"
        Me.bookingNavigateButton.Size = New System.Drawing.Size(82, 23)
        Me.bookingNavigateButton.TabIndex = 4
        Me.bookingNavigateButton.Text = "Add Booking"
        Me.bookingNavigateButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(135, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Create Quote"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(235, 283)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "View Timetable"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'managefilesButton
        '
        Me.managefilesButton.Location = New System.Drawing.Point(-1, -1)
        Me.managefilesButton.Name = "managefilesButton"
        Me.managefilesButton.Size = New System.Drawing.Size(94, 23)
        Me.managefilesButton.TabIndex = 9
        Me.managefilesButton.Text = "Manage Files"
        Me.managefilesButton.UseVisualStyleBackColor = True
        '
        'addMaterialButton
        '
        Me.addMaterialButton.BackColor = System.Drawing.SystemColors.Control
        Me.addMaterialButton.Location = New System.Drawing.Point(320, 312)
        Me.addMaterialButton.Name = "addMaterialButton"
        Me.addMaterialButton.Size = New System.Drawing.Size(86, 23)
        Me.addMaterialButton.TabIndex = 10
        Me.addMaterialButton.Text = "Add Material"
        Me.addMaterialButton.UseVisualStyleBackColor = False
        '
        'graphButton
        '
        Me.graphButton.Location = New System.Drawing.Point(91, -1)
        Me.graphButton.Name = "graphButton"
        Me.graphButton.Size = New System.Drawing.Size(94, 23)
        Me.graphButton.TabIndex = 11
        Me.graphButton.Text = "Graphs"
        Me.graphButton.UseVisualStyleBackColor = True
        '
        'greetingLabel
        '
        Me.greetingLabel.Location = New System.Drawing.Point(0, 135)
        Me.greetingLabel.Name = "greetingLabel"
        Me.greetingLabel.Size = New System.Drawing.Size(482, 13)
        Me.greetingLabel.TabIndex = 13
        Me.greetingLabel.Text = "Welcome "
        Me.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(482, 347)
        Me.Controls.Add(Me.greetingLabel)
        Me.Controls.Add(Me.graphButton)
        Me.Controls.Add(Me.addMaterialButton)
        Me.Controls.Add(Me.managefilesButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bookingNavigateButton)
        Me.Controls.Add(Me.userNavigateButton)
        Me.Controls.Add(Me.customerNavigateButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(498, 386)
        Me.MinimumSize = New System.Drawing.Size(498, 386)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carrick Technical Solutions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents customerNavigateButton As Button
    Friend WithEvents userNavigateButton As Button
    Friend WithEvents bookingNavigateButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents managefilesButton As Button
    Friend WithEvents addMaterialButton As Button
    Friend WithEvents graphButton As Button
    Friend WithEvents greetingLabel As Label
End Class
