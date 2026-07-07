















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
