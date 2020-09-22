Imports RelationsSimple.Classes

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '
        ' Columns are defined in the designer of each DataGridView
        '
        PhoneDataGridView.AutoGenerateColumns = False
        EmailDataGridView.AutoGenerateColumns = False

        '
        ' Get all contact, show first and last name
        '
        ContactsComboBox.DataSource = ContactOperations.GetAllContacts()

        '
        ' Get phone numbers and email addresses for the current person
        '
        GetCurrentPersonDetails()

    End Sub
    ''' <summary>
    ''' Get person details
    ''' </summary>
    Private Sub GetCurrentPersonDetails()

        '
        ' Get current person for their primary key
        '
        Dim personEntity = CType(ContactsComboBox.SelectedItem, PersonEntity)

        '
        ' Show phones and emails
        '
        PhoneDataGridView.DataSource = ContactOperations.PersonPhones(personEntity.PersonId)
        EmailDataGridView.DataSource = ContactOperations.PersonEmailAddresses(personEntity.PersonId)

        PhoneDataGridView.ExpandColumns()
        EmailDataGridView.ExpandColumns()

    End Sub

    Private Sub ContactsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ContactsComboBox.SelectedIndexChanged

        GetCurrentPersonDetails()

    End Sub
End Class
