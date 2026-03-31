public interface IBookingService
{
    Task<BookingResponse> CreateBooking(BookingRequest booking);
}