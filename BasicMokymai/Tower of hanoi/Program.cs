﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//prisiskiriam kintamuosius, sulygiuojam (\u0023 reiškia #)
string stulp1_eil1 = "      |";
string stulp2_eil1 = "            |"; 
string stulp3_eil1 = "            |";
string stulp1_eil2 = "     \u0023|\u0023";
string stulp2_eil2 = "           |";
string stulp3_eil2 = "            |";
string stulp1_eil3 = "    \u0023\u0023|\u0023\u0023";
string stulp2_eil3 = "          |";
string stulp3_eil3 = "            |";
string stulp1_eil4 = "   \u0023\u0023\u0023|\u0023\u0023\u0023";
string stulp2_eil4 = "         |";
string stulp3_eil4 = "            |";
string stulp1_eil5 = " \u0023\u0023\u0023\u0023\u0023|\u0023\u0023\u0023\u0023\u0023";
string stulp2_eil5 = "       |";
string stulp3_eil5 = "            |";


Console.WriteLine("Tower of Hanoi");
Console.WriteLine("\n 1. Nupieškite Tower of Hanoi piešiniui naudokite kintamuosius\n");


Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");

Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kitą veiksmą
Console.ReadKey();



Console.WriteLine("\n 2. Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi\n");

//apverčiam piramdę su kintamaisiais ir palygiuojam, buvo galima redaguot tik pirmą stulp, bet kol mokaus ir pirmą kartą rašau kodą bus gerai taip, jeigu ateityje naudosiu kaip pavizdį gerai apmastyt veiksmus, kad nebūtų perteklinių.
stulp1_eil1 = " \u0023\u0023\u0023\u0023\u0023|\u0023\u0023\u0023\u0023\u0023";
stulp1_eil2 = "   \u0023\u0023\u0023|\u0023\u0023\u0023";
stulp1_eil3 = "    \u0023\u0023|\u0023\u0023";
stulp1_eil4 = "     \u0023|\u0023";
stulp1_eil5 = "      |";
stulp2_eil1 = "       |";
stulp2_eil2 = "         |";
stulp2_eil3 = "          |";
stulp2_eil4 = "           |";
stulp2_eil5 = "            |";
stulp3_eil1 = "            |";
stulp3_eil2 = "            |";
stulp3_eil3 = "            |";
stulp3_eil4 = "            |";
stulp3_eil5 = "            |";

Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");

Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kitą veiksmą
Console.ReadKey();

Console.WriteLine("\n 3. Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi\n");


//vėl prisiskiriam kintamuosius ir lygiuojam(būtų užtekę prisiskirt tik pirmam stulpeliui)
stulp1_eil1 = "      |";
stulp1_eil2 = "      |";
stulp1_eil3 = "      |";
stulp1_eil4 = "      |";
stulp1_eil5 = "      |";
stulp1_eil5 = "      |";
stulp2_eil1 = "            |";
stulp2_eil2 = "            |";
stulp2_eil3 = "            |";
stulp2_eil4 = "            |";
stulp2_eil5 = "            |";


Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");

Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kitą veiksmą
Console.ReadKey();


Console.WriteLine("\n 4.	Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi\n");


//keičiam kintamuosius, pasilygiuojam
stulp1_eil5 = " \u0023\u0023\u0023\u0023\u0023|\u0023\u0023\u0023\u0023\u0023";
stulp2_eil5 = "  \u0023\u0023\u0023\u0023\u0023|\u0023\u0023\u0023\u0023\u0023";
stulp3_eil5 = "  \u0023\u0023\u0023\u0023\u0023|\u0023\u0023\u0023\u0023\u0023";

Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");

Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kitą veiksmą
Console.ReadKey();


Console.WriteLine("\n 5. Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi\n");

//Vėl keičiu kintamuosius ir sulygiuoju
stulp1_eil5 = " \u0023\u0023\u0023\u0023\u0023I\u0023\u0023\u0023\u0023\u0023";
stulp2_eil5 = "    \u0023\u0023\u0023|\u0023\u0023\u0023";
stulp3_eil4 = "           \u0023|\u0023";
stulp3_eil5 = "       \u0023\u0023|\u0023\u0023";

Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");


Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kitą veiksmą
Console.ReadKey();

Console.WriteLine("\n 6.	Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi\n");

//kintamųjų reikšmių keitimas ir lygiavimas
stulp1_eil5 = " \u0023\u0023\u0023\u0023\u0023|\u0023\u0023\u0023\u0023\u0023";
stulp2_eil5 = "    \u0023\u0023\u0023|\u0023\u0023\u0023";
stulp3_eil4 = "           \u0023|\u0023";
stulp3_eil5 = "       \u0023\u0023|\u0023\u0023";
stulp1_eil4 = "     \u0023|\u0023 ";
stulp2_eil4 = "          |";

Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");

Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kita veiksmą
Console.ReadKey();

Console.WriteLine("\n 7.	Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi\n");

//vėl kintamieji keičiami ir pasilygiuojam
stulp2_eil1 = "         \u0023\u0023|\u0023\u0023";
stulp2_eil2 = "         \u0023\u0023|\u0023\u0023";
stulp2_eil3 = "         \u0023\u0023|\u0023\u0023";
stulp2_eil4 = "       \u0023\u0023|\u0023\u0023";
stulp2_eil5 = "    \u0023\u0023|\u0023\u0023   ";      
 

Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");


Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kitą veiksmą
Console.ReadKey();

Console.WriteLine("\n 8. Į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi\n");

//pakeičiam kintamuosius(būtų užtekę tik dalį pakeist).
stulp1_eil1 =  "      |";
stulp1_eil2 =  "      |";
stulp1_eil3 =  "      |";
stulp1_eil4 =  "      |";
stulp1_eil5 = "      |";
stulp2_eil1 = "            |     ";
stulp2_eil2 = "            |     ";
stulp2_eil3 = "            |     ";
stulp2_eil4 = "            |     ";
stulp2_eil5 = "            |      ";
stulp3_eil1 = "      |";
stulp3_eil2 = "     \u0023|\u0023";
stulp3_eil3 = "    \u0023\u0023|\u0023\u0023";
stulp3_eil4 = "   \u0023\u0023\u0023|\u0023\u0023\u0023";
stulp3_eil5 = "\u0023\u0023\u0023\u0023\u0023|\u0023\u0023\u0023\u0023\u0023";



Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");


Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kita veiksmą
Console.ReadKey();

Console.WriteLine("\n 9.	pakeiskite visų elementų dizainą iš # į kabutes\n");

//Groteles pakeičiam kabutėm.
stulp3_eil1 = "      |";
stulp3_eil2 = "     \u0023|\u0023".Replace("#", "\""); ;
stulp3_eil3 = "    \u0023\u0023|\u0023\u0023".Replace("#", "\""); ;
stulp3_eil4 = "   \u0023\u0023\u0023|\u0023\u0023\u0023".Replace("#", "\""); ;
stulp3_eil5 = "\u0023\u0023\u0023\u0023\u0023|\u0023\u0023\u0023\u0023\u0023".Replace("#", "\"");


Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");

Console.WriteLine("\n\n\n------tęsti-------\n");

//pasidarom kad po paspaudomo atidarytų kita veiksmą
Console.ReadKey();

Console.WriteLine("\n 10.	paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute ");

Console.WriteLine("\nNupieškite pirmo stulpelio pirmą eilutę");

//piešimo įdėjimas
stulp1_eil1 = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"1eil. {stulp1_eil1}{stulp2_eil1}{stulp3_eil1}");
Console.WriteLine($"2eil. {stulp1_eil2}{stulp2_eil2}{stulp3_eil2}");
Console.WriteLine($"3eil. {stulp1_eil3}{stulp2_eil3}{stulp3_eil3}");
Console.WriteLine($"4eil. {stulp1_eil4}{stulp2_eil4}{stulp3_eil4}");
Console.WriteLine($"5eil. {stulp1_eil5}{stulp2_eil5}{stulp3_eil5}");
Console.WriteLine("      ----1sulp-------2stulp-------3stulp----");

//Visumoj kodas atrodo baisiai ir neaišku ar teisingas, bet lyg ir veikia.

