Module ButtonModule

    Public Sub ButtonSpecifics(sender As Object, e As EventArgs)

        Select Case sender.name.ToString

            Case "Button1"
                Call Saver(Form1.DataGridView1)

            Case "Button105"
                Call Saver(StaffForm.Button105)
                Staff_Form.Text = Staff_Form.TextBox101.Text.ToString &
                    " " & Staff_Form.TextBox102.Text.ToString

            Case "Button101"
                Dim SqlCode As String = "SELECT PersEmail, hVivoEmail, Address, " &
                    "PMST_Trainee, Case_Investigations FROM Staff WHERE Staff_ID=" & CurrentStaff
                Dim TempTbl As DataTable = OverClass.TempDataTable(SqlCode)
                Pers_Form = New Personal_Info
                OverClass.AddAllDataItem(Pers_Form.SplitContainer1)
                For Each ctl In OverClass.DataItemCollection
                    If (TypeOf ctl Is Button) Then
                        Dim But As Button = ctl
                        RemoveHandler But.Click, AddressOf ButtonSpecifics
                        AddHandler But.Click, AddressOf ButtonSpecifics
                    End If
                Next
                With Pers_Form
                    .Text = Staff_Form.TextBox101.Text & " " & Staff_Form.TextBox102.Text
                    .TextBox201.Text = TempTbl.Rows(0).Item("PersEmail").ToString
                    .TextBox202.Text = TempTbl.Rows(0).Item("hVivoEmail").ToString
                    .TextBox203.Text = TempTbl.Rows(0).Item("Address").ToString
                    .CheckBox201.Checked = TempTbl.Rows(0).Item("PMST_Trainee")
                    .CheckBox202.Checked = TempTbl.Rows(0).Item("Case_Investigations")
                    .DialogResult = DialogResult.Abort
                    .ShowDialog()
                End With
                OverClass.RemoveAllDataItem(Pers_Form.SplitContainer1)
                Pers_Form = Nothing

            Case "Button205"
                Call Saver(Pers_Form.Button205)


            Case "Button104"
                Dim SqlCode As String = "SELECT ConnectToHvivo, DateGMCConnect, Status " &
                    "FROM GMC_Status WHERE Staff_ID=" & CurrentStaff
                Dim TempTbl As DataTable = OverClass.TempDataTable(SqlCode)
                GMC_Form = New GMC_Status
                OverClass.AddAllDataItem(GMC_Form.SplitContainer1)
                For Each ctl In OverClass.DataItemCollection
                    If (TypeOf ctl Is Button) Then
                        Dim But As Button = ctl
                        RemoveHandler But.Click, AddressOf ButtonSpecifics
                        AddHandler But.Click, AddressOf ButtonSpecifics
                    End If
                Next
                With GMC_Form
                    .Text = Staff_Form.TextBox101.Text & " " & Staff_Form.TextBox102.Text
                    .TextBox301.Text = TempTbl.Rows(0).Item("Status").ToString
                    If TempTbl.Rows(0).Item("DateGMCConnect").ToString <> vbNullString Then
                        .TextBox302.Text = Format(TempTbl.Rows(0).Item("DateGMCConnect"), "dd-MMM-yyyy")
                    End If
                    .CheckBox301.Checked = TempTbl.Rows(0).Item("ConnectToHvivo")
                    .DialogResult = DialogResult.Abort
                    .ShowDialog()
                End With
                OverClass.RemoveAllDataItem(GMC_Form.SplitContainer1)
                GMC_Form = Nothing

            Case "Button301"
                Call Saver(GMC_Form.Button301)

            Case "Button102"
                Dim SqlCode As String = "SELECT PreviousRO, RVLMain, OutsideRVL, " &
                    "PostQExp, PrevPrescribeConnection, CurPrescribeConnection, Interests " &
                    "FROM Prof_Profile WHERE Staff_ID=" & CurrentStaff
                Dim TempTbl As DataTable = OverClass.TempDataTable(SqlCode)
                Prof_Form = New Prof_Profile
                OverClass.AddAllDataItem(Prof_Form.SplitContainer1)
                For Each ctl In OverClass.DataItemCollection
                    If (TypeOf ctl Is Button) Then
                        Dim But As Button = ctl
                        RemoveHandler But.Click, AddressOf ButtonSpecifics
                        AddHandler But.Click, AddressOf ButtonSpecifics
                    End If
                Next
                With Prof_Form
                    .Text = Staff_Form.TextBox101.Text & " " & Staff_Form.TextBox102.Text
                    .TextBox401.Text = TempTbl.Rows(0).Item("OutsideRVL").ToString
                    .TextBox402.Text = TempTbl.Rows(0).Item("PostQExp").ToString
                    .TextBox403.Text = TempTbl.Rows(0).Item("PreviousRO").ToString
                    .TextBox404.Text = TempTbl.Rows(0).Item("PrevPrescribeConnection").ToString
                    .TextBox405.Text = TempTbl.Rows(0).Item("CurPrescribeConnection").ToString
                    .TextBox406.Text = TempTbl.Rows(0).Item("Interests").ToString
                    .CheckBox401.Checked = TempTbl.Rows(0).Item("RVLMain")
                    .DialogResult = DialogResult.Abort
                    .ShowDialog()
                End With
                OverClass.RemoveAllDataItem(Prof_Form.SplitContainer1)
                GMC_Form = Nothing

            Case "Button401"
                Call Saver(Prof_Form.Button401)


            Case "Button103"
                Appr_View = New Appraisal_View

                Dim SQLCode As String = "SELECT Appraisal_ID, cdate(Appraisal_Date) as AppDat, Reval_Appr FROM Appraisal " &
                    "WHERE Staff_ID=" & CurrentStaff & " ORDER BY cdate(Appraisal_Date) DESC"
                OverClass.CreateDataSet(SQLCode, Appr_View.BindingSource1, Appr_View.DataGridView501)

                Appr_View.DataGridView501.Columns("Appraisal_ID").Visible = False
                Appr_View.DataGridView501.Columns("AppDat").HeaderText = "Date"
                Appr_View.DataGridView501.Columns("AppDat").DefaultCellStyle.Format = "dd-MMM-yyyy"
                Appr_View.DataGridView501.Columns("Reval_Appr").HeaderText = "Appraisal/Revalidation"

                Dim NewClm As New DataGridViewImageColumn
                NewClm.Image = My.Resources.Lookup
                NewClm.ImageLayout = ImageLayout.Stretch
                Appr_View.DataGridView501.Columns.Add(NewClm)
                NewClm.HeaderText = "View"
                NewClm.Name = "View"

                Dim ApprDate As Date = DateTime.Now
                Dim RevDate As Date = DateTime.Now

                Dim SQLArray(2) As String
                Dim TblArray(2) As DataTable

                SQLArray(0) = "SELECT max(CDate(Appraisal_Date)) As AppDat FROM Appraisal " &
                    "WHERE Staff_ID=" & CurrentStaff & " AND Reval_Appr='Appraisal'"

                SQLArray(1) = "SELECT max(CDate(Appraisal_Date)) As AppDat FROM Appraisal " &
                    "WHERE Staff_ID=" & CurrentStaff & " AND Reval_Appr='Revalidation'"

                SQLArray(2) = "SELECT Appr_Due, Reval_Due FROM Staff " &
                    "WHERE Staff_ID=" & CurrentStaff

                TblArray = OverClass.MultiTempDataTable(SQLArray)

                If Not IsDBNull(TblArray(0).Rows(0).Item("AppDat")) Then
                    ApprDate = TblArray(0).Rows(0).Item("AppDat")
                    ApprDate = DateAdd(DateInterval.Year, 1, ApprDate)
                End If

                If Not IsDBNull(TblArray(1).Rows(0).Item("AppDat")) Then
                    RevDate = TblArray(1).Rows(0).Item("AppDat")
                    RevDate = DateAdd(DateInterval.Year, 5, RevDate)
                End If

                If Not IsDBNull(TblArray(2).Rows(0).Item("Appr_Due")) Then
                    Appr_View.DateTimePicker1.Checked = True
                    Appr_View.DateTimePicker1.Value = TblArray(2).Rows(0).Item("Appr_Due")
                End If

                If Not IsDBNull(TblArray(2).Rows(0).Item("Reval_Due")) Then
                    Appr_View.DateTimePicker2.Checked = True
                    Appr_View.DateTimePicker2.Value = TblArray(2).Rows(0).Item("Reval_Due")
                End If

                OverClass.AddAllDataItem(Appr_View.SplitContainer1)
                For Each ctl In OverClass.DataItemCollection
                    If (TypeOf ctl Is Button) Then
                        Dim But As Button = ctl
                        RemoveHandler But.Click, AddressOf ButtonSpecifics
                        AddHandler But.Click, AddressOf ButtonSpecifics
                    End If
                Next
                With Appr_View
                    .Text = Staff_Form.TextBox101.Text & " " & Staff_Form.TextBox102.Text
                    .TextBox502.Text = Format(ApprDate, "dd-MMM-yyyy")
                    .TextBox501.Text = Format(RevDate, "dd-MMM-yyyy")

                    If ApprDate <= DateAndTime.Now Then
                        .Label2.ForeColor = Color.Red
                    Else
                        .Label2.ForeColor = Color.Black
                    End If

                    If RevDate <= DateAndTime.Now Then
                        .Label1.ForeColor = Color.Red
                    Else
                        .Label1.ForeColor = Color.Black
                    End If

                    If .DateTimePicker2.Checked = True And
                        .DateTimePicker2.Value <= DateAndTime.Now Then
                        .Label4.ForeColor = Color.Red
                    Else
                        .Label4.ForeColor = Color.Black
                    End If

                    If .DateTimePicker1.Checked = True And
                        .DateTimePicker1.Value <= DateAndTime.Now Then
                        .Label3.ForeColor = Color.Red
                    Else
                        .Label3.ForeColor = Color.Black
                    End If

                    .DialogResult = DialogResult.Abort
                    .ShowDialog()
                End With
                Try
                    OverClass.RemoveAllDataItem(Appr_View.SplitContainer1)
                Catch
                End Try
                Appr_Form = Nothing

            Case "Button501"
                New_Appr = True
                Appraisal_Form = New Appr_Form
                OverClass.AddAllDataItem(Appraisal_Form.SplitContainer1)
                For Each ctl In OverClass.DataItemCollection
                    If (TypeOf ctl Is Button) Then
                        Dim But As Button = ctl
                        RemoveHandler But.Click, AddressOf ButtonSpecifics
                        AddHandler But.Click, AddressOf ButtonSpecifics
                    End If
                Next
                With Appraisal_Form
                    .Text = Appr_View.Text
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
                New_Appr = False



            Case "Button601"
                Call Saver(Appraisal_Form.Button601)


        End Select

    End Sub

End Module
