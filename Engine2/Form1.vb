Public Class Form1

    Private game As Game

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        game = New Game(Me, GameInfo.TITLE + " | " + GameInfo.BUILD, 800, 600)
        game.Init()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        InputManager.KeyDown(e.KeyValue)
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        InputManager.KeyUp(e.KeyValue)
    End Sub
End Class
