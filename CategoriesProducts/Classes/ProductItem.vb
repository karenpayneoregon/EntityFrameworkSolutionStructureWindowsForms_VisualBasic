Public Class ProductItem
    Public Property CategoryID As Integer?
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property Quantity() As Integer
    Public Property UnitPrice As Decimal?

    Public Overrides Function ToString() As String
        Return $"{ProductName} -> {Quantity}"
    End Function
End Class
