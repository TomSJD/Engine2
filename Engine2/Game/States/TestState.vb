Public Class TestState : Inherits State

    Public Overrides Sub InitState()

    End Sub

    Public Overrides Sub Tick(delta As Double)

    End Sub

    Public Overrides Sub Render(device As Graphics)
        device.FillRectangle(Brushes.Black, 0, 0, 800, 600)
    End Sub

    Public Overrides Sub EndState()

    End Sub
End Class
