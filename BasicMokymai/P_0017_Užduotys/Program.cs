using System.Text;

namespace P_0017_Užduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var skaicius1 = 0;
            /*

            //Stringbuilder sukurimas
            StringBuilder sb = new StringBuilder(); // be teksto 
            StringBuilder sb1 = new StringBuilder("Labas pasauli"); // sukurimo metu irasomas tekstas
            StringBuilder sb2 = new StringBuilder(123456); // sukurimo metu taip pat irasomas tekstas 

            //teksto isgavimas is StringBuilder
            Console.WriteLine(sb.ToString());

            //teksto pridejimas per stringbuilder
            sb.Append("Labas");
            sb.Append("Pasauli");
            sb.AppendLine();
            sb.AppendLine("Labas #");

            //teksto iterpimas
            sb.Insert(5, "AAAA");
            Console.WriteLine(sb.ToString());


            //Teksto pasalinimas
            sb.Remove(6, 2);
            Console.WriteLine(sb.ToString());

            //Teksto pakeitimas
            sb.Replace("Labas", "Hello");
            Console.WriteLine(sb.ToString());

            */



            //  ReadIntNumber(); 

            //var sk = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{IntegerToBinary(45)}");

            //  Console.WriteLine("iveskite skaiciu");

            int skaicius1 = 0;

            //Console.WriteLine(SkaiciuTrikampis(5));
            //Console.WriteLine(LygiasonisTrikampis(5));


            Console.WriteLine($"{LygiasonisTrikampis(7)}");
        }





        /*
        UŽDUOTIS 1.
      Sukurti metodą ReadIntNumber, 
      kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
      Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
      įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
      neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
      (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.
        */

        public static void ReadIntNumber()

        {
            Console.WriteLine("Iveskite skaiciu");
            string input = "";
            bool arIvestasSKaiciusTeisingas = false;

            while (!arIvestasSKaiciusTeisingas)
            {
                input = Console.ReadLine();
                arIvestasSKaiciusTeisingas = int.TryParse(input, out _);

                if (!arIvestasSKaiciusTeisingas)
                {
                    Console.WriteLine("neteisingai ivestas skaicius");
                }
            }


            Console.WriteLine($"Ivestas skaicius {input}");

        }


        /*Sukurti metodą IntegerToBinary, 
        kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
        2 --> 10
        7 --> 111
        45 --> 101101
        */

        public static string IntegerToBinary(int sk)

        {
            string binSk = "";
            while (sk > 0)
            {
                binSk = sk % 2 + binSk;
                sk /= 2;
            }
            return binSk;

        }

        /*Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
      laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
      kelsime, antras laipsnis, kuriuo pakelti.
      NB! kai skaičius 0 o laipsnis > 0 gąžinama 1
      NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
      NB! kai laipsnis = 1 gąžinamas tas pats skaičius
        */

        public static int PakeltiLaipsniu(int skaicius, int laipsnis)
        {


            if (laipsnis == 0 && skaicius > 0)
            {
                return 1;
            }
            if (skaicius == 0 && laipsnis == 0)
                return 1;
            if (laipsnis == 1)
            {
                return skaicius;
            }
            var rezultatas = skaicius;
            for (int i = 1; i < laipsnis; i++)
            {
                rezultatas = rezultatas * skaicius;
            }
            return rezultatas;

        }


        /*Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą). 
        Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
        5
        55
        555
        5555
        55555
        */


        public static string SkaiciuTrikampis(int skaicius1)
        {
            // Console.WriteLine("Iveskite skaiciu nuo 1 iki 9");
            // skaicius1 = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb1 = new StringBuilder();



            if (skaicius1 >= 1 && skaicius1 <= 9)

            {
                for (int i = 0; i < skaicius1; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        sb1.Append(skaicius1);
                    }
                    sb1.AppendLine();
                }


            }
            else
                Console.WriteLine("Neteisingas skaicius");
            SkaiciuTrikampis(skaicius1);

            return sb1.ToString();
        }

        /*
         * Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
       jeigu įveda netinkamą skaičių
       prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
        7
        77
        777
        7777
        77777
        777777
        7777777
        777777
        77777
        7777
        777
        77
        7
        */


        public static string LygiasonisTrikampis(int skaicius1)
        {
           
            StringBuilder sb2 = new StringBuilder();
            
            while (skaicius1 < 1 && skaicius1 > 9)
                            {
                Console.WriteLine("Iveskite skaiciu");
                skaicius1 = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= skaicius1; i++)
                {
                    sb2.Append(skaicius1);
                    Console.WriteLine(sb2.ToString());
                }
                for (int i = skaicius1; i >= 1; i--)
                {
                    sb2.Remove(0, 1);
                    Console.WriteLine(sb2.ToString());
                }
          

            }
                return sb2.ToString();

        }







        }
    }   




       



