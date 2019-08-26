Imports System.Data.Entity
Imports NorthWind.Data.NorthWindModel

Namespace Contexts
    Partial Public Class NorthWindContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=NorthWindModel")
        End Sub

        Public Overridable Property Categories As DbSet(Of Category)
        Public Overridable Property Contacts As DbSet(Of Contact)
        Public Overridable Property ContactContactDevices As DbSet(Of ContactContactDevice)
        Public Overridable Property ContactTypes As DbSet(Of ContactType)
        Public Overridable Property Countries As DbSet(Of Country)
        Public Overridable Property Customers As DbSet(Of Customer)
        Public Overridable Property Departments As DbSet(Of Department)
        Public Overridable Property Employees As DbSet(Of Employee)
        Public Overridable Property OrderDetails As DbSet(Of OrderDetail)
        Public Overridable Property Orders As DbSet(Of Order)
        Public Overridable Property PhoneTypes As DbSet(Of PhoneType)
        Public Overridable Property Products As DbSet(Of Product)
        Public Overridable Property Shippers As DbSet(Of Shipper)
        Public Overridable Property Suppliers As DbSet(Of Supplier)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Entity(Of Country)() _
                .HasMany(Function(e) e.Customers) _
                .WithOptional(Function(e) e.Country) _
                .HasForeignKey(Function(e) e.CountryIdentfier)

            modelBuilder.Entity(Of Customer)() _
                .HasMany(Function(e) e.Orders) _
                .WithOptional(Function(e) e.Customer) _
                .WillCascadeOnDelete()

            modelBuilder.Entity(Of OrderDetail)() _
                .Property(Function(e) e.UnitPrice) _
                .HasPrecision(19, 4)

            modelBuilder.Entity(Of Order)() _
                .Property(Function(e) e.Freight) _
                .HasPrecision(19, 4)

            modelBuilder.Entity(Of Product)() _
                .Property(Function(e) e.UnitPrice) _
                .HasPrecision(19, 4)

            modelBuilder.Entity(Of Product)() _
                .HasMany(Function(e) e.OrderDetails) _
                .WithRequired(Function(e) e.Product) _
                .WillCascadeOnDelete(False)

            modelBuilder.Entity(Of Shipper)() _
                .HasMany(Function(e) e.Orders) _
                .WithOptional(Function(e) e.Shipper) _
                .HasForeignKey(Function(e) e.ShipVia)
        End Sub
    End Class
End Namespace
