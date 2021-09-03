create procedure dbo.GetAnswers
@GetTable varchar(25)

as
begin

	declare @Table as table(Record_Count int,Column_Count int,Created_Date date,Constraint_Count int, Rev_TabName varchar(25))
	declare @Record_Count AS INT
	declare @Col_Count AS INT
	declare @Constraint_Count AS INT
	declare @Created_Date AS DATE
	declare @Rev_TabName AS varchar(20)

	set @Record_Count = 
	(
	select count(*) from [HumanResources].[Shift]
	)

	set @Col_Count =
	(
		SELECT count(*)
		FROM INFORMATION_SCHEMA.COLUMNS
		WHERE TABLE_NAME = @GetTable
	)

	set @Created_Date =
	(
		select create_date from 
	( 
		SELECT name,create_date, convert(varchar,create_date,103) as tdate FROM sys.tables 
	)as t
		WHERE t.name = @GetTable
	)

	set @Constraint_Count =
	(
		SELECT count(*) 
		FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
		WHERE TABLE_NAME=@GetTable
	)

	set @Rev_TabName=
	(
		SELECT REVERSE(@GetTable)
	)

	insert into @Table values(@Record_Count,@Col_Count,@Created_Date,@Constraint_Count,@Rev_TabName)

	select * from @Table
end

DECLARE @return_value table (Record_Count int,Column_Count int,Created_Date date,Constraint_Count int, Rev_TabName varchar(25))
insert @return_value
EXEC  dbo.GetAnswers @GetTable = 'EmployeeDepartmentHistory'
SELECT	* from @return_value
GO

drop procedure dbo.GetAnswers;