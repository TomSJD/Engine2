Public MustInherit Class UIComponent

    Private _position As PointF

    Public Sub New(ByVal position As PointF)
        _position = position
    End Sub

    Public MustOverride Sub Update()
    Public MustOverride Sub Render(device As Graphics)

    Public Property Position As PointF
        Get
            Return _position
        End Get
        Set(value As PointF)
            _position = value
        End Set
    End Property
End Class
