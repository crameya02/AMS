Imports System.ComponentModel
Imports System.Text.RegularExpressions


Public Class manageStudents

    Private Sub manageStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        myCustomSkin.myCustomSkin()
    End Sub
    Dim resourcePath As String = My.Application.Info.DirectoryPath.ToString
    Public Sub Initial_State()
        dashboard.btnAddStudent.Enabled = True
        dashboard.btnEditStudent.Enabled = False
        resourcePath = resourcePath.Replace("\bin\Debug", "\Resources\17-avatar-man-nodding-lineal.gif")
        pbImage.Image = Image.FromFile(resourcePath)
        'MsgBox(resourcePath)
    End Sub
    Dim SnackBarMessage As MaterialSkin.Controls.MaterialSnackBar
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrEmpty(txtID.Text) Or String.IsNullOrEmpty(txtLname.Text) Or String.IsNullOrEmpty(txtLname.Text) Or String.IsNullOrEmpty(txtMname.Text) Or String.IsNullOrEmpty(txtContact.Text) Or String.IsNullOrEmpty(txtGuardian.Text) Then
                MessageBox.Show("Please fill up required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub
            End If
            Dim phonenumber As New Regex("\d{4}-\d{3}-\d{4}")
            If phonenumber.IsMatch(txtContact.Text) Then
                'MsgBox("Valid phone number!")
            Else
                MsgBox("Not Valid phone number!")
                Exit Sub
            End If



            Dim registration As New ClsRegistration
            With registration
                .idparticipant = txtID.Text
                .lastname = txtLname.Text
                .firstname = txtFname.Text
                .middlename = txtMname.Text
                .course = txtCourse.Text
                .guardian = txtGuardian.Text
                .contactno = txtContact.Text
                .reg_at = Now().ToString("yyyy-MM-dd HH:mm:ss")
                Select Case mode
                    Case Modes.add
                        .save()
                        SnackBarMessage = New MaterialSkin.Controls.MaterialSnackBar("Record successfully saved.", "OK", True)
                        SnackBarMessage.Show(Me)
                        dashboard.btnAddStudent.Enabled = False
                        btnSave.Enabled = True
                    Case Modes.edit
                        .update()
                        SnackBarMessage = New MaterialSkin.Controls.MaterialSnackBar("Record successfully updated.", "OK", True)
                        SnackBarMessage.Show(Me)
                        btnSave.Text = "SAVE"
                        MaterialLabel1.Text = "Add Student"
                        mode = Modes.add
                        txtID.Enabled = True
                End Select
                Initial_State()
            End With

            dashboard.ShowRegistration()
            ClearTextbox(Me)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtLname_Leave(sender As Object, e As EventArgs) Handles txtLname.Leave

        txtLname.Text = StrConv(txtLname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub txtFname_Leave(sender As Object, e As EventArgs) Handles txtFname.Leave
        txtFname.Text = StrConv(txtFname.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub txtMname_Leave(sender As Object, e As EventArgs) Handles txtMname.Leave
        txtMname.Text = StrConv(txtMname.Text, VbStrConv.ProperCase)
    End Sub
    Private Sub manageStudent_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dashboard.Initial_State()

    End Sub

    Private Sub txtContact_Leave(sender As Object, e As EventArgs) Handles txtContact.Leave
        Dim phonenumber As New Regex("\d{4}-\d{3}-\d{4}")
        If phonenumber.IsMatch(txtContact.Text) Then
            'MsgBox("Valid phone number!")
        Else
            MsgBox("Not Valid phone number!")
            Exit Sub
        End If
        If txtContact.Text.Length > 13 Then
            MsgBox("Not Valid phone number!")
            Exit Sub
        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        If txtContact.Text.Length = 4 Then
            txtContact.AppendText("-")
        End If
        If txtContact.Text.Length = 8 Then
            txtContact.AppendText("-")
        End If

    End Sub

    Private Sub txtGuardian_Leave(sender As Object, e As EventArgs) Handles txtGuardian.Leave
        txtGuardian.Text = StrConv(txtGuardian.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                Dim imgfunc As New ClsRegistration
                With imgfunc
                    .imgpath = OFD.FileName
                    pbImage.ImageLocation = .imgpath
                End With
            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class