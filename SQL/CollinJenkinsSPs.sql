use GeoSnowDB_
GO
CREATE PROC AddForumPost
    @ResortID INT,
    @PosterName NVARCHAR(255),
    @Title NVARCHAR(255),
    @Content NVARCHAR(MAX),
    @ParentPostID INT = NULL  -- Optional parameter for replies
AS
BEGIN
    INSERT INTO ForumPost (ResortID, PosterName, Title, Content, ParentPostID)
    VALUES (@ResortID, @PosterName, @Title, @Content, @ParentPostID);
END;

EXEC AddForumPost 16,'John Doe','Great Experience!','I had a wonderful time at the resort. Highly recommended!';
GO


CREATE PROCEDURE CheckEmailSubscription
    @Email NVARCHAR(255),
    @IsSubscribed BIT OUTPUT
AS
BEGIN
    SET @IsSubscribed = 0;
    IF EXISTS (SELECT 1 FROM NewsletterSubscribers WHERE Email = @Email)
    BEGIN
        SET @IsSubscribed = 1;
    END
END;


-- Test checking if an email is subscribed
DECLARE @IsSubscribed BIT;
EXEC CheckEmailSubscription @Email='john.doe@example.com', @IsSubscribed= @IsSubscribed OUTPUT;
SELECT @IsSubscribed AS IsSubscribed; -- Should return 1 (true)

-- Test checking an unsubscribed email
DECLARE @IsSubscribed BIT;
EXEC CheckEmailSubscription @Email='jane.doe@example.com', @IsSubscribed= @IsSubscribed OUTPUT;
SELECT @IsSubscribed AS IsSubscribed; -- Should return 0 (false)

GO
