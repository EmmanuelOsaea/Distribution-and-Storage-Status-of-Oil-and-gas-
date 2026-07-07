CREATE OR ALTER PROCEDURE
dbo.usp_User_Upsert
@UserId INT = NULL,
@Email NVARCHAR(258)
@isActive BIT = 1
AS
*


Author: 
Create Date: 2026-07-06
Description: Inserts or update s user record


  
  
 
 BEGIN  
  INSERT INTO dbo.Users
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
