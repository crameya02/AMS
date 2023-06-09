Imports MySql.Data.MySqlClient
Public Class ClsLogin
    Public Property username As String
    Public Property password As String
    Public Property userRole As String
    Public Property firstName As String
    Public Property lastName As String
    Public Property userEmail As String
    Public Property oldpassword As String

    Public Sub USER_LOOKUP()
        Try
            If (ClsConn.OpenConnection() = True) Then
                cmd = sqlCon.CreateCommand()
                cmd.CommandText = "SELECT UserName,UserPassword,UserType FROM users where 
UserName = @d1 and UserPassword=@d2"
                cmd.Parameters.AddWithValue("@d1", username)
                cmd.Parameters.AddWithValue("@d2", Encrypt(password))
                Dim rdr As MySqlDataReader
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    userRole = rdr.GetValue(2).ToString
                    'dashboard.UserType.Text = rdr.GetValue(0).ToString.Trim
                    Dim st As String = "Successfully logged in" & userRole
                    'LogFunc(UserID.Text, st)
                    ' MsgBox(st)
                    login.Hide()
                    dashboard.Show()
                    login.Timer1.Enabled = False
                Else
                    MsgBox("Login Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                End If
                cmd.Dispose()
                ClsConn.CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub updatePassword()
        If (ClsConn.OpenConnection() = True) Then
            cmd = New MySqlCommand("update users set UserPassword=@UserPassword where UserName=@UserName and UserPassword=@oldpassword", sqlCon)
            cmd.Parameters.AddWithValue("@UserPassword", Encrypt(password))
            cmd.Parameters.AddWithValue("@UserName", username)
            cmd.Parameters.AddWithValue("@oldpassword", Encrypt(oldpassword))
            Dim RowsAffected As Integer = 0
            RowsAffected = cmd.ExecuteNonQuery()


            If RowsAffected > 0 Then
                Dim st As String = "Successfully changed the password"
                MessageBox.Show(st, "Task completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'LogFunc(UserID.Text, st)
                'frmCustomDialog2.ShowDialog()
                'Me.Hide()
                'frmLogin.Show()
                'frmLogin.UserID.Text = ""
                'frmLogin.Password.Text = ""
                'frmLogin.UserID.Focus()
            Else
                MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dashboard.txtnewpassword.Text = ""
                dashboard.txtnewpassword.Text = ""
                dashboard.txtconfirmpassword.Text = ""
            End If
            ClsConn.CloseConnection()
        End If
    End Sub

    Public Sub save()
        If (ClsConn.OpenConnection() = True) Then
            mode = Modes.add
            cmd = New MySqlCommand("INSERT INTO users VALUES(@firstName,@lastName, @userEmail, @userName, @userPassword, @userType)", sqlCon)
            cmd.Parameters.AddWithValue("@firstName", firstName)
            cmd.Parameters.AddWithValue("@lastName", lastName)
            cmd.Parameters.AddWithValue("@userEmail", userEmail)
            cmd.Parameters.AddWithValue("@userName", username)
            cmd.Parameters.AddWithValue("@userPassword", password)
            cmd.Parameters.AddWithValue("@userType", userRole)

            cmd.ExecuteNonQuery()
            dashboard.ShowAttendance(dashboard.cmbEventList.SelectedValue.ToString)


            MsgBox("Welcome : " & username, vbInformation)


            ClsConn.CloseConnection()
        End If
    End Sub

    'Public Sub update()
    '    If (ClsConn.OpenConnection() = True) Then
    '        cmd = New MySqlCommand("UPDATE participants SET lastname=@lastname, firstname=@firstname, middlename=@middlename, contactno=@contactno, reg_at=@reg_at  WHERE idparticipant=@idparticipant", sqlCon)
    '        cmd.Parameters.AddWithValue("@idparticipant", idparticipant)
    '        cmd.Parameters.AddWithValue("@lastname", lastname)
    '        cmd.Parameters.AddWithValue("@firstname", firstname)
    '        cmd.Parameters.AddWithValue("@middlename", middlename)
    '        cmd.Parameters.AddWithValue("@contactno", contactno)
    '        ' cmd.Parameters.AddWithValue("@idgroup", idgroup)
    '        cmd.Parameters.AddWithValue("@reg_at", reg_at)


    '        cmd.ExecuteNonQuery()
    '        ClsConn.CloseConnection()
    '    End If
    'End Sub

    'Public Sub delete(ByVal id As Integer)
    '    If (ClsConn.OpenConnection() = True) Then
    '        cmd = New MySqlCommand("DELETE FROM product WHERE idproduct=@id", sqlCon)
    '        cmd.Parameters.AddWithValue("@idparticipant", idparticipant)
    '        cmd.ExecuteNonQuery()
    '        ClsConn.CloseConnection()
    '    End If
    'End Sub
End Class
