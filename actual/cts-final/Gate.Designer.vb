<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gate))
        Me.usernameBox = New System.Windows.Forms.TextBox()
        Me.passwordBox = New System.Windows.Forms.MaskedTextBox()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usernameBox
        '
        Me.usernameBox.Location = New System.Drawing.Point(106, 25)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(100, 20)
        Me.usernameBox.TabIndex = 0
        '
        'passwordBox
        '
        Me.passwordBox.Location = New System.Drawing.Point(106, 51)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordBox.Size = New System.Drawing.Size(100, 20)
        Me.passwordBox.TabIndex = 1
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(45, 28)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.usernameLabel.TabIndex = 2
        Me.usernameLabel.Text = "Username:"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(45, 54)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(56, 13)
        Me.passwordLabel.TabIndex = 3
        Me.passwordLabel.Text = "Password:"
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(96, 101)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 23)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.errorLabel.Location = New System.Drawing.Point(46, 85)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(0, 13)
        Me.errorLabel.TabIndex = 5
        '
        'Gate
        '
        Me.AcceptButton = Me.loginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 142)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.usernameBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(288, 181)
        Me.MinimumSize = New System.Drawing.Size(288, 181)
        Me.Name = "Gate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernameBox As TextBox
    Friend WithEvents passwordBox As MaskedTextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents loginButton As Button
    Friend WithEvents errorLabel As Label
End Class
