<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recoverPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recoverPassword))
        Me.txtEmailID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnSendMail = New MaterialSkin.Controls.MaterialButton()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialExpansionPanel1 = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.MaterialCheckbox2 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCheckbox1 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.txtVerNewPass = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtVerPass = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard4.SuspendLayout()
        Me.MaterialExpansionPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmailID
        '
        Me.txtEmailID.AnimateReadOnly = False
        Me.txtEmailID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtEmailID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEmailID.Depth = 0
        Me.txtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEmailID.HideSelection = True
        Me.txtEmailID.Hint = "Email Address"
        Me.txtEmailID.LeadingIcon = Nothing
        Me.txtEmailID.Location = New System.Drawing.Point(25, 50)
        Me.txtEmailID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmailID.MaxLength = 32767
        Me.txtEmailID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtEmailID.Name = "txtEmailID"
        Me.txtEmailID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailID.PrefixSuffixText = Nothing
        Me.txtEmailID.ReadOnly = False
        Me.txtEmailID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmailID.SelectedText = ""
        Me.txtEmailID.SelectionLength = 0
        Me.txtEmailID.SelectionStart = 0
        Me.txtEmailID.ShortcutsEnabled = True
        Me.txtEmailID.Size = New System.Drawing.Size(333, 48)
        Me.txtEmailID.TabIndex = 0
        Me.txtEmailID.TabStop = False
        Me.txtEmailID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmailID.TrailingIcon = Nothing
        Me.txtEmailID.UseSystemPasswordChar = False
        '
        'btnSendMail
        '
        Me.btnSendMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSendMail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSendMail.Depth = 0
        Me.btnSendMail.HighEmphasis = True
        Me.btnSendMail.Icon = Nothing
        Me.btnSendMail.Location = New System.Drawing.Point(384, 54)
        Me.btnSendMail.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnSendMail.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSendMail.Size = New System.Drawing.Size(64, 36)
        Me.btnSendMail.TabIndex = 1
        Me.btnSendMail.Text = "Send"
        Me.btnSendMail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSendMail.UseAccentColor = False
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.txtEmailID)
        Me.MaterialCard4.Controls.Add(Me.btnSendMail)
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel12)
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel11)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(23, 96)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(19, 17, 19, 17)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(19, 17, 19, 17)
        Me.MaterialCard4.Size = New System.Drawing.Size(496, 158)
        Me.MaterialCard4.TabIndex = 5
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel12.Location = New System.Drawing.Point(17, 113)
        Me.MaterialLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(452, 30)
        Me.MaterialLabel12.TabIndex = 1
        Me.MaterialLabel12.Text = "*The code will expire when application closes"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel11.Location = New System.Drawing.Point(23, 17)
        Me.MaterialLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(339, 24)
        Me.MaterialLabel11.TabIndex = 1
        Me.MaterialLabel11.Text = "Enter email registered in your account"
        '
        'MaterialExpansionPanel1
        '
        Me.MaterialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialExpansionPanel1.Collapse = True
        Me.MaterialExpansionPanel1.Controls.Add(Me.MaterialCheckbox2)
        Me.MaterialExpansionPanel1.Controls.Add(Me.MaterialCheckbox1)
        Me.MaterialExpansionPanel1.Controls.Add(Me.txtVerNewPass)
        Me.MaterialExpansionPanel1.Controls.Add(Me.txtVerPass)
        Me.MaterialExpansionPanel1.Depth = 0
        Me.MaterialExpansionPanel1.Description = ""
        Me.MaterialExpansionPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialExpansionPanel1.Location = New System.Drawing.Point(23, 196)
        Me.MaterialExpansionPanel1.Margin = New System.Windows.Forms.Padding(21, 1, 21, 0)
        Me.MaterialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialExpansionPanel1.Name = "MaterialExpansionPanel1"
        Me.MaterialExpansionPanel1.Padding = New System.Windows.Forms.Padding(32, 79, 32, 20)
        Me.MaterialExpansionPanel1.Size = New System.Drawing.Size(496, 48)
        Me.MaterialExpansionPanel1.TabIndex = 6
        Me.MaterialExpansionPanel1.Title = "Change Password"
        Me.MaterialExpansionPanel1.Visible = False
        '
        'MaterialCheckbox2
        '
        Me.MaterialCheckbox2.AutoSize = True
        Me.MaterialCheckbox2.Depth = 0
        Me.MaterialCheckbox2.Location = New System.Drawing.Point(379, 149)
        Me.MaterialCheckbox2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox2.Name = "MaterialCheckbox2"
        Me.MaterialCheckbox2.ReadOnly = False
        Me.MaterialCheckbox2.Ripple = True
        Me.MaterialCheckbox2.Size = New System.Drawing.Size(35, 37)
        Me.MaterialCheckbox2.TabIndex = 2
        Me.MaterialCheckbox2.UseVisualStyleBackColor = True
        '
        'MaterialCheckbox1
        '
        Me.MaterialCheckbox1.AutoSize = True
        Me.MaterialCheckbox1.Depth = 0
        Me.MaterialCheckbox1.Image = Global.AMS.My.Resources.Resources.icons8_eye_24
        Me.MaterialCheckbox1.Location = New System.Drawing.Point(379, 84)
        Me.MaterialCheckbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox1.Name = "MaterialCheckbox1"
        Me.MaterialCheckbox1.ReadOnly = False
        Me.MaterialCheckbox1.Ripple = True
        Me.MaterialCheckbox1.Size = New System.Drawing.Size(35, 37)
        Me.MaterialCheckbox1.TabIndex = 2
        Me.MaterialCheckbox1.UseVisualStyleBackColor = True
        '
        'txtVerNewPass
        '
        Me.txtVerNewPass.AnimateReadOnly = False
        Me.txtVerNewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtVerNewPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVerNewPass.Depth = 0
        Me.txtVerNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtVerNewPass.HideSelection = True
        Me.txtVerNewPass.Hint = "Verify New Password"
        Me.txtVerNewPass.LeadingIcon = Nothing
        Me.txtVerNewPass.Location = New System.Drawing.Point(36, 135)
        Me.txtVerNewPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVerNewPass.MaxLength = 32767
        Me.txtVerNewPass.MouseState = MaterialSkin.MouseState.OUT
        Me.txtVerNewPass.Name = "txtVerNewPass"
        Me.txtVerNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtVerNewPass.PrefixSuffixText = Nothing
        Me.txtVerNewPass.ReadOnly = False
        Me.txtVerNewPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerNewPass.SelectedText = ""
        Me.txtVerNewPass.SelectionLength = 0
        Me.txtVerNewPass.SelectionStart = 0
        Me.txtVerNewPass.ShortcutsEnabled = True
        Me.txtVerNewPass.Size = New System.Drawing.Size(333, 48)
        Me.txtVerNewPass.TabIndex = 0
        Me.txtVerNewPass.TabStop = False
        Me.txtVerNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtVerNewPass.TrailingIcon = Nothing
        Me.txtVerNewPass.UseSystemPasswordChar = True
        '
        'txtVerPass
        '
        Me.txtVerPass.AnimateReadOnly = False
        Me.txtVerPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtVerPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVerPass.Depth = 0
        Me.txtVerPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtVerPass.HideSelection = True
        Me.txtVerPass.Hint = "New Password"
        Me.txtVerPass.LeadingIcon = Nothing
        Me.txtVerPass.Location = New System.Drawing.Point(36, 69)
        Me.txtVerPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVerPass.MaxLength = 32767
        Me.txtVerPass.MouseState = MaterialSkin.MouseState.OUT
        Me.txtVerPass.Name = "txtVerPass"
        Me.txtVerPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtVerPass.PrefixSuffixText = Nothing
        Me.txtVerPass.ReadOnly = False
        Me.txtVerPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerPass.SelectedText = ""
        Me.txtVerPass.SelectionLength = 0
        Me.txtVerPass.SelectionStart = 0
        Me.txtVerPass.ShortcutsEnabled = True
        Me.txtVerPass.Size = New System.Drawing.Size(333, 48)
        Me.txtVerPass.TabIndex = 0
        Me.txtVerPass.TabStop = False
        Me.txtVerPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtVerPass.TrailingIcon = Nothing
        Me.txtVerPass.UseSystemPasswordChar = True
        '
        'recoverPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 294)
        Me.Controls.Add(Me.MaterialCard4)
        Me.Controls.Add(Me.MaterialExpansionPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "recoverPassword"
        Me.Padding = New System.Windows.Forms.Padding(4, 79, 4, 4)
        Me.Sizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Recovery"
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        Me.MaterialExpansionPanel1.ResumeLayout(False)
        Me.MaterialExpansionPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtEmailID As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnSendMail As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialExpansionPanel1 As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents MaterialCheckbox2 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckbox1 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents txtVerNewPass As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtVerPass As MaterialSkin.Controls.MaterialTextBox2
End Class
