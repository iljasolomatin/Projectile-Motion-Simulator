<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPaperForm
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
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.BrowseFileButton = New System.Windows.Forms.Button()
        Me.DifficultyUpDown = New System.Windows.Forms.NumericUpDown()
        Me.FilePathTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DifficultyLabel = New System.Windows.Forms.Label()
        Me.FilePathLabel = New System.Windows.Forms.Label()
        Me.PaperNameLabel = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.CompletedLabel = New System.Windows.Forms.Label()
        Me.CompletedCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.DifficultyUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DoneButton
        '
        Me.DoneButton.Location = New System.Drawing.Point(350, 88)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(75, 23)
        Me.DoneButton.TabIndex = 15
        Me.DoneButton.Text = "Done"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'BrowseFileButton
        '
        Me.BrowseFileButton.Location = New System.Drawing.Point(431, 49)
        Me.BrowseFileButton.Name = "BrowseFileButton"
        Me.BrowseFileButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseFileButton.TabIndex = 14
        Me.BrowseFileButton.Text = "Browse"
        Me.BrowseFileButton.UseVisualStyleBackColor = True
        '
        'DifficultyUpDown
        '
        Me.DifficultyUpDown.Location = New System.Drawing.Point(77, 91)
        Me.DifficultyUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DifficultyUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DifficultyUpDown.Name = "DifficultyUpDown"
        Me.DifficultyUpDown.Size = New System.Drawing.Size(40, 20)
        Me.DifficultyUpDown.TabIndex = 13
        Me.DifficultyUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FilePathTextBox
        '
        Me.FilePathTextBox.Location = New System.Drawing.Point(77, 51)
        Me.FilePathTextBox.Name = "FilePathTextBox"
        Me.FilePathTextBox.Size = New System.Drawing.Size(348, 20)
        Me.FilePathTextBox.TabIndex = 12
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(77, 12)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(348, 20)
        Me.NameTextBox.TabIndex = 11
        '
        'DifficultyLabel
        '
        Me.DifficultyLabel.AutoSize = True
        Me.DifficultyLabel.Location = New System.Drawing.Point(15, 93)
        Me.DifficultyLabel.Name = "DifficultyLabel"
        Me.DifficultyLabel.Size = New System.Drawing.Size(47, 13)
        Me.DifficultyLabel.TabIndex = 10
        Me.DifficultyLabel.Text = "Difficulty"
        '
        'FilePathLabel
        '
        Me.FilePathLabel.AutoSize = True
        Me.FilePathLabel.Location = New System.Drawing.Point(15, 54)
        Me.FilePathLabel.Name = "FilePathLabel"
        Me.FilePathLabel.Size = New System.Drawing.Size(48, 13)
        Me.FilePathLabel.TabIndex = 9
        Me.FilePathLabel.Text = "File Path"
        '
        'PaperNameLabel
        '
        Me.PaperNameLabel.AutoSize = True
        Me.PaperNameLabel.Location = New System.Drawing.Point(15, 15)
        Me.PaperNameLabel.Name = "PaperNameLabel"
        Me.PaperNameLabel.Size = New System.Drawing.Size(35, 13)
        Me.PaperNameLabel.TabIndex = 8
        Me.PaperNameLabel.Text = "Name"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(431, 88)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 16
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'CompletedLabel
        '
        Me.CompletedLabel.AutoSize = True
        Me.CompletedLabel.Location = New System.Drawing.Point(155, 93)
        Me.CompletedLabel.Name = "CompletedLabel"
        Me.CompletedLabel.Size = New System.Drawing.Size(63, 13)
        Me.CompletedLabel.TabIndex = 17
        Me.CompletedLabel.Text = "Completed?"
        '
        'CompletedCheckBox
        '
        Me.CompletedCheckBox.AutoSize = True
        Me.CompletedCheckBox.Location = New System.Drawing.Point(225, 93)
        Me.CompletedCheckBox.Name = "CompletedCheckBox"
        Me.CompletedCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CompletedCheckBox.TabIndex = 18
        Me.CompletedCheckBox.UseVisualStyleBackColor = True
        '
        'EditPaperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 124)
        Me.Controls.Add(Me.CompletedCheckBox)
        Me.Controls.Add(Me.CompletedLabel)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.BrowseFileButton)
        Me.Controls.Add(Me.DifficultyUpDown)
        Me.Controls.Add(Me.FilePathTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DifficultyLabel)
        Me.Controls.Add(Me.FilePathLabel)
        Me.Controls.Add(Me.PaperNameLabel)
        Me.Name = "EditPaperForm"
        Me.Text = "EditPaperForm"
        CType(Me.DifficultyUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DoneButton As System.Windows.Forms.Button
    Friend WithEvents BrowseFileButton As System.Windows.Forms.Button
    Friend WithEvents DifficultyUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents FilePathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DifficultyLabel As System.Windows.Forms.Label
    Friend WithEvents FilePathLabel As System.Windows.Forms.Label
    Friend WithEvents PaperNameLabel As System.Windows.Forms.Label
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents CompletedLabel As System.Windows.Forms.Label
    Friend WithEvents CompletedCheckBox As System.Windows.Forms.CheckBox
End Class
