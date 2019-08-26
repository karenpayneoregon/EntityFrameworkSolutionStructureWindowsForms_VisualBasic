Namespace NorthWindModel

    Partial Public Class Country
        Public Sub New()
            Customers = New HashSet(Of Customer)()
        End Sub

        Public Property Id As Integer

        Public Property CountryName As String

        Public Overridable Property Customers As ICollection(Of Customer)
    End Class
End Namespace