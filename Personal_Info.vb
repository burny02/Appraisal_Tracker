Public Class Personal_Info

    Private Sub Personal_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CopyDir As String = ImageLocation & CurrentStaff & ".jpg"
        If System.IO.File.Exists(CopyDir) = True Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(CopyDir,
                 IO.FileMode.Open, IO.FileAccess.Read)
            Me.PictureBox201.BackgroundImage = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If

    End Sub

End Class