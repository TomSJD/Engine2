Imports System.Runtime.InteropServices

Public MustInherit Class Tile

    Public Const TILE_SIZE As Integer = 32

    Private _x As Integer
    Private _y As Integer
    Private _name As String

    Public Sub New(ByVal name As String, ByVal x As Integer, ByVal y As Integer)
        _name = name
        _x = x
        _y = y
    End Sub

    Public Overridable Sub Update()
    End Sub
    Public MustOverride Sub Render(device As Graphics)

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property X As Integer
        Get
            Return _x
        End Get
    End Property

    Public ReadOnly Property Y As Integer
        Get
            Return _y
        End Get
    End Property
End Class
