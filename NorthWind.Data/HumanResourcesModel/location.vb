Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Namespace HumanResourcesModel

    Partial Public Class Location
        Public Sub New()
            departments = New HashSet(Of Department)()
        End Sub

        <Key>
        <Column("location_id")>
        Public Property LocationId As Integer

        <StringLength(40)>
        <Column("street_address")>
        Public Property StreetAddress As String

        <StringLength(12)>
        <Column("postal_code")>
        Public Property PostalCode As String

        <Required>
        <StringLength(30)>
        Public Property City As String

        <StringLength(25)>
        <Column("state_province")>
        Public Property StateProvince As String

        <Required>
        <StringLength(2)>
        <Column("Country_id")>
        Public Property CountryId As String

        Public Overridable Property Country As Country

        Public Overridable Property Departments As ICollection(Of Department)
    End Class
End Namespace