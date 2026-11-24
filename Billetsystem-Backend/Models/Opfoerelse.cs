namespace Billetsystem_Backend.Models;

public class Opfoerelse
{
    public int Id { get; set; }
    public DateTime Dato { get; set; }
    public string Tid { get; set; } = string.Empty;
    public SalgStatus Status { get; set; }
    
    public required Forestilling Forestilling { get; set; }
}

public enum SalgStatus
{
    Åben,
    Lukket
}