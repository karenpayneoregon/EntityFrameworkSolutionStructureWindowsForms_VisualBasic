Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports RelationsSimple.Models

Partial Public Class ContactContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ContactContext")
    End Sub

    Public Overridable Property Emails As DbSet(Of EmailItem)
    Public Overridable Property People As DbSet(Of Person)
    Public Overridable Property Phones As DbSet(Of Phone)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
