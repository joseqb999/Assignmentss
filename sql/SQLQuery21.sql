create procedure dbo.Splitstring 
@value varchar(15)
as
begin
	 SELECT * FROM STRING_SPLIT(@value,',')
end

exec dbo.Splitstring @value = 'x,y,z';