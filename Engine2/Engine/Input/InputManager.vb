Public Class InputManager

    Private Shared INSTANCE As InputManager

    Private Shared _inputEventSubscribers As New List(Of IInput)
    Private Shared _mousePosition As Point
    Private Shared _keys(265) As Boolean

    Public Shared Sub RegisterForEvents(subscriber As IInput)
        _inputEventSubscribers.Add(subscriber)
    End Sub

    Public Shared Sub MouseClick(e As MouseEventArgs)
        For Each subscriber As IInput In _inputEventSubscribers
            subscriber.MouseClicked(e)
        Next
    End Sub

    Public Shared Sub MouseMove(newX As Integer, newY As Integer)
        _mousePosition = New Point(newX, newY)
    End Sub

    Public Shared Sub KeyDown(keyCode As Integer)
        If keyCode < 1 Or keyCode > _keys.Length Then
            Return
        End If
        _keys(keyCode) = True
    End Sub

    Public Shared Sub KeyUp(keyCode As Integer)
        If keyCode < 1 Or keyCode > _keys.Length Then
            Return
        End If
        _keys(keyCode) = False
    End Sub

    Public Shared ReadOnly Property MousePosition As Point
        Get
            Return _mousePosition
        End Get
    End Property

    Public Shared ReadOnly Property IsKeyDown(keyCode As Integer) As Boolean
        Get
            If keyCode < 1 Or keyCode > _keys.Length Then
                Return False
            End If
            Return _keys(keyCode)
        End Get
    End Property

End Class
