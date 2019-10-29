<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.MainMenuLabel = New System.Windows.Forms.Label()
        Me.ProjectileMotionCalculatorButton = New System.Windows.Forms.Button()
        Me.PastPapersButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MainMenuLabel
        '
        Me.MainMenuLabel.AutoSize = True
        Me.MainMenuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuLabel.Location = New System.Drawing.Point(237, 111)
        Me.MainMenuLabel.Name = "MainMenuLabel"
        Me.MainMenuLabel.Size = New System.Drawing.Size(158, 33)
        Me.MainMenuLabel.TabIndex = 0
        Me.MainMenuLabel.Text = "Main Menu"
        '
        'ProjectileMotionCalculatorButton
        '
        Me.ProjectileMotionCalculatorButton.Location = New System.Drawing.Point(224, 164)
        Me.ProjectileMotionCalculatorButton.Name = "ProjectileMotionCalculatorButton"
        Me.ProjectileMotionCalculatorButton.Size = New System.Drawing.Size(75, 39)
        Me.ProjectileMotionCalculatorButton.TabIndex = 1
        Me.ProjectileMotionCalculatorButton.Text = "Calculator"
        Me.ProjectileMotionCalculatorButton.UseVisualStyleBackColor = True
        '
        'PastPapersButton
        '
        Me.PastPapersButton.Location = New System.Drawing.Point(327, 164)
        Me.PastPapersButton.Name = "PastPapersButton"
        Me.PastPapersButton.Size = New System.Drawing.Size(75, 39)
        Me.PastPapersButton.TabIndex = 3
        Me.PastPapersButton.Text = "Past Papers"
        Me.PastPapersButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Projectile Motion Teaching Aid"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 245)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PastPapersButton)
        Me.Controls.Add(Me.ProjectileMotionCalculatorButton)
        Me.Controls.Add(Me.MainMenuLabel)
        Me.Name = "Form1"
        Me.Text = "Projectile Motion - Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenuLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectileMotionCalculatorButton As System.Windows.Forms.Button
    Friend WithEvents PastPapersButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
