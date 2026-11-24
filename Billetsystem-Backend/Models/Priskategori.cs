namespace Billetsystem_Backend.Models;

public class Priskategori
{
    public int Id { get; set; }
    public string Kategori { get; set; } = string.Empty;
    public int Pris { get; set; } = 0;
    public string Farve { get; set; } = string.Empty;
}