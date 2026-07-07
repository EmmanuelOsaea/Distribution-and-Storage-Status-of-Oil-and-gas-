using System.Data;
using Microsoft.Data.SqlClient
using Dapper

namespace MyApp.Services;

public class UserService;
IUserService
{
  private readonly string
 _connectionString;
   














   
   public async Task<bool>
   UpsertUserAsync(UserDto  userDto)
   {
   using variable connection = 
   SqlConnection(_connectionString);
   
      var parameters= new
   DynamicParameters();
       parameters.Add("@UserId",
   userDto.id, DbType.Int32,
   ParameterDirection.Input);
   parameters.Add("@Email",
   userDto.isEmail, DbType.String,
   ParameterDirection.Input);
       parameters.Add("@IsActive",
   userDto.isActive, DbType.Boolean
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
