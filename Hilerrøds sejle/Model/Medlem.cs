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

    [Required(ErrorMessage = "Indtast dit navn")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Navnet er for kort")]
    public string Navn { get; set; } = string.Empty;

    [Required(ErrorMessage = "Indtast din mail")]
    [EmailAddress(ErrorMessage = "Ugyldig Email")]
    public string Email { get; set; } = string.Empty;

    [Required]
    public Medlemsrolle Rolle { get; set; } = Medlemsrolle.Medlem;

    [Required(ErrorMessage ="Indtast et gyldigt telefon nummer")]
    [StringLength(8,MinimumLength=8,ErrorMessage ="Telefon nummeret er for kort")]
    public string TelefonNummer {  get; set; } = string.Empty;

    public string Adresse { get; set; } = string.Empty;

    //Skal være tilstede for razor pages modelbinding
    public Medlem() { }

    public Medlem(string navn, string email, int id, Medlemsrolle rolle, string telefonnummer, string adresse)
    {
       Id = id;
       Navn = navn; 
       Email = email;
       Rolle = rolle;
       TelefonNummer = telefonnummer;
       Adresse = adresse;
    }
}
