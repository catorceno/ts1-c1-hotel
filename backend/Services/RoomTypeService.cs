public class RoomTypeService : IRoomTypeService
{
    private readonly IRoomTypeRepository _roomTypeRepo;
    public RoomTypeService(IRoomTypeRepository roomTypeRepository)
    {
        _roomTypeRepo = roomTypeRepository;
    }

    public async Task<List<RoomTypeResponse>> GetAll()
    {
        var roomTypes = await _roomTypeRepo.GetAll();
        return roomTypes.Select(rt => new RoomTypeResponse
        {
            Id = rt.Id,
            Name = rt.Name,
            Capacity = rt.Capacity,
            Price = rt.Price,
            Description = rt.Description
        }).ToList();
    }
}