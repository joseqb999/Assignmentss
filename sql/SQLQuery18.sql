create table NewTable(Country varchar(50),StateCode varchar(50),
StateName varchar(50));
insert into NewTable(Country,StateCode,StateName)
select c.[Name],s.[StateProvinceCode],s.[Name]
from  [Person].[CountryRegion] c inner join [Person].[StateProvince] s 
on c.[CountryRegionCode]=s.[CountryRegionCode];

select * from NewTable;

create function States(@CountryName varchar(15))
returns table
as
return 
select StateCode + ':' +StateName as result from NewTable 
where Country=@CountryName;

select result from [dbo].[States]('Australia');