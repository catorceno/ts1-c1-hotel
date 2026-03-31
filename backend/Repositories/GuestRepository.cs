public class GuestRepository : IGuestRepository
{
    private readonly Supabase.Client _client;
    public GuestRepository(Supabase.Client supabaseClient)
    {
        _client = supabaseClient;
    }

    public async Task<Guest> Add(Guest guest)
    {
        var foundGuest = await _client.From<Guest>().Where(g => g.Ci == guest.Ci).Get();
        var existingGuest = foundGuest.Models.FirstOrDefault();

        if (existingGuest != null)
        {
            if (existingGuest.Name == guest.Name &&
                existingGuest.Email == guest.Email &&
                existingGuest.Phone == guest.Phone)
            {
                return existingGuest;
            }

            throw new Exception($"Ya existe un huésped con CI {guest.Ci}, pero los datos no coinciden.");
        }

        var result = await _client.From<Guest>().Insert(guest);

        var insertedGuest = result.Models.FirstOrDefault();
        if(insertedGuest == null)
            throw new Exception("Error al insertar huésped.");

        return insertedGuest;
    }
}