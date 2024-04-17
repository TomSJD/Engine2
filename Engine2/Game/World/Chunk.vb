Public Class Chunk

    Public Const CHUNK_SIZE As Integer = 16

    Private _chunkX As Integer
    Private _chunkY As Integer
    Private _tiles(CHUNK_SIZE, CHUNK_SIZE) As Tile

    Public Sub New(ByVal chunkX As Integer, ByVal chunkY As Integer)
        _chunkX = chunkX
        _chunkY = chunkY
        FillChunk()
    End Sub

    Private Sub FillChunk()
        Dim randomColour As Brush = RandomBrush()
        For x As Integer = 0 To CHUNK_SIZE - 1
            For y As Integer = 0 To CHUNK_SIZE - 1
                _tiles(x, y) = New TestTile(randomColour)
            Next
        Next
    End Sub

    Public Function GetTile(ByVal x As Integer, ByVal y As Integer) As Tile
        Return _tiles(x, y)
    End Function

    Public ReadOnly Property ChunkX As Integer
        Get
            Return _chunkX
        End Get
    End Property

    Public ReadOnly Property ChunkY As Integer
        Get
            Return _chunkY
        End Get
    End Property

    ' Test function to generate a random brush colour
    Public Shared Function RandomBrush() As Brush
        Dim rand As New Random()
        Dim r As Integer = rand.Next(0, 255)
        Dim g As Integer = rand.Next(0, 255)
        Dim b As Integer = rand.Next(0, 255)
        Return New SolidBrush(Color.FromArgb(r, g, b))
    End Function
End Class
