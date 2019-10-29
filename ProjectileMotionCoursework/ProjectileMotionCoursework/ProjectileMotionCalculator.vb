Public Class ProjectileMotionCalculator
    'Creating an instance of the cProjectile class
    Private CurrentProjectile As cProjectile

    'Constants for error messages and file format
    Private Const NoInitialVelocityErrorMessage As String = "Please enter an initial velocity, for now it will be set to 10."
    Private Const NonNumericInputsErrorMessage As String = "Only numbers are permitted."
    Private Const NegativeAccelerationErrorMessage As String = "Please enter an acceleration greater than 0, and less than or equal to 50."
    Private Const NegativeInitialHeightErrorMessage As String = "Please enter an initial height in the range 0 to 1000m."
    Private Const VelocityOutOfRangeErrorMessage As String = "Please use a velocity in the range 1 to 100 m/s."
    Private Const AngleOutOfRangeErrorMessage As String = "Only angles between 0 and 90."
    Private Const DefaultFileDialogFilter As String = "Binary File | *.bin"
    Private Const DefaultFileDialogExtension As String = "bin"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ProjectileMotionCalculator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GraphPanel.BackColor = Color.LightGray
        'Combo box set to Earth by default upon loading the form
        CommonAccelRadioButton.Checked = True
        CommonAccelComboBox.SelectedIndex = 0
        'Option for air resistance is deactivated by default upon loading the form
        DragCoefficientTrackBar.Visible = False
        DragCoefficientTextBox.Enabled = False
    End Sub

    'When the calculte button is clicked, the calculations and graph drawing must be done
    Private Sub CalculateButton_Click(sender As System.Object, e As System.EventArgs) Handles CalculateButton.Click
        'A new instance of the cProjectile class is created
        CurrentProjectile = New cProjectile()

        'The values entered by the user must be used for calculations so the properties of the object are filled in
        If CommonAccelComboBox.Enabled Then
            Select Case CommonAccelComboBox.SelectedIndex
                Case 0 'Earth
                    CurrentProjectile.SetAcceleration(9.81)
                Case 1 'Jupiter
                    CurrentProjectile.SetAcceleration(25.95)
                Case 2 'Neptune
                    CurrentProjectile.SetAcceleration(14.07)
                Case 3 'Venus
                    CurrentProjectile.SetAcceleration(8.87)
                Case 4 'Mars
                    CurrentProjectile.SetAcceleration(3.77)
                Case 5 'Mercury
                    CurrentProjectile.SetAcceleration(3.59)
                Case 6 'Moon
                    CurrentProjectile.SetAcceleration(1.62)
                Case 7 'Pluto
                    CurrentProjectile.SetAcceleration(0.42)
            End Select
        Else
            'If the common option was not enabled, then the value in the custom text box is used
            CurrentProjectile.SetAcceleration(CustomAccelTextBox.Text)
        End If

        'If the initial velocity text box is empty upon pressing calculate then an error message is shown
        If InitialVelocityTextBox.Text = vbNullString Then
            MsgBox(NoInitialVelocityErrorMessage)
            'The velocity is set to 10 by default
            InitialVelocityTextBox.Text = CStr(10)
            CurrentProjectile.SetInitialVelocity(CDec(InitialVelocityTextBox.Text))
        Else
            'Else the text box is not empty
            CurrentProjectile.SetInitialVelocity(CDec(InitialVelocityTextBox.Text))
        End If

        'If the initial height text box is empty then set the height to 0 by default (starting from ground)
        If InitialHeightTextBox.Text = vbNullString Then
            InitialHeightTextBox.Text = CStr(0)
            CurrentProjectile.SetInitialHeight(CDec(InitialHeightTextBox.Text))
        Else
            'else the initial height text box is not empty
            CurrentProjectile.SetInitialHeight(CDec(InitialHeightTextBox.Text))
        End If

        'If the initial height text box is 0, and the angle set is also 0 then set the angle to 1
        If CInt(InitialHeightTextBox.Text) = 0 And AngleTrackBar.Value = 0 Then
            AngleTrackBar.Value = 1
            AngleTextBox.Text = CStr(1)
            CurrentProjectile.SetAngle(CDec(AngleTrackBar.Value))
        Else
            'Else the user has an angle above 0 which is valid when starting at ground level
            CurrentProjectile.SetAngle(CDec(AngleTrackBar.Value))
        End If

        'The procedure to calculate all the characteristics of a projectile is called
        CurrentProjectile.CalculateValuesForProjectile()

        'Procedure to calculate the coordinates using SUVAT equations is called
        CurrentProjectile.SetCoordinatesArray()

        'Procedure to draw the graph is called
        DrawGraph()

        'The results are displayed on the side
        FillSimulationResults()

    End Sub

    'After calculation the properties of the object will need to be
    'displayed to the user in the respective textboxes
    Private Sub FillSimulationResults()
        InitialVerticalVelocityTextBox.Text = CStr(Math.Round(CurrentProjectile.GetInitialVerticalVelocity, 1))
        HorizontalVelocityTextBox.Text = CStr(Math.Round(CurrentProjectile.GetHorizontalVelocity, 1))
        MaximumHeightTextBox.Text = CStr(Math.Round(CurrentProjectile.GetMaximumHeight, 1))
        TimeUntilMaximumHeightTextBox.Text = CStr(Math.Round(CurrentProjectile.GetTimeUntilmaximumHeight, 1))
        RangeTextBox.Text = CStr(Math.Round(CurrentProjectile.GetRange, 1))
        FlightDurationTextBox.Text = CStr(Math.Round(CurrentProjectile.GetTimeUntilLanding, 1))
    End Sub

    Private Sub DrawGraph()
        'Firstly the graph is wiped of any currently drawn trajectory, and the axis values are reset
        WipeGraph()

        'An array is dimensioned and given a size of the time until the projectile lands multiplied by 100, so there are 100 array positions of coordinates per second of flight
        'Also a pen is created of a different colour to the axes for aesthetic purposes
        Dim CurrentCoordPoints(CurrentProjectile.GetCoordPoints.Length - 1) As PointF
        Dim TrajectoryPen As New Pen(Brushes.Red, 2)
        'The ratio of the panels width to the projectiles horizontal distance travelled
        Dim XRatio As Decimal = GraphPanel.Width / CurrentProjectile.GetRange()
        'The ratio of the panels height to the projectiles maximum height reached
        Dim YRatio As Decimal = GraphPanel.Height / CurrentProjectile.GetMaximumHeight()
        'The smallest ratio will be used to fit the whole curve on the graph
        Dim RatioToUse As Decimal

        ' If the x ratio is less than the y ratio, then it will be used
        If XRatio < YRatio Then
            RatioToUse = XRatio
        Else
            ' else the Y ratio will be used
            RatioToUse = YRatio
        End If

        'The array is filled with the current projectiles x and y floating point coordinates as calculated earlier
        CurrentCoordPoints = CurrentProjectile.GetCoordPoints()

        'Procedure to assign displacement values to axis of graph is called
        FillLabelsWithValues(RatioToUse)

        'Procedure to flip Y coordinates upside down is called
        FlipYCoordinateValues(CurrentCoordPoints, RatioToUse)

        'Procedure to draw the points is called
        DrawPointsOnGraph(CurrentCoordPoints, TrajectoryPen)

        'If the user selected the option for air resistance then the coordinate array is overwritten with a new array which includes the drag coefficient inputted by the user
        If DragCoefficientCheckBox.CheckState = CheckState.Checked And DragCoefficientTextBox.Text > CStr(0) Then
            CurrentProjectile.SetCoordinatesArray(DragCoefficientTextBox.Text)
            CurrentCoordPoints = CurrentProjectile.GetCoordPoints()
            'A different coloured pen is used to represent the line with air resistance
            Dim DragTrajectoryPen As New Pen(Brushes.Blue, 2)
            'The Y values are flipped upside down
            FlipYCoordinateValues(CurrentCoordPoints, RatioToUse)
            'The points are plotted on the graph using the DrawPointsOnGraph() procedure
            DrawPointsOnGraph(CurrentCoordPoints, DragTrajectoryPen)
        End If
    End Sub

    'Procedure to plot the coordinates on the panel using DrawLine()
    Private Sub DrawPointsOnGraph(ByVal inCoordPoints() As PointF, ByVal PenToUse As Pen)
        For Looper = 0 To inCoordPoints.Length - 2
            GraphPanel.CreateGraphics.DrawLine(PenToUse, inCoordPoints(Looper), inCoordPoints(Looper + 1))
            For Delay = 0 To 1000000
            Next
        Next
    End Sub

    Private Sub FlipYCoordinateValues(ByRef CoordsToFlip() As PointF, ByVal AxisRatio As Decimal)
        'Definite iteration that will flip the graph upside down, as the origin of the panel (0,0) is in the top left instead of the bottom left
        For Looper = 0 To CoordsToFlip.Length - 1
            'The coordinates are scaled appropriately using the passed in axis ratio before flipping
            CoordsToFlip(Looper).Y = (CoordsToFlip(Looper).Y) * AxisRatio - 1 '1 is subtracted so that the graph is 1 pixel higher so the DrawLine() doesn't overwrite the bottom black axis and make them red.
            CoordsToFlip(Looper).X = (CoordsToFlip(Looper).X) * AxisRatio
            'If the Y value is above the halfway point of the panels height (300)
            If CoordsToFlip(Looper).Y < (GraphPanel.Height / 2) Then
                'Then the Y value is incremented by half the panels height subtract the y value, all multiplied by 2
                CoordsToFlip(Looper).Y += (((GraphPanel.Height / 2) - CoordsToFlip(Looper).Y) * 2)
            Else
                'Else the Y value must be 300 or above, meaning the Y value is now decremented by the Y value subtracting half the panels height, all multiplied by 2
                CoordsToFlip(Looper).Y -= ((CoordsToFlip(Looper).Y - (GraphPanel.Height / 2)) * 2)
            End If
        Next
    End Sub

    'All the x and y axis subdivisions are set to the horizontal displacement, and vertical displacement respectively. They are set at quarter, half, three-qaurter and whole values
    Private Sub FillLabelsWithValues(ByVal AxisRatio As Decimal)
        X1Label.Text = CStr(Math.Round((GraphPanel.Width / AxisRatio) * 0.125, 1))
        X2Label.Text = CStr(Math.Round((GraphPanel.Width / AxisRatio) * 0.25, 1))
        X3Label.Text = CStr(Math.Round((GraphPanel.Width / AxisRatio) * 0.375, 1))
        X4Label.Text = CStr(Math.Round((GraphPanel.Width / AxisRatio) * 0.5, 1))
        X5Label.Text = CStr(Math.Round((GraphPanel.Width / AxisRatio) * 0.625, 1))
        X6Label.Text = CStr(Math.Round((GraphPanel.Width / AxisRatio) * 0.75, 1))
        X7Label.Text = CStr(Math.Round((GraphPanel.Width / AxisRatio) * 0.875, 1))
        X8Label.Text = CStr(Math.Round(GraphPanel.Width / AxisRatio, 1))

        Y1Label.Text = CStr(Math.Round((GraphPanel.Height / AxisRatio) * 0.125, 1))
        Y2Label.Text = CStr(Math.Round((GraphPanel.Height / AxisRatio) * 0.25, 1))
        Y3Label.Text = CStr(Math.Round((GraphPanel.Height / AxisRatio) * 0.375, 1))
        Y4Label.Text = CStr(Math.Round((GraphPanel.Height / AxisRatio) * 0.5, 1))
        Y5Label.Text = CStr(Math.Round((GraphPanel.Height / AxisRatio) * 0.625, 1))
        Y6Label.Text = CStr(Math.Round((GraphPanel.Height / AxisRatio) * 0.75, 1))
        Y7Label.Text = CStr(Math.Round((GraphPanel.Height / AxisRatio) * 0.875, 1))
        Y8Label.Text = CStr(Math.Round((GraphPanel.Height / AxisRatio), 1))
    End Sub

    'Event to constantly have the axis showing on the graph
    Private Sub GraphPanel_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GraphPanel.Paint
        'X and Y Axis including border around panel
        e.Graphics.DrawLine(Pens.Black, 0, 0, 0, GraphPanel.Height)
        e.Graphics.DrawLine(Pens.Black, GraphPanel.Width - 1, 0, GraphPanel.Width - 1, GraphPanel.Height)
        e.Graphics.DrawLine(Pens.Black, 0, GraphPanel.Height - 1, GraphPanel.Width, GraphPanel.Height - 1)
        e.Graphics.DrawLine(Pens.Black, 0, 0, GraphPanel.Width, 0)

    End Sub

    'Event to constantly have subdivisions across axis on the form
    '70 is where the origin of the panel is with respect to the form's origin
    Private Sub ProjectileMotionCalculator_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Subdivisions across X axis
        e.Graphics.DrawLine(Pens.Black, 70 + GraphPanel.Width - 1, 70 + GraphPanel.Height, 70 + GraphPanel.Width - 1, 70 + GraphPanel.Height + 5)
        e.Graphics.DrawLine(Pens.Black, CInt(GraphPanel.Width * 0.125) + 70, 70 + GraphPanel.Height, CInt(GraphPanel.Width * 0.125) + 70, 70 + GraphPanel.Height + 5)
        e.Graphics.DrawLine(Pens.Black, CInt(GraphPanel.Width * 0.25) + 70, 70 + GraphPanel.Height, CInt(GraphPanel.Width * 0.25) + 70, 70 + GraphPanel.Height + 5)
        e.Graphics.DrawLine(Pens.Black, CInt(GraphPanel.Width * 0.375) + 70, 70 + GraphPanel.Height, CInt(GraphPanel.Width * 0.375) + 70, 70 + GraphPanel.Height + 5)
        e.Graphics.DrawLine(Pens.Black, CInt(GraphPanel.Width * 0.5) + 70, 70 + GraphPanel.Height, CInt(GraphPanel.Width * 0.5) + 70, 70 + GraphPanel.Height + 5)
        e.Graphics.DrawLine(Pens.Black, CInt(GraphPanel.Width * 0.625) + 70, 70 + GraphPanel.Height, CInt(GraphPanel.Width * 0.625) + 70, 70 + GraphPanel.Height + 5)
        e.Graphics.DrawLine(Pens.Black, CInt(GraphPanel.Width * 0.75) + 70, 70 + GraphPanel.Height, CInt(GraphPanel.Width * 0.75) + 70, 70 + GraphPanel.Height + 5)
        e.Graphics.DrawLine(Pens.Black, CInt(GraphPanel.Width * 0.875) + 70, 70 + GraphPanel.Height, CInt(GraphPanel.Width * 0.875) + 70, 70 + GraphPanel.Height + 5)

        'Subdivisions along Y axis
        e.Graphics.DrawLine(Pens.Black, 70, 70, 65, 70)
        e.Graphics.DrawLine(Pens.Black, 70, CInt(GraphPanel.Height * 0.125) + 70, 65, CInt(GraphPanel.Height * 0.125) + 70)
        e.Graphics.DrawLine(Pens.Black, 70, CInt(GraphPanel.Height * 0.25) + 70, 65, CInt(GraphPanel.Height * 0.25) + 70)
        e.Graphics.DrawLine(Pens.Black, 70, CInt(GraphPanel.Height * 0.375) + 70, 65, CInt(GraphPanel.Height * 0.375) + 70)
        e.Graphics.DrawLine(Pens.Black, 70, CInt(GraphPanel.Height * 0.5) + 70, 65, CInt(GraphPanel.Height * 0.5) + 70)
        e.Graphics.DrawLine(Pens.Black, 70, CInt(GraphPanel.Height * 0.625) + 70, 65, CInt(GraphPanel.Height * 0.625) + 70)
        e.Graphics.DrawLine(Pens.Black, 70, CInt(GraphPanel.Height * 0.75) + 70, 65, CInt(GraphPanel.Height * 0.75) + 70)
        e.Graphics.DrawLine(Pens.Black, 70, CInt(GraphPanel.Height * 0.875) + 70, 65, CInt(GraphPanel.Height * 0.875) + 70)
    End Sub

    'Event to constantly have border around user input areas on the panel
    Private Sub InitialValuesPanel_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles InitialValuesPanel.Paint
        'Black line border around input area for user, for aesthetic purposes
        e.Graphics.DrawLine(Pens.Black, 0, 0, 0, InitialValuesPanel.Height)
        e.Graphics.DrawLine(Pens.Black, InitialValuesPanel.Width - 1, 0, InitialValuesPanel.Width - 1, InitialValuesPanel.Height)
        e.Graphics.DrawLine(Pens.Black, 0, InitialValuesPanel.Height - 1, InitialValuesPanel.Width, InitialValuesPanel.Height - 1)
        e.Graphics.DrawLine(Pens.Black, 0, 0, InitialValuesPanel.Width, 0)
    End Sub

    'Button to clear the graph and set result text boxes back to empty strings
    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        WipeGraph()
    End Sub

    'Procedure that will wipe the graph by clearing the panel and resetting all axis subdivision labels back to the X and Y placeholders.
    Private Sub WipeGraph()
        Me.Refresh()
        X1Label.Text = vbNullString
        X2Label.Text = vbNullString
        X3Label.Text = vbNullString
        X4Label.Text = vbNullString
        X5Label.Text = vbNullString
        X6Label.Text = vbNullString
        X7Label.Text = vbNullString
        X8Label.Text = vbNullString

        Y1Label.Text = vbNullString
        Y2Label.Text = vbNullString
        Y3Label.Text = vbNullString
        Y4Label.Text = vbNullString
        Y5Label.Text = vbNullString
        Y6Label.Text = vbNullString
        Y7Label.Text = vbNullString
        Y8Label.Text = vbNullString

        InitialVerticalVelocityTextBox.Text = vbNullString
        HorizontalVelocityTextBox.Text = vbNullString
        MaximumHeightTextBox.Text = vbNullString
        TimeUntilMaximumHeightTextBox.Text = vbNullString
        RangeTextBox.Text = vbNullString
        FlightDurationTextBox.Text = vbNullString
    End Sub

    'The following events are to make sure that the user can only use one of the options, that is using the combo box but not the custom text box, or vice versa.
    Private Sub CommonAccelRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CommonAccelRadioButton.CheckedChanged
        CustomAccelTextBox.Enabled = False
        CommonAccelComboBox.Enabled = True
    End Sub
    Private Sub CustomAccelRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CustomAccelRadioButton.CheckedChanged
        CommonAccelComboBox.Enabled = False
        CustomAccelTextBox.Enabled = True
    End Sub

    'Validation for the acceleration input
    Private Sub CustomAccelTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CustomAccelTextBox.TextChanged
        'If the value in the text box is not a number then
        If Not IsNumeric(CustomAccelTextBox.Text) Then
            If CustomAccelTextBox.Text = vbNullString And CustomAccelTextBox.Enabled = False Then
                'Do nothing if its an empty string
            Else
                'Else display the error message for having non numeric input
                MsgBox(NonNumericInputsErrorMessage)
                'Acceleration is set back to the default value for Earth
                CustomAccelTextBox.Text = CStr(9.81)
            End If
        Else
            'Else the text box does have a numeric value
            'If the numeric value is less than or equal to 0 then
            If CInt(CustomAccelTextBox.Text) <= 0 Or CInt(CustomAccelTextBox.Text) > 50 Then
                'Display the error message for having negative acceleration
                MsgBox(NegativeAccelerationErrorMessage)
                'Set the acceleration back to the default value for Earth
                CustomAccelTextBox.Text = CStr(9.81)
            End If
        End If
    End Sub

    'Validation for the initial velocity input
    Private Sub InitialVelocityTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles InitialVelocityTextBox.TextChanged
        'If the value in the etxt box is not a number then
        If Not IsNumeric(InitialVelocityTextBox.Text) Then
            If InitialVelocityTextBox.Text = vbNullString Then
                'Do nothing if its an empty string
            Else
                'Else display the error message for having non numeric input
                MsgBox(NonNumericInputsErrorMessage)
                'Set the initial velocity text box to an empty string so the user can try typing again
                InitialVelocityTextBox.Text = vbNullString
            End If
        Else
            'Else the text box does have a numeric value
            'If the numeric value is less then or equal to 0, or it is greater than 100 then
            If CInt(InitialVelocityTextBox.Text) <= 0 Or CInt(InitialVelocityTextBox.Text) > 100 Then
                'Display the error message for having a velocity out of the allowed range
                MsgBox(VelocityOutOfRangeErrorMessage)
                'The velocity is set to 20
                InitialVelocityTextBox.Text = CStr(20)
            End If
            'The track bar value is always updated to represent the value in the respective text box
            InitialVelocityTrackBar.Value = CInt(InitialVelocityTextBox.Text)
        End If
    End Sub

    'Validation for the initial height input
    Private Sub InitialHeightTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles InitialHeightTextBox.TextChanged
        'If the value in the text box is not a number then
        If Not IsNumeric(InitialHeightTextBox.Text) Then
            If InitialHeightTextBox.Text = vbNullString Then
                'Do nothing if the value is an empty string
            Else
                'Else display the error for having a non numeric input
                MsgBox(NonNumericInputsErrorMessage)
                'Set the initial height back to the default of 10 (ground level)
                InitialHeightTextBox.Text = CStr(0)
            End If
        Else
            'Else the value is a number
            'If the number is less than 0 (below ground) then
            If InitialHeightTextBox.Text < CStr(0) Or CInt(InitialHeightTextBox.Text) > 1000 Then
                'Display the error for having an invalid initial height
                MsgBox(NegativeInitialHeightErrorMessage)
                'Set the initial height back to the default value of 0
                InitialHeightTextBox.Text = CStr(0)
            End If
        End If
    End Sub

    'The next two procedures handle the event event to allow the user to type into the textbox, and that will update the slider value, and vice versa.
    Private Sub AngleTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles AngleTextBox.TextChanged
        'If the value entered by the user is not a numeric value then
        If Not IsNumeric(AngleTextBox.Text) Then
            'If the user has an empty text do nothing, as it may be that they wanted to change a value from 25 to 30 for example, by using backspace to remove the digits one by one until there is an empty string
            If AngleTextBox.Text = vbNullString Then
            Else
                'Display the error message for having a non numeric input
                MsgBox(NonNumericInputsErrorMessage)
                'Set the angle back to the default of 45
                AngleTextBox.Text = CStr(45)
            End If
        Else
            'Else if the numeric value is greater than 90 which is the maximum for the trackbar then give an error message.
            'Also the text box value is set back to the default 45, which will automatically be updated on the trackbar value aswell.
            If CInt(AngleTextBox.Text) > 90 Or CInt(AngleTextBox.Text) < 0 Then
                MsgBox(AngleOutOfRangeErrorMessage)
                AngleTextBox.Text = CStr(45)
            Else
                'At this point, the value entered by the user is numeric, and is also in between 0 and 90. Or it could be an empty string "" so the trackbar value doesnt change
                AngleTrackBar.Value = CInt(AngleTextBox.Text)
            End If
        End If
    End Sub

    'When the user drags the track bar for the angle, the respective text box is updated simultaneously
    Private Sub AngleTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles AngleTrackBar.Scroll
        AngleTextBox.Text = CStr(AngleTrackBar.Value)
    End Sub

    'When the user drags the velocity track bar, the respective text box is updated simultaneously
    Private Sub InitialVelocityTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles InitialVelocityTrackBar.Scroll
        InitialVelocityTextBox.Text = CStr(InitialVelocityTrackBar.Value)
    End Sub

    'If the user selects the option for air resistance, then the track bar to alter the value is shown
    Private Sub DragCoefficientCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles DragCoefficientCheckBox.CheckedChanged
        If DragCoefficientCheckBox.Checked Then
            DragCoefficientTrackBar.Visible = True
        Else
            'Else the text box value is set to 0, and the track bar is hidden
            DragCoefficientTextBox.Text = CStr(0)
            DragCoefficientTrackBar.Visible = False
        End If
    End Sub

    'When the user drags the dragcoefficient track bar, the text box value is updated simultaneously
    Private Sub DragCoefficientTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles DragCoefficientTrackBar.Scroll
        DragCoefficientTextBox.Text = CStr(DragCoefficientTrackBar.Value / 100)
    End Sub

    'When the user changes the text box value for dragcoefficient, the trackbar value is updated simultaneously
    Private Sub DragCoefficientTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DragCoefficientTextBox.TextChanged
        DragCoefficientTrackBar.Value = CDec(DragCoefficientTextBox.Text) * 100
    End Sub

    'When the user presses to save their simulation, the respective procedure is called
    Private Sub SaveAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveSimulation()
    End Sub

    'When the user presses to load a simulation, the respective procedure is called
    Private Sub LoadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        LoadSimulation()
        'The acceleration that was loaded is in the custom acceleration text box, so the option for common inputs is deactivated
        CommonAccelRadioButton.Checked = False
        CustomAccelRadioButton.Checked = True
        'The calculate button is "clicked" to draw the curve
        CalculateButton.PerformClick()
    End Sub

    'Procedure to save the drawn curve
    Private Sub SaveSimulation()
        'A window is opened for the user to select where to save the file, and give it a name
        Dim SaveDialog As New SaveFileDialog
        Dim FileName As String
        'The dialog  will only display binary files, as that is the format the simulation is saved in
        SaveDialog.Filter = DefaultFileDialogFilter
        SaveDialog.DefaultExt = DefaultFileDialogExtension
        'If the user presses OK to save then
        If SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FileName = SaveDialog.FileName
            'The file is opened in binary mode, if it doesnt exist a new one is created
            FileOpen(1, FileName, OpenMode.Binary, OpenAccess.Write)
            'The inputted values by the user for that particular simulation, are written to the file
            FilePutObject(1, CurrentProjectile.GetAcceleration)
            FilePutObject(1, CurrentProjectile.GetInitialVelocity)
            FilePutObject(1, CurrentProjectile.GetAngle)
            FilePutObject(1, CurrentProjectile.GetInitialHeight)
            'The file is closed after use
            FileClose(1)
        End If
    End Sub

    'Procedure to load a previously saved simulation
    Private Sub LoadSimulation()
        'A window is opened for the user to select which file they would like to load
        Dim OpenDialog As New OpenFileDialog
        Dim FileName As String
        'The displayed files in the dialog will only be binary files, so the user doesnt attempt to open files of a different format
        OpenDialog.Filter = DefaultFileDialogFilter
        OpenDialog.DefaultExt = DefaultFileDialogExtension
        'When the user presses OK to open the file then
        If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'The values are loaded one at a time, in the order they were saved, into the text boxes on the form
            FileName = OpenDialog.FileName
            FileOpen(1, FileName, OpenMode.Binary, OpenAccess.Read)
            FileGetObject(1, CustomAccelTextBox.Text)
            FileGetObject(1, InitialVelocityTextBox.Text)
            FileGetObject(1, AngleTextBox.Text)
            FileGetObject(1, InitialHeightTextBox.Text)
            'The file is closed after use
            FileClose(1)
        End If
    End Sub

    'A button to return to the main menu, and close the calculator form.
    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class