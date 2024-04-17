Public Class Miner : Inherits FactoryTile

    Public Const MINE_TIME_TICKS As Integer = 10

    Private _inventory As Inventory
    Private _surroundingOres As List(Of Point)
    Private _timer As TickTimer

    Public Sub New(x As Integer, y As Integer)
        MyBase.New(x, y)
        _inventory = New Inventory(1)
        FindSurroundingOres()
        _timer = New TickTimer()
    End Sub

    Private Sub FindSurroundingOres()
        _surroundingOres = New List(Of Point)
        For x As Integer = x - 1 To x + 1
            For y As Integer = y - 1 To y + 1
                If x = Me.X And y = Me.Y Then
                    Continue For
                End If
                If x < 0 Or x >= TestState.WORLD_SIZE Or y < 0 Or y >= TestState.WORLD_SIZE Then
                    Continue For
                End If
                If TestState.GetTileAtCoords(x, y).GetType() = GetType(IronOre) Then
                    _surroundingOres.Add(New Point(x, y))
                End If
            Next
        Next

    End Sub

    Public Overrides Sub Update()
        If _timer.HasElapsed(MINE_TIME_TICKS, True) Then
            For Each ore As Point In _surroundingOres
                _inventory.AddItem(Items.IRON_ORE_ITEM, 1)
            Next
        End If
        _timer.Tick()
    End Sub

    Public Overrides Sub Render(device As Graphics)
        Dim stack As ItemStack = _inventory.FindStack(Items.IRON_ORE_ITEM)
        device.FillRectangle(Brushes.Blue, New Rectangle(X * TILE_SIZE, Y * TILE_SIZE, TILE_SIZE, TILE_SIZE))
        If stack IsNot Nothing Then
            device.DrawString(stack.Quantity, Fonts.GetFont(18), Brushes.White, New PointF(X * TILE_SIZE, Y * TILE_SIZE))
        End If
    End Sub

End Class