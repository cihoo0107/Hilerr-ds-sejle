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

    [Required]
    [StringLength(30,MinimumLength = 2)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public Medlemsrolle Rolle { get; set; } = Medlemsrolle.Medlem;

    public Medlem() { }

    public Medlem(string name, string email, int id, Medlemsrolle rolle)
    {
       Id = id;
       Name = name; 
       Email = email;
       Rolle = rolle;
    }
}
