namespace Datos_bandymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string bandymas = "54321";
            var raide = bandymas[0];
            Console.WriteLine($"{raide == '5'}");


            char q = '1';
            Console.WriteLine($"{q + '1' + '1' + '1'} {'1' + '1' + '1' + '1'}");


            Console.WriteLine($"{q + '1' == '1' + '1'}");

            Console.WriteLine($"{q -48}");



            char a = '1';
            char b = '2';

            Console.WriteLine($"{a + b} ir a {a + '1'}  ");



            Console.WriteLine("Įveskite savo asmens kodą (11 simb.)");
            var asmensKodas = (Console.ReadLine());
            //tikrinam ar įvesta 11 skaitmenu ir ar visi ivesti simboliai yra skaiciai 
            if (asmensKodas.Length == 11 && double.TryParse(asmensKodas, out _))
            {
                //ar galima taip palikt?
            }
            else
            {
                Console.WriteLine("Neteisingai ivedete asmens koda");
                Environment.Exit(0);
            }


            //pasiimam asmens kodo pirmą raidę tikrinimui
            var asmensKodoPirmaRaide = asmensKodas[0];
            var gimimoMetaiIsAsmensKodoString = asmensKodas.Substring(1, 2);
            var menesis = asmensKodas.Substring(3, 2);
            var diena = asmensKodas.Substring(5, 2);
            var menesis1 = Int32.Parse(menesis);
            var diena1 = Int32.Parse(diena);
            var gimimoMetaiIsAsmensKodo = int.Parse(gimimoMetaiIsAsmensKodoString);

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

            DateTime dob = new DateTime(gimimoMetaiIsAsmensKodo, menesis1, diena1);
            String dob2 = dob.ToString("yyyy-MM-dd");
            //DateTime dob3 = DateTime.Parse(dob2);
            //Console.WriteLine($"{dob}");

            //var data = Convert.ToDateTime(gimimoMetaiIsAsmensKodo + menesis1 + diena1);

           // Console.WriteLine($"{data}");

            // var menesis = asmensKodas.Substring(3, 2);
            //var diena = asmensKodas.Substring(5, 2);
            // var menesis1 = Int32.Parse(menesis);
            //var diena1 = Int32.Parse(diena);
           // var gimimostring = Convert.ToString(gimimoMetaiIsAsmensKodo);
            //var gimimo = DateTime.Parse(gimimostring);
           // Console.WriteLine($"{gimimo}");

            // DateTime data = new DateTime(gimimoMetaiIsAsmensKodo, menesis1, diena1);
            Console.WriteLine($"{gimimoMetaiIsAsmensKodo}");
            //Console.WriteLine($"{data}");


        }
    }
}