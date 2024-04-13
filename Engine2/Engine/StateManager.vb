Public Class StateManager

    Private currentState As State

    Public Sub New(ByVal newState As State)
        Me.currentState = newState
        currentState.InitState()
    End Sub

    Public Sub Tick(ByVal delta As Double)
        currentState.Tick(delta)
    End Sub

    Public Sub Render(ByVal device As Graphics)
        currentState.Render(device)
    End Sub

    Public Sub ChangeState(ByVal newState As State)
        Me.currentState.EndState()
        Me.currentState = newState
        Me.currentState.InitState()
    End Sub

    Public Sub Dispose()
        Me.currentState.EndState()
        currentState = Nothing
    End Sub
End Class
