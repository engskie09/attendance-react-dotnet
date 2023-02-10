using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers;

[ApiController]
[Route("v1/user")]
public class UserController : ControllerBase
{
    [HttpGet("{id}")]
    public String SelectUser(int id)
    {
        return "SelectUser";
    }

    [HttpPost]
    public String InsertUser()
    {
        return "InsertUser";
    }

    [HttpPatch("{id}")]
    public String UpdateUser(int id)
    {
        return "UpdateUser";
    }

    [HttpDelete("{id}")]
    public String DeleteUser(int id)
    {
        return "DeleteUser";
    }
}
