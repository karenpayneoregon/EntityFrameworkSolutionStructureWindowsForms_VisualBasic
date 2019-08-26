Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Namespace HumanResourcesModel

    Partial Public Class Job
        Public Sub New()
            employees = New HashSet(Of Employee)()
        End Sub

        <Key>
        <Column("job_id")>
        Public Property JobId As Integer

        <Required>
        <StringLength(35)>
        <Column("job_title")>
        Public Property JobTitle As String

        <Column("min_salary")>
        Public Property MinSalary As Decimal?

        <Column("max_salary")>
        Public Property MaxSalary As Decimal?

        Public Overridable Property Employees As ICollection(Of Employee)
    End Class
End Namespace