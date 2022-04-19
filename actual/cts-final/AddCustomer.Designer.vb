<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCustomer))
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.postcodeBox = New System.Windows.Forms.TextBox()
        Me.areaLabel = New System.Windows.Forms.Label()
        Me.postcodeLabel = New System.Windows.Forms.Label()
        Me.numberBox = New System.Windows.Forms.TextBox()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.areaBox = New System.Windows.Forms.ComboBox()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(65, 46)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 3
        Me.nameLabel.Text = "Name"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(106, 43)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 20)
        Me.nameBox.TabIndex = 4
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Location = New System.Drawing.Point(55, 98)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(45, 13)
        Me.addressLabel.TabIndex = 7
        Me.addressLabel.Text = "Address"
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(106, 95)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(100, 20)
        Me.addressBox.TabIndex = 8
        '
        'postcodeBox
        '
        Me.postcodeBox.Location = New System.Drawing.Point(106, 147)
        Me.postcodeBox.Name = "postcodeBox"
        Me.postcodeBox.Size = New System.Drawing.Size(100, 20)
        Me.postcodeBox.TabIndex = 12
        '
        'areaLabel
        '
        Me.areaLabel.AutoSize = True
        Me.areaLabel.Location = New System.Drawing.Point(71, 124)
        Me.areaLabel.Name = "areaLabel"
        Me.areaLabel.Size = New System.Drawing.Size(29, 13)
        Me.areaLabel.TabIndex = 9
        Me.areaLabel.Text = "Area"
        '
        'postcodeLabel
        '
        Me.postcodeLabel.AutoSize = True
        Me.postcodeLabel.Location = New System.Drawing.Point(48, 150)
        Me.postcodeLabel.Name = "postcodeLabel"
        Me.postcodeLabel.Size = New System.Drawing.Size(52, 13)
        Me.postcodeLabel.TabIndex = 11
        Me.postcodeLabel.Text = "Postcode"
        '
        'numberBox
        '
        Me.numberBox.Location = New System.Drawing.Point(106, 69)
        Me.numberBox.Name = "numberBox"
        Me.numberBox.Size = New System.Drawing.Size(100, 20)
        Me.numberBox.TabIndex = 6
        '
        'numberLabel
        '
        Me.numberLabel.AutoSize = True
        Me.numberLabel.Location = New System.Drawing.Point(22, 72)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(78, 13)
        Me.numberLabel.TabIndex = 5
        Me.numberLabel.Text = "Phone Number"
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addButton.Location = New System.Drawing.Point(85, 195)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 13
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'IDBox
        '
        Me.IDBox.Cursor = System.Windows.Forms.Cursors.No
        Me.IDBox.Location = New System.Drawing.Point(106, 17)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.ReadOnly = True
        Me.IDBox.Size = New System.Drawing.Size(100, 20)
        Me.IDBox.TabIndex = 2
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.BackColor = System.Drawing.SystemColors.Control
        Me.IDLabel.Location = New System.Drawing.Point(82, 20)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 13)
        Me.IDLabel.TabIndex = 1
        Me.IDLabel.Text = "ID"
        '
        'areaBox
        '
        Me.areaBox.BackColor = System.Drawing.SystemColors.Window
        Me.areaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.areaBox.FormattingEnabled = True
        Me.areaBox.Items.AddRange(New Object() {"Borras", "Brymbo", "Marford", "Gresford"})
        Me.areaBox.Location = New System.Drawing.Point(106, 121)
        Me.areaBox.Name = "areaBox"
        Me.areaBox.Size = New System.Drawing.Size(100, 21)
        Me.areaBox.TabIndex = 10
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.errorLabel.Location = New System.Drawing.Point(91, 179)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(0, 13)
        Me.errorLabel.TabIndex = 15
        '
        'AddCustomer
        '
        Me.AcceptButton = Me.addButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 226)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.areaBox)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.numberBox)
        Me.Controls.Add(Me.numberLabel)
        Me.Controls.Add(Me.postcodeLabel)
        Me.Controls.Add(Me.areaLabel)
        Me.Controls.Add(Me.postcodeBox)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.nameBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(262, 265)
        Me.MinimumSize = New System.Drawing.Size(262, 265)
        Me.Name = "AddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Add Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents addressBox As TextBox
    Friend WithEvents postcodeBox As TextBox
    Friend WithEvents areaLabel As Label
    Friend WithEvents postcodeLabel As Label
    Friend WithEvents numberBox As TextBox
    Friend WithEvents numberLabel As Label
    Friend WithEvents addButton As Button
    Friend WithEvents IDBox As TextBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents areaBox As ComboBox
    Friend WithEvents errorLabel As Label
End Class
