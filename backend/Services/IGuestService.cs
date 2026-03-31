public interface IGuestService
{
    Task<GuestResponse> Create(GuestRequest guest);
}