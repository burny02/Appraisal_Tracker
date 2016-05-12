<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appraisal_View
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appraisal_View))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button501 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox502 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox501 = New System.Windows.Forms.TextBox()
        Me.PictureBox501 = New System.Windows.Forms.PictureBox()
        Me.DataGridView501 = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox501, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView501, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button501)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox502)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox501)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox501)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView501)
        Me.SplitContainer1.Size = New System.Drawing.Size(868, 445)
        Me.SplitContainer1.SplitterDistance = 233
        Me.SplitContainer1.TabIndex = 3
        '
        'Button501
        '
        Me.Button501.BackgroundImage = Global.Appraisal_Tracker.My.Resources.Resources.New_Appr
        Me.Button501.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button501.Location = New System.Drawing.Point(414, 162)
        Me.Button501.Name = "Button501"
        Me.Button501.Size = New System.Drawing.Size(271, 45)
        Me.Button501.TabIndex = 69
        Me.Button501.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 34)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Calculated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Next Appraisal:"
        '
        'TextBox502
        '
        Me.TextBox502.Enabled = False
        Me.TextBox502.Location = New System.Drawing.Point(414, 59)
        Me.TextBox502.Name = "TextBox502"
        Me.TextBox502.ReadOnly = True
        Me.TextBox502.Size = New System.Drawing.Size(111, 22)
        Me.TextBox502.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 34)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Calculated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Next Revalidation:"
        '
        'TextBox501
        '
        Me.TextBox501.Enabled = False
        Me.TextBox501.Location = New System.Drawing.Point(414, 107)
        Me.TextBox501.Name = "TextBox501"
        Me.TextBox501.ReadOnly = True
        Me.TextBox501.Size = New System.Drawing.Size(111, 22)
        Me.TextBox501.TabIndex = 65
        '
        'PictureBox501
        '
        Me.PictureBox501.BackgroundImage = Global.Appraisal_Tracker.My.Resources.Resources.Silhouette
        Me.PictureBox501.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox501.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox501.Location = New System.Drawing.Point(51, 14)
        Me.PictureBox501.Name = "PictureBox501"
        Me.PictureBox501.Size = New System.Drawing.Size(219, 209)
        Me.PictureBox501.TabIndex = 44
        Me.PictureBox501.TabStop = False
        '
        'DataGridView501
        '
        Me.DataGridView501.AllowUserToAddRows = False
        Me.DataGridView501.AllowUserToDeleteRows = False
        Me.DataGridView501.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView501.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView501.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView501.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView501.Name = "DataGridView501"
        Me.DataGridView501.ReadOnly = True
        Me.DataGridView501.RowHeadersVisible = False
        Me.DataGridView501.RowTemplate.Height = 24
        Me.DataGridView501.Size = New System.Drawing.Size(866, 206)
        Me.DataGridView501.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(543, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Appraisal Due:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(543, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Revalidation Due:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(673, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(175, 22)
        Me.DateTimePicker1.TabIndex = 74
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(673, 107)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowCheckBox = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(175, 22)
        Me.DateTimePicker2.TabIndex = 75
        '
        'Appraisal_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 445)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Appraisal_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appraisal_View"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox501, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView501, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox501 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox502 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox501 As TextBox
    Friend WithEvents DataGridView501 As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button501 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
