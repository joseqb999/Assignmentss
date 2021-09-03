create function CalculateDaysofMonth(@d date)
returns int
as
begin
return day(eomonth(@d))
end;

select [dbo].[CalculateDaysofMonth]('2010-05-01');

drop function CalculateDaysofMonth
