<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class importMultipleStudents
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(importMultipleStudents))
        Me.btnSaveMultiple = New MaterialSkin.Controls.MaterialButton()
        Me.btnOpenFile = New MaterialSkin.Controls.MaterialButton()
        Me.lblcountrec = New MaterialSkin.Controls.MaterialLabel()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveMultiple
        '
        Me.btnSaveMultiple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveMultiple.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSaveMultiple.Depth = 0
        Me.btnSaveMultiple.HighEmphasis = True
        Me.btnSaveMultiple.Icon = Global.AMS.My.Resources.Resources.icons8_save_96
        Me.btnSaveMultiple.Location = New System.Drawing.Point(140, 92)
        Me.btnSaveMultiple.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnSaveMultiple.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveMultiple.Name = "btnSaveMultiple"
        Me.btnSaveMultiple.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSaveMultiple.Size = New System.Drawing.Size(86, 36)
        Me.btnSaveMultiple.TabIndex = 12
        Me.btnSaveMultiple.Text = "Save"
        Me.btnSaveMultiple.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSaveMultiple.UseAccentColor = False
        Me.btnSaveMultiple.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOpenFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnOpenFile.Depth = 0
        Me.btnOpenFile.HighEmphasis = True
        Me.btnOpenFile.Icon = Global.AMS.My.Resources.Resources.icons8_upload_to_ftp_96
        Me.btnOpenFile.Location = New System.Drawing.Point(12, 92)
        Me.btnOpenFile.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnOpenFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnOpenFile.Size = New System.Drawing.Size(88, 36)
        Me.btnOpenFile.TabIndex = 11
        Me.btnOpenFile.Text = "Open"
        Me.btnOpenFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnOpenFile.UseAccentColor = False
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lblcountrec
        '
        Me.lblcountrec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcountrec.AutoSize = True
        Me.lblcountrec.Depth = 0
        Me.lblcountrec.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblcountrec.Location = New System.Drawing.Point(1116, 110)
        Me.lblcountrec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcountrec.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblcountrec.Name = "lblcountrec"
        Me.lblcountrec.Size = New System.Drawing.Size(1, 0)
        Me.lblcountrec.TabIndex = 15
        '
        'BunifuDataGridView1
        '
        Me.BunifuDataGridView1.AllowCustomTheming = True
        Me.BunifuDataGridView1.AllowUserToAddRows = False
        Me.BunifuDataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuDataGridView1.ColumnHeadersHeight = 40
        Me.BunifuDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuDataGridView1.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(12, 148)
        Me.BunifuDataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.ReadOnly = True
        Me.BunifuDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowHeadersWidth = 51
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(1267, 592)
        Me.BunifuDataGridView1.TabIndex = 16
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Last_Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "First_Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Middle_Name"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Grade"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Guardian_Name"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Contact_No"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'importMultipleStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 747)
        Me.Controls.Add(Me.BunifuDataGridView1)
        Me.Controls.Add(Me.lblcountrec)
        Me.Controls.Add(Me.btnSaveMultiple)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "importMultipleStudents"
        Me.Padding = New System.Windows.Forms.Padding(4, 79, 4, 4)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from CSV"
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveMultiple As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnOpenFile As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblcountrec As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
