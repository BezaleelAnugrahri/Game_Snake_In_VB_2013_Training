Public Class MainMenu


    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        SnakeGame.Show() 'go to the game scene first or input player name first
        Me.Close()
    End Sub

    Private Sub score_Click(sender As Object, e As EventArgs) Handles score.Click
        'showing table score form(from highest to lowest) in database mysql
        HighscoreTable.Show()
        Me.Close()
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click

        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'Me.Close()
            Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If copyright.Location.X + copyright.Width < 0 Then
            copyright.Location = New Point(Me.Width, copyright.Location.Y)
        Else
            copyright.Location = New Point(copyright.Location.X - 5, copyright.Location.Y)
        End If
    End Sub
End Class
