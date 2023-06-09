<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageStudents))
        Me.txtID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtLname = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtFname = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtMname = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCourse = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtContact = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtGuardian = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnbrowse = New MaterialSkin.Controls.MaterialButton()
        Me.pbImage = New Bunifu.UI.WinForms.BunifuPictureBox()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.AnimateReadOnly = False
        Me.txtID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtID.Depth = 0
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtID.HideSelection = True
        Me.txtID.Hint = "ID"
        Me.txtID.LeadingIcon = Nothing
        Me.txtID.Location = New System.Drawing.Point(41, 143)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtID.MaxLength = 32767
        Me.txtID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PrefixSuffixText = Nothing
        Me.txtID.ReadOnly = False
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtID.SelectedText = ""
        Me.txtID.SelectionLength = 0
        Me.txtID.SelectionStart = 0
        Me.txtID.ShortcutsEnabled = True
        Me.txtID.Size = New System.Drawing.Size(460, 48)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtID.TrailingIcon = Nothing
        Me.txtID.UseSystemPasswordChar = False
        '
        'txtLname
        '
        Me.txtLname.AnimateReadOnly = False
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLname.Depth = 0
        Me.txtLname.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtLname.Hint = "Last Name"
        Me.txtLname.LeadingIcon = Nothing
        Me.txtLname.Location = New System.Drawing.Point(41, 210)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLname.MaxLength = 50
        Me.txtLname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtLname.Multiline = False
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(460, 50)
        Me.txtLname.TabIndex = 1
        Me.txtLname.Text = ""
        Me.txtLname.TrailingIcon = Nothing
        '
        'txtFname
        '
        Me.txtFname.AnimateReadOnly = False
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFname.Depth = 0
        Me.txtFname.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFname.Hint = "First Name"
        Me.txtFname.LeadingIcon = Nothing
        Me.txtFname.Location = New System.Drawing.Point(41, 279)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFname.MaxLength = 50
        Me.txtFname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFname.Multiline = False
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(460, 50)
        Me.txtFname.TabIndex = 2
        Me.txtFname.Text = ""
        Me.txtFname.TrailingIcon = Nothing
        '
        'txtMname
        '
        Me.txtMname.AnimateReadOnly = False
        Me.txtMname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMname.Depth = 0
        Me.txtMname.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMname.Hint = "Middle Name"
        Me.txtMname.LeadingIcon = Nothing
        Me.txtMname.Location = New System.Drawing.Point(41, 348)
        Me.txtMname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMname.MaxLength = 50
        Me.txtMname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMname.Multiline = False
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(460, 50)
        Me.txtMname.TabIndex = 3
        Me.txtMname.Text = ""
        Me.txtMname.TrailingIcon = Nothing
        '
        'txtCourse
        '
        Me.txtCourse.AutoResize = False
        Me.txtCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourse.Depth = 0
        Me.txtCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.txtCourse.DropDownHeight = 174
        Me.txtCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCourse.DropDownWidth = 121
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCourse.FormattingEnabled = True
        Me.txtCourse.Hint = "Course"
        Me.txtCourse.IntegralHeight = False
        Me.txtCourse.ItemHeight = 43
        Me.txtCourse.Items.AddRange(New Object() {"GRADE 1", "GRADE 2", "GRADE 3", "GRADE 4", "GRADE 5", "GRADE 6", "GRADE 7"})
        Me.txtCourse.Location = New System.Drawing.Point(41, 418)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCourse.MaxDropDownItems = 4
        Me.txtCourse.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(459, 49)
        Me.txtCourse.StartIndex = 0
        Me.txtCourse.TabIndex = 4
        '
        'txtContact
        '
        Me.txtContact.AnimateReadOnly = False
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Depth = 0
        Me.txtContact.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtContact.HideSelection = False
        Me.txtContact.Hint = "Guardian Contact No."
        Me.txtContact.LeadingIcon = Nothing
        Me.txtContact.Location = New System.Drawing.Point(41, 555)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContact.MaxLength = 50
        Me.txtContact.MouseState = MaterialSkin.MouseState.OUT
        Me.txtContact.Multiline = False
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(775, 50)
        Me.txtContact.TabIndex = 5
        Me.txtContact.Text = ""
        Me.txtContact.TrailingIcon = Nothing
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Global.AMS.My.Resources.Resources.icons8_sent_96
        Me.btnSave.Location = New System.Drawing.Point(701, 628)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(86, 36)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "save"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        Me.MaterialLabel1.Location = New System.Drawing.Point(43, 54)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(262, 58)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Add Student"
        '
        'txtGuardian
        '
        Me.txtGuardian.AnimateReadOnly = False
        Me.txtGuardian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuardian.Depth = 0
        Me.txtGuardian.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGuardian.HideSelection = False
        Me.txtGuardian.Hint = "Guardian Name"
        Me.txtGuardian.LeadingIcon = Nothing
        Me.txtGuardian.Location = New System.Drawing.Point(41, 486)
        Me.txtGuardian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGuardian.MaxLength = 50
        Me.txtGuardian.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGuardian.Multiline = False
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(775, 50)
        Me.txtGuardian.TabIndex = 5
        Me.txtGuardian.Text = ""
        Me.txtGuardian.TrailingIcon = Nothing
        '
        'btnbrowse
        '
        Me.btnbrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnbrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnbrowse.Depth = 0
        Me.btnbrowse.HighEmphasis = True
        Me.btnbrowse.Icon = Global.AMS.My.Resources.Resources.icons8_plus___96
        Me.btnbrowse.Location = New System.Drawing.Point(597, 434)
        Me.btnbrowse.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnbrowse.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnbrowse.Size = New System.Drawing.Size(108, 36)
        Me.btnbrowse.TabIndex = 6
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnbrowse.UseAccentColor = False
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.AllowFocused = False
        Me.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbImage.AutoSizeHeight = True
        Me.pbImage.BorderRadius = 154
        Me.pbImage.Image = Global.AMS.My.Resources.Resources._17_avatar_man_nodding_lineal
        Me.pbImage.IsCircle = True
        Me.pbImage.Location = New System.Drawing.Point(512, 143)
        Me.pbImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(308, 308)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 7
        Me.pbImage.TabStop = False
        Me.pbImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'manageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 699)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtGuardian)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtID)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "manageStudents"
        Me.Padding = New System.Windows.Forms.Padding(4, 30, 4, 4)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtLname As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtFname As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtMname As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCourse As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtContact As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtGuardian As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnbrowse As MaterialSkin.Controls.MaterialButton
    Friend WithEvents pbImage As Bunifu.UI.WinForms.BunifuPictureBox
End Class
