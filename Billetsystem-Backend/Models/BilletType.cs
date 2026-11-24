namespace Billetsystem_Backend.Models;

public class BilletType
{
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Beskrivelse { get; set; } = string.Empty;
}