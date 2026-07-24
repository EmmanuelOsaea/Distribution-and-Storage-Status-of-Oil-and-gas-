using Microsoft.AspNetCore.Mvc;
using MyApp.Common.Extension;
using MyApp.Models;
using MyApp.Services;

namespace MyApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController: ControllerBase
{
private readonly IUserService _userService;

public UserController










public async Task<ActionResult>
{
if (!model.IsValid())
{
return BadRequest("Invalid user data provided.")
}

var result = await _userService.UpsertUserAsync(model);

return result
? Ok(new { message = "Done" }
: StatusCode(500, "Error updating database");
}
