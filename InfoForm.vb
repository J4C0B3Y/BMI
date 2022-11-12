Public Class InfoForm

    ' ----- Start Fade ----- '

    ' Increases opacity until 100% then stops the timer '
    Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        If Opacity < 1 Then
            Opacity += 0.05
        Else
            StartTimer.Enabled = False
        End If
    End Sub

    ' Starts the fade in when the form loads '
    Private Sub InfoForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        StartTimer.Enabled = True
    End Sub

    ' ----- Stop Fade ----- '

    ' Decreases opacity until 0% and then closes the window '
    Private Sub StopTimer_Tick(sender As Object, e As EventArgs) Handles StopTimer.Tick
        If Opacity > 0 Then
            Opacity -= 0.05
        Else
            Close()
        End If
    End Sub

    ' Starts the fade out when ExitButton is clicked '
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        StopTimer.Enabled = True
    End Sub
End Class