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

    public User? SelectUser(int Id)
    {
        if (_attendanceDbContext != null)
        {
            return _attendanceDbContext?.Users?.Where(x => x.Id == Id).FirstOrDefault();
        }
        else
        {
            throw new NullReferenceException($"{nameof(_attendanceDbContext)}");
        }
    }

    public async Task<User> InsertUser(User user)
    {
        if (_attendanceDbContext != null)
        {
            _attendanceDbContext.Add<User>(user);
            await _attendanceDbContext.SaveChangesAsync();

            return user;
        }
        else
        {
            throw new NullReferenceException($"{nameof(_attendanceDbContext)}");
        }
    }

    public async Task<User> UpdateUser(User user)
    {
        if (_attendanceDbContext != null)
        {
            _attendanceDbContext.Update<User>(user);

            await _attendanceDbContext.SaveChangesAsync();

            return user;
            
        }
        else
        {
            throw new NullReferenceException($"{nameof(_attendanceDbContext)}");
        }
    }

    public Task DeleteUser(int id)
    {
        throw new NotImplementedException();
    }
}