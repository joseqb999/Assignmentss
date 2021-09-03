CREATE FUNCTION Dates
    (
	    @Date AS date
    )
    RETURNS varchar(25)
    AS
    BEGIN
		Declare @Curr_date as date
		Declare @day as int
		set @Curr_date = GETDATE()
		set @day = DATEDIFF(day, @Date, @Curr_date)
		if @day>0
			return 'Its an old Date'
		else
			return str(abs(@day))
		
		RETURN @day
	END;


print dbo.Dates('2021-09-20');

print dbo.Dates('2021-08-20');