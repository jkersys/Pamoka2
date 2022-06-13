// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, priskyrimo operatoriai = += -= *= /=");
int skaicius;
int kitasskaicius = 20;
int neyginisSkaicius = 5;
skaicius = 10;
kitasskaicius = skaicius;
Console.WriteLine($" skaicius = {skaicius}, kitasSkaicius = {kitasskaicius}"); // skaicius int kitasskaicius = 20 pradingo

kitasskaicius += neyginisSkaicius;
Console.WriteLine($" kitasSkaicius = {neyginisSkaicius}");

kitasskaicius -= neyginisSkaicius;
Console.WriteLine($" kitasSkaicius = {kitasskaicius}");

kitasskaicius *= neyginisSkaicius;
Console.WriteLine($" kitasSkaicius = {kitasskaicius}");

kitasskaicius = 21;

kitasskaicius /= neyginisSkaicius;
Console.WriteLine($" kitasSkaicius = {kitasskaicius}");

double doubleSkaicius = 21;
doubleSkaicius /= (double)neyginisSkaicius;
Console.WriteLine($" kitasskaicius = {doubleSkaicius}");

Console.WriteLine();
Console.WriteLine("Hello, matematiniai operatoriai + - * / % ++ --");
//sudetis
int suma = skaicius + kitasskaicius;
Console.WriteLine(" suma= skaicius+kitasskaicius = {0}", suma);
int atimtis = skaicius - kitasskaicius;
Console.WriteLine(" atimtis= skaicius-kitasskaicius = {0}", atimtis);
int daugyba = skaicius * kitasskaicius;
Console.WriteLine(" daugyba= skaicius*kitasskaicius = {0}", daugyba);
double dalyba = (double)skaicius / kitasskaicius; // 
Console.WriteLine(" dalyba= skaicius/kitasskaicius = {0}", dalyba);

int matematinisRezultatas = 1 + 2 - 3 + 4 + neyginisSkaicius - skaicius;
Console.WriteLine($" matematinisRezultatas = {matematinisRezultatas} ");


var dalybaSuLiekana = neyginisSkaicius % 2;
Console.WriteLine(" dalyvaSuLiekana = neyginisSkaicius % 2 = {0}", dalybaSuLiekana);
skaicius++; // prideda 1
Console.WriteLine($" skaicius ={skaicius}");

skaicius--; // atima 1
Console.WriteLine($" skaicius ={skaicius}");
//are of trapezoid ( trapecijos ploto skaiciavimas)
double side1 = 5.5;
double side2 = 3.25;
double heigh = 4.6;
double area = (side1 + side2) / 2 * heigh;

double areaKazkasKito = ((side1 * 2) + side2) / (2 * heigh); // sklaustelius galima deliotis kaip nori pagal matematines taisykles


int nulis = 0;
int int10 = 10;
long long10 = 10;
double double10 = 10;

//Console.WriteLine($" int10/nulis={int10/nulis}"); //luzta
//Console.WriteLine($"long10/nulis= {long10 / nulis}"); //luzta
Console.WriteLine($"double0/nulis= {double10 / nulis}"); //neluzta grazina begalybes zenkla - ty begalybes implementacija

double a = double.PositiveInfinity;
Console.WriteLine($" a= {a}");

Console.WriteLine($" {a==double.PositiveInfinity}");
Console.WriteLine($" {a == double.NegativeInfinity}");
Console.WriteLine($"a - 500 = {a -500}");

double a1 = double.NaN;
Console.WriteLine($" begalybe / begalybe ={a / double.PositiveInfinity}");

//****** Overflow and Underflow

short s1 = 30_000;
short s2 = 30_000;
short s3 = (short)(s1 + s2);
Console.WriteLine($"s3={s3}");
/*checked
{
    s3 = (short)(s1 + s2);
}


/*PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS.PROGRAMA TURI IŠVESTI
• SKAIČIŲ SUMĄ
• SKAIČIŲ SKIRTUMĄ
• SANDAUGĄ
• DALYBĄ
*/


Console.WriteLine("įveskite 1 skaičių");
int skaicius1 = int.Parse(Console.ReadLine());
Console.WriteLine("įveskite 2 skaičių");
int skaicius2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{skaicius1}+{skaicius2}={skaicius1+skaicius2}");
Console.WriteLine($"{skaicius1}-{skaicius2}={skaicius1-skaicius2}");
Console.WriteLine($"{skaicius1}*{skaicius2}={skaicius1*skaicius2}");
Console.WriteLine($"{skaicius1}/{skaicius2}={skaicius1/skaicius2}");

//PARAŠYTI PROGRAMĄ, 3 SKAIČIUS. PROGRAMA TURI IŠVESTI ŠIŲ SKAIČIŲ VIDURKĮ

int skaicius11 = int.Parse(Console.ReadLine());
int skaicius22 = int.Parse(Console.ReadLine());
int skaicius33 = int.Parse(Console.ReadLine());

Console.WriteLine("vidurkis = {0}", (double)(skaicius11+skaicius22+skaicius33) / 3);