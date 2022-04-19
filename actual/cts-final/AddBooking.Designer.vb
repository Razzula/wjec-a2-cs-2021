<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBooking))
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.addresslabel = New System.Windows.Forms.Label()
        Me.jobLengthLabel = New System.Windows.Forms.Label()
        Me.customerLabel = New System.Windows.Forms.Label()
        Me.customerBox = New System.Windows.Forms.ComboBox()
        Me.areaBox = New System.Windows.Forms.TextBox()
        Me.postcodeBox = New System.Windows.Forms.TextBox()
        Me.hourBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minuteBox = New System.Windows.Forms.TextBox()
        Me.jobType = New System.Windows.Forms.Label()
        Me.jobBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.errorLabel.Location = New System.Drawing.Point(97, 205)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(0, 13)
        Me.errorLabel.TabIndex = 29
        '
        'IDBox
        '
        Me.IDBox.Cursor = System.Windows.Forms.Cursors.No
        Me.IDBox.Location = New System.Drawing.Point(104, 13)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.ReadOnly = True
        Me.IDBox.Size = New System.Drawing.Size(100, 20)
        Me.IDBox.TabIndex = 2
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.BackColor = System.Drawing.SystemColors.Control
        Me.IDLabel.Location = New System.Drawing.Point(80, 16)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 13)
        Me.IDLabel.TabIndex = 1
        Me.IDLabel.Text = "ID"
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addButton.Location = New System.Drawing.Point(91, 221)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 28
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(104, 66)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.ReadOnly = True
        Me.addressBox.Size = New System.Drawing.Size(100, 20)
        Me.addressBox.TabIndex = 6
        '
        'addresslabel
        '
        Me.addresslabel.AutoSize = True
        Me.addresslabel.Location = New System.Drawing.Point(53, 69)
        Me.addresslabel.Name = "addresslabel"
        Me.addresslabel.Size = New System.Drawing.Size(45, 13)
        Me.addresslabel.TabIndex = 5
        Me.addresslabel.Text = "Address"
        '
        'jobLengthLabel
        '
        Me.jobLengthLabel.AutoSize = True
        Me.jobLengthLabel.Location = New System.Drawing.Point(38, 176)
        Me.jobLengthLabel.Name = "jobLengthLabel"
        Me.jobLengthLabel.Size = New System.Drawing.Size(60, 13)
        Me.jobLengthLabel.TabIndex = 7
        Me.jobLengthLabel.Text = "Job Length"
        '
        'customerLabel
        '
        Me.customerLabel.AutoSize = True
        Me.customerLabel.Location = New System.Drawing.Point(47, 42)
        Me.customerLabel.Name = "customerLabel"
        Me.customerLabel.Size = New System.Drawing.Size(51, 13)
        Me.customerLabel.TabIndex = 3
        Me.customerLabel.Text = "Customer"
        '
        'customerBox
        '
        Me.customerBox.BackColor = System.Drawing.SystemColors.Window
        Me.customerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customerBox.FormattingEnabled = True
        Me.customerBox.Location = New System.Drawing.Point(104, 39)
        Me.customerBox.Name = "customerBox"
        Me.customerBox.Size = New System.Drawing.Size(100, 21)
        Me.customerBox.TabIndex = 4
        '
        'areaBox
        '
        Me.areaBox.Location = New System.Drawing.Point(104, 92)
        Me.areaBox.Name = "areaBox"
        Me.areaBox.ReadOnly = True
        Me.areaBox.Size = New System.Drawing.Size(100, 20)
        Me.areaBox.TabIndex = 6
        '
        'postcodeBox
        '
        Me.postcodeBox.Location = New System.Drawing.Point(104, 118)
        Me.postcodeBox.Name = "postcodeBox"
        Me.postcodeBox.ReadOnly = True
        Me.postcodeBox.Size = New System.Drawing.Size(100, 20)
        Me.postcodeBox.TabIndex = 6
        '
        'hourBox
        '
        Me.hourBox.Location = New System.Drawing.Point(104, 171)
        Me.hourBox.Name = "hourBox"
        Me.hourBox.Size = New System.Drawing.Size(20, 20)
        Me.hourBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "m"
        '
        'minuteBox
        '
        Me.minuteBox.Location = New System.Drawing.Point(138, 171)
        Me.minuteBox.Name = "minuteBox"
        Me.minuteBox.Size = New System.Drawing.Size(20, 20)
        Me.minuteBox.TabIndex = 8
        '
        'jobType
        '
        Me.jobType.AutoSize = True
        Me.jobType.Location = New System.Drawing.Point(47, 147)
        Me.jobType.Name = "jobType"
        Me.jobType.Size = New System.Drawing.Size(51, 13)
        Me.jobType.TabIndex = 7
        Me.jobType.Text = "Job Type"
        '
        'jobBox
        '
        Me.jobBox.AutoCompleteCustomSource.AddRange(New String() {"Mowing"})
        Me.jobBox.BackColor = System.Drawing.SystemColors.Window
        Me.jobBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jobBox.FormattingEnabled = True
        Me.jobBox.Location = New System.Drawing.Point(104, 144)
        Me.jobBox.Name = "jobBox"
        Me.jobBox.Size = New System.Drawing.Size(100, 21)
        Me.jobBox.TabIndex = 8
        '
        'AddBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 256)
        Me.Controls.Add(Me.jobBox)
        Me.Controls.Add(Me.jobType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.minuteBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hourBox)
        Me.Controls.Add(Me.postcodeBox)
        Me.Controls.Add(Me.areaBox)
        Me.Controls.Add(Me.customerBox)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.addresslabel)
        Me.Controls.Add(Me.jobLengthLabel)
        Me.Controls.Add(Me.customerLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(270, 295)
        Me.MinimumSize = New System.Drawing.Size(270, 295)
        Me.Name = "AddBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents errorLabel As Label
    Friend WithEvents IDBox As TextBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents addButton As Button
    Friend WithEvents addressBox As TextBox
    Friend WithEvents addresslabel As Label
    Friend WithEvents jobLengthLabel As Label
    Friend WithEvents customerLabel As Label
    Friend WithEvents customerBox As ComboBox
    Friend WithEvents areaBox As TextBox
    Friend WithEvents postcodeBox As TextBox
    Friend WithEvents hourBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents minuteBox As TextBox
    Friend WithEvents jobType As Label
    Friend WithEvents jobBox As ComboBox
End Class
