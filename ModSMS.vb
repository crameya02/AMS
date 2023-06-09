Imports System.Management
Imports System.Threading
Imports System.Text.RegularExpressions
Imports MaterialSkin.Controls
Imports MySql.Data.MySqlClient
Imports System.IO.Ports

Module ModSMS
    'For ch30 usb modem
    Public Function findComDevice(ByVal PartialName As String) As String
        Try
            Dim moReturn As Management.ManagementObjectCollection
            Dim moSearch As Management.ManagementObjectSearcher
            Dim mo As Management.ManagementObject
            moSearch = New Management.ManagementObjectSearcher("Select * from Win32_PnPEntity")
            moReturn = moSearch.Get

            For Each mo In moReturn
                If IsNothing(mo.Properties.Item("Name").Value) Then Continue For
                If CStr(mo.Properties.Item("Name").Value).ToUpper.Contains(PartialName.ToUpper) Then
                    'returns something like: "Prolific USB-to-Serial Comm Port (COM17)"
                    Dim IPRegEx As Regex = New Regex("(?<=\().*?(?=\))")
                    Return IPRegEx.Match(mo.Properties.Item("Name").Value.ToString).Value
                End If
            Next
            Return Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return Nothing
        End Try

    End Function

    Private Sub OpenScanner()
        Dim rst = findComDevice("USB-SERIAL CH340")
        If Not IsNothing(rst) Then
            'portname.PortName = rst.ToString
        Else
            'ComScanner.PortName = some value from a settings file
        End If

    End Sub

    'for usb modem like globe tatoo
    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim strComputer As String = "."
            Dim searcher As New ManagementObjectSearcher(
                "\root\CIMV2",
                         "SELECT * FROM Win32_PnPEntity")
            '  "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                'If queryObj("Status") = "OK" Then
                '    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")
                'End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Return ""
        End Try
        Return modems
    End Function
    Public Function portname() As String
        Dim ports() As String
        Dim port As String = ""
        Try
            ports = Split(ModemsConnected(), "***")

            For i As Integer = 0 To ports.Length - 2
                port = (ports(i))
                port = Trim(Mid(port, 1, 5))

            Next

        Catch err As ManagementException
            MessageBox.Show("Error while connecting to Modem: " & err.Message)

            Return ""
        End Try
        Return port
    End Function

    Public Property rcvdata As String = ""
    Public Sub messagedata(ByVal indata As String)
        rcvdata &= indata
    End Sub

    Public Async Sub sendsms(txtnumber As String, txtmessage As String)
        Try
            With dashboard.SerialPort1
                .Write("AT" & vbCrLf)
                Await Task.Delay(1000)
                .Write("AT+CSCS=" & Chr(34) & "GSM" & Chr(34) & vbCrLf)
                Await Task.Delay(1000)
                ' Threading.Thread.Sleep(1000)
                .Write("AT+CMGF=1" + vbCrLf)
                Await Task.Delay(1000)
                'Threading.Thread.Sleep(1000)
                .Write("AT+CMGS=" & Chr(34) & txtnumber & Chr(34) & vbCrLf)
                Await Task.Delay(1000)
                .Write(txtmessage & Chr(26))
                Await Task.Delay(15000)
                ' Threading.Thread.Sleep(1000)
                'MsgBox(rcvdata.ToString)
            End With
            If rcvdata.ToString.Contains(">") And rcvdata.ToString.Contains("+CMGS: ") Then
                'MsgBox("Message Sent")
                receiver = txtnumber
                message = txtmessage
                status = "Sent"
                save()
            Else
                MsgBox("Unable to send message at the moment. Please contact system administrator")
            End If
        Catch ex As Exception
            'MsgBox(ErrorToString)
            Dim smsSnackbar As MaterialSnackBar = New MaterialSnackBar("Error while connecting to Modem: " & ErrorToString(), 1500)
            smsSnackbar.Show(dashboard)
        End Try
    End Sub
    Dim receiver, message, status As String

    Public Sub save()
        If (ClsConn.OpenConnection() = True) Then
            mode = Modes.add
            cmd = New MySqlCommand("INSERT INTO smslog VALUES(@smsid,@sender, @receiver, @message, @status, @datesent)", sqlCon)
            cmd.Parameters.AddWithValue("@smsid", ClsConn.Generateid("Select smsID FROM conferencedb.smslog"))
            cmd.Parameters.AddWithValue("@sender", "Attendance Management System")
            cmd.Parameters.AddWithValue("@receiver", receiver)
            cmd.Parameters.AddWithValue("@message", message)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@datesent", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            cmd.ExecuteNonQuery()
            dashboard.ShowAttendance(dashboard.cmbEventList.SelectedValue.ToString)

            ClsConn.CloseConnection()
        End If
    End Sub
End Module
