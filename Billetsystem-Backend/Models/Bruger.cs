namespace Billetsystem_Backend.Models;

public class Bruger
{
    public int  Id { get; set; }
    
    public string Navn { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    
    public required Rolle Rolle { get; set; }
}