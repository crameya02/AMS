Imports System.ComponentModel
Imports System.Globalization
Public Class manageEvents
    Public Sub initialState()
        ' addMinutes()
        If mode = Modes.add Then
            ClearTextbox(Me)
            dtEnd.Value = Now
            dtStart.Value = Now
            txtEventEnd.Text = dtEnd.Text
            txtEventStart.Text = dtStart.Text
            txtEventDescription.Text = ""
            cmbHourStr.SelectedIndex = 0
            cmbHourEnd.SelectedIndex = 9
            cmbAMPMStr.SelectedIndex = 0
            cmbAMPMEnd.SelectedIndex = 1
            cmbMinutesStr.SelectedIndex = 0
            cmbMinutesEnd.SelectedIndex = 0
            cmbEventFor.SelectedIndex = -1
            ' this is not necessary if you are using normal windows form, there is a bug in materialSkin that doesn't update combobox this is jus a workaround
            cmbHourStr.Enabled = False
            cmbHourEnd.Enabled = False
            cmbAMPMStr.Enabled = False
            cmbAMPMEnd.Enabled = False
            cmbMinutesStr.Enabled = False
            cmbMinutesEnd.Enabled = False
            cmbEventFor.Enabled = False
            cmbHourStr.Enabled = True
            cmbHourEnd.Enabled = True
            cmbAMPMStr.Enabled = True
            cmbAMPMEnd.Enabled = True
            cmbMinutesStr.Enabled = True
            cmbMinutesEnd.Enabled = True
            cmbEventFor.Enabled = True

        End If

        dashboard.btnAddEvent.Enabled = True
        dashboard.btnEditEvent.Enabled = False
    End Sub
    Public Sub addMinutes()
        Dim minutes As String = ""
        Dim indexA As Integer
        Dim indexB As Integer

        For indexA = 0 To 9 Step 1
            minutes = "0" + indexA.ToString
            cmbMinutesStr.Items.Add(minutes)
            cmbMinutesEnd.Items.Add(minutes)
        Next indexA
        For indexB = 10 To 59 Step 1
            minutes = indexB.ToString
            cmbMinutesStr.Items.Add(minutes)
            cmbMinutesEnd.Items.Add(minutes)
        Next indexB
    End Sub
    Private Sub manageEvents_Load(sender As Object, e As EventArgs) Handles Me.Load
        myCustomSkin.myCustomSkin()
        initialState()


    End Sub


    Private Sub dtEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtEnd.ValueChanged
        txtEventEnd.Text = dtEnd.Text
    End Sub

    Private Sub dtStart_ValueChanged(sender As Object, e As EventArgs) Handles dtStart.ValueChanged
        txtEventStart.Text = dtStart.Text
    End Sub
    Dim SnackBarMessage As MaterialSkin.Controls.MaterialSnackBar
    Private Sub btnSaveEvent_Click(sender As Object, e As EventArgs) Handles btnSaveEvent.Click
        Try

            If String.IsNullOrEmpty(txtEventName.Text) Or String.IsNullOrEmpty(txtEventDescription.Text) Or String.IsNullOrEmpty(txtVenue.Text) Or String.IsNullOrEmpty(txtEventEnd.Text) Or String.IsNullOrEmpty(txtEventStart.Text) Or String.IsNullOrEmpty(cmbEventFor.Text) Then
                MessageBox.Show("Please fill up required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If



            Dim date_start, date_end As String
            Dim start_time As String
            Dim end_time As String
            'if selected is pm then



            start_time = cmbHourStr.Text + ":" + cmbMinutesStr.Text + " " + cmbAMPMStr.Text
            end_time = cmbHourEnd.Text + ":" + cmbMinutesEnd.Text + " " + cmbAMPMEnd.Text
            date_start = Format(CDate(txtEventStart.Text), "yyyy-MM-dd") + " " + Format(CDate(start_time), "HH:mm:ss tt")
            date_end = Format(CDate(txtEventEnd.Text), "yyyy-MM-dd") + " " + Format(CDate(end_time), "HH:mm:ss tt")

            Dim Events As New ClsEvents
            With Events
                .event_id = txtEventID.Text
                .event_name = txtEventName.Text
                .event_description = txtEventDescription.Text
                .event_venue = txtVenue.Text
                .event_datetime_start = date_start
                .event_datetime_end = date_end
                .event_status = "0"
                .event_date_created = Now().ToString("yyyy-MM-dd HH:mm:ss tt")
                .event_for = cmbEventFor.Text

                Select Case mode
                    Case Modes.add
                        .save()
                        SnackBarMessage = New MaterialSkin.Controls.MaterialSnackBar("Record successfully saved.", "OK", True)
                        SnackBarMessage.Show(Me)
                        dashboard.btnAddEvent.Enabled = False
                        btnSaveEvent.Enabled = True
                    Case Modes.edit
                        .update()
                        SnackBarMessage = New MaterialSkin.Controls.MaterialSnackBar("Record successfully updated.", "OK", True)
                        SnackBarMessage.Show(Me)
                        btnSaveEvent.Text = "SAVE"
                        MaterialLabel1.Text = "Add Event"
                        mode = Modes.add

                End Select
                initialState()
            End With

            dashboard.ShowEvents()
            dashboard.ShowEventList()
            ClearTextbox(Me)
            txtEventDescription.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtEventName_Leave(sender As Object, e As EventArgs) Handles txtEventName.Leave
        txtEventName.Text = StrConv(txtEventName.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub txtEventDescription_Leave(sender As Object, e As EventArgs) Handles txtEventDescription.Leave
        txtEventDescription.Text = StrConv(txtEventDescription.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub txtVenue_Leave(sender As Object, e As EventArgs) Handles txtVenue.Leave
        txtVenue.Text = StrConv(txtVenue.Text, VbStrConv.ProperCase)
    End Sub


End Class