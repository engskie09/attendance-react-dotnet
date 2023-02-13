using Microsoft.EntityFrameworkCore;

using Attendance.Models;

public partial class AttendanceDbContext : DbContext
{
    public DbSet<User>? Users { get; set; }

    public AttendanceDbContext (DbContextOptions<AttendanceDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}