namespace Billetsystem_Backend.Models;

public class Plads
{
    public int Id { get; set; }
    public required Teatersal Teatersal { get; set; }
    public string Raekke { get; set; } = string.Empty;
    public int PladsNummer { get; set; }
    public string Omraade { get; set; } = string.Empty;
    public required Priskategori Priskategori { get; set; }
    public bool BegraensetUdsigt { get; set; }
}