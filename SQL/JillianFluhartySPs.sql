use GeoSnowDB_
GO
CREATE PROCEDURE GetPostsByResort
    @ResortID INT
AS
BEGIN
    SELECT * FROM ForumPost
    WHERE ResortID = @ResortID
    ORDER BY PostDate DESC;  -- Newest posts first
END;

EXEC GetPostsByResort 16;
GO

CREATE PROCEDURE DeleteForumPost
    @PostID INT
AS
BEGIN
    DELETE FROM ForumPost
    WHERE PostID = @PostID;
END;

EXEC DeleteForumPost 15; 
GO