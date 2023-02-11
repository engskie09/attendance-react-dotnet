using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Attendance.Models;

namespace Attendance.Services;

public sealed class UserService : IUserService
{
    private readonly AttendanceDbContext? _attendanceDbContext;

    public UserService(AttendanceDbContext attendanceDbContext)
    {
        _attendanceDbContext = attendanceDbContext;
    }

    public Task<IEnumerable<User>> SelectUsers()
    {
        throw new NotImplementedException();
    }

    public Task<User> SelectUser(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<User> InsertUser(User user)
    {
        if (_attendanceDbContext != null)
        {
            _attendanceDbContext.Add(user);
            await _attendanceDbContext.SaveChangesAsync();
            return user;
        }
        else
        {
            throw new NullReferenceException($"{nameof(_attendanceDbContext)}");
        }
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