Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace NorthWindModel

    <Table("Contact")>
    Partial Public Class Contact
        Public Sub New()
            ContactContactDevices = New HashSet(Of ContactContactDevice)()
            Customers = New HashSet(Of Customer)()
        End Sub

        <Key>
        Public Property ContactIdentifier As Integer

        Public Property FirstName As String

        Public Property LastName As String

        Public Property ModifiedDate As Date?

        Public Property InUse As Boolean?

        Public Overridable Property ContactContactDevices As ICollection(Of ContactContactDevice)

        Public Overridable Property Customers As ICollection(Of Customer)
    End Class
End Namespace