// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//
//Išveskite į console savo vardą
//Console.WriteLine("Justinas");

//Nuskaitykite iš klaviatūros savo vardą ir išveskite į consolę
//Console.WriteLine(" " + Console.ReadLine());

//Nuskaitykite iš klaviatūros savo vardo pirmąją raidę ir išveskite į konsolę jos ASCII kodą
//Console.WriteLine("suvestas ASCII" + (int)Console.ReadKey().KeyChar );

// Nuskaitykite iš klaviatūros savo vardo pirmąją raidę, tada nuskaitykite bet kokį skaičių ir išveskite į konsolę sumą. Pabandykite šį skaičių išvesti įvairiais formatais
//Console.WriteLine("įveskite savo vardo pirmąją raidę ir bet kokį skaičių");
//Console.WriteLine("rezultatas yra: {0}", (int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar-48);


//Console.WriteLine("{0} {1} {2}", "išvedimas", "vienoje", "eiluteje"); //kompozicija

//Parašykite programą kuri žodžio LABAS kiekvieną raidę išveda naujoje eilutėje.
//Console.WriteLine("L\nA\nB\nA\nS");//1 būdas

//2 būdas
//Console.WriteLine(@"L
//A
//B
//A
//S
//");

//3 būdas
//Console.WriteLine(L);
//Console.WriteLine(A);
//Console.WriteLine(B);
//Console.WriteLine(A);
//Console.WriteLine(S);

//Parašykite programą kuri žodžio LABAS kiekvieną raidę nutolusią per vieną tab
//Console.WriteLine("L    A   B   A   S"); //su tab
//Console.WriteLine("L\tA\tB\tA\tS");


//Padarykite konsolės meniu skirtingose eilutėse (1) Pirkti, (2) Parduoti, (3) Likučiai.Išveskite pasirinktą meniu punktą.
//Console.WriteLine("(1) Pirkti \n(2) Parduoti (3) Likučiai");
//Console.WriteLine("     \"pasirinkimas yra : {0} \" " (int)console.readkey().Keychar-48);

//Labas kabutėse dviem būdais
//Console.WriteLine("\"LABAS\" ");
///Console.WriteLine("\u0022LABAS\u0022 ");


//Parašykite programą kuri nuskaito jūsų vardą ir išveda antrą raidę
//Console.WriteLine("Įveskite savo vardą, o aš atspėsiu pirmą raidę:");
//Console.WriteLine("  " + Console.ReadLine()[1]);

//Parašykite programą kuri nuskaito jūsų vardą ir išveda raidžių kiekį
//Console.WriteLine("Parašykite programą kuri nuskaito jūsų vardą ir išveda raidžių kiekį");
//Console.WriteLine("     " + Console.ReadLine().Length);

//Parašykite programą kuri nuskaito jūsų vardą ir raidžių kiekį. Išveskite į ekraną tokiu principu:
//justinas
//8
//| justinas | 8 |

//Console.WriteLine("|  {0} |  {1} |", Console.ReadLine(), Console.ReadLine());

//Parašykite programą kuri nuskaito jūsų vardą ir jį išveda 3 eilutėm žemiau (naudoti new line)
//Console.WriteLine("\n\n\n{0}", Console.ReadLine());

//Nupieškite veiduką ir pakeičiam žvaigzdutes kabutėm.
Console.WriteLine(@"
        ********
    ****
   **()() * *
  ****
  ****".Replace("*", "\""));
  