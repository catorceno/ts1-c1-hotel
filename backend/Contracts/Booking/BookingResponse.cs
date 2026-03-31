public class BookingResponse
{
    public int Id { get; set; }
    public DateTime Arrive { get; set; }
    public DateTime Depart { get; set; }
    public decimal Amount { get; set; }
    public decimal Total { get; set; }
    public string Status { get; set; }
    public List<GuestResponse> Guests { get; set; }
    public RoomResponse Room { get; set; }
}