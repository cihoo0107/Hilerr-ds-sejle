using System.ComponentModel.DataAnnotations;
namespace Hilerrøds_sejle.Model;

public enum Medlemsrolle
{
Medlem,
Bestyrelsesmedlem,
Næstformand,
Næstforkvinde,
Formand
}

public class Medlem
{
    public int Id { get; set; }

    [Required]
    [StringLength(30,MinimumLength = 2)]
    public string Navn { get; set; }

    [Required]
    [EmailAddress]
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
