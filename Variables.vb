Imports TemplateDB

Module Variables
    Public OverClass As OverClass
    Private Const TablePath As String = "M:\VOLUNTEER SCREENING SERVICES\Systems\Appraisal_Tracker\Validation.accdb"
    Public ImageLocation As String = "M:\VOLUNTEER SCREENING SERVICES\Systems\Appraisal_Tracker\DB_Files\"
    Private Const PWord As String = "RetroRetro*1"
    Private Const Connect2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & TablePath & ";Jet OLEDB:Database Password=" & PWord
    Private Const UserTable As String = "[Users]"
    Private Const UserField As String = "Username"
    Private Const LockTable As String = "[Locker]"
    Private Const AuditTbl As String = "[Audit]"
    Private Contact As String = "Fiona Hughes"
    Public Const SolutionName As String = "Appraisal Tracker"
    Public CurrentStaff, CurAppr As Long
    Public Staff_Form As StaffForm
    Public Pers_Form As Personal_Info
    Public GMC_Form As GMC_Status
    Public Prof_Form As Prof_Profile
    Public Appr_View As Appraisal_View
    Public Appraisal_Form As Appr_Form
    Public New_Appr As Boolean

    Public Function GetTheConnection() As String
        GetTheConnection = Connect2
    End Function


    Public Sub StartUp()

        OverClass = New TemplateDB.OverClass
        OverClass.SetPrivate(UserTable,
                           UserField,
                           LockTable,
                           Contact,
                           Connect2,
                           AuditTbl)

        OverClass.LockCheck()

        OverClass.LoginCheck()

        OverClass.AddAllDataItem(Form1)

        For Each ctl In OverClass.DataItemCollection
            'If (TypeOf ctl Is ComboBox) Then
            'Dim Com As ComboBox = ctl
            'AddHandler Com.SelectionChangeCommitted, AddressOf GenericCombo
            'End If
            If (TypeOf ctl Is Button) Then
                Dim But As Button = ctl
                AddHandler But.Click, AddressOf ButtonSpecifics
            End If
        Next


    End Sub

End Module
