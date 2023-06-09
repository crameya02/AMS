<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewStudent))
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.txtQrCode = New MaterialSkin.Controls.MaterialLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtLName = New MaterialSkin.Controls.MaterialLabel()
        Me.txtFName = New MaterialSkin.Controls.MaterialLabel()
        Me.txtMName = New MaterialSkin.Controls.MaterialLabel()
        Me.txtCourse = New MaterialSkin.Controls.MaterialLabel()
        Me.txtParentNum = New MaterialSkin.Controls.MaterialLabel()
        Me.btnSaveQR = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtGuardian = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.txtQrCode)
        Me.MaterialCard4.Controls.Add(Me.PictureBox2)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(23, 96)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(19, 17, 19, 17)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(19, 17, 19, 17)
        Me.MaterialCard4.Size = New System.Drawing.Size(348, 325)
        Me.MaterialCard4.TabIndex = 4
        '
        'txtQrCode
        '
        Me.txtQrCode.Depth = 0
        Me.txtQrCode.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtQrCode.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.txtQrCode.Location = New System.Drawing.Point(-5, 282)
        Me.txtQrCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtQrCode.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtQrCode.Name = "txtQrCode"
        Me.txtQrCode.Size = New System.Drawing.Size(348, 28)
        Me.txtQrCode.TabIndex = 2
        Me.txtQrCode.Text = "Student ID"
        Me.txtQrCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(23, 20)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(304, 258)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(439, 106)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(90, 19)
        Me.MaterialLabel1.TabIndex = 5
        Me.MaterialLabel1.Text = "Last Name : "
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(439, 149)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(90, 19)
        Me.MaterialLabel2.TabIndex = 5
        Me.MaterialLabel2.Text = "First Name : "
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(439, 191)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(107, 19)
        Me.MaterialLabel3.TabIndex = 5
        Me.MaterialLabel3.Text = "Middle Name : "
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(439, 235)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel4.TabIndex = 5
        Me.MaterialLabel4.Text = "Grade :"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.Location = New System.Drawing.Point(439, 316)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(119, 19)
        Me.MaterialLabel5.TabIndex = 5
        Me.MaterialLabel5.Text = "Parent Number : "
        '
        'txtLName
        '
        Me.txtLName.AutoSize = True
        Me.txtLName.Depth = 0
        Me.txtLName.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtLName.Location = New System.Drawing.Point(599, 106)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(90, 19)
        Me.txtLName.TabIndex = 5
        Me.txtLName.Text = "Last Name : "
        '
        'txtFName
        '
        Me.txtFName.AutoSize = True
        Me.txtFName.Depth = 0
        Me.txtFName.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFName.Location = New System.Drawing.Point(599, 149)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtFName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(90, 19)
        Me.txtFName.TabIndex = 5
        Me.txtFName.Text = "First Name : "
        '
        'txtMName
        '
        Me.txtMName.AutoSize = True
        Me.txtMName.Depth = 0
        Me.txtMName.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMName.Location = New System.Drawing.Point(599, 191)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtMName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(107, 19)
        Me.txtMName.TabIndex = 5
        Me.txtMName.Text = "Middle Name : "
        '
        'txtCourse
        '
        Me.txtCourse.AutoSize = True
        Me.txtCourse.Depth = 0
        Me.txtCourse.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCourse.Location = New System.Drawing.Point(599, 235)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtCourse.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(58, 19)
        Me.txtCourse.TabIndex = 5
        Me.txtCourse.Text = "Course :"
        '
        'txtParentNum
        '
        Me.txtParentNum.AutoSize = True
        Me.txtParentNum.Depth = 0
        Me.txtParentNum.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtParentNum.Location = New System.Drawing.Point(599, 316)
        Me.txtParentNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtParentNum.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtParentNum.Name = "txtParentNum"
        Me.txtParentNum.Size = New System.Drawing.Size(119, 19)
        Me.txtParentNum.TabIndex = 5
        Me.txtParentNum.Text = "Parent Number : "
        '
        'btnSaveQR
        '
        Me.btnSaveQR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveQR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSaveQR.Depth = 0
        Me.btnSaveQR.HighEmphasis = True
        Me.btnSaveQR.Icon = Global.AMS.My.Resources.Resources.icons8_download_24
        Me.btnSaveQR.Location = New System.Drawing.Point(709, 382)
        Me.btnSaveQR.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnSaveQR.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveQR.Name = "btnSaveQR"
        Me.btnSaveQR.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSaveQR.Size = New System.Drawing.Size(86, 36)
        Me.btnSaveQR.TabIndex = 1
        Me.btnSaveQR.Text = "Save"
        Me.btnSaveQR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSaveQR.UseAccentColor = False
        Me.btnSaveQR.UseVisualStyleBackColor = True
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.Location = New System.Drawing.Point(439, 276)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(78, 19)
        Me.MaterialLabel6.TabIndex = 5
        Me.MaterialLabel6.Text = "Guardian : "
        '
        'txtGuardian
        '
        Me.txtGuardian.AutoSize = True
        Me.txtGuardian.Depth = 0
        Me.txtGuardian.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGuardian.Location = New System.Drawing.Point(599, 276)
        Me.txtGuardian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtGuardian.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(74, 19)
        Me.txtGuardian.TabIndex = 5
        Me.txtGuardian.Text = "Guardian :"
        '
        'viewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 437)
        Me.Controls.Add(Me.txtParentNum)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.txtGuardian)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.btnSaveQR)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialCard4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "viewStudent"
        Me.Padding = New System.Windows.Forms.Padding(4, 79, 4, 4)
        Me.Sizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Student Info"
        Me.MaterialCard4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSaveQR As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtLName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtFName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtMName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtCourse As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtParentNum As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtQrCode As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtGuardian As MaterialSkin.Controls.MaterialLabel
End Class
