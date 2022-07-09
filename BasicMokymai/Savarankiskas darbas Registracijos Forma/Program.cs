namespace Savarankiskas_darbas_2022_06_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, Užduotis!");




            //Asmenskodasprivalomas jeigu nera nutraukia

            /* 
           Sukurkite programą, kuri pateiktų vartotojo registracijos formą.
           Vartotojas įveda:
            - vardą ir pavardę 
            - asmens kodą (11simb.)
            - amžių (sveiką skaičių metais) ir/arba gimimo datą (galima abu, tik kažkurį vieną, ar neįvesti nei vieno)
          Programa į ekraną išveda ataskatą:
           - šiandienos datą
           - Vardas, pavardė
           - Lytis
              <HINT> asmens kodo pirmasis rodo gimimo šimtmetį ir asmens lytį 
              (1 – XIX a. gimęs vyras, 
               2 – XIX a. gimusi moteris, 
               3 – XX a. gimęs vyras,
               4 – XX a. gimusi moteris, 
               5 – XXI a. gimęs vyras,
               6 – XXI a. gimusi moteris
               tolesni šeši: 
                    metai (du skaitmenys), 
                    mėnuo (du skaitmenys), 
                    diena (du skaitmenys))     
           - Asmens kodas 
              <NEPRIVALOMAS PASUNKINIMAS> asmens kodas validuojamas pagal tokias salygas
                 Paskaičiuojamas Kontrolinis skaičius 
                 a) jei kontrolinis skaičius teisingas išvedamas asmens kodas
                 b) jei neteisingas išvedamas tekstas "kodas neteisingas", 
                    o laukeAmžiaus patikimumas išvedama "patikimumui trūksta duomenų" 
                    <HINT> https://lt.wikipedia.org/wiki/Asmens_kodas
           - Amžius
           - Amžiaus patikimumas - pagal tokias sąlygas:
           -  jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu. 
              a) jei sutampa išvesti "amžius patikimas"
              b) jei nesutampa išvesti "amžius pameluotas"
           - jei įvesta gimimo data sulyginti su įvestu asmens kodu. 
              a) jei sutampa išvesti "amžius patikimas" 
              b) jei nesutampa išvesti "amžius pameluotas"
           - jei įvesta ir amžius ir gimimo data sulyginti su įvestu asmens kodu. 
              a) jei viskas sutampa išvesti "amžius tikras" 
              b) jei asmens kodu sutampa tik vienas įvestų, išvesti "amžius nepatikimas" 
              c) jei nesutampa išvesti "amžius pameluotas"
           - jei neįvesta nei amžius nei gimimo data išvesti
              a) "patikimumui trūksta duomenų"
Rezultatas gali atrodyti taip:
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      2022-06-20       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓     Vardas, pavardė ▓ Vardenis Pavardenis                 ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓               Lytis ▓ Vyras                               ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓        Asmens kodas ▓ 44012029286                         ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓              Amžius ▓ 82                                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓         Gimimo data ▓ 1980-06-20                          ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓ Amžiaus patikimumas ▓ amžius nepatikimas                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
*/





            //prasom ivesti varda ir pavarde
            Console.WriteLine("Įveskite savo vardą ir pavardę");
            string vardasIrPavarde = Console.ReadLine();


            //tikrinam ar ivesta vardas ir pavarde (All(char.IsLetter) nepraleidzia whitespaco)
            if (vardasIrPavarde.Length == 0 || vardasIrPavarde.Any(char.IsDigit) || vardasIrPavarde.Any(char.IsSymbol))
            {
                Console.WriteLine("Įvedete neteisingus duomenis");
                Environment.Exit(0);
            }    
          

            Console.WriteLine("Įveskite savo asmens kodą (11 simb.)");
            var asmensKodas = (Console.ReadLine());
            //tikrinam ar įvesta 11 skaitmenu ir ar visi ivesti simboliai yra skaiciai 
            if (asmensKodas.Length == 11 && asmensKodas.All(char.IsNumber))
            {
               
            }
            else
            {
                Console.WriteLine("Neteisingai ivedete asmens koda");
                Environment.Exit(0);
            }





            ///amziaus ivedimas
            Console.WriteLine("Įveskite amžių");
            string amziusString = Console.ReadLine();

            //gimimo datos ivedimas
            Console.WriteLine("Įveskite gimimo datą formatu yyyy-mm-dd");
            var gimimoDataString = Console.ReadLine();

            //issivedam siandienos data atvzaidavimo lentelei, kad rodytu pildymo data
            var siandienosData = DateTime.Today;


            //******TIKRINAM AR VYRAS AR MOTERIS*******
            //pasiimam asmens kodo pirmą raidę tikrinimui
            var asmensKodoPirmaRaide = asmensKodas[0];
            
            //Pasidarom string kintamaji kurio reiksme istatysim su if
            string lytis = "";
            //tikrinam ar pirma asmens kodo raide yra 1, 3, 5, jeigu taip gražinam reiksme kad tai vyras
            if (asmensKodoPirmaRaide == '1' || asmensKodoPirmaRaide == '3' || asmensKodoPirmaRaide == '5')
            {
                lytis = "Vyras";
            }
            //tikrinam ar pirma asmens kodo raide yra 2, 4, 6, jeigu taip gražinam reiksme kad tai moteris
            else if (asmensKodoPirmaRaide == '2' || asmensKodoPirmaRaide == '4' || asmensKodoPirmaRaide == '6')
            {
                lytis = "Moteris";
            }
            else
            {   // jeigu nei vyras, nei moteris uzdarom programa
                Console.WriteLine("Neteisingai ivedete asmens koda");
                Environment.Exit(0);
            }


            //******Issivedam is asmens kodo gimimo data
            //pasiimam metus
            var gimimoMetaiIsAsmensKodoString = asmensKodas.Substring(1, 2);
            //pasiimam menesi
            var gimimoMenesisIsAsmensKodoString = asmensKodas.Substring(3, 2);
            //pasiimam diena
            var gimimoDienaisIsAsmensKodoString = asmensKodas.Substring(5, 2);

            //paimtus skaicius parsinam is string i int
            var gimimoMetaiIsAsmensKodo = int.Parse(gimimoMetaiIsAsmensKodoString);
            var menesis1 = int.Parse(gimimoMenesisIsAsmensKodoString);
            var diena1 = int.Parse(gimimoDienaisIsAsmensKodoString);


            //skaiciuojam amziu
            if (asmensKodoPirmaRaide == '1' || asmensKodoPirmaRaide == '2')
            {
                gimimoMetaiIsAsmensKodo = gimimoMetaiIsAsmensKodo + 1800;
            }
            if (asmensKodoPirmaRaide == '3' || asmensKodoPirmaRaide == '4')
            {
                gimimoMetaiIsAsmensKodo = gimimoMetaiIsAsmensKodo + 1900;

            }
            if (asmensKodoPirmaRaide == '5' || asmensKodoPirmaRaide == '6')
            {
                gimimoMetaiIsAsmensKodo = gimimoMetaiIsAsmensKodo + 2000;
            }

            //susidedam turimus int'us i data 
            DateTime dataGautaIsAsmensKodo = new DateTime(gimimoMetaiIsAsmensKodo, menesis1, diena1);
           // String dataGautaIsAsmensKodoString = dataGautaIsAsmensKodo.ToString("yyyy-MM-dd"); //nereikalingas


           

            //kintamasis amziaus patikimumui isvesti
            var amziausZinute = "amžius patikimas";
            //kintamieji patikrinti ar pagal vartotojo ivestus duomenis patikimas amzius ir gimimo data 
            var amziusPagalMetusPatikimas = false;
            var amziusPagalGimimoDataPatikimas = false;




                          //tikrinam ar ivesti bent vienas is duomenu
               if (string.IsNullOrEmpty(amziusString) == true && string.IsNullOrEmpty(gimimoDataString) == true)
                {
                    amziausZinute = "patikimumui trūksta duomenų";
                }
               else
                {
            
                    if (string.IsNullOrEmpty(amziusString) == false) // tikrinam ar ivestas amzius
                {
                    var amzius = int.Parse(amziusString); // amziu pasiparsinam i int
                    var gimimoMetaiIsskaiciuoti = DateTime.Today.AddYears(-amzius); // is siandienos datos atimam ivestus metus
                    // var gimimoMetaiIsskaiciuotiString = gimimoMetaiIsskaiciuoti.ToString("yyyy-MM-dd");

                    //   Console.WriteLine($"dataGautaIsAsmensKodo{dataGautaIsAsmensKodo.Year} {gimimoMetaiIsskaiciuoti.Year} gimimoMetaiIsskaiciuoti");

                    if (dataGautaIsAsmensKodo.Year == gimimoMetaiIsskaiciuoti.Year) // tikrinam ar paskaiciuoti metai sutama su asmens kodo metais
                    {
                        amziusPagalMetusPatikimas = true;     // jeigu sutampa isvedam true
                        amziausZinute = "amžius patikimas";
                    }
                    else
                    {
                        amziausZinute = "amžius pameluotas"; // jeigu nesutampa false
                    }
                }

                // tikrinames ar ivesta data, jeigu taip ar sutampa su askems kodu
                if (string.IsNullOrEmpty(gimimoDataString) == false)
                {
                    var gimimoData = DateTime.Parse(gimimoDataString);
                    if (gimimoData == dataGautaIsAsmensKodo)
                    {

                        amziusPagalGimimoDataPatikimas = true;
                        amziausZinute = "amžius patikimas";
                    }
                    else
                    {
                        amziausZinute = "amžius pameluotas";
                    }
                }


                if (string.IsNullOrEmpty(amziusString) == false && string.IsNullOrEmpty(gimimoDataString) == false)
                {
                    if (amziusPagalMetusPatikimas == true && amziusPagalGimimoDataPatikimas == true)
                    {
                        amziausZinute = "amžius tikras";
                    }
                    if (amziusPagalMetusPatikimas == true && amziusPagalGimimoDataPatikimas == false)
                    {
                        amziausZinute = "amžius nepatikimas";
                    }
                    if (amziusPagalGimimoDataPatikimas == true && amziusPagalMetusPatikimas == false)
                    {
                        amziausZinute = "amžius nepatikimas";
                    }

                    if (amziusPagalMetusPatikimas == false && amziusPagalGimimoDataPatikimas == false)
                    {
                        amziausZinute = "amžius pameluotas";
                    }

                }

                }


                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ATASKAITA APIE ASMENĮ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓{siandienosData.ToString("yyyy-MM-dd")}▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓Vardas, pavarde▓▓▓▓▓▓{vardasIrPavarde}                                                            ▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓Lytis ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓{lytis}                                                                     ▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓Asmens kodas▓▓▓▓▓▓▓▓▓{asmensKodas}                                                               ▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓Amzius▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓{amziusString}                                                                        ▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓Gimimo data▓▓▓▓▓▓▓▓▓▓{gimimoDataString}                                                                ▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓Amziaus patikimumas▓▓{amziausZinute}                                                             ▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");

            
        }
    }
}




















