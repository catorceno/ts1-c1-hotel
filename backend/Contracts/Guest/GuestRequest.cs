using System.ComponentModel.DataAnnotations;

public class GuestRequest
{
    [Required]
    public string Name { get; set; }

    [Required]
    [RegularExpression("^([0-9]{7})$", ErrorMessage = "El CI debe tener 7 dígitos.")]
    public string Ci { get; set; }

    [EmailAddress(ErrorMessage = "El email no tiene formato válido.")]
    public string Email { get; set; }

    [RegularExpression("^([0-9]{8})$", ErrorMessage = "El teléfono debe tener 8 dígitos.")]
    public string Phone { get; set; }
}