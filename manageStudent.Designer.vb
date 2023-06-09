<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageStudent
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
        Me.txtID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtLname = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtFname = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtMname = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCourse = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtContact = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.AnimateReadOnly = False
        Me.txtID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtID.Depth = 0
        Me.txtID.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtID.HideSelection = True
        Me.txtID.Hint = "ID"
        Me.txtID.LeadingIcon = Nothing
        Me.txtID.Location = New System.Drawing.Point(31, 116)
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
        Me.txtID.Size = New System.Drawing.Size(345, 48)
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
        Me.txtLname.Location = New System.Drawing.Point(31, 171)
        Me.txtLname.MaxLength = 50
        Me.txtLname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtLname.Multiline = False
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(345, 50)
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
        Me.txtFname.Location = New System.Drawing.Point(31, 227)
        Me.txtFname.MaxLength = 50
        Me.txtFname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFname.Multiline = False
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(345, 50)
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
        Me.txtMname.Location = New System.Drawing.Point(31, 283)
        Me.txtMname.MaxLength = 50
        Me.txtMname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMname.Multiline = False
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(345, 50)
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
        Me.txtCourse.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCourse.FormattingEnabled = True
        Me.txtCourse.Hint = "Course"
        Me.txtCourse.IntegralHeight = False
        Me.txtCourse.ItemHeight = 43
        Me.txtCourse.Items.AddRange(New Object() {"VISITOR", "BSIT", "BSBA", "BEED", "BSED", "HRM"})
        Me.txtCourse.Location = New System.Drawing.Point(31, 340)
        Me.txtCourse.MaxDropDownItems = 4
        Me.txtCourse.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(345, 49)
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
        Me.txtContact.Hint = "Parent Contact No."
        Me.txtContact.LeadingIcon = Nothing
        Me.txtContact.Location = New System.Drawing.Point(31, 395)
        Me.txtContact.MaxLength = 50
        Me.txtContact.MouseState = MaterialSkin.MouseState.OUT
        Me.txtContact.Multiline = False
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(345, 50)
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
        Me.btnSave.Location = New System.Drawing.Point(290, 463)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
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
        Me.MaterialLabel1.Location = New System.Drawing.Point(32, 44)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(262, 58)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Add Student"
        '
        'manageStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 535)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtID)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "manageStudent"
        Me.Padding = New System.Windows.Forms.Padding(3, 24, 3, 3)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
End Class
