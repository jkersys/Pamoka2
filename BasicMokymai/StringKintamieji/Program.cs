// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("string (tekstinio) tipo kintamieji");
string kintamasis = "Hello World";

Console.WriteLine(kintamasis);

var stringkintamasis = "betkoks tekstas";
string tuščias = "";
string nulas = null;
string laisvaerdve = "      ";

string konkatinacija = stringkintamasis + kintamasis;
Console.WriteLine(konkatinacija );

string komposicija = string.Format("{0}", stringkintamasis);
string interpoliacija = $"{stringkintamasis}";

kintamasis = "tekstas belenkoks";
Console.WriteLine(kintamasis);