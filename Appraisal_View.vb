Public Class Appraisal_View
    Private Sub Appraisal_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CopyDir As String = ImageLocation & CurrentStaff & ".jpg"
        If System.IO.File.Exists(CopyDir) = True Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(CopyDir,
                 IO.FileMode.Open, IO.FileAccess.Read)
            Me.PictureBox501.BackgroundImage = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If

    End Sub

    Private Sub DataGridView501_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView501.CellContentClick

        If e.ColumnIndex = sender.columns("View").index Then

            CurAppr = sender.item("Appraisal_ID", e.RowIndex).value

            New_Appr = False
            Appraisal_Form = New Appr_Form
            OverClass.AddAllDataItem(Appraisal_Form.SplitContainer1)
            For Each ctl In OverClass.DataItemCollection
                If (TypeOf ctl Is Button) Then
                    Dim But As Button = ctl
                    RemoveHandler But.Click, AddressOf ButtonSpecifics
                    AddHandler But.Click, AddressOf ButtonSpecifics
                End If
            Next

            Dim SqlCode As String = "SELECT Appraisal_Date, Reval_Appr, SignedOff, Conducted_By, System " &
                    "FROM Appraisal WHERE Appraisal_ID=" & CurAppr
            Dim TempTbl As DataTable = OverClass.TempDataTable(SqlCode)

            With Appraisal_Form
                .Text = Appr_View.Text
                .TextBox601.Text = TempTbl.Rows(0).Item("Appraisal_Date").ToString
                .TextBox602.Text = TempTbl.Rows(0).Item("SignedOff").ToString
                .TextBox603.Text = TempTbl.Rows(0).Item("Conducted_By").ToString
                .TextBox604.Text = TempTbl.Rows(0).Item("System").ToString
                .ComboBox601.Text = TempTbl.Rows(0).Item("Reval_Appr").ToString
                .ComboBox601.Items.Add("Appraisal")
                .ComboBox601.Items.Add("Revalidation")
                .DialogResult = DialogResult.Abort
                .ShowDialog()
            End With
            Try
                OverClass.RemoveAllDataItem(Appraisal_Form.SplitContainer1)
            Catch
            End Try
            Appraisal_Form = Nothing

        End If
    End Sub
End Class