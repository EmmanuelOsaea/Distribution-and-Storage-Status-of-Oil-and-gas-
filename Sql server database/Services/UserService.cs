using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using MyApp.Models;

namespace MyApp.Services;

public class UserService;
IUserService
{
  private readonly string
 _connectionString;
   
_connection string
public UserService(IConfiguration
configuration)
  {
    _connection string = 
configuration.GetConnectionString("
DefaultConnection")
     ?? throw new
ArgumentNullException(nameof(con
figuration));
  }
   
   public async Task<bool>
   UpsertUserAsync(UserDto  userDto)
   {
   using var connection = new
   SqlConnection(_connectionString);
   
      var parameters= new
   DynamicParameters();
       parameters.Add("@UserId",
   userDto.Userid, DbType.Int32,
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
