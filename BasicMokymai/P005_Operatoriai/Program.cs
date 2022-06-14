namespace P005_Operatoriai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Operatoria!");

            //Realiaciniai operatoriai == != >= <=

            var skaicius = 10;
            var nelyginisSKaicius = 5;
            var lyginisSKaicius = 10;


            Console.WriteLine(" == patikrina ar kintamieji yra lygus");
            Console.WriteLine($" {skaicius}=={lyginisSKaicius} yra {skaicius == lyginisSKaicius} ");

            bool ar10yralygu5 = skaicius == nelyginisSKaicius;
            Console.WriteLine($" {skaicius}=={nelyginisSKaicius} yra {ar10yralygu5} ");
        }
    }
}