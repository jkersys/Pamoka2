using System.Text;

namespace P_0021_ForEach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ForEach!");
            AntrasKlasesUzdavinys();

            int[] taskuMasyvas = new int[10];
            taskuMasyvas[0] = 1;
            foreach (int taskai in taskuMasyvas)
            {
                Console.WriteLine($"{taskai}Naujas elementas");
            }


            string[] masinos = new string[] { "BMW", "Audi", "Toyota" };

            foreach (var masina in masinos)
            {
                Console.WriteLine(masina);
            }

            List<int> amziai = new List<int> { 19, 20, 21 };
            foreach (var amzius in amziai)
            {
                Console.WriteLine($"amzius: {amzius}");
            }

            List<string> vardai = new List<string> { "Ieva", "Vardenis", "Edgaras" };
            foreach (var vardas in vardai)
            {
                Console.WriteLine($"Vardai: {vardas}");
            }


            string sakinys = "Buvo karta erdve ir ji kazkur paklydo";
            foreach (var raide in sakinys)
            {
                Console.WriteLine(raide);
            }



            List<string> kortos = new List<string> { "Sirdziu", "Bugnu", "Vynu", "Kryziu", };
            List<string> rusis = new List<string> { "Tuzas", "Dviake", "Triake", "Keturake", "Penkake", "Sesake", "Septynake", "Astuonake", "Devynakės", "Desimtake", "Valetas", "Dama", "Karalius", };


            // ketvirtasUzdavinys("asd123dsa456");


        }


        // KLASES DARBAS 1. ## Parasykite programa, kuri apskaiciuotu duoto integer saraso vidurki.
        /*
        public static double PavyzdziaiForEach()
        {
            List<int> skaiciai = new List<int>
            {
                1, 5, 8, 9, 8 ,5 ,8, 9, 9
            };

            var rezultatas = ApskaiciuotiVidurki(skaiciai);
        }
        */

        public static double ApskaiciuotiVidurki(List<int> skaiciai)
        {
            var vidurkis = 0;

            foreach (var skaicius in skaiciai)
            {

                vidurkis += skaicius;
                Console.WriteLine($"skaicius {skaicius}.  suma: {vidurkis}");
            }
            return vidurkis / skaiciai.Count;
        }


        //KLASES DARBAS 2. ## Parasykite metoda, kuris grazina ar skaicius neigiamas ar teigiamas masyve.

        public static void AntrasKlasesUzdavinys()
        {

            List<int> skaiciai = new List<int>
            {
                1, 5, -8, 9, 8 ,-5
            };

            var rezultatas = TikrintiSkaiciausTeigiamuma(skaiciai);

            foreach (string skaiciausTeigiamumas in rezultatas)
            {
                Console.WriteLine($"Ar skaicius teigiamas: {skaiciausTeigiamumas}");
            }
        }
        public static List<string> TikrintiSkaiciausTeigiamuma(List<int> skaiciai)
        {
            var SkaiciuTeigiamumas = new List<string>();

            foreach (var skaicius in skaiciai)
            {
                if (skaicius >= 0)
                    SkaiciuTeigiamumas.Add("Teigiamas");
                else
                    SkaiciuTeigiamumas.Add("Neigiamas");
            }
            return SkaiciuTeigiamumas;
        }


        // //KLASES DARBAS 3. ## Parasykite metoda, kuris apskaiciuos kiek jums reikes sumoketi GPM nuo duoto imoku saraso. Sio uzdavinio GPM: 15%

        public static void TreciasKlasesUzdavinys()
        {
            int gpm = 15;
            List<double> imokos = new List<double>()

            {
                100, 150, 188.88, 153.87, 68,68
            };



        }
        public static double ApskaiciuotiGPM(List<double> imokos, int gpm)
        {
            var galutinisMokestis = 0d;

            foreach (var mokestis in imokos)
            {
                galutinisMokestis += mokestis;
            }
            return galutinisMokestis * (gpm / 100d);

        }



        ///Parašyti metodą IstrauktiSkaicius, kuris priima teksta, bet grazina tik skaicius egzistuojancius paciame tekste.        
        ///  Isgavus teksta programa turetu naudoti naujai sukurta SurikiuotiSkaiciusIsTeksto metoda, kuris priima "string skaiciaiTekste" ir surikiuoja skaicius       
        ///didejimo tvarka. SurikiuotiSkaiciusIsTeksto privalo panaudoti foreach, kad suformuotumet nauja List<int>:  
        ///PVZ: Ivedame: 1sd512sd5. Programa be rusiavimo grazina mums: 15125. Programa su rusiavimu grazina mums: 11255        
        ////// </summary>



        public static string IstrauktiSkaicius(string tekstas)
        {
            var skaiciaiTekste = new StringBuilder();

            foreach (var simbolis in tekstas)
                if (char.IsDigit(simbolis))
                    skaiciaiTekste.Append(simbolis);
            return skaiciaiTekste.ToString();
        }

        public static List<int> SurikiuotiSkaiciusTekste(string skaiciaiTekste)
        {
            var skaiciai = new List<int>();

            foreach (var skaicius in skaiciaiTekste)
            {
                skaiciai.Add(SkaiciausTikrinimas(skaicius.ToString()));
            }
            skaiciai.Sort();
            return skaiciai;
        }


        public static void atspausdintiSkaicius()
        {

        }




        //karolio tikrinimo metodas
        private static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;





        /*
        public static void ketvirtasUzdavinys(string skaiciaiTekste)
        {

            List<string> tekstas = new List<string>
            {
                "1sd512sd5"
            };

            var rezultatas = IstrauktiSkaicius(tekstas);

            foreach (string skaiciai in rezultatas)
            {
                Console.WriteLine($"skaiciai tekste: {skaiciaiTekste}");
            }
        }



        public static List<string> IstrauktiSkaicius(List<string> tekstas)
        {
            var skaiciaiTekste = new List<string>();

             skaiciaiTekste = tekstas.Where(Char.IsDigit).ToList();

            return skaiciaiTekste;
        }

        */

/// <summary> 

/// Parašyti metodą IsmetytiZodzius, kuris priima sakini, bet grazina nauja zodziu List sudaryta tik is zodziu, kurie ilgesni nei 5 raides ir yra surikiuoti abeceles tvarka.        
/// ///  Tada parasykite metoda, kuris priima 2 zodziu sarasus, juos sujungia i viena kolekcija naudojant ciklus ir atspausdina ekrane.        
/// ///  PRIMINIMAS: Kad isskirti string i atskirus zodzius naudokite pavyzdinisString.Split(' ')        
/// ///  PVZ: Ivedame: "Labas as esu Kodelskis ir labai megstu programuoti".         
/// ///  Programa be rusiavimo grazina mums: as esu ir Labas Kodelskis labai megstu programuoti        
/// ///  Programa su rusiavimu grazina mums: as esu ir Kodelskis labai Labas megstu programuoti        
/// /// </summary>

/*
public static string[] IstrauktiZodzius(string sakinys) => sakinys.Split(' ');
public static List<string> isgautiIlgusZodzius(string[] zodziai, int ilgis = 5)
{
    var ilgiZodziai = new List<string>();
    foreach (string zodis in zodziai)
        if (zodis.Length >= ilgis)
            ilgiZodziai.Add(zodis);
    return ilgiZodziai;
    }

public static List<string> surikiuotiZodzius(List<string> zodziai)
{
    zodziai.Sort();
    return zodziai;
}

public static List<string> IsvalytiZodzius(List<string> zodziai)
{
    var trumpiZodziai = new List<string>();
    foreach (var zodis in zodziai)
        if(zodis.Length >= 5)

    {

    }
}

public static List<string> IsmetytiZodzius(string sakinys)
{
    var zodziai = IstrauktiZodzius(sakinys);
    var ilgiZodziai = isgautiIlgusZodzius;

    foreach (var zodis in zodziai)
    {
        Console.WriteLine(zodis);
    }
    return ilgiZodziai;
}

/*
public static List<string> IsmetytiZodzius(string tekstas)
{
    List<string> zodziai = new List<string>();
    string[] splitas = tekstas.Split(' ');

    foreach (string tikrinimas in splitas)
        if (tikrinimas.Length > 5)
        {
            zodziai.Add(tikrinimas);
        }
    zodziai.Sort();

    return zodziai;
}

public static List<string> SujungtiDuSarasus(List<string> pirmas, List<string> antras)
{

}
*/

/*
Parašyti metodą SukonstruotiKalade(rusis, kortos). Sis metodas turi sukonstruoti kalade is duotu 2 string sarasu.        
///  Po to parasyti metoda, kuris surikiuoja jusu kalade pagal abeceles tvarka.        
///  ///  Ir galiausiai parasyti, kad jusu visas kortas atspausdintu ekrane.        
///  ///  PRIMINIMAS: 

/*         * "Sirdziu",                
 *         "Bugnu",                
 *         "Vynu",                
 *         "Kryziu",
 *         *          
 *         * Kortos 
 *         *          * 
 *         "Tuzas",                
 *         "Dviake",                
 *         "Triake",                
 *         "Keturake",                
 *         "Penkake",                
 *         "Sesake",                
 *         "Septynake",                
 *         "Astuonake",                
 *         "Devynakės",                
 *         "Desimtake",                
 *         "Valetas",                
 *         "Dama",                
 *         "Karalius",         */


/*
 *  var ilgiZodziai = new List<string>();
    foreach (string zodis in zodziai)
        if (zodis.Length >= ilgis)
            ilgiZodziai.Add(zodis);
    return ilgiZodziai;*/

public static List<string> SukonstruotiKalade(List<string> rusys, List<string> kortos)
{
    var kortuKalade = new List<string>();
    foreach (string rusis in rusys)
    {
        foreach (string korta in kortos)
        {
                    kortuKalade.Add($"{rusis} {korta}");
        }
    }

    

}


}

}
