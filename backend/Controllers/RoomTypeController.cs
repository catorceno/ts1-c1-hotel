using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class RoomTypeController : ControllerBase
{
    private readonly IRoomTypeService _roomTypeService;
    public RoomTypeController(IRoomTypeService roomTypeService)
    {
        _roomTypeService = roomTypeService;
    }

    [HttpGet]
    public async Task<ActionResult<List<RoomTypeResponse>>> GetAll()
    {
        var roomTypes = await _roomTypeService.GetAll();
        return Ok(roomTypes);
    }
}