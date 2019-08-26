Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace HumanResourcesModel

    Partial Public Class Country
        Public Sub New()
            locations = New HashSet(Of Location)()
        End Sub

        <Key>
        <Column("Country_id")>
        <StringLength(2)>
        Public Property CountryId As String

        <StringLength(40)>
        <Column("Country_name")>
        Public Property CountryName As String
        <Column("Region_id")>
        Public Property RegionId As Integer

        Public Overridable Property Region As Region

        Public Overridable Property Locations As ICollection(Of Location)
    End Class
End Namespace