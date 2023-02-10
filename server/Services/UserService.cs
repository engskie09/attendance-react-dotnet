using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Attendance.Models;

namespace Attendance.Services;

public sealed class UserService : IUserService
{
    public Task<IEnumerable<User>> SelectUsers()
    {
        throw new NotImplementedException();
    }

    public Task<User> SelectUser(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> InsertUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteUser(int id)
    {
        throw new NotImplementedException();
    }
}