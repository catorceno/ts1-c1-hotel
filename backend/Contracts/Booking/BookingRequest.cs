using System.ComponentModel.DataAnnotations;

public class BookingRequest
{
    // [Required]
    // public int RoomId { get; set; }

    // [Required]
    // public DateTime Arrive { get; set; }

    // [Required]
    // public DateTime Depart { get; set; }

    [Required]
    [MinLength(1, ErrorMessage = "Se debe registrar al menos a 1 húesped.")]
    public List<GuestRequest> Guests { get; set; }
}