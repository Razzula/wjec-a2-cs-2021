<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageFiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageFiles))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filenameBox = New System.Windows.Forms.ComboBox()
        Me.fileContents = New System.Windows.Forms.ListView()
        Me.addItemButton = New System.Windows.Forms.Button()
        Me.editItemButton = New System.Windows.Forms.Button()
        Me.deleteItemButton = New System.Windows.Forms.Button()
        Me.clearFileButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File:"
        '
        'filenameBox
        '
        Me.filenameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filenameBox.FormattingEnabled = True
        Me.filenameBox.Items.AddRange(New Object() {"Users.txt", "Customers.txt", "Bookings.txt", "Jobs.txt", "Materials.txt"})
        Me.filenameBox.Location = New System.Drawing.Point(44, 6)
        Me.filenameBox.Name = "filenameBox"
        Me.filenameBox.Size = New System.Drawing.Size(121, 21)
        Me.filenameBox.TabIndex = 1
        '
        'fileContents
        '
        Me.fileContents.FullRowSelect = True
        Me.fileContents.HideSelection = False
        Me.fileContents.Location = New System.Drawing.Point(15, 33)
        Me.fileContents.Name = "fileContents"
        Me.fileContents.Size = New System.Drawing.Size(692, 302)
        Me.fileContents.TabIndex = 2
        Me.fileContents.UseCompatibleStateImageBehavior = False
        Me.fileContents.View = System.Windows.Forms.View.Details
        '
        'addItemButton
        '
        Me.addItemButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addItemButton.Enabled = False
        Me.addItemButton.Location = New System.Drawing.Point(713, 33)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Size = New System.Drawing.Size(75, 23)
        Me.addItemButton.TabIndex = 3
        Me.addItemButton.Text = "Add Item"
        Me.addItemButton.UseVisualStyleBackColor = True
        '
        'editItemButton
        '
        Me.editItemButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editItemButton.Enabled = False
        Me.editItemButton.Location = New System.Drawing.Point(713, 62)
        Me.editItemButton.Name = "editItemButton"
        Me.editItemButton.Size = New System.Drawing.Size(75, 23)
        Me.editItemButton.TabIndex = 4
        Me.editItemButton.Text = "Edit Item"
        Me.editItemButton.UseVisualStyleBackColor = True
        '
        'deleteItemButton
        '
        Me.deleteItemButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteItemButton.Enabled = False
        Me.deleteItemButton.Location = New System.Drawing.Point(713, 91)
        Me.deleteItemButton.Name = "deleteItemButton"
        Me.deleteItemButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteItemButton.TabIndex = 5
        Me.deleteItemButton.Text = "Delete Item"
        Me.deleteItemButton.UseVisualStyleBackColor = True
        '
        'clearFileButton
        '
        Me.clearFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clearFileButton.Enabled = False
        Me.clearFileButton.Location = New System.Drawing.Point(713, 149)
        Me.clearFileButton.Name = "clearFileButton"
        Me.clearFileButton.Size = New System.Drawing.Size(75, 23)
        Me.clearFileButton.TabIndex = 6
        Me.clearFileButton.Text = "Clear File"
        Me.clearFileButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printButton.Enabled = False
        Me.printButton.Location = New System.Drawing.Point(713, 312)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 7
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search:"
        '
        'searchBox
        '
        Me.searchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBox.Enabled = False
        Me.searchBox.Location = New System.Drawing.Point(512, 12)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(195, 20)
        Me.searchBox.TabIndex = 9
        '
        'ManageFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 347)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.clearFileButton)
        Me.Controls.Add(Me.deleteItemButton)
        Me.Controls.Add(Me.editItemButton)
        Me.Controls.Add(Me.addItemButton)
        Me.Controls.Add(Me.fileContents)
        Me.Controls.Add(Me.filenameBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(816, 386)
        Me.Name = "ManageFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageFiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents filenameBox As ComboBox
    Friend WithEvents fileContents As ListView
    Friend WithEvents addItemButton As Button
    Friend WithEvents editItemButton As Button
    Friend WithEvents deleteItemButton As Button
    Friend WithEvents clearFileButton As Button
    Friend WithEvents printButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents searchBox As TextBox
End Class
