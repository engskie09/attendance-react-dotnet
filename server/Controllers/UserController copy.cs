using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers;

[ApiController]
[Route("v1/users")]
public class UsersController : ControllerBase
{
    [HttpGet(Name = nameof(SelectUsers))]
    public String SelectUsers()
    {
        return "SelectUsers";
    }
}
