Public Class splash
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        myCustomSkin.myCustomSkin()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Hard coded loading only. You can implements system load if you want
            MaterialProgressBar1.Visible = True
            MaterialProgressBar1.Value = MaterialProgressBar1.Value + 1
            If (MaterialProgressBar1.Value = 10) Then
                lblSet.Text = "Reading modules.."
            ElseIf (MaterialProgressBar1.Value = 20) Then
                lblSet.Text = "Turning on modules."
            ElseIf (MaterialProgressBar1.Value = 40) Then
                lblSet.Text = "Starting modules.."
            ElseIf (MaterialProgressBar1.Value = 60) Then
                lblSet.Text = "Loading modules.."
            ElseIf (MaterialProgressBar1.Value = 80) Then
                lblSet.Text = "Done Loading modules.."
            ElseIf (MaterialProgressBar1.Value = 100) Then
                Timer1.Enabled = False
                Me.Hide()
                login.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                login.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub
End Class
