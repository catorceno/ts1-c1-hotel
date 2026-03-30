public interface IRoomTypeRepository
{
    Task<List<RoomType>> GetAll();
}