Imports RelationsSimple.Models

Namespace Classes

    ''' <summary>
    ''' All data operations are done here and called from a form.
    ''' </summary>
    Public Class ContactOperations
        ''' <summary>
        ''' Get all people without navigation properties
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetAllContacts() As List(Of PersonEntity)

            Using context As New ContactContext
                Return context.People.Select(Function(person) New PersonEntity With {
                                                .PersonId = person.PersonId,
                                                .FirstName = person.FirstName,
                                                .LastName = person.LastName}).ToList()
            End Using
        End Function
        ''' <summary>
        ''' Get all phone numbers for a person without navigation properties
        ''' </summary>
        ''' <param name="personId"></param>
        ''' <returns></returns>
        Public Shared Function PersonPhones(personId As Integer?) As List(Of PhoneEntity)
            Using context As New ContactContext
                Return context.Phones.
                    Where(Function(phone) CBool(phone.PersonId = personId)).
                    Select(Function(phone) New PhoneEntity With {
                              .PersonId = phone.PersonId,
                              .PhoneType = phone.PhoneType,
                              .PhoneNumber = phone.PhoneNumber,
                              .PhoneNumberId = phone.PhoneNumberId}).ToList()
            End Using
        End Function
        ''' <summary>
        ''' Get all email addresses for a person without navigation properties
        ''' </summary>
        ''' <param name="personId"></param>
        ''' <returns></returns>
        Public Shared Function PersonEmailAddresses(personId As Integer?) As List(Of EmailEntity)
            Using context As New ContactContext
                Return context.Emails.
                    Where(Function(email) CBool(email.PersonId = personId)).
                    Select(Function(email) New EmailEntity With {
                              .PersonId = email.PersonId,
                              .EmailType = email.EmailType,
                              .EmailAddress = email.EmailAddress,
                              .EmailIdentifier = email.EmailIdentifier}).ToList()
            End Using
        End Function
    End Class
End Namespace