Public MustInherit Class Tile

    Public Const TILE_SIZE As Integer = 32

    Private _name As String
    Private _testColour As Brush

    Public Sub New(ByVal name As String, ByVal testColour As Brush)
        _name = name
        _testColour = testColour
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property TestColour As Brush
        Get
            Return _testColour
        End Get
    End Property
End Class
