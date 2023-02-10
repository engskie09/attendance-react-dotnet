using Microsoft.EntityFrameworkCore;

using Attendance.Models;

public partial class DatabaseContext : DbContext
{
    public DbSet<User>? Users { get; set; }

    public DatabaseContext (DbContextOptions<DatabaseContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}