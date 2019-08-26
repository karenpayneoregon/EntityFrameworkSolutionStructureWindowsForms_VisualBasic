Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Namespace HumanResourcesModel

    Partial Public Class Region
        Public Sub New()
            countries = New HashSet(Of country)()
        End Sub

        <Key>
        <Column("region_id")>
        Public Property RegionId As Integer

        <StringLength(25)>
        <Column("region_name")>
        Public Property RegionName As String

        Public Overridable Property Countries As ICollection(Of Country)
    End Class
End Namespace