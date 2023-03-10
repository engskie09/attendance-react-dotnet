using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public int Id {get; set;}

    [Column("username")]
    public string? Username {get; set;}

    [Column("password")]
    public string? Password {get; set;}

    [Column("first_name")]
    public string? FirstName {get; set;}

    [Column("last_name")]
    public string? LastName {get; set;}
}
