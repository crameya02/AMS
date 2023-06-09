<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scanQR
    Inherits MaterialSkin.Controls.MaterialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanQR))
        Me.dateTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpm = New System.Windows.Forms.Label()
        Me.lblam = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDetect = New MaterialSkin.Controls.MaterialButton()
        Me.btnStart = New MaterialSkin.Controls.MaterialButton()
        Me.btnStop = New MaterialSkin.Controls.MaterialButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateTimeTimer
        '
        Me.dateTimeTimer.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(657, 431)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "PM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(657, 215)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "AM"
        '
        'lblpm
        '
        Me.lblpm.AutoSize = True
        Me.lblpm.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpm.Location = New System.Drawing.Point(672, 431)
        Me.lblpm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpm.Name = "lblpm"
        Me.lblpm.Size = New System.Drawing.Size(209, 145)
        Me.lblpm.TabIndex = 34
        Me.lblpm.Text = "AM"
        '
        'lblam
        '
        Me.lblam.AutoSize = True
        Me.lblam.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblam.Location = New System.Drawing.Point(672, 235)
        Me.lblam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblam.Name = "lblam"
        Me.lblam.Size = New System.Drawing.Size(209, 145)
        Me.lblam.TabIndex = 33
        Me.lblam.Text = "AM"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(128, 150)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(497, 24)
        Me.ComboBox1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Open Camera"
        '
        'Timer1
        '
        '
        'btnDetect
        '
        Me.btnDetect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDetect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnDetect.Depth = 0
        Me.btnDetect.HighEmphasis = True
        Me.btnDetect.Icon = Nothing
        Me.btnDetect.Location = New System.Drawing.Point(349, 634)
        Me.btnDetect.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnDetect.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDetect.Name = "btnDetect"
        Me.btnDetect.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnDetect.Size = New System.Drawing.Size(75, 36)
        Me.btnDetect.TabIndex = 37
        Me.btnDetect.Text = "Detect"
        Me.btnDetect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnDetect.UseAccentColor = False
        Me.btnDetect.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnStart.Depth = 0
        Me.btnStart.HighEmphasis = True
        Me.btnStart.Icon = Nothing
        Me.btnStart.Location = New System.Drawing.Point(249, 634)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnStart.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnStart.Size = New System.Drawing.Size(67, 36)
        Me.btnStart.TabIndex = 37
        Me.btnStart.Text = "Start"
        Me.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnStart.UseAccentColor = False
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnStop.Depth = 0
        Me.btnStop.HighEmphasis = True
        Me.btnStop.Icon = Nothing
        Me.btnStop.Location = New System.Drawing.Point(461, 634)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnStop.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnStop.Name = "btnStop"
        Me.btnStop.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnStop.Size = New System.Drawing.Size(64, 36)
        Me.btnStop.TabIndex = 37
        Me.btnStop.Text = "Stop"
        Me.btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnStop.UseAccentColor = False
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(128, 193)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(498, 429)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'scanQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 703)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnDetect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblpm)
        Me.Controls.Add(Me.lblam)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "scanQR"
        Me.Padding = New System.Windows.Forms.Padding(4, 108, 4, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateTimeTimer As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblpm As Label
    Friend WithEvents lblam As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnDetect As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnStart As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnStop As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
