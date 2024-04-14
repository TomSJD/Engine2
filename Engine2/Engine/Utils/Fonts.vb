Public Class Fonts
    Public Shared Function GetFont(ByVal size As Integer) As Font
        Return New Font("Arial", size)
    End Function

    Public Shared Function GetFont(ByVal size As Integer, ByVal style As FontStyle) As Font
        Return New Font("Arial", size, style)
    End Function

    Public Shared Function GetFont(ByVal size As Integer, ByVal style As FontStyle, ByVal unit As GraphicsUnit) As Font
        Return New Font("Arial", size, style, unit)
    End Function

    Public Shared Function GetFont(ByVal familyName As String, ByVal size As Integer) As Font
        Return New Font(familyName, size)
    End Function

    Public Shared Function GetFont(ByVal familyName As String, ByVal size As Integer, ByVal style As FontStyle) As Font
        Return New Font(familyName, size, style)
    End Function

    Public Shared Function GetFont(ByVal familyName As String, ByVal size As Integer, ByVal style As FontStyle, ByVal unit As GraphicsUnit) As Font
        Return New Font(familyName, size, style, unit)
    End Function

    Public Shared Function GetFont(ByVal family As FontFamily, ByVal size As Integer, ByVal style As FontStyle, ByVal unit As GraphicsUnit) As Font
        Return New Font(family, size, style, unit)
    End Function

    Public Shared Function GetFont(ByVal family As FontFamily, ByVal size As Single, ByVal style As FontStyle, ByVal unit As GraphicsUnit, ByVal gdiCharSet As Byte) As Font
        Return New Font(family, size, style, unit, gdiCharSet)
    End Function

    Public Shared Function GetFont(ByVal family As FontFamily, ByVal emSize As Single, ByVal style As FontStyle, ByVal unit As GraphicsUnit, ByVal gdiCharSet As Byte, ByVal gdiVerticalFont As Boolean) As Font
        Return New Font(family, emSize, style, unit, gdiCharSet, gdiVerticalFont)
    End Function

    Public Shared Function GetStringWidth(ByVal text As String, ByVal font As Font) As Single
        Return TextRenderer.MeasureText(text, font).Width
    End Function
End Class
