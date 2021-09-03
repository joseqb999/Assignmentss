CREATE FUNCTION ADDITION
    (
	    @a AS INT,
	    @b AS INT,
		@c AS INT
    )
    RETURNS INT
    AS
    BEGIN
	    RETURN @a + @b + @c
    END;

	select dbo.addition(5,6,8);