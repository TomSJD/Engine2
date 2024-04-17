Public Class TickTimer

    Private _ticks As Integer = 0

    Public Sub New()

    End Sub

    Public Sub Reset()
        _ticks = 0
    End Sub

    Public Sub Tick()
        _ticks += 1
    End Sub

    Public Function HasElapsed(elapsed As Integer, resetTimer As Boolean) As Boolean
        If _ticks >= elapsed Then
            If resetTimer Then
                Reset()
            End If
            Return True
        End If
        Return False
    End Function

    Public Function GetTicks() As Integer
        Return _ticks
    End Function
End Class
