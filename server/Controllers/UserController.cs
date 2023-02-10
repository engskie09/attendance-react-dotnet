using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers;

[ApiController]
[Route("v1/user")]
public class UserController : ControllerBase
{
    [HttpGet(Name = nameof(SelectUser))]
    public String SelectUser()
    {
        return "SelectUser";
    }

    [HttpPost(Name = nameof(InsertUser))]
    public String InsertUser()
    {
        return "InsertUser";
    }

    [HttpPatch(Name = nameof(UpdateUser))]
    public String UpdateUser()
    {
        return "UpdateUser";
    }

    [HttpDelete(Name = nameof(DeleteUser))]
    public String DeleteUser()
    {
        return "DeleteUser";
    }
}
