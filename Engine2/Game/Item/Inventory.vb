Public Class Inventory

    Private _items As List(Of ItemStack)
    Private _maxItems As Integer

    Public Sub New(ByVal maxItems As Integer)
        _items = New List(Of ItemStack)
        _maxItems = maxItems
    End Sub

    Public Function AddItem(ByVal item As Item, ByVal quantity As Integer) As Boolean
        If _items.Count >= _maxItems Then
            Return False
        End If

        Dim stack As ItemStack = FindStack(item)
        If stack Is Nothing Then
            stack = New ItemStack(item, 0)
            _items.Add(stack)
        End If

        stack.Quantity += quantity
        Return True
    End Function

    Public Function FindStack(ByVal item As Item) As ItemStack
        For Each stack As ItemStack In _items
            If stack.Item.ID = item.ID Then
                Return stack
            End If
        Next

        Return Nothing
    End Function

End Class
