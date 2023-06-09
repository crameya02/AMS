<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageUsers
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtLname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtUserEmail = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtUserName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtUserPassword = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.txtConfirmPassword = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.btnUpdateUser = New MaterialSkin.Controls.MaterialButton()
        Me.cmbUserType = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblAvailable = New MaterialSkin.Controls.MaterialLabel()
        Me.lblvalidemail = New MaterialSkin.Controls.MaterialLabel()
        Me.btnDeleteUser = New MaterialSkin.Controls.MaterialButton()
        Me.btnSaveUser = New MaterialSkin.Controls.MaterialButton()
        Me.btnNewUser = New MaterialSkin.Controls.MaterialButton()
        Me.LogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AllowUserToResizeColumns = False
        Me.dgw.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgw.Location = New System.Drawing.Point(264, 115)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgw.RowHeadersWidth = 25
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.ShowRowErrors = False
        Me.dgw.Size = New System.Drawing.Size(1113, 402)
        Me.dgw.TabIndex = 1
        '
        'Description
        '
        Me.Description.HeaderText = "First Name"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 137
        '
        'Column1
        '
        Me.Column1.HeaderText = "Last Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 137
        '
        'Column2
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Email"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 137
        '
        'Column3
        '
        Me.Column3.HeaderText = "User Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 137
        '
        'Column4
        '
        Me.Column4.HeaderText = "Password"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 137
        '
        'Column5
        '
        Me.Column5.HeaderText = "Role"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 137
        '
        'Column7
        '
        Me.Column7.HeaderText = "Registration Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 137
        '
        'Column6
        '
        DataGridViewCellStyle4.Format = "dd/MM/yyyy hh:mm:ss tt"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "Date Updated"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 137
        '
        'txtFname
        '
        Me.txtFname.AnimateReadOnly = False
        Me.txtFname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFname.Depth = 0
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFname.HideSelection = True
        Me.txtFname.Hint = "First Name"
        Me.txtFname.LeadingIcon = Nothing
        Me.txtFname.Location = New System.Drawing.Point(7, 170)
        Me.txtFname.MaxLength = 32767
        Me.txtFname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.PrefixSuffixText = Nothing
        Me.txtFname.ReadOnly = False
        Me.txtFname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFname.SelectedText = ""
        Me.txtFname.SelectionLength = 0
        Me.txtFname.SelectionStart = 0
        Me.txtFname.ShortcutsEnabled = True
        Me.txtFname.Size = New System.Drawing.Size(250, 48)
        Me.txtFname.TabIndex = 2
        Me.txtFname.TabStop = False
        Me.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFname.TrailingIcon = Nothing
        Me.txtFname.UseSystemPasswordChar = False
        '
        'txtLname
        '
        Me.txtLname.AnimateReadOnly = False
        Me.txtLname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLname.Depth = 0
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtLname.HideSelection = True
        Me.txtLname.Hint = "Last Name"
        Me.txtLname.LeadingIcon = Nothing
        Me.txtLname.Location = New System.Drawing.Point(7, 224)
        Me.txtLname.MaxLength = 32767
        Me.txtLname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtLname.Name = "txtLname"
        Me.txtLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLname.PrefixSuffixText = Nothing
        Me.txtLname.ReadOnly = False
        Me.txtLname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLname.SelectedText = ""
        Me.txtLname.SelectionLength = 0
        Me.txtLname.SelectionStart = 0
        Me.txtLname.ShortcutsEnabled = True
        Me.txtLname.Size = New System.Drawing.Size(250, 48)
        Me.txtLname.TabIndex = 3
        Me.txtLname.TabStop = False
        Me.txtLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLname.TrailingIcon = Nothing
        Me.txtLname.UseSystemPasswordChar = False
        '
        'txtUserEmail
        '
        Me.txtUserEmail.AnimateReadOnly = False
        Me.txtUserEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtUserEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUserEmail.Depth = 0
        Me.txtUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtUserEmail.HideSelection = True
        Me.txtUserEmail.Hint = "Email"
        Me.txtUserEmail.LeadingIcon = Nothing
        Me.txtUserEmail.Location = New System.Drawing.Point(7, 278)
        Me.txtUserEmail.MaxLength = 32767
        Me.txtUserEmail.MouseState = MaterialSkin.MouseState.OUT
        Me.txtUserEmail.Name = "txtUserEmail"
        Me.txtUserEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserEmail.PrefixSuffixText = Nothing
        Me.txtUserEmail.ReadOnly = False
        Me.txtUserEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserEmail.SelectedText = ""
        Me.txtUserEmail.SelectionLength = 0
        Me.txtUserEmail.SelectionStart = 0
        Me.txtUserEmail.ShortcutsEnabled = True
        Me.txtUserEmail.Size = New System.Drawing.Size(250, 48)
        Me.txtUserEmail.TabIndex = 4
        Me.txtUserEmail.TabStop = False
        Me.txtUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUserEmail.TrailingIcon = Nothing
        Me.txtUserEmail.UseSystemPasswordChar = False
        '
        'txtUserName
        '
        Me.txtUserName.AnimateReadOnly = False
        Me.txtUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUserName.Depth = 0
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtUserName.HideSelection = True
        Me.txtUserName.Hint = "User Name"
        Me.txtUserName.LeadingIcon = Nothing
        Me.txtUserName.Location = New System.Drawing.Point(6, 347)
        Me.txtUserName.MaxLength = 32767
        Me.txtUserName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.PrefixSuffixText = Nothing
        Me.txtUserName.ReadOnly = False
        Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.SelectionLength = 0
        Me.txtUserName.SelectionStart = 0
        Me.txtUserName.ShortcutsEnabled = True
        Me.txtUserName.Size = New System.Drawing.Size(250, 48)
        Me.txtUserName.TabIndex = 5
        Me.txtUserName.TabStop = False
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUserName.TrailingIcon = Nothing
        Me.txtUserName.UseSystemPasswordChar = False
        '
        'txtUserPassword
        '
        Me.txtUserPassword.AllowPromptAsInput = True
        Me.txtUserPassword.AnimateReadOnly = False
        Me.txtUserPassword.AsciiOnly = False
        Me.txtUserPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtUserPassword.BeepOnError = False
        Me.txtUserPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.txtUserPassword.Depth = 0
        Me.txtUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtUserPassword.HidePromptOnLeave = False
        Me.txtUserPassword.HideSelection = True
        Me.txtUserPassword.Hint = "Password"
        Me.txtUserPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.txtUserPassword.LeadingIcon = Nothing
        Me.txtUserPassword.Location = New System.Drawing.Point(7, 415)
        Me.txtUserPassword.Mask = ""
        Me.txtUserPassword.MaxLength = 32767
        Me.txtUserPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtUserPassword.PrefixSuffixText = Nothing
        Me.txtUserPassword.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtUserPassword.ReadOnly = False
        Me.txtUserPassword.RejectInputOnFirstFailure = False
        Me.txtUserPassword.ResetOnPrompt = True
        Me.txtUserPassword.ResetOnSpace = True
        Me.txtUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserPassword.SelectedText = ""
        Me.txtUserPassword.SelectionLength = 0
        Me.txtUserPassword.SelectionStart = 0
        Me.txtUserPassword.ShortcutsEnabled = True
        Me.txtUserPassword.Size = New System.Drawing.Size(250, 48)
        Me.txtUserPassword.SkipLiterals = True
        Me.txtUserPassword.TabIndex = 6
        Me.txtUserPassword.TabStop = False
        Me.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUserPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtUserPassword.TrailingIcon = Nothing
        Me.txtUserPassword.UseSystemPasswordChar = True
        Me.txtUserPassword.ValidatingType = Nothing
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.AllowPromptAsInput = True
        Me.txtConfirmPassword.AnimateReadOnly = False
        Me.txtConfirmPassword.AsciiOnly = False
        Me.txtConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtConfirmPassword.BeepOnError = False
        Me.txtConfirmPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.txtConfirmPassword.Depth = 0
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtConfirmPassword.HidePromptOnLeave = False
        Me.txtConfirmPassword.HideSelection = True
        Me.txtConfirmPassword.Hint = "Confirm Password"
        Me.txtConfirmPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.txtConfirmPassword.LeadingIcon = Nothing
        Me.txtConfirmPassword.Location = New System.Drawing.Point(8, 469)
        Me.txtConfirmPassword.Mask = ""
        Me.txtConfirmPassword.MaxLength = 32767
        Me.txtConfirmPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmPassword.PrefixSuffixText = Nothing
        Me.txtConfirmPassword.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtConfirmPassword.ReadOnly = False
        Me.txtConfirmPassword.RejectInputOnFirstFailure = False
        Me.txtConfirmPassword.ResetOnPrompt = True
        Me.txtConfirmPassword.ResetOnSpace = True
        Me.txtConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.SelectionLength = 0
        Me.txtConfirmPassword.SelectionStart = 0
        Me.txtConfirmPassword.ShortcutsEnabled = True
        Me.txtConfirmPassword.Size = New System.Drawing.Size(250, 48)
        Me.txtConfirmPassword.SkipLiterals = True
        Me.txtConfirmPassword.TabIndex = 7
        Me.txtConfirmPassword.TabStop = False
        Me.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConfirmPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtConfirmPassword.TrailingIcon = Nothing
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        Me.txtConfirmPassword.ValidatingType = Nothing
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdateUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnUpdateUser.Depth = 0
        Me.btnUpdateUser.Enabled = False
        Me.btnUpdateUser.HighEmphasis = True
        Me.btnUpdateUser.Icon = Global.AMS.My.Resources.Resources.icons8_update_file_96
        Me.btnUpdateUser.Location = New System.Drawing.Point(190, 70)
        Me.btnUpdateUser.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdateUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnUpdateUser.Size = New System.Drawing.Size(105, 36)
        Me.btnUpdateUser.TabIndex = 10
        Me.btnUpdateUser.Text = "Update"
        Me.btnUpdateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnUpdateUser.UseAccentColor = False
        Me.btnUpdateUser.UseVisualStyleBackColor = True
        '
        'cmbUserType
        '
        Me.cmbUserType.AutoResize = False
        Me.cmbUserType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbUserType.Depth = 0
        Me.cmbUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbUserType.DropDownHeight = 174
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.DropDownWidth = 121
        Me.cmbUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbUserType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.IntegralHeight = False
        Me.cmbUserType.ItemHeight = 43
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmbUserType.Location = New System.Drawing.Point(7, 115)
        Me.cmbUserType.MaxDropDownItems = 4
        Me.cmbUserType.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(250, 49)
        Me.cmbUserType.StartIndex = 0
        Me.cmbUserType.TabIndex = 1
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Depth = 0
        Me.lblAvailable.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        Me.lblAvailable.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis
        Me.lblAvailable.Location = New System.Drawing.Point(17, 398)
        Me.lblAvailable.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(6, 14)
        Me.lblAvailable.TabIndex = 12
        Me.lblAvailable.Text = "*"
        Me.lblAvailable.UseAccent = True
        '
        'lblvalidemail
        '
        Me.lblvalidemail.AutoSize = True
        Me.lblvalidemail.Depth = 0
        Me.lblvalidemail.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        Me.lblvalidemail.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis
        Me.lblvalidemail.Location = New System.Drawing.Point(17, 329)
        Me.lblvalidemail.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblvalidemail.Name = "lblvalidemail"
        Me.lblvalidemail.Size = New System.Drawing.Size(6, 14)
        Me.lblvalidemail.TabIndex = 13
        Me.lblvalidemail.Text = "*"
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeleteUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnDeleteUser.Depth = 0
        Me.btnDeleteUser.Enabled = False
        Me.btnDeleteUser.HighEmphasis = True
        Me.btnDeleteUser.Icon = Global.AMS.My.Resources.Resources.icons8_trash_24
        Me.btnDeleteUser.Location = New System.Drawing.Point(303, 70)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDeleteUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnDeleteUser.Size = New System.Drawing.Size(101, 36)
        Me.btnDeleteUser.TabIndex = 11
        Me.btnDeleteUser.Text = "Delete"
        Me.btnDeleteUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnDeleteUser.UseAccentColor = False
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnSaveUser
        '
        Me.btnSaveUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSaveUser.Depth = 0
        Me.btnSaveUser.HighEmphasis = True
        Me.btnSaveUser.Icon = Global.AMS.My.Resources.Resources.icons8_save_96
        Me.btnSaveUser.Location = New System.Drawing.Point(96, 70)
        Me.btnSaveUser.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSaveUser.Size = New System.Drawing.Size(86, 36)
        Me.btnSaveUser.TabIndex = 9
        Me.btnSaveUser.Text = "Save"
        Me.btnSaveUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSaveUser.UseAccentColor = False
        Me.btnSaveUser.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNewUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnNewUser.Depth = 0
        Me.btnNewUser.HighEmphasis = True
        Me.btnNewUser.Icon = Global.AMS.My.Resources.Resources.icons8_new_copy_96
        Me.btnNewUser.Location = New System.Drawing.Point(7, 70)
        Me.btnNewUser.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNewUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnNewUser.Size = New System.Drawing.Size(81, 36)
        Me.btnNewUser.TabIndex = 8
        Me.btnNewUser.Text = "New"
        Me.btnNewUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnNewUser.UseAccentColor = False
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'LogsBindingSource
        '
        Me.LogsBindingSource.DataMember = "Logs"
        '
        'manageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1397, 540)
        Me.Controls.Add(Me.lblvalidemail)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.btnSaveUser)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtUserEmail)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Name = "manageUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Management"
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogsBindingSource As BindingSource
    Friend WithEvents dgw As DataGridView
    Friend WithEvents txtFname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtLname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtUserEmail As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtUserName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtUserPassword As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents txtConfirmPassword As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents btnNewUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSaveUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdateUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDeleteUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmbUserType As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents lblAvailable As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblvalidemail As MaterialSkin.Controls.MaterialLabel
End Class
