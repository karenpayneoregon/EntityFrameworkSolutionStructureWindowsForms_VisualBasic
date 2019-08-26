Imports NorthWind.Data.Contexts
Namespace NorthWindOperations
    Public Class Operations
        Public Function CustomerJoined() As List(Of CustomerEntity)

            Using context = New NorthWindContext()
                Return (
                        From customer In context.Customers
                        Join contactType In context.ContactTypes On customer.ContactTypeIdentifier _
                            Equals contactType.ContactTypeIdentifier
                        Join contact In context.Contacts On customer.ContactIdentifier _
                            Equals contact.ContactIdentifier
                        Join country In context.Countries On customer.CountryIdentfier _
                            Equals country.Id
                        Select New CustomerEntity With
                            {
                                .CustomerIdentifier = customer.CustomerIdentifier,
                                .CompanyName = customer.CompanyName,
                                .ContactIdentifier = customer.ContactIdentifier,
                                .FirstName = contact.FirstName,
                                .LastName = contact.LastName,
                                .ContactTypeIdentifier = contactType.ContactTypeIdentifier,
                                .ContactTitle = contactType.ContactTitle,
                                .Address = customer.Street,
                                .City = customer.City,
                                .PostalCode = customer.PostalCode,
                                .CountryIdentifier = customer.CountryIdentfier,
                                .CountyName = country.CountryName}
                    ).ToList()

            End Using
        End Function
    End Class
End Namespace