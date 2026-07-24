CREATE OR ALTER PROCEDURE
dbo.usp_User_Upsert
@UserId INT = NULL,
@Email NVARCHAR(258)
@IsActive BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

  
    BEGIN TRY
        BEGIN TRANSACTION;
  
 IF @UserId IS NULL
 BEGIN  
  INSERT INTO dbo.Users (Email, IsActive, CreatedDate)
     VALUES(@Email, @IsActive,
GETUTCDATE());
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
   
COMMIT TRANSACTION;
END TRY
  BEGIN CATCH
   IF @@TRANCOUNT > 0
       ROLLBACK TRANSACTION;

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
