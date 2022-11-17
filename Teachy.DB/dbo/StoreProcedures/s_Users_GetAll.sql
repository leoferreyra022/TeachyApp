CREATE PROCEDURE [dbo].[s_Users_GetAll]
AS
BEGIN
	SELECT 
	[Id]
	,[FirstName]
	,[LastName]
	,[NickName]
	FROM [dbo].[User]
	WHERE [Active] = 1
END
