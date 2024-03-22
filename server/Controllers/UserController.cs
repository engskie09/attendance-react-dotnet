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
    public ActionResult<IEnumerable<User>> SelectUser(int id)
    {
        if (_userService != null)
        {
            return Ok(_userService.SelectUser(id));
        }
        else
        {
            throw new NullReferenceException($"{nameof(_userService)}");
        }
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<User>>> InsertUser(User user)
    {
        if (_userService != null)
        {
            return Ok(await _userService.InsertUser(user));
        }
        else
        {
            throw new NullReferenceException($"{nameof(_userService)}");
        }
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult<IEnumerable<User>>> UpdateUser(int id, User user)
    {
        if (_userService != null)
        {
            var selectedUser = _userService.SelectUser(id);

            if (selectedUser == null)
                return NotFound();

            return Ok(await _userService.UpdateUser(user));
        }
        else
        {
            throw new NullReferenceException($"{nameof(_userService)}");
        }
    }

    [HttpDelete("{id}")]
    public String DeleteUser(int id)
    {
        return "DeleteUser";
    }
}
