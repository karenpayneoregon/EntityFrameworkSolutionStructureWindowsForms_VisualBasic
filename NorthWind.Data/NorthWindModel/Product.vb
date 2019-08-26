Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


Namespace NorthWindModel

    Partial Public Class Product
        Public Sub New()
            OrderDetails = New HashSet(Of OrderDetail)()
        End Sub

        Public Property ProductID As Integer

        <Required>
        <StringLength(40)>
        Public Property ProductName As String

        Public Property SupplierID As Integer?

        Public Property CategoryID As Integer?

        <StringLength(20)>
        Public Property QuantityPerUnit As String

        <Column(TypeName:="money")>
        Public Property UnitPrice As Decimal?

        Public Property UnitsInStock As Short?

        Public Property UnitsOnOrder As Short?

        Public Property ReorderLevel As Short?

        Public Property ModifiedDate As Date?

        Public Property InUse As Boolean?

        Public Overridable Property Category As Category

        Public Overridable Property OrderDetails As ICollection(Of OrderDetail)

        Public Overridable Property Supplier As Supplier
    End Class
End Namespace