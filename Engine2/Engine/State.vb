Public MustInherit Class State
    Public MustOverride Sub InitState()
    Public MustOverride Sub Tick(ByVal delta As Double)
    Public MustOverride Sub Render(ByVal device As Graphics)
    Public MustOverride Sub EndState()
End Class
