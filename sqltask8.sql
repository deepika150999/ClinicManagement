select * from person.Person

select Person.FirstName,LastName
from Person.Person



select * from person.Person

select Person.FirstName,LastName 
from Person.Person
where FirstName like 'a%' and LastName Like 'a%'




select * from Sales.Currency
select * from Sales.CountryRegionCurrency

select CY.CurrencyCode,CY.Name
from Sales.Currency CY,Sales.CountryRegionCurrency CRC



select * from HumanResources.Department

SET IDENTITY_INSERT HR.Dept ON

insert into HR.Dept
( sno,DepartmentID, Name,GroupName, ModifiedData)
select sno,DepartmentID, Name,GroupName, ModifiedData 
from HumanResources.Department
SET IDENTITY_INSERT HR.Dept OFF
select * from HR.Dept



CREATE TABLE [Student].[FirstStd](
	[StudentID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] varchar(100) NOT NULL,
	[Address] varchar(100) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_FirstStd_StudentID] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Deepika','Dgl',getdate(),getdate())
insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('satheesh','Chennai',getdate(),getdate())
insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Arun','Bangalore',getdate(),getdate())
insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Dharani','viruthunagar',getdate(),getdate())
insert into [Student].[FirstStd] Name,Address,ModifiedData,createDate
values ('Preethi','madurai',getdate(),getdate())

select * from FirstStd

select * from Person.Person
select * from Person.BusinessEntityAddress

select BEA.BusinessEntityID,BEA.AddressTypeID
from Person.Person p
join Person.BusinessEntityAddress BEA on BEA.BusinessEntityID = P.BusinessEntityID


 select * from HumanResources.Department

 select distinct groupName
 from humanresources.department


select top 1* from Production.ProductCostHistory
select top 1* from Production.Product
select top 1* from [Production].[ProductDocument]

select documentnode,P.StandardCost, (ListPrice + PCH.StandardCost) Price
from Production.Product P
join Production.ProductCostHistory PCH on PCH.ProductID = P.ProductID
JOIN [Production].[ProductDocument] D on P.ProductID=d.ProductID



select * from HumanResources.EmployeeDepartmentHistory

select DATEDIFF(year,startDate,isnull(enddate,getdate())) yearsonrole
from HumanResources.EmployeeDepartmentHistory 


select * From Sales.SalesPersonQuotaHistory

select 5000 

from Sales.SalesPersonQuotaHistory 



select * from sales.salestaxrate

select max (TaxRate )
from sales.SalesTaxRate



select * from HumanResources.Department
select * from HumanResources.Employee
select * from HumanResources.EmployeeDepartmentHistory



select EDH.DepartmentID,EDH.BusinessentityId,EDH.ShiftID,E.BirthDate,DATEDIFF(year,BirthDate,getdate()) Age
from HumanResources.Employee E
join HumanResources.EmployeeDepartmentHistory EDH on E.BusinessEntityID = EDH.BusinessEntityID
join HumanResources.Department D on D.DepartmentID = EDH.DepartmentID



create view HumanResource.Name_age 
as 
select EDH.DepartmentID,EDH.BusinessentityId,EDH.ShiftID,E.BirthDate,DATEDIFF(year,BirthDate,getdate()) Age
from HumanResources.Employee E
join HumanResources.EmployeeDepartmentHistory EDH on E.BusinessEntityID = EDH.BusinessEntityID
join HumanResources.Department D on D.DepartmentID = EDH.DepartmentID





select * from HumanResources.Department
select * from [HumanResources].[EmployeeDepartmentHistory]
select * from [HumanResources].[EmployeePayHistory]

select d.DepartmentID,d.Name, MAX(Rate) MaximumRate
from HumanResources.EmployeeDepartmentHistory EDH 
join HumanResources.Department D on D.DepartmentID = EDH.DepartmentID
join HumanResources.EmployeePayHistory EPH on EPH.BusinessEntityID = EDH.BusinessEntityID
Group by d.DepartmentID,d.Name 



select * from Person.Person
select * from Person.BusinessEntityAddress

select P.FirstName,P.MiddleName,P.Title,BEA.AddressTypeID,BEA.BusinessEntityID
from Person.Person p
 Left join Person.BusinessEntityAddress BEA on BEA.BusinessEntityID = P.BusinessEntityID
 where P.FirstName is not null



select * from Production.ProductInventory 

select PN.ProductID,PN.LocationID,PN.Shelf
from Production.ProductInventory PN
WHERE (ProductID >= 300 and ProductID <= 350) AND (LocationID = 50 or Shelf = 'E')



select * from Production.ProductInventory
select * from Production.Location

select ProIn.LocationID,ProIn.Shelf, L.Name
from Production.ProductInventory ProIn
Join Production.Location L on L.LocationID = ProIn.LocationID



select * from Person.StateProvince
select * from Person.Address


select Ad.AddressID,Ad.AddressLine1,Ad.AddressLine2,AD.StateProvinceID,sp.StateProvinceCode,sp.CountryRegionCode
from Person.StateProvince SP
join Person.Address Ad on Ad.StateProvinceID = SP.StateProvinceID



Select * from Sales.SalesTerritory
Select * from Sales.CountryRegionCurrency
select * from Sales.SalesOrderHeader

select CRC.CurrencyCode, (SubTotal + TaxAmt) Total 
from Sales.SalesTerritory ST 
join Sales.CountryRegionCurrency CRC on CRC.CountryRegionCode = ST.CountryRegionCode
join Sales.SalesOrderHeader SOH on SOH.TerritoryID = ST.TerritoryID
