Public Class HUD

    Public Sub Init()

    End Sub

    Public Sub Update()

    End Sub

    Public Sub Render(device As Graphics)
        device.FillRectangle(Brushes.White, New Rectangle(0, 0, Form1.Size.Width, 32))
        device.DrawString("Factree Development Build", Fonts.GetFont(18), Brushes.Black, New PointF(0, 0))
    End Sub
End Class
