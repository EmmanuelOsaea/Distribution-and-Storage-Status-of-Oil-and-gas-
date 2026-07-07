using System.Data;
using Microsoft.Data.SqlClient
using Dapper

namespace MyApp.Services;

public class UserService;
IUserService
{
  private readonly string
 _connectionString;
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   parameters
   UserDto.isActive, DbType.Boolean
   ParameterDirection.Input);
    
    int rowsAffected = await
connection.ExecuteAsync(
    "dbo.usp_User_Upsert",
    parameters,
    commandType:
CommandType.StoredProcedure
);

return rowsAffected > 0;
 }
 }
