using Billetsystem_Backend.Models;

namespace Billetsystem_Backend.Data;

public class SeedData
{
    public static void Initialize(BilletDbContext context)
    {
        if (context.Forestillinger.Any()) return;

        context.Forestillinger.AddRange(
            new Forestillinger
            {
                Titel = "Hamlet – genopført",
                TeatersalId = 1,
                KortBeskrivelse = "Klassisk teaterforestilling om hævn, kærlighed og svigt.",
                Beskrivelse = "Oplev Shakespeares klassiske fortælling om prins Hamlet, der forsøger at finde sandheden om sin fars død. En spændende forestilling om hævn, kærlighed og svigt.",
                SalgsType = SalgsType.Offentligt,
                BilledeUrl = "/images/hamlet.png"
            },

            new Forestillinger
            {
                Titel = "Frøken Julie",
                TeatersalId = 2,
                KortBeskrivelse = "Drama om kærlighed, magt og sociale forskelle.",
                Beskrivelse = "Et drama om den unge Julie og tjeneren Jean, der forelsker sig på trods af deres forskellige sociale baggrunde. En fortælling om kærlighed, magt og svære valg.",
                SalgsType = SalgsType.Offentligt, 
                BilledeUrl = "/images/frkjulie.png"
            },

            new Forestillinger
            {
                Titel = "Julekalender på scenen",
                TeatersalId = 2,
                KortBeskrivelse = "Hyggelig familieforestilling med juleeventyr, humor og spænding.",
                Beskrivelse = "En hyggelig juleforestilling for hele familien. Følg en gruppe børn, der forsøger at redde julen gennem sjove og spændende oplevelser.",
                SalgsType = SalgsType.Offentligt, 
                BilledeUrl = "/images/julekalender.png"
            },

            new Forestillinger
            {
                Titel = "Kammerkammerat",
                TeatersalId = 2,
                KortBeskrivelse = "Monolog med én skuespiller om venskab, ensomhed og livets udfordringer.",
                Beskrivelse = "En monolog om venskab, ensomhed og livets oplevelser. Med både humor og alvor fortæller én skuespiller en personlig historie.",
                SalgsType = SalgsType.Offentligt, 
                BilledeUrl = "/images/kammerkammerat.png"
            },

            new Forestillinger
            {
                Titel = "Opera i parketten",
                TeatersalId = 1,
                KortBeskrivelse = "Musikalsk koncertforestilling med kendte operastykker og smukke melodier.",
                Beskrivelse = "En musikalsk aften med kendte operastykker og smukke melodier. Oplev fortællinger om kærlighed, glæde og sorg gennem sang og musik.",
                SalgsType = SalgsType.Offentligt,
                BilledeUrl = "/images/opera.png"
            },

            new Forestillinger
            {
                Titel = "Sæsonafslutning: Galla",
                TeatersalId = 1,
                KortBeskrivelse = "Festlig sæsonafslutning med musik og underholdning for inviterede gæster.",
                Beskrivelse = "En festlig afslutning på teatersæsonen for inviterede gæster. Aftenen byder på musik, underholdning og højdepunkter fra årets forestillinger.",
                SalgsType = SalgsType.Inviteret, 
                BilledeUrl = "/images/galla.png"
            }
        );

        context.SaveChanges();
    }
}