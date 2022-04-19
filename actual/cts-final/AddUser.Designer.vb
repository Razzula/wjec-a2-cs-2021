<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.accessLevelBox = New System.Windows.Forms.ComboBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.accessLevelLabel = New System.Windows.Forms.Label()
        Me.passwordBox2 = New System.Windows.Forms.TextBox()
        Me.passwordlabel2 = New System.Windows.Forms.Label()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.usernameBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.errorLabel.Location = New System.Drawing.Point(77, 152)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(0, 13)
        Me.errorLabel.TabIndex = 29
        '
        'accessLevelBox
        '
        Me.accessLevelBox.BackColor = System.Drawing.SystemColors.Window
        Me.accessLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.accessLevelBox.FormattingEnabled = True
        Me.accessLevelBox.Items.AddRange(New Object() {"Admin", "User"})
        Me.accessLevelBox.Location = New System.Drawing.Point(91, 102)
        Me.accessLevelBox.Name = "accessLevelBox"
        Me.accessLevelBox.Size = New System.Drawing.Size(100, 21)
        Me.accessLevelBox.TabIndex = 10
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addButton.Location = New System.Drawing.Point(71, 168)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 11
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'passwordBox
        '
        Me.passwordBox.Location = New System.Drawing.Point(91, 50)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(100, 20)
        Me.passwordBox.TabIndex = 6
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(32, 53)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(53, 13)
        Me.passwordLabel.TabIndex = 5
        Me.passwordLabel.Text = "Password"
        '
        'accessLevelLabel
        '
        Me.accessLevelLabel.AutoSize = True
        Me.accessLevelLabel.Location = New System.Drawing.Point(14, 105)
        Me.accessLevelLabel.Name = "accessLevelLabel"
        Me.accessLevelLabel.Size = New System.Drawing.Size(71, 13)
        Me.accessLevelLabel.TabIndex = 9
        Me.accessLevelLabel.Text = "Access Level"
        '
        'passwordBox2
        '
        Me.passwordBox2.Location = New System.Drawing.Point(91, 76)
        Me.passwordBox2.Name = "passwordBox2"
        Me.passwordBox2.Size = New System.Drawing.Size(100, 20)
        Me.passwordBox2.TabIndex = 8
        '
        'passwordlabel2
        '
        Me.passwordlabel2.AutoSize = True
        Me.passwordlabel2.Location = New System.Drawing.Point(32, 79)
        Me.passwordlabel2.Name = "passwordlabel2"
        Me.passwordlabel2.Size = New System.Drawing.Size(53, 13)
        Me.passwordlabel2.TabIndex = 7
        Me.passwordlabel2.Text = "Password"
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(30, 27)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.usernameLabel.TabIndex = 3
        Me.usernameLabel.Text = "Username"
        '
        'usernameBox
        '
        Me.usernameBox.Location = New System.Drawing.Point(91, 24)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(100, 20)
        Me.usernameBox.TabIndex = 4
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 206)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.accessLevelBox)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.accessLevelLabel)
        Me.Controls.Add(Me.passwordBox2)
        Me.Controls.Add(Me.passwordlabel2)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.usernameBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(235, 245)
        Me.MinimumSize = New System.Drawing.Size(235, 245)
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents errorLabel As Label
    Friend WithEvents accessLevelBox As ComboBox
    Friend WithEvents addButton As Button
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents accessLevelLabel As Label
    Friend WithEvents passwordBox2 As TextBox
    Friend WithEvents passwordlabel2 As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents usernameBox As TextBox
End Class
