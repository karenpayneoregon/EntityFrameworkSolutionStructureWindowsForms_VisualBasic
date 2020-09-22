Namespace Classes
    Public Class PersonEntity
        Public Property PersonId As Integer

        Public Property FirstName As String

        Public Property LastName As String
        Public Overrides Function ToString() As String
            Return $"{FirstName} {LastName}"
        End Function
    End Class
End Namespace