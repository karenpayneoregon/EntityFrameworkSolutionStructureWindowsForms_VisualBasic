Public Class DataOperations
    Public Shared Function Categories() As List(Of Category)
        Using context As New NorthWindContext
            Return context.Categories.ToList()
        End Using
    End Function
    Public Shared Function ProductsByCategory(categoryIdentifier As Integer?) As List(Of Product)
        Using context As New NorthWindContext
            Return context.Products.AsEnumerable().Where(Function(product) product.CategoryID.Value = categoryIdentifier.Value).ToList
        End Using
    End Function
    Public Shared Function SingleProduct(identifier As Integer, quantity As Integer) As ProductItem
        Using context As New NorthWindContext
            Dim selectedProduct As Product = context.Products.FirstOrDefault(Function(product) product.ProductID = identifier)
            Return New ProductItem() With {
                .ProductID = selectedProduct.ProductID,
                .ProductName = selectedProduct.ProductName,
                .Quantity = quantity,
                .UnitPrice = selectedProduct.UnitPrice,
                .CategoryID = selectedProduct.CategoryID}
        End Using
    End Function
End Class
