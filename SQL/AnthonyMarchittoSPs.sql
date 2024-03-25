use GeoSnowDB_
GO
CREATE PROCEDURE AddSubscriber
    @Email NVARCHAR(255)
AS
BEGIN
    INSERT INTO NewsletterSubscribers (Email)
    VALUES (@Email)
END
EXEC AddSubscriber @Email='john.doe@example.com';
EXEC AddSubscriber @Email= 'markdoe@example.com';
EXEC AddSubscriber @Email='rubindoe@example.com';
EXEC AddSubscriber @Email='jakedoe@example.com';
EXEC AddSubscriber @Email='alexdoe@example.com';
GO



CREATE PROCEDURE RemoveSubscriber
    @Email NVARCHAR(255)
AS
BEGIN
    DELETE FROM NewsletterSubscribers
    WHERE Email = @Email
END
EXEC RemoveSubscriber @Email= 'johndoe@examplecom';
GO
