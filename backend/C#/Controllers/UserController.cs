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
