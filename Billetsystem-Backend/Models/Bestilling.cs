namespace Billetsystem_Backend.Models;

public class Bestilling
{
    public int Id { get; set; }
    public required Kunde Kunde { get; set; }
    public required Opfoerelse Opfoerelse { get; set; }
    public DateTime BestillingDato { get; set; }
    public BestillingStatus BestillingStatus { get; set; }
    public int TotalPris { get; set; }
}

public enum BestillingStatus
{
    IkkeBestilt,
    Bestilt
}