public class GuestService : IGuestService
{
    private readonly IGuestRepository _guestRepo;
    public GuestService(IGuestRepository guestRepository)
    {
        _guestRepo = guestRepository;
    }

    public async Task<GuestResponse> Create(GuestRequest guest)
    {
        var newGuest = new Guest
        {
            Name = guest.Name,
            Ci = guest.Ci,
            Email = guest.Email,
            Phone = guest.Phone
        };

        var insertedGuest = await _guestRepo.Add(newGuest);
        
        return new GuestResponse
        {
            Id = insertedGuest.Id,
            Name = insertedGuest.Name,
            Ci = insertedGuest.Ci,
            Email = insertedGuest.Email,
            Phone = insertedGuest.Phone
        };
    }
}