namespace Billetsystem_Backend.Models;

public class Kunde
{
    public int Id { get; set; }
    public string Navn { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Telefon { get; set; }
}