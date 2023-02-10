using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Attendance.Models;

namespace Attendance.Services;

public interface IUserService
{
    Task<IEnumerable<User>> SelectUsers();
    Task<User> SelectUser(int id);
    Task<int> InsertUser(User user);
    Task<int> UpdateUser(User user);
    Task<int> DeleteUser(int id);
}