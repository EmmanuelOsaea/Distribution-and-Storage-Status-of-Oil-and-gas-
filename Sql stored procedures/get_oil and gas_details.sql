CREATE OR ALTER PROCEDURE
dbo.usp_User_Upsert
@UserId INT = NULL,
@Email NVARCHAR(258)
@isActive BIT = 1
AS
/
*******************************************************************************


Author: Your Name
Create Date: 2026-07-06
Description: Inserts or update a user record.
Prefix 'usp_' denotes a User Stored Procedure.
‎*******************************************************************************/
  
BEGIN

SET NOCOUNT ON;
SET XACT ABORT ON;

  
  BEGIN TRY
  BEGIN TRANSACTION
  
 IF @UserId IS NULL
 BEGIN  
  INSERT INTO dbo.Users(Email, isActive, CreatedDate)
     VALUES(@Email, @IsActive,
GETUTCDATE()
END
ELSE  
BEGIN
  UPDATE dbo.Users
  SET Email =@Email,
  IsActive = @IsActive
  ModifiedDate =
  GETUTCDATE()
  WHERE UserId = @UserId;
  END 
  
  BEGIN CATCH
  IF @@TRANCOUNT > 0
  BEGIN
  ROLLBACK TRANSACTION;
END

DECLARE @ErrorMessage INT NVARCHAR(4000)=
ERROR_MESSAGE();
  
DECLARE @ErrorSeverity INT =
ERROR_SEVERITY();

DECLARE @ErrorState INT =
ERROR_STATE();
  
RAISERROR(@ErrorMessage,
@ErrorSeverity, @ErrorState);
 END CATCH
END
GO
