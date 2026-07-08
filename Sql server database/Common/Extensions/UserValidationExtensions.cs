










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
