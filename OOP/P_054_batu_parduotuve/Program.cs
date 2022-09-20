using P_054_batu_parduotuve.Infrastructure.Database;
using P_054_batu_parduotuve.Infrastructure.Services;
using P_054_batu_parduotuve.Services;

namespace P_054_batu_parduotuve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Sukurti programą Batų parduotuvė.
                Sukurti reikiamą duomenų bazę saugoti informacijai. Lentelės: 
                - Batai (Id , Batu pavadinimas, Tipas (Moteriski Vyriski, Vaikiski) , Kaina)
                - BatuDydziai (Id , dydis, kiekis, Batas)
                - Pardavimai ( Id , koks BatuDydis nupirktas, Kiek poru nupirkta, kiek pinigų išleista.)
           Sukurti metodus, kurie: 
                1. fiksuoja pirkimą 
                - vartotojas pasirenka kokius batus perka, kokio dydžio, kiek porų
                - programa išsaugo pasikeitusius duomenis lentelėse BatuDydziai (kiekis sumažėja), 
                - lentelėje Pardavimai užfiksuojamas pardavimas
         */

            
            Console.WriteLine("Hello, Batu parduotuve!");
            using (var ctx = new ParduotuveContext())
            {
                //ctx.Database.EnsureCreated();
                var repository = new ParduotuveRepository(ctx);
                IBatuParduotuve parduotuve = new BatuParduotuve(repository);
                parduotuve.Begin();
            }
        }
    }
}