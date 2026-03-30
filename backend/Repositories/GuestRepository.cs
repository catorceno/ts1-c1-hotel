public class GuestRepository : IGuestRepository
{
    private readonly Supabase.Client _client;
    public GuestRepository(Supabase.Client supabaseClient)
    {
        _client = supabaseClient;
    }

    public async Task<Guest> Add(Guest guest)
    {
        var exists = await _client.From<Guest>().Where(g => g.Ci == guest.Ci).Get();
        if(exists.Models.Any())
            throw new Exception($"Se encontró registrado un húesped con el mismo CI: {guest.Ci}.");
        
        var result = await _client.From<Guest>().Insert(guest);

        return result.Models.First();
    }
}