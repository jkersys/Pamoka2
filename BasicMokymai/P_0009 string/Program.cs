namespace P_0009_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //var a = Console.WriteLine("Kazkas"); negrazina nieko
            // var b = Console.ReadLine(); // grazina reikmse string
            //  var c = 1 > 2 ? "kazkas" : "kitas"; // duoda reiksme kuria galima irasyti

            Console.WriteLine("String manipuliacijos");

            Console.WriteLine("******string constructor");
            //masyvas angliskai array
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters); //string constructor
            Console.WriteLine(greetings);
            //Console.WriteLine(greetings[2]); // pasiima viena raide is zodzio nurodant [] indeksa

            string vardas = "Petras";
            Console.WriteLine(vardas[2]); // isves raide
            DateTime siandien = DateTime.Today;

            //-------------------------------
            Console.WriteLine("******* string concatinaton");
            var pilnasVardas = vardas + "Pavadenis";
            Console.WriteLine(pilnasVardas);

            //---------------------------------
            Console.WriteLine("****** string composition");
            var vardasirData = string.Format("{0} data ={1}", vardas, siandien);
            Console.WriteLine(vardasirData);

            Console.WriteLine("****** string interpoliation");
            var vardasirData1 = string.Format($"{vardas} data={siandien}");
            Console.WriteLine(vardasirData1);

            //-------------------------------
            string? nullas = null; // stringas gali buti nulas
            string baltaErdve = "         "; // tarpas kuriam nera informacijos
            string tuscia = ""; // "" ir string.Empty tapatus dalykai
            string tuscia1 = string.Empty; // 
            Console.WriteLine("ar \"\" yra tapatu string. Empty? {0}", tuscia == tuscia1);
            Console.WriteLine("ar \"\" yra tapatu baltaErdve? {0}", tuscia == baltaErdve);
            bool arTuscia = string.IsNullOrEmpty(tuscia); //tikrinimas ar tuscia tikrai tuscia
            Console.WriteLine($"arTuscia={arTuscia}");
            bool arNullas = string.IsNullOrEmpty(nullas); // tikrinimas ar nullas tikrai yra nullas


            bool arBaltaErdveYRaTuscia = string.IsNullOrEmpty(baltaErdve); //tikrinam ar balta erve yra tuscia
            Console.WriteLine($"arBaltaErdveYRaTuscia={arBaltaErdveYRaTuscia}");

            bool arBaltaerve = string.IsNullOrWhiteSpace(baltaErdve); // tikrinam ar balta erdve yra balta erdve 
            Console.WriteLine($"arBaltaerdve={arBaltaerve}");

            //---------------------------------------------
            Console.WriteLine("-------------------------------");
            string aa1 = "kabute = \"";
            string aa2 = "kabute = \\";
            string aa3 = "kabute = \n";
            string aa4 = $"eilute {Environment.NewLine} nauja"; // isveda i nauja eilute
            string aa5 = $"kelias diskineje sistemoje {Path.DirectorySeparatorChar} program files\\ {Path.DirectorySeparatorChar}windows";
            string aa6 = $"{{}}";
            string aa7 = @"galime
rasyti teksta
per
kelias eilutes";

            //-----------------------------------
            Console.WriteLine("-----------------");
            double skaicius = 6.6566555465465465456465;
            string skaiciusSuapribotukiekiuPoKablelio = skaicius.ToString("0.00"); // To.String operacija visada apvalina
            Console.WriteLine(skaiciusSuapribotukiekiuPoKablelio);


            //tryparse grazina 2 reiksmes patikrina ar is stringo galima gauti skaitmeni


            //-------------------
            //string metodai

            //is asmens kodi iskaiciuota 

            





        }
    }
}