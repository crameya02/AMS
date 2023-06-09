Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports USB_Barcode_Scanner
Imports System.ComponentModel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Buffers
Imports System.Data.SqlClient

Public Class dashboard
    WithEvents barcodeScanner As BarcodeScanner
    Public Sub Initial_State()
        btnAddStudent.Enabled = True
        btnEditStudent.Enabled = False
        btnAddEvent.Enabled = True
        btnEditEvent.Enabled = False
        cmbEventList.Enabled = False
        Me.DrawerIsOpen = False
        Me.DrawerUseColors = False
    End Sub
    Private Sub selectModemForSMS()
        Try
            Dim rst = findComDevice("USB-SERIAL CH340")
            'MsgBox(rst.ToString)
            With SerialPort1
                '.PortName = portname() ' for globe broadband
                '.PortName = "COM3" 'manual
                .PortName = rst.ToString
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With
            If SerialPort1.IsOpen Then
                ' ToolStripStatusLabel1.Text = "Connected to : " & portname()
                ToolStripStatusLabel1.Text = "Connected to : " & rst.ToString
            Else
                ToolStripStatusLabel1.Text = "Error connecting to modem"
            End If
        Catch ex As Exception
            ToolStripStatusLabel1.Text = ErrorToString()
        End Try
    End Sub
    Private Sub loadStudentChart()
        Try
            If (ClsConn.OpenConnection() = True) Then

                With chartStudents
                    .DataSource = ClsConn.LoadData("SELECT course,COUNT(idparticipant) as students FROM participants GROUP BY course")
                    .Legends.Clear()
                    .ChartAreas.Clear()
                    .ChartAreas.Add(New ChartArea("Students"))


                    With .ChartAreas("Students")

                        'Play with this to get the effect you want
                        '.AxisX.LabelStyle.Interval = 1
                        '.AxisY.LabelStyle.Interval = 5
                        .AxisX.LabelStyle.ForeColor = Color.Green
                        .AxisY.LabelStyle.ForeColor = Color.Green
                        .AxisY.Title = "Number of Students"
                        .AxisX.Title = "Grade"
                        .AxisX.TitleFont = New Font("arial", 12)
                        .AxisY.TitleFont = New Font("arial", 12)
                        .AxisX.TitleForeColor = Color.Green
                        .AxisY.TitleForeColor = Color.Green
                        .AxisX.MajorGrid.Enabled = False
                        .AxisY.MajorGrid.LineColor = Color.Green
                        .AxisY.LineColor = Color.Green
                        .AxisX.LineColor = Color.Green
                        .BackColor = Color.Transparent

                    End With
                    .Series.Clear()
                    .Series.Add(New Series("Students"))
                    With .Series("Students")
                        .ChartArea = "Students"
                        .ChartType = SeriesChartType.Column
                        .XValueType = ChartValueType.String
                        .YValueType = ChartValueType.Int64
                        .XValueMember = "course"
                        .YValueMembers = "students"
                        .IsVisibleInLegend = True
                        .IsValueShownAsLabel = True
                        .LabelForeColor = Color.Green
                        .Color = Color.LightGreen
                    End With
                End With
            End If

            lblTotalStudents.Text = ClsConn.CountRec("SELECT COUNT(idparticipant) as students FROM participants")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ClsConn.CloseConnection()
        End Try
    End Sub
    Private Sub chartEvents_CustomizeLegend(sender As Object, e As CustomizeLegendEventArgs) Handles chartEvents.CustomizeLegend, chartLogs.CustomizeLegend
        Dim xValues As String() = {"Ongoing", "Completed"}

        For i As Integer = 0 To e.LegendItems.Count - 1
            e.LegendItems(i).Cells(1).Text = xValues(i)
        Next

    End Sub


    Private Sub loadEventChart()
        Try

            If (ClsConn.OpenConnection() = True) Then
                With chartEvents
                    .DataSource = ClsConn.LoadData("SELECT event,status,COUNT(id) as id FROM events GROUP BY status")
                    .Legends.Clear()
                    .Legends.Add("")
                    .ChartAreas.Clear()
                    .ChartAreas.Add(New ChartArea("Events"))


                    With .ChartAreas("Events")
                        '.AxisX.LabelStyle.ForeColor = Color.White
                        '.AxisY.LabelStyle.ForeColor = Color.White
                        ''.AxisY.Title = "Number of Students"
                        ''.AxisX.Title = "Course"
                        '.AxisX.TitleFont = New Font("arial", 12)
                        '.AxisY.TitleFont = New Font("arial", 12)
                        '.AxisX.TitleForeColor = Color.White
                        '.AxisY.TitleForeColor = Color.White
                        '.AxisX.MajorGrid.Enabled = False
                        '.AxisY.MajorGrid.LineColor = Color.White
                        '.AxisY.LineColor = Color.White
                        '.AxisX.LineColor = Color.White
                        .BackColor = Color.Transparent

                    End With
                    .Series.Clear()
                    .Series.Add(New Series("Events"))
                    With .Series("Events")
                        .ChartArea = "Events"
                        .ChartType = SeriesChartType.Pie
                        .XValueType = ChartValueType.String
                        .YValueType = ChartValueType.Int64
                        ' .XValueMember = "status"
                        .YValueMembers = "id"

                        .IsVisibleInLegend = True
                        .IsValueShownAsLabel = True
                        .LabelForeColor = Color.Green

                    End With


                End With
            End If

            lblTotalEvents.Text = ClsConn.CountRec("SELECT COUNT(id) as id FROM events")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ClsConn.CloseConnection()
        End Try

    End Sub

    Private Sub loadLogsChart()
        Try
            If (ClsConn.OpenConnection() = True) Then

                With chartLogs
                    .DataSource = ClsConn.LoadData("SELECT  events.event as Events, COUNT(DISTINCT(participantid)) as NumOfloggedStudents FROM attendance INNER JOIN events ON attendance.event_id=events.id where date(logdatetime)=CURRENT_DATE and events.status =  0 GROUP BY events.event order by event_id asc")
                    .Legends.Clear()
                    .ChartAreas.Clear()
                    .ChartAreas.Add(New ChartArea("Logs"))


                    With .ChartAreas("Logs")

                        'Play with this to get the effect you want
                        '.AxisX.LabelStyle.Interval = 1
                        '.AxisY.LabelStyle.Interval = 5
                        .AxisX.LabelStyle.ForeColor = Color.Green
                        .AxisY.LabelStyle.ForeColor = Color.Green
                        .AxisY.Title = "Logged Students"
                        .AxisX.Title = "Events"
                        .AxisX.TitleFont = New Font("arial", 12)
                        .AxisY.TitleFont = New Font("arial", 12)
                        .AxisX.TitleForeColor = Color.Green
                        .AxisY.TitleForeColor = Color.Green
                        .AxisX.MajorGrid.Enabled = False
                        .AxisY.MajorGrid.LineColor = Color.Green
                        .AxisY.LineColor = Color.Green
                        .AxisX.LineColor = Color.Green
                        .BackColor = Color.Transparent

                    End With
                    .Series.Clear()
                    .Series.Add(New Series("Logs"))
                    With .Series("Logs")
                        .ChartArea = "Logs"
                        .ChartType = SeriesChartType.Line
                        .XValueType = ChartValueType.String
                        .YValueType = ChartValueType.Int64
                        .XValueMember = "Events"
                        .YValueMembers = "NumOfloggedStudents"
                        .IsVisibleInLegend = True
                        .IsValueShownAsLabel = True
                        .LabelForeColor = Color.Green
                        .Color = Color.LightGreen
                    End With
                End With
            End If

            lblTotalLogs.Text = ClsConn.CountRec("select COUNT(TotalLog) TotalLogs from
(
SELECT  COUNT(*) TotalLog, attendance.*  FROM `attendance`  where date(logdatetime)=CURRENT_DATE GROUP by participantid,event_id) src
")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ClsConn.CloseConnection()
        End Try
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MaterialTabControl1.SelectedIndex = 3 Then
            ScannedTextbox.SelectAll()
            ScannedTextbox.Focus()
            Timer1.Enabled = False

        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCustomSkin.myCustomSkin()
        Dim manageUser As New ClsLogin
        With manageUser
            .username = login.txtUserName.Text
            .password = login.txtPassword.Text
            .USER_LOOKUP()

            If .userRole = "True" Then

            Else

                MaterialTabControl1.TabPages(1).Enabled = False
                MaterialTabControl1.TabPages(2).Enabled = False
                MaterialTabControl1.TabPages(4).Enabled = False
                MaterialCard3.Enabled = False
                MaterialExpansionPanel2.Enabled = False
                MaterialCard4.Enabled = False
                pnlDBsetting.Enabled = False
                MaterialTabControl1.SelectTab(3)

                ' MsgBox(ActiveControl.Name)


            End If

            ShowRegistration()
            ShowEventList()
            ShowEvents()

            Initial_State()
            eventTimer.Enabled = True
            selectModemForSMS()
            loadStudentChart()
            loadEventChart()
            loadLogsChart()

            addButtonsToDGV()
            barcodeScanner = New BarcodeScanner(ScannedTextbox)
            Timer1.Enabled = True

        End With


    End Sub
    Dim resourcePath As String = My.Application.Info.DirectoryPath.ToString
    Public Sub addButtonsToDGV()
        Dim viewimg As New DataGridViewImageColumn()
        Dim inImgview As Image = Image.FromFile(resourcePath & "\dgwbuttons\icons8-eye-24.png")
        viewimg.Image = inImgview
        BunifuDataGridView1.Columns.Add(viewimg)
        viewimg.HeaderText = ""
        viewimg.Name = "viewimg"
        viewimg.Width = 50

        Dim editimg As New DataGridViewImageColumn()
        Dim inImgedit As Image = Image.FromFile(resourcePath & "\dgwbuttons\icons8-edit-24.png")
        editimg.Image = inImgedit
        BunifuDataGridView1.Columns.Add(editimg)
        editimg.HeaderText = ""
        editimg.Name = "editimg"
        editimg.Width = 50

        Dim deleteimg As New DataGridViewImageColumn()
        Dim inImgdelete As Image = Image.FromFile(resourcePath & "\dgwbuttons\icons8-trash-24.png")
        deleteimg.Image = inImgdelete
        BunifuDataGridView1.Columns.Add(deleteimg)
        deleteimg.HeaderText = ""
        deleteimg.Name = "deleteimg"
        deleteimg.Width = 50
    End Sub
    Dim decode As String
    Private Sub barcodeScanner_BarcodeScanned(sender As Object, e As BarcodeScannerEventArgs) Handles barcodeScanner.BarcodeScanned
        Try


            'decode = ScannedTextbox.Text
            ' MsgBox(decode)

            If e.Barcode <> "" Then
                ScannedTextbox.SelectAll()
                ScannedTextbox.Select()
                ScannedTextbox.Text = e.Barcode
                Dim attendance As New ClsAttendance
                With attendance
                    .participantid = ScannedTextbox.Text
                    .checkifcourseisacceptedinevent()
                    'CountAttendance()
                    'MsgBox("Event ID: " + dashboard.cmbEventList.SelectedValue.ToString)
                    ScannedTextbox.Clear()
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub serialport1_datareceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = ""
        Dim numbytes As Integer = SerialPort1.BytesToRead
        For i As Integer = 1 To numbytes
            datain &= Chr(SerialPort1.ReadChar)
        Next
        messagedata(datain)
    End Sub
    Private Sub Backup()
        ' download nuget https://github.com/MySqlBackupNET/MySqlBackup.Net/wiki/How-to-Add-This-Library-into-Your-Project
        If (ClsConn.OpenConnection() = True) Then

            Dim cmd1 As MySqlCommand = New MySqlCommand
            cmd1.Connection = sqlCon

            Dim mb As MySqlBackup = New MySqlBackup(cmd1)
            Dim defaultAppPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Setting")

            Dim backUpPath As String = defaultAppPath
            Dim mySettings As String = backUpPath & "\Settings.ini"
            Dim objIniFile As New ClsIni(mySettings)
            If (Not System.IO.Directory.Exists(backUpPath)) Then
                System.IO.Directory.CreateDirectory(backUpPath)
            End If
            If Not System.IO.File.Exists(mySettings) Then
                System.IO.File.Create(mySettings).Dispose()
            End If
            Dim readbackUpPath As String = objIniFile.GetString("Backup", "Location", "")
            If readbackUpPath = "" Then
                objIniFile.WriteString("Backup", "Location", "C:\backup\ams\")
                readbackUpPath = objIniFile.GetString("Backup", "Location", "")
            End If


            mb.ExportToFile(readbackUpPath + "conferencedb_backup_" + Now.ToString("yyyy-MM-dd HH-mm-ss tt") + ".sql")
            Dim SnackBarMessage As MaterialSnackBar = New MaterialSnackBar("Backup successfully created.", 750)
            SnackBarMessage.Show(Me)
            ClsConn.CloseConnection()
        End If
    End Sub
    Private Sub dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Do you really want to quit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If MessageBox.Show("Do you want backup database before logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Backup()

                    End

                    Application.Exit()
                Else
                    End

                    Application.Exit()
                End If
            Else
                e.Cancel = True
            End If
            If MaterialTabControl1.SelectedIndex = 8 Then

                e.Cancel = True
                MaterialTabControl1.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MaterialTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialTabControl1.SelectedIndexChanged
        If MaterialTabControl1.SelectedIndex = 0 Then
            loadStudentChart()
            loadEventChart()
            loadLogsChart()
            Me.Text = "Home"
        End If
        If MaterialTabControl1.SelectedIndex = 1 Then
            ShowRegistration()
            Me.Text = "Students"
        End If

        If MaterialTabControl1.SelectedIndex = 8 Then

            Me.Close()
        End If
        If MaterialTabControl1.SelectedIndex = 2 Then
            ShowEventList()
            ' ShowAttendance(1)
            Me.Text = "Events"
        End If
        If MaterialTabControl1.SelectedIndex = 3 Then
            ScannedTextbox.SelectAll()
            ScannedTextbox.Focus()
            ShowAttendance(1)
            Me.Text = "Logs"
        End If
        If MaterialTabControl1.SelectedIndex = 4 Then
            ShowSMSLogs()
            Me.Text = "SMS"
        End If
        If MaterialTabControl1.SelectedIndex = 5 Then
            Me.Text = "Reports"
        End If
        If MaterialTabControl1.SelectedIndex = 6 Then
            Me.Text = "Settings"
            Dim defaultAppPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Setting")

            Dim backUpPath As String = defaultAppPath
            Dim mySettings As String = backUpPath & "\Settings.ini"
            Dim objIniFile As New ClsIni(mySettings)
            If (Not System.IO.Directory.Exists(backUpPath)) Then
                System.IO.Directory.CreateDirectory(backUpPath)
            End If
            If Not System.IO.File.Exists(mySettings) Then
                System.IO.File.Create(mySettings).Dispose()
            End If
            Dim readbackUpPath As String = objIniFile.GetString("Backup", "Location", "")
            If readbackUpPath = "" Then
                objIniFile.WriteString("Backup", "Location", "C:\backup\ams\")
                readbackUpPath = objIniFile.GetString("Backup", "Location", "")
            Else
                txtBackupLocation.Text = readbackUpPath
            End If
            Dim readServer As String = objIniFile.GetString("Database", "server", "")
            Dim readDBName As String = objIniFile.GetString("Database", "name", "")
            Dim readUsername As String = objIniFile.GetString("Database", "username", "")
            Dim readPassword As String = objIniFile.GetString("Database", "password", "")
            If readServer = "" Or readDBName = "" Or readUsername = "" Then
                objIniFile.WriteString("Database", "server", "localhost")
                objIniFile.WriteString("Database", "name", "conferencedb")
                objIniFile.WriteString("Database", "username", "root")
                objIniFile.WriteString("Database", "password", "")
                readServer = objIniFile.GetString("Database", "server", "")
                readDBName = objIniFile.GetString("Database", "name", "")
                readUsername = objIniFile.GetString("Database", "username", "")
                readPassword = objIniFile.GetString("Database", "password", "")
            Else
                txtServer.Text = readServer
                txtDBname.Text = readDBName
                txtDBUsername.Text = readUsername
                txtDBPassword.Text = Decrypt(readPassword)
            End If

        End If
        If MaterialTabControl1.SelectedIndex = 7 Then
            Me.Text = "About"
        End If
    End Sub

    Public Sub ShowRegistration()
        'For Each version As String() In ClsConn.LoadData("SELECT idparticipant as PARTICIPANTID, LASTNAME, FIRSTNAME, MIDDLENAME, CONTACTNO, date_format(REG_AT,'%b %d %Y %h:%i') AS `DATE REGISTERED` FROM conferencedb.participants order by reg_at desc").DefaultView
        '    Dim item = New ListViewItem(version)
        '    MaterialListView1.Items.Add(item)
        'Next
        BunifuDataGridView1.DataSource = ClsConn.LoadData("SELECT idparticipant as ID, LASTNAME as Last_Name, FIRSTNAME as First_Name, MIDDLENAME as Middle_Name, COURSE as Grade,GUARDIAN as Guardian_Name, CONTACTNO as Contact_No, date_format(REG_AT,'%b-%d-%Y %h:%i %p') AS `DATE REGISTERED` FROM conferencedb.participants order by reg_at desc").DefaultView

        lblcountrec.Text = "Records: "
        lblcountrec.Text = lblcountrec.Text + BunifuDataGridView1.Rows.Count().ToString()
    End Sub
    Public Sub ShowEvents()
        BunifuDataGridView2.DataSource = ClsConn.LoadData("SELECT id as ID, event as Event,event_for as Grade, description as Description, venue as venue, date_format(event_datetime_start,'%b-%d-%Y %h:%i %p') AS `Start`,  date_format(event_datetime_end,'%b-%d-%Y %h:%i %p') AS `End`, status as Status, date_format(date_created,'%b-%d-%Y %h:%i %p') AS `Date Created` FROM conferencedb.events order by date_created desc").DefaultView
        lblcounteventrec.Text = "Records: "
        lblcounteventrec.Text = lblcounteventrec.Text + BunifuDataGridView2.Rows.Count().ToString()
    End Sub
    Public Sub ShowEventList()
        cmbEventList.DataSource = ClsConn.LoadData("SELECT id , event FROM conferencedb.events where status=0 order by id asc").DefaultView
        cmbEventList.ValueMember = "id"
        cmbEventList.DisplayMember = "event"
    End Sub
    Public Sub ShowAttendance(ByVal cmbindex As String)
        ' BunifuDataGridView3.DataSource = ClsConn.LoadData("SELECT attendance.idattendance as ID, participantid as Student_ID,event_id as Event_ID,  date_format(logdatetime,'%b-%d-%Y %h:%i %p') AS `Log` FROM conferencedb.attendance order by logdatetime desc").DefaultView
        'BunifuDataGridView3.DataSource = ClsConn.LoadData(" SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event,  date_format(logdatetime,'%b-%d-%Y %h:%i %p') AS `Log` FROM conferencedb.attendance, conferencedb.participants, conferencedb.events where participants.idparticipant = attendance.participantid and attendance.event_id = events.id order by logdatetime desc").DefaultView
        'BunifuDataGridView3.DataSource = ClsConn.LoadData("SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event,  date_format(logdatetime,'%b-%d-%Y %h:%i %p') AS `Log` FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN  conferencedb.events  on attendance.event_id = events.id) where attendance.event_id = " & cmbindex & " order by logdatetime desc ").DefaultView

        'Case WHEN MAX(CASE WHEN enddate Is NULL THEN 1 ELSE 0 END) = 0
        'THEN MAX(enddate)


        'BunifuDataGridView3.DataSource = ClsConn.LoadData("SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event, date_format(logdatetime,'%b-%d-%Y') AS Day, Min(date_format(logdatetime, '%h:%i %p')) AS CheckIn, (CASE WHEN Max(date_format(logdatetime,'%h:%i %p')) = Min(date_format(logdatetime, '%h:%i %p')) THEN Max(date_format(logdatetime,'%h:%i %p')) = ' ' ELSE Max(date_format(logdatetime,'%h:%i %p')) END ) AS CheckOut FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN conferencedb.events on attendance.event_id = events.id) where attendance.event_id = attendance.event_id GROUP by attendance.participantid  order by logdatetime desc LIMIT 2")

        'BunifuDataGridView3.DataSource = ClsConn.LoadData("SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event, date_format(logdatetime,'%b-%d-%Y') AS Day, date_format(timein, '%h:%i %p') AS TimeIN,  date_format(timeout, '%h:%i %p')AS TimeOut FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN conferencedb.events on attendance.event_id = events.id) where attendance.event_id =  " & cmbindex & " order by logdatetime desc")
        BunifuDataGridView3.DataSource = ClsConn.LoadData("SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event, date_format(logdatetime,'%b-%d-%Y') AS Day, date_format(timein, '%h:%i %p') AS TimeIN,  date_format(timeout, '%h:%i %p')AS TimeOut FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN conferencedb.events on attendance.event_id = events.id) where attendance.event_id =  " & cmbindex & "  and  date_format(logdatetime,'%Y-%m-%d') = CURDATE() order by logdatetime desc")
        lblAttendeesCount.Text = "Records: "
        lblAttendeesCount.Text = lblAttendeesCount.Text + BunifuDataGridView3.Rows.Count().ToString()
        BunifuDataGridView3.Columns(0).Visible = False
    End Sub
    Public Sub ShowSMSLogs()
        BunifuDataGridView4.DataSource = ClsConn.LoadData("SELECT smsID as ID, sender as Sender,message as Message, receiver as Recipient, status as Status, date_format(datesent,'%b-%d-%Y %h:%i %p') AS `Date and Time` FROM conferencedb.smslog order by datesent desc").DefaultView
        lblcountsms.Text = "Records: "
        lblcountsms.Text = lblcountsms.Text + BunifuDataGridView4.Rows.Count().ToString()
    End Sub

    Private Sub BunifuDataGridView1_Paint(sender As Object, e As PaintEventArgs) _
    Handles BunifuDataGridView1.Paint
        If BunifuDataGridView1.Rows.Count = 0 Then
            TextRenderer.DrawText(e.Graphics, "No records found.",
            BunifuDataGridView1.Font, BunifuDataGridView1.ClientRectangle,
            BunifuDataGridView1.ForeColor, BunifuDataGridView1.BackgroundColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End If
    End Sub
    Private Sub BunifuDataGridView2_Paint(sender As Object, e As PaintEventArgs) _
    Handles BunifuDataGridView2.Paint
        If BunifuDataGridView2.Rows.Count = 0 Then
            TextRenderer.DrawText(e.Graphics, "No records found.",
            BunifuDataGridView2.Font, BunifuDataGridView2.ClientRectangle,
            BunifuDataGridView2.ForeColor, BunifuDataGridView2.BackgroundColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End If
    End Sub
    Private Sub BunifuDataGridView3_Paint(sender As Object, e As PaintEventArgs) _
    Handles BunifuDataGridView3.Paint
        If BunifuDataGridView3.Rows.Count = 0 Then
            TextRenderer.DrawText(e.Graphics, "No records found.",
            BunifuDataGridView3.Font, BunifuDataGridView3.ClientRectangle,
            BunifuDataGridView3.ForeColor, BunifuDataGridView3.BackgroundColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End If
    End Sub
    Private Sub BunifuDataGridView4_Paint(sender As Object, e As PaintEventArgs) _
    Handles BunifuDataGridView4.Paint
        If BunifuDataGridView4.Rows.Count = 0 Then
            TextRenderer.DrawText(e.Graphics, "No records found.",
            BunifuDataGridView4.Font, BunifuDataGridView4.ClientRectangle,
            BunifuDataGridView4.ForeColor, BunifuDataGridView4.BackgroundColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End If
    End Sub
    Private Sub dgwRpt_Paint(sender As Object, e As PaintEventArgs) _
    Handles dgwRpt.Paint
        If dgwRpt.Rows.Count = 0 Then
            TextRenderer.DrawText(e.Graphics, "No records found.",
            dgwRpt.Font, dgwRpt.ClientRectangle,
            dgwRpt.ForeColor, dgwRpt.BackgroundColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End If
    End Sub
    Private _formOverlay As Form
    Public Sub test(ByVal ParentForm As Form, ByVal Title As String, ByVal Text As String, ByVal ValidationButtonText As String, ByVal ShowCancelButton As Boolean, ByVal CancelButtonText As String, ByVal UseAccentColor As Boolean)
        _formOverlay = New Form With {
        .BackColor = Color.Black,
        .Opacity = 0.5,
        .MinimizeBox = False,
        .MaximizeBox = False,
        .Text = "",
        .ShowIcon = False,
        .ControlBox = False,
        .FormBorderStyle = FormBorderStyle.None,
        .Size = New Size(ParentForm.Width, ParentForm.Height),
        .ShowInTaskbar = False,
        .Owner = ParentForm,
        .Visible = True,
        .Location = New Point(ParentForm.Location.X, ParentForm.Location.Y),
        .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
}
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        mode = Modes.add
        manageStudents.btnSave.Text = "save"
        manageStudents.MaterialLabel1.Text = "Add Student"
        manageStudents.btnSave.Enabled = True
        manageStudents.txtID.Enabled = True
        Me.DrawerIsOpen = True
        Me.DrawerUseColors = True
        manageStudents.ShowDialog()
    End Sub
    Dim SnackBarMessage As New MaterialSkin.Controls.MaterialSnackBar


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        Try
            If (BunifuDataGridView1.Item("ID", BunifuDataGridView1.CurrentRow.Index).Value.ToString() = "") Then
                MsgBox("Choose item to edit.", vbInformation, )
            Else
                Dim tempContact As Long
                mode = Modes.edit
                manageStudents.btnSave.Text = "UPDATE"
                manageStudents.MaterialLabel1.Text = "Edit Student"
                btnEditStudent.Enabled = False
                manageStudents.txtID.Enabled = False
                manageStudents.txtID.Text = BunifuDataGridView1.Item("ID", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
                manageStudents.txtLname.Text = BunifuDataGridView1.Item("Last_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
                manageStudents.txtFname.Text = BunifuDataGridView1.Item("First_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
                manageStudents.txtMname.Text = BunifuDataGridView1.Item("Middle_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
                manageStudents.txtCourse.Text = BunifuDataGridView1.Item("Grade", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
                tempContact = BunifuDataGridView1.Item("Contact_No", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
                manageStudents.txtContact.Text = Format(tempContact, "0000-000-0000")

                manageStudents.txtGuardian.Text = BunifuDataGridView1.Item("Guardian_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
                If (ClsConn.OpenConnection() = True) Then

                    cmd = New MySqlCommand("Select * FROM participants where  idparticipant=@participantid ", sqlCon)
                    cmd.Parameters.AddWithValue("@participantid", BunifuDataGridView1.Item("ID", BunifuDataGridView1.CurrentRow.Index).Value.ToString())



                    '   If cmd.ExecuteScalar <> 0 Then '' this is for integer because scalar accepts double by default
                    If Convert.ToString(cmd.ExecuteScalar()) IsNot Nothing Then
                        rdr = cmd.ExecuteReader()
                        If rdr.Read Then

                            arrImage = rdr(8)
                            Dim mstream As New System.IO.MemoryStream(arrImage)
                            manageStudents.pbImage.Image = Image.FromStream(mstream)
                            'MsgBox(rdr(8).value.ToString)
                        End If


                    End If

                End If

                manageStudents.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        btnEditStudent.Enabled = True
        If e.ColumnIndex = 0 Then
            'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
            viewStudent.txtQrCode.Text = BunifuDataGridView1.Item("ID", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
            viewStudent.txtLName.Text = BunifuDataGridView1.Item("Last_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
            viewStudent.txtFName.Text = BunifuDataGridView1.Item("First_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
            viewStudent.txtMName.Text = BunifuDataGridView1.Item("Middle_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
            viewStudent.txtCourse.Text = BunifuDataGridView1.Item("Grade", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
            viewStudent.txtGuardian.Text = BunifuDataGridView1.Item("Guardian_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
            viewStudent.txtParentNum.Text = BunifuDataGridView1.Item("Contact_No", BunifuDataGridView1.CurrentRow.Index).Value.ToString()
            viewStudent.ShowDialog()

        End If
        If e.ColumnIndex = 1 Then
            btnEditStudent.PerformClick()
        End If
        Try
            If e.ColumnIndex = 2 Then
                Dim deleteStudent As New ClsRegistration
                With deleteStudent
                    Dim studentData As String =
                     BunifuDataGridView1.Item("Last_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString() & ", " &
                    BunifuDataGridView1.Item("First_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString() & " " &
                    BunifuDataGridView1.Item("Middle_Name", BunifuDataGridView1.CurrentRow.Index).Value.ToString() & " of " &
                    BunifuDataGridView1.Item("Grade", BunifuDataGridView1.CurrentRow.Index).Value.ToString()

                    If MessageBox.Show("Do you really want to delete the selected student? : " & studentData, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
                        .delete(BunifuDataGridView1.Item("ID", BunifuDataGridView1.CurrentRow.Index).Value)
                        MsgBox("Successfully deleted student : " & studentData)
                        ShowRegistration()
                    End If
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView2.CellClick
        btnEditEvent.Enabled = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudent.TextChanged
        Dim str As String = String.Format("SELECT idparticipant as ID, LASTNAME as Last_Name, FIRSTNAME as First_Name, MIDDLENAME as Middle_Name, COURSE as Course, GUARDIAN as Guardian_Name, CONTACTNO as Contact_No, date_format(REG_AT,'%b %d %Y %h:%i %p') AS `DATE REGISTERED` FROM conferencedb.participants WHERE lastname like '%{0}%' OR firstname like '%{0}%' order by reg_at desc", txtSearchStudent.Text)
        BunifuDataGridView1.DataSource = ClsConn.LoadData(str).DefaultView
        lblcountrec.Text = "Records: "
        lblcountrec.Text = lblcountrec.Text + BunifuDataGridView1.Rows.Count().ToString()
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        mode = Modes.add
        manageEvents.btnSaveEvent.Text = "save"
        manageEvents.MaterialLabel1.Text = "Add Event"
        manageEvents.btnSaveEvent.Enabled = True
        manageEvents.txtEventID.Enabled = False

        manageEvents.ShowDialog()
    End Sub


    Private Sub btnEditEvent_Click(sender As Object, e As EventArgs) Handles btnEditEvent.Click
        Try
            If (BunifuDataGridView2.Item("ID", BunifuDataGridView2.CurrentRow.Index).Value.ToString() = "") Then
                MsgBox("Choose item to edit.", vbInformation, )
            Else

                'Dim date_start, date_end As String
                'Dim start_time As String = cmbHourStr.Text + ":" + cmbMinutesStr.Text
                'Dim end_time As String = cmbHourEnd.Text + ":" + cmbMinutesEnd.Text
                'date_start = Format(CDate(txtEventStart.Text), "yyyy-MM-dd") + " " + Format(CDate(start_time), "HH:mm:ss")
                'date_end = Format(CDate(txtEventEnd.Text), "yyyy-MM-dd") + " " + Format(CDate(end_time), "HH:mm:ss")


                mode = Modes.edit
                manageEvents.btnSaveEvent.Text = "UPDATE"
                manageEvents.MaterialLabel1.Text = "Edit Event"
                btnEditEvent.Enabled = False
                manageEvents.txtEventID.Enabled = False

                manageEvents.txtEventID.Text = BunifuDataGridView2.Item("ID", BunifuDataGridView2.CurrentRow.Index).Value.ToString()
                manageEvents.txtEventName.Text = BunifuDataGridView2.Item("Event", BunifuDataGridView2.CurrentRow.Index).Value.ToString()
                manageEvents.cmbEventFor.Text = BunifuDataGridView2.Item("Grade", BunifuDataGridView2.CurrentRow.Index).Value.ToString()
                manageEvents.txtEventDescription.Text = BunifuDataGridView2.Item("Description", BunifuDataGridView2.CurrentRow.Index).Value.ToString()
                manageEvents.txtVenue.Text = BunifuDataGridView2.Item("Venue", BunifuDataGridView2.CurrentRow.Index).Value.ToString()

                Dim HR_START As String
                Dim HR_START_ARRAY() As String
                Dim MIN_START_ARRAY() As String
                Dim HR_COUNT As Integer
                Dim MIN_COUNT As Integer
                HR_START = BunifuDataGridView2.Item("Start", BunifuDataGridView2.CurrentRow.Index).Value.ToString()
                HR_START_ARRAY = HR_START.Split(" ")
                For HR_COUNT = 0 To HR_START_ARRAY.Length - 1
                    'MsgBox(strArr(HR_COUNT))
                    ' MsgBox(HR_COUNT)
                    If HR_COUNT = 0 Then
                        manageEvents.txtEventStart.Text = Format(CDate(HR_START_ARRAY(0)), "Long Date")
                    End If
                    If HR_COUNT = 1 Then
                        manageEvents.cmbHourStr.Text = HR_START_ARRAY(1)
                        MIN_START_ARRAY = HR_START_ARRAY(1).Split(":")
                        For MIN_COUNT = 0 To MIN_START_ARRAY.Length - 1
                            If MIN_COUNT = 0 Then
                                manageEvents.cmbHourStr.SelectedIndex = manageEvents.cmbHourStr.FindString(MIN_START_ARRAY(0))
                            End If
                            If MIN_COUNT = 1 Then
                                manageEvents.cmbMinutesStr.SelectedIndex = manageEvents.cmbMinutesStr.FindString(MIN_START_ARRAY(1))
                            End If
                        Next
                    End If
                    If HR_COUNT = 2 Then
                        manageEvents.cmbAMPMStr.SelectedIndex = manageEvents.cmbAMPMStr.FindString(HR_START_ARRAY(2))
                    End If

                Next

                Dim HR_END As String
                Dim HR_END_ARRAY() As String
                Dim MIN_END_ARRAY() As String
                Dim HR_COUNT_END As Integer
                Dim MIN_COUNT_END As Integer
                HR_END = BunifuDataGridView2.Item("End", BunifuDataGridView2.CurrentRow.Index).Value.ToString()
                HR_END_ARRAY = HR_END.Split(" ")
                For HR_COUNT_END = 0 To HR_END_ARRAY.Length - 1
                    'MsgBox(strArr(HR_COUNT))
                    ' MsgBox(HR_COUNT)
                    If HR_COUNT_END = 0 Then
                        manageEvents.txtEventEnd.Text = Format(CDate(HR_END_ARRAY(0)), "Long Date")
                    End If
                    If HR_COUNT_END = 1 Then
                        manageEvents.cmbHourStr.Text = HR_END_ARRAY(1)
                        MIN_END_ARRAY = HR_END_ARRAY(1).Split(":")
                        For MIN_COUNT_END = 0 To MIN_END_ARRAY.Length - 1
                            If MIN_COUNT_END = 0 Then
                                manageEvents.cmbHourEnd.SelectedIndex = manageEvents.cmbHourStr.FindString(MIN_END_ARRAY(0))
                            End If
                            If MIN_COUNT_END = 1 Then
                                manageEvents.cmbMinutesEnd.SelectedIndex = manageEvents.cmbMinutesStr.FindString(MIN_END_ARRAY(1))
                            End If
                        Next
                    End If
                    If HR_COUNT_END = 2 Then
                        manageEvents.cmbAMPMEnd.SelectedIndex = manageEvents.cmbAMPMEnd.FindString(HR_END_ARRAY(2))
                    End If
                Next
                manageEvents.ShowDialog()

            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub txtSearchEvent_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEvent.TextChanged
        Dim str As String = String.Format("SELECT id as ID, event as Event,event_for as Course , description as Description, venue as venue, date_format(event_datetime_start,'%b-%d-%Y %h:%i %p') AS `Start`,  date_format(event_datetime_end,'%b-%d-%Y %h:%i %p') AS `End`, status as Status, date_format(date_created,'%b-%d-%Y %h:%i %p') AS `Date Created` FROM conferencedb.events  WHERE event like '%{0}%' OR venue like '%{0}%' order by date_created desc", txtSearchEvent.Text)
        BunifuDataGridView2.DataSource = ClsConn.LoadData(str).DefaultView
        lblcounteventrec.Text = "Records: "
        lblcounteventrec.Text = lblcounteventrec.Text + BunifuDataGridView2.Rows.Count().ToString()
    End Sub

    Private Sub eventTimer_Tick(sender As Object, e As EventArgs) Handles eventTimer.Tick

        For i = 0 To BunifuDataGridView2.RowCount - 1
            If BunifuDataGridView2.Rows(i).Cells(7).Value = False Then  'See if checkbox is checked
                If BunifuDataGridView2.Rows(i).Cells(6).Value < Now Then

                    Dim CheckDoneEvents As New ClsEvents
                    With CheckDoneEvents
                        .event_id = BunifuDataGridView2.Rows(i).Cells(0).Value.ToString()
                        .event_name = BunifuDataGridView2.Rows(i).Cells(1).Value.ToString()
                        .event_for = BunifuDataGridView2.Rows(i).Cells(2).Value.ToString()
                        .event_description = BunifuDataGridView2.Rows(i).Cells(3).Value.ToString()
                        .event_venue = BunifuDataGridView2.Rows(i).Cells(4).Value.ToString()
                        .event_datetime_start = Format(CDate(BunifuDataGridView2.Rows(i).Cells(5).Value), "yyyy-MM-dd HH:mm:ss tt")
                        .event_datetime_end = Format(CDate(BunifuDataGridView2.Rows(i).Cells(6).Value), "yyyy-MM-dd HH:mm:ss tt")
                        .event_status = "1"
                        .event_date_created = Format(CDate(BunifuDataGridView2.Rows(i).Cells(8).Value), "yyyy-MM-dd HH:mm:ss tt")
                        .update()
                        SnackBarMessage = New MaterialSkin.Controls.MaterialSnackBar(BunifuDataGridView2.Rows(i).Cells(1).Value.ToString() + " Ended", "OK", True)
                        SnackBarMessage.Show(Me)
                        ShowEvents()
                        ShowEventList()

                        loadEventChart()

                    End With
                End If
            End If
        Next


    End Sub

    Private Sub cmbEventList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEventList.SelectedIndexChanged
        If eventSwitch.Checked Then
            ' BunifuDataGridView3.DataSource = ClsConn.LoadData("SELECT attendance.idattendance as ID, participantid as Student_ID,event_id as Event_ID,  date_format(logdatetime,'%b-%d-%Y %h:%i %p') AS `Log` FROM conferencedb.attendance order by logdatetime desc").DefaultView
            'BunifuDataGridView3.DataSource = ClsConn.LoadData(" SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event,  date_format(logdatetime,'%b-%d-%Y %h:%i %p') AS `Log` FROM conferencedb.attendance, conferencedb.participants, conferencedb.events where participants.idparticipant = attendance.participantid and attendance.event_id = events.id order by logdatetime desc").DefaultView
            'MsgBox(cmbEventList.SelectedValue.ToString)
            'Dim strAttendance As String = String.Format(" SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event, date_format(logdatetime,'%b-%d-%Y') AS Day, date_format(timein, '%h:%i %p') AS TimeIN,  date_format(timeout, '%h:%i %p')AS TimeOut FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN conferencedb.events on attendance.event_id = events.id) where attendance.event_id =  " & cmbEventList.SelectedValue.ToString & " order by logdatetime desc   ")
            Dim strAttendance As String = String.Format(" SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event, date_format(logdatetime,'%b-%d-%Y') AS Day, date_format(timein, '%h:%i %p') AS TimeIN,  date_format(timeout, '%h:%i %p')AS TimeOut FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN conferencedb.events on attendance.event_id = events.id) where attendance.event_id =  " & cmbEventList.SelectedValue.ToString & "  And  date_format(logdatetime,'%Y-%m-%d') = CURDATE() order by logdatetime desc   ")

            BunifuDataGridView3.DataSource = ClsConn.LoadData(strAttendance).DefaultView
            lblAttendeesCount.Text = "Records: "
            lblAttendeesCount.Text = lblAttendeesCount.Text + BunifuDataGridView3.Rows.Count().ToString()
        Else
            ShowAttendance(1)
        End If
    End Sub

    Private Sub eventSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles eventSwitch.CheckedChanged
        If eventSwitch.Checked Then
            '  cmbEventList.SelectedIndex = -1

            cmbEventList.Enabled = False
            cmbEventList.Enabled = True
        Else
            cmbEventList.SelectedIndex = 0
            cmbEventList.Enabled = True
            cmbEventList.Enabled = False



        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        scanQR.ShowDialog()
    End Sub
    Public Sub Restore()
        If (ClsConn.OpenConnection() = True) Then
            Dim cmd1 As MySqlCommand = New MySqlCommand
            cmd1.Connection = sqlCon
            'sqlCon.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd1)
            OpenFileDialog1.Title = "Please select a DB file"
            OpenFileDialog1.InitialDirectory = "C:\"
            OpenFileDialog1.Filter = "DB Files|*.sql"
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()

            ' Test result.
            If result = Windows.Forms.DialogResult.OK Then
                ' Do something.
                Dim sr As String = OpenFileDialog1.FileName
                mb.ImportFromFile(sr)
                ' MessageBox.Show("Database successfully restored" + " " + sr, "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim SnackBarMessage As MaterialSnackBar = New MaterialSnackBar("Database successfully restored" & " " & sr, "OK", True)
                SnackBarMessage.Show(Me)
            End If
            sqlCon.Close()
        End If
    End Sub


    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            Backup()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Try
            If MessageBox.Show("Do you want to restore database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Restore()
                ShowRegistration()
                ShowEventList()
                ShowEvents()
                ShowAttendance(1)
                Initial_State()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ScannedTextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ScannedTextbox.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim attendance As New ClsAttendance
            With attendance
                .participantid = ScannedTextbox.Text
                .checkifcourseisacceptedinevent()
                'CountAttendance()
                'MsgBox("Event ID: " + dashboard.cmbEventList.SelectedValue.ToString)

            End With
        End If
    End Sub

    Private Sub txtsearchsms_TextChanged(sender As Object, e As EventArgs) Handles txtsearchsms.TextChanged
        Dim str As String = String.Format("SELECT smsID as ID, sender as Sender,message as Message, receiver as Recipient, status as Status, date_format(datesent,'%b-%d-%Y %h:%i %p') AS `Date and Time` FROM conferencedb.smslog  WHERE receiver like '%{0}%' OR message like '%{0}%' or datesent like '%{0}%' order by datesent desc", txtsearchsms.Text)
        BunifuDataGridView4.DataSource = ClsConn.LoadData(str).DefaultView
        lblcountsms.Text = "Records: "
        lblcountsms.Text = lblcountsms.Text + BunifuDataGridView4.Rows.Count().ToString()
    End Sub



    Private Sub MaterialExpansionPanel1_SaveClick(sender As Object, e As EventArgs) Handles panelChangePassword.SaveClick
        Try



            If Len(Trim(txtoldpassword.Text)) = 0 Then
                MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtoldpassword.SelectAll()
                txtoldpassword.Focus()
                Exit Sub
            End If
            If Len(Trim(txtnewpassword.Text)) = 0 Then
                MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.SelectAll()
                txtnewpassword.Focus()
                Exit Sub
            End If
            If Len(Trim(txtconfirmpassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtconfirmpassword.SelectAll()
                txtconfirmpassword.Focus()
                Exit Sub
            End If
            If txtnewpassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtnewpassword.SelectAll()
                txtnewpassword.Focus()
                Exit Sub
            ElseIf txtnewpassword.Text <> txtconfirmpassword.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtoldpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtconfirmpassword.SelectAll()
                txtconfirmpassword.Focus()
                Exit Sub
            ElseIf txtoldpassword.Text = txtnewpassword.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtnewpassword.SelectAll()
                txtnewpassword.Focus()
                Exit Sub
            End If
            Dim userCredential As New ClsLogin
            With userCredential
                .username = login.txtUserName.Text
                .password = txtnewpassword.Text
                .oldpassword = txtoldpassword.Text
                .updatePassword()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub ExportExcel(ByVal obj As Object)
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = obj.RowCount
            colsTotal = obj.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = obj.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = obj.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub



    Private Sub cmbReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReportType.SelectedIndexChanged
        If cmbReportType.SelectedIndex = 0 Then
            With cmbReportFilter
                .DataSource = Nothing
                .Items.Clear()
                .Items.Add("ALL")
                .Items.Add("GRADE 1")
                .Items.Add("GRADE 2")
                .Items.Add("GRADE 3")
                .Items.Add("GRADE 4")
                .Items.Add("GRADE 5")
                .Items.Add("GRADE 6")
                .Items.Add("GRADE 7")
            End With

        End If
        If cmbReportType.SelectedIndex = 1 Then
            With cmbReportFilter
                .DataSource = Nothing
                .Items.Clear()
                .Items.Add("All")
                .Items.Add("Ongoing")
                .Items.Add("Completed")
            End With
        End If
        If cmbReportType.SelectedIndex = 2 Then
            With cmbReportFilter
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = ClsConn.LoadData("SELECT id, event FROM conferencedb.events order by event asc").DefaultView
                .ValueMember = "id"
                .DisplayMember = "event"
            End With

        End If
        If cmbReportType.SelectedIndex = 3 Then
            With cmbReportFilter
                .DataSource = Nothing
                .Items.Clear()
            End With
        End If
    End Sub
    Dim str, txtFilter, txtFilterStudent, txtDateFrom, txtDateTo As String

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If cmbReportType.SelectedIndex = 0 Then
            txtFilter = cmbReportFilter.Text
            If txtFilter = "ALL" Then
                txtFilter = ""
            End If
            str = String.Format("SELECT idparticipant as ID, LASTNAME as Last_Name, FIRSTNAME as First_Name, MIDDLENAME as Middle_Name, COURSE as Grade,guardian as Guardian_Name, CONTACTNO as Contact_No, date_format(REG_AT,'%b %d %Y %h:%i %p') AS `DATE REGISTERED` FROM conferencedb.participants WHERE course like '%{0}%' order by reg_at desc", txtFilter)
            dgwRpt.DataSource = ClsConn.LoadData(str).DefaultView
            lblCountRpt.Text = "Records: "
            lblCountRpt.Text = lblCountRpt.Text + dgwRpt.Rows.Count().ToString()
        End If
        If cmbReportType.SelectedIndex = 1 Then
            txtFilter = cmbReportFilter.Text
            If txtFilter = "Ongoing" Then
                txtFilter = "0"
            End If
            If txtFilter = "Completed" Then
                txtFilter = "1"
            End If
            If txtFilter = "All" Then
                txtFilter = ""
            End If
            str = String.Format("SELECT id as ID, event as Event,event_for as Course , description as Description, venue as venue, date_format(event_datetime_start,'%b-%d-%Y %h:%i %p') AS `Start`,  date_format(event_datetime_end,'%b-%d-%Y %h:%i %p') AS `End`, status as Status, date_format(date_created,'%b-%d-%Y %h:%i %p') AS `Date Created` FROM conferencedb.events  WHERE status like '%{0}%' order by date_created desc", txtFilter)
            dgwRpt.DataSource = ClsConn.LoadData(str).DefaultView
            lblCountRpt.Text = "Records: "
            lblCountRpt.Text = lblCountRpt.Text + dgwRpt.Rows.Count().ToString()
        End If
        If cmbReportType.SelectedIndex = 2 Then
            filterReports.ShowDialog()
            txtFilter = cmbReportFilter.SelectedValue.ToString
            txtFilterStudent = filterReports.cmbCriteria.Text
            txtDateFrom = filterReports.dtFrom.Value.ToString("yyyy-MM-dd")
            txtDateTo = filterReports.dtTo.Value.ToString("yyyy-MM-dd")
            If txtFilterStudent = "All" Or txtFilterStudent = "" Then
                txtFilterStudent = ""
            End If
            'MsgBox(txtFilterStudent)
            str = String.Format("SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event, date_format(logdatetime,'%b-%d-%Y') AS Day, date_format(timein, '%h:%i %p') AS TimeIN,  date_format(timeout, '%h:%i %p')AS TimeOut FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN conferencedb.events on attendance.event_id = events.id) where attendance.event_id =  " & txtFilter & " and Date(logdatetime) Between '" & txtDateFrom & "' and '" & txtDateTo & "' and CONCAT(lastname,', ',firstname, ' ',middlename) like '%{0}%' order by logdatetime desc", txtFilterStudent)
            dgwRpt.DataSource = ClsConn.LoadData(str).DefaultView
            lblCountRpt.Text = "Records: "
            lblCountRpt.Text = lblCountRpt.Text + dgwRpt.Rows.Count().ToString()
        End If
        If cmbReportType.SelectedIndex = 3 Then
            filterReports.ShowDialog()

            txtFilterStudent = filterReports.cmbCriteria.Text
            txtDateFrom = filterReports.dtFrom.Value.ToString("yyyy-MM-dd")
            txtDateTo = filterReports.dtTo.Value.ToString("yyyy-MM-dd")
            If txtFilterStudent = "All" Or txtFilterStudent = "" Then
                txtFilterStudent = ""
            End If
            'MsgBox(txtFilterStudent)
            str = String.Format("SELECT smsID as ID, sender as Sender,message as Message, receiver as Recipient,participants.guardian as guardian, status as Status, date_format(datesent,'%b-%d-%Y %h:%i %p') AS `Date and Time` FROM conferencedb.smslog,conferencedb.participants where receiver= REPLACE(contactno,'-','') and Date(datesent) Between '" & txtDateFrom & "' and '" & txtDateTo & "'and CONCAT(lastname,', ',firstname, ' ',middlename) like '%{0}%' order by datesent desc", txtFilterStudent)
            dgwRpt.DataSource = ClsConn.LoadData(str).DefaultView
            lblCountRpt.Text = "Records: "
            lblCountRpt.Text = lblCountRpt.Text + dgwRpt.Rows.Count().ToString()
        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportExcel(dgwRpt)
    End Sub


    Private Sub dashboard_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If MaterialTabControl1.SelectedIndex = 3 Then
            If e.KeyCode = Keys.Enter Then
                ScannedTextbox.SelectAll()
                ScannedTextbox.Select()
            End If
        End If
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click

        If MaterialExpansionPanel2.Collapse = False Then
            MaterialExpansionPanel2.Collapse = True
        Else
            MaterialExpansionPanel2.Collapse = False
        End If

    End Sub
    Dim apppath As String = ""
    Private Sub txtBackupLocation_Click(sender As Object, e As EventArgs) Handles txtBackupLocation.Click

        If apppath = "" Then
            Dim dialog As New FolderBrowserDialog()
            dialog.RootFolder = Environment.SpecialFolder.Desktop
            dialog.SelectedPath = Application.StartupPath
            dialog.Description = "Select Application Configuration Files Path"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                apppath = dialog.SelectedPath & "\"
            End If
            txtBackupLocation.Text = apppath

            ' My.Computer.FileSystem.WriteAllText(apppath & "\", apppath, False)
        End If
        'If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
        '    txtBackupLocation.Text = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName.ToString)

        'End If
    End Sub

    Private Sub MaterialExpansionPanel2_SaveClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel2.SaveClick
        Dim defaultAppPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Setting")

        Dim backUpPath As String = defaultAppPath
        Dim mySettings As String = backUpPath & "\Settings.ini"
        Dim objIniFile As New ClsIni(mySettings)
        If (Not System.IO.Directory.Exists(backUpPath)) Then
            System.IO.Directory.CreateDirectory(backUpPath)
        End If
        If Not System.IO.File.Exists(mySettings) Then
            System.IO.File.Create(mySettings).Dispose()
        End If
        Dim readbackUpPath As String = objIniFile.GetString("Backup", "Location", "")
        If readbackUpPath = "" Then
            objIniFile.WriteString("Backup", "Location", "C:\backup\ams\")
            readbackUpPath = objIniFile.GetString("Backup", "Location", "")
        Else
            objIniFile.WriteString("Backup", "Location", apppath)
        End If


        Dim SnackBarMessage As MaterialSnackBar = New MaterialSnackBar("Backup location successfully modified.", 750)
        SnackBarMessage.Show(Me)
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        Dim manageUser As New ClsLogin
        With manageUser
            .username = login.txtUserName.Text
            .password = login.txtPassword.Text
            .USER_LOOKUP()
            If .userRole = "True" Then
                manageUsers.ShowDialog()
            Else
                If panelChangePassword.Collapse = True Then
                    panelChangePassword.Collapse = False
                Else
                    panelChangePassword.Collapse = True
                End If
            End If
        End With
    End Sub

    Private Sub btnServerSetting_Click(sender As Object, e As EventArgs) Handles btnServerSetting.Click
        If pnlDBsetting.Collapse = False Then
            pnlDBsetting.Collapse = True
        Else
            pnlDBsetting.Collapse = False
        End If
    End Sub

    Private Sub pnlDBsetting_SaveClick(sender As Object, e As EventArgs) Handles pnlDBsetting.SaveClick
        Dim defaultAppPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Setting")

        Dim backUpPath As String = defaultAppPath
        Dim mySettings As String = backUpPath & "\Settings.ini"
        Dim objIniFile As New ClsIni(mySettings)
        If (Not System.IO.Directory.Exists(backUpPath)) Then
            System.IO.Directory.CreateDirectory(backUpPath)
        End If
        If Not System.IO.File.Exists(mySettings) Then
            System.IO.File.Create(mySettings).Dispose()
        End If
        Dim readServer As String = objIniFile.GetString("Database", "server", "")
        Dim readDBName As String = objIniFile.GetString("Database", "name", "")
        Dim readUsername As String = objIniFile.GetString("Database", "username", "")
        Dim readPassword As String = objIniFile.GetString("Database", "password", "")
        If readServer = "" Or readDBName = "" Or readUsername = "" Then
            objIniFile.WriteString("Database", "server", "localhost")
            objIniFile.WriteString("Database", "name", "conferencedb")
            objIniFile.WriteString("Database", "username", "root")
            objIniFile.WriteString("Database", "password", "")
            readServer = objIniFile.GetString("Database", "server", "")
            readDBName = objIniFile.GetString("Database", "name", "")
            readUsername = objIniFile.GetString("Database", "username", "")
            readPassword = objIniFile.GetString("Database", "password", "")
        Else
            objIniFile.WriteString("Database", "server", txtServer.Text)
            objIniFile.WriteString("Database", "name", txtDBname.Text)
            objIniFile.WriteString("Database", "username", txtDBUsername.Text)
            objIniFile.WriteString("Database", "password", Encrypt(txtDBPassword.Text.Trim()))
        End If


        Dim SnackBarMessage As MaterialSnackBar = New MaterialSnackBar("Database settings successfully modified.", 750)
        SnackBarMessage.Show(Me)
    End Sub

    Private Sub btnLinks_Click(sender As Object, e As EventArgs) Handles btnFaceBook.Click, btnYoutube.Click, btnGmail.Click
        Dim defaultAppPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Setting")

        Dim backUpPath As String = defaultAppPath
        Dim mySettings As String = backUpPath & "\Settings.ini"
        Dim objIniFile As New ClsIni(mySettings)
        If (Not System.IO.Directory.Exists(backUpPath)) Then
            System.IO.Directory.CreateDirectory(backUpPath)
        End If
        If Not System.IO.File.Exists(mySettings) Then
            System.IO.File.Create(mySettings).Dispose()
        End If
        Dim readFB As String = objIniFile.GetString("URLs", "facebook", "")
        Dim readYT As String = objIniFile.GetString("URLs", "youtube", "")
        Dim readGmail As String = objIniFile.GetString("URLs", "gmail", "")

        If readFB = "" Or readYT = "" Or readGmail = "" Then
            objIniFile.WriteString("URLs", "facebook", "www.facebook.com")
            objIniFile.WriteString("URLs", "youtube", "www.youtube.com")
            objIniFile.WriteString("URLs", "gmail", "mail.google.com")

            readFB = objIniFile.GetString("URLs", "facebook", "")
            readYT = objIniFile.GetString("URLs", "youtube", "")
            readGmail = objIniFile.GetString("URLs", "gmail", "")
        Else
            If sender.name.ToString.Contains("btnFaceBook") Then
                NavigateWebURL(readFB, "msedge")
            End If
            If sender.name.ToString.Contains("btnYoutube") Then
                NavigateWebURL(readYT, "msedge")
            End If
            If sender.name.ToString.Contains("btnGmail") Then
                NavigateWebURL(readGmail, "msedge")
            End If
        End If
    End Sub
    Private Sub NavigateWebURL(ByVal URL As String, Optional browser As String = "default")

        If Not (browser = "default") Then
            Try
                '// try set browser if there was an error (browser not installed)
                Process.Start(browser, URL)
            Catch ex As Exception
                '// use default browser
                Process.Start(URL)
            End Try

        Else
            '// use default browser
            Process.Start(URL)

        End If

    End Sub

    Private Sub btnImportMultipleStud_Click(sender As Object, e As EventArgs) Handles btnImportMultipleStud.Click
        importMultipleStudents.ShowDialog()
    End Sub



    Private Sub btnDeleteMultiple_Click(sender As Object, e As EventArgs) Handles btnDeleteMultiple.Click
        'MsgBox(BunifuDataGridView1.SelectedRows.Count)
        Dim deleteStudent As New ClsRegistration
        With deleteStudent

            If MessageBox.Show("Do you really want to delete the selected student? : ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
                For Each row As DataGridViewRow In BunifuDataGridView1.SelectedRows
                    '  yourDGV.Rows.Remove(row)
                    .delete(BunifuDataGridView1.Item("ID", row.Index).Value)
                    '.delete(BunifuDataGridView1.Item("ID", BunifuDataGridView1.CurrentRow.Index).Value)
                Next

                MsgBox("Successfully deleted students")
                ShowRegistration()
            End If
        End With
    End Sub




    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Print()
    End Sub
    Sub Print()
        Try

            'If cmbReportType.SelectedIndex = 0 Then
            '    Dim txtFilter As String = cmbReportFilter.Text
            '    If txtFilter = "ALL" Then
            '        txtFilter = ""
            '    End If
            '    str = String.Format("SELECT idparticipant as ID, LASTNAME as Last_Name, FIRSTNAME as First_Name, MIDDLENAME as Middle_Name, COURSE as Grade,guardian as Guardian_Name, CONTACTNO as Contact_No, date_format(REG_AT,'%b %d %Y %h:%i %p') AS `DATE REGISTERED` FROM conferencedb.participants WHERE course like '%{0}%' order by reg_at desc", txtFilter)
            '    dgwRpt.DataSource = ClsConn.LoadData(str).DefaultView
            '    lblCountRpt.Text = "Records: "
            '    lblCountRpt.Text = lblCountRpt.Text + dgwRpt.Rows.Count().ToString()
            'End If
            'If cmbReportType.SelectedIndex = 1 Then
            '    Dim txtFilter As String = cmbReportFilter.Text
            '    If txtFilter = "Ongoing" Then
            '        txtFilter = "0"
            '    End If
            '    If txtFilter = "Completed" Then
            '        txtFilter = "1"
            '    End If
            '    If txtFilter = "All" Then
            '        txtFilter = ""
            '    End If
            '    str = String.Format("SELECT id as ID, event as Event,event_for as Course , description as Description, venue as venue, date_format(event_datetime_start,'%b-%d-%Y %h:%i %p') AS `Start`,  date_format(event_datetime_end,'%b-%d-%Y %h:%i %p') AS `End`, status as Status, date_format(date_created,'%b-%d-%Y %h:%i %p') AS `Date Created` FROM conferencedb.events  WHERE status like '%{0}%' order by date_created desc", txtFilter)
            '    dgwRpt.DataSource = ClsConn.LoadData(str).DefaultView
            '    lblCountRpt.Text = "Records: "
            '    lblCountRpt.Text = lblCountRpt.Text + dgwRpt.Rows.Count().ToString()
            'End If
            'If cmbReportType.SelectedIndex = 2 Then
            '    filterReports.ShowDialog()
            '    Dim txtFilter As String = cmbReportFilter.SelectedValue.ToString
            '    Dim txtFilterStudent As String = filterReports.cmbCriteria.Text
            '    Dim txtDateFrom As String = filterReports.dtFrom.Value.ToString("yyyy-MM-dd")
            '    Dim txtDateTo As String = filterReports.dtTo.Value.ToString("yyyy-MM-dd")
            '    If txtFilterStudent = "All" Or txtFilterStudent = "" Then
            '        txtFilterStudent = ""
            '    End If
            '    'MsgBox(txtFilterStudent)
            '    str = String.Format("SELECT attendance.idattendance as ID, concat(participants.lastname, ', ',participants.firstname, ' ', participants.middlename) as Student_Name,attendance.participantid as Student_ID, concat(events.event,'-',attendance.event_id) as Event, date_format(logdatetime,'%b-%d-%Y') AS Day, date_format(timein, '%h:%i %p') AS TimeIN,  date_format(timeout, '%h:%i %p')AS TimeOut FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN conferencedb.events on attendance.event_id = events.id) where attendance.event_id =  " & txtFilter & " and Date(logdatetime) Between '" & txtDateFrom & "' and '" & txtDateTo & "' and CONCAT(lastname,', ',firstname, ' ',middlename) like '%{0}%' order by logdatetime desc", txtFilterStudent)
            '    dgwRpt.DataSource = ClsConn.LoadData(str).DefaultView
            '    lblCountRpt.Text = "Records: "
            '    lblCountRpt.Text = lblCountRpt.Text + dgwRpt.Rows.Count().ToString()
            'End If
            'If cmbReportType.SelectedIndex = 3 Then
            '    filterReports.ShowDialog()

            '    Dim txtFilterStudent As String = filterReports.cmbCriteria.Text
            '    Dim txtDateFrom As String = filterReports.dtFrom.Value.ToString("yyyy-MM-dd")
            '    Dim txtDateTo As String = filterReports.dtTo.Value.ToString("yyyy-MM-dd")
            '    If txtFilterStudent = "All" Or txtFilterStudent = "" Then
            '        txtFilterStudent = ""
            '    End If
            '    'MsgBox(txtFilterStudent)
            '    str = String.Format("SELECT smsID as ID, sender as Sender,message as Message, receiver as Recipient,participants.guardian as guardian, status as Status, date_format(datesent,'%b-%d-%Y %h:%i %p') AS `Date and Time` FROM conferencedb.smslog,conferencedb.participants where receiver= REPLACE(contactno,'-','') and Date(datesent) Between '" & txtDateFrom & "' and '" & txtDateTo & "'and CONCAT(lastname,', ',firstname, ' ',middlename) like '%{0}%' order by datesent desc", txtFilterStudent)
            '    dgwRpt.DataSource = ClsConn.LoadData(str).DefaultView
            '    lblCountRpt.Text = "Records: "
            '    lblCountRpt.Text = lblCountRpt.Text + dgwRpt.Rows.Count().ToString()
            'End If
            If (ClsConn.OpenConnection() = True) Then
                Cursor = Cursors.WaitCursor
                Timer1.Enabled = True
                Dim rptStudents As New Students
                Dim rptEvents As New Events
                Dim rptAttendance As New Attendance
                Dim rptSms As New SMSLogs
                Dim myConnection As MySqlConnection
                Dim MyCommand, MyCommand1 As New MySqlCommand()
                Dim myDA, myDA1 As New MySqlDataAdapter()
                Dim myDS As New DataSet 'The DataSet you created.

                myConnection = sqlCon
                MyCommand.Connection = myConnection
                MyCommand1.Connection = myConnection
                If cmbReportType.SelectedIndex = 0 Then
                    MyCommand1.CommandText = String.Format("SELECT * FROM conferencedb.participants WHERE course like '%{0}%' order by lastname asc", txtFilter)
                    MyCommand1.CommandType = CommandType.Text
                    myDA1.SelectCommand = MyCommand1
                    myDA1.Fill(myDS, "participants")
                    rptStudents.SetDataSource(myDS)
                    frmReport.CrystalReportViewer.ReportSource = rptStudents
                    frmReport.ShowDialog()
                End If
                If cmbReportType.SelectedIndex = 1 Then
                    MyCommand1.CommandText = String.Format("SELECT  id , event,event_for , description, venue, date_format(event_datetime_start,'%b-%d-%Y %h:%i %p') as `event_datetime_start`,  date_format(event_datetime_end,'%b-%d-%Y %h:%i %p') as `event_datetime_end`, CAST(status AS CHAR) as status, date_format(date_created,'%b-%d-%Y %h:%i %p') as `date_created` FROM conferencedb.events  WHERE status like '%{0}%' order by date_created desc", txtFilter)
                    MyCommand1.CommandType = CommandType.Text
                    myDA1.SelectCommand = MyCommand1

                    myDA1.Fill(myDS, "events")
                    rptEvents.SetDataSource(myDS)
                    frmReport.CrystalReportViewer.ReportSource = rptEvents
                    frmReport.ShowDialog()
                End If
                If cmbReportType.SelectedIndex = 2 Then
                    'MsgBox(txtFilter)
                    MyCommand1.CommandText = String.Format("SELECT attendance.idattendance , participants.lastname, participants.firstname,  participants.middlename,attendance.participantid , events.event,attendance.event_id, logdatetime, date_format(timein, '%h:%i %p') AS timein,  date_format(timeout, '%h:%i %p') AS timeout FROM ((conferencedb.attendance INNER JOIN conferencedb.participants on participants.idparticipant = attendance.participantid) INNER JOIN conferencedb.events on attendance.event_id = events.id) where attendance.event_id =  " & txtFilter & " and Date(logdatetime) Between '" & txtDateFrom & "' and '" & txtDateTo & "' and CONCAT(lastname,', ',firstname, ' ',middlename) like '%{0}%' order by logdatetime desc", txtFilterStudent)
                    MyCommand1.CommandType = CommandType.Text
                    myDA1.SelectCommand = MyCommand1

                    myDA1.Fill(myDS, "attendance")
                    ' myDA1.Fill(myDS, "participants")
                    rptAttendance.SetDataSource(myDS)
                    frmReport.CrystalReportViewer.ReportSource = rptAttendance
                    frmReport.ShowDialog()
                End If
                If cmbReportType.SelectedIndex = 3 Then
                    MyCommand1.CommandText = String.Format("SELECT smsID , sender, Message, receiver, participants.guardian,  REPLACE(contactno,'-','') as contactno, status, date_format(datesent,'%b-%d-%Y %h:%i %p') AS `datesent` FROM conferencedb.smslog, conferencedb.participants where receiver= REPLACE(contactno,'-','') and Date(datesent) Between '" & txtDateFrom & "' and '" & txtDateTo & "'and CONCAT(lastname,', ',firstname, ' ',middlename) like '%{0}%' order by datesent desc", txtFilterStudent)
                    MyCommand1.CommandType = CommandType.Text
                    myDA1.SelectCommand = MyCommand1
                    myDA1.Fill(myDS, "smslog")
                    rptSms.SetDataSource(myDS)
                    frmReport.CrystalReportViewer.ReportSource = rptSms
                    frmReport.ShowDialog()
                End If


                ClsConn.CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class