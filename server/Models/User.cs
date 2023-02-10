using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace attendance_api.Models;

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
}
