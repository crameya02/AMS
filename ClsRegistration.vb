Imports CrystalDecisions.ReportAppServer.CommonControls
Imports MySql.Data.MySqlClient
Public Class ClsRegistration
    Public Property idparticipant As String
    Public Property lastname As String
    Public Property firstname As String
    Public Property middlename As String
    Public Property course As String
    Public Property contactno As String
    Public Property guardian As String
    Public Property reg_at As String
    Public Property imgpath As String





    Public Sub save()
        If (ClsConn.OpenConnection() = True) Then
            Dim mstream As New System.IO.MemoryStream()
            manageStudents.pbImage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()

            cmd = New MySqlCommand("INSERT INTO participants VALUES(@idparticipant, @lastname, @firstname, @middlename,@course, @contactno, @reg_at, @guardian, @studimg)", sqlCon)
            cmd.Parameters.AddWithValue("@idparticipant", idparticipant)
            cmd.Parameters.AddWithValue("@lastname", lastname)
            cmd.Parameters.AddWithValue("@firstname", firstname)
            cmd.Parameters.AddWithValue("@middlename", middlename)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@contactno", contactno.Replace("-", ""))
            cmd.Parameters.AddWithValue("@reg_at", reg_at)
            cmd.Parameters.AddWithValue("@guardian", guardian)
            cmd.Parameters.AddWithValue("@studimg", arrImage)

            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub

    Public Sub update()
        If (ClsConn.OpenConnection() = True) Then
            Dim mstream As New System.IO.MemoryStream()
            manageStudents.pbImage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            cmd = New MySqlCommand("UPDATE participants SET lastname=@lastname, firstname=@firstname, middlename=@middlename,course=@course, contactno=@contactno, reg_at=@reg_at, guardian=@guardian, studimg=@studimg  WHERE idparticipant=@idparticipant", sqlCon)
            cmd.Parameters.AddWithValue("@idparticipant", idparticipant)
            cmd.Parameters.AddWithValue("@lastname", lastname)
            cmd.Parameters.AddWithValue("@firstname", firstname)
            cmd.Parameters.AddWithValue("@middlename", middlename)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@contactno", contactno.Replace("-", ""))
            cmd.Parameters.AddWithValue("@reg_at", reg_at)
            cmd.Parameters.AddWithValue("@guardian", guardian)
            cmd.Parameters.AddWithValue("@studimg", arrImage)

            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub

    Public Sub delete(ByVal id As String)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New MySqlCommand("delete from participants where idparticipant=@id", sqlCon)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub
End Class
