<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddJob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddJob))
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.materialsList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resourcePriceBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labourPriceBox = New System.Windows.Forms.TextBox()
        Me.materialsLabel = New System.Windows.Forms.Label()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.addMaterialButton = New System.Windows.Forms.Button()
        Me.removeMaterialButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.newMaterialButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IDBox
        '
        Me.IDBox.Cursor = System.Windows.Forms.Cursors.No
        Me.IDBox.Location = New System.Drawing.Point(106, 12)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.ReadOnly = True
        Me.IDBox.Size = New System.Drawing.Size(100, 20)
        Me.IDBox.TabIndex = 6
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.BackColor = System.Drawing.SystemColors.Control
        Me.IDLabel.Location = New System.Drawing.Point(82, 15)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 13)
        Me.IDLabel.TabIndex = 5
        Me.IDLabel.Text = "ID"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(38, 41)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(62, 13)
        Me.nameLabel.TabIndex = 7
        Me.nameLabel.Text = "Task Name"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(106, 38)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 20)
        Me.nameBox.TabIndex = 8
        '
        'materialsList
        '
        Me.materialsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.materialsList.FullRowSelect = True
        Me.materialsList.HideSelection = False
        Me.materialsList.Location = New System.Drawing.Point(106, 64)
        Me.materialsList.MultiSelect = False
        Me.materialsList.Name = "materialsList"
        Me.materialsList.Size = New System.Drawing.Size(329, 123)
        Me.materialsList.TabIndex = 9
        Me.materialsList.UseCompatibleStateImageBehavior = False
        Me.materialsList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 265
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Resource Expense £"
        '
        'resourcePriceBox
        '
        Me.resourcePriceBox.Location = New System.Drawing.Point(106, 193)
        Me.resourcePriceBox.Name = "resourcePriceBox"
        Me.resourcePriceBox.ReadOnly = True
        Me.resourcePriceBox.Size = New System.Drawing.Size(100, 20)
        Me.resourcePriceBox.TabIndex = 11
        Me.resourcePriceBox.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Labour Fee £"
        '
        'labourPriceBox
        '
        Me.labourPriceBox.Location = New System.Drawing.Point(280, 193)
        Me.labourPriceBox.Name = "labourPriceBox"
        Me.labourPriceBox.ReadOnly = True
        Me.labourPriceBox.Size = New System.Drawing.Size(100, 20)
        Me.labourPriceBox.TabIndex = 13
        Me.labourPriceBox.Text = "0"
        '
        'materialsLabel
        '
        Me.materialsLabel.AutoSize = True
        Me.materialsLabel.Location = New System.Drawing.Point(51, 64)
        Me.materialsLabel.Name = "materialsLabel"
        Me.materialsLabel.Size = New System.Drawing.Size(49, 13)
        Me.materialsLabel.TabIndex = 14
        Me.materialsLabel.Text = "Materials"
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.errorLabel.Location = New System.Drawing.Point(224, 220)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(0, 13)
        Me.errorLabel.TabIndex = 17
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addButton.Location = New System.Drawing.Point(218, 236)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 16
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'addMaterialButton
        '
        Me.addMaterialButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addMaterialButton.Location = New System.Drawing.Point(441, 64)
        Me.addMaterialButton.Name = "addMaterialButton"
        Me.addMaterialButton.Size = New System.Drawing.Size(84, 23)
        Me.addMaterialButton.TabIndex = 18
        Me.addMaterialButton.Text = "Add Material"
        Me.addMaterialButton.UseVisualStyleBackColor = False
        '
        'removeMaterialButton
        '
        Me.removeMaterialButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.removeMaterialButton.Enabled = False
        Me.removeMaterialButton.Location = New System.Drawing.Point(442, 122)
        Me.removeMaterialButton.Name = "removeMaterialButton"
        Me.removeMaterialButton.Size = New System.Drawing.Size(83, 23)
        Me.removeMaterialButton.TabIndex = 19
        Me.removeMaterialButton.Text = "Remove"
        Me.removeMaterialButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.clearButton.Enabled = False
        Me.clearButton.Location = New System.Drawing.Point(442, 151)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(83, 23)
        Me.clearButton.TabIndex = 22
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "per hour"
        '
        'newMaterialButton
        '
        Me.newMaterialButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.newMaterialButton.Location = New System.Drawing.Point(441, 93)
        Me.newMaterialButton.Name = "newMaterialButton"
        Me.newMaterialButton.Size = New System.Drawing.Size(84, 23)
        Me.newMaterialButton.TabIndex = 24
        Me.newMaterialButton.Text = "New Material"
        Me.newMaterialButton.UseVisualStyleBackColor = False
        '
        'AddJob
        '
        Me.AcceptButton = Me.addButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 268)
        Me.Controls.Add(Me.newMaterialButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.removeMaterialButton)
        Me.Controls.Add(Me.addMaterialButton)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.materialsLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labourPriceBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resourcePriceBox)
        Me.Controls.Add(Me.materialsList)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.nameBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(545, 307)
        Me.MinimumSize = New System.Drawing.Size(545, 307)
        Me.Name = "AddJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quote Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDBox As TextBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents materialsList As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents resourcePriceBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents labourPriceBox As TextBox
    Friend WithEvents materialsLabel As Label
    Friend WithEvents errorLabel As Label
    Friend WithEvents addButton As Button
    Friend WithEvents addMaterialButton As Button
    Friend WithEvents removeMaterialButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents newMaterialButton As Button
End Class
