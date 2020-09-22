Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Person")>
Partial Public Class Person
    Public Sub New()
        Emails = New HashSet(Of Email)()
        Phones = New HashSet(Of Phone)()
    End Sub

    Public Property PersonId As Integer

    Public Property FirstName As String

    Public Property LastName As String

    Public Overridable Property Emails As ICollection(Of Email)

    Public Overridable Property Phones As ICollection(Of Phone)

    Public Overrides Function ToString() As String
        Return $"{FirstName} {LastName}"
    End Function
End Class
