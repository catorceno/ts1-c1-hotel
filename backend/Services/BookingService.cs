public class BookingService : IBookingService
{
    private readonly IGuestService _guestService;
    public BookingService(IGuestService guestService)
    {
        _guestService = guestService;
    }

    public async Task<BookingResponse> CreateBooking(BookingRequest booking)
    {
        var guestResponses = new List<GuestResponse>();
        foreach(var guestRequest in booking.Guests)
        {
            var guestResponse = await _guestService.Create(guestRequest);
            guestResponses.Add(guestResponse);
        }

        return new BookingResponse
        {
            Guests = guestResponses
        };
    }
}