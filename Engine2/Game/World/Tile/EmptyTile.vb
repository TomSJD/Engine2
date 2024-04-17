Public Class EmptyTile : Inherits Tile

    Public Sub New(x As Integer, y As Integer)
        MyBase.New("Empty", x, y)
    End Sub

    Public Overrides Sub Render(device As Graphics)
        device.FillRectangle(Brushes.Black, New Rectangle(X * TILE_SIZE, Y * TILE_SIZE, TILE_SIZE, TILE_SIZE))
    End Sub

End Class
