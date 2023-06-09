<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customDialog
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
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.studPic = New System.Windows.Forms.PictureBox()
        Me.studName = New MaterialSkin.Controls.MaterialLabel()
        Me.labeldialog = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.studPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.labeldialog)
        Me.MaterialCard1.Controls.Add(Me.studPic)
        Me.MaterialCard1.Controls.Add(Me.studName)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(3, 0)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(412, 484)
        Me.MaterialCard1.TabIndex = 0
        '
        'studPic
        '
        Me.studPic.Location = New System.Drawing.Point(17, 68)
        Me.studPic.Name = "studPic"
        Me.studPic.Size = New System.Drawing.Size(382, 348)
        Me.studPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studPic.TabIndex = 4
        Me.studPic.TabStop = False
        '
        'studName
        '
        Me.studName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studName.Depth = 0
        Me.studName.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.studName.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.studName.Location = New System.Drawing.Point(17, 419)
        Me.studName.MouseState = MaterialSkin.MouseState.HOVER
        Me.studName.Name = "studName"
        Me.studName.Size = New System.Drawing.Size(378, 61)
        Me.studName.TabIndex = 3
        Me.studName.Text = "Name"
        Me.studName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labeldialog
        '
        Me.labeldialog.Depth = 0
        Me.labeldialog.Font = New System.Drawing.Font("Roboto", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.labeldialog.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        Me.labeldialog.Location = New System.Drawing.Point(17, 7)
        Me.labeldialog.MouseState = MaterialSkin.MouseState.HOVER
        Me.labeldialog.Name = "labeldialog"
        Me.labeldialog.Size = New System.Drawing.Size(382, 58)
        Me.labeldialog.TabIndex = 5
        Me.labeldialog.Text = "Title"
        Me.labeldialog.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'customDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 487)
        Me.Controls.Add(Me.MaterialCard1)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Name = "customDialog"
        Me.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.studPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents studPic As PictureBox
    Friend WithEvents studName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents labeldialog As MaterialSkin.Controls.MaterialLabel
End Class
