Public Class filterReports
    Private Sub filterReports_Load(sender As Object, e As EventArgs) Handles Me.Load
        myCustomSkin.myCustomSkin()
        If dashboard.cmbReportType.SelectedIndex = 2 Or dashboard.cmbReportType.SelectedIndex = 3 Then
            With cmbCriteria
                .DataSource = Nothing
                .Items.Clear()
                Dim str As String = String.Format("SELECT idparticipant as id, concat(lastname, ', ',firstname, ' ', middlename) as Student_Name, COURSE as Course,  date_format(REG_AT,'%b %d %Y %h:%i %p') AS `DATE REGISTERED` FROM conferencedb.participants order by lastname asc")
                .DataSource = ClsConn.LoadData(str).DefaultView
                .ValueMember = "id"
                .DisplayMember = "Student_Name"

            End With
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.Close()
    End Sub

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged
        If cbAll.Checked = True Then
            With cmbCriteria
                .DataSource = Nothing
                .Items.Clear()
                .Items.Add("All")
                .SelectedIndex = 0
                .Enabled = False
            End With
        End If
        If cbAll.Checked = False Then
            With cmbCriteria
                .Enabled = True
                .DataSource = Nothing
                .Items.Clear()
                Dim str As String = String.Format("SELECT idparticipant as id, concat(lastname, ', ',firstname, ' ', middlename) as Student_Name, COURSE as Course,  date_format(REG_AT,'%b %d %Y %h:%i %p') AS `DATE REGISTERED` FROM conferencedb.participants order by lastname asc")
                .DataSource = ClsConn.LoadData(str).DefaultView
                .ValueMember = "id"
                .DisplayMember = "Student_Name"

            End With
        End If
    End Sub
End Class