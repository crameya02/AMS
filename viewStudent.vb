Imports ZXing
Imports ZXing.QrCode

Public Class viewStudent

    Private Sub btnSaveQR_Click(sender As Object, e As EventArgs) Handles btnSaveQR.Click
        'download qr code
        If PictureBox2.Image Is Nothing Then
            MessageBox.Show("Image not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim save As SaveFileDialog = New SaveFileDialog()
            save.CreatePrompt = True
            save.OverwritePrompt = True
            save.FileName = txtLName.Text & ", " & txtFName.Text & " " & txtMName.Text & " (" & txtCourse.Text & ")"
            save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif"

            If save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                PictureBox2.Image.Save(save.FileName)
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            End If
        End If


        'Dim SD As New SaveFileDialog
        'SD.FileName = "Qrcode"
        'SD.Filter = "PNG Files only (*.png)|*.png"
        'If SD.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Try
        '        PictureBox2.Image.Save(SD.FileName, System.Drawing.Imaging.ImageFormat.Png)
        '        MessageBox.Show("Successfully Saved")
        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Private Sub viewStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        'https://www.codeproject.com/Articles/1005081/Basic-with-QR-Code-using-Zxing-Library
        'encode qr
        Dim options = New QrCodeEncodingOptions With {
        .DisableECI = True,
        .CharacterSet = "UTF-8",
        .Width = 250,
        .Height = 250
    }
        Dim writer = New BarcodeWriter()
        writer.Format = BarcodeFormat.QR_CODE
        writer.Options = options

        If String.IsNullOrWhiteSpace(txtQrCode.Text) OrElse String.IsNullOrEmpty(txtQrCode.Text) Then
            PictureBox2.Image = Nothing
            MessageBox.Show("Text not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim qr = New ZXing.BarcodeWriter()
            qr.Options = options
            qr.Format = ZXing.BarcodeFormat.QR_CODE
            Dim result = New Bitmap(qr.Write(txtQrCode.Text.Trim()))
            PictureBox2.Image = result

        End If
        'Dim QRWriter As New BarcodeWriter
        'QRWriter.Format = BarcodeFormat.QR_CODE
        'PictureBox2.Image = QRWriter.Write(txtQRCode.Text)

        ''decode qr
        'Try
        '    Dim bitmap As Bitmap = New Bitmap(PictureBox2.Image)
        '    Dim reader As BarcodeReader = New BarcodeReader With {
        '        .AutoRotate = True,
        '        .TryInverted = True
        '    }
        '    Dim result As Result = reader.Decode(bitmap)
        '    Dim decoded As String = result.ToString().Trim()
        '    MsgBox(decoded)
        '    ' txtQRCode.Text = decoded
        'Catch __unusedException1__ As Exception
        '    MessageBox.Show("Image not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        'End Try
        ''browse image to decode
        'Dim open As OpenFileDialog = New OpenFileDialog()

        'If open.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Dim qr = New ZXing.BarcodeWriter()
        '    qr.Options = options
        '    qr.Format = ZXing.BarcodeFormat.QR_CODE
        '    PictureBox2.ImageLocation = open.FileName
        'End If
    End Sub
End Class