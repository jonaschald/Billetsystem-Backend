namespace Billetsystem_Backend.Models;

public class Forestillinger
{
    public int Id { get; set; }
    public string Titel { get; set; } = string.Empty;

    public int TeatersalId { get; set; }
    public Teatersal? Teatersal { get; set; }

    public string KortBeskrivelse { get; set; } = string.Empty;
    public string Beskrivelse { get; set; } = string.Empty;

    public SalgsType SalgsType { get; set; }
}

public enum SalgsType
{
    Offentligt, 
    Inviteret
}