Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace NorthWindModel

    Partial Public Class OrderDetail
        <Key>
        <Column(Order:=0)>
        <DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property OrderID As Integer

        <Key>
        <Column(Order:=1)>
        <DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property ProductID As Integer

        <Column(TypeName:="money")>
        Public Property UnitPrice As Decimal

        Public Property Quantity As Short

        Public Property Discount As Single

        Public Overridable Property Order As Order

        Public Overridable Property Product As Product
    End Class
End Namespace