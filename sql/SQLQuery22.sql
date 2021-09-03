create procedure dbo.GetShift 
@shiftname varchar(15)
as
begin


	select 
	Right('0000000' + CONVERT(NVARCHAR, Emp.NationalIDNumber), 7) AS EmpIDText,
	DATEDIFF(YEAR,Emp.BirthDate,GETDATE()) as Age, Emp.JobTitle , 
	Emp.HireDate , Dep.Name , shif.Name , 
	concat( Per.FirstName,' ',Per.MiddleName,' ',Per.LastName ) as FullName
	from [Person].[Person] as Per 
	inner join [HumanResources].[EmployeeDepartmentHistory] as EmployeeDep
	on Per.BusinessEntityID=EmployeeDep.BusinessEntityID 
	inner join[HumanResources].[Employee] as Emp
	on EmployeeDep.BusinessEntityID=Emp.BusinessEntityID
	inner join[HumanResources].[Department] as Dep
	on EmployeeDep.DepartmentID=Dep.DepartmentID
	inner join[HumanResources].[Shift] as Shif
	on EmployeeDep.ShiftID=Shif.ShiftID
	where Shif.Name=@shiftname

end;

Exec dbo.GetShift @shiftname = 'Evening';