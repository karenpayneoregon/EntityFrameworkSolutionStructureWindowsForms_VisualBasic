Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Namespace HumanResourcesModel

    Partial Public Class Dependent
        <Key>
        Public Property dependent_id As Integer

        <Required>
        <StringLength(50)>
        Public Property first_name As String

        <Required>
        <StringLength(50)>
        Public Property last_name As String

        <Required>
        <StringLength(25)>
        Public Property relationship As String

        Public Property employee_id As Integer

        Public Overridable Property employee As Employee
    End Class
End Namespace