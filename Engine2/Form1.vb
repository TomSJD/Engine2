Public Class Form1

    Private game As Game

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        game = New Game(Me, GameInfo.TITLE + " | " + GameInfo.BUILD, 800, 600)
        game.Init()
    End Sub
End Class
