
Public Class MenuState : Inherits State

    Private _menuButtons As List(Of UIButton)

    Public Overrides Sub InitState()
        _menuButtons = New List(Of UIButton)
        _menuButtons.Add(New UIButton(New PointF(100, 100), "Start", Fonts.GetFont(18), Brushes.White, Brushes.Black, Function() As Boolean
                                                                                                                          Game.stateManager.ChangeState(New TestState)
                                                                                                                          Return True
                                                                                                                      End Function))
        InputManager.RegisterForEvents(_menuButtons.ElementAt(0))
    End Sub

    Public Overrides Sub Tick(ByVal delta As Double)
        For Each btn As UIButton In _menuButtons
            btn.Update()
        Next
    End Sub

    Public Overrides Sub Render(ByVal device As Graphics)
        For Each btn As UIButton In _menuButtons
            btn.Render(device)
        Next
    End Sub

    Public Overrides Sub EndState()

    End Sub
End Class
