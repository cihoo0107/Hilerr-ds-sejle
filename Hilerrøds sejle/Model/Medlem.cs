using System.ComponentModel.DataAnnotations;
namespace Hilerrøds_sejle.Model;

public enum Medlemsrolle
{
Medlem,
Bestyrelsesmedlem,
Næstformand,
Formand
}

public class Medlem
{
    public int Id { get; set; }

    [Required(ErrorMessage ="Indtast dit navn")]
    [StringLength(100,MinimumLength = 2, ErrorMessage="Navnet er for kort")]
    public string Navn { get; set; }

    [Required(ErrorMessage ="Indtast din mail")]
    [EmailAddress(ErrorMessage ="Ugyldig Email")]
    public string Email { get; set; }

    [Required]
    public Medlemsrolle Rolle { get; set; } = Medlemsrolle.Medlem;

    //Skal være tilstede for razor pages modelbinding
    public Medlem() { }

    public Medlem(string navn, string email, int id, Medlemsrolle rolle)
    {
       Id = id;
       Navn = navn; 
       Email = email;
       Rolle = rolle;
    }
}
