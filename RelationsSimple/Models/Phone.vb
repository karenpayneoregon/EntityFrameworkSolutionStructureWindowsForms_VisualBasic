Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Phone")>
Partial Public Class Phone
    <Key>
    Public Property PhoneNumberId As Integer

    Public Property PhoneType As String

    Public Property PhoneNumber As String

    Public Property PersonId As Integer?

    Public Overridable Property Person As Person
End Class