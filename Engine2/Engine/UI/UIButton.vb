Public Class UIButton : Inherits UIComponent : Implements IInput

    Private _text As String
    Private _font As Font
    Private _textBrush As Brush
    Private _backgroundBrush As Brush
    Private _runAction As Func(Of Boolean)
    Private _size As New SizeF
    Private _padding As Integer = 8

    Public Sub New(ByRef position As PointF, ByVal text As String, ByVal font As Font, ByVal textBrush As Brush, ByVal backgroundBrush As Brush, ByVal runAction As Func(Of Boolean))
        MyBase.New(position)
        _text = text
        _font = font
        _textBrush = textBrush
        _backgroundBrush = backgroundBrush
        _runAction = runAction
    End Sub

    Public Overrides Sub Update()
        _size = New SizeF(Fonts.GetStringWidth(_text, _font) + _padding, _font.GetHeight + _padding)
    End Sub

    Public Overrides Sub Render(device As Graphics)
        device.FillRectangle(_backgroundBrush, New RectangleF(Position, _size))
        device.DrawString(_text, _font, _textBrush, New PointF(Position.X + _padding / 2, Position.Y + _padding / 2))
    End Sub

    Public Sub MouseClicked(e As MouseEventArgs) Implements IInput.MouseClicked
        If InputManager.MousePosition.X > Position.X And InputManager.MousePosition.X < Position.X + _size.Width And
            InputManager.MousePosition.Y > Position.Y And InputManager.MousePosition.Y < Position.Y + _size.Height Then
            _runAction.Invoke()
        End If
    End Sub
End Class
