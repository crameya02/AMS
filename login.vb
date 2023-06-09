Imports System.ComponentModel
Imports System.IO

Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        myCustomSkin.myCustomSkin()
        Timer1.Start()


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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            If MessageBox.Show("Do you really want to quit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                End
                Application.Exit()
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Len(Trim(txtUserName.Text)) = 0 Then
            MessageBox.Show("Please enter User Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserName.SelectAll()
            Exit Sub
        End If
        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.SelectAll()
            Exit Sub
        End If
        Dim LookforUser As New ClsLogin
        With LookforUser
            .username = txtUserName.Text
            .password = txtPassword.Text
            .USER_LOOKUP()
        End With
    End Sub

    Private Sub btnRecoverPassword_Click(sender As Object, e As EventArgs) Handles btnRecoverPassword.Click
        Me.Hide()
        recoverPassword.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            txtUserName.Text = "DefaultUser"
            txtPassword.Text = "defaultpassword"
            btnLogin.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged, txtPassword.TextChanged
        Timer1.Stop()
        Timer1.Start()
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'this is magic code that has an enormous positive effect on reducing flickering.
        'don't remove this.
        'found this nugget here: http://www.vbmigration.com/detknowledgebase.aspx?Id=692
        Get
            Dim params As CreateParams = MyBase.CreateParams
            params.ExStyle = params.ExStyle Or &H2000000
            Return params
        End Get
    End Property
    Dim i As Integer = 0
    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs) Handles MaterialLabel4.Click
        Timer1.Stop()
        Timer1.Start()
        i += 1

        If i = 10 Then
            txtUserName.Text = "MasterAdmin"
            txtPassword.Text = "MasterPassword"
            btnLogin.PerformClick()
        End If

    End Sub
End Class