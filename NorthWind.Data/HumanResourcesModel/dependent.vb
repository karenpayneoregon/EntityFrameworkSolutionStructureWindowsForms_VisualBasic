Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Namespace HumanResourcesModel

    Partial Public Class Dependent
        <Key>
        <Column("dependent_id")>
        Public Property DependentId As Integer

        <Required>
        <Column("first_name")>
        <StringLength(50)>
        Public Property FirstName As String

        <Required>
        <Column("last_name")>
        <StringLength(50)>
        Public Property LastName As String

        <Required>
        <StringLength(25)>
        Public Property Relationship As String

        Public Property employee_id As Integer

        Public Overridable Property Employee As Employee
    End Class
End Namespace