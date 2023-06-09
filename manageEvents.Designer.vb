<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageEvents))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtEventID = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtEventName = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtVenue = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtEventDescription = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.btnSaveEvent = New MaterialSkin.Controls.MaterialButton()
        Me.cmbHourStr = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbMinutesStr = New MaterialSkin.Controls.MaterialComboBox()
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.txtEventStart = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtEventEnd = New MaterialSkin.Controls.MaterialTextBox()
        Me.dtEnd = New System.Windows.Forms.DateTimePicker()
        Me.cmbHourEnd = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbMinutesEnd = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbAMPMEnd = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbAMPMStr = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbEventFor = New MaterialSkin.Controls.MaterialComboBox()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        Me.MaterialLabel1.Location = New System.Drawing.Point(35, 52)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(215, 58)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Add Event"
        '
        'txtEventID
        '
        Me.txtEventID.AnimateReadOnly = False
        Me.txtEventID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventID.Depth = 0
        Me.txtEventID.Enabled = False
        Me.txtEventID.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEventID.Hint = "ID"
        Me.txtEventID.LeadingIcon = Nothing
        Me.txtEventID.Location = New System.Drawing.Point(23, 127)
        Me.txtEventID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEventID.MaxLength = 50
        Me.txtEventID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtEventID.Multiline = False
        Me.txtEventID.Name = "txtEventID"
        Me.txtEventID.Size = New System.Drawing.Size(119, 50)
        Me.txtEventID.TabIndex = 1
        Me.txtEventID.Text = ""
        Me.txtEventID.TrailingIcon = Nothing
        '
        'txtEventName
        '
        Me.txtEventName.AnimateReadOnly = False
        Me.txtEventName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventName.Depth = 0
        Me.txtEventName.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEventName.Hint = "Event"
        Me.txtEventName.LeadingIcon = Nothing
        Me.txtEventName.Location = New System.Drawing.Point(149, 127)
        Me.txtEventName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEventName.MaxLength = 50
        Me.txtEventName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtEventName.Multiline = False
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(581, 50)
        Me.txtEventName.TabIndex = 2
        Me.txtEventName.Text = ""
        Me.txtEventName.TrailingIcon = Nothing
        '
        'txtVenue
        '
        Me.txtVenue.AnimateReadOnly = False
        Me.txtVenue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVenue.Depth = 0
        Me.txtVenue.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtVenue.Hint = "Venue"
        Me.txtVenue.LeadingIcon = Nothing
        Me.txtVenue.Location = New System.Drawing.Point(23, 196)
        Me.txtVenue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVenue.MaxLength = 50
        Me.txtVenue.MouseState = MaterialSkin.MouseState.OUT
        Me.txtVenue.Multiline = False
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(423, 50)
        Me.txtVenue.TabIndex = 3
        Me.txtVenue.Text = ""
        Me.txtVenue.TrailingIcon = Nothing
        '
        'txtEventDescription
        '
        Me.txtEventDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEventDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventDescription.Depth = 0
        Me.txtEventDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEventDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEventDescription.Hint = "Description"
        Me.txtEventDescription.Location = New System.Drawing.Point(23, 265)
        Me.txtEventDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEventDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEventDescription.Name = "txtEventDescription"
        Me.txtEventDescription.Size = New System.Drawing.Size(708, 177)
        Me.txtEventDescription.TabIndex = 5
        Me.txtEventDescription.Text = ""
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveEvent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSaveEvent.Depth = 0
        Me.btnSaveEvent.HighEmphasis = True
        Me.btnSaveEvent.Icon = Global.AMS.My.Resources.Resources.icons8_sent_96
        Me.btnSaveEvent.Location = New System.Drawing.Point(587, 598)
        Me.btnSaveEvent.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnSaveEvent.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSaveEvent.Size = New System.Drawing.Size(86, 36)
        Me.btnSaveEvent.TabIndex = 14
        Me.btnSaveEvent.Text = "Save"
        Me.btnSaveEvent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSaveEvent.UseAccentColor = False
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'cmbHourStr
        '
        Me.cmbHourStr.AutoResize = False
        Me.cmbHourStr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbHourStr.Depth = 0
        Me.cmbHourStr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbHourStr.DropDownHeight = 174
        Me.cmbHourStr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHourStr.DropDownWidth = 121
        Me.cmbHourStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbHourStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbHourStr.FormattingEnabled = True
        Me.cmbHourStr.IntegralHeight = False
        Me.cmbHourStr.ItemHeight = 43
        Me.cmbHourStr.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "01", "02", "03", "04", "05", "06", "07"})
        Me.cmbHourStr.Location = New System.Drawing.Point(387, 449)
        Me.cmbHourStr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbHourStr.MaxDropDownItems = 4
        Me.cmbHourStr.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbHourStr.Name = "cmbHourStr"
        Me.cmbHourStr.Size = New System.Drawing.Size(108, 49)
        Me.cmbHourStr.StartIndex = 0
        Me.cmbHourStr.TabIndex = 7
        '
        'cmbMinutesStr
        '
        Me.cmbMinutesStr.AutoResize = False
        Me.cmbMinutesStr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMinutesStr.Depth = 0
        Me.cmbMinutesStr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbMinutesStr.DropDownHeight = 174
        Me.cmbMinutesStr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMinutesStr.DropDownWidth = 121
        Me.cmbMinutesStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbMinutesStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbMinutesStr.FormattingEnabled = True
        Me.cmbMinutesStr.IntegralHeight = False
        Me.cmbMinutesStr.ItemHeight = 43
        Me.cmbMinutesStr.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMinutesStr.Location = New System.Drawing.Point(504, 449)
        Me.cmbMinutesStr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbMinutesStr.MaxDropDownItems = 4
        Me.cmbMinutesStr.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbMinutesStr.Name = "cmbMinutesStr"
        Me.cmbMinutesStr.Size = New System.Drawing.Size(108, 49)
        Me.cmbMinutesStr.StartIndex = 0
        Me.cmbMinutesStr.TabIndex = 8
        '
        'dtStart
        '
        Me.dtStart.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtStart.CustomFormat = ""
        Me.dtStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtStart.Location = New System.Drawing.Point(355, 466)
        Me.dtStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(23, 29)
        Me.dtStart.TabIndex = 9
        '
        'txtEventStart
        '
        Me.txtEventStart.AnimateReadOnly = False
        Me.txtEventStart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventStart.Depth = 0
        Me.txtEventStart.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEventStart.Hint = "Start"
        Me.txtEventStart.LeadingIcon = Nothing
        Me.txtEventStart.Location = New System.Drawing.Point(23, 449)
        Me.txtEventStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEventStart.MaxLength = 50
        Me.txtEventStart.MouseState = MaterialSkin.MouseState.OUT
        Me.txtEventStart.Multiline = False
        Me.txtEventStart.Name = "txtEventStart"
        Me.txtEventStart.Size = New System.Drawing.Size(356, 50)
        Me.txtEventStart.TabIndex = 6
        Me.txtEventStart.Text = ""
        Me.txtEventStart.TrailingIcon = Nothing
        '
        'txtEventEnd
        '
        Me.txtEventEnd.AnimateReadOnly = False
        Me.txtEventEnd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventEnd.Depth = 0
        Me.txtEventEnd.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEventEnd.Hint = "End"
        Me.txtEventEnd.LeadingIcon = Nothing
        Me.txtEventEnd.Location = New System.Drawing.Point(23, 521)
        Me.txtEventEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEventEnd.MaxLength = 50
        Me.txtEventEnd.MouseState = MaterialSkin.MouseState.OUT
        Me.txtEventEnd.Multiline = False
        Me.txtEventEnd.Name = "txtEventEnd"
        Me.txtEventEnd.Size = New System.Drawing.Size(356, 50)
        Me.txtEventEnd.TabIndex = 10
        Me.txtEventEnd.Text = ""
        Me.txtEventEnd.TrailingIcon = Nothing
        '
        'dtEnd
        '
        Me.dtEnd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEnd.Location = New System.Drawing.Point(355, 535)
        Me.dtEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(23, 29)
        Me.dtEnd.TabIndex = 9
        '
        'cmbHourEnd
        '
        Me.cmbHourEnd.AutoResize = False
        Me.cmbHourEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbHourEnd.Depth = 0
        Me.cmbHourEnd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbHourEnd.DropDownHeight = 174
        Me.cmbHourEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHourEnd.DropDownWidth = 121
        Me.cmbHourEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbHourEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbHourEnd.FormattingEnabled = True
        Me.cmbHourEnd.IntegralHeight = False
        Me.cmbHourEnd.ItemHeight = 43
        Me.cmbHourEnd.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "01", "02", "03", "04", "05", "06", "07"})
        Me.cmbHourEnd.Location = New System.Drawing.Point(387, 519)
        Me.cmbHourEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbHourEnd.MaxDropDownItems = 4
        Me.cmbHourEnd.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbHourEnd.Name = "cmbHourEnd"
        Me.cmbHourEnd.Size = New System.Drawing.Size(108, 49)
        Me.cmbHourEnd.StartIndex = 0
        Me.cmbHourEnd.TabIndex = 11
        '
        'cmbMinutesEnd
        '
        Me.cmbMinutesEnd.AutoResize = False
        Me.cmbMinutesEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMinutesEnd.Depth = 0
        Me.cmbMinutesEnd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbMinutesEnd.DropDownHeight = 174
        Me.cmbMinutesEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMinutesEnd.DropDownWidth = 121
        Me.cmbMinutesEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbMinutesEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbMinutesEnd.FormattingEnabled = True
        Me.cmbMinutesEnd.IntegralHeight = False
        Me.cmbMinutesEnd.ItemHeight = 43
        Me.cmbMinutesEnd.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMinutesEnd.Location = New System.Drawing.Point(504, 519)
        Me.cmbMinutesEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbMinutesEnd.MaxDropDownItems = 4
        Me.cmbMinutesEnd.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbMinutesEnd.Name = "cmbMinutesEnd"
        Me.cmbMinutesEnd.Size = New System.Drawing.Size(108, 49)
        Me.cmbMinutesEnd.StartIndex = 0
        Me.cmbMinutesEnd.TabIndex = 12
        '
        'cmbAMPMEnd
        '
        Me.cmbAMPMEnd.AutoResize = False
        Me.cmbAMPMEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAMPMEnd.Depth = 0
        Me.cmbAMPMEnd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbAMPMEnd.DropDownHeight = 174
        Me.cmbAMPMEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAMPMEnd.DropDownWidth = 121
        Me.cmbAMPMEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbAMPMEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbAMPMEnd.FormattingEnabled = True
        Me.cmbAMPMEnd.IntegralHeight = False
        Me.cmbAMPMEnd.ItemHeight = 43
        Me.cmbAMPMEnd.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbAMPMEnd.Location = New System.Drawing.Point(621, 519)
        Me.cmbAMPMEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbAMPMEnd.MaxDropDownItems = 4
        Me.cmbAMPMEnd.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbAMPMEnd.Name = "cmbAMPMEnd"
        Me.cmbAMPMEnd.Size = New System.Drawing.Size(108, 49)
        Me.cmbAMPMEnd.StartIndex = 0
        Me.cmbAMPMEnd.TabIndex = 13
        '
        'cmbAMPMStr
        '
        Me.cmbAMPMStr.AutoResize = False
        Me.cmbAMPMStr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAMPMStr.Depth = 0
        Me.cmbAMPMStr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbAMPMStr.DropDownHeight = 174
        Me.cmbAMPMStr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAMPMStr.DropDownWidth = 121
        Me.cmbAMPMStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbAMPMStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbAMPMStr.FormattingEnabled = True
        Me.cmbAMPMStr.IntegralHeight = False
        Me.cmbAMPMStr.ItemHeight = 43
        Me.cmbAMPMStr.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbAMPMStr.Location = New System.Drawing.Point(621, 449)
        Me.cmbAMPMStr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbAMPMStr.MaxDropDownItems = 4
        Me.cmbAMPMStr.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbAMPMStr.Name = "cmbAMPMStr"
        Me.cmbAMPMStr.Size = New System.Drawing.Size(108, 49)
        Me.cmbAMPMStr.StartIndex = 0
        Me.cmbAMPMStr.TabIndex = 9
        '
        'cmbEventFor
        '
        Me.cmbEventFor.AutoResize = False
        Me.cmbEventFor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbEventFor.Depth = 0
        Me.cmbEventFor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbEventFor.DropDownHeight = 174
        Me.cmbEventFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEventFor.DropDownWidth = 121
        Me.cmbEventFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbEventFor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbEventFor.FormattingEnabled = True
        Me.cmbEventFor.Hint = "For"
        Me.cmbEventFor.IntegralHeight = False
        Me.cmbEventFor.ItemHeight = 43
        Me.cmbEventFor.Items.AddRange(New Object() {"ALL", "GRADE 1", "GRADE 2", "GRADE 3", "GRADE 4", "GRADE 5", "GRADE 6", "GRADE 7"})
        Me.cmbEventFor.Location = New System.Drawing.Point(455, 196)
        Me.cmbEventFor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbEventFor.MaxDropDownItems = 4
        Me.cmbEventFor.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbEventFor.Name = "cmbEventFor"
        Me.cmbEventFor.Size = New System.Drawing.Size(275, 49)
        Me.cmbEventFor.StartIndex = 0
        Me.cmbEventFor.TabIndex = 4
        '
        'manageEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 668)
        Me.Controls.Add(Me.cmbEventFor)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.cmbAMPMEnd)
        Me.Controls.Add(Me.cmbAMPMStr)
        Me.Controls.Add(Me.cmbMinutesEnd)
        Me.Controls.Add(Me.cmbHourEnd)
        Me.Controls.Add(Me.cmbMinutesStr)
        Me.Controls.Add(Me.cmbHourStr)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.Controls.Add(Me.txtEventDescription)
        Me.Controls.Add(Me.txtEventEnd)
        Me.Controls.Add(Me.txtEventStart)
        Me.Controls.Add(Me.txtVenue)
        Me.Controls.Add(Me.txtEventName)
        Me.Controls.Add(Me.txtEventID)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "manageEvents"
        Me.Padding = New System.Windows.Forms.Padding(4, 30, 4, 4)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtEventID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtEventName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtVenue As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtEventDescription As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents btnSaveEvent As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmbHourStr As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbMinutesStr As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents txtEventStart As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtEventEnd As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents cmbHourEnd As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbMinutesEnd As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbAMPMEnd As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbAMPMStr As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbEventFor As MaterialSkin.Controls.MaterialComboBox
End Class
