<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.start = New System.Windows.Forms.Button()
        Me.score = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.legend = New System.Windows.Forms.Label()
        Me.copyright = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 267)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'start
        '
        Me.start.BackColor = System.Drawing.Color.LawnGreen
        Me.start.Location = New System.Drawing.Point(311, 85)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(187, 56)
        Me.start.TabIndex = 1
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = False
        '
        'score
        '
        Me.score.BackColor = System.Drawing.Color.LawnGreen
        Me.score.Location = New System.Drawing.Point(311, 147)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(187, 56)
        Me.score.TabIndex = 2
        Me.score.Text = "ScoreBoard"
        Me.score.UseVisualStyleBackColor = False
        '
        'quit
        '
        Me.quit.BackColor = System.Drawing.Color.LawnGreen
        Me.quit.Location = New System.Drawing.Point(311, 209)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(187, 56)
        Me.quit.TabIndex = 4
        Me.quit.Text = "Quit"
        Me.quit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Matura MT Script Capitals", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Snake Game"
        '
        'legend
        '
        Me.legend.AutoSize = True
        Me.legend.Font = New System.Drawing.Font("Mistral", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.legend.Location = New System.Drawing.Point(356, 49)
        Me.legend.Name = "legend"
        Me.legend.Size = New System.Drawing.Size(97, 33)
        Me.legend.TabIndex = 6
        Me.legend.Text = "legendary"
        '
        'copyright
        '
        Me.copyright.AutoSize = True
        Me.copyright.Location = New System.Drawing.Point(124, 4)
        Me.copyright.Name = "copyright"
        Me.copyright.Size = New System.Drawing.Size(262, 13)
        Me.copyright.TabIndex = 7
        Me.copyright.Text = "@Copy Right By Bezaleel Bagoes A. A. (1151600076)"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.copyright)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 271)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 22)
        Me.Panel1.TabIndex = 8
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 293)
        Me.Controls.Add(Me.legend)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents score As System.Windows.Forms.Button
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents legend As System.Windows.Forms.Label
    Friend WithEvents copyright As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
