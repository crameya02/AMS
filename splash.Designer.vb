<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splash))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialProgressBar1 = New MaterialSkin.Controls.MaterialProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSet = New MaterialSkin.Controls.MaterialLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel1.HighEmphasis = True
        Me.MaterialLabel1.Location = New System.Drawing.Point(175, 26)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(463, 119)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "QR ATTENDANCE AND SMS NOTIFICATION"
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialLabel1.UseAccent = True
        '
        'MaterialProgressBar1
        '
        Me.MaterialProgressBar1.Depth = 0
        Me.MaterialProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialProgressBar1.Location = New System.Drawing.Point(4, 178)
        Me.MaterialProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaterialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialProgressBar1.Name = "MaterialProgressBar1"
        Me.MaterialProgressBar1.Size = New System.Drawing.Size(660, 5)
        Me.MaterialProgressBar1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AMS.My.Resources.Resources.icons8_qr_code_96
        Me.PictureBox1.Location = New System.Drawing.Point(35, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 119)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Depth = 0
        Me.lblSet.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblSet.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline
        Me.lblSet.Location = New System.Drawing.Point(31, 162)
        Me.lblSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSet.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(1, 0)
        Me.lblSet.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AMS.My.Resources.Resources.icons8_qr_code_96
        Me.PictureBox2.Location = New System.Drawing.Point(35, 26)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 119)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AMS.My.Resources.Resources._1335_qr_code_lineal
        Me.PictureBox3.Location = New System.Drawing.Point(32, 26)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(135, 119)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 187)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblSet)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialProgressBar1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "splash"
        Me.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialProgressBar1 As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSet As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
