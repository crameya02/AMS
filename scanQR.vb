Imports System.IO
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec
Imports MessagingToolkit.QRCode
Imports VB = Microsoft.VisualBasic
Public Class scanQR
    Dim decoded As String
    Private CaptureDevice As FilterInfoCollection
    Private FinalFrame As VideoCaptureDevice
    Public Sub CountAttendance()
        lblam.Text = ClsConn.CountRec("SELECT COUNT(DISTINCT participantid) FROM conferencedb.attendance WHERE date(timein)=date(now()) and date_format(timein, '%p')='AM';").ToString()
        lblpm.Text = ClsConn.CountRec("SELECT COUNT(DISTINCT participantid) FROM conferencedb.attendance WHERE date(timeout)=date(now()) and date_format(timeout, '%p')='PM';").ToString()
    End Sub

    Private Sub FinalFrame_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Try
            PictureBox1.Image = CType(eventArgs.Frame.Clone(), Bitmap)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub scanQR_Load(sender As Object, e As EventArgs) Handles Me.Load

        myCustomSkin.myCustomSkin()
        dateTimeTimer.Enabled = True
        CaptureDevice = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        ComboBox1.Items.Clear()

        For Each Device As FilterInfo In CaptureDevice
            ComboBox1.Items.Add(Device.Name)
        Next

        ComboBox1.SelectedIndex = 0
        FinalFrame = New VideoCaptureDevice()
        CountAttendance()
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub dateTimeTimer_Tick(sender As Object, e As EventArgs) Handles dateTimeTimer.Tick
        Me.Text = Now
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        FinalFrame = New VideoCaptureDevice(CaptureDevice(ComboBox1.SelectedIndex).MonikerString)
        AddHandler FinalFrame.NewFrame, AddressOf Me.FinalFrame_NewFrame

        FinalFrame.Start()
    End Sub
    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Private Sub btnDetect_Click(sender As Object, e As EventArgs) Handles btnDetect.Click

        wait(5)

        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If FinalFrame.IsRunning = True Then
            FinalFrame.[Stop]()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            Dim Reader As BarcodeReader = New BarcodeReader()
            Dim result As Result = Reader.Decode(CType(PictureBox1.Image, Bitmap))

            decoded = result.ToString().Trim()

            If decoded <> "" Then
                Timer1.[Stop]()
                Dim attendance As New ClsAttendance
                With attendance
                    .participantid = decoded.ToString()
                    .checkifcourseisacceptedinevent()
                    'CountAttendance()
                    'MsgBox("Event ID: " + dashboard.cmbEventList.SelectedValue.ToString)

                End With

            Else
                Timer1.Start()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub scanQR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If FinalFrame.IsRunning = True Then
            FinalFrame.[Stop]()
        End If
    End Sub

End Class