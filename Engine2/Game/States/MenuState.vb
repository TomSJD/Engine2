Public Class MenuState : Inherits State

    Public Overrides Sub InitState()

    End Sub

    Public Overrides Sub Tick(ByVal delta As Double)

    End Sub

    Public Overrides Sub Render(ByVal device As Graphics)
        device.FillRectangle(Brushes.Red, 100, 100, 100, 100)
    End Sub

    Public Overrides Sub EndState()

    End Sub
End Class
