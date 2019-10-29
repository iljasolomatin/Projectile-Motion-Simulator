Public Class EditPaperForm
    'Constants to store the default file dialog filter and extensions to display only pdf files
    Private Const DefaultFileDialogFilter As String = "PDF File | *.pdf"
    Private Const DefaultFileDialogExtension As String = ".pdf"
    Private Const NonExistentFileErrorMessage As String = "File is non existent"
    Private Const InvalidFileTypeErrorMessage As String = "Only PDF's are allowed"

    'Variable to store the paper that will be edited
    Private PaperToEdit As ExamPaper

    Private Sub EditPaperForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'The paper that will be edited is selected from the array of papers, using the index of its location in the datagrid.
        PaperToEdit = ExamPastPapers.AllPastPapers(PastPaperManagementForm.PastPaperDataGrid.CurrentCell.RowIndex)

        'The textboxes in the edit form are filled out with the respective values from the selected paper
        NameTextBox.Text = PaperToEdit.PaperName
        FilePathTextBox.Text = PaperToEdit.PaperFilePath
        DifficultyUpDown.Value = PaperToEdit.PaperDifficulty
        CompletedCheckBox.Checked = PaperToEdit.PaperCompleted
    End Sub

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
        'If the file in the file path textbox exists
        If My.Computer.FileSystem.FileExists(FilePathTextBox.Text) Then
            'Check if the last 4 characters of the file name are '.pdf' to ensure the correct file type is used
            If FilePathTextBox.Text.Substring(FilePathTextBox.Text.Length - 4, 4) = DefaultFileDialogExtension Then
                'then make the assign the changes from the user's inputs
                PaperToEdit.PaperName = CStr(NameTextBox.Text)
                PaperToEdit.PaperFilePath = CStr(FilePathTextBox.Text)
                PaperToEdit.PaperDifficulty = CByte(DifficultyUpDown.Value)
                PaperToEdit.PaperCompleted = CompletedCheckBox.Checked
                'Call the procedure to apply the changes from the ExamPastPapers Module
                ExamPastPapers.EditPastPaper(PastPaperManagementForm.PastPaperDataGrid, PaperToEdit)
                Me.Close()
            Else
                MsgBox(InvalidFileTypeErrorMessage)
            End If
        Else
            MsgBox(NonExistentFileErrorMessage)
        End If
    End Sub

    'If the user decides they dont want to edit a paper, the edit paper form will be closed
    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class