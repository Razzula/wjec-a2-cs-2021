<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMaterial))
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.typeLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.priceBox = New System.Windows.Forms.TextBox()
        Me.unitTypeLabel = New System.Windows.Forms.Label()
        Me.typeBox = New System.Windows.Forms.ComboBox()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(53, 27)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 13)
        Me.IDLabel.TabIndex = 1
        Me.IDLabel.Text = "ID"
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(77, 24)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.ReadOnly = True
        Me.IDBox.Size = New System.Drawing.Size(100, 20)
        Me.IDBox.TabIndex = 2
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(33, 53)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(38, 13)
        Me.nameLabel.TabIndex = 3
        Me.nameLabel.Text = "Name:"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(77, 50)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 20)
        Me.nameBox.TabIndex = 4
        '
        'typeLabel
        '
        Me.typeLabel.AutoSize = True
        Me.typeLabel.Location = New System.Drawing.Point(37, 79)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(34, 13)
        Me.typeLabel.TabIndex = 5
        Me.typeLabel.Text = "Type:"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(28, 105)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(49, 13)
        Me.priceLabel.TabIndex = 7
        Me.priceLabel.Text = "Price:   £"
        '
        'priceBox
        '
        Me.priceBox.Enabled = False
        Me.priceBox.Location = New System.Drawing.Point(77, 102)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(26, 20)
        Me.priceBox.TabIndex = 8
        '
        'unitTypeLabel
        '
        Me.unitTypeLabel.AutoSize = True
        Me.unitTypeLabel.Location = New System.Drawing.Point(104, 105)
        Me.unitTypeLabel.Name = "unitTypeLabel"
        Me.unitTypeLabel.Size = New System.Drawing.Size(0, 13)
        Me.unitTypeLabel.TabIndex = 9
        '
        'typeBox
        '
        Me.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeBox.FormattingEnabled = True
        Me.typeBox.Items.AddRange(New Object() {"Resource", "Labour"})
        Me.typeBox.Location = New System.Drawing.Point(77, 75)
        Me.typeBox.Name = "typeBox"
        Me.typeBox.Size = New System.Drawing.Size(100, 21)
        Me.typeBox.TabIndex = 6
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.errorLabel.Location = New System.Drawing.Point(78, 138)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(0, 13)
        Me.errorLabel.TabIndex = 17
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addButton.Location = New System.Drawing.Point(72, 154)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 10
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'AddMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 188)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.typeBox)
        Me.Controls.Add(Me.unitTypeLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.typeLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.IDBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(235, 227)
        Me.MinimumSize = New System.Drawing.Size(235, 227)
        Me.Name = "AddMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Material"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDLabel As Label
    Friend WithEvents IDBox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents typeLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents priceBox As TextBox
    Friend WithEvents unitTypeLabel As Label
    Friend WithEvents typeBox As ComboBox
    Friend WithEvents errorLabel As Label
    Friend WithEvents addButton As Button
End Class
