namespace Billetsystem_Backend.Models;

public class Forestilling
{
    public int Id { get; set; }
    public string Titel { get; set; } = string.Empty;
    public string Beskrivelse { get; set; } = string.Empty;
    public string KortBeskrivelse { get; set; } = string.Empty;
    public SalgsType SalgsType { get; set; }
    
    public required Teatersal Teatersal { get; set; }
}

public enum SalgsType
{
    Offentlig,
    Privat
}