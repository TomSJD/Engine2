Public Class ItemStack

    Public Property Item As Item
    Public Property Quantity As Integer

    Public Sub New(ByVal item As Item, ByVal quantity As Integer)
        Me.Item = item
        Me.Quantity = quantity
    End Sub

End Class
