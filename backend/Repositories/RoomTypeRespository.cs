public class RoomTypeRepository : IRoomTypeRepository
{
    private readonly Supabase.Client _client;
    public RoomTypeRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<List<RoomType>> GetAll()
    {
        var result = await _client.From<RoomType>().Get();
        return result.Models;
    }
}