
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class GuestController : ControllerBase
{
    private GuestService _guestService;
    public GuestController(GuestService guestService)
    {
        _guestService = guestService;
    }

    [HttpPost]
    public async Task<ActionResult<CreateGuestResponse>> CreateGuest(CreateGuestRequest request)
    {
        var guest = await _guestService.Add(request);
        return Ok(guest);
    }
}