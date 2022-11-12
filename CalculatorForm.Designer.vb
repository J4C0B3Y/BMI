<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculatorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WeightSlider = New System.Windows.Forms.TrackBar()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.HeightSlider = New System.Windows.Forms.TrackBar()
        Me.WeightLabel = New System.Windows.Forms.Label()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.WeightInput = New System.Windows.Forms.TextBox()
        Me.HeightInput = New System.Windows.Forms.TextBox()
        Me.FeetInput = New System.Windows.Forms.TextBox()
        Me.InchesInput = New System.Windows.Forms.TextBox()
        Me.ImperialLable = New System.Windows.Forms.Label()
        Me.InfoButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        CType(Me.WeightSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(253, 266)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(56, 43)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StopTimer
        '
        Me.StopTimer.Interval = 5
        '
        'StartTimer
        '
        Me.StartTimer.Interval = 5
        '
        'WeightSlider
        '
        Me.WeightSlider.Cursor = System.Windows.Forms.Cursors.Default
        Me.WeightSlider.Location = New System.Drawing.Point(36, 129)
        Me.WeightSlider.Maximum = 1
        Me.WeightSlider.Name = "WeightSlider"
        Me.WeightSlider.Size = New System.Drawing.Size(82, 45)
        Me.WeightSlider.TabIndex = 2
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.CalculateButton.Location = New System.Drawing.Point(73, 255)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(172, 64)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "CALCULATE"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(9, 266)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(56, 43)
        Me.ResetButton.TabIndex = 4
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'HeightSlider
        '
        Me.HeightSlider.Location = New System.Drawing.Point(198, 129)
        Me.HeightSlider.Maximum = 1
        Me.HeightSlider.Name = "HeightSlider"
        Me.HeightSlider.Size = New System.Drawing.Size(82, 45)
        Me.HeightSlider.TabIndex = 5
        '
        'WeightLabel
        '
        Me.WeightLabel.AutoSize = True
        Me.WeightLabel.Location = New System.Drawing.Point(41, 113)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(72, 13)
        Me.WeightLabel.TabIndex = 7
        Me.WeightLabel.Text = "kg               lb"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(202, 113)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(72, 13)
        Me.HeightLabel.TabIndex = 8
        Me.HeightLabel.Text = "cm               ft"
        '
        'ResultBox
        '
        Me.ResultBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResultBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.ResultBox.Location = New System.Drawing.Point(12, 12)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(294, 83)
        Me.ResultBox.TabIndex = 9
        Me.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightInput
        '
        Me.WeightInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.WeightInput.Location = New System.Drawing.Point(24, 173)
        Me.WeightInput.Name = "WeightInput"
        Me.WeightInput.Size = New System.Drawing.Size(108, 38)
        Me.WeightInput.TabIndex = 11
        Me.WeightInput.Text = "0"
        Me.WeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeightInput
        '
        Me.HeightInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.HeightInput.Location = New System.Drawing.Point(184, 173)
        Me.HeightInput.Name = "HeightInput"
        Me.HeightInput.Size = New System.Drawing.Size(108, 38)
        Me.HeightInput.TabIndex = 12
        Me.HeightInput.Text = "0"
        Me.HeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FeetInput
        '
        Me.FeetInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.FeetInput.Location = New System.Drawing.Point(184, 173)
        Me.FeetInput.Name = "FeetInput"
        Me.FeetInput.Size = New System.Drawing.Size(45, 38)
        Me.FeetInput.TabIndex = 13
        Me.FeetInput.Text = "0"
        Me.FeetInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FeetInput.Visible = False
        '
        'InchesInput
        '
        Me.InchesInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.InchesInput.Location = New System.Drawing.Point(246, 173)
        Me.InchesInput.Name = "InchesInput"
        Me.InchesInput.Size = New System.Drawing.Size(46, 38)
        Me.InchesInput.TabIndex = 14
        Me.InchesInput.Text = "0"
        Me.InchesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InchesInput.Visible = False
        '
        'ImperialLable
        '
        Me.ImperialLable.AutoSize = True
        Me.ImperialLable.Location = New System.Drawing.Point(229, 175)
        Me.ImperialLable.Name = "ImperialLable"
        Me.ImperialLable.Size = New System.Drawing.Size(74, 13)
        Me.ImperialLable.TabIndex = 15
        Me.ImperialLable.Text = "'                    """
        Me.ImperialLable.Visible = False
        '
        'InfoButton
        '
        Me.InfoButton.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!)
        Me.InfoButton.Location = New System.Drawing.Point(146, 181)
        Me.InfoButton.Name = "InfoButton"
        Me.InfoButton.Size = New System.Drawing.Size(24, 24)
        Me.InfoButton.TabIndex = 16
        Me.InfoButton.Text = "i"
        Me.InfoButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(101, 223)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(115, 23)
        Me.CopyButton.TabIndex = 17
        Me.CopyButton.Text = "COPY"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 328)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.InfoButton)
        Me.Controls.Add(Me.InchesInput)
        Me.Controls.Add(Me.FeetInput)
        Me.Controls.Add(Me.HeightInput)
        Me.Controls.Add(Me.WeightInput)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.WeightLabel)
        Me.Controls.Add(Me.HeightSlider)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.WeightSlider)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ImperialLable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CalculatorForm"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator"
        CType(Me.WeightSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As Button
    Friend WithEvents StopTimer As Timer
    Friend WithEvents StartTimer As Timer
    Friend WithEvents WeightSlider As TrackBar
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents HeightSlider As TrackBar
    Friend WithEvents WeightLabel As Label
    Friend WithEvents HeightLabel As Label
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents WeightInput As TextBox
    Friend WithEvents HeightInput As TextBox
    Friend WithEvents FeetInput As TextBox
    Friend WithEvents InchesInput As TextBox
    Friend WithEvents ImperialLable As Label
    Friend WithEvents InfoButton As Button
    Friend WithEvents CopyButton As Button
End Class
