Namespace NorthWindOperations
    Public Class CustomerEntity
        Public Property CustomerIdentifier As Integer
        Public Property CompanyName As String
        Public Property ContactTitle As String
        Public Property ContactIdentifier As Integer?
        Public Property ContactTypeIdentifier As Integer
        Public Property FirstName As String
        Public Property LastName As String
        Public Property PostalCode As String
        Public Property CountryIdentifier As Integer?
        Public Property CountyName As String
        Public Property Address As String
        Public Property City As String

        Public Overrides Function ToString() As String
            Return $"{CustomerIdentifier} {CompanyName}"
        End Function
    End Class
End NameSpace