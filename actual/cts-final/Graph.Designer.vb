<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Graph
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Graph))
        Me.endDateABox = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startDateABox = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.startDateBBox = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comparatorSelectionBox = New System.Windows.Forms.ComboBox()
        Me.endDateBBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'endDateABox
        '
        Me.endDateABox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.endDateABox.Location = New System.Drawing.Point(654, 12)
        Me.endDateABox.Name = "endDateABox"
        Me.endDateABox.Size = New System.Drawing.Size(134, 20)
        Me.endDateABox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(628, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(452, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From"
        '
        'startDateABox
        '
        Me.startDateABox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startDateABox.Location = New System.Drawing.Point(488, 12)
        Me.startDateABox.Name = "startDateABox"
        Me.startDateABox.Size = New System.Drawing.Size(134, 20)
        Me.startDateABox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(452, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "From"
        '
        'startDateBBox
        '
        Me.startDateBBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startDateBBox.Location = New System.Drawing.Point(488, 38)
        Me.startDateBBox.Name = "startDateBBox"
        Me.startDateBBox.Size = New System.Drawing.Size(134, 20)
        Me.startDateBBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(628, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Compare"
        '
        'comparatorSelectionBox
        '
        Me.comparatorSelectionBox.FormattingEnabled = True
        Me.comparatorSelectionBox.Items.AddRange(New Object() {"Earnings"})
        Me.comparatorSelectionBox.Location = New System.Drawing.Point(67, 12)
        Me.comparatorSelectionBox.Name = "comparatorSelectionBox"
        Me.comparatorSelectionBox.Size = New System.Drawing.Size(121, 21)
        Me.comparatorSelectionBox.TabIndex = 9
        '
        'endDateBBox
        '
        Me.endDateBBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.endDateBBox.Location = New System.Drawing.Point(654, 38)
        Me.endDateBBox.Name = "endDateBBox"
        Me.endDateBBox.ReadOnly = True
        Me.endDateBBox.Size = New System.Drawing.Size(134, 20)
        Me.endDateBBox.TabIndex = 10
        '
        'Graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.endDateBBox)
        Me.Controls.Add(Me.comparatorSelectionBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.startDateBBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.startDateABox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.endDateABox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "Graph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents endDateABox As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents startDateABox As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents startDateBBox As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents comparatorSelectionBox As ComboBox
    Friend WithEvents endDateBBox As TextBox
End Class
