<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.homeTab = New System.Windows.Forms.TabPage()
        Me.MaterialCard9 = New MaterialSkin.Controls.MaterialCard()
        Me.chartLogs = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.chartEvents = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTotalLogs = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTotalEvents = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTotalStudents = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.chartStudents = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.studentsTab = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteMultiple = New MaterialSkin.Controls.MaterialButton()
        Me.btnImportMultipleStud = New MaterialSkin.Controls.MaterialButton()
        Me.txtSearchStudent = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblcountrec = New MaterialSkin.Controls.MaterialLabel()
        Me.btnEditStudent = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddStudent = New MaterialSkin.Controls.MaterialButton()
        Me.eventTab = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuDataGridView2 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblcounteventrec = New MaterialSkin.Controls.MaterialLabel()
        Me.txtSearchEvent = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnEditEvent = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddEvent = New MaterialSkin.Controls.MaterialButton()
        Me.attendanceTab = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtgrade = New MaterialSkin.Controls.MaterialLabel()
        Me.txtMname = New MaterialSkin.Controls.MaterialLabel()
        Me.txtfname = New MaterialSkin.Controls.MaterialLabel()
        Me.txtlname = New MaterialSkin.Controls.MaterialLabel()
        Me.pbStudImg = New System.Windows.Forms.PictureBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BunifuDataGridView3 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ScannedTextbox = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnScan = New MaterialSkin.Controls.MaterialButton()
        Me.eventSwitch = New MaterialSkin.Controls.MaterialSwitch()
        Me.lblAttendeesCount = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.cmbEventList = New MaterialSkin.Controls.MaterialComboBox()
        Me.SMSTab = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BunifuDataGridView4 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtsearchsms = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblcountsms = New MaterialSkin.Controls.MaterialLabel()
        Me.ReportsTab = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.dgwRpt = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnPrint = New MaterialSkin.Controls.MaterialButton()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.btnReport = New MaterialSkin.Controls.MaterialButton()
        Me.cmbReportFilter = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbReportType = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblCountRpt = New MaterialSkin.Controls.MaterialLabel()
        Me.settingsTab = New System.Windows.Forms.TabPage()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.btnServerSetting = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnRestore = New MaterialSkin.Controls.MaterialButton()
        Me.btnBackup = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard10 = New MaterialSkin.Controls.MaterialCard()
        Me.btnManageUser = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.panelChangePassword = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.txtconfirmpassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtoldpassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtnewpassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialExpansionPanel2 = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.txtBackupLocation = New MaterialSkin.Controls.MaterialTextBox2()
        Me.pnlDBsetting = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.txtDBPassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtDBname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtDBUsername = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtServer = New MaterialSkin.Controls.MaterialTextBox2()
        Me.aboutTab = New System.Windows.Forms.TabPage()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnGmail = New MaterialSkin.Controls.MaterialButton()
        Me.btnYoutube = New MaterialSkin.Controls.MaterialButton()
        Me.btnFaceBook = New MaterialSkin.Controls.MaterialButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.eventTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialTabControl1.SuspendLayout()
        Me.homeTab.SuspendLayout()
        Me.MaterialCard9.SuspendLayout()
        CType(Me.chartLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard6.SuspendLayout()
        CType(Me.chartEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard8.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard7.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.chartStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentsTab.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.eventTab.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.BunifuDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.attendanceTab.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.pbStudImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.BunifuDataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SMSTab.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.BunifuDataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.ReportsTab.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.dgwRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.settingsTab.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        Me.MaterialCard10.SuspendLayout()
        Me.panelChangePassword.SuspendLayout()
        Me.MaterialExpansionPanel2.SuspendLayout()
        Me.pnlDBsetting.SuspendLayout()
        Me.aboutTab.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.homeTab)
        Me.MaterialTabControl1.Controls.Add(Me.studentsTab)
        Me.MaterialTabControl1.Controls.Add(Me.eventTab)
        Me.MaterialTabControl1.Controls.Add(Me.attendanceTab)
        Me.MaterialTabControl1.Controls.Add(Me.SMSTab)
        Me.MaterialTabControl1.Controls.Add(Me.ReportsTab)
        Me.MaterialTabControl1.Controls.Add(Me.settingsTab)
        Me.MaterialTabControl1.Controls.Add(Me.aboutTab)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.ImageList = Me.ImageList1
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 64)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1183, 592)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'homeTab
        '
        Me.homeTab.BackColor = System.Drawing.Color.White
        Me.homeTab.Controls.Add(Me.MaterialCard9)
        Me.homeTab.Controls.Add(Me.MaterialCard6)
        Me.homeTab.Controls.Add(Me.MaterialCard8)
        Me.homeTab.Controls.Add(Me.MaterialCard7)
        Me.homeTab.Controls.Add(Me.MaterialCard5)
        Me.homeTab.Controls.Add(Me.MaterialCard1)
        Me.homeTab.ImageKey = "icons8-home-page-96.png"
        Me.homeTab.Location = New System.Drawing.Point(4, 31)
        Me.homeTab.Name = "homeTab"
        Me.homeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.homeTab.Size = New System.Drawing.Size(1175, 557)
        Me.homeTab.TabIndex = 0
        Me.homeTab.Text = "Home"
        '
        'MaterialCard9
        '
        Me.MaterialCard9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialCard9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard9.Controls.Add(Me.chartLogs)
        Me.MaterialCard9.Depth = 0
        Me.MaterialCard9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard9.Location = New System.Drawing.Point(791, 233)
        Me.MaterialCard9.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard9.Name = "MaterialCard9"
        Me.MaterialCard9.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard9.Size = New System.Drawing.Size(367, 285)
        Me.MaterialCard9.TabIndex = 3
        '
        'chartLogs
        '
        Me.chartLogs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartLogs.BackColor = System.Drawing.SystemColors.ControlDarkDark
        ChartArea1.Name = "ChartArea1"
        Me.chartLogs.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartLogs.Legends.Add(Legend1)
        Me.chartLogs.Location = New System.Drawing.Point(13, 17)
        Me.chartLogs.Name = "chartLogs"
        Series1.ChartArea = "ChartArea1"
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartLogs.Series.Add(Series1)
        Me.chartLogs.Size = New System.Drawing.Size(343, 251)
        Me.chartLogs.TabIndex = 0
        '
        'MaterialCard6
        '
        Me.MaterialCard6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.chartEvents)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(404, 236)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(367, 285)
        Me.MaterialCard6.TabIndex = 3
        '
        'chartEvents
        '
        Me.chartEvents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartEvents.BackColor = System.Drawing.SystemColors.ControlDarkDark
        ChartArea2.Name = "ChartArea1"
        Me.chartEvents.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartEvents.Legends.Add(Legend2)
        Me.chartEvents.Location = New System.Drawing.Point(13, 17)
        Me.chartEvents.Name = "chartEvents"
        Me.chartEvents.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.ChartArea = "ChartArea1"
        Series2.LabelBackColor = System.Drawing.Color.Transparent
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartEvents.Series.Add(Series2)
        Me.chartEvents.Size = New System.Drawing.Size(343, 251)
        Me.chartEvents.TabIndex = 0
        '
        'MaterialCard8
        '
        Me.MaterialCard8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialCard8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard8.Controls.Add(Me.PictureBox5)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel8)
        Me.MaterialCard8.Controls.Add(Me.lblTotalLogs)
        Me.MaterialCard8.Depth = 0
        Me.MaterialCard8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard8.Location = New System.Drawing.Point(791, 14)
        Me.MaterialCard8.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard8.Name = "MaterialCard8"
        Me.MaterialCard8.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.Size = New System.Drawing.Size(367, 181)
        Me.MaterialCard8.TabIndex = 2
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.AMS.My.Resources.Resources.icons8_edit_calendar_100
        Me.PictureBox5.Location = New System.Drawing.Point(251, 32)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel8.HighEmphasis = True
        Me.MaterialLabel8.Location = New System.Drawing.Point(4, 32)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(241, 41)
        Me.MaterialLabel8.TabIndex = 0
        Me.MaterialLabel8.Text = "Total Logs Today"
        Me.MaterialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalLogs
        '
        Me.lblTotalLogs.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalLogs.Depth = 0
        Me.lblTotalLogs.Font = New System.Drawing.Font("Roboto Light", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTotalLogs.FontType = MaterialSkin.MaterialSkinManager.fontType.H2
        Me.lblTotalLogs.HighEmphasis = True
        Me.lblTotalLogs.Location = New System.Drawing.Point(5, 70)
        Me.lblTotalLogs.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotalLogs.Name = "lblTotalLogs"
        Me.lblTotalLogs.Size = New System.Drawing.Size(236, 72)
        Me.lblTotalLogs.TabIndex = 0
        Me.lblTotalLogs.Text = "0"
        Me.lblTotalLogs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTotalLogs.UseAccent = True
        '
        'MaterialCard7
        '
        Me.MaterialCard7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialCard7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard7.Controls.Add(Me.PictureBox4)
        Me.MaterialCard7.Controls.Add(Me.MaterialLabel7)
        Me.MaterialCard7.Controls.Add(Me.lblTotalEvents)
        Me.MaterialCard7.Depth = 0
        Me.MaterialCard7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard7.Location = New System.Drawing.Point(404, 17)
        Me.MaterialCard7.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard7.Name = "MaterialCard7"
        Me.MaterialCard7.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.Size = New System.Drawing.Size(367, 181)
        Me.MaterialCard7.TabIndex = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.AMS.My.Resources.Resources.icons8_schedule_100
        Me.PictureBox4.Location = New System.Drawing.Point(251, 32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel7.HighEmphasis = True
        Me.MaterialLabel7.Location = New System.Drawing.Point(4, 32)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(241, 41)
        Me.MaterialLabel7.TabIndex = 0
        Me.MaterialLabel7.Text = "Total Event Record"
        Me.MaterialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalEvents
        '
        Me.lblTotalEvents.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalEvents.Depth = 0
        Me.lblTotalEvents.Font = New System.Drawing.Font("Roboto Light", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTotalEvents.FontType = MaterialSkin.MaterialSkinManager.fontType.H2
        Me.lblTotalEvents.HighEmphasis = True
        Me.lblTotalEvents.Location = New System.Drawing.Point(5, 70)
        Me.lblTotalEvents.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotalEvents.Name = "lblTotalEvents"
        Me.lblTotalEvents.Size = New System.Drawing.Size(236, 72)
        Me.lblTotalEvents.TabIndex = 0
        Me.lblTotalEvents.Text = "0"
        Me.lblTotalEvents.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTotalEvents.UseAccent = True
        '
        'MaterialCard5
        '
        Me.MaterialCard5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard5.Controls.Add(Me.PictureBox3)
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard5.Controls.Add(Me.lblTotalStudents)
        Me.MaterialCard5.Depth = 0
        Me.MaterialCard5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard5.Location = New System.Drawing.Point(17, 17)
        Me.MaterialCard5.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard5.Name = "MaterialCard5"
        Me.MaterialCard5.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.Size = New System.Drawing.Size(367, 181)
        Me.MaterialCard5.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AMS.My.Resources.Resources.icons8_user_location_100
        Me.PictureBox3.Location = New System.Drawing.Point(250, 32)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 110)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel4.HighEmphasis = True
        Me.MaterialLabel4.Location = New System.Drawing.Point(3, 32)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(241, 41)
        Me.MaterialLabel4.TabIndex = 0
        Me.MaterialLabel4.Text = "Total Student Record"
        Me.MaterialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalStudents.Depth = 0
        Me.lblTotalStudents.Font = New System.Drawing.Font("Roboto Light", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTotalStudents.FontType = MaterialSkin.MaterialSkinManager.fontType.H2
        Me.lblTotalStudents.HighEmphasis = True
        Me.lblTotalStudents.Location = New System.Drawing.Point(1, 70)
        Me.lblTotalStudents.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(236, 72)
        Me.lblTotalStudents.TabIndex = 0
        Me.lblTotalStudents.Text = "0"
        Me.lblTotalStudents.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTotalStudents.UseAccent = True
        '
        'MaterialCard1
        '
        Me.MaterialCard1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.chartStudents)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(17, 236)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(367, 285)
        Me.MaterialCard1.TabIndex = 1
        '
        'chartStudents
        '
        Me.chartStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartStudents.BackColor = System.Drawing.SystemColors.ControlDarkDark
        ChartArea3.Name = "ChartArea1"
        Me.chartStudents.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartStudents.Legends.Add(Legend3)
        Me.chartStudents.Location = New System.Drawing.Point(13, 17)
        Me.chartStudents.Name = "chartStudents"
        Series3.ChartArea = "ChartArea1"
        Series3.LabelForeColor = System.Drawing.Color.White
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chartStudents.Series.Add(Series3)
        Me.chartStudents.Size = New System.Drawing.Size(343, 251)
        Me.chartStudents.TabIndex = 0
        '
        'studentsTab
        '
        Me.studentsTab.Controls.Add(Me.Panel2)
        Me.studentsTab.Controls.Add(Me.Panel1)
        Me.studentsTab.ImageKey = "icons8-user-96.png"
        Me.studentsTab.Location = New System.Drawing.Point(4, 31)
        Me.studentsTab.Name = "studentsTab"
        Me.studentsTab.Size = New System.Drawing.Size(1175, 557)
        Me.studentsTab.TabIndex = 3
        Me.studentsTab.Text = "Students"
        Me.studentsTab.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuDataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1175, 499)
        Me.Panel2.TabIndex = 12
        '
        'BunifuDataGridView1
        '
        Me.BunifuDataGridView1.AllowCustomTheming = False
        Me.BunifuDataGridView1.AllowUserToAddRows = False
        Me.BunifuDataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuDataGridView1.ColumnHeadersHeight = 40
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuDataGridView1.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.ReadOnly = True
        Me.BunifuDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowHeadersWidth = 51
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(1175, 499)
        Me.BunifuDataGridView1.TabIndex = 10
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDeleteMultiple)
        Me.Panel1.Controls.Add(Me.btnImportMultipleStud)
        Me.Panel1.Controls.Add(Me.txtSearchStudent)
        Me.Panel1.Controls.Add(Me.lblcountrec)
        Me.Panel1.Controls.Add(Me.btnEditStudent)
        Me.Panel1.Controls.Add(Me.btnAddStudent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 58)
        Me.Panel1.TabIndex = 11
        '
        'btnDeleteMultiple
        '
        Me.btnDeleteMultiple.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteMultiple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeleteMultiple.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnDeleteMultiple.Depth = 0
        Me.btnDeleteMultiple.HighEmphasis = True
        Me.btnDeleteMultiple.Icon = Global.AMS.My.Resources.Resources.icons8_trash_24
        Me.btnDeleteMultiple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteMultiple.Location = New System.Drawing.Point(845, 13)
        Me.btnDeleteMultiple.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDeleteMultiple.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDeleteMultiple.Name = "btnDeleteMultiple"
        Me.btnDeleteMultiple.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnDeleteMultiple.Size = New System.Drawing.Size(174, 36)
        Me.btnDeleteMultiple.TabIndex = 11
        Me.btnDeleteMultiple.Text = "Delete Multiple"
        Me.btnDeleteMultiple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteMultiple.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnDeleteMultiple.UseAccentColor = False
        Me.btnDeleteMultiple.UseVisualStyleBackColor = True
        '
        'btnImportMultipleStud
        '
        Me.btnImportMultipleStud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImportMultipleStud.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnImportMultipleStud.Depth = 0
        Me.btnImportMultipleStud.HighEmphasis = True
        Me.btnImportMultipleStud.Icon = Global.AMS.My.Resources.Resources.icons8_import_96
        Me.btnImportMultipleStud.Location = New System.Drawing.Point(186, 13)
        Me.btnImportMultipleStud.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnImportMultipleStud.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImportMultipleStud.Name = "btnImportMultipleStud"
        Me.btnImportMultipleStud.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnImportMultipleStud.Size = New System.Drawing.Size(104, 36)
        Me.btnImportMultipleStud.TabIndex = 10
        Me.btnImportMultipleStud.Text = "Import"
        Me.btnImportMultipleStud.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnImportMultipleStud.UseAccentColor = False
        Me.btnImportMultipleStud.UseVisualStyleBackColor = True
        '
        'txtSearchStudent
        '
        Me.txtSearchStudent.AnimateReadOnly = False
        Me.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchStudent.Depth = 0
        Me.txtSearchStudent.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSearchStudent.Hint = "Search By First Name or Last Name"
        Me.txtSearchStudent.LeadingIcon = Nothing
        Me.txtSearchStudent.Location = New System.Drawing.Point(297, 5)
        Me.txtSearchStudent.MaxLength = 50
        Me.txtSearchStudent.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSearchStudent.Multiline = False
        Me.txtSearchStudent.Name = "txtSearchStudent"
        Me.txtSearchStudent.Size = New System.Drawing.Size(291, 50)
        Me.txtSearchStudent.TabIndex = 9
        Me.txtSearchStudent.Text = ""
        Me.txtSearchStudent.TrailingIcon = Nothing
        '
        'lblcountrec
        '
        Me.lblcountrec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcountrec.AutoSize = True
        Me.lblcountrec.Depth = 0
        Me.lblcountrec.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblcountrec.Location = New System.Drawing.Point(1050, 23)
        Me.lblcountrec.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblcountrec.Name = "lblcountrec"
        Me.lblcountrec.Size = New System.Drawing.Size(1, 0)
        Me.lblcountrec.TabIndex = 1
        '
        'btnEditStudent
        '
        Me.btnEditStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnEditStudent.Depth = 0
        Me.btnEditStudent.HighEmphasis = True
        Me.btnEditStudent.Icon = Global.AMS.My.Resources.Resources.icons8_schedule_96
        Me.btnEditStudent.Location = New System.Drawing.Point(97, 13)
        Me.btnEditStudent.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEditStudent.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnEditStudent.Size = New System.Drawing.Size(81, 36)
        Me.btnEditStudent.TabIndex = 8
        Me.btnEditStudent.Text = "EDIT"
        Me.btnEditStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEditStudent.UseAccentColor = False
        Me.btnEditStudent.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnAddStudent.Depth = 0
        Me.btnAddStudent.HighEmphasis = True
        Me.btnAddStudent.Icon = Global.AMS.My.Resources.Resources.icons8_plus___96
        Me.btnAddStudent.Location = New System.Drawing.Point(11, 13)
        Me.btnAddStudent.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddStudent.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnAddStudent.Size = New System.Drawing.Size(78, 36)
        Me.btnAddStudent.TabIndex = 7
        Me.btnAddStudent.Text = "ADD"
        Me.btnAddStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAddStudent.UseAccentColor = False
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'eventTab
        '
        Me.eventTab.Controls.Add(Me.Panel4)
        Me.eventTab.Controls.Add(Me.Panel3)
        Me.eventTab.ImageKey = "icons8-schedule-96.png"
        Me.eventTab.Location = New System.Drawing.Point(4, 31)
        Me.eventTab.Name = "eventTab"
        Me.eventTab.Padding = New System.Windows.Forms.Padding(3)
        Me.eventTab.Size = New System.Drawing.Size(1175, 557)
        Me.eventTab.TabIndex = 1
        Me.eventTab.Text = "Events"
        Me.eventTab.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.BunifuDataGridView2)
        Me.Panel4.Location = New System.Drawing.Point(3, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1169, 486)
        Me.Panel4.TabIndex = 1
        '
        'BunifuDataGridView2
        '
        Me.BunifuDataGridView2.AllowCustomTheming = False
        Me.BunifuDataGridView2.AllowUserToAddRows = False
        Me.BunifuDataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BunifuDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.BunifuDataGridView2.ColumnHeadersHeight = 40
        Me.BunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView2.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuDataGridView2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView2.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView2.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BunifuDataGridView2.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuDataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.BunifuDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuDataGridView2.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuDataGridView2.HeaderBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView2.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView2.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuDataGridView2.Name = "BunifuDataGridView2"
        Me.BunifuDataGridView2.ReadOnly = True
        Me.BunifuDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuDataGridView2.RowHeadersVisible = False
        Me.BunifuDataGridView2.RowHeadersWidth = 51
        Me.BunifuDataGridView2.RowTemplate.Height = 40
        Me.BunifuDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView2.Size = New System.Drawing.Size(1169, 486)
        Me.BunifuDataGridView2.TabIndex = 11
        Me.BunifuDataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblcounteventrec)
        Me.Panel3.Controls.Add(Me.txtSearchEvent)
        Me.Panel3.Controls.Add(Me.btnEditEvent)
        Me.Panel3.Controls.Add(Me.btnAddEvent)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1169, 65)
        Me.Panel3.TabIndex = 0
        '
        'lblcounteventrec
        '
        Me.lblcounteventrec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcounteventrec.AutoSize = True
        Me.lblcounteventrec.Depth = 0
        Me.lblcounteventrec.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblcounteventrec.Location = New System.Drawing.Point(1050, 23)
        Me.lblcounteventrec.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblcounteventrec.Name = "lblcounteventrec"
        Me.lblcounteventrec.Size = New System.Drawing.Size(1, 0)
        Me.lblcounteventrec.TabIndex = 13
        '
        'txtSearchEvent
        '
        Me.txtSearchEvent.AnimateReadOnly = False
        Me.txtSearchEvent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchEvent.Depth = 0
        Me.txtSearchEvent.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSearchEvent.Hint = "Search"
        Me.txtSearchEvent.LeadingIcon = Nothing
        Me.txtSearchEvent.Location = New System.Drawing.Point(206, 9)
        Me.txtSearchEvent.MaxLength = 50
        Me.txtSearchEvent.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSearchEvent.Multiline = False
        Me.txtSearchEvent.Name = "txtSearchEvent"
        Me.txtSearchEvent.Size = New System.Drawing.Size(291, 50)
        Me.txtSearchEvent.TabIndex = 12
        Me.txtSearchEvent.Text = ""
        Me.txtSearchEvent.TrailingIcon = Nothing
        '
        'btnEditEvent
        '
        Me.btnEditEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditEvent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnEditEvent.Depth = 0
        Me.btnEditEvent.HighEmphasis = True
        Me.btnEditEvent.Icon = Global.AMS.My.Resources.Resources.icons8_schedule_96
        Me.btnEditEvent.Location = New System.Drawing.Point(95, 14)
        Me.btnEditEvent.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEditEvent.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditEvent.Name = "btnEditEvent"
        Me.btnEditEvent.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnEditEvent.Size = New System.Drawing.Size(81, 36)
        Me.btnEditEvent.TabIndex = 11
        Me.btnEditEvent.Text = "EDIT"
        Me.btnEditEvent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEditEvent.UseAccentColor = False
        Me.btnEditEvent.UseVisualStyleBackColor = True
        '
        'btnAddEvent
        '
        Me.btnAddEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddEvent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnAddEvent.Depth = 0
        Me.btnAddEvent.HighEmphasis = True
        Me.btnAddEvent.Icon = Global.AMS.My.Resources.Resources.icons8_plus___96
        Me.btnAddEvent.Location = New System.Drawing.Point(9, 14)
        Me.btnAddEvent.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddEvent.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnAddEvent.Size = New System.Drawing.Size(78, 36)
        Me.btnAddEvent.TabIndex = 10
        Me.btnAddEvent.Text = "ADD"
        Me.btnAddEvent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAddEvent.UseAccentColor = False
        Me.btnAddEvent.UseVisualStyleBackColor = True
        '
        'attendanceTab
        '
        Me.attendanceTab.Controls.Add(Me.StatusStrip1)
        Me.attendanceTab.Controls.Add(Me.Panel6)
        Me.attendanceTab.Controls.Add(Me.Panel5)
        Me.attendanceTab.ImageKey = "icons8-moleskine-96.png"
        Me.attendanceTab.Location = New System.Drawing.Point(4, 31)
        Me.attendanceTab.Name = "attendanceTab"
        Me.attendanceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.attendanceTab.Size = New System.Drawing.Size(1175, 557)
        Me.attendanceTab.TabIndex = 2
        Me.attendanceTab.Text = "Logs"
        Me.attendanceTab.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 528)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1169, 26)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripStatusLabel1.Text = "Status:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 72)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1169, 482)
        Me.Panel6.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel11, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel12, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1169, 482)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.BackgroundImage = Global.AMS.My.Resources.Resources.pngtree_kindergarten_enrollment_simple_literary_image_32528
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.txtgrade)
        Me.Panel11.Controls.Add(Me.txtMname)
        Me.Panel11.Controls.Add(Me.txtfname)
        Me.Panel11.Controls.Add(Me.txtlname)
        Me.Panel11.Controls.Add(Me.pbStudImg)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(868, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(298, 476)
        Me.Panel11.TabIndex = 0
        '
        'txtgrade
        '
        Me.txtgrade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtgrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgrade.Depth = 0
        Me.txtgrade.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtgrade.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.txtgrade.HighEmphasis = True
        Me.txtgrade.Location = New System.Drawing.Point(22, 410)
        Me.txtgrade.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.Size = New System.Drawing.Size(251, 38)
        Me.txtgrade.TabIndex = 13
        Me.txtgrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtgrade.UseAccent = True
        '
        'txtMname
        '
        Me.txtMname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMname.Depth = 0
        Me.txtMname.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMname.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.txtMname.HighEmphasis = True
        Me.txtMname.Location = New System.Drawing.Point(22, 361)
        Me.txtMname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(251, 38)
        Me.txtMname.TabIndex = 13
        Me.txtMname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtMname.UseAccent = True
        '
        'txtfname
        '
        Me.txtfname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfname.Depth = 0
        Me.txtfname.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtfname.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.txtfname.HighEmphasis = True
        Me.txtfname.Location = New System.Drawing.Point(22, 310)
        Me.txtfname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(251, 38)
        Me.txtfname.TabIndex = 13
        Me.txtfname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtfname.UseAccent = True
        '
        'txtlname
        '
        Me.txtlname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlname.Depth = 0
        Me.txtlname.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtlname.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.txtlname.HighEmphasis = True
        Me.txtlname.Location = New System.Drawing.Point(22, 259)
        Me.txtlname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(251, 38)
        Me.txtlname.TabIndex = 13
        Me.txtlname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtlname.UseAccent = True
        '
        'pbStudImg
        '
        Me.pbStudImg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbStudImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbStudImg.Image = Global.AMS.My.Resources.Resources._17_avatar_man_nodding_lineal
        Me.pbStudImg.Location = New System.Drawing.Point(22, 18)
        Me.pbStudImg.Name = "pbStudImg"
        Me.pbStudImg.Size = New System.Drawing.Size(251, 227)
        Me.pbStudImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbStudImg.TabIndex = 12
        Me.pbStudImg.TabStop = False
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.BunifuDataGridView3)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(859, 476)
        Me.Panel12.TabIndex = 1
        '
        'BunifuDataGridView3
        '
        Me.BunifuDataGridView3.AllowCustomTheming = False
        Me.BunifuDataGridView3.AllowUserToAddRows = False
        Me.BunifuDataGridView3.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.BunifuDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView3.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BunifuDataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.BunifuDataGridView3.ColumnHeadersHeight = 40
        Me.BunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView3.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView3.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuDataGridView3.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView3.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView3.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView3.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuDataGridView3.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView3.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView3.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BunifuDataGridView3.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView3.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView3.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuDataGridView3.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView3.DefaultCellStyle = DataGridViewCellStyle9
        Me.BunifuDataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuDataGridView3.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView3.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuDataGridView3.HeaderBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView3.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView3.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.BunifuDataGridView3.Name = "BunifuDataGridView3"
        Me.BunifuDataGridView3.ReadOnly = True
        Me.BunifuDataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuDataGridView3.RowHeadersVisible = False
        Me.BunifuDataGridView3.RowHeadersWidth = 51
        Me.BunifuDataGridView3.RowTemplate.Height = 40
        Me.BunifuDataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView3.Size = New System.Drawing.Size(859, 476)
        Me.BunifuDataGridView3.TabIndex = 11
        Me.BunifuDataGridView3.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ScannedTextbox)
        Me.Panel5.Controls.Add(Me.btnScan)
        Me.Panel5.Controls.Add(Me.eventSwitch)
        Me.Panel5.Controls.Add(Me.lblAttendeesCount)
        Me.Panel5.Controls.Add(Me.MaterialLabel1)
        Me.Panel5.Controls.Add(Me.cmbEventList)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1169, 69)
        Me.Panel5.TabIndex = 1
        '
        'ScannedTextbox
        '
        Me.ScannedTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ScannedTextbox.AnimateReadOnly = False
        Me.ScannedTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ScannedTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ScannedTextbox.Depth = 0
        Me.ScannedTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ScannedTextbox.HelperText = "Enter ID for manual attendance"
        Me.ScannedTextbox.HideSelection = True
        Me.ScannedTextbox.Hint = "ID"
        Me.ScannedTextbox.LeadingIcon = Nothing
        Me.ScannedTextbox.Location = New System.Drawing.Point(824, 10)
        Me.ScannedTextbox.MaxLength = 32767
        Me.ScannedTextbox.MouseState = MaterialSkin.MouseState.OUT
        Me.ScannedTextbox.Name = "ScannedTextbox"
        Me.ScannedTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ScannedTextbox.PrefixSuffixText = Nothing
        Me.ScannedTextbox.ReadOnly = False
        Me.ScannedTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ScannedTextbox.SelectedText = ""
        Me.ScannedTextbox.SelectionLength = 0
        Me.ScannedTextbox.SelectionStart = 0
        Me.ScannedTextbox.ShortcutsEnabled = True
        Me.ScannedTextbox.Size = New System.Drawing.Size(198, 48)
        Me.ScannedTextbox.TabIndex = 6
        Me.ScannedTextbox.TabStop = False
        Me.ScannedTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ScannedTextbox.TrailingIcon = Nothing
        Me.ScannedTextbox.UseSystemPasswordChar = False
        '
        'btnScan
        '
        Me.btnScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnScan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnScan.Depth = 0
        Me.btnScan.HighEmphasis = True
        Me.btnScan.Icon = Global.AMS.My.Resources.Resources.icons8_qr_code_96
        Me.btnScan.Location = New System.Drawing.Point(1053, 18)
        Me.btnScan.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnScan.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnScan.Name = "btnScan"
        Me.btnScan.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnScan.Size = New System.Drawing.Size(88, 36)
        Me.btnScan.TabIndex = 4
        Me.btnScan.Text = "Scan"
        Me.btnScan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnScan.UseAccentColor = False
        Me.btnScan.UseVisualStyleBackColor = True
        Me.btnScan.Visible = False
        '
        'eventSwitch
        '
        Me.eventSwitch.AutoSize = True
        Me.eventSwitch.Depth = 0
        Me.eventSwitch.Location = New System.Drawing.Point(497, 13)
        Me.eventSwitch.Margin = New System.Windows.Forms.Padding(0)
        Me.eventSwitch.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.eventSwitch.MouseState = MaterialSkin.MouseState.HOVER
        Me.eventSwitch.Name = "eventSwitch"
        Me.eventSwitch.Ripple = True
        Me.eventSwitch.Size = New System.Drawing.Size(175, 37)
        Me.eventSwitch.TabIndex = 3
        Me.eventSwitch.Text = "Switch to Events"
        Me.eventSwitch.UseVisualStyleBackColor = True
        '
        'lblAttendeesCount
        '
        Me.lblAttendeesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAttendeesCount.AutoSize = True
        Me.lblAttendeesCount.Depth = 0
        Me.lblAttendeesCount.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblAttendeesCount.Location = New System.Drawing.Point(1050, 23)
        Me.lblAttendeesCount.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAttendeesCount.Name = "lblAttendeesCount"
        Me.lblAttendeesCount.Size = New System.Drawing.Size(1, 0)
        Me.lblAttendeesCount.TabIndex = 2
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel1.Location = New System.Drawing.Point(26, 22)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(61, 24)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Event :"
        '
        'cmbEventList
        '
        Me.cmbEventList.AutoResize = False
        Me.cmbEventList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbEventList.Depth = 0
        Me.cmbEventList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbEventList.DropDownHeight = 174
        Me.cmbEventList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEventList.DropDownWidth = 121
        Me.cmbEventList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbEventList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbEventList.FormattingEnabled = True
        Me.cmbEventList.IntegralHeight = False
        Me.cmbEventList.ItemHeight = 43
        Me.cmbEventList.Location = New System.Drawing.Point(93, 9)
        Me.cmbEventList.MaxDropDownItems = 4
        Me.cmbEventList.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbEventList.Name = "cmbEventList"
        Me.cmbEventList.Size = New System.Drawing.Size(386, 49)
        Me.cmbEventList.StartIndex = 0
        Me.cmbEventList.TabIndex = 0
        '
        'SMSTab
        '
        Me.SMSTab.Controls.Add(Me.Panel8)
        Me.SMSTab.Controls.Add(Me.Panel7)
        Me.SMSTab.ImageKey = "icons8-envelope-96.png"
        Me.SMSTab.Location = New System.Drawing.Point(4, 31)
        Me.SMSTab.Name = "SMSTab"
        Me.SMSTab.Size = New System.Drawing.Size(1175, 557)
        Me.SMSTab.TabIndex = 7
        Me.SMSTab.Text = "SMS"
        Me.SMSTab.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.BunifuDataGridView4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 72)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1175, 485)
        Me.Panel8.TabIndex = 14
        '
        'BunifuDataGridView4
        '
        Me.BunifuDataGridView4.AllowCustomTheming = False
        Me.BunifuDataGridView4.AllowUserToAddRows = False
        Me.BunifuDataGridView4.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.BunifuDataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView4.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuDataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BunifuDataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.BunifuDataGridView4.ColumnHeadersHeight = 40
        Me.BunifuDataGridView4.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuDataGridView4.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView4.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView4.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuDataGridView4.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView4.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView4.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuDataGridView4.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView4.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView4.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView4.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuDataGridView4.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView4.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView4.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BunifuDataGridView4.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView4.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView4.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuDataGridView4.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView4.DefaultCellStyle = DataGridViewCellStyle12
        Me.BunifuDataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuDataGridView4.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView4.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuDataGridView4.HeaderBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuDataGridView4.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView4.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView4.Location = New System.Drawing.Point(0, 0)
        Me.BunifuDataGridView4.Name = "BunifuDataGridView4"
        Me.BunifuDataGridView4.ReadOnly = True
        Me.BunifuDataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuDataGridView4.RowHeadersVisible = False
        Me.BunifuDataGridView4.RowHeadersWidth = 51
        Me.BunifuDataGridView4.RowTemplate.Height = 40
        Me.BunifuDataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView4.Size = New System.Drawing.Size(1175, 485)
        Me.BunifuDataGridView4.TabIndex = 12
        Me.BunifuDataGridView4.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtsearchsms)
        Me.Panel7.Controls.Add(Me.lblcountsms)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1175, 72)
        Me.Panel7.TabIndex = 13
        '
        'txtsearchsms
        '
        Me.txtsearchsms.AnimateReadOnly = False
        Me.txtsearchsms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearchsms.Depth = 0
        Me.txtsearchsms.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtsearchsms.Hint = "Search"
        Me.txtsearchsms.LeadingIcon = Nothing
        Me.txtsearchsms.Location = New System.Drawing.Point(16, 12)
        Me.txtsearchsms.MaxLength = 50
        Me.txtsearchsms.MouseState = MaterialSkin.MouseState.OUT
        Me.txtsearchsms.Multiline = False
        Me.txtsearchsms.Name = "txtsearchsms"
        Me.txtsearchsms.Size = New System.Drawing.Size(291, 50)
        Me.txtsearchsms.TabIndex = 13
        Me.txtsearchsms.Text = ""
        Me.txtsearchsms.TrailingIcon = Nothing
        '
        'lblcountsms
        '
        Me.lblcountsms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcountsms.AutoSize = True
        Me.lblcountsms.Depth = 0
        Me.lblcountsms.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblcountsms.Location = New System.Drawing.Point(1050, 23)
        Me.lblcountsms.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblcountsms.Name = "lblcountsms"
        Me.lblcountsms.Size = New System.Drawing.Size(1, 0)
        Me.lblcountsms.TabIndex = 3
        '
        'ReportsTab
        '
        Me.ReportsTab.Controls.Add(Me.Panel10)
        Me.ReportsTab.Controls.Add(Me.Panel9)
        Me.ReportsTab.ImageKey = "icons8-graph-report-96.png"
        Me.ReportsTab.Location = New System.Drawing.Point(4, 31)
        Me.ReportsTab.Name = "ReportsTab"
        Me.ReportsTab.Size = New System.Drawing.Size(1175, 557)
        Me.ReportsTab.TabIndex = 8
        Me.ReportsTab.Text = "Reports"
        Me.ReportsTab.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.dgwRpt)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 72)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1175, 485)
        Me.Panel10.TabIndex = 16
        '
        'dgwRpt
        '
        Me.dgwRpt.AllowCustomTheming = False
        Me.dgwRpt.AllowUserToAddRows = False
        Me.dgwRpt.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        Me.dgwRpt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgwRpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwRpt.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwRpt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwRpt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgwRpt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwRpt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgwRpt.ColumnHeadersHeight = 40
        Me.dgwRpt.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgwRpt.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgwRpt.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgwRpt.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dgwRpt.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgwRpt.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.dgwRpt.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgwRpt.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.dgwRpt.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dgwRpt.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgwRpt.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgwRpt.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgwRpt.CurrentTheme.Name = Nothing
        Me.dgwRpt.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dgwRpt.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgwRpt.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgwRpt.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dgwRpt.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwRpt.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgwRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwRpt.EnableHeadersVisualStyles = False
        Me.dgwRpt.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgwRpt.HeaderBackColor = System.Drawing.Color.MediumSeaGreen
        Me.dgwRpt.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgwRpt.HeaderForeColor = System.Drawing.Color.White
        Me.dgwRpt.Location = New System.Drawing.Point(0, 0)
        Me.dgwRpt.Name = "dgwRpt"
        Me.dgwRpt.ReadOnly = True
        Me.dgwRpt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgwRpt.RowHeadersVisible = False
        Me.dgwRpt.RowHeadersWidth = 51
        Me.dgwRpt.RowTemplate.Height = 40
        Me.dgwRpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwRpt.Size = New System.Drawing.Size(1175, 485)
        Me.dgwRpt.TabIndex = 14
        Me.dgwRpt.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnPrint)
        Me.Panel9.Controls.Add(Me.btnExport)
        Me.Panel9.Controls.Add(Me.btnReport)
        Me.Panel9.Controls.Add(Me.cmbReportFilter)
        Me.Panel9.Controls.Add(Me.cmbReportType)
        Me.Panel9.Controls.Add(Me.lblCountRpt)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1175, 72)
        Me.Panel9.TabIndex = 15
        '
        'btnPrint
        '
        Me.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnPrint.Depth = 0
        Me.btnPrint.HighEmphasis = True
        Me.btnPrint.Icon = Global.AMS.My.Resources.Resources.icons8_print_96
        Me.btnPrint.Location = New System.Drawing.Point(595, 17)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPrint.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnPrint.Size = New System.Drawing.Size(91, 36)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnPrint.UseAccentColor = False
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExport.Depth = 0
        Me.btnExport.HighEmphasis = True
        Me.btnExport.Icon = Global.AMS.My.Resources.Resources.icons8_microsoft_excel_96
        Me.btnExport.Location = New System.Drawing.Point(694, 17)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExport.Name = "btnExport"
        Me.btnExport.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExport.Size = New System.Drawing.Size(105, 36)
        Me.btnExport.TabIndex = 17
        Me.btnExport.Text = "Export"
        Me.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnExport.UseAccentColor = False
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnReport.Depth = 0
        Me.btnReport.HighEmphasis = True
        Me.btnReport.Icon = Global.AMS.My.Resources.Resources.icons8_search_more_96
        Me.btnReport.Location = New System.Drawing.Point(481, 17)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReport.Name = "btnReport"
        Me.btnReport.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnReport.Size = New System.Drawing.Size(106, 36)
        Me.btnReport.TabIndex = 16
        Me.btnReport.Text = "search"
        Me.btnReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnReport.UseAccentColor = False
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'cmbReportFilter
        '
        Me.cmbReportFilter.AutoResize = False
        Me.cmbReportFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbReportFilter.Depth = 0
        Me.cmbReportFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbReportFilter.DropDownHeight = 174
        Me.cmbReportFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportFilter.DropDownWidth = 121
        Me.cmbReportFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbReportFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbReportFilter.FormattingEnabled = True
        Me.cmbReportFilter.IntegralHeight = False
        Me.cmbReportFilter.ItemHeight = 43
        Me.cmbReportFilter.Location = New System.Drawing.Point(340, 12)
        Me.cmbReportFilter.MaxDropDownItems = 4
        Me.cmbReportFilter.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbReportFilter.Name = "cmbReportFilter"
        Me.cmbReportFilter.Size = New System.Drawing.Size(121, 49)
        Me.cmbReportFilter.StartIndex = 0
        Me.cmbReportFilter.TabIndex = 15
        '
        'cmbReportType
        '
        Me.cmbReportType.AutoResize = False
        Me.cmbReportType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbReportType.Depth = 0
        Me.cmbReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbReportType.DropDownHeight = 174
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.DropDownWidth = 121
        Me.cmbReportType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbReportType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.IntegralHeight = False
        Me.cmbReportType.ItemHeight = 43
        Me.cmbReportType.Items.AddRange(New Object() {"Students", "Events", "Logs", "SMS"})
        Me.cmbReportType.Location = New System.Drawing.Point(15, 12)
        Me.cmbReportType.MaxDropDownItems = 4
        Me.cmbReportType.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(302, 49)
        Me.cmbReportType.StartIndex = 0
        Me.cmbReportType.TabIndex = 14
        '
        'lblCountRpt
        '
        Me.lblCountRpt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCountRpt.AutoSize = True
        Me.lblCountRpt.Depth = 0
        Me.lblCountRpt.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCountRpt.Location = New System.Drawing.Point(1050, 23)
        Me.lblCountRpt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCountRpt.Name = "lblCountRpt"
        Me.lblCountRpt.Size = New System.Drawing.Size(1, 0)
        Me.lblCountRpt.TabIndex = 3
        '
        'settingsTab
        '
        Me.settingsTab.Controls.Add(Me.MaterialCard3)
        Me.settingsTab.Controls.Add(Me.MaterialCard4)
        Me.settingsTab.Controls.Add(Me.MaterialCard10)
        Me.settingsTab.Controls.Add(Me.panelChangePassword)
        Me.settingsTab.Controls.Add(Me.MaterialExpansionPanel2)
        Me.settingsTab.Controls.Add(Me.pnlDBsetting)
        Me.settingsTab.ImageKey = "icons8-settings-96.png"
        Me.settingsTab.Location = New System.Drawing.Point(4, 31)
        Me.settingsTab.Name = "settingsTab"
        Me.settingsTab.Size = New System.Drawing.Size(1175, 557)
        Me.settingsTab.TabIndex = 4
        Me.settingsTab.Text = "Settings"
        Me.settingsTab.UseVisualStyleBackColor = True
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.btnServerSetting)
        Me.MaterialCard3.Controls.Add(Me.MaterialButton1)
        Me.MaterialCard3.Controls.Add(Me.MaterialLabel6)
        Me.MaterialCard3.Controls.Add(Me.MaterialLabel5)
        Me.MaterialCard3.Controls.Add(Me.btnRestore)
        Me.MaterialCard3.Controls.Add(Me.btnBackup)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(14, 28)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(372, 181)
        Me.MaterialCard3.TabIndex = 0
        '
        'btnServerSetting
        '
        Me.btnServerSetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnServerSetting.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnServerSetting.Depth = 0
        Me.btnServerSetting.HighEmphasis = True
        Me.btnServerSetting.Icon = Nothing
        Me.btnServerSetting.Location = New System.Drawing.Point(212, 67)
        Me.btnServerSetting.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnServerSetting.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnServerSetting.Name = "btnServerSetting"
        Me.btnServerSetting.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnServerSetting.Size = New System.Drawing.Size(75, 36)
        Me.btnServerSetting.TabIndex = 2
        Me.btnServerSetting.Text = "Modify"
        Me.btnServerSetting.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnServerSetting.UseAccentColor = False
        Me.btnServerSetting.UseVisualStyleBackColor = True
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(279, 125)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(75, 36)
        Me.MaterialButton1.TabIndex = 2
        Me.MaterialButton1.Text = "Modify"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel6.Location = New System.Drawing.Point(27, 125)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(305, 42)
        Me.MaterialLabel6.TabIndex = 1
        Me.MaterialLabel6.Text = "*The default backup location is at ""C:\backup\ams\"""
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel5.Location = New System.Drawing.Point(27, 18)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(146, 24)
        Me.MaterialLabel5.TabIndex = 1
        Me.MaterialLabel5.Text = "Backup Settings"
        '
        'btnRestore
        '
        Me.btnRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRestore.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnRestore.Depth = 0
        Me.btnRestore.HighEmphasis = True
        Me.btnRestore.Icon = Nothing
        Me.btnRestore.Location = New System.Drawing.Point(120, 67)
        Me.btnRestore.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRestore.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnRestore.Size = New System.Drawing.Size(84, 36)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnRestore.UseAccentColor = False
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnBackup.Depth = 0
        Me.btnBackup.HighEmphasis = True
        Me.btnBackup.Icon = Nothing
        Me.btnBackup.Location = New System.Drawing.Point(30, 67)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBackup.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnBackup.Size = New System.Drawing.Size(82, 36)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Back Up"
        Me.btnBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnBackup.UseAccentColor = False
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel12)
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel11)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(789, 28)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(372, 181)
        Me.MaterialCard4.TabIndex = 3
        Me.MaterialCard4.Visible = False
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel12.Location = New System.Drawing.Point(17, 132)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(226, 24)
        Me.MaterialLabel12.TabIndex = 1
        Me.MaterialLabel12.Text = "*Manage Database Settings"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel11.Location = New System.Drawing.Point(17, 14)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(165, 24)
        Me.MaterialLabel11.TabIndex = 1
        Me.MaterialLabel11.Text = "Database Settings"
        '
        'MaterialCard10
        '
        Me.MaterialCard10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard10.Controls.Add(Me.btnManageUser)
        Me.MaterialCard10.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard10.Controls.Add(Me.MaterialLabel10)
        Me.MaterialCard10.Depth = 0
        Me.MaterialCard10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard10.Location = New System.Drawing.Point(402, 28)
        Me.MaterialCard10.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard10.Name = "MaterialCard10"
        Me.MaterialCard10.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard10.Size = New System.Drawing.Size(372, 181)
        Me.MaterialCard10.TabIndex = 0
        '
        'btnManageUser
        '
        Me.btnManageUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnManageUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnManageUser.Depth = 0
        Me.btnManageUser.HighEmphasis = True
        Me.btnManageUser.Icon = Nothing
        Me.btnManageUser.Location = New System.Drawing.Point(31, 67)
        Me.btnManageUser.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnManageUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnManageUser.Size = New System.Drawing.Size(86, 36)
        Me.btnManageUser.TabIndex = 2
        Me.btnManageUser.Text = "Proceed"
        Me.btnManageUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnManageUser.UseAccentColor = False
        Me.btnManageUser.UseVisualStyleBackColor = True
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel9.Location = New System.Drawing.Point(27, 125)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(226, 42)
        Me.MaterialLabel9.TabIndex = 1
        Me.MaterialLabel9.Text = "*Manage Users (Administrator) *Change Password (User)"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel10.Location = New System.Drawing.Point(27, 18)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(153, 24)
        Me.MaterialLabel10.TabIndex = 1
        Me.MaterialLabel10.Text = "Account Settings"
        '
        'panelChangePassword
        '
        Me.panelChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelChangePassword.Collapse = True
        Me.panelChangePassword.Controls.Add(Me.txtconfirmpassword)
        Me.panelChangePassword.Controls.Add(Me.txtoldpassword)
        Me.panelChangePassword.Controls.Add(Me.txtnewpassword)
        Me.panelChangePassword.Depth = 0
        Me.panelChangePassword.Description = ""
        Me.panelChangePassword.ExpandHeight = 304
        Me.panelChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.panelChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelChangePassword.Location = New System.Drawing.Point(402, 161)
        Me.panelChangePassword.Margin = New System.Windows.Forms.Padding(16, 1, 16, 0)
        Me.panelChangePassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.panelChangePassword.Name = "panelChangePassword"
        Me.panelChangePassword.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.panelChangePassword.Size = New System.Drawing.Size(372, 48)
        Me.panelChangePassword.TabIndex = 1
        Me.panelChangePassword.Title = "Change Password"
        Me.panelChangePassword.ValidationButtonEnable = True
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.AnimateReadOnly = False
        Me.txtconfirmpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtconfirmpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtconfirmpassword.Depth = 0
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtconfirmpassword.HideSelection = True
        Me.txtconfirmpassword.Hint = "Confirm Password"
        Me.txtconfirmpassword.LeadingIcon = Nothing
        Me.txtconfirmpassword.Location = New System.Drawing.Point(27, 178)
        Me.txtconfirmpassword.MaxLength = 32767
        Me.txtconfirmpassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpassword.PrefixSuffixText = Nothing
        Me.txtconfirmpassword.ReadOnly = False
        Me.txtconfirmpassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtconfirmpassword.SelectedText = ""
        Me.txtconfirmpassword.SelectionLength = 0
        Me.txtconfirmpassword.SelectionStart = 0
        Me.txtconfirmpassword.ShortcutsEnabled = True
        Me.txtconfirmpassword.Size = New System.Drawing.Size(318, 48)
        Me.txtconfirmpassword.TabIndex = 4
        Me.txtconfirmpassword.TabStop = False
        Me.txtconfirmpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtconfirmpassword.TrailingIcon = Nothing
        Me.txtconfirmpassword.UseSystemPasswordChar = False
        '
        'txtoldpassword
        '
        Me.txtoldpassword.AnimateReadOnly = False
        Me.txtoldpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtoldpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtoldpassword.Depth = 0
        Me.txtoldpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtoldpassword.HideSelection = True
        Me.txtoldpassword.Hint = "Old Password"
        Me.txtoldpassword.LeadingIcon = Nothing
        Me.txtoldpassword.Location = New System.Drawing.Point(27, 55)
        Me.txtoldpassword.MaxLength = 32767
        Me.txtoldpassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtoldpassword.Name = "txtoldpassword"
        Me.txtoldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpassword.PrefixSuffixText = Nothing
        Me.txtoldpassword.ReadOnly = False
        Me.txtoldpassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtoldpassword.SelectedText = ""
        Me.txtoldpassword.SelectionLength = 0
        Me.txtoldpassword.SelectionStart = 0
        Me.txtoldpassword.ShortcutsEnabled = True
        Me.txtoldpassword.Size = New System.Drawing.Size(318, 48)
        Me.txtoldpassword.TabIndex = 2
        Me.txtoldpassword.TabStop = False
        Me.txtoldpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtoldpassword.TrailingIcon = Nothing
        Me.txtoldpassword.UseSystemPasswordChar = False
        '
        'txtnewpassword
        '
        Me.txtnewpassword.AnimateReadOnly = False
        Me.txtnewpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtnewpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnewpassword.Depth = 0
        Me.txtnewpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtnewpassword.HideSelection = True
        Me.txtnewpassword.Hint = "New Password"
        Me.txtnewpassword.LeadingIcon = Nothing
        Me.txtnewpassword.Location = New System.Drawing.Point(27, 119)
        Me.txtnewpassword.MaxLength = 32767
        Me.txtnewpassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpassword.PrefixSuffixText = Nothing
        Me.txtnewpassword.ReadOnly = False
        Me.txtnewpassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnewpassword.SelectedText = ""
        Me.txtnewpassword.SelectionLength = 0
        Me.txtnewpassword.SelectionStart = 0
        Me.txtnewpassword.ShortcutsEnabled = True
        Me.txtnewpassword.Size = New System.Drawing.Size(318, 48)
        Me.txtnewpassword.TabIndex = 3
        Me.txtnewpassword.TabStop = False
        Me.txtnewpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnewpassword.TrailingIcon = Nothing
        Me.txtnewpassword.UseSystemPasswordChar = False
        '
        'MaterialExpansionPanel2
        '
        Me.MaterialExpansionPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialExpansionPanel2.Collapse = True
        Me.MaterialExpansionPanel2.Controls.Add(Me.txtBackupLocation)
        Me.MaterialExpansionPanel2.Depth = 0
        Me.MaterialExpansionPanel2.ExpandHeight = 200
        Me.MaterialExpansionPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialExpansionPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialExpansionPanel2.Location = New System.Drawing.Point(14, 161)
        Me.MaterialExpansionPanel2.Margin = New System.Windows.Forms.Padding(16, 1, 16, 0)
        Me.MaterialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialExpansionPanel2.Name = "MaterialExpansionPanel2"
        Me.MaterialExpansionPanel2.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.MaterialExpansionPanel2.Size = New System.Drawing.Size(372, 48)
        Me.MaterialExpansionPanel2.TabIndex = 2
        Me.MaterialExpansionPanel2.ValidationButtonEnable = True
        '
        'txtBackupLocation
        '
        Me.txtBackupLocation.AnimateReadOnly = False
        Me.txtBackupLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtBackupLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBackupLocation.Depth = 0
        Me.txtBackupLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBackupLocation.HideSelection = True
        Me.txtBackupLocation.Hint = "Backup Location"
        Me.txtBackupLocation.LeadingIcon = Nothing
        Me.txtBackupLocation.Location = New System.Drawing.Point(27, 67)
        Me.txtBackupLocation.MaxLength = 32767
        Me.txtBackupLocation.MouseState = MaterialSkin.MouseState.OUT
        Me.txtBackupLocation.Name = "txtBackupLocation"
        Me.txtBackupLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBackupLocation.PrefixSuffixText = Nothing
        Me.txtBackupLocation.ReadOnly = False
        Me.txtBackupLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBackupLocation.SelectedText = ""
        Me.txtBackupLocation.SelectionLength = 0
        Me.txtBackupLocation.SelectionStart = 0
        Me.txtBackupLocation.ShortcutsEnabled = True
        Me.txtBackupLocation.Size = New System.Drawing.Size(301, 48)
        Me.txtBackupLocation.TabIndex = 2
        Me.txtBackupLocation.TabStop = False
        Me.txtBackupLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBackupLocation.TrailingIcon = Nothing
        Me.txtBackupLocation.UseSystemPasswordChar = False
        '
        'pnlDBsetting
        '
        Me.pnlDBsetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDBsetting.Collapse = True
        Me.pnlDBsetting.Controls.Add(Me.txtDBPassword)
        Me.pnlDBsetting.Controls.Add(Me.txtDBname)
        Me.pnlDBsetting.Controls.Add(Me.txtDBUsername)
        Me.pnlDBsetting.Controls.Add(Me.txtServer)
        Me.pnlDBsetting.Depth = 0
        Me.pnlDBsetting.ExpandHeight = 341
        Me.pnlDBsetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.pnlDBsetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlDBsetting.Location = New System.Drawing.Point(14, 162)
        Me.pnlDBsetting.Margin = New System.Windows.Forms.Padding(16, 1, 16, 0)
        Me.pnlDBsetting.MouseState = MaterialSkin.MouseState.HOVER
        Me.pnlDBsetting.Name = "pnlDBsetting"
        Me.pnlDBsetting.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.pnlDBsetting.Size = New System.Drawing.Size(372, 48)
        Me.pnlDBsetting.TabIndex = 4
        Me.pnlDBsetting.ValidationButtonEnable = True
        '
        'txtDBPassword
        '
        Me.txtDBPassword.AnimateReadOnly = False
        Me.txtDBPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtDBPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDBPassword.Depth = 0
        Me.txtDBPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDBPassword.HideSelection = True
        Me.txtDBPassword.Hint = "Database Password"
        Me.txtDBPassword.LeadingIcon = Nothing
        Me.txtDBPassword.Location = New System.Drawing.Point(24, 229)
        Me.txtDBPassword.MaxLength = 32767
        Me.txtDBPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDBPassword.Name = "txtDBPassword"
        Me.txtDBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDBPassword.PrefixSuffixText = Nothing
        Me.txtDBPassword.ReadOnly = False
        Me.txtDBPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDBPassword.SelectedText = ""
        Me.txtDBPassword.SelectionLength = 0
        Me.txtDBPassword.SelectionStart = 0
        Me.txtDBPassword.ShortcutsEnabled = True
        Me.txtDBPassword.Size = New System.Drawing.Size(321, 48)
        Me.txtDBPassword.TabIndex = 2
        Me.txtDBPassword.TabStop = False
        Me.txtDBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDBPassword.TrailingIcon = Nothing
        Me.txtDBPassword.UseSystemPasswordChar = False
        '
        'txtDBname
        '
        Me.txtDBname.AnimateReadOnly = False
        Me.txtDBname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtDBname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDBname.Depth = 0
        Me.txtDBname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDBname.HideSelection = True
        Me.txtDBname.Hint = "Database Name"
        Me.txtDBname.LeadingIcon = Nothing
        Me.txtDBname.Location = New System.Drawing.Point(24, 121)
        Me.txtDBname.MaxLength = 32767
        Me.txtDBname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDBname.Name = "txtDBname"
        Me.txtDBname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDBname.PrefixSuffixText = Nothing
        Me.txtDBname.ReadOnly = False
        Me.txtDBname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDBname.SelectedText = ""
        Me.txtDBname.SelectionLength = 0
        Me.txtDBname.SelectionStart = 0
        Me.txtDBname.ShortcutsEnabled = True
        Me.txtDBname.Size = New System.Drawing.Size(321, 48)
        Me.txtDBname.TabIndex = 2
        Me.txtDBname.TabStop = False
        Me.txtDBname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDBname.TrailingIcon = Nothing
        Me.txtDBname.UseSystemPasswordChar = False
        '
        'txtDBUsername
        '
        Me.txtDBUsername.AnimateReadOnly = False
        Me.txtDBUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtDBUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDBUsername.Depth = 0
        Me.txtDBUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDBUsername.HideSelection = True
        Me.txtDBUsername.Hint = "Database Username"
        Me.txtDBUsername.LeadingIcon = Nothing
        Me.txtDBUsername.Location = New System.Drawing.Point(24, 175)
        Me.txtDBUsername.MaxLength = 32767
        Me.txtDBUsername.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDBUsername.Name = "txtDBUsername"
        Me.txtDBUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDBUsername.PrefixSuffixText = Nothing
        Me.txtDBUsername.ReadOnly = False
        Me.txtDBUsername.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDBUsername.SelectedText = ""
        Me.txtDBUsername.SelectionLength = 0
        Me.txtDBUsername.SelectionStart = 0
        Me.txtDBUsername.ShortcutsEnabled = True
        Me.txtDBUsername.Size = New System.Drawing.Size(321, 48)
        Me.txtDBUsername.TabIndex = 2
        Me.txtDBUsername.TabStop = False
        Me.txtDBUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDBUsername.TrailingIcon = Nothing
        Me.txtDBUsername.UseSystemPasswordChar = False
        '
        'txtServer
        '
        Me.txtServer.AnimateReadOnly = False
        Me.txtServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtServer.Depth = 0
        Me.txtServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtServer.HideSelection = True
        Me.txtServer.Hint = "Server"
        Me.txtServer.LeadingIcon = Nothing
        Me.txtServer.Location = New System.Drawing.Point(24, 67)
        Me.txtServer.MaxLength = 32767
        Me.txtServer.MouseState = MaterialSkin.MouseState.OUT
        Me.txtServer.Name = "txtServer"
        Me.txtServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServer.PrefixSuffixText = Nothing
        Me.txtServer.ReadOnly = False
        Me.txtServer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtServer.SelectedText = ""
        Me.txtServer.SelectionLength = 0
        Me.txtServer.SelectionStart = 0
        Me.txtServer.ShortcutsEnabled = True
        Me.txtServer.Size = New System.Drawing.Size(321, 48)
        Me.txtServer.TabIndex = 2
        Me.txtServer.TabStop = False
        Me.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtServer.TrailingIcon = Nothing
        Me.txtServer.UseSystemPasswordChar = False
        '
        'aboutTab
        '
        Me.aboutTab.Controls.Add(Me.MaterialCard2)
        Me.aboutTab.ImageKey = "icons8-about-96.png"
        Me.aboutTab.Location = New System.Drawing.Point(4, 31)
        Me.aboutTab.Name = "aboutTab"
        Me.aboutTab.Size = New System.Drawing.Size(1175, 557)
        Me.aboutTab.TabIndex = 5
        Me.aboutTab.Text = "About"
        Me.aboutTab.UseVisualStyleBackColor = True
        '
        'MaterialCard2
        '
        Me.MaterialCard2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.PictureBox2)
        Me.MaterialCard2.Controls.Add(Me.MaterialLabel3)
        Me.MaterialCard2.Controls.Add(Me.MaterialLabel2)
        Me.MaterialCard2.Controls.Add(Me.btnGmail)
        Me.MaterialCard2.Controls.Add(Me.btnYoutube)
        Me.MaterialCard2.Controls.Add(Me.btnFaceBook)
        Me.MaterialCard2.Controls.Add(Me.PictureBox1)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(294, 52)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(598, 451)
        Me.MaterialCard2.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.AMS.My.Resources.Resources._1335_qr_code_lineal
        Me.PictureBox2.Location = New System.Drawing.Point(63, 14)
        Me.PictureBox2.MaximumSize = New System.Drawing.Size(96, 96)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(96, 96)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel3.HighEmphasis = True
        Me.MaterialLabel3.Location = New System.Drawing.Point(168, 14)
        Me.MaterialLabel3.MaximumSize = New System.Drawing.Size(347, 97)
        Me.MaterialLabel3.MinimumSize = New System.Drawing.Size(347, 97)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(347, 97)
        Me.MaterialLabel3.TabIndex = 8
        Me.MaterialLabel3.Text = "QR ATTENDANCE AND SMS NOTIFCATION"
        Me.MaterialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialLabel3.UseAccent = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(63, 117)
        Me.MaterialLabel2.MaximumSize = New System.Drawing.Size(485, 274)
        Me.MaterialLabel2.MinimumSize = New System.Drawing.Size(485, 274)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(485, 274)
        Me.MaterialLabel2.TabIndex = 10
        Me.MaterialLabel2.Text = resources.GetString("MaterialLabel2.Text")
        '
        'btnGmail
        '
        Me.btnGmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnGmail.Depth = 0
        Me.btnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGmail.HighEmphasis = False
        Me.btnGmail.Icon = Global.AMS.My.Resources.Resources.icons8_google_48
        Me.btnGmail.Location = New System.Drawing.Point(332, 396)
        Me.btnGmail.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGmail.Name = "btnGmail"
        Me.btnGmail.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnGmail.Size = New System.Drawing.Size(94, 36)
        Me.btnGmail.TabIndex = 11
        Me.btnGmail.Text = "GMAIL"
        Me.btnGmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnGmail.UseAccentColor = False
        Me.btnGmail.UseVisualStyleBackColor = True
        '
        'btnYoutube
        '
        Me.btnYoutube.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnYoutube.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnYoutube.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnYoutube.Depth = 0
        Me.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYoutube.HighEmphasis = False
        Me.btnYoutube.Icon = Global.AMS.My.Resources.Resources.icons8_youtube_48
        Me.btnYoutube.Location = New System.Drawing.Point(205, 396)
        Me.btnYoutube.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnYoutube.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnYoutube.Name = "btnYoutube"
        Me.btnYoutube.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnYoutube.Size = New System.Drawing.Size(114, 36)
        Me.btnYoutube.TabIndex = 12
        Me.btnYoutube.Text = "YOUTUBE"
        Me.btnYoutube.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnYoutube.UseAccentColor = False
        Me.btnYoutube.UseVisualStyleBackColor = True
        '
        'btnFaceBook
        '
        Me.btnFaceBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFaceBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFaceBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnFaceBook.Depth = 0
        Me.btnFaceBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFaceBook.HighEmphasis = False
        Me.btnFaceBook.Icon = Global.AMS.My.Resources.Resources.icons8_facebook_48
        Me.btnFaceBook.Location = New System.Drawing.Point(68, 396)
        Me.btnFaceBook.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnFaceBook.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFaceBook.Name = "btnFaceBook"
        Me.btnFaceBook.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnFaceBook.Size = New System.Drawing.Size(124, 36)
        Me.btnFaceBook.TabIndex = 13
        Me.btnFaceBook.Text = "FACEBOOK"
        Me.btnFaceBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnFaceBook.UseAccentColor = False
        Me.btnFaceBook.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.AMS.My.Resources.Resources.icons8_qr_code_96
        Me.PictureBox1.Location = New System.Drawing.Point(63, 14)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(96, 96)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(96, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-about-96.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-emergency-exit-96.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-home-page-96.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-qr-code-96.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-schedule-96.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8-settings-96.png")
        Me.ImageList1.Images.SetKeyName(6, "icons8-user-96.png")
        Me.ImageList1.Images.SetKeyName(7, "icons8-moleskine-96.png")
        Me.ImageList1.Images.SetKeyName(8, "icons8-envelope-96.png")
        Me.ImageList1.Images.SetKeyName(9, "icons8-graph-report-96.png")
        '
        'eventTimer
        '
        Me.eventTimer.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'dashboard
        '
        Me.ClientSize = New System.Drawing.Size(1189, 659)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1150, 610)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.homeTab.ResumeLayout(False)
        Me.MaterialCard9.ResumeLayout(False)
        CType(Me.chartLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard6.ResumeLayout(False)
        CType(Me.chartEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard8.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard7.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard5.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.chartStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentsTab.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.eventTab.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.BunifuDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.attendanceTab.ResumeLayout(False)
        Me.attendanceTab.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.pbStudImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.BunifuDataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.SMSTab.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.BunifuDataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ReportsTab.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.dgwRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.settingsTab.ResumeLayout(False)
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        Me.MaterialCard10.ResumeLayout(False)
        Me.MaterialCard10.PerformLayout()
        Me.panelChangePassword.ResumeLayout(False)
        Me.panelChangePassword.PerformLayout()
        Me.MaterialExpansionPanel2.ResumeLayout(False)
        Me.MaterialExpansionPanel2.PerformLayout()
        Me.pnlDBsetting.ResumeLayout(False)
        Me.pnlDBsetting.PerformLayout()
        Me.aboutTab.ResumeLayout(False)
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents homeTab As TabPage
    Friend WithEvents eventTab As TabPage
    Friend WithEvents attendanceTab As TabPage
    Friend WithEvents studentsTab As TabPage
    Friend WithEvents settingsTab As TabPage
    Friend WithEvents aboutTab As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnEditStudent As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddStudent As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents lblcountrec As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearchStudent As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuDataGridView2 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSearchEvent As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnEditEvent As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddEvent As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblcounteventrec As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents eventTimer As Timer
    Friend WithEvents cmbEventList As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BunifuDataGridView3 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAttendeesCount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents eventSwitch As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents btnScan As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnGmail As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnYoutube As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnFaceBook As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents chartStudents As DataVisualization.Charting.Chart
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTotalStudents As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents SMSTab As TabPage
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btnRestore As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnBackup As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents chartEvents As DataVisualization.Charting.Chart
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotalEvents As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard9 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents chartLogs As DataVisualization.Charting.Chart
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotalLogs As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BunifuDataGridView4 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblcountsms As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtsearchsms As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents panelChangePassword As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents txtconfirmpassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtnewpassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtoldpassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard10 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnImportMultipleStud As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ScannedTextbox As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialExpansionPanel2 As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents btnManageUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ReportsTab As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblCountRpt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgwRpt As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents btnReport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmbReportFilter As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbReportType As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPrint As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtBackupLocation As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btnServerSetting As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pnlDBsetting As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents txtDBname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtServer As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtDBPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtDBUsername As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnDeleteMultiple As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbStudImg As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtlname As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtgrade As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtMname As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtfname As MaterialSkin.Controls.MaterialLabel
End Class
