Public Class CalculatorForm

    ' ----- Calculation Variables ----- '

    ' Kilograms '
    Dim kgs As Double
    ' Centimeters'
    Dim cms As Double

    ' ----- Conversion Functions ----- '

    ' Converts feets and inches to cms '
    Function ImperialToMetricHeight(feet As Double, inches As Double)
        Return Math.Round(feet * 30.48 + inches * 2.54)
    End Function

    ' Converts lbs to kgs '
    Function ImperialToMetricWeight(lbs As Double)
        Return Math.Round(lbs / 2.2046)
    End Function

    ' Converts cms to feet and inches '
    Function MetricToImperialHeight(cm As Double)
        Dim total = cm / 2.54
        Dim feet = Math.Floor(total / 12)
        Dim inches = Math.Round(total - 12 * feet)
        Return {feet, inches}
    End Function

    ' Converts kgs to lbs '
    Function MetricToImperialWeight(kgs As Double)
        Return Math.Floor(kgs * 2.2046)
    End Function

    ' ----- Start Fade ----- '

    ' Increases opacity until 100% then stops the timer '
    Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        If Opacity < 1 Then
            Opacity += 0.05
        Else
            StartTimer.Enabled = False
        End If
    End Sub

    ' Starts the fade in when the window loads '
    Private Sub CalculatorForm_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    ' ----- Reset Values ----- '
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ' Reset Conversion Sliders '
        WeightSlider.Value = 0
        HeightSlider.Value = 0
        ' Reset Results '
        ResultBox.Text = ""
        ' Reset Inputs '
        WeightInput.Text = 0
        HeightInput.Text = 0
    End Sub

    ' ----- Input Changes ----- '

    ' Weight Input Changes '
    Private Sub WeightInput_TextChanged(sender As Object, e As EventArgs) Handles WeightInput.TextChanged
        ' Checks if weight input's text is a valid number '
        If Double.TryParse(WeightInput.Text, vbNull) Then
            ' If weight slider is set to lbs then converts weight input's text to metric and set kgs to it'
            ' Else sets kgs to weight input's text without converting it '
            If WeightSlider.Value Then
                kgs = ImperialToMetricWeight(WeightInput.Text)
            Else
                kgs = WeightInput.Text
            End If
        End If
    End Sub

    ' Height Input Changes '
    Private Sub HeightInput_TextChanged(sender As Object, e As EventArgs) Handles HeightInput.TextChanged
        ' Checks if height input's text is a valid number '
        If Double.TryParse(HeightInput.Text, vbNull) Then
            ' Sets cms to height input's text '
            cms = HeightInput.Text
        End If
    End Sub

    Private Sub FeetInput_TextChanged(sender As Object, e As EventArgs) Handles FeetInput.TextChanged
        ' Checks if feet input's text is a valid number '
        If Double.TryParse(FeetInput.Text, vbNull) AndAlso Double.TryParse(InchesInput.Text, vbNull) Then
            ' Convets feet and inches's text to imperial and then sets cms to it '
            cms = ImperialToMetricHeight(FeetInput.Text, InchesInput.Text)
        End If
    End Sub

    Private Sub InchesInput_TextChanged(sender As Object, e As EventArgs) Handles InchesInput.TextChanged
        ' Checks if inches input's text is a valid number '
        If Double.TryParse(FeetInput.Text, vbNull) AndAlso Double.TryParse(InchesInput.Text, vbNull) Then
            ' Convets feet and inches's text to imperial and then sets cms to it '
            cms = ImperialToMetricHeight(FeetInput.Text, InchesInput.Text)
        End If
    End Sub

    ' ----- Conversion Slider Changes ----- '

    ' Weight conversion slider '
    Private Sub WeightSlider_ValueChanged(sender As Object, e As EventArgs) Handles WeightSlider.ValueChanged
        ' Converts kgs to lbs if slider is set to lbs '
        ' else keeps kgs if slider is set to kgs '
        If WeightSlider.Value Then
            WeightInput.Text = MetricToImperialWeight(kgs)
        Else
            WeightInput.Text = kgs
        End If
    End Sub

    ' Height conversion slider '
    Private Sub HeightSlider_ValueChanged(sender As Object, e As EventArgs) Handles HeightSlider.ValueChanged
        ' Shows metric height input if slider is set to cms '
        HeightInput.Visible = HeightSlider.Value = 0

        ' Shows imperial hight sliders if slider is set to ft '
        FeetInput.Visible = HeightSlider.Value
        InchesInput.Visible = HeightSlider.Value

        ' Shows feet and inches symbols if slider is set to ft '
        ImperialLable.Visible = HeightSlider.Value

        ' Converts cms to feet and inches if slider is set to ft '
        ' else keeps cms if slider is set to cms ' 
        If HeightSlider.Value Then
            Dim result = MetricToImperialHeight(cms)
            FeetInput.Text = result(0)
            InchesInput.Text = result(1)
        Else
            HeightInput.Text = cms
        End If
    End Sub

    ' ----- Calculation ----- '
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Does the BMI calculation and stores stores the BMI in the result variable '
        Dim result = Math.Round(kgs / cms / cms * 10000, 2)

        ' Checks if result is a valid number '
        If result.ToString <> "NaN" Then
            ' Sets the result text box's text to result '
            ResultBox.Text = result
        End If
    End Sub

    ' ----- Clipboard ----- '

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        ' Checks if result box's text is a valid number '
        If Double.TryParse(ResultBox.Text, vbNull) Then
            ' Copies result box's text to clipboard '
            My.Computer.Clipboard.SetText(ResultBox.Text)
        End If
    End Sub

    ' ----- InfoForm ----- '

    Private Sub InfoButton_Click(sender As Object, e As EventArgs) Handles InfoButton.Click
        ' Skips code if result box's text is an invalid number '
        If Double.TryParse(ResultBox.Text, vbNull) = False Then
            Return
        End If

        ' Creates and shows the InfoForm '
        Dim info = New InfoForm()
        info.Show()

        ' Set the InfoForm's posision to the right of the calculator '
        info.SetBounds(Left + (Right - Left), Top, info.Width, info.Height)

        ' Sets the InfoForm's result box to the BMI result '
        info.ResultBox.Text = ResultBox.Text

        ' Checks the BMI value and sets the colour of the result box accordingly '
        If info.ResultBox.Text < 18.5 Then
            info.ResultBox.BackColor = Color.DeepSkyBlue
        ElseIf info.ResultBox.Text < 25 Then
            info.ResultBox.BackColor = Color.ForestGreen
        ElseIf info.ResultBox.Text < 30 Then
            info.ResultBox.BackColor = Color.Gold
        ElseIf info.ResultBox.Text < 40 Then
            info.ResultBox.BackColor = Color.Orange
        ElseIf info.ResultBox.Text >= 40 Then
            info.ResultBox.BackColor = Color.DarkRed
        End If
    End Sub

    ' ----- Enter Calculate ----- '

    Private Sub Enter_KeyDown(sender As Object, keyEvent As KeyEventArgs) Handles WeightInput.KeyDown, HeightInput.KeyDown, FeetInput.KeyDown, InchesInput.KeyDown
        ' Checks if the enter key is pressed'
        If keyEvent.KeyCode = 13 Then
            ' Clicks the calculate button '
            CalculateButton.PerformClick()
            ' Stops windows from making a sound by suppressing the keypress '
            keyEvent.SuppressKeyPress = True
        End If
    End Sub

End Class