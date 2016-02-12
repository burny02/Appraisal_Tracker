Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Call StartUp()

        Try
            Me.Label2.Text = SolutionName & vbNewLine & "Developed by David Burnside" & vbNewLine & "Version: " & System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Catch
            Me.Label2.Text = SolutionName & vbNewLine & "Developed by David Burnside"
        End Try

        Me.Text = SolutionName

    End Sub

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting

        Dim SQLCode As String = vbNullString
        Dim Bind As BindingSource = BindingSource1
        Dim ctl As DataGridView = Nothing

        If OverClass.UnloadData() = True Then
            e.Cancel = True
            Exit Sub
        End If

        OverClass.ResetCollection()

        Select Case e.TabPage.Text

            Case "Staff"
                ctl = Me.DataGridView1
                SQLCode = "SELECT * FROM StaffQry WHERE Hidden=False ORDER BY FName ASC"
                OverClass.CreateDataSet(SQLCode, Bind, ctl)
                ctl.Columns("AppDate").Visible = False
                ctl.Columns("RevalDate").Visible = False
                ctl.Columns("Staff_ID").Visible = False
                ctl.Columns("FName").HeaderText = "Name"
                ctl.Columns("SName").HeaderText = "Surname"
                Dim NewClm As New DataGridViewImageColumn
                NewClm.Image = My.Resources.Lookup
                NewClm.ImageLayout = ImageLayout.Stretch
                ctl.Columns.Add(NewClm)
                NewClm.HeaderText = "View"
                NewClm.Name = "View"
        End Select


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = sender.columns("View").index Then
            If IsDBNull(sender.Item("Staff_ID", e.RowIndex).Value) Then Exit Sub

            If OverClass.UnloadData() = True Then
                Exit Sub
            End If

            CurrentStaff = sender.item("Staff_ID", e.RowIndex).value

            Dim SqlCode As String = "SELECT FName, SName, GMCNo, Site, Contract, Posi, Line_Manager " &
                "FROM Staff WHERE Staff_ID=" & CurrentStaff
            Dim TempTbl As DataTable = OverClass.TempDataTable(SqlCode)
            Staff_Form = New StaffForm
            OverClass.AddAllDataItem(Staff_Form.SplitContainer1)
            For Each ctl In OverClass.DataItemCollection
                If (TypeOf ctl Is Button) Then
                    Dim But As Button = ctl
                    RemoveHandler But.Click, AddressOf ButtonSpecifics
                    AddHandler But.Click, AddressOf ButtonSpecifics
                End If
            Next
            With Staff_Form
                .Text = sender.item("FName", e.RowIndex).value & " " & sender.item("SName", e.RowIndex).value
                .TextBox101.Text = TempTbl.Rows(0).Item("FName").ToString
                .TextBox102.Text = TempTbl.Rows(0).Item("SName").ToString
                .TextBox103.Text = TempTbl.Rows(0).Item("GMCNo").ToString
                .TextBox104.Text = TempTbl.Rows(0).Item("Posi").ToString
                .TextBox105.Text = TempTbl.Rows(0).Item("Line_Manager").ToString
                .ComboBox101.Text = TempTbl.Rows(0).Item("Site").ToString
                .ComboBox102.Text = TempTbl.Rows(0).Item("Contract").ToString
                .ComboBox101.Items.Add("MAN")
                .ComboBox101.Items.Add("WHC")
                .ComboBox102.Items.Add("Permanent")
                .ComboBox102.Items.Add("Bank")
                .DialogResult = DialogResult.Abort
                .ShowDialog()
            End With
            OverClass.RemoveAllDataItem(Staff_Form.SplitContainer1)
            Staff_Form = Nothing
            Me.TabControl1.SelectedIndex = 1
            Me.TabControl1_Selecting(Me.TabControl1, New TabControlCancelEventArgs(TabPage2, 0, False, TabControlAction.Selecting))

        End If

    End Sub


    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit

        If IsDBNull(sender.item("Staff_ID", e.RowIndex).value) Or IsNothing(sender.item("Staff_ID", e.RowIndex).value) Then
            Exit Sub
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint

        Dim AppDate As Date = "01-Jan-2500"
        Dim RevalDate As Date = "01-Jan-2500"

        Try
            AppDate = DataGridView1.Item("AppDate", e.RowIndex).Value
        Catch ex As Exception
        End Try

        Try
            RevalDate = DataGridView1.Item("RevalDate", e.RowIndex).Value
        Catch ex As Exception
        End Try

        If e.RowIndex <> DataGridView1.NewRowIndex Then
            If AppDate <= DateAndTime.Now Or RevalDate <= DateAndTime.Now Then
                DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            End If
        End If
    End Sub
End Class
