Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


Namespace NorthWindModel

    Partial Public Class Shipper
        Public Sub New()
            Orders = New HashSet(Of Order)()
        End Sub

        <DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property ShipperID As Integer

        <Required>
        <StringLength(40)>
        Public Property CompanyName As String

        <StringLength(24)>
        Public Property Phone As String

        Public Overridable Property Orders As ICollection(Of Order)
    End Class
End Namespace