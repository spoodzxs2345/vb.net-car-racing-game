<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        road1 = New PictureBox()
        road2 = New PictureBox()
        road4 = New PictureBox()
        road3 = New PictureBox()
        road5 = New PictureBox()
        road6 = New PictureBox()
        road8 = New PictureBox()
        road7 = New PictureBox()
        ScoreLabel = New Label()
        SpeedLabel = New Label()
        enemy1 = New PictureBox()
        player = New PictureBox()
        enemy2 = New PictureBox()
        enemy3 = New PictureBox()
        enemy4 = New PictureBox()
        GameOver = New Label()
        ReplayButton = New Button()
        RoadMover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        EnemyMover1 = New Timer(components)
        EnemyMover2 = New Timer(components)
        EnemyMover3 = New Timer(components)
        EnemyMover4 = New Timer(components)
        CType(road1, ComponentModel.ISupportInitialize).BeginInit()
        CType(road2, ComponentModel.ISupportInitialize).BeginInit()
        CType(road4, ComponentModel.ISupportInitialize).BeginInit()
        CType(road3, ComponentModel.ISupportInitialize).BeginInit()
        CType(road5, ComponentModel.ISupportInitialize).BeginInit()
        CType(road6, ComponentModel.ISupportInitialize).BeginInit()
        CType(road8, ComponentModel.ISupportInitialize).BeginInit()
        CType(road7, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy1, ComponentModel.ISupportInitialize).BeginInit()
        CType(player, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' road1
        ' 
        road1.BackColor = SystemColors.ButtonHighlight
        road1.Location = New Point(102, -36)
        road1.Name = "road1"
        road1.Size = New Size(16, 102)
        road1.TabIndex = 0
        road1.TabStop = False
        ' 
        ' road2
        ' 
        road2.BackColor = SystemColors.ButtonHighlight
        road2.Location = New Point(219, -36)
        road2.Name = "road2"
        road2.Size = New Size(16, 102)
        road2.TabIndex = 1
        road2.TabStop = False
        ' 
        ' road4
        ' 
        road4.BackColor = SystemColors.ButtonHighlight
        road4.Location = New Point(219, 105)
        road4.Name = "road4"
        road4.Size = New Size(16, 102)
        road4.TabIndex = 3
        road4.TabStop = False
        ' 
        ' road3
        ' 
        road3.BackColor = SystemColors.ButtonHighlight
        road3.Location = New Point(102, 105)
        road3.Name = "road3"
        road3.Size = New Size(16, 102)
        road3.TabIndex = 2
        road3.TabStop = False
        ' 
        ' road5
        ' 
        road5.BackColor = SystemColors.ButtonHighlight
        road5.Location = New Point(102, 248)
        road5.Name = "road5"
        road5.Size = New Size(16, 102)
        road5.TabIndex = 6
        road5.TabStop = False
        ' 
        ' road6
        ' 
        road6.BackColor = SystemColors.ButtonHighlight
        road6.Location = New Point(219, 248)
        road6.Name = "road6"
        road6.Size = New Size(16, 102)
        road6.TabIndex = 7
        road6.TabStop = False
        ' 
        ' road8
        ' 
        road8.BackColor = SystemColors.ButtonHighlight
        road8.Location = New Point(219, 391)
        road8.Name = "road8"
        road8.Size = New Size(16, 102)
        road8.TabIndex = 9
        road8.TabStop = False
        ' 
        ' road7
        ' 
        road7.BackColor = SystemColors.ButtonHighlight
        road7.Location = New Point(102, 391)
        road7.Name = "road7"
        road7.Size = New Size(16, 102)
        road7.TabIndex = 8
        road7.TabStop = False
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.Font = New Font("Agency FB", 15.75F, FontStyle.Bold)
        ScoreLabel.ForeColor = SystemColors.ButtonHighlight
        ScoreLabel.Location = New Point(24, 9)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(68, 25)
        ScoreLabel.TabIndex = 10
        ScoreLabel.Text = "SCORE 0"
        ' 
        ' SpeedLabel
        ' 
        SpeedLabel.AutoSize = True
        SpeedLabel.Font = New Font("Agency FB", 15.75F, FontStyle.Bold)
        SpeedLabel.ForeColor = SystemColors.ButtonHighlight
        SpeedLabel.Location = New Point(256, 9)
        SpeedLabel.Name = "SpeedLabel"
        SpeedLabel.Size = New Size(66, 25)
        SpeedLabel.TabIndex = 11
        SpeedLabel.Text = "SPEED 0"
        ' 
        ' enemy1
        ' 
        enemy1.Image = My.Resources.Resources.car
        enemy1.Location = New Point(24, 238)
        enemy1.Name = "enemy1"
        enemy1.Size = New Size(41, 80)
        enemy1.SizeMode = PictureBoxSizeMode.Zoom
        enemy1.TabIndex = 12
        enemy1.TabStop = False
        ' 
        ' player
        ' 
        player.Image = My.Resources.Resources.player
        player.Location = New Point(148, 353)
        player.Name = "player"
        player.Size = New Size(38, 84)
        player.SizeMode = PictureBoxSizeMode.Zoom
        player.TabIndex = 13
        player.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = My.Resources.Resources.bus
        enemy2.Location = New Point(241, 142)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(54, 145)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 14
        enemy2.TabStop = False
        ' 
        ' enemy3
        ' 
        enemy3.Image = My.Resources.Resources.truck
        enemy3.Location = New Point(124, 9)
        enemy3.Name = "enemy3"
        enemy3.Size = New Size(49, 190)
        enemy3.SizeMode = PictureBoxSizeMode.Zoom
        enemy3.TabIndex = 15
        enemy3.TabStop = False
        ' 
        ' enemy4
        ' 
        enemy4.Image = My.Resources.Resources.bantay
        enemy4.Location = New Point(24, 66)
        enemy4.Name = "enemy4"
        enemy4.Size = New Size(33, 50)
        enemy4.SizeMode = PictureBoxSizeMode.Zoom
        enemy4.TabIndex = 16
        enemy4.TabStop = False
        ' 
        ' GameOver
        ' 
        GameOver.AutoSize = True
        GameOver.BackColor = Color.White
        GameOver.Font = New Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GameOver.ForeColor = Color.Red
        GameOver.Location = New Point(75, 164)
        GameOver.Name = "GameOver"
        GameOver.Size = New Size(197, 59)
        GameOver.TabIndex = 17
        GameOver.Text = "GAME OVER"
        GameOver.Visible = False
        ' 
        ' ReplayButton
        ' 
        ReplayButton.Font = New Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReplayButton.Location = New Point(135, 238)
        ReplayButton.Name = "ReplayButton"
        ReplayButton.Size = New Size(78, 38)
        ReplayButton.TabIndex = 18
        ReplayButton.Text = "REPLAY"
        ReplayButton.UseVisualStyleBackColor = True
        ReplayButton.Visible = False
        ' 
        ' RoadMover
        ' 
        RoadMover.Enabled = True
        RoadMover.Interval = 10
        ' 
        ' RightSide
        ' 
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Interval = 10
        ' 
        ' EnemyMover1
        ' 
        EnemyMover1.Enabled = True
        EnemyMover1.Interval = 10
        ' 
        ' EnemyMover2
        ' 
        EnemyMover2.Enabled = True
        EnemyMover2.Interval = 10
        ' 
        ' EnemyMover3
        ' 
        EnemyMover3.Enabled = True
        EnemyMover3.Interval = 10
        ' 
        ' EnemyMover4
        ' 
        EnemyMover4.Enabled = True
        EnemyMover4.Interval = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(334, 461)
        Controls.Add(ReplayButton)
        Controls.Add(GameOver)
        Controls.Add(enemy4)
        Controls.Add(enemy3)
        Controls.Add(enemy2)
        Controls.Add(player)
        Controls.Add(enemy1)
        Controls.Add(SpeedLabel)
        Controls.Add(ScoreLabel)
        Controls.Add(road8)
        Controls.Add(road7)
        Controls.Add(road6)
        Controls.Add(road5)
        Controls.Add(road4)
        Controls.Add(road3)
        Controls.Add(road2)
        Controls.Add(road1)
        MaximumSize = New Size(350, 500)
        MinimumSize = New Size(350, 500)
        Name = "Form1"
        Text = "Car Racing Game"
        CType(road1, ComponentModel.ISupportInitialize).EndInit()
        CType(road2, ComponentModel.ISupportInitialize).EndInit()
        CType(road4, ComponentModel.ISupportInitialize).EndInit()
        CType(road3, ComponentModel.ISupportInitialize).EndInit()
        CType(road5, ComponentModel.ISupportInitialize).EndInit()
        CType(road6, ComponentModel.ISupportInitialize).EndInit()
        CType(road8, ComponentModel.ISupportInitialize).EndInit()
        CType(road7, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy1, ComponentModel.ISupportInitialize).EndInit()
        CType(player, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents road1 As PictureBox
    Friend WithEvents road2 As PictureBox
    Friend WithEvents road4 As PictureBox
    Friend WithEvents road3 As PictureBox
    Friend WithEvents road5 As PictureBox
    Friend WithEvents road6 As PictureBox
    Friend WithEvents road8 As PictureBox
    Friend WithEvents road7 As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents SpeedLabel As Label
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents player As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents enemy4 As PictureBox
    Friend WithEvents GameOver As Label
    Friend WithEvents ReplayButton As Button
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents EnemyMover1 As Timer
    Friend WithEvents EnemyMover2 As Timer
    Friend WithEvents EnemyMover3 As Timer
    Friend WithEvents EnemyMover4 As Timer

End Class
