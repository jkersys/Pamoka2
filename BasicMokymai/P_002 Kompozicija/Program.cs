namespace P_002_Kompozicija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OOP (-De)Kompozicija!");

            var pavyzdineKlase = new PavyzdineKlase();

            DirbtiSuPirmaUzduotimiNamasKnygaSalis();
           // DirbtiSuPirmaUzduotimi();
        }

        public static void DirbtiSuPirmaUzduotimiNamasKnygaSalis()
        {
            Namas namas = new Namas();
            namas.Tipas = "Murinis";
            namas.AukstuSkaicius = 2;
            namas.StatybosMetai = 2007;
            namas.StogoTipas = "Slaitinis";
            namas.KambariuSkaicius = 6;
            namas.SildymoBudas = "Geoterminis";
            namas.medziagos = new Medziagos()
            {
                Stogas = "Cerpes",
                Sienos = "Blokeliai",
                Perdangos = "Gelzbetonines"
            };

            Console.WriteLine($"{namas.Tipas} namas\n pastatytas is {namas.medziagos.Sienos}\nStogas dengtas {namas.medziagos.Stogas}\nAukstus skiria {namas.medziagos.Perdangos} perdangos");



            Console.WriteLine($"namas.tipas{namas.Tipas}\nnamas.AukstuSkaicius: {namas.AukstuSkaicius}\nnamas.StatybosMetai{namas.StatybosMetai}");

            var knyga = new Knyga()
            {
                VirselioTipas = "Kietas",
                LapuSkaicius = 300,
                Autorius = "Karlas Marksas",
                TirazoSkaicius = 1_000_000,
                Leidykla = "Vaga",
                Zanras = "Traktatas",
                savininkas = new Savininkas()
                {
                    Lytis = "Vyras",
                    Amzius = 40,
                    Vardas = "Vardenis"
                }



            };
            Console.WriteLine($"Knygos kurios autorius yra{knyga.Autorius}\nsavininkas yra {knyga.savininkas.Lytis}\nkuriam yra {knyga.savininkas.Amzius}\n jo vardas yra {knyga.savininkas.Vardas}");


            var salis = new Salis()
            {
                Zemynas = "Europa",
                GyventojuSkaicius = 2_500_000,
                NacionalineKalba = "Lietuviu",
                ValdymoForma = "Respublika",
               valdziosInstitucis = new ValdziosInstitucis()
               {
                   Vadovas = "Prezidentas",
                   Vykdomojo = "Vyriausybe",
                   Leidziamji = "Seimas"
               }
                
                


        };
                 Console.WriteLine($"Zemynas - {salis.Zemynas}\nGyventoju skaicius {salis.GyventojuSkaicius}\nNacionaline Kalba{salis.NacionalineKalba}");

            Console.WriteLine($" Salis esanti {salis.Zemynas}\n kurios vadovas yra {salis.valdziosInstitucis.Vadovas}\nleidziamoji valda {salis.valdziosInstitucis.Leidziamji}vykdomoji valdzia {salis.valdziosInstitucis.Vykdomojo}");
        }


        public static void DirbtiSuPirmaUzduotimi()
        {
            Zmogus zmogus = new Zmogus();
            zmogus.akiuSpalva = "Melyna";
            zmogus.vardas = "Ricardas";
            zmogus.pavarde = "Gyras";
            zmogus.pareigos = "aktorius";
            zmogus.augintinis = new Augintinis()
            {
                Vardas = "Babsis",
                Rusis = "Suo",
                GimimoMetai = 2021
            };
            Console.WriteLine($"Informacija apie {zmogus.vardas} zmogaus autintini: \n -------- \n vardas {zmogus.augintinis.Vardas}\n Rusis {zmogus.augintinis.Rusis}");

            Console.WriteLine($"{zmogus.akiuSpalva}\nzmogus.vardas: {zmogus.vardas}\nzmogus.pavarde{zmogus.pavarde}");

            var masina = new Masina()
            {
                modelis = "Corolla",
                Gamintojas = "Toyota",
                ArDrausta = true,
                DidziausiasGreitis = 180,
                EmisijuKiekis = 0,
                KedziuKiekis = 4,
                Spalva = "Raudona",
                VariklioTipas = "Elektrinis",
                apsaugosSistema = new ApsaugosSistema()
                {
                    Gamintojas = "SecurCe",
                    Lygis = 9,
                    Pavadinimas = "ProSecure"
                }
            };
            Console.WriteLine($"Gamintojas: {masina.modelis}\nNaudoja apsaugos sistema {masina.apsaugosSistema.Gamintojas} kurios lygis yra {masina.apsaugosSistema.Lygis}");
            //var masinos = new List<masina>()
            //{
            //    new Masina(),
            //    new Masina(),
            //    new Masina(),
            //    new Masina(),
            //};

            Console.WriteLine($"Modelis: {masina.modelis}\nmasina.Gamintojas {masina.Gamintojas}");


            var IsmaniejiTelefonai = new Dictionary<int, IsmanusisTelefonas>();
            var samsung = new IsmanusisTelefonas();
            var iPhone = new IsmanusisTelefonas();
            IsmaniejiTelefonai.Add(1, samsung);
            IsmaniejiTelefonai.Add(2, samsung);
        }




        /*[6:14 PM] Edvinas  Kesminas
Uzduotis 1: Apsirašykite klases, kurios atributų pagalba apibūdintų:
        Žmogų +
        Mašiną+
        Namą(Savarankiskai) +
        Išmanųjį telefoną
        Šalį+
        (Savarankiskai)
        Knygą(Savarankiskai)
        */











            // kontraktas/interfeisas - visi public dalykai esantys klaseje
        class PavyzdineKlase
        {
            public string vardas; // laukas/field vadinsime fieldais
                                  // public int Taskai { get; set; } // Savybe/Property . vadinsime properciais

            private int taskai;

            public int Taskai;
            
        }




    }
}