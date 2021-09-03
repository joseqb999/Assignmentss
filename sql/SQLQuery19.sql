create table NewTable1(NationalIDNumber nvarchar(15),JobTitle nvarchar(50),BirthDate date,DepartmentName varchar(50));
insert into NewTable1(NationalIDNumber,JobTitle,Birthdate,DepartmentName)
select b.NationalIDNumber,b.JobTitle,b.BirthDate,a.Name
	from [HumanResources].[Department] as a inner join 
	[HumanResources].[EmployeeDepartmentHistory] as c on 
	a.DepartmentID=c.DepartmentID inner join
	[HumanResources].[Employee] as b
	on b.BusinessEntityID=c.BusinessEntityID;



select * from newtable1;

CREATE PROCEDURE dbo.GetDetails @NationalIDNum varchar(15)
as
begin
select * from NewTable1 where NationalIDNumber = @NationalIDNum
end;

EXEC dbo.GetDetails @NationalIDNum = 540688287;