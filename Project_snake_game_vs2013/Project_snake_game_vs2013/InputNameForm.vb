Public Class InputNameForm
    Public player As String
    Public scorePlayer As Integer
    Private Sub Initialize()
        scorePlayer = 0
        player = " "
    End Sub

    Private Sub scoreSave()
        CongratulationForm.ScoreTotal = scorePlayer
        player = PlayerName.Text
        'playername and score player automaticaly saved at Highscore table in mysql or ms. access
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
        PlayerName.Text = "[Noname]" 'seting default name for highscore
        scoreSave()
        Initialize()
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        PlayerName.Text = " "
    End Sub


    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        scoreSave()
        CongratulationForm.Show()
        Me.Close()
        SnakeGame.Close()
        Initialize()
        'show playername and score first at new form where it has 2 button (MainMenu and Show Table)
    End Sub
End Class