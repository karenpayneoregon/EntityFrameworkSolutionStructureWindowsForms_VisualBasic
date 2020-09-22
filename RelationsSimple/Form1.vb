Imports RelationsSimple.Classes

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PhoneDataGridView.AutoGenerateColumns = False
        EmailDataGridView.AutoGenerateColumns = False

        ContactsComboBox.DataSource = ContactOperations.GetAllContacts()

        GetCurrentPersonDetails()

    End Sub
    Private Sub GetCurrentPersonDetails()
        Dim personEntity = CType(ContactsComboBox.SelectedItem, PersonEntity)
        PhoneDataGridView.DataSource = ContactOperations.PersonPhones(personEntity.PersonId)
        EmailDataGridView.DataSource = ContactOperations.PersonEmailAddresses(personEntity.PersonId)

        PhoneDataGridView.ExpandColumns()
        EmailDataGridView.ExpandColumns()
    End Sub

    Private Sub ContactsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ContactsComboBox.SelectedIndexChanged
        GetCurrentPersonDetails()
    End Sub
End Class
