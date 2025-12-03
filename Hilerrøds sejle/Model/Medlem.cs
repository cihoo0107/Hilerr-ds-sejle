namespace Hilerrøds_sejle.Model;

public class Medlem
{
    public string Name { get; }    
    public string Email { get; }
    public string Password { get; }

    public Medlem() { }

    public Medlem(string name, string email, string password)
    { 
       Name = name; 
       Email = email;
       Password = password;
    }
}
