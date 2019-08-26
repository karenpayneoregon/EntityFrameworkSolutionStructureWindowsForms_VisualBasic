Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Namespace HumanResourcesModel
    Partial Public Class HumanResourcesContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=HRModel")
        End Sub

        Public Overridable Property Countries As DbSet(Of Country)
        Public Overridable Property Departments As DbSet(Of Department)
        Public Overridable Property Dependents As DbSet(Of Dependent)
        Public Overridable Property Employees As DbSet(Of Employee)
        Public Overridable Property Jobs As DbSet(Of Job)
        Public Overridable Property Locations As DbSet(Of Location)
        Public Overridable Property Regions As DbSet(Of Region)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Entity(Of Country)() _
            .Property(Function(e) e.CountryId) _
            .IsFixedLength() _
            .IsUnicode(False)

            modelBuilder.Entity(Of Country)() _
            .Property(Function(e) e.CountryName) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Department)() _
            .Property(Function(e) e.DepartmentName) _
            .IsUnicode(False)

            modelBuilder.Entity(Of department)() _
            .HasMany(Function(e) e.employees) _
            .WithOptional(Function(e) e.department) _
            .WillCascadeOnDelete()

            modelBuilder.Entity(Of Dependent)() _
            .Property(Function(e) e.FirstName) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Dependent)() _
            .Property(Function(e) e.LastName) _
            .IsUnicode(False)

            modelBuilder.Entity(Of dependent)() _
            .Property(Function(e) e.relationship) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Employee)() _
            .Property(Function(e) e.FirstName) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Employee)() _
            .Property(Function(e) e.LastName) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Employee)() _
            .Property(Function(e) e.Email) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Employee)() _
            .Property(Function(e) e.PhoneNumber) _
            .IsUnicode(False)

            modelBuilder.Entity(Of employee)() _
            .Property(Function(e) e.salary) _
            .HasPrecision(8, 2)

            modelBuilder.Entity(Of Employee)() _
            .HasMany(Function(e) e.Employees1) _
            .WithOptional(Function(e) e.Employee1) _
            .HasForeignKey(Function(e) e.ManagerId)

            modelBuilder.Entity(Of Job)() _
            .Property(Function(e) e.JobTitle) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Job)() _
            .Property(Function(e) e.MinSalary) _
            .HasPrecision(8, 2)

            modelBuilder.Entity(Of Job)() _
            .Property(Function(e) e.MaxSalary) _
            .HasPrecision(8, 2)

            modelBuilder.Entity(Of Location)() _
            .Property(Function(e) e.StreetAddress) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Location)() _
            .Property(Function(e) e.PostalCode) _
            .IsUnicode(False)

            modelBuilder.Entity(Of location)() _
            .Property(Function(e) e.city) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Location)() _
            .Property(Function(e) e.StateProvince) _
            .IsUnicode(False)

            modelBuilder.Entity(Of Location)() _
            .Property(Function(e) e.CountryId) _
            .IsFixedLength() _
            .IsUnicode(False)

            modelBuilder.Entity(Of location)() _
            .HasMany(Function(e) e.departments) _
            .WithOptional(Function(e) e.location) _
            .WillCascadeOnDelete()

            modelBuilder.Entity(Of Region)() _
            .Property(Function(e) e.RegionName) _
            .IsUnicode(False)
        End Sub
    End Class

End Namespace
