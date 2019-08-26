Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace HumanResourcesModel

    Partial Public Class Department
        Public Sub New()
            employees = New HashSet(Of employee)()
        End Sub

        <Key>
        <Column("department_id")>
        Public Property DepartmentId As Integer

        <Required>
        <StringLength(30)>
        <Column("department_name")>
        Public Property DepartmentName As String
        <Column("location_id")>
        Public Property LocationId As Integer?

        Public Overridable Property Location As Location

        Public Overridable Property Employees As ICollection(Of Employee)
    End Class
End Namespace