public interface IRoomTypeService
{
    Task<List<RoomTypeResponse>> GetAll();
}