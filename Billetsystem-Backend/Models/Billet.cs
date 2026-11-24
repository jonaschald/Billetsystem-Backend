namespace Billetsystem_Backend.Models;

public class Billet
{
    public int Id { get; set; }
    public required Bestilling Bestiling { get; set; }
    public required Opfoerelse Opfoerelse { get; set; }
    
    public required BilletType BilletType { get; set; }
}