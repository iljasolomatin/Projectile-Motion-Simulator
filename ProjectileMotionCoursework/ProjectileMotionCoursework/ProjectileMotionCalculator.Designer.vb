<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectileMotionCalculator
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CommonAccelRadioButton = New System.Windows.Forms.RadioButton()
        Me.GraphPanel = New System.Windows.Forms.Panel()
        Me.KeyPanel = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.InitialVelocityTextBox = New System.Windows.Forms.TextBox()
        Me.AngleTextBox = New System.Windows.Forms.TextBox()
        Me.MaximumHeightTextBox = New System.Windows.Forms.TextBox()
        Me.HorizontalVelocityTextBox = New System.Windows.Forms.TextBox()
        Me.InitialVerticalVelocityTextBox = New System.Windows.Forms.TextBox()
        Me.RangeTextBox = New System.Windows.Forms.TextBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CustomAccelRadioButton = New System.Windows.Forms.RadioButton()
        Me.CustomAccelTextBox = New System.Windows.Forms.TextBox()
        Me.InitialHeightTextBox = New System.Windows.Forms.TextBox()
        Me.AngleTrackBar = New System.Windows.Forms.TrackBar()
        Me.CommonAccelComboBox = New System.Windows.Forms.ComboBox()
        Me.FlightDurationTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeUntilMaximumHeightTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.Y1Label = New System.Windows.Forms.Label()
        Me.Y2Label = New System.Windows.Forms.Label()
        Me.Y3Label = New System.Windows.Forms.Label()
        Me.Y4Label = New System.Windows.Forms.Label()
        Me.X1Label = New System.Windows.Forms.Label()
        Me.X2Label = New System.Windows.Forms.Label()
        Me.X3Label = New System.Windows.Forms.Label()
        Me.X4Label = New System.Windows.Forms.Label()
        Me.HorizontalDisplacementLabel = New System.Windows.Forms.Label()
        Me.InitialValuesPanel = New System.Windows.Forms.Panel()
        Me.InitialVelocityTrackBar = New System.Windows.Forms.TrackBar()
        Me.DragCoefficientTrackBar = New System.Windows.Forms.TrackBar()
        Me.DragCoefficientCheckBox = New System.Windows.Forms.CheckBox()
        Me.DragCoefficientTextBox = New System.Windows.Forms.TextBox()
        Me.ResultValuesLabel = New System.Windows.Forms.Label()
        Me.UserInputsLabel = New System.Windows.Forms.Label()
        Me.FormTitleLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Y5Label = New System.Windows.Forms.Label()
        Me.Y6Label = New System.Windows.Forms.Label()
        Me.Y7Label = New System.Windows.Forms.Label()
        Me.Y8Label = New System.Windows.Forms.Label()
        Me.X5Label = New System.Windows.Forms.Label()
        Me.X6Label = New System.Windows.Forms.Label()
        Me.X7Label = New System.Windows.Forms.Label()
        Me.X8Label = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphPanel.SuspendLayout()
        Me.KeyPanel.SuspendLayout()
        CType(Me.AngleTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InitialValuesPanel.SuspendLayout()
        CType(Me.InitialVelocityTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DragCoefficientTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Initial Velocity (ms⁻¹)              [1 to 100]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Angle (°)                                 [0 to 90]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Intial Height (m)                    [0 to 1000]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Range (m)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Maximum Height (m)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Horizontal Velocity (ms⁻¹)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Initial Vertical Velocity (ms⁻¹)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CommonAccelRadioButton
        '
        Me.CommonAccelRadioButton.AutoSize = True
        Me.CommonAccelRadioButton.Location = New System.Drawing.Point(16, 32)
        Me.CommonAccelRadioButton.Name = "CommonAccelRadioButton"
        Me.CommonAccelRadioButton.Size = New System.Drawing.Size(157, 17)
        Me.CommonAccelRadioButton.TabIndex = 8
        Me.CommonAccelRadioButton.TabStop = True
        Me.CommonAccelRadioButton.Text = "Common Acceleration (ms⁻²)"
        Me.CommonAccelRadioButton.UseVisualStyleBackColor = True
        '
        'GraphPanel
        '
        Me.GraphPanel.Controls.Add(Me.KeyPanel)
        Me.GraphPanel.Location = New System.Drawing.Point(70, 70)
        Me.GraphPanel.Name = "GraphPanel"
        Me.GraphPanel.Size = New System.Drawing.Size(900, 600)
        Me.GraphPanel.TabIndex = 30
        '
        'KeyPanel
        '
        Me.KeyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KeyPanel.Controls.Add(Me.Label13)
        Me.KeyPanel.Controls.Add(Me.Label12)
        Me.KeyPanel.Controls.Add(Me.Panel2)
        Me.KeyPanel.Controls.Add(Me.Panel1)
        Me.KeyPanel.Controls.Add(Me.Label10)
        Me.KeyPanel.Location = New System.Drawing.Point(746, 13)
        Me.KeyPanel.Name = "KeyPanel"
        Me.KeyPanel.Size = New System.Drawing.Size(141, 86)
        Me.KeyPanel.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(39, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "With Air Resistance"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "No Air Resistance"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(7, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(18, 17)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(7, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(18, 17)
        Me.Panel1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Key"
        '
        'InitialVelocityTextBox
        '
        Me.InitialVelocityTextBox.Location = New System.Drawing.Point(236, 167)
        Me.InitialVelocityTextBox.Name = "InitialVelocityTextBox"
        Me.InitialVelocityTextBox.Size = New System.Drawing.Size(35, 20)
        Me.InitialVelocityTextBox.TabIndex = 16
        Me.InitialVelocityTextBox.Text = "20"
        '
        'AngleTextBox
        '
        Me.AngleTextBox.Location = New System.Drawing.Point(236, 234)
        Me.AngleTextBox.Name = "AngleTextBox"
        Me.AngleTextBox.Size = New System.Drawing.Size(35, 20)
        Me.AngleTextBox.TabIndex = 17
        Me.AngleTextBox.Text = "45"
        '
        'MaximumHeightTextBox
        '
        Me.MaximumHeightTextBox.Location = New System.Drawing.Point(206, 404)
        Me.MaximumHeightTextBox.Name = "MaximumHeightTextBox"
        Me.MaximumHeightTextBox.ReadOnly = True
        Me.MaximumHeightTextBox.Size = New System.Drawing.Size(56, 20)
        Me.MaximumHeightTextBox.TabIndex = 20
        '
        'HorizontalVelocityTextBox
        '
        Me.HorizontalVelocityTextBox.Location = New System.Drawing.Point(206, 378)
        Me.HorizontalVelocityTextBox.Name = "HorizontalVelocityTextBox"
        Me.HorizontalVelocityTextBox.ReadOnly = True
        Me.HorizontalVelocityTextBox.Size = New System.Drawing.Size(56, 20)
        Me.HorizontalVelocityTextBox.TabIndex = 19
        '
        'InitialVerticalVelocityTextBox
        '
        Me.InitialVerticalVelocityTextBox.Location = New System.Drawing.Point(206, 353)
        Me.InitialVerticalVelocityTextBox.Name = "InitialVerticalVelocityTextBox"
        Me.InitialVerticalVelocityTextBox.ReadOnly = True
        Me.InitialVerticalVelocityTextBox.Size = New System.Drawing.Size(56, 20)
        Me.InitialVerticalVelocityTextBox.TabIndex = 18
        '
        'RangeTextBox
        '
        Me.RangeTextBox.Location = New System.Drawing.Point(206, 456)
        Me.RangeTextBox.Name = "RangeTextBox"
        Me.RangeTextBox.ReadOnly = True
        Me.RangeTextBox.Size = New System.Drawing.Size(56, 20)
        Me.RangeTextBox.TabIndex = 21
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(29, 567)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 22
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(187, 538)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 23
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CustomAccelRadioButton
        '
        Me.CustomAccelRadioButton.AutoSize = True
        Me.CustomAccelRadioButton.Location = New System.Drawing.Point(16, 55)
        Me.CustomAccelRadioButton.Name = "CustomAccelRadioButton"
        Me.CustomAccelRadioButton.Size = New System.Drawing.Size(214, 17)
        Me.CustomAccelRadioButton.TabIndex = 27
        Me.CustomAccelRadioButton.TabStop = True
        Me.CustomAccelRadioButton.Text = "Custom Acceleration (ms⁻²)        [0 to 50]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CustomAccelRadioButton.UseVisualStyleBackColor = True
        '
        'CustomAccelTextBox
        '
        Me.CustomAccelTextBox.Enabled = False
        Me.CustomAccelTextBox.Location = New System.Drawing.Point(236, 54)
        Me.CustomAccelTextBox.Name = "CustomAccelTextBox"
        Me.CustomAccelTextBox.Size = New System.Drawing.Size(35, 20)
        Me.CustomAccelTextBox.TabIndex = 28
        Me.CustomAccelTextBox.Text = "9.81"
        '
        'InitialHeightTextBox
        '
        Me.InitialHeightTextBox.Location = New System.Drawing.Point(236, 301)
        Me.InitialHeightTextBox.Name = "InitialHeightTextBox"
        Me.InitialHeightTextBox.Size = New System.Drawing.Size(35, 20)
        Me.InitialHeightTextBox.TabIndex = 29
        Me.InitialHeightTextBox.Text = "0"
        '
        'AngleTrackBar
        '
        Me.AngleTrackBar.Location = New System.Drawing.Point(29, 253)
        Me.AngleTrackBar.Maximum = 90
        Me.AngleTrackBar.Name = "AngleTrackBar"
        Me.AngleTrackBar.Size = New System.Drawing.Size(251, 45)
        Me.AngleTrackBar.TabIndex = 30
        Me.AngleTrackBar.Value = 45
        '
        'CommonAccelComboBox
        '
        Me.CommonAccelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CommonAccelComboBox.Enabled = False
        Me.CommonAccelComboBox.FormattingEnabled = True
        Me.CommonAccelComboBox.Items.AddRange(New Object() {"Earth (9.81)", "Jupiter (25.95)", "Neptune (14.07)", "Venus (8.87)", "Mars (3.77)", "Mercury (3.59)", "Moon (1.62)", "Pluto (0.42)"})
        Me.CommonAccelComboBox.Location = New System.Drawing.Point(176, 31)
        Me.CommonAccelComboBox.Name = "CommonAccelComboBox"
        Me.CommonAccelComboBox.Size = New System.Drawing.Size(95, 21)
        Me.CommonAccelComboBox.TabIndex = 31
        '
        'FlightDurationTextBox
        '
        Me.FlightDurationTextBox.Location = New System.Drawing.Point(206, 481)
        Me.FlightDurationTextBox.Name = "FlightDurationTextBox"
        Me.FlightDurationTextBox.ReadOnly = True
        Me.FlightDurationTextBox.Size = New System.Drawing.Size(56, 20)
        Me.FlightDurationTextBox.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Flight Duration (s)"
        '
        'TimeUntilMaximumHeightTextBox
        '
        Me.TimeUntilMaximumHeightTextBox.Location = New System.Drawing.Point(206, 430)
        Me.TimeUntilMaximumHeightTextBox.Name = "TimeUntilMaximumHeightTextBox"
        Me.TimeUntilMaximumHeightTextBox.ReadOnly = True
        Me.TimeUntilMaximumHeightTextBox.Size = New System.Drawing.Size(56, 20)
        Me.TimeUntilMaximumHeightTextBox.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 433)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Time Until Maximum Height (s)"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(29, 538)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 36
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'Y1Label
        '
        Me.Y1Label.AutoSize = True
        Me.Y1Label.Location = New System.Drawing.Point(29, 590)
        Me.Y1Label.Name = "Y1Label"
        Me.Y1Label.Size = New System.Drawing.Size(0, 13)
        Me.Y1Label.TabIndex = 0
        '
        'Y2Label
        '
        Me.Y2Label.AutoSize = True
        Me.Y2Label.Location = New System.Drawing.Point(29, 515)
        Me.Y2Label.Name = "Y2Label"
        Me.Y2Label.Size = New System.Drawing.Size(0, 13)
        Me.Y2Label.TabIndex = 37
        '
        'Y3Label
        '
        Me.Y3Label.AutoSize = True
        Me.Y3Label.Location = New System.Drawing.Point(29, 440)
        Me.Y3Label.Name = "Y3Label"
        Me.Y3Label.Size = New System.Drawing.Size(0, 13)
        Me.Y3Label.TabIndex = 38
        '
        'Y4Label
        '
        Me.Y4Label.AutoSize = True
        Me.Y4Label.Location = New System.Drawing.Point(29, 365)
        Me.Y4Label.Name = "Y4Label"
        Me.Y4Label.Size = New System.Drawing.Size(0, 13)
        Me.Y4Label.TabIndex = 39
        '
        'X1Label
        '
        Me.X1Label.AutoSize = True
        Me.X1Label.Location = New System.Drawing.Point(173, 685)
        Me.X1Label.Name = "X1Label"
        Me.X1Label.Size = New System.Drawing.Size(0, 13)
        Me.X1Label.TabIndex = 40
        '
        'X2Label
        '
        Me.X2Label.AutoSize = True
        Me.X2Label.Location = New System.Drawing.Point(285, 685)
        Me.X2Label.Name = "X2Label"
        Me.X2Label.Size = New System.Drawing.Size(0, 13)
        Me.X2Label.TabIndex = 41
        '
        'X3Label
        '
        Me.X3Label.AutoSize = True
        Me.X3Label.Location = New System.Drawing.Point(398, 685)
        Me.X3Label.Name = "X3Label"
        Me.X3Label.Size = New System.Drawing.Size(0, 13)
        Me.X3Label.TabIndex = 42
        '
        'X4Label
        '
        Me.X4Label.AutoSize = True
        Me.X4Label.Location = New System.Drawing.Point(510, 685)
        Me.X4Label.Name = "X4Label"
        Me.X4Label.Size = New System.Drawing.Size(0, 13)
        Me.X4Label.TabIndex = 43
        '
        'HorizontalDisplacementLabel
        '
        Me.HorizontalDisplacementLabel.AutoSize = True
        Me.HorizontalDisplacementLabel.Location = New System.Drawing.Point(451, 723)
        Me.HorizontalDisplacementLabel.Name = "HorizontalDisplacementLabel"
        Me.HorizontalDisplacementLabel.Size = New System.Drawing.Size(138, 13)
        Me.HorizontalDisplacementLabel.TabIndex = 44
        Me.HorizontalDisplacementLabel.Text = "Horizontal Displacement (m)"
        '
        'InitialValuesPanel
        '
        Me.InitialValuesPanel.BackColor = System.Drawing.SystemColors.Control
        Me.InitialValuesPanel.Controls.Add(Me.InitialVelocityTrackBar)
        Me.InitialValuesPanel.Controls.Add(Me.Label4)
        Me.InitialValuesPanel.Controls.Add(Me.InitialHeightTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.DragCoefficientTrackBar)
        Me.InitialValuesPanel.Controls.Add(Me.DragCoefficientCheckBox)
        Me.InitialValuesPanel.Controls.Add(Me.DragCoefficientTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.ResultValuesLabel)
        Me.InitialValuesPanel.Controls.Add(Me.UserInputsLabel)
        Me.InitialValuesPanel.Controls.Add(Me.CommonAccelRadioButton)
        Me.InitialValuesPanel.Controls.Add(Me.Label2)
        Me.InitialValuesPanel.Controls.Add(Me.Label3)
        Me.InitialValuesPanel.Controls.Add(Me.Label8)
        Me.InitialValuesPanel.Controls.Add(Me.Label7)
        Me.InitialValuesPanel.Controls.Add(Me.Label6)
        Me.InitialValuesPanel.Controls.Add(Me.Label5)
        Me.InitialValuesPanel.Controls.Add(Me.InitialVelocityTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.AngleTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.BackButton)
        Me.InitialValuesPanel.Controls.Add(Me.CalculateButton)
        Me.InitialValuesPanel.Controls.Add(Me.InitialVerticalVelocityTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.TimeUntilMaximumHeightTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.HorizontalVelocityTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.Label11)
        Me.InitialValuesPanel.Controls.Add(Me.MaximumHeightTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.FlightDurationTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.RangeTextBox)
        Me.InitialValuesPanel.Controls.Add(Me.Label1)
        Me.InitialValuesPanel.Controls.Add(Me.ClearButton)
        Me.InitialValuesPanel.Controls.Add(Me.CommonAccelComboBox)
        Me.InitialValuesPanel.Controls.Add(Me.CustomAccelRadioButton)
        Me.InitialValuesPanel.Controls.Add(Me.AngleTrackBar)
        Me.InitialValuesPanel.Controls.Add(Me.CustomAccelTextBox)
        Me.InitialValuesPanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InitialValuesPanel.Location = New System.Drawing.Point(998, 70)
        Me.InitialValuesPanel.Name = "InitialValuesPanel"
        Me.InitialValuesPanel.Size = New System.Drawing.Size(290, 600)
        Me.InitialValuesPanel.TabIndex = 45
        '
        'InitialVelocityTrackBar
        '
        Me.InitialVelocityTrackBar.Location = New System.Drawing.Point(29, 187)
        Me.InitialVelocityTrackBar.Maximum = 100
        Me.InitialVelocityTrackBar.Minimum = 1
        Me.InitialVelocityTrackBar.Name = "InitialVelocityTrackBar"
        Me.InitialVelocityTrackBar.Size = New System.Drawing.Size(251, 45)
        Me.InitialVelocityTrackBar.TabIndex = 57
        Me.InitialVelocityTrackBar.Value = 20
        '
        'DragCoefficientTrackBar
        '
        Me.DragCoefficientTrackBar.Location = New System.Drawing.Point(29, 105)
        Me.DragCoefficientTrackBar.Maximum = 100
        Me.DragCoefficientTrackBar.Name = "DragCoefficientTrackBar"
        Me.DragCoefficientTrackBar.Size = New System.Drawing.Size(242, 45)
        Me.DragCoefficientTrackBar.TabIndex = 55
        '
        'DragCoefficientCheckBox
        '
        Me.DragCoefficientCheckBox.AutoSize = True
        Me.DragCoefficientCheckBox.Location = New System.Drawing.Point(16, 82)
        Me.DragCoefficientCheckBox.Name = "DragCoefficientCheckBox"
        Me.DragCoefficientCheckBox.Size = New System.Drawing.Size(138, 17)
        Me.DragCoefficientCheckBox.TabIndex = 54
        Me.DragCoefficientCheckBox.Text = "Drag Coefficient (0 to 1)"
        Me.DragCoefficientCheckBox.UseVisualStyleBackColor = True
        '
        'DragCoefficientTextBox
        '
        Me.DragCoefficientTextBox.Enabled = False
        Me.DragCoefficientTextBox.Location = New System.Drawing.Point(236, 80)
        Me.DragCoefficientTextBox.Name = "DragCoefficientTextBox"
        Me.DragCoefficientTextBox.Size = New System.Drawing.Size(35, 20)
        Me.DragCoefficientTextBox.TabIndex = 53
        Me.DragCoefficientTextBox.Text = "0"
        '
        'ResultValuesLabel
        '
        Me.ResultValuesLabel.AutoSize = True
        Me.ResultValuesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultValuesLabel.Location = New System.Drawing.Point(26, 332)
        Me.ResultValuesLabel.Name = "ResultValuesLabel"
        Me.ResultValuesLabel.Size = New System.Drawing.Size(49, 13)
        Me.ResultValuesLabel.TabIndex = 49
        Me.ResultValuesLabel.Text = "Results"
        '
        'UserInputsLabel
        '
        Me.UserInputsLabel.AutoSize = True
        Me.UserInputsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInputsLabel.Location = New System.Drawing.Point(35, 13)
        Me.UserInputsLabel.Name = "UserInputsLabel"
        Me.UserInputsLabel.Size = New System.Drawing.Size(87, 13)
        Me.UserInputsLabel.TabIndex = 48
        Me.UserInputsLabel.Text = "Data To Enter"
        '
        'FormTitleLabel
        '
        Me.FormTitleLabel.AutoSize = True
        Me.FormTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormTitleLabel.Location = New System.Drawing.Point(393, 18)
        Me.FormTitleLabel.Name = "FormTitleLabel"
        Me.FormTitleLabel.Size = New System.Drawing.Size(372, 31)
        Me.FormTitleLabel.TabIndex = 46
        Me.FormTitleLabel.Text = "Projectile Motion Calculator"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 299)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "p" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "n" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(m)"
        '
        'Y5Label
        '
        Me.Y5Label.AutoSize = True
        Me.Y5Label.Location = New System.Drawing.Point(29, 290)
        Me.Y5Label.Name = "Y5Label"
        Me.Y5Label.Size = New System.Drawing.Size(0, 13)
        Me.Y5Label.TabIndex = 48
        '
        'Y6Label
        '
        Me.Y6Label.AutoSize = True
        Me.Y6Label.Location = New System.Drawing.Point(29, 215)
        Me.Y6Label.Name = "Y6Label"
        Me.Y6Label.Size = New System.Drawing.Size(0, 13)
        Me.Y6Label.TabIndex = 49
        '
        'Y7Label
        '
        Me.Y7Label.AutoSize = True
        Me.Y7Label.Location = New System.Drawing.Point(29, 140)
        Me.Y7Label.Name = "Y7Label"
        Me.Y7Label.Size = New System.Drawing.Size(0, 13)
        Me.Y7Label.TabIndex = 50
        '
        'Y8Label
        '
        Me.Y8Label.AutoSize = True
        Me.Y8Label.Location = New System.Drawing.Point(29, 65)
        Me.Y8Label.Name = "Y8Label"
        Me.Y8Label.Size = New System.Drawing.Size(0, 13)
        Me.Y8Label.TabIndex = 51
        '
        'X5Label
        '
        Me.X5Label.AutoSize = True
        Me.X5Label.Location = New System.Drawing.Point(623, 685)
        Me.X5Label.Name = "X5Label"
        Me.X5Label.Size = New System.Drawing.Size(0, 13)
        Me.X5Label.TabIndex = 52
        '
        'X6Label
        '
        Me.X6Label.AutoSize = True
        Me.X6Label.Location = New System.Drawing.Point(735, 685)
        Me.X6Label.Name = "X6Label"
        Me.X6Label.Size = New System.Drawing.Size(0, 13)
        Me.X6Label.TabIndex = 53
        '
        'X7Label
        '
        Me.X7Label.AutoSize = True
        Me.X7Label.Location = New System.Drawing.Point(848, 685)
        Me.X7Label.Name = "X7Label"
        Me.X7Label.Size = New System.Drawing.Size(0, 13)
        Me.X7Label.TabIndex = 54
        '
        'X8Label
        '
        Me.X8Label.AutoSize = True
        Me.X8Label.Location = New System.Drawing.Point(960, 685)
        Me.X8Label.Name = "X8Label"
        Me.X8Label.Size = New System.Drawing.Size(0, 13)
        Me.X8Label.TabIndex = 55
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1322, 24)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ProjectileMotionCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 762)
        Me.Controls.Add(Me.X8Label)
        Me.Controls.Add(Me.X7Label)
        Me.Controls.Add(Me.X6Label)
        Me.Controls.Add(Me.X5Label)
        Me.Controls.Add(Me.Y8Label)
        Me.Controls.Add(Me.Y7Label)
        Me.Controls.Add(Me.Y6Label)
        Me.Controls.Add(Me.Y5Label)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.FormTitleLabel)
        Me.Controls.Add(Me.InitialValuesPanel)
        Me.Controls.Add(Me.HorizontalDisplacementLabel)
        Me.Controls.Add(Me.X4Label)
        Me.Controls.Add(Me.X3Label)
        Me.Controls.Add(Me.X2Label)
        Me.Controls.Add(Me.X1Label)
        Me.Controls.Add(Me.Y4Label)
        Me.Controls.Add(Me.Y3Label)
        Me.Controls.Add(Me.Y2Label)
        Me.Controls.Add(Me.Y1Label)
        Me.Controls.Add(Me.GraphPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1338, 801)
        Me.MinimumSize = New System.Drawing.Size(1338, 801)
        Me.Name = "ProjectileMotionCalculator"
        Me.Text = "Projectile Motion Calculator"
        Me.GraphPanel.ResumeLayout(False)
        Me.KeyPanel.ResumeLayout(False)
        Me.KeyPanel.PerformLayout()
        CType(Me.AngleTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InitialValuesPanel.ResumeLayout(False)
        Me.InitialValuesPanel.PerformLayout()
        CType(Me.InitialVelocityTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DragCoefficientTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CommonAccelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GraphPanel As System.Windows.Forms.Panel
    Friend WithEvents InitialVelocityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AngleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaximumHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HorizontalVelocityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InitialVerticalVelocityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RangeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CustomAccelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CustomAccelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InitialHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AngleTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents CommonAccelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FlightDurationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimeUntilMaximumHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents Y1Label As System.Windows.Forms.Label
    Friend WithEvents Y2Label As System.Windows.Forms.Label
    Friend WithEvents Y3Label As System.Windows.Forms.Label
    Friend WithEvents Y4Label As System.Windows.Forms.Label
    Friend WithEvents X1Label As System.Windows.Forms.Label
    Friend WithEvents X2Label As System.Windows.Forms.Label
    Friend WithEvents X3Label As System.Windows.Forms.Label
    Friend WithEvents X4Label As System.Windows.Forms.Label
    Friend WithEvents HorizontalDisplacementLabel As System.Windows.Forms.Label
    Friend WithEvents InitialValuesPanel As System.Windows.Forms.Panel
    Friend WithEvents FormTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UserInputsLabel As System.Windows.Forms.Label
    Friend WithEvents ResultValuesLabel As System.Windows.Forms.Label
    Friend WithEvents DragCoefficientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DragCoefficientCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DragCoefficientTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Y5Label As System.Windows.Forms.Label
    Friend WithEvents Y6Label As System.Windows.Forms.Label
    Friend WithEvents Y7Label As System.Windows.Forms.Label
    Friend WithEvents Y8Label As System.Windows.Forms.Label
    Friend WithEvents X5Label As System.Windows.Forms.Label
    Friend WithEvents X6Label As System.Windows.Forms.Label
    Friend WithEvents X7Label As System.Windows.Forms.Label
    Friend WithEvents X8Label As System.Windows.Forms.Label
    Friend WithEvents KeyPanel As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents InitialVelocityTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
