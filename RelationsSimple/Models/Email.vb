Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Email")>
Partial Public Class Email
    <Key>
    Public Property EmailIdentifier As Integer

    Public Property EmailType As String

    Public Property EmailAddress As String

    Public Property PersonId As Integer?

    Public Overridable Property Person As Person
End Class