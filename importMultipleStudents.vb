Imports System.IO
Public Class importMultipleStudents
    Private Sub importMultipleStudents_Load(sender As Object, e As EventArgs) Handles Me.Load
        myCustomSkin.myCustomSkin()
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Try
            Dim selectedfile As String = ""
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.InitialDirectory = "C:\"
            OpenFileDialog1.Title = "Open a Text File"
            OpenFileDialog1.Filter = "Text Files|*.csv"

            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                BunifuDataGridView1.DataSource = Nothing
                BunifuDataGridView1.Rows.Clear()
                selectedfile = Path.GetFullPath(OpenFileDialog1.FileName)


                Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedfile)

                TextFieldParser1.Delimiters = New String() {","}

                While Not TextFieldParser1.EndOfData
                    Dim Row1 As String() = TextFieldParser1.ReadFields()

                    If BunifuDataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                        Dim i As Integer

                        For i = 0 To Row1.Count - 1
                            BunifuDataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                        Next
                    End If
                    BunifuDataGridView1.Rows.Add(Row1)
                End While
                BunifuDataGridView1.Rows.RemoveAt(0)
                lblcountrec.Text = "Records: "
                lblcountrec.Text = lblcountrec.Text + BunifuDataGridView1.Rows.Count().ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim SnackBarMessage = New MaterialSkin.Controls.MaterialSnackBar
    Private Sub btnSaveMultiple_Click(sender As Object, e As EventArgs) Handles btnSaveMultiple.Click
        Try
            If BunifuDataGridView1.Columns.Count = 0 Then
                MessageBox.Show("Datagridview cannot be empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim registration As New ClsRegistration
            With registration

                For Each row As DataGridViewRow In BunifuDataGridView1.Rows
                    'If row.Cells(0).Value = True Then

                    'End If
                    .idparticipant = row.Cells(0).Value
                    .lastname = row.Cells(1).Value
                    .firstname = row.Cells(2).Value
                    .middlename = row.Cells(3).Value
                    .course = row.Cells(4).Value
                    .guardian = row.Cells(5).Value
                    .contactno = row.Cells(6).Value
                    .reg_at = Now().ToString("yyyy-MM-dd HH:mm:ss")
                    .save()
                Next
                SnackBarMessage = New MaterialSkin.Controls.MaterialSnackBar("Record successfully saved.", "OK", True)
                SnackBarMessage.Show(Me)
                dashboard.ShowRegistration()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class