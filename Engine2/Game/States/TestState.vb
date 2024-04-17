Public Class TestState : Inherits State

    Public Const WORLD_SIZE As Integer = 128
    Private Shared _tiles(WORLD_SIZE, WORLD_SIZE) As Tile

    Private _hud As HUD

    Public Overrides Sub InitState()
        ' Generate the world
        ClearWorldTiles()
        GenerateOres()
        ' Init the HUD
        _hud = New HUD()
        _hud.Init()
    End Sub

    ' Should never be run unless a new world is created
    Private Sub ClearWorldTiles()
        For x As Integer = 0 To WORLD_SIZE - 1
            For y As Integer = 0 To WORLD_SIZE - 1
                _tiles(x, y) = New EmptyTile(x, y)
            Next
        Next
    End Sub

    Private Sub GenerateOres()
        Dim random As New Random()
        For x As Integer = 0 To WORLD_SIZE - 1
            For y As Integer = 0 To WORLD_SIZE - 1
                If random.Next(0, 100) < 1 Then
                    _tiles(x, y) = New IronOre(x, y)
                End If
            Next
        Next
    End Sub

    Public Overrides Sub Tick(delta As Double)
        _hud.Update()
        For x As Integer = 0 To WORLD_SIZE - 1
            For y As Integer = 0 To WORLD_SIZE - 1
                _tiles(x, y).Update()
            Next
        Next

        ' When the user clicks a tile set it to a new Miner tile
        If InputManager.IsKeyDown(Keys.A) Then
            Dim x As Integer = InputManager.MousePosition.X \ Tile.TILE_SIZE
            Dim y As Integer = InputManager.MousePosition.Y \ Tile.TILE_SIZE
            If x < WORLD_SIZE And y < WORLD_SIZE Then
                _tiles(x, y) = New Miner(x, y)
            End If
        End If
    End Sub

    Public Overrides Sub Render(device As Graphics)
        For x As Integer = 0 To WORLD_SIZE - 1
            For y As Integer = 0 To WORLD_SIZE - 1
                If x * Tile.TILE_SIZE > Form1.Size.Width Or y * Tile.TILE_SIZE > Form1.Size.Height Then
                    Continue For
                End If

                Dim current As Tile = _tiles(x, y)
                current.Render(device)
            Next
        Next
        _hud.Render(device)
    End Sub

    Public Overrides Sub EndState()

    End Sub

    Public Shared Function GetTileAtCoords(x As Integer, y As Integer) As Tile
        Return _tiles(x, y)
    End Function
End Class
