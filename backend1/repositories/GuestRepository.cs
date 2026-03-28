
using Supabase.Models;

public class GuestRepository
{
    private readonly Supabase.Client _client;

    public GuestRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<CreateGuestResponse> Add(CreateGuestRequest request)
    {
        var guest = new Guest
        {
            Name = request.Name,
            Ci = request.Ci,
            Email = request.Email,
            Phone = request.Phone
        };

        try
        {
            var response = await _client.From<Guest>().Insert(guest);
            var newGuest = response.Models.First();
            return new CreateGuestResponse
            {
                Id = newGuest.Id,
                Name = newGuest.Name,
                Ci = newGuest.Ci,
                Email = newGuest.Email,
                Phone = newGuest.Phone,
                CreatedAt = newGuest.CreatedAt
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }

        // if(response.Models == null || !response.Models.Any())
        // {
        //     throw new Exception("No se pudo insertar al huésped.");
        // }
    }

    public async Task<List<Guest>> GetAll()
    {
        var result = await _client.From<Guest>().Get();
        return result.Models;
    }
}