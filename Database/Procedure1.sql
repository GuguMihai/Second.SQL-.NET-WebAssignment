CREATE    PROCEDURE [dbo].[GetFinalRes] (
    @firstName Varchar(500),
    @lastName Varchar(500)
) AS
BEGIN
    DECLARE @i int = 0;
    declare @t table(col1 varchar(100));

WHILE @i < 100
BEGIN
    SET @i = @i + 1

    IF (@i % 3 = 0) AND (@i % 5 = 0)
        BEGIN
			insert @t values(@firstName + ' ' + @lastName)
        END
    ELSE IF (@i % 3 = 0)
        BEGIN
			insert @t values(@firstName)
        END
    ELSE IF (@i % 5 = 0)
        BEGIN
			insert @t values(@lastName)
        END
    ELSE
         BEGIN
			insert @t values(CAST(@i as varchar(10)))
        END
END

select * from @t

    

END;
