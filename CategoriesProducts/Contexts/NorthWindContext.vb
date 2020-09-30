Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class NorthWindContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=NorthWindContext")
    End Sub

    Public Overridable Property Categories As DbSet(Of Category)
    Public Overridable Property Products As DbSet(Of Product)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Product)() _
            .Property(Function(e) e.UnitPrice) _
            .HasPrecision(19, 4)
    End Sub
End Class
