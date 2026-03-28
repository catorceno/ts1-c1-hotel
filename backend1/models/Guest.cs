// using System.ComponentModel.DataAnnotations.Schema;
using Postgrest.Attributes;
using Postgrest.Models;

namespace Supabase.Models;

[Table("guest")]
public class Guest : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("ci")]
    public string Ci { get; set; }
    
    [Column("email")]
    public string Email { get; set; }
    
    [Column("phone")]
    public string Phone { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}