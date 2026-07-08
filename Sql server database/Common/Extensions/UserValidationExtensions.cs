using
System.Text.RegularExpressions;
using MyApp.Models

namespace
MyApp.Common.Extensions;

public static class
UserValidationExtensions
{
public static bool isValid(this
UserDto user)
{
if (user == null) return false;
if
(string.IsNullorWhiteSpace(user.Em
ail)) return false;
regex
var emailRegex = new
Regex(@"^[^@\s]+@[^@\s]+\
.[^@\s]+$", RegexOptions.Compiled
| RegexOptions.IgnoreCase);
   return 
emailRegex.Ismatch(user.Email)
}

  public static bool
IsEligibleForAdmin(this UserDto
user)
{
     return userIsValid() &&
user.IsActive;
}
}
