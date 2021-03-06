﻿namespace Samples.FSharp.Northwind

open System
open System.Collections.ObjectModel
open System.Data.Linq.Mapping
open DbExtensions

[<AllowNullLiteral>]
[<Table(Name = "Categories")>]
type Category() =
   
   [<Column(IsPrimaryKey = true, IsDbGenerated = true)>]
   member val CategoryID = 0 with get,set

   [<Column>]
   member val CategoryName : string = null with get,set
   
   [<Column>]
   member val Description : string = null with get,set
   
   [<Column>]
   member val Picture : Byte[] = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "Suppliers")>]
type Supplier() =
   
   [<Column(IsPrimaryKey = true, IsDbGenerated = true)>]
   member val SupplierID = 0 with get,set

   [<Column(CanBeNull = false)>]
   member val CompanyName : string = null with get,set

   [<Column>]
   member val ContactName : string = null with get,set

   [<Column>]
   member val ContactTitle : string = null with get,set

   [<Column>]
   member val Address : string = null with get,set

   [<Column>]
   member val City : string = null with get,set

   [<Column>]
   member val Region : string = null with get,set

   [<Column>]
   member val PostalCode : string = null with get,set

   [<Column>]
   member val Country : string = null with get,set

   [<Column>]
   member val Phone : string = null with get,set

   [<Column>]
   member val Fax : string = null with get,set

   [<Column(UpdateCheck = UpdateCheck.Never)>]
   member val HomePage : string = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "Products")>]
type Product() =

   [<Column(IsPrimaryKey = true, IsDbGenerated = true)>]
   member val ProductID = 0 with get,set
   
   [<Column(CanBeNull = false)>]
   member val ProductName : string = null with get,set
   
   [<Column>]
   member val SupplierID = new Nullable<int>() with get,set
   
   [<Column>]
   member val CategoryID = new Nullable<int>() with get,set
   
   [<Column>]
   member val QuantityPerUnit : string = null with get,set
   
   [<Column>]
   member val UnitPrice = new Nullable<decimal>() with get,set
   
   [<Column>]
   member val UnitsInStock = new Nullable<Int16>() with get,set
   
   [<Column>]
   member val UnitsOnOrder = new Nullable<Int16>() with get,set
   
   [<Column>]
   member val ReorderLevel = new Nullable<Int16>() with get,set
   
   [<Column>]
   member val Discontinued = false with get,set

   [<Association(ThisKey = "CategoryID", IsForeignKey = true)>]
   member val Category : Category = null with get,set

   [<Association(ThisKey = "SupplierID", IsForeignKey = true)>]
   member val Supplier : Supplier = null with get,set

   member val ValueInStock = 0m with get,set

[<AllowNullLiteral>]
[<Table(Name = "Employees")>]
type Employee() =
   
   [<Column(IsPrimaryKey = true, IsDbGenerated = true)>]
   member val EmployeeID = 0 with get,set

   [<Column>]
   member val LastName : string = null with get,set
   
   [<Column>]
   member val FirstName : string = null with get,set
   
   [<Column>]
   member val Title : string = null with get,set
   
   [<Column>]
   member val TitleOfCourtesy : string = null with get,set
   
   [<Column>]
   member val BirthDate = new Nullable<DateTime>() with get,set
   
   [<Column>]
   member val HireDate = new Nullable<DateTime>() with get,set
   
   [<Column>]
   member val Address : string = null with get,set
   
   [<Column>]
   member val City : string = null with get,set
   
   [<Column>]
   member val Region : string = null with get,set
   
   [<Column>]
   member val PostalCode : string = null with get,set
   
   [<Column>]
   member val Country : string = null with get,set
   
   [<Column>]
   member val HomePhone : string = null with get,set
   
   [<Column>]
   member val Extension : string = null with get,set
   
   [<Column(UpdateCheck = UpdateCheck.Never)>]
   member val Photo : Byte[] = null with get,set
   
   [<Column(UpdateCheck = UpdateCheck.Never)>]
   member val Notes : string = null with get,set
   
   [<Column>]
   member val ReportsTo = new Nullable<int>() with get,set
   
   [<Column>]
   member val PhotoPath : string = null with get,set

   [<Association(ThisKey = "ReportsTo", IsForeignKey = true)>]
   member val ReportsToEmployee : Employee = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "Region")>]
type Region() =

   [<Column(IsPrimaryKey = true)>]
   member val RegionID = 0 with get,set
   
   [<Column(CanBeNull = false)>]
   member val RegionDescription : string = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "Territories")>]
type Territory() =

   [<Column(IsPrimaryKey = true, CanBeNull = false)>]
   member val TerritoryID : string = null with get,set

   [<Column(CanBeNull = false)>]
   member val TerritoryDescription : string = null with get,set
   
   [<Column>]
   member val RegionID = 0 with get,set

   [<Association(ThisKey = "RegionID", IsForeignKey = true)>]
   member val Region : Region = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "EmployeeTerritories")>]
type EmployeeTerritory() =

   [<Column(IsPrimaryKey = true)>]
   member val EmployeeID = 0 with get,set
   
   [<Column(IsPrimaryKey = true)>]
   member val TerritoryID : string = null with get,set

   [<Association(ThisKey = "EmployeeID", IsForeignKey = true)>]
   member val Employee : Employee = null with get,set

   [<Association(ThisKey = "TerritoryID", IsForeignKey = true)>]
   member val Territory : Territory = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "Customers")>]
type Customer() =

   [<Column(IsPrimaryKey = true)>]
   member val CustomerID = 0 with get,set

   [<Column>]
   member val CompanyName : string = null with get,set

   [<Column>]
   member val ContactName : string = null with get,set

   [<Column>]
   member val ContactTitle : string = null with get,set

   [<Column>]
   member val Address : string = null with get,set

   [<Column>]
   member val City : string = null with get,set

   [<Column>]
   member val Region : string = null with get,set

   [<Column>]
   member val PostalCode : string = null with get,set

   [<Column>]
   member val Country : string = null with get,set

   [<Column>]
   member val Phone : string = null with get,set

   [<Column>]
   member val Fax : string = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "CustomerDemographics")>]
type CustomerDemographic() =

   [<Column(IsPrimaryKey = true)>]
   member val CustomerTypeID : string = null with get,set

   [<Column(UpdateCheck = UpdateCheck.Never)>]
   member val CustomerDesc : string = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "CustomerCustomerDemo")>]
type CustomerCustomerDemo() =

   [<Column(IsPrimaryKey = true)>]
   member val CustomerID : string = null with get,set

   [<Column(IsPrimaryKey = true)>]
   member val CustomerTypeID : string = null with get,set

   [<Association(ThisKey = "CustomerTypeID", IsForeignKey = true)>]
   member val CustomerDemographic : CustomerDemographic = null with get,set

   [<Association(ThisKey = "CustomerID", IsForeignKey = true)>]
   member val Customer : Customer = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "Shippers")>]
type Shipper() =

   [<Column(IsPrimaryKey = true, IsDbGenerated = true)>]
   member val ShipperID = 0 with get,set

   [<Column(CanBeNull = false)>]
   member val CompanyName : string = null with get,set

   [<Column>]
   member val Phone : string = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "Order Details")>]
type OrderDetail() =

   [<Column(IsPrimaryKey = true)>]
   member val OrderID = 0 with get,set

   [<Column(IsPrimaryKey = true)>]
   member val ProductID = 0 with get,set

   [<Column>]
   member val UnitPrice = 0M with get,set

   [<Column>]
   member val Quantity = 0s with get,set

   [<Column>]
   member val Discount = 0.0 with get,set

   [<Association(ThisKey = "ProductID", IsForeignKey = true)>]
   member val Product : Product = null with get,set

[<AllowNullLiteral>]
[<Table(Name = "Orders")>]
type Order() =

   [<Column(IsPrimaryKey = true, IsDbGenerated = true)>]
   member val OrderID = 0 with get,set

   [<Column(CanBeNull = false)>]
   member val CustomerID : string = null with get,set

   [<Column>]
   member val EmployeeID = new Nullable<int>() with get,set

   [<Column>]
   member val OrderDate = new Nullable<DateTime>() with get,set

   [<Column>]
   member val RequiredDate = new Nullable<DateTime>() with get,set

   [<Column>]
   member val ShippedDate = new Nullable<DateTime>() with get,set

   [<Column>]
   member val ShipVia = new Nullable<int>() with get,set

   [<Column>]
   member val Freight =  new Nullable<decimal>() with get,set

   [<Column>]
   member val ShipName : string = null with get,set

   [<Column>]
   member val ShipAddress : string = null with get,set

   [<Column>]
   member val ShipCity : string = null with get,set

   [<Column>]
   member val ShipRegion : string = null with get,set

   [<Column>]
   member val ShipPostalCode : string = null with get,set

   [<Column>]
   member val ShipCountry : string = null with get,set

   [<Association(OtherKey = "OrderID")>]
   member val OrderDetails = new Collection<OrderDetail>() with get,set

   [<Association(ThisKey = "CustomerID", IsForeignKey = true)>]
   member val Customer : Customer = null with get,set

   [<Association(ThisKey = "EmployeeID", IsForeignKey = true)>]
   member val Employee : Employee = null with get,set

   [<Association(ThisKey = "ShipVia", IsForeignKey = true)>]
   member val Shipper : Shipper = null with get,set

type NorthwindDatabase =
   inherit Database

   member this.Products = this.Table<Product>()
   member this.Orders = this.Table<Order>()
   member this.OrderDetails = this.Table<OrderDetail>()

   new(connString : string, mapping : MetaModel) = {
      inherit Database(connString, mapping)
   }

/// <summary>
/// Unlike AttributeMappingSource, XmlMappingSource crashes when you call GetModel and
/// pass a Type that doesn't inherit from DataContext. The workaround is to define a DataContext
/// type in the same namespace as your entities.
/// </summary>
type ForXmlMappingSourceOnlyDataContext =
   inherit System.Data.Linq.DataContext

   private new() = {
      inherit System.Data.Linq.DataContext(string null, null)
        
      //raise (System.InvalidOperationException())
   }