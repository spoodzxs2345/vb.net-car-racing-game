Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 5

        road(0) = road1
        road(1) = road2
        road(2) = road3
        road(3) = road4
        road(4) = road5
        road(5) = road6
        road(6) = road7
        road(7) = road8

    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        If (score > 10 And score < 30) Then
            speed = 7
        End If
        If (score > 30 And score < 60) Then
            speed = 9
        End If
        If (score > 60 And score < 100) Then
            speed = 11
        End If
        If (score > 100 And score < 150) Then
            speed = 15
        End If
        If (score > 150 And score < 200) Then
            speed = 17
        End If
        If (score > 200 And score < 250) Then
            speed = 20
        End If
        If (score > 250) Then
            speed = 50
        End If

        SpeedLabel.Text = "Speed: " & speed
        If (player.Bounds.IntersectsWith(enemy1.Bounds)) Then
            Game_Over()
        End If
        If (player.Bounds.IntersectsWith(enemy2.Bounds)) Then
            Game_Over()
        End If
        If (player.Bounds.IntersectsWith(enemy3.Bounds)) Then
            Game_Over()
        End If
        If (player.Bounds.IntersectsWith(enemy4.Bounds)) Then
            Game_Over()
        End If
    End Sub

    Private Sub Game_Over()
        GameOver.Visible = True
        ReplayButton.Visible = True
        RoadMover.Stop()
        EnemyMover1.Stop()
        EnemyMover2.Stop()
        EnemyMover3.Stop()
        EnemyMover4.Stop()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        End If

        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If (player.Location.X < 281) Then
            player.Left += 5
        End If
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If (player.Location.X > 0) Then
            player.Left -= 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSide.Stop()
        LeftSide.Stop()
    End Sub

    Private Sub EnemyMover1_Tick(sender As Object, e As EventArgs) Handles EnemyMover1.Tick
        enemy1.Top += speed / 2
        If enemy1.Top >= Me.Height Then
            score += 1
            ScoreLabel.Text = "Score: " & score
            enemy1.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + enemy1.Height)
            enemy1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        End If
    End Sub

    Private Sub EnemyMover2_Tick(sender As Object, e As EventArgs) Handles EnemyMover2.Tick
        enemy2.Top += speed / 3
        If enemy2.Top >= Me.Height Then
            score += 1
            ScoreLabel.Text = "Score: " & score
            enemy2.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + enemy2.Height)
            enemy2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
        End If
    End Sub

    Private Sub EnemyMover3_Tick(sender As Object, e As EventArgs) Handles EnemyMover3.Tick
        enemy3.Top += speed * 1 / 2
        If enemy3.Top >= Me.Height Then
            score += 1
            ScoreLabel.Text = "Score: " & score
            enemy3.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + enemy3.Height)
            enemy3.Left = CInt(Math.Ceiling(Rnd() * 120)) + 180
        End If
    End Sub

    Private Sub EnemyMover4_Tick(sender As Object, e As EventArgs) Handles EnemyMover4.Tick
        enemy4.Top += speed * 1 / 2
        If enemy4.Top >= Me.Height Then
            score += 1
            ScoreLabel.Text = "Score: " & score
            enemy4.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + enemy4.Height)
            enemy4.Left = CInt(Math.Ceiling(Rnd() * 120)) + 280
        End If
    End Sub

    Private Sub ReplayButton_Click(sender As Object, e As EventArgs) Handles ReplayButton.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
