<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPaperForm
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
        Me.PaperNameLabel = New System.Windows.Forms.Label()
        Me.FilePathLabel = New System.Windows.Forms.Label()
        Me.DifficultyLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.FilePathTextBox = New System.Windows.Forms.TextBox()
        Me.DifficultyUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BrowseFileButton = New System.Windows.Forms.Button()
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.CompletedCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompletedLabel = New System.Windows.Forms.Label()
        CType(Me.DifficultyUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaperNameLabel
        '
        Me.PaperNameLabel.AutoSize = True
        Me.PaperNameLabel.Location = New System.Drawing.Point(21, 20)
        Me.PaperNameLabel.Name = "PaperNameLabel"
        Me.PaperNameLabel.Size = New System.Drawing.Size(35, 13)
        Me.PaperNameLabel.TabIndex = 0
        Me.PaperNameLabel.Text = "Name"
        '
        'FilePathLabel
        '
        Me.FilePathLabel.AutoSize = True
        Me.FilePathLabel.Location = New System.Drawing.Point(21, 59)
        Me.FilePathLabel.Name = "FilePathLabel"
        Me.FilePathLabel.Size = New System.Drawing.Size(48, 13)
        Me.FilePathLabel.TabIndex = 1
        Me.FilePathLabel.Text = "File Path"
        '
        'DifficultyLabel
        '
        Me.DifficultyLabel.AutoSize = True
        Me.DifficultyLabel.Location = New System.Drawing.Point(21, 98)
        Me.DifficultyLabel.Name = "DifficultyLabel"
        Me.DifficultyLabel.Size = New System.Drawing.Size(47, 13)
        Me.DifficultyLabel.TabIndex = 2
        Me.DifficultyLabel.Text = "Difficulty"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(83, 17)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(348, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'FilePathTextBox
        '
        Me.FilePathTextBox.Location = New System.Drawing.Point(83, 56)
        Me.FilePathTextBox.Name = "FilePathTextBox"
        Me.FilePathTextBox.Size = New System.Drawing.Size(348, 20)
        Me.FilePathTextBox.TabIndex = 4
        '
        'DifficultyUpDown
        '
        Me.DifficultyUpDown.Location = New System.Drawing.Point(83, 96)
        Me.DifficultyUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DifficultyUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DifficultyUpDown.Name = "DifficultyUpDown"
        Me.DifficultyUpDown.Size = New System.Drawing.Size(40, 20)
        Me.DifficultyUpDown.TabIndex = 5
        Me.DifficultyUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BrowseFileButton
        '
        Me.BrowseFileButton.Location = New System.Drawing.Point(437, 54)
        Me.BrowseFileButton.Name = "BrowseFileButton"
        Me.BrowseFileButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseFileButton.TabIndex = 6
        Me.BrowseFileButton.Text = "Browse"
        Me.BrowseFileButton.UseVisualStyleBackColor = True
        '
        'DoneButton
        '
        Me.DoneButton.Location = New System.Drawing.Point(356, 93)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(75, 23)
        Me.DoneButton.TabIndex = 7
        Me.DoneButton.Text = "Done"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(437, 93)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'CompletedCheckBox
        '
        Me.CompletedCheckBox.AutoSize = True
        Me.CompletedCheckBox.Location = New System.Drawing.Point(230, 98)
        Me.CompletedCheckBox.Name = "CompletedCheckBox"
        Me.CompletedCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CompletedCheckBox.TabIndex = 20
        Me.CompletedCheckBox.UseVisualStyleBackColor = True
        '
        'CompletedLabel
        '
        Me.CompletedLabel.AutoSize = True
        Me.CompletedLabel.Location = New System.Drawing.Point(160, 98)
        Me.CompletedLabel.Name = "CompletedLabel"
        Me.CompletedLabel.Size = New System.Drawing.Size(63, 13)
        Me.CompletedLabel.TabIndex = 19
        Me.CompletedLabel.Text = "Completed?"
        '
        'AddPaperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 132)
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
        Me.Name = "AddPaperForm"
        Me.Text = "AddPaperForm"
        CType(Me.DifficultyUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PaperNameLabel As System.Windows.Forms.Label
    Friend WithEvents FilePathLabel As System.Windows.Forms.Label
    Friend WithEvents DifficultyLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FilePathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DifficultyUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BrowseFileButton As System.Windows.Forms.Button
    Friend WithEvents DoneButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents CompletedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CompletedLabel As System.Windows.Forms.Label
End Class
