using Microsoft.AspNetCore.Mvc;

using Attendance.Models;
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
    public String InsertUser(User user)
    {
        return "InsertUser";
    }

    [HttpPatch("{id}")]
    public String UpdateUser(int id, User user)
    {
        return "UpdateUser";
    }

    [HttpDelete("{id}")]
    public String DeleteUser(int id)
    {
        return "DeleteUser";
    }
}
