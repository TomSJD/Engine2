Public Class TestState : Inherits State

    Private _chunks As List(Of Chunk)

    Public Overrides Sub InitState()
        _chunks = New List(Of Chunk)
        GenerateTestChunks()
    End Sub

    Private Sub GenerateTestChunks()
        For x As Integer = 0 To 1
            For y As Integer = 0 To 1
                Dim chunk As New Chunk(x, y)
                _chunks.Add(chunk)
            Next
        Next
    End Sub

    Public Overrides Sub Tick(delta As Double)

    End Sub

    Public Overrides Sub Render(device As Graphics)
        For Each chunk As Chunk In _chunks
            For x As Integer = 0 To Chunk.CHUNK_SIZE - 1
                For y As Integer = 0 To Chunk.CHUNK_SIZE - 1
                    Dim tile As Tile = chunk.GetTile(x, y)
                    device.FillRectangle(tile.TestColour,
                                         chunk.ChunkX * (Chunk.CHUNK_SIZE * Tile.TILE_SIZE) + Tile.TILE_SIZE * x,
                                         chunk.ChunkY * (Chunk.CHUNK_SIZE * Tile.TILE_SIZE) + Tile.TILE_SIZE * y,
                                         Tile.TILE_SIZE - 1, Tile.TILE_SIZE - 1)
                Next
            Next
        Next
    End Sub

    Public Overrides Sub EndState()

    End Sub
End Class
