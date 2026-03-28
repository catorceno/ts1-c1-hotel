
using Supabase.Models;

public class GuestService
{
    private GuestRepository _guestRepository;
    public GuestService(GuestRepository guestRepository)
    {
        _guestRepository = guestRepository;
    }

    public async Task<CreateGuestResponse> Add(CreateGuestRequest request)
    {
        return await _guestRepository.Add(request);
    }
}