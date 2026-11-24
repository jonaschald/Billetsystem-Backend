using Billetsystem_Backend.Models;

namespace Billetsystem_Backend.Data;

public class SeedData
{
    public static void Initialize(BilletDbContext context)
    {
        if (!context.Roller.Any())
        {
            context.Roller.AddRange(
                new Rolle 
                {
                    Navn = "Administrator"
                },
                new Rolle
                {
                    Navn = "Billetkontrolløren" 
                }
            );
        }

        if (!context.Teatersale.Any())
        {
            context.Teatersale.AddRange(
                new Teatersal
                {
                    Navn = "Store sal",
                    Kapacitet = 420
                },
                new Teatersal
                {
                    Navn = "Lille sal",
                    Kapacitet = 140
                }
                );
        }
        
        if (!context.Priskategorier.Any())
        {
            context.Priskategorier.AddRange(
                new Priskategori
                {
                    Kategori = "A",
                    Pris = 320,
                    Farve = "Rød"
                },
                new Priskategori
                {
                    Kategori = "B",
                    Pris = 240,
                    Farve = "Gul"
                },
                new Priskategori
                {
                    Kategori = "C",
                    Pris = 150,
                    Farve = "Grøn"
                }
                );
        }
        
        if (!context.BilletTyper.Any())
        {
            context.BilletTyper.AddRange(
                new BilletType
                {
                    Type = "Voksen",
                    Beskrivelse = "Almindelig billet"
                },
                new BilletType
                {
                    Type = "Barn",
                    Beskrivelse = "Børn under 12 år (kategori C-pris)"
                }
                );
        }

        if (!context.Kunder.Any())
        {
            context.Kunder.AddRange(
                new Kunde
                {
                    Navn = "Jens Petersen",
                    Email = "Jens@mail.dk",
                    Telefon = 12345678
                },
                new Kunde
                {
                    Navn = "Anna Nielsen",
                    Email = "Anna@mail.dk",
                    Telefon = 87654321
                },
                new Kunde
                {
                    Navn = "Søren Hansen",
                    Email = "Soren@mail.dk",
                    Telefon = 13578642
                }
                );
        }

        context.SaveChanges();
    }
}