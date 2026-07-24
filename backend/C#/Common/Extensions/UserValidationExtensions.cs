using System.Text.RegularExpressions;
using MyApp.Models;

namespace MyApp.Common.Extensions;

public static class UserValidationExtensions
{
  public static bool IsValid(This UserDto user)
  {
    if (user == null) return false;
    if (string.IsNullOrWhitespace(user
    .Email)) return false;

    return emailRegex.IsMatch(user.Email);
  }
