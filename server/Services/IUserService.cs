using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Attendance.Models;

namespace Attendance.Services;

public interface IUserService
{
    Task<IEnumerable<User>> SelectUsers();
    Task<User?> SelectUser(int Id);
    Task<User> InsertUser(User user);
    Task<User> UpdateUser(User user);
    Task DeleteUser(int id);
}