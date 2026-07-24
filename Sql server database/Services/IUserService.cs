using MyApp.Models;

namespace MyApp.Services;

public interface IUserService
{
    Task <bool> UpsertUserAsync(UserDto userDto);
}
