Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


Namespace NorthWindModel

    <Table("ContactType")>
    Partial Public Class ContactType
        Public Sub New()
            Customers = New HashSet(Of Customer)()
        End Sub

        <Key>
        Public Property ContactTypeIdentifier As Integer

        Public Property ContactTitle As String

        Public Overridable Property Customers As ICollection(Of Customer)
    End Class
End Namespace