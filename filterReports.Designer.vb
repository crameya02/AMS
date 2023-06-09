<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filterReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(filterReports))
        Me.cmbCriteria = New MaterialSkin.Controls.MaterialComboBox()
        Me.dtFrom = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.dtTo = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.btnGo = New MaterialSkin.Controls.MaterialButton()
        Me.cbAll = New MaterialSkin.Controls.MaterialCheckbox()
        Me.SuspendLayout()
        '
        'cmbCriteria
        '
        Me.cmbCriteria.AutoResize = False
        Me.cmbCriteria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCriteria.Depth = 0
        Me.cmbCriteria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbCriteria.DropDownHeight = 174
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.DropDownWidth = 121
        Me.cmbCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbCriteria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbCriteria.FormattingEnabled = True
        Me.cmbCriteria.IntegralHeight = False
        Me.cmbCriteria.ItemHeight = 43
        Me.cmbCriteria.Location = New System.Drawing.Point(47, 58)
        Me.cmbCriteria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCriteria.MaxDropDownItems = 4
        Me.cmbCriteria.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.Size = New System.Drawing.Size(292, 49)
        Me.cmbCriteria.StartIndex = 0
        Me.cmbCriteria.TabIndex = 0
        '
        'dtFrom
        '
        Me.dtFrom.BackColor = System.Drawing.Color.Transparent
        Me.dtFrom.BorderColor = System.Drawing.Color.Silver
        Me.dtFrom.BorderRadius = 1
        Me.dtFrom.Color = System.Drawing.Color.Silver
        Me.dtFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dtFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dtFrom.DisabledColor = System.Drawing.Color.Gray
        Me.dtFrom.DisplayWeekNumbers = False
        Me.dtFrom.DPHeight = 0
        Me.dtFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtFrom.FillDatePicker = False
        Me.dtFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtFrom.ForeColor = System.Drawing.Color.Black
        Me.dtFrom.Icon = CType(resources.GetObject("dtFrom.Icon"), System.Drawing.Image)
        Me.dtFrom.IconColor = System.Drawing.Color.Gray
        Me.dtFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dtFrom.LeftTextMargin = 5
        Me.dtFrom.Location = New System.Drawing.Point(48, 133)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtFrom.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(292, 32)
        Me.dtFrom.TabIndex = 1
        '
        'dtTo
        '
        Me.dtTo.BackColor = System.Drawing.Color.Transparent
        Me.dtTo.BorderColor = System.Drawing.Color.Silver
        Me.dtTo.BorderRadius = 1
        Me.dtTo.Color = System.Drawing.Color.Silver
        Me.dtTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dtTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dtTo.DisabledColor = System.Drawing.Color.Gray
        Me.dtTo.DisplayWeekNumbers = False
        Me.dtTo.DPHeight = 0
        Me.dtTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtTo.FillDatePicker = False
        Me.dtTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtTo.ForeColor = System.Drawing.Color.Black
        Me.dtTo.Icon = CType(resources.GetObject("dtTo.Icon"), System.Drawing.Image)
        Me.dtTo.IconColor = System.Drawing.Color.Gray
        Me.dtTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dtTo.LeftTextMargin = 5
        Me.dtTo.Location = New System.Drawing.Point(367, 133)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtTo.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(292, 32)
        Me.dtTo.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnGo.Depth = 0
        Me.btnGo.HighEmphasis = True
        Me.btnGo.Icon = Nothing
        Me.btnGo.Location = New System.Drawing.Point(575, 74)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnGo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGo.Name = "btnGo"
        Me.btnGo.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnGo.Size = New System.Drawing.Size(64, 36)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnGo.UseAccentColor = False
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.Depth = 0
        Me.cbAll.Location = New System.Drawing.Point(367, 73)
        Me.cbAll.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAll.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cbAll.MouseState = MaterialSkin.MouseState.HOVER
        Me.cbAll.Name = "cbAll"
        Me.cbAll.ReadOnly = False
        Me.cbAll.Ripple = True
        Me.cbAll.Size = New System.Drawing.Size(100, 37)
        Me.cbAll.TabIndex = 5
        Me.cbAll.Text = "Select All"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'filterReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 213)
        Me.Controls.Add(Me.cbAll)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.Controls.Add(Me.cmbCriteria)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "filterReports"
        Me.Padding = New System.Windows.Forms.Padding(4, 30, 4, 4)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filter Criteria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCriteria As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents dtFrom As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents dtTo As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents btnGo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cbAll As MaterialSkin.Controls.MaterialCheckbox
End Class
