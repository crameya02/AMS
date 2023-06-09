
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class manageUsers

    Dim st1 As String
    Sub Reset()
        txtUserEmail.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        txtUserPassword.Text = ""
        txtUserName.Text = ""
        txtUserName.Enabled = True
        cmbUserType.SelectedIndex = -1
        cmbUserType.Focus()
        lblvalidemail.Text = "*"
        lblAvailable.Text = "*"
        btnSaveUser.Enabled = True
        btnUpdateUser.Enabled = False
        btnDeleteUser.Enabled = False
    End Sub



    Private Sub DeleteRecord()

        Try
            If dgw.Rows.Count = 1 Then
                MessageBox.Show("Account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim RowsAffected As Integer = 0
            If (ClsConn.OpenConnection() = True) Then

                Dim cq As String = "delete from users where UserName=@d1"
                cmd = New MySqlCommand(cq, sqlCon)
                cmd.Parameters.AddWithValue("@d1", txtUserName.Text)

                RowsAffected = cmd.ExecuteNonQuery()
                If RowsAffected > 0 Then
                    Dim st As String = "deleted the user '" & txtUserName.Text & "'"

                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Getdata()
                    Reset()
                Else
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Reset()
                End If
                ClsConn.CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Public Sub Getdata()
        Try
            If (ClsConn.OpenConnection() = True) Then
                cmd = New MySqlCommand("SELECT RTRIM(FirstName), RTRIM(LastName), RTRIM(UserEmail), RTRIM(UserName), RTRIM(UserPassword), RTRIM(UserType),DateAdded,DateUpdated from users where Not UserName='DefaultUser' and Not UserName='MasterAdmin' order by DateAdded", sqlCon)
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw.Rows.Clear()
                While (rdr.Read() = True)
                    dgw.Rows.Add(rdr(0), rdr(1), (rdr(2)), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7))
                End While

                ClsConn.CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgw_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Dim oldpass As String = ""

    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            If dgw.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgw.SelectedRows(0)
                txtFname.Text = dr.Cells(0).Value.ToString()
                txtLname.Text = dr.Cells(1).Value.ToString()
                txtUserEmail.Text = dr.Cells(2).Value.ToString()
                txtUserEmail_Validating(txtUserEmail, Nothing)
                txtUserName.Text = dr.Cells(3).Value.ToString()
                txtUserPassword.Text = Decrypt(dr.Cells(4).Value.ToString())
                oldpass = Decrypt(dr.Cells(4).Value.ToString())
                Dim userType As String = dr.Cells(5).Value.ToString()

                If userType = "1" Then
                    cmbUserType.Text = "Admin"
                    cmbUserType.Select()
                End If
                If userType = "0" Then
                    cmbUserType.Text = "User"
                    cmbUserType.Select()
                End If
                cmbUserType.Text = dr.Cells(5).Value.ToString()
                st1 = dr.Cells(2).Value.ToString()
                btnUpdateUser.Enabled = True
                btnDeleteUser.Enabled = True
                btnSaveUser.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        Try
            If (ClsConn.OpenConnection() = True) Then
                Dim ct As String = "select userName from users where userName=@d1"
                cmd = New MySqlCommand(ct, sqlCon)
                cmd.Parameters.AddWithValue("@d1", txtUserName.Text)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    ' MessageBox.Show("User Name already taken", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If txtUserName.Text IsNot Nothing Then
                        lblAvailable.Text = "*User Name already taken."
                    End If
                    If txtUserName.Text = "" Then
                        lblAvailable.Text = "*"
                    End If

                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                Else
                    'MessageBox.Show("User ID available", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If txtUserName.Text IsNot Nothing Then
                        lblAvailable.Text = "✓"
                    End If
                    If txtUserName.Text = "" Then
                        lblAvailable.Text = "*"
                    End If

                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                End If
                ClsConn.CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateUser.Click
        Try

            If lblAvailable.Text.Length > 1 Or lblvalidemail.Text.Length > 1 Then
                MessageBox.Show("Unable to save. Please check fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If txtFname.Text = "" Then
                MessageBox.Show("Please enter First Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtFname.SelectAll()
                txtFname.Select()
                Return
            End If
            If txtLname.Text = "" Then
                MessageBox.Show("Please enter Last Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtLname.SelectAll()
                txtLname.Select()
                Return
            End If
            If txtUserEmail.Text = "" Then
                MessageBox.Show("Please enter email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserEmail.SelectAll()
                txtUserEmail.Select()
                Return
            End If
            txtUserName.Enabled = False
            If txtUserPassword.Text = "" Then
                MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserPassword.SelectAll()
                txtUserPassword.Select()
                Return
            End If
            If Len(Trim(txtConfirmPassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtConfirmPassword.SelectAll()
                txtConfirmPassword.Focus()
                Exit Sub
            End If
            If txtUserPassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserPassword.Text = ""
                txtConfirmPassword.Text = ""
                txtUserPassword.SelectAll()
                txtUserPassword.Focus()
                Exit Sub
            ElseIf txtUserPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserPassword.Text = ""
                txtUserPassword.Text = ""
                txtConfirmPassword.Text = ""
                txtConfirmPassword.SelectAll()
                txtConfirmPassword.Focus()
                Exit Sub
            ElseIf oldpass = txtUserPassword.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserPassword.Text = ""
                txtConfirmPassword.Text = ""
                txtUserPassword.SelectAll()
                txtUserPassword.Focus()
                Exit Sub
            End If

            If st1 <> txtUserEmail.Text Then
                If (ClsConn.OpenConnection() = True) Then
                    Dim ct2 As String = "select UserEmail from users where UserEmail=@d1"
                    cmd = New MySqlCommand(ct2, sqlCon)
                    cmd.Parameters.AddWithValue("@d1", txtUserEmail.Text)
                    rdr = cmd.ExecuteReader()
                    If rdr.Read() Then
                        MessageBox.Show("Email Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                        txtUserEmail.SelectAll()
                        txtUserEmail.Select()
                        If (rdr IsNot Nothing) Then
                            rdr.Close()
                        End If
                        Return
                    End If
                    ClsConn.CloseConnection()

                End If
            End If

            If (ClsConn.OpenConnection() = True) Then
                Dim cb As String = "update users set FirstName=@d1, LastName=@d2,UserEmail=@d3,UserPassword=@d4,UserType=@d5,DateAdded=@d6 where UserName=@d7"
                cmd = New MySqlCommand(cb, sqlCon)
                cmd.Parameters.AddWithValue("@d1", txtFname.Text)
                cmd.Parameters.AddWithValue("@d2", txtLname.Text)
                cmd.Parameters.AddWithValue("@d3", txtUserEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@d4", Encrypt(txtUserPassword.Text.Trim()))
                Dim UserType As String
                If cmbUserType.Text = "Admin" Then
                    UserType = "1"
                Else
                    UserType = "0"
                End If
                cmd.Parameters.AddWithValue("@d5", UserType)
                cmd.Parameters.AddWithValue("@d6", Now)
                cmd.Parameters.AddWithValue("@d7", txtUserName.Text)
                cmd.ExecuteReader()
                ClsConn.CloseConnection()
            End If
            MessageBox.Show("Successfully updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdateUser.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnDeleteUser_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteUser.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveUser_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveUser.Click
        If lblAvailable.Text.Length > 1 Or lblvalidemail.Text.Length > 1 Then
            MessageBox.Show("Unable to save. Please check fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtFname.Text = "" Then
            MessageBox.Show("Please enter First Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFname.SelectAll()
            txtFname.Select()
            Return
        End If
        If txtLname.Text = "" Then
            MessageBox.Show("Please enter Last Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLname.SelectAll()
            txtLname.Select()
            Return
        End If
        If txtUserEmail.Text = "" Then
            MessageBox.Show("Please enter email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserEmail.SelectAll()
            txtUserEmail.Select()
            Return
        End If
        If txtUserName.Text = "" Then
            MessageBox.Show("Please enter User Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserName.SelectAll()
            txtUserName.Select()
            Return
        End If
        If txtUserPassword.Text = "" Then
            MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserPassword.SelectAll()
            txtUserPassword.Select()
            Return
        End If

        If Len(Trim(txtConfirmPassword.Text)) = 0 Then
            MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPassword.SelectAll()
            txtConfirmPassword.Focus()
            Exit Sub
        End If
        If txtUserPassword.TextLength < 5 Then
            MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtUserPassword.SelectAll()
            txtUserPassword.Focus()
            Exit Sub
        End If
        If txtUserPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserPassword.Text = ""
            txtUserPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtConfirmPassword.SelectAll()
            txtConfirmPassword.Focus()
            Exit Sub
        End If

        Try
            If (ClsConn.OpenConnection() = True) Then

                Dim ct As String = "select UserName from users where UserName=@d1"
                cmd = New MySqlCommand(ct, sqlCon)
                cmd.Parameters.AddWithValue("@d1", txtUserName.Text)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    MessageBox.Show("User Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    txtUserName.Text = ""
                    txtUserName.SelectAll()
                    txtUserName.Select()

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
                cmd.Parameters.AddWithValue("@d1", txtUserEmail.Text)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    MessageBox.Show("Email Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                End If
                ClsConn.CloseConnection()
            End If

            If (ClsConn.OpenConnection() = True) Then

                Dim cb As String = "insert into users(FirstName, LastName, UserEmail, UserPassword, UserType, DateAdded,UserName) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)"
                cmd = New MySqlCommand(cb, sqlCon)
                cmd.Parameters.AddWithValue("@d1", txtFname.Text)
                cmd.Parameters.AddWithValue("@d2", txtLname.Text)
                cmd.Parameters.AddWithValue("@d3", txtUserEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@d4", Encrypt(txtUserPassword.Text.Trim()))
                Dim UserType As String
                If cmbUserType.Text = "Admin" Then
                    UserType = "1"
                Else
                    UserType = "0"
                End If
                cmd.Parameters.AddWithValue("@d5", UserType)
                cmd.Parameters.AddWithValue("@d6", Now)
                cmd.Parameters.AddWithValue("@d7", txtUserName.Text)
                cmd.ExecuteReader()
                ClsConn.CloseConnection()
            End If
            MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSaveUser.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnNewUser_Click(sender As System.Object, e As System.EventArgs) Handles btnNewUser.Click
        Reset()
    End Sub

    Private Sub dgw_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgw.CellFormatting
        If (e.ColumnIndex = 4) AndAlso e.Value IsNot Nothing Then
            dgw.Rows(e.RowIndex).Tag = e.Value
            e.Value = New [String]("●"c, e.Value.ToString().Length)
        End If
        If (e.ColumnIndex = 5) AndAlso e.Value IsNot Nothing Then
            dgw.Rows(e.RowIndex).Tag = e.Value
            If e.Value = "1" Then
                e.Value = "Admin"
            Else
                e.Value = "User"
            End If

        End If
    End Sub
    Private Sub manageUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Getdata()
    End Sub

    Private Sub dgw_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgw.EditingControlShowing
        If dgw.CurrentCell.ColumnIndex = 2 Then
            'select target column
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                textBox.UseSystemPasswordChar = True
            End If
        Else
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                textBox.UseSystemPasswordChar = False
            End If
        End If
    End Sub



    Private Sub txtUserEmail_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserEmail.KeyPress
        Dim ac As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If ac.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True

                        Else

                            If txtUserEmail.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If

                        End If


                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txtUserEmail_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtUserEmail.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtUserEmail.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            lblvalidemail.Text = "*"
        Else
            lblvalidemail.Text = "*Please enter a valid email id"
        End If
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

    Private Sub txtUserName_Click(sender As Object, e As EventArgs) Handles txtUserName.Click

    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        If btnSaveUser.Enabled = False Then
            txtUserName.Enabled = False
        Else
            txtUserName.Enabled = True
        End If
    End Sub
End Class


