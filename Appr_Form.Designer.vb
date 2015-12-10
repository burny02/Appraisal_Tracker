<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appr_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appr_Form))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox301 = New System.Windows.Forms.TextBox()
        Me.Button601 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox604 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox603 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox601 = New System.Windows.Forms.ComboBox()
        Me.TextBox602 = New System.Windows.Forms.TextBox()
        Me.TextBox601 = New System.Windows.Forms.TextBox()
        Me.PictureBox601 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox601, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 22)
        Me.TextBox1.TabIndex = 47
        '
        'TextBox301
        '
        Me.TextBox301.Location = New System.Drawing.Point(432, 63)
        Me.TextBox301.Name = "TextBox301"
        Me.TextBox301.Size = New System.Drawing.Size(174, 22)
        Me.TextBox301.TabIndex = 45
        '
        'Button601
        '
        Me.Button601.BackgroundImage = Global.Appraisal_Tracker.My.Resources.Resources.SAVER
        Me.Button601.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button601.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button601.FlatAppearance.BorderSize = 0
        Me.Button601.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button601.Location = New System.Drawing.Point(0, 0)
        Me.Button601.Margin = New System.Windows.Forms.Padding(4)
        Me.Button601.Name = "Button601"
        Me.Button601.Size = New System.Drawing.Size(173, 43)
        Me.Button601.TabIndex = 57
        Me.Button601.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button601.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button601)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox604)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox603)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBox601)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox602)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox601)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox601)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Size = New System.Drawing.Size(661, 305)
        Me.SplitContainer1.SplitterDistance = 43
        Me.SplitContainer1.TabIndex = 2
        '
        'TextBox604
        '
        Me.TextBox604.Location = New System.Drawing.Point(428, 219)
        Me.TextBox604.Name = "TextBox604"
        Me.TextBox604.Size = New System.Drawing.Size(174, 22)
        Me.TextBox604.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "System Used:"
        '
        'TextBox603
        '
        Me.TextBox603.Location = New System.Drawing.Point(428, 182)
        Me.TextBox603.Name = "TextBox603"
        Me.TextBox603.Size = New System.Drawing.Size(174, 22)
        Me.TextBox603.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Conducted By:"
        '
        'ComboBox601
        '
        Me.ComboBox601.FormattingEnabled = True
        Me.ComboBox601.Location = New System.Drawing.Point(428, 55)
        Me.ComboBox601.Name = "ComboBox601"
        Me.ComboBox601.Size = New System.Drawing.Size(174, 24)
        Me.ComboBox601.TabIndex = 59
        '
        'TextBox602
        '
        Me.TextBox602.Location = New System.Drawing.Point(428, 91)
        Me.TextBox602.Multiline = True
        Me.TextBox602.Name = "TextBox602"
        Me.TextBox602.Size = New System.Drawing.Size(174, 75)
        Me.TextBox602.TabIndex = 60
        '
        'TextBox601
        '
        Me.TextBox601.Location = New System.Drawing.Point(428, 21)
        Me.TextBox601.Name = "TextBox601"
        Me.TextBox601.Size = New System.Drawing.Size(174, 22)
        Me.TextBox601.TabIndex = 58
        '
        'PictureBox601
        '
        Me.PictureBox601.BackgroundImage = Global.Appraisal_Tracker.My.Resources.Resources.Silhouette
        Me.PictureBox601.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox601.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox601.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox601.Name = "PictureBox601"
        Me.PictureBox601.Size = New System.Drawing.Size(219, 248)
        Me.PictureBox601.TabIndex = 57
        Me.PictureBox601.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Reported/Signed Off:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Appraisal/Revalidation:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Date:"
        '
        'Appr_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 305)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Appr_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appr_Form"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox601, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox301 As TextBox
    Friend WithEvents Button601 As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TextBox604 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox603 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox601 As ComboBox
    Friend WithEvents TextBox602 As TextBox
    Friend WithEvents TextBox601 As TextBox
    Friend WithEvents PictureBox601 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
