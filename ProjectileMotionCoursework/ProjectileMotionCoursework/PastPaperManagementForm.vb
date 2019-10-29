Public Class PastPaperManagementForm
    'Constant to store an error message
    Private Const EmptyTableErrorMessage As String = "Cannot delete as the table is empty"

    'As the form loads, the papers are loaded into the datagrid view
    Private Sub PastPaperManagementForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ExamPastPapers.LoadExamPapers()
        ExamPastPapers.FillPapersGrid(Me.PastPaperDataGrid)
    End Sub

    Private Sub AddPaperButton_Click(sender As System.Object, e As System.EventArgs) Handles AddPaperButton.Click
        AddPaperForm.Show()
    End Sub

    Private Sub EditPaperButton_Click(sender As System.Object, e As System.EventArgs) Handles EditPaperButton.Click
        EditPaperForm.Show()
    End Sub

    Private Sub RemovePaperButton_Click(sender As System.Object, e As System.EventArgs) Handles RemovePaperButton.Click
        'If there is more than 1 row left, then a paper can be deleted
        If Me.PastPaperDataGrid.Rows.Count > 1 Then
            ExamPastPapers.RemovePastPaper(Me.PastPaperDataGrid, Me.PastPaperDataGrid.CurrentRow.Index)
        Else
            'Else there are no papers in the table and so a relevant error message is displayed
            MsgBox(EmptyTableErrorMessage)
        End If
    End Sub

    Private Sub SavePapersButton_Click(sender As System.Object, e As System.EventArgs) Handles SavePapersButton.Click
        ExamPastPapers.SavePastPapers()
    End Sub

    Private Sub CompletedButton_Click(sender As System.Object, e As System.EventArgs) Handles CompletedButton.Click
        ExamPastPapers.PaperCompleted(Me.PastPaperDataGrid)
    End Sub

    Private Sub OpenPaperButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenPaperButton.Click
        ExamPastPapers.OpenPastPaper(Me.PastPaperDataGrid.CurrentRow.Index)
    End Sub

    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub SortButton_Click(sender As System.Object, e As System.EventArgs) Handles SortButton.Click
        ExamPastPapers.SortPapersByDifficulty(Me.PastPaperDataGrid)
    End Sub
End Class