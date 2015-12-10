<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMC_Status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GMC_Status))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button301 = New System.Windows.Forms.Button()
        Me.TextBox302 = New System.Windows.Forms.TextBox()
        Me.TextBox301 = New System.Windows.Forms.TextBox()
        Me.PictureBox301 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox301 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox301, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button301)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox302)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox301)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox301)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CheckBox301)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Size = New System.Drawing.Size(664, 315)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 1
        '
        'Button301
        '
        Me.Button301.BackgroundImage = Global.Appraisal_Tracker.My.Resources.Resources.SAVER
        Me.Button301.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button301.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button301.FlatAppearance.BorderSize = 0
        Me.Button301.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button301.Location = New System.Drawing.Point(0, 0)
        Me.Button301.Margin = New System.Windows.Forms.Padding(4)
        Me.Button301.Name = "Button301"
        Me.Button301.Size = New System.Drawing.Size(173, 41)
        Me.Button301.TabIndex = 57
        Me.Button301.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button301.UseVisualStyleBackColor = True
        '
        'TextBox302
        '
        Me.TextBox302.Location = New System.Drawing.Point(455, 127)
        Me.TextBox302.Name = "TextBox302"
        Me.TextBox302.Size = New System.Drawing.Size(174, 22)
        Me.TextBox302.TabIndex = 60
        '
        'TextBox301
        '
        Me.TextBox301.Location = New System.Drawing.Point(455, 62)
        Me.TextBox301.Name = "TextBox301"
        Me.TextBox301.Size = New System.Drawing.Size(174, 22)
        Me.TextBox301.TabIndex = 59
        '
        'PictureBox301
        '
        Me.PictureBox301.BackgroundImage = Global.Appraisal_Tracker.My.Resources.Resources.Silhouette
        Me.PictureBox301.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox301.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox301.Location = New System.Drawing.Point(35, 11)
        Me.PictureBox301.Name = "PictureBox301"
        Me.PictureBox301.Size = New System.Drawing.Size(219, 248)
        Me.PictureBox301.TabIndex = 58
        Me.PictureBox301.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(294, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 17)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Connected to hVivo:"
        '
        'CheckBox301
        '
        Me.CheckBox301.AutoSize = True
        Me.CheckBox301.Location = New System.Drawing.Point(455, 197)
        Me.CheckBox301.Name = "CheckBox301"
        Me.CheckBox301.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox301.TabIndex = 56
        Me.CheckBox301.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 17)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "GMC Connect Added Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Status:"
        '
        'GMC_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 315)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GMC_Status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GMC_Status"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox301, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button301 As Button
    Friend WithEvents TextBox302 As TextBox
    Friend WithEvents TextBox301 As TextBox
    Friend WithEvents PictureBox301 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox301 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
