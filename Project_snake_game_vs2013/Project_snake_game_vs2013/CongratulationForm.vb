Public Class CongratulationForm

    Public ScoreTotal As Integer
    Public NamePlayer As String

    Private Sub Auto()
        NamePlayer = InputNameForm.player
    End Sub
    Private Sub GoToMainmenu_Click(sender As Object, e As EventArgs) Handles GoToMainmenu.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Table_Click(sender As Object, e As EventArgs) Handles Table.Click
        HighscoreTable.Show()
        Me.Close()
    End Sub

    Private Sub CongratulationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auto()
        Label2.Text = "Your Name : "
        Label3.Text = NamePlayer
        Label4.Text = "Score : "
        Label5.Text = ScoreTotal
    End Sub
End Class