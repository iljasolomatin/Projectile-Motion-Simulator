<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PastPaperManagementForm
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
        Me.PastPaperDataGrid = New System.Windows.Forms.DataGridView()
        Me.PastPaperName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PastPaperDifficulty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddPaperButton = New System.Windows.Forms.Button()
        Me.RemovePaperButton = New System.Windows.Forms.Button()
        Me.EditPaperButton = New System.Windows.Forms.Button()
        Me.SavePapersButton = New System.Windows.Forms.Button()
        Me.SortButton = New System.Windows.Forms.Button()
        Me.CompletedButton = New System.Windows.Forms.Button()
        Me.OpenPaperButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.PastPaperDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PastPaperDataGrid
        '
        Me.PastPaperDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PastPaperDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PastPaperName, Me.PastPaperDifficulty, Me.Completed})
        Me.PastPaperDataGrid.Location = New System.Drawing.Point(12, 12)
        Me.PastPaperDataGrid.Name = "PastPaperDataGrid"
        Me.PastPaperDataGrid.Size = New System.Drawing.Size(362, 290)
        Me.PastPaperDataGrid.TabIndex = 0
        '
        'PastPaperName
        '
        Me.PastPaperName.HeaderText = "Name"
        Me.PastPaperName.Name = "PastPaperName"
        '
        'PastPaperDifficulty
        '
        Me.PastPaperDifficulty.HeaderText = "Difficulty"
        Me.PastPaperDifficulty.Name = "PastPaperDifficulty"
        '
        'Completed
        '
        Me.Completed.HeaderText = "Completed"
        Me.Completed.Name = "Completed"
        '
        'AddPaperButton
        '
        Me.AddPaperButton.Location = New System.Drawing.Point(389, 12)
        Me.AddPaperButton.Name = "AddPaperButton"
        Me.AddPaperButton.Size = New System.Drawing.Size(87, 46)
        Me.AddPaperButton.TabIndex = 1
        Me.AddPaperButton.Text = "Add Paper"
        Me.AddPaperButton.UseVisualStyleBackColor = True
        '
        'RemovePaperButton
        '
        Me.RemovePaperButton.Location = New System.Drawing.Point(492, 12)
        Me.RemovePaperButton.Name = "RemovePaperButton"
        Me.RemovePaperButton.Size = New System.Drawing.Size(87, 46)
        Me.RemovePaperButton.TabIndex = 2
        Me.RemovePaperButton.Text = "Remove Paper"
        Me.RemovePaperButton.UseVisualStyleBackColor = True
        '
        'EditPaperButton
        '
        Me.EditPaperButton.Location = New System.Drawing.Point(389, 116)
        Me.EditPaperButton.Name = "EditPaperButton"
        Me.EditPaperButton.Size = New System.Drawing.Size(87, 46)
        Me.EditPaperButton.TabIndex = 3
        Me.EditPaperButton.Text = "Edit Paper"
        Me.EditPaperButton.UseVisualStyleBackColor = True
        '
        'SavePapersButton
        '
        Me.SavePapersButton.Location = New System.Drawing.Point(492, 116)
        Me.SavePapersButton.Name = "SavePapersButton"
        Me.SavePapersButton.Size = New System.Drawing.Size(87, 46)
        Me.SavePapersButton.TabIndex = 4
        Me.SavePapersButton.Text = "Save Papers"
        Me.SavePapersButton.UseVisualStyleBackColor = True
        '
        'SortButton
        '
        Me.SortButton.Location = New System.Drawing.Point(389, 168)
        Me.SortButton.Name = "SortButton"
        Me.SortButton.Size = New System.Drawing.Size(87, 46)
        Me.SortButton.TabIndex = 5
        Me.SortButton.Text = "Sort Papers"
        Me.SortButton.UseVisualStyleBackColor = True
        '
        'CompletedButton
        '
        Me.CompletedButton.Location = New System.Drawing.Point(492, 64)
        Me.CompletedButton.Name = "CompletedButton"
        Me.CompletedButton.Size = New System.Drawing.Size(87, 46)
        Me.CompletedButton.TabIndex = 6
        Me.CompletedButton.Text = "Mark Completed"
        Me.CompletedButton.UseVisualStyleBackColor = True
        '
        'OpenPaperButton
        '
        Me.OpenPaperButton.Location = New System.Drawing.Point(389, 64)
        Me.OpenPaperButton.Name = "OpenPaperButton"
        Me.OpenPaperButton.Size = New System.Drawing.Size(87, 46)
        Me.OpenPaperButton.TabIndex = 7
        Me.OpenPaperButton.Text = "Open Paper"
        Me.OpenPaperButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(389, 275)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(87, 27)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'PastPaperManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 317)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.OpenPaperButton)
        Me.Controls.Add(Me.CompletedButton)
        Me.Controls.Add(Me.SortButton)
        Me.Controls.Add(Me.SavePapersButton)
        Me.Controls.Add(Me.EditPaperButton)
        Me.Controls.Add(Me.RemovePaperButton)
        Me.Controls.Add(Me.AddPaperButton)
        Me.Controls.Add(Me.PastPaperDataGrid)
        Me.Name = "PastPaperManagementForm"
        Me.Text = "PastPaperManagementForm"
        CType(Me.PastPaperDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PastPaperDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AddPaperButton As System.Windows.Forms.Button
    Friend WithEvents RemovePaperButton As System.Windows.Forms.Button
    Friend WithEvents EditPaperButton As System.Windows.Forms.Button
    Friend WithEvents SavePapersButton As System.Windows.Forms.Button
    Friend WithEvents SortButton As System.Windows.Forms.Button
    Friend WithEvents PastPaperName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PastPaperDifficulty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Completed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompletedButton As System.Windows.Forms.Button
    Friend WithEvents OpenPaperButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
