// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, Loginiai operatoriai!");
Console.WriteLine("&& (AND), || (OR) ! (NOT), ^ (XOR) ");

Console.WriteLine("Neigimas" !);
bool tiesa = true;
bool melas = !tiesa;
Console.WriteLine($" tiesa = {tiesa}");
Console.WriteLine($"melas = {melas}");
Console.WriteLine($"!melas = {!melas}");

Console.WriteLine("AND &&");
Console.WriteLine($" tiesa AND tiesa {tiesa && tiesa}");
Console.WriteLine($" tiesa AND melas {tiesa && melas}");
Console.WriteLine($" melas AND tiesa {melas && tiesa}");
Console.WriteLine($" melas AND melas {melas && melas}");


Console.WriteLine("OR ||");
Console.WriteLine($" tiesa OR tiesa {tiesa || tiesa}");
Console.WriteLine($" tiesa OR melas {tiesa || melas}");
Console.WriteLine($" melas OR tiesa {melas || tiesa}");
Console.WriteLine($" melas OR melas {melas || melas}");


Console.WriteLine("XOR ^");
Console.WriteLine($" tiesa XOR tiesa {tiesa ^ tiesa}");
Console.WriteLine($" tiesa XOR melas {tiesa ^ melas}");
Console.WriteLine($" melas XOR tiesa {melas ^ tiesa}");
Console.WriteLine($" melas XOR melas {melas ^ melas}");


Console.WriteLine("NAND ! &&");
Console.WriteLine($" tiesa NAND tiesa {!(tiesa && tiesa)}");
Console.WriteLine($" tiesa NAND melas {!(tiesa && melas)}");
Console.WriteLine($" melas NAND tiesa {!(melas && tiesa)}");
Console.WriteLine($" melas NAND melas {!(melas && melas)}");


Console.WriteLine("NOR ! ||");
Console.WriteLine($" tiesa NOR tiesa {!(tiesa || tiesa)}");
Console.WriteLine($" tiesa NOR melas {!(tiesa || melas)}");
Console.WriteLine($" melas NOR tiesa {!(melas || tiesa)}");
Console.WriteLine($" melas NOR melas {!(melas || melas)}");

Console.WriteLine("NXOR ! ^");
Console.WriteLine($" tiesa NXOR tiesa {!(tiesa ^ tiesa)}");
Console.WriteLine($" tiesa NXOR melas {!(tiesa ^ melas)}");
Console.WriteLine($" melas NXOR tiesa {!(melas ^ tiesa)}");
Console.WriteLine($" melas NXOR melas {!(melas ^ melas)}");


Console.WriteLine($"melas OR melas OR tiesa    {melas || melas || tiesa}");
Console.WriteLine($"melas OR melas OR tiesa    {melas || melas || tiesa && tiesa}");
Console.WriteLine($"melas OR tiesa OR melas AND tiesa    {melas || tiesa || melas && tiesa}");


int a = 5;
int b = 5;
int c = 6;


bool s = a >= b && a > c;
Console.WriteLine(s);


/*
            PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI 2 SKAIČIUS.
            JEI ABU LYGUS PROGRAMA TURI IŠVESTI TRUE, JEI NE FALSE
*/
/*
Console.WriteLine($"Įveskite 2 skaičius");
var r = Convert.ToInt32(Console.ReadLine());
var t = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"ar lygus {r==t}");
*/
/*
 * Parašyti programą, kuri prašo įvesti 2 skaičius.
 * Jei abu lyginiai, programa turi išvesti true, jei ne folse.
 * 
 */
/*
Console.WriteLine($"Įveskite 2 skaičius");
var z = Convert.ToInt32(Console.ReadLine());
var x = Convert.ToInt32(Console.ReadLine());
bool rz = z % 2 == 0;
bool rx = x % 2 == 0;
bool r2 = rz && rx;
//arba
bool r1 = a % 2 == 0 && b % 2 == 0;
Console.WriteLine(r1);
Console.WriteLine(r2);
*/

/*Tikriausiai žinote, kad elektronikoje signalai koduojami dviejų bitų kodu. Ty 0(low) ir 1(high).
išsivaizduokite du ryšio kanalus kurie atsiunčia štai tokią informaciją:
kanalas A __---___---___---___---___
kanalas B ____---___---___---___---_
Apatinis brūkšnys (_) reiškia false, o paprastas (-) true.
Parašykite progamą kuri atvazduoja šių kanalų logines operacijas:
a) A AND B
b) A OR B
c) A XOR B
d) A NAND B
e) A NOR B
f) NOT A
g) NOT A OR B
e) (A OR B) NAND A

atsakymas:
a) ____-_____-_____-_____-___
b) __-----_-----_-----_-----_
c) __--_--_--_--_--_--_--_--_
*/

bool a = true;
bool b = false;
//kanalas A __---___---___---___---___
//kanalas B ____---___---___---___---_

//PASIBAIGT KAITALIOT A IR B // IR PADARYT KITA UZDAVINĮ
Console.WriteLine("---->"+ true.ToString().Replace("True", "-").Replace("false", "_") );
Console.WriteLine("---->" + false.ToString().Replace("True", "-").Replace("false", "_"));
Console.WriteLine("M AND N");
Console.WriteLine($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(a && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(a && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(a && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!b && !b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(a && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!b && !b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(a && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!b && !b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(!a && a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b && !b).ToString().Replace("True", "-").Replace("False", "_")}");

Console.WriteLine("b) A OR B");
Console.WriteLine($"{(a || a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(a || b).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b || a).ToString().Replace("True", "-").Replace("False", "_")}");
Console.WriteLine($"{(b || b).ToString().Replace("True", "-").Replace("False", "_")}");
