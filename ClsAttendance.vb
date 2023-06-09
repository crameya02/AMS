Imports MySql.Data.MySqlClient
Imports MaterialSkin.Controls
Imports TheArtOfDev.HtmlRenderer.Adapters

Public Class ClsAttendance
    Public Property idattendance As Integer
    Public Property participantid As String
    Public Property logdatetime As String

    Public Property eventid As String
    Public Property timein As String
    Public Property timeout As String
    Public Property currentID As Integer
    Public Function checkStudentIfExits() As Boolean
        If (ClsConn.OpenConnection() = True) Then
            cmd = New MySqlCommand("SELECT count(*) FROM participants where idparticipant=@participantid", sqlCon)
            cmd.Parameters.AddWithValue("@participantid", participantid)
            Dim count As Integer = 0

            count = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                Dim SnackBarMessageStudentExists As MaterialSnackBar = New MaterialSnackBar("Student not found/ Invalid input", 3000)
                SnackBarMessageStudentExists.Show(dashboard)
                'MsgBox("Student not found/ Invalid input", vbInformation)
                Return False
            Else
                'MsgBox("Student exists")
                Return True
            End If
            ClsConn.CloseConnection()
        End If
    End Function

    Public Sub checkifcourseisacceptedinevent()
        If (ClsConn.OpenConnection() = True) Then
            If checkStudentIfExits() = False Then
                Exit Sub
            End If
            cmd = New MySqlCommand("SELECT * FROM participants,events where participants.idparticipant=@participantid and events.id = " & dashboard.cmbEventList.SelectedValue & " and (participants.course = events.event_for  or events.event_for='ALL')", sqlCon)
            cmd.Parameters.AddWithValue("@participantid", participantid)

            If Convert.ToString(cmd.ExecuteScalar()) Is Nothing Then
                MsgBox("Student not allowed to enter event", vbInformation)
            End If
            If Convert.ToString(cmd.ExecuteScalar()) IsNot Nothing Then
                'if event accepts the student course
                Dim ReadEventfor As String
                rdr = cmd.ExecuteReader()
                If rdr.Read Then
                    ReadEventfor = rdr("id")
                    If dashboard.cmbEventList.SelectedValue = CInt(ReadEventfor) Then
                        checkIfCurrentDateandIDExistsThenUpdateOrSave()
                    End If
                End If
            End If

            ClsConn.CloseConnection()
        End If
    End Sub
    Dim ReadName, lname, fname, mname, grade As String

    Public Sub checkparticipantIDandSendSmS()

        If (ClsConn.OpenConnection() = True) Then

            cmd = New MySqlCommand("Select * FROM participants where  idparticipant=@participantid ", sqlCon)
            cmd.Parameters.AddWithValue("@participantid", participantid)

            Dim ReadID As String
            Dim ReadCourse As String
            Dim ReadContactNumber As String
            Dim ReadRegDate As String
            Dim concatReadMessage As String
            Dim studentstatus As String
            '   If cmd.ExecuteScalar <> 0 Then '' this is for integer because scalar accepts double by default
            If Convert.ToString(cmd.ExecuteScalar()) IsNot Nothing Then
                rdr = cmd.ExecuteReader()
                If rdr.Read Then
                    ReadID = rdr(0) 'id
                    ReadName = rdr(1) & ", " & rdr(2) & " " & rdr(3) & " " 'lname fname mname
                    lname = rdr(1)
                    fname = rdr(2)
                    mname = rdr(3)
                    grade = rdr(4)
                    ReadCourse = rdr(4) ' course
                    ReadContactNumber = rdr(5) 'contactnumber
                    ReadRegDate = rdr(6) ' regdate
                    'id is valid and date is valid

                    arrImage = rdr(8)
                    Select Case mode
                        Case Modes.add
                            If dashboard.cmbEventList.SelectedValue = 1 Then
                                studentstatus = "entered the campus On"
                                concatReadMessage = ReadName & " " & studentstatus & " " & Now
                                'MsgBox(concatReadMessage)
                                sendsms(ReadContactNumber.Replace("-", ""), concatReadMessage)
                            Else
                                studentstatus = "entered Event" & " " & dashboard.cmbEventList.Text & " On"
                                concatReadMessage = ReadName & studentstatus & " " & Now
                                'MsgBox(concatReadMessage)
                                sendsms(ReadContactNumber.Replace("-", ""), concatReadMessage)
                            End If
                        Case Modes.edit
                            If dashboard.cmbEventList.SelectedValue = 1 Then
                                studentstatus = "Exit the campus On"
                                concatReadMessage = ReadName & " " & studentstatus & " " & Now
                                'MsgBox(concatReadMessage)
                                sendsms(ReadContactNumber.Replace("-", ""), concatReadMessage)
                            Else
                                studentstatus = "Exit Event" & " " & dashboard.cmbEventList.Text & " On"
                                concatReadMessage = ReadName & studentstatus & " " & Now
                                ' MsgBox(concatReadMessage)
                                sendsms(ReadContactNumber.Replace("-", ""), concatReadMessage)
                            End If


                    End Select
                End If


            End If

        End If

    End Sub
    Private WithEvents tm As New Timer
    Dim materialDialog As MaterialDialog
    Public Sub save()
        If (ClsConn.OpenConnection() = True) Then
            mode = Modes.add
            cmd = New MySqlCommand("INSERT INTO attendance VALUES(@idattendance,@participantid, @logdatetime, @eventid, @timein, @timeout)", sqlCon)
            cmd.Parameters.AddWithValue("@idattendance", ClsConn.Generateid("Select idattendance FROM conferencedb.attendance"))
            cmd.Parameters.AddWithValue("@participantid", participantid)
            cmd.Parameters.AddWithValue("@logdatetime", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@eventid", dashboard.cmbEventList.SelectedValue.ToString)
            cmd.Parameters.AddWithValue("@timein", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@timeout", "")

            cmd.ExecuteNonQuery()
            dashboard.ShowAttendance(dashboard.cmbEventList.SelectedValue.ToString)

            checkparticipantIDandSendSmS()
            dashboard.txtlname.Text = lname
            dashboard.txtfname.Text = fname
            dashboard.txtMname.Text = mname
            dashboard.txtgrade.Text = grade
            Dim mstream As New System.IO.MemoryStream(arrImage)
            dashboard.pbStudImg.Image = Image.FromStream(mstream)
            'dashboard.pbStudImg.Image = img
            tm.Interval = 3000
            tm.Start()

            materialDialog = New MaterialDialog(dashboard, "Time In", ReadName & "(" & participantid & ")", "OK", True, "Cancel")
            materialDialog.ShowDialog(dashboard)
            'MsgBox("Welcome : " & ReadName & "(" & participantid & ")", vbInformation)
            'MsgBox(lname)
            dashboard.ScannedTextbox.SelectAll()
            'scanQR.btnDetect.PerformClick()
            ClsConn.CloseConnection()
        End If
    End Sub
    Private Sub tm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tm.Tick
        materialDialog.Close()
    End Sub
    Public Sub checkIfCurrentDateandIDExistsThenUpdateOrSave()
        If (ClsConn.OpenConnection() = True) Then

            'search if participant already logged for the current date
            cmd = New MySqlCommand("SELECT idattendance FROM attendance where  participantid=@participantid and event_id=@eventid and date_format(logdatetime,'%Y-%m-%d')=@logdatetime and (timeout is null or timeout = '') ", sqlCon)
            cmd.Parameters.AddWithValue("@participantid", participantid)
            cmd.Parameters.AddWithValue("@logdatetime", Now.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@eventid", dashboard.cmbEventList.SelectedValue.ToString)
            'if partcipant found already has timed in then
            If cmd.ExecuteScalar <> 0 Then
                'search for attendance id and event id
                currentID = CInt(cmd.ExecuteScalar)
                cmd = New MySqlCommand("SELECT COUNT(*) FROM attendance where idattendance=@idattendance and event_id=@eventid and date_format(logdatetime,'%Y-%m-%d')=@logdatetime ", sqlCon)
                cmd.Parameters.AddWithValue("@idattendance", currentID)
                cmd.Parameters.AddWithValue("@eventid", dashboard.cmbEventList.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@logdatetime", Now.ToString("yyyy-MM-dd"))

                If cmd.ExecuteScalar <> 0 Then
                    'id is valid and date is valid
                    update()
                Else
                    'user is not valid

                    MsgBox("No Record to Update.", vbInformation)
                    Exit Sub

                End If
            Else
                'participant has no log in
                save()



            End If
        End If
    End Sub

    Public Sub update()
        If (ClsConn.OpenConnection() = True) Then
            ' cmd = New MySqlCommand("UPDATE attendance Set idattendance=@idattendance, description =@description, term =@term, year_ =@year_, program =@program WHERE idattendance=@idattendance", sqlCon)
            mode = Modes.edit
            cmd = New MySqlCommand("UPDATE attendance SET  timeout=@timeout WHERE idattendance=@idattendance And date_format(logdatetime,'%Y-%m-%d')=@logdatetime", sqlCon)
            cmd.Parameters.AddWithValue("@idattendance", currentID)
            cmd.Parameters.AddWithValue("@logdatetime", Now.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@timeout", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("UPDATE attendance SET  logdatetime=@logdatetime WHERE idattendance=@idattendance", sqlCon)
            cmd.Parameters.AddWithValue("@idattendance", currentID)
            cmd.Parameters.AddWithValue("@logdatetime", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            cmd.ExecuteNonQuery()

            dashboard.ShowAttendance(dashboard.cmbEventList.SelectedValue.ToString)

            checkparticipantIDandSendSmS()
            dashboard.txtlname.Text = lname
            dashboard.txtfname.Text = fname
            dashboard.txtMname.Text = mname
            dashboard.txtgrade.Text = grade
            Dim mstream As New System.IO.MemoryStream(arrImage)
            dashboard.pbStudImg.Image = Image.FromStream(mstream)
            tm.Interval = 3000
            tm.Start()
            materialDialog = New MaterialDialog(dashboard, "Time Out", ReadName & "(" & participantid & ")", "OK", True, "Cancel")
            materialDialog.ShowDialog(dashboard)
            ' MsgBox("Record successfully updated.", vbInformation)
            dashboard.ScannedTextbox.SelectAll()
            'scanQR.btnDetect.PerformClick()
            ClsConn.CloseConnection()
        End If
    End Sub

    Public Sub delete(ByVal id As Integer)
        If (ClsConn.OpenConnection() = True) Then
            '  cmd = New MySqlCommand("delete from participants where idparticipant=@id", sqlCon)
            '  cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub
End Class
