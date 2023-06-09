<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnRecoverPassword = New MaterialSkin.Controls.MaterialButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnGmail = New MaterialSkin.Controls.MaterialButton()
        Me.btnYoutube = New MaterialSkin.Controls.MaterialButton()
        Me.btnFaceBook = New MaterialSkin.Controls.MaterialButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialButton()
        Me.btnLogin = New MaterialSkin.Controls.MaterialButton()
        Me.txtPassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUserName = New MaterialSkin.Controls.MaterialTextBox2()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel1.HighEmphasis = True
        Me.MaterialLabel1.Location = New System.Drawing.Point(116, 11)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(347, 97)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "QR ATTENDANCE AND SMS NOTIFICATION"
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialLabel1.UseAccent = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(11, 114)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(458, 274)
        Me.MaterialLabel2.TabIndex = 5
        Me.MaterialLabel2.Text = resources.GetString("MaterialLabel2.Text")
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(475, 4)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(10, 430)
        Me.MaterialDivider1.TabIndex = 6
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel3.HighEmphasis = True
        Me.MaterialLabel3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.MaterialLabel3.Location = New System.Drawing.Point(580, 147)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(99, 56)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "LOGIN"
        Me.MaterialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialLabel3.UseAccent = True
        '
        'btnRecoverPassword
        '
        Me.btnRecoverPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRecoverPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnRecoverPassword.Depth = 0
        Me.btnRecoverPassword.HighEmphasis = True
        Me.btnRecoverPassword.Icon = Nothing
        Me.btnRecoverPassword.Location = New System.Drawing.Point(551, 402)
        Me.btnRecoverPassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRecoverPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRecoverPassword.Name = "btnRecoverPassword"
        Me.btnRecoverPassword.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnRecoverPassword.Size = New System.Drawing.Size(165, 36)
        Me.btnRecoverPassword.TabIndex = 8
        Me.btnRecoverPassword.Text = "Forgot Password."
        Me.btnRecoverPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnRecoverPassword.UseAccentColor = False
        Me.btnRecoverPassword.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        Me.MaterialLabel4.HighEmphasis = True
        Me.MaterialLabel4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.MaterialLabel4.Location = New System.Drawing.Point(678, 4)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(83, 27)
        Me.MaterialLabel4.TabIndex = 10
        Me.MaterialLabel4.Text = "Version 1.4"
        Me.MaterialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialLabel4.UseAccent = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.AMS.My.Resources.Resources._1335_qr_code_lineal
        Me.PictureBox4.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(101, 97)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AMS.My.Resources.Resources._268_avatar_man_lineal1
        Me.PictureBox3.Location = New System.Drawing.Point(576, 41)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(105, 99)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'btnGmail
        '
        Me.btnGmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnGmail.Depth = 0
        Me.btnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGmail.HighEmphasis = False
        Me.btnGmail.Icon = Global.AMS.My.Resources.Resources.icons8_google_48
        Me.btnGmail.Location = New System.Drawing.Point(280, 393)
        Me.btnGmail.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGmail.Name = "btnGmail"
        Me.btnGmail.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnGmail.Size = New System.Drawing.Size(94, 36)
        Me.btnGmail.TabIndex = 7
        Me.btnGmail.Text = "GMAIL"
        Me.btnGmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnGmail.UseAccentColor = False
        Me.btnGmail.UseVisualStyleBackColor = True
        '
        'btnYoutube
        '
        Me.btnYoutube.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnYoutube.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnYoutube.Depth = 0
        Me.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYoutube.HighEmphasis = False
        Me.btnYoutube.Icon = Global.AMS.My.Resources.Resources.icons8_youtube_48
        Me.btnYoutube.Location = New System.Drawing.Point(153, 393)
        Me.btnYoutube.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnYoutube.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnYoutube.Name = "btnYoutube"
        Me.btnYoutube.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnYoutube.Size = New System.Drawing.Size(114, 36)
        Me.btnYoutube.TabIndex = 7
        Me.btnYoutube.Text = "YOUTUBE"
        Me.btnYoutube.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnYoutube.UseAccentColor = False
        Me.btnYoutube.UseVisualStyleBackColor = True
        '
        'btnFaceBook
        '
        Me.btnFaceBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFaceBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnFaceBook.Depth = 0
        Me.btnFaceBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFaceBook.HighEmphasis = False
        Me.btnFaceBook.Icon = Global.AMS.My.Resources.Resources.icons8_facebook_48
        Me.btnFaceBook.Location = New System.Drawing.Point(16, 393)
        Me.btnFaceBook.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnFaceBook.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFaceBook.Name = "btnFaceBook"
        Me.btnFaceBook.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnFaceBook.Size = New System.Drawing.Size(124, 36)
        Me.btnFaceBook.TabIndex = 7
        Me.btnFaceBook.Text = "FACEBOOK"
        Me.btnFaceBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnFaceBook.UseAccentColor = False
        Me.btnFaceBook.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnCancel.Depth = 0
        Me.btnCancel.HighEmphasis = True
        Me.btnCancel.Icon = Global.AMS.My.Resources.Resources.icons8_emergency_exit_96
        Me.btnCancel.Location = New System.Drawing.Point(625, 354)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnCancel.Size = New System.Drawing.Size(105, 36)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancel.UseAccentColor = True
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLogin.Depth = 0
        Me.btnLogin.HighEmphasis = True
        Me.btnLogin.Icon = Global.AMS.My.Resources.Resources.icons8_sent_96
        Me.btnLogin.Location = New System.Drawing.Point(530, 354)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLogin.Size = New System.Drawing.Size(87, 36)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Send"
        Me.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLogin.UseAccentColor = False
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.AnimateReadOnly = False
        Me.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPassword.Depth = 0
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPassword.HideSelection = True
        Me.txtPassword.Hint = "Password"
        Me.txtPassword.LeadingIcon = Global.AMS.My.Resources.Resources.icons8_password_48
        Me.txtPassword.Location = New System.Drawing.Point(501, 271)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PrefixSuffixText = Nothing
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(250, 48)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TabStop = False
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.TrailingIcon = Nothing
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AMS.My.Resources.Resources.icons8_user_96
        Me.PictureBox2.Location = New System.Drawing.Point(565, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AMS.My.Resources.Resources.icons8_qr_code_96
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 97)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
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
        Me.txtUserName.LeadingIcon = Global.AMS.My.Resources.Resources.icons8_user_96
        Me.txtUserName.Location = New System.Drawing.Point(501, 206)
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
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.TabStop = False
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUserName.TrailingIcon = Nothing
        Me.txtUserName.UseAccent = False
        Me.txtUserName.UseSystemPasswordChar = False
        '
        'login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(767, 445)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnRecoverPassword)
        Me.Controls.Add(Me.btnGmail)
        Me.Controls.Add(Me.btnYoutube)
        Me.Controls.Add(Me.btnFaceBook)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.DrawerAutoHide = False
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Sizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtUserName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnFaceBook As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnYoutube As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnGmail As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRecoverPassword As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox4 As PictureBox
End Class
