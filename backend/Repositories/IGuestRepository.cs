public interface IGuestRepository
{
    Task<Guest> Add(Guest guest);
}