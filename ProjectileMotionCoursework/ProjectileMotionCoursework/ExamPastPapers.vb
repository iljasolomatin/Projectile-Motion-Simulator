Module ExamPastPapers
    'Constant string to store messages displayed to the user
    Private Const NonExistentFileErrorMessage As String = "File is non existent"
    Private Const MarkUncompleteMessage As String = "The paper will be reset to uncomplete."

    'Variable that stores the path where the text file with past papers is located, as it will change based on where the program is located.
    Private PastPapersTextFilePath As String = System.IO.Directory.GetCurrentDirectory & "\Past Papers\PastPapers.txt"

    ' The structure of a single past paper containing the following information
    Structure ExamPaper
        Dim PaperName As String
        Dim PaperFilePath As String
        Dim PaperDifficulty As Byte
        Dim PaperCompleted As Boolean
    End Structure

    'An array storing 'exam papers' using the structure
    Public AllPastPapers() As ExamPaper
    'Variable to store the number of exam papers
    Dim NoOfPapers As Byte
    'Procedure to load exam papers from a file

    Public Sub LoadExamPapers()
        'A new instance of the StreamReader class is created
        Dim FileReader As IO.StreamReader = New IO.StreamReader(PastPapersTextFilePath)
        'Loop until the end of the file is reached
        Do Until FileReader.EndOfStream
            'The size of the array is increased by 1
            ReDim Preserve AllPastPapers(NoOfPapers)
            'In each iteration, 4 lines are read and assigned to the different information for a past paper
            AllPastPapers(NoOfPapers).PaperName = FileReader.ReadLine
            AllPastPapers(NoOfPapers).PaperFilePath = FileReader.ReadLine
            AllPastPapers(NoOfPapers).PaperDifficulty = CByte(FileReader.ReadLine)
            AllPastPapers(NoOfPapers).PaperCompleted = CBool(FileReader.ReadLine)
            'After the 3 pieces are read in for a single paper, the counter can be increased by 1
            NoOfPapers += 1
        Loop
        'The file is closed after use
        FileReader.Close()
    End Sub

    'Procedure to fill the cells of the data grid with information of past papers that have already been loaded from the file
    Public Sub FillPapersGrid(ByRef inDataGrid As DataGridView)
        'The current contents of the grid are cleared
        inDataGrid.Rows.Clear()
        For Looper = 0 To NoOfPapers - 1
            'A new row is added to the data grid
            inDataGrid.Rows.Add()
            inDataGrid.Item(0, Looper).Value = AllPastPapers(Looper).PaperName ' Column: 0, Row: Looper
            inDataGrid.Item(1, Looper).Value = AllPastPapers(Looper).PaperDifficulty ' Column: 1, Row: Looper
            inDataGrid.Item(2, Looper).Value = CStr(AllPastPapers(Looper).PaperCompleted) ' Column: 2, Row: Looper
        Next
    End Sub

    'Procedure to open the past paper that the user has selected
    Public Sub OpenPastPaper(ByVal SelectedRow As Integer)
        Dim PaperFilepath As String
        'String that will store the file path of the paper that will be opened
        PaperFilepath = AllPastPapers(SelectedRow).PaperFilePath
        'If the file that the user wished to open exists, then
        If My.Computer.FileSystem.FileExists(PaperFilepath) Then
            Process.Start(PaperFilepath)
        Else
            'Else the file does not exist, and so a relevant error message is shown
            MsgBox(NonExistentFileErrorMessage)
        End If
    End Sub

    'Procedure to add a new past paper to the data grid if the user wishes to do so.
    Public Sub AddPastPaper(ByVal inNewPastPaper As ExamPaper, ByRef inDataGrid As DataGridView)
        'A new row is added to the data grid
        inDataGrid.Rows.Add()
        inDataGrid.Item(0, NoOfPapers).Value = inNewPastPaper.PaperName
        inDataGrid.Item(1, NoOfPapers).Value = inNewPastPaper.PaperDifficulty
        inDataGrid.Item(2, NoOfPapers).Value = CStr(inNewPastPaper.PaperCompleted)
        'The size of the array is increased by 1
        ReDim Preserve AllPastPapers(NoOfPapers)
        'Number of papers has increased by 1
        NoOfPapers += 1
        'The new paper is assigned to the array which contains all existing past papers
        AllPastPapers(NoOfPapers - 1) = inNewPastPaper
    End Sub

    'Procedure to mark papers as 'completed' by the user
    Public Sub PaperCompleted(ByRef inDataGrid As DataGridView)
        'If the completed value is already true in the selected row, then set it back to false
        If inDataGrid.Item(2, inDataGrid.CurrentCell.RowIndex).Value = CStr(True) Then
            MsgBox(MarkUncompleteMessage)
            inDataGrid.Item(2, inDataGrid.CurrentCell.RowIndex).Value = CStr(False)
            AllPastPapers(inDataGrid.CurrentCell.RowIndex).PaperCompleted = True
        Else
            'Else set the corresponding cell to true
            inDataGrid.Item(2, inDataGrid.CurrentCell.RowIndex).Value = CStr(True)
            AllPastPapers(inDataGrid.CurrentCell.RowIndex).PaperCompleted = True
        End If
    End Sub

    'Procedure to change information of a paper within the datagrid view
    Public Sub EditPastPaper(ByRef inDataGrid As DataGridView, ByVal inExamPaper As ExamPaper)
        Dim PaperIndex As Integer
        'The position of the paper in the array is found by calling the LocatePaper function
        PaperIndex = LocatePaper(inExamPaper.PaperFilePath)
        'The paper parameter passed from the form is then assigned to the paper at the specific index in the array
        AllPastPapers(PaperIndex) = inExamPaper
        'The grid is completely refilled
        FillPapersGrid(inDataGrid)
    End Sub

    'Function that will return the position of a paper to be found in the array of papers
    Public Function LocatePaper(ByVal LocationToFind As String) As Integer
        Dim FilePathMatch As Boolean
        'Loop until the paper to be found is equal to the paper location at a specific index in the array
        For Looper = 0 To AllPastPapers.Length - 1
            If LocationToFind = AllPastPapers(Looper).PaperFilePath Then
                FilePathMatch = True
                Return Looper
            End If
        Next
    End Function

    'Procedure to remove a past paper in the datagrid at a row selected by the user
    Public Sub RemovePastPaper(ByRef inDataGrid As DataGridView, ByVal SelectedRow As Integer)
        'All the papers above the row in which the paper to be removed is, are moved up by 1 position, thus overwriting the paper to be removed
        For Looper = SelectedRow To NoOfPapers - 2
            ' Paper at the loopers position, is overwritten by the paper above it
            AllPastPapers(Looper) = AllPastPapers(Looper + 1)
        Next
        'Total number of papers has decreased by 1
        NoOfPapers -= 1
        'The array must be resized to remove the duplicate paper at the end of the array
        ReDim Preserve AllPastPapers(NoOfPapers)
        'The grid is refilled
        FillPapersGrid(inDataGrid)
    End Sub

    'Procedure to write all past paper information from the array, to a text file.
    Public Sub SavePastPapers()
        Dim FileWriter As New IO.StreamWriter(PastPapersTextFilePath)
        'All the properties of the papers in the array are written to a text file, a line at a time
        For Looper = 0 To NoOfPapers - 1
            FileWriter.WriteLine(AllPastPapers(Looper).PaperName)
            FileWriter.WriteLine(AllPastPapers(Looper).PaperFilePath)
            FileWriter.WriteLine(AllPastPapers(Looper).PaperDifficulty)
            FileWriter.WriteLine(AllPastPapers(Looper).PaperCompleted)
        Next
        'File is closed after use
        FileWriter.Close()
    End Sub

    'Procedure to sort papers displayed in the grid by their difficulty using a recursive merge sort
    Public Sub SortPapersByDifficulty(ByRef inDataGrid As DataGridView)
        'Call the recursive merge sort procedure, passing in the array of papers, the smallest poisition in the array (0), and the highest position respectively
        MergeSortRecursive(AllPastPapers, 0, NoOfPapers - 1)
        'The table is refilled after the array is sorted by difficulty
        FillPapersGrid(PastPaperManagementForm.PastPaperDataGrid)
    End Sub

    'Procedure to recursively split the array until its size is one
    Public Sub MergeSortRecursive(ByRef inPapers As ExamPaper(), ByVal LeftPointer As Integer, ByVal RightPointer As Integer)
        'If the value on the left is less than the value on the right, then
        If LeftPointer < RightPointer Then
            'Calculte the index of the element that is in the middle, as this will serve as the greatest index in the left array, and middle+1 will serve as the smallest index in the right array
            Dim Middle As Integer = LeftPointer + (RightPointer - LeftPointer) \ 2
            'Divide the left side into two parts recursively
            MergeSortRecursive(inPapers, LeftPointer, Middle)
            'Divide the right side into two parts recursively
            MergeSortRecursive(inPapers, Middle + 1, RightPointer)
            'Merge the two sides of the array by comparing elements
            Merge(inPapers, LeftPointer, Middle, RightPointer)
        End If
    End Sub

    'Function to merge two halves together
    Private Sub Merge(ByRef inPapers As ExamPaper(), ByVal Left As Integer, ByVal Middle As Integer, ByVal Right As Integer)
        'Initial indexes of first, second and third subarrays respectively
        Dim IndexFirst As Integer, IndexSecond As Integer, IndexMerged As Integer
        Dim LeftSize As Integer = Middle - Left + 1
        Dim RightSize As Integer = Right - Middle
        'Temporary arrays of the ExamPaper structure
        Dim TempLeftArray As ExamPaper() = New ExamPaper(LeftSize - 1) {}
        Dim TempRightArray As ExamPaper() = New ExamPaper(RightSize - 1) {}

        'Fill in the temporary array for the left side
        For IndexFirst = 0 To LeftSize - 1
            TempLeftArray(IndexFirst) = inPapers(Left + IndexFirst)
        Next

        'Fill in the temporary array for the right side
        For IndexSecond = 0 To RightSize - 1
            TempRightArray(IndexSecond) = inPapers(Middle + 1 + IndexSecond)
        Next

        'After filling the temporary arrays, the indexes are reset
        IndexFirst = 0
        IndexSecond = 0
        'IndexMerged is set to left as that is the left-most index in the array
        IndexMerged = Left

        'While both the first index is less than the left, and second index is less than the right, do the following
        While IndexFirst < LeftSize AndAlso IndexSecond < RightSize
            'If the paper difficulty on the left is less than or equal to the paper difficulty on the right, then that paper is assigned to the merged array
            'and the index of the left array is incremented by one
            If TempLeftArray(IndexFirst).PaperDifficulty <= TempRightArray(IndexSecond).PaperDifficulty Then
                inPapers(IndexMerged) = TempLeftArray(IndexFirst)
                IndexFirst += 1
            Else
                'Else the paper difficulty on the left must've been greater than the difficulty on the right, and so the paper on the right is assigned to the merged array
                'and the index of the right array is incrememnted by one
                inPapers(IndexMerged) = TempRightArray(IndexSecond)
                IndexSecond += 1
            End If
            'Increment index of the merged array by one after having an element added
            IndexMerged += 1
        End While

        'Copy the remaining elements of the temporary left array if there are any left
        While IndexFirst < LeftSize
            inPapers(IndexMerged) = TempLeftArray(IndexFirst)
            'Increment both the indexes
            IndexFirst += 1
            IndexMerged += 1
        End While

        'Copy the remaining elements of the temporary right array if there are any left
        While IndexSecond < RightSize
            inPapers(IndexMerged) = TempRightArray(IndexSecond)
            'Increment both the indexes
            IndexSecond += 1
            IndexMerged += 1
        End While
    End Sub
End Module