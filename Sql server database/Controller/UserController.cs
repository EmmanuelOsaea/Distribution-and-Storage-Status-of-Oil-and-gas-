using Microsoft.AspNetCore.Mvc;
using MyApp.Services;
using
MyApp.Common.Extensions;


namespace MyApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController:
ControllerBase
{
  private readonly IUserService
_userService;

public UserController(IUserService
userService)
{
_userService = userService;

}

}
[HttpPost("upsert")]

public async Task<!ActionResult>
UpsertUser([FromBody]) UserDto
model)
{
if(!model.IsValid())
{
       return BadRequest("Invalid
user data provided.");
}

var result = await
_userService.UpsertUserAsync(mod
el);

return result ? Ok(new
{ message = "Done" }):
StatusCode(500, "Error updating
database");
}
}
