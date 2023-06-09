Imports MySql.Data.MySqlClient
Public Class ClsEvents
    Public Property event_id As String
    Public Property event_datetime_start As String
    Public Property event_datetime_end As String
    Public Property event_name As String
    Public Property event_description As String
    Public Property event_venue As String
    Public Property event_status As String
    Public Property event_date_created As String
    Public Property event_for As String


    Public Sub save()
        If (ClsConn.OpenConnection() = True) Then
            cmd = New MySqlCommand("INSERT INTO events VALUES(@event_id,@event_datetime_start, @event_datetime_end, @event_name, @event_description, @event_venue, @event_status, @event_date_created, @event_for)", sqlCon)
            cmd.Parameters.AddWithValue("@event_id", event_id)
            cmd.Parameters.AddWithValue("@event_name", event_name)
            cmd.Parameters.AddWithValue("@event_description", event_description)
            cmd.Parameters.AddWithValue("@event_venue", event_venue)
            cmd.Parameters.AddWithValue("@event_datetime_start", event_datetime_start)
            cmd.Parameters.AddWithValue("@event_datetime_end", event_datetime_end)
            cmd.Parameters.AddWithValue("@event_status", event_status)
            cmd.Parameters.AddWithValue("@event_date_created", event_date_created)
            cmd.Parameters.AddWithValue("@event_for", event_for)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub

    Public Sub update()
        If (ClsConn.OpenConnection() = True) Then
            cmd = New MySqlCommand("UPDATE events SET event=@event_name, description=@event_description, venue=@event_venue,event_datetime_start=@event_datetime_start, event_datetime_end=@event_datetime_end, status=@event_status, date_created=@event_date_created, event_for=@event_for  WHERE id=@event_id", sqlCon)
            cmd.Parameters.AddWithValue("@event_id", event_id)
            cmd.Parameters.AddWithValue("@event_name", event_name)
            cmd.Parameters.AddWithValue("@event_description", event_description)
            cmd.Parameters.AddWithValue("@event_venue", event_venue)
            cmd.Parameters.AddWithValue("@event_datetime_start", event_datetime_start)
            cmd.Parameters.AddWithValue("@event_datetime_end", event_datetime_end)
            cmd.Parameters.AddWithValue("@event_status", event_status)
            cmd.Parameters.AddWithValue("@event_date_created", event_date_created)
            cmd.Parameters.AddWithValue("@event_for", event_for)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub

    Public Sub delete(ByVal id As Integer)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New MySqlCommand("DELETE FROM events WHERE event_id=@event_id", sqlCon)
            cmd.Parameters.AddWithValue("@event_id", event_id)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub
End Class


