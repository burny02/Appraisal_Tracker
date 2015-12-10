Public Class StaffForm
    Private Sub PictureBox101_Click(sender As Object, e As EventArgs) Handles PictureBox101.Click

        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim filnam As String
        Dim ColumnHeaderNumber As Integer = 2

        fd.Title = "Choose query .jpg to upload"
        fd.Filter = "Image Files|*.jpg;*.jpeg;*.PNG"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True
        fd.Multiselect = False
        fd.AutoUpgradeEnabled = False

        If fd.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            fd = Nothing
            Exit Sub
        End If

        filnam = fd.FileName

        fd = Nothing

        If Not filnam = vbNullString Then

            Dim CopyDir As String = ImageLocation & CurrentStaff & ".jpg"
            System.IO.File.Copy(filnam, CopyDir, True)
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(CopyDir,
                 IO.FileMode.Open, IO.FileAccess.Read)
            Me.PictureBox101.BackgroundImage = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If


    End Sub

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CopyDir As String = ImageLocation & CurrentStaff & ".jpg"
        If System.IO.File.Exists(CopyDir) = True Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(CopyDir,
                 IO.FileMode.Open, IO.FileAccess.Read)
            Me.PictureBox101.BackgroundImage = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If

    End Sub
End Class