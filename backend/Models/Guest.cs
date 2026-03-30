using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("guest")]
public class Guest : BaseModel
{
    [PrimaryKey("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("ci")]
    public string Ci { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("phone")]
    public string? Phone { get; set; }

    [Column("created_at", ignoreOnInsert: true)]
    public DateTime? CreatedAt { get; set; }
}