Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Namespace Models

    <Table("Email")>
    Partial Public Class EmailItem
        <Key>
        Public Property EmailIdentifier As Integer

        Public Property EmailType As String

        Public Property EmailAddress As String

        Public Property PersonId As Integer?

        Public Overridable Property Person As Person
    End Class
End Namespace