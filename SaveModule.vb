Module SaveModule

    Public Sub Saver(ctl As Object)
        Dim DisplayMessage As Boolean = True

        'Get a generic command list first - Ignore errors (Multi table)
        Dim cb As New OleDb.OleDbCommandBuilder(OverClass.CurrentDataAdapter)

        Try
            OverClass.CurrentDataAdapter.UpdateCommand = cb.GetUpdateCommand()
        Catch
        End Try
        Try
            OverClass.CurrentDataAdapter.InsertCommand = cb.GetInsertCommand()
        Catch
        End Try
        Try
            OverClass.CurrentDataAdapter.DeleteCommand = cb.GetDeleteCommand()
        Catch
        End Try


        'Create and overwrite a custom one if needed (More than 1 table) ...OLEDB Parameters must be added in the order they are used

        Select Case ctl.name

            Case "DataGridView1"

                OverClass.CurrentDataAdapter.UpdateCommand = New OleDb.OleDbCommand("UPDATE Staff " &
                                                               "SET FName=@P1, SName=@P2 WHERE Staff_ID=@P3")

                With OverClass.CurrentDataAdapter.UpdateCommand.Parameters
                    .Add("@P1", OleDb.OleDbType.VarChar, 255, "FName")
                    .Add("@P2", OleDb.OleDbType.VarChar, 255, "SName")
                    .Add("@P3", OleDb.OleDbType.Double, 255, "Staff_ID")
                End With

                OverClass.CurrentDataAdapter.InsertCommand = New OleDb.OleDbCommand("INSERT INTO Staff (FName, SName) " &
                                                               "VALUES (@P1,@P2)")

                With OverClass.CurrentDataAdapter.InsertCommand.Parameters
                    .Add("@P1", OleDb.OleDbType.VarChar, 255, "FName")
                    .Add("@P2", OleDb.OleDbType.VarChar, 255, "SName")
                End With

            Case "Button105"

                Dim F1 As String = "FName='" & Staff_Form.TextBox101.Text.ToString & "'"
                Dim F2 As String = ",SName='" & Staff_Form.TextBox102.Text.ToString & "'"
                Dim F3 As String = ",GMCNo='" & Staff_Form.TextBox103.Text.ToString & "'"
                Dim F4 As String = ",Site='" & Staff_Form.ComboBox101.Text.ToString & "'"
                Dim F5 As String = ",Contract='" & Staff_Form.ComboBox102.Text.ToString & "'"
                Dim F6 As String = ",Posi='" & Staff_Form.TextBox104.Text.ToString & "'"
                Dim F7 As String = ",Line_Manager='" & Staff_Form.TextBox105.Text.ToString & "'"

                Dim SqlCode As String = "UPDATE Staff SET " & F1 & F2 & F3 & F4 & F5 & F6 & F7 &
                    " WHERE Staff_ID=" & CurrentStaff


                OverClass.ExecuteSQL(SqlCode)
                MsgBox("Table Updated")
                Exit Sub

            Case "Button205"

                Dim F1 As String = "PersEmail='" & Pers_Form.TextBox201.Text.ToString & "'"
                Dim F2 As String = ",hVivoEmail='" & Pers_Form.TextBox202.Text.ToString & "'"
                Dim F3 As String = ",Address='" & Pers_Form.TextBox203.Text.ToString & "'"
                Dim F4 As String = ",PMST_Trainee=" & Pers_Form.CheckBox201.Checked
                Dim F5 As String = ",Case_Investigations=" & Pers_Form.CheckBox202.Checked

                Dim SqlCode As String = "UPDATE Staff SET " & F1 & F2 & F3 & F4 & F5 &
                    " WHERE Staff_ID=" & CurrentStaff


                OverClass.ExecuteSQL(SqlCode)
                MsgBox("Table Updated")
                Exit Sub

            Case "Button301"

                If IsDate(GMC_Form.TextBox302.Text) = False Then
                    MsgBox("Please ensure a correct date is entered.")
                    Exit Sub
                End If

                Dim F1 As String = "ConnectToHvivo=" & GMC_Form.CheckBox301.Checked
                Dim F2 As String = ",DateGMCConnect=" & OverClass.SQLDate(CDate(GMC_Form.TextBox302.Text))
                Dim F3 As String = ",Status='" & GMC_Form.TextBox301.Text.ToString & "'"

                Dim SqlCode As String = "UPDATE GMC_Status SET " & F1 & F2 & F3 &
                    " WHERE Staff_ID=" & CurrentStaff


                OverClass.ExecuteSQL(SqlCode)
                MsgBox("Table Updated")
                Exit Sub

            Case "Button401"


                Dim F1 As String = "OutsideRVL='" & Prof_Form.TextBox401.Text.ToString & "'"
                Dim F2 As String = ",PostQExp='" & Prof_Form.TextBox402.Text.ToString & "'"
                Dim F3 As String = ",PreviousRO='" & Prof_Form.TextBox403.Text.ToString & "'"
                Dim F4 As String = ",PrevPrescribeConnection='" & Prof_Form.TextBox404.Text.ToString & "'"
                Dim F5 As String = ",CurPrescribeConnection='" & Prof_Form.TextBox405.Text.ToString & "'"
                Dim F6 As String = ",Interests='" & Prof_Form.TextBox406.Text.ToString & "'"
                Dim F7 As String = ",RVLMain=" & Prof_Form.CheckBox401.Checked

                Dim SqlCode As String = "UPDATE Prof_Profile SET " & F1 & F2 & F3 & F4 & F5 & F6 & F7 &
                    " WHERE Staff_ID=" & CurrentStaff


                OverClass.ExecuteSQL(SqlCode)
                MsgBox("Table Updated")
                Exit Sub


            Case "Button601"

                If IsDate(Appraisal_Form.TextBox601.Text) = False Then
                    MsgBox("Please ensure a correct date is entered")
                    Exit Sub
                End If

                If CDate(Appraisal_Form.TextBox601.Text) > DateAdd(DateInterval.Day, 1, DateTime.Now) Then
                    MsgBox("Please enter today's date or before")
                    Exit Sub
                End If

                If Appraisal_Form.ComboBox601.Text = vbNullString Then
                    MsgBox("Please choose whether this entry is an appraisal or revalidation")
                    Exit Sub
                End If

                Dim SqlCode As String = vbNullString

                If New_Appr = False Then
                    Dim F1 As String = "Appraisal_Date='" & Appraisal_Form.TextBox601.Text.ToString & "'"
                    Dim F2 As String = ",SignedOff='" & Appraisal_Form.TextBox602.Text.ToString & "'"
                    Dim F3 As String = ",Conducted_By='" & Appraisal_Form.TextBox603.Text.ToString & "'"
                    Dim F4 As String = ",System='" & Appraisal_Form.TextBox604.Text.ToString & "'"
                    Dim F5 As String = ",Reval_Appr='" & Appraisal_Form.ComboBox601.Text.ToString & "'"
                    SqlCode = "UPDATE Appraisal SET " & F1 & F2 & F3 & F4 & F5 &
                    " WHERE Appraisal_ID=" & CurAppr
                Else
                    SqlCode = "INSERT INTO Appraisal (Staff_ID, Appraisal_Date, Reval_Appr, SignedOff, Conducted_By, System) " &
                        "VALUES (" & CurrentStaff & "," &
                        "'" & Appraisal_Form.TextBox601.Text.ToString & "'," &
                        "'" & Appraisal_Form.ComboBox601.Text.ToString & "'," &
                        "'" & Appraisal_Form.TextBox602.Text.ToString & "'," &
                        "'" & Appraisal_Form.TextBox603.Text.ToString & "'," &
                        "'" & Appraisal_Form.TextBox604.Text.ToString & "')"
                End If


                OverClass.ExecuteSQL(SqlCode)
                MsgBox("Table Updated")

                OverClass.RemoveAllDataItem(Appr_View.SplitContainer1)
                OverClass.RemoveAllDataItem(Appraisal_Form.SplitContainer1)
                Appraisal_Form.Dispose()
                Appraisal_Form = Nothing
                Appr_View.Dispose()
                Appr_View = Nothing
                Staff_Form.Button103.PerformClick()
                Exit Sub

        End Select

        Call OverClass.SetCommandConnection()
        Call OverClass.UpdateBackend(ctl, DisplayMessage)
        If DisplayMessage = False Then MsgBox("Table Updated")


    End Sub


End Module
