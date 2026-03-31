using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("room_type")]
public class RoomType : BaseModel
{
    [PrimaryKey("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("capacity")]
    public int Capacity { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }
}