<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoForm))
        Me.StartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.ResultImage = New System.Windows.Forms.PictureBox()
        CType(Me.ResultImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartTimer
        '
        Me.StartTimer.Interval = 5
        '
        'StopTimer
        '
        Me.StopTimer.Interval = 5
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(113, 290)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(92, 30)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ResultBox
        '
        Me.ResultBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.ResultBox.ForeColor = System.Drawing.Color.White
        Me.ResultBox.Location = New System.Drawing.Point(12, 12)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(294, 83)
        Me.ResultBox.TabIndex = 1
        Me.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultImage
        '
        Me.ResultImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultImage.Image = CType(resources.GetObject("ResultImage.Image"), System.Drawing.Image)
        Me.ResultImage.Location = New System.Drawing.Point(12, 107)
        Me.ResultImage.Name = "ResultImage"
        Me.ResultImage.Size = New System.Drawing.Size(294, 177)
        Me.ResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ResultImage.TabIndex = 2
        Me.ResultImage.TabStop = False
        '
        'InfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 328)
        Me.Controls.Add(Me.ResultImage)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "InfoForm"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator - Info"
        CType(Me.ResultImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartTimer As Timer
    Friend WithEvents StopTimer As Timer
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents ResultImage As PictureBox
End Class
