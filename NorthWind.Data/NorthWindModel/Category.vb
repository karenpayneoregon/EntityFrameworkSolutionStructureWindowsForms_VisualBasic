Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace NorthWindModel
    Partial Public Class Category
        Public Sub New()
            Products = New HashSet(Of Product)()
        End Sub

        Public Property CategoryID As Integer

        <Required>
        <StringLength(15)>
        Public Property CategoryName As String

        <Column(TypeName:="ntext")>
        Public Property Description As String

        <Column(TypeName:="image")>
        Public Property Picture As Byte()

        Public Property ModifiedDate As Date?

        Public Property InUse As Boolean?

        Public Overridable Property Products As ICollection(Of Product)
    End Class
End Namespace