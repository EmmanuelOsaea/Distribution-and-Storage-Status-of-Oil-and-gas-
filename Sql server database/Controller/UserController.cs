





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
