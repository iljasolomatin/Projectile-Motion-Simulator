Public Class AddPaperForm
    'Constants to store the default file dialog filter and extensions to display only pdf files
    Private Const DefaultFileDialogFilter As String = "PDF File | *.pdf"
    Private Const DefaultFileDialogExtension As String = ".pdf"
    Private Const NonExistentFileErrorMessage As String = "File is non existent"
    Private Const InvalidFileTypeErrorMessage As String = "Only PDF's are allowed"

    Private Sub BrowseFileButton_Click(sender As System.Object, e As System.EventArgs) Handles BrowseFileButton.Click
        'A new instance of the OpenFileDialog class is created
        Dim OpenDialog As New OpenFileDialog
        OpenDialog.Filter = DefaultFileDialogFilter
        OpenDialog.DefaultExt = DefaultFileDialogExtension
        'The window for selecting a file is shown, and if the user presses OK, then
        If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Their selected file's path will be assigned to the text value of the file path textbox
            FilePathTextBox.Text = OpenDialog.FileName
        End If
    End Sub

    Private Sub DoneButton_Click(sender As System.Object, e As System.EventArgs) Handles DoneButton.Click
        'Check whether the file in the textbox exists
        If My.Computer.FileSystem.FileExists(FilePathTextBox.Text) Then
            'Check if the last 4 characters of the file name are '.pdf' to ensure the correct file type is used
            If FilePathTextBox.Text.Substring(FilePathTextBox.Text.Length - 4, 4) = DefaultFileDialogExtension Then
                'A new paper is created from the ExamPaper structure
                Dim NewPaper As ExamPaper
                'The three properties of the paper are filled from the respective textboxes
                NewPaper.PaperName = NameTextBox.Text
                NewPaper.PaperFilePath = FilePathTextBox.Text
                NewPaper.PaperDifficulty = DifficultyUpDown.Value
                NewPaper.PaperCompleted = CompletedCheckBox.Checked
                'The paper is added to the array using the method from the ExamPastPapers Module
                ExamPastPapers.AddPastPaper(NewPaper, PastPaperManagementForm.PastPaperDataGrid)
                'Form is closed as its no longer needed
                Me.Close()
            Else
                MsgBox(InvalidFileTypeErrorMessage)
            End If
        Else
            MsgBox(NonExistentFileErrorMessage)
        End If
    End Sub

    'If the user decides they dont want to add a paper, the add paper form will be closed
    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class