using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Attendance.Models;
using Attendance.Services;

namespace Attendance.Controllers;

[ApiController]
[Route("v1/user")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService? _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet("{id}")]
    public String SelectUser(int id)
    {
        return "SelectUser";
    }

    [HttpPost]
    public async Task<User> InsertUser(User user)
    {
        if (_userService != null)
        {
            return await _userService.InsertUser(user);
        }
        else
        {
            throw new NullReferenceException($"{nameof(_userService)}");
        }
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
