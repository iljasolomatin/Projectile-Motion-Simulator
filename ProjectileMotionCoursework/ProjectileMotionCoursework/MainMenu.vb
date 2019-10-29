Public Class MainMenu
    'Button to show the calculator form, and close the main menu
    Private Sub ProjectileMotionCalculatorButton_Click(sender As System.Object, e As System.EventArgs) Handles ProjectileMotionCalculatorButton.Click
        ProjectileMotionCalculator.Show()
        Me.Close()
    End Sub

    'Button to show the past papers form, and close the main menu
    Private Sub PastPapersButton_Click(sender As System.Object, e As System.EventArgs) Handles PastPapersButton.Click
        PastPaperManagementForm.Show()
        Me.Close()
    End Sub
End Class