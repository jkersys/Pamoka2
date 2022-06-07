namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Console.Write("išvedimas");
            //Console.Write("vienoje ");
            //Console.Write("eilutėje");
            //Console.WriteLine();
            // Console.WriteLine("tekstas kitoje eilutėje");
            // Console.Write("tekstas");

            //Console.WriteLine("---------------");
            //Console.WriteLine("išvedimas" + "vienoje" + "eilutėje"); //konkatnacija
            // Console.WriteLine("{0} {1} {2}", "išvedimas", "vienoje", "eilutėje"); // kompozicija
            //Console.WriteLine($"{"išvedimas"} {"vienoje"} {"eilutėje"}"); // interpoliacija
            // Console.WriteLine("---------------");

            //Console.WriteLine("----press any key to continue---");
            //Console.ReadKey();
            // Console.Clear();

            //Console.WriteLine("įveskite savo vadą, o aš jį pakartosiu");

            //Console.WriteLine("Įveskite raidę");
            //var key = Console.ReadKey();
            // Console.WriteLine("įvestassimbolis {0}", key.keychar);

            console.write("justinas");
            console.writeline("-----press any key to continue----------");
            console.readkey();
            console.clear();

            console.writeline("įveskite savo vardą, o aš jį pakartosiu:");
            console.writeline("o štai mano pakartojimas " + console.readline());
            console.writeline("o štai mano pakartojimas {0}", console.readline());
            console.writeline($"o štai mano pakartojimas {console.readline()}");

            console.writeline("įveskite savo vardą, o aš jį pakartosiu:");
            console.writeline("o štai mano pakartojimas " + console.readline());
            console.writeline("o štai mano pakartojimas {0}", console.readline());
            console.writeline($"o štai mano pakartojimas {console.readline()}");

            console.writeline("įveskite raidę");
            var key = console.readkey();
            console.writeline("ivestas simbolis {0}", key.keychar);
            console.writeline("ivestas simbolis {0}", key.key);
            console.writeline("ivestas simbolis {0}", (int)key.keychar);

            console.writeline("ivestas simbolis {0}", console.readkey().keychar);
            console.writeline("ivestas simbolis {0}", (int)console.readkey().keychar);



            Console.ReadKey();




        }
    }
}