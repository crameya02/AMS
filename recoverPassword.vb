
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class recoverPassword
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean

    Private Sub recoverPassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        myCustomSkin.myCustomSkin()
    End Sub

    Private Sub bntSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMail.Click
        Try
            If txtEmailID.Text = "" Then
                MessageBox.Show("Please enter Email ID", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmailID.Focus()
                Exit Sub
            End If
            If (ClsConn.OpenConnection() = True) Then
                Dim sql As String = "select count(*) from EmailSetting Having count(*) <=0"
                cmd = New MySqlCommand(sql, sqlCon)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    MsgBox("Sender email not defined. Please check your settings folder or contact system Administrator.")
                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                End If
                ClsConn.CloseConnection()
            End If
            If (ClsConn.OpenConnection() = True) Then

                Dim ct2 As String = "select UserEmail from users where UserEmail=@d1"
                cmd = New MySqlCommand(ct2, sqlCon)
                cmd.Parameters.AddWithValue("@d1", txtEmailID.Text)

                rdr = cmd.ExecuteReader()
                If Not rdr.Read() Then
                    MsgBox("Email does not exist in our records.")
                    txtEmailID.Text = ""
                    txtEmailID.Focus()
                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                End If
                ClsConn.CloseConnection()
            End If
            If CheckForInternetConnection() = True Then
                Cursor = Cursors.WaitCursor
                Timer2.Enabled = True
                Dim ds = New DataSet()
                If (ClsConn.OpenConnection() = True) Then

                    Dim cmd As New MySqlCommand("SELECT UserPassword FROM users Where UserEmail='" & txtEmailID.Text & "'", sqlCon)
                    Dim da As New MySqlDataAdapter(cmd)
                    da.Fill(ds)

                    If ds.Tables(0).Rows.Count > 0 Then


                        Dim ctn As String = "select Username,UserPassword,SMTPAddress,Port from emailsetting where IsDefault='Yes' and IsActive='Yes'"
                        cmd = New MySqlCommand(ctn, sqlCon)

                        rdr = cmd.ExecuteReader()
                        If rdr.Read() Then

                            'MsgBox(Decrypt(rdr.GetValue(1)))
                            SendMail(rdr.GetValue(0), txtEmailID.Text, "Your Password: " & Decrypt(Convert.ToString(ds.Tables(0).Rows(0)("UserPassword"))) & "", "Password", rdr.GetValue(2), rdr.GetValue(3), rdr.GetValue(0), Decrypt(rdr.GetValue(1)))
                            MessageBox.Show("Password Successfully sent " & vbCrLf & "Please check your mail", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If (rdr IsNot Nothing) Then
                                rdr.Close()
                            End If
                        End If
                    End If

                    Me.Hide()
                    login.Show()
                    login.txtUserName.Clear()
                    login.txtPassword.Clear()
                    login.txtUserName.Focus()
                End If
                ClsConn.CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub OSKeyboard()
            Dim old As Long
            If Environment.Is64BitOperatingSystem Then
                If Wow64DisableWow64FsRedirection(old) Then
                    Process.Start("osk.exe")
                    Wow64EnableWow64FsRedirection(old)
                End If
            Else
                Process.Start("osk.exe")
            End If
        End Sub
    Private Sub recoverPassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        login.Show()
        login.txtUserName.Clear()
        login.txtPassword.Clear()
        login.txtUserName.Focus()
    End Sub



    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        login.Show()
        login.txtUserName.Clear()
        login.txtPassword.Clear()
        login.txtUserName.Focus()
    End Sub




    Private Sub txtEmailID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmailID.KeyPress, txtVerPass.KeyPress, txtVerNewPass.KeyPress
        Dim ac As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If ac.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True

                        Else

                            If txtEmailID.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If

                        End If


                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txtEmailID_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmailID.Validating, txtVerPass.Validating, txtVerNewPass.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtEmailID.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
        Else
            MessageBox.Show("Please enter a valid email id", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmailID.Clear()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Cursor = Cursors.Default
        Timer2.Enabled = False
    End Sub
    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Public Sub SendMail(ByVal s1 As String, ByVal s2 As String, ByVal s3 As String, ByVal s5 As String, ByVal s6 As String, ByVal s7 As Integer, ByVal s8 As String, ByVal s9 As String)
        Dim msg As New MailMessage()
        Try
            msg.From = New MailAddress(s1)
            msg.[To].Add(s2)
            msg.Body = s3
            msg.IsBodyHtml = True
            msg.Subject = s5
            Dim smt As New SmtpClient(s6)
            smt.Port = s7
            smt.DeliveryMethod = smt.DeliveryMethod.Network
            smt.Credentials = New NetworkCredential(s8, s9)
            smt.EnableSsl = True
            smt.Send(msg)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub MaterialExpansionPanel1_SaveClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel1.SaveClick
        'Try
        '    If txtVerPass.Text = "" Then
        '        MessageBox.Show("Please enter New Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        txtVerPass.Focus()
        '        Return
        '    End If
        '    If txtVerNewPass.Text = "" Then
        '        MessageBox.Show("Please verify New Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        txtVerNewPass.Focus()
        '        Return
        '    End If

        '    If txtVerPass.Text <> txtVerNewPass.Text Then
        '        MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        '        Return
        '    End If
        '    con = New SqlConnection(cs)
        '    con.Open()
        '     Dim cb As String = "update registration set userid=@d1, usertype=@d2,password=@d3,name=@d4,contactno=@d5,emailid=@d6,Active=@d8 where userid=@d7"
        '    Dim cb As String = "update registration set password=@d1 where emailid=@d2"
        '    cmd = New SqlCommand(cb)
        '    cmd.Connection = con
        '    cmd.Parameters.AddWithValue("@d2", SendCode.txtEmail.Text)
        '    cmd.Parameters.AddWithValue("@d1", Encrypt(txtVerPass.Text.Trim()))
        '    cmd.ExecuteReader()
        '    con.Close()
        '    Dim st As String = "updated the user '" & SendCode.txtEmail.Text & "' details"
        '    LogFunc(SendCode.txtEmail.Text, st)
        '    MessageBox.Show("Successfully updated password", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        'End Try
    End Sub
End Class

