Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Namespace HumanResourcesModel

    Partial Public Class Employee
        Public Sub New()
            dependents = New HashSet(Of dependent)()
            employees1 = New HashSet(Of Employee)()
        End Sub

        <Key>
        <Column("employee_id")>
        Public Property EmployeeId As Integer

        <StringLength(20)>
        <Column("first_name")>
        Public Property FirstName As String

        <Required>
        <StringLength(25)>
        <Column("last_name")>
        Public Property LastName As String

        <Required>
        <StringLength(100)>
        Public Property Email As String

        <StringLength(20)>
        <Column("phone_number")>
        Public Property PhoneNumber As String

        <Column("hire_date", TypeName:="date")>
        Public Property HireDate As Date

        <Column("job_id")>
        Public Property JobId As Integer

        Public Property Salary As Decimal

        <Column("manager_id")>
        Public Property ManagerId As Integer?

        <Column("department_id")>
        Public Property DepartmentId As Integer?

        Public Overridable Property Department As Department

        Public Overridable Property Dependents As ICollection(Of Dependent)

        Public Overridable Property Job As Job

        Public Overridable Property Employees1 As ICollection(Of Employee)

        Public Overridable Property Employee1 As Employee
    End Class
End Namespace