using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers;

[ApiController]
[Route("v1/users")]
public class UsersController : ControllerBase
{
    [HttpGet("{page}/{size}")]
    public String SelectUsers(int page, int size)
    {
        return "SelectUsers";
    }
}
