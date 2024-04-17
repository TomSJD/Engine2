Public MustInherit Class Item

    Private _id As Integer
    Private _name As String

    Public Sub New(ByVal id As Integer, ByVal name As String)
        _id = id
        _name = name
    End Sub

    Public ReadOnly Property ID As Integer
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
End Class
