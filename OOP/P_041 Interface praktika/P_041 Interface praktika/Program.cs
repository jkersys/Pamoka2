using P_041_Interface_praktika.Interface;
using P_041_Interface_praktika.Models;

namespace P_041_Interface_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IHobby hooby = new Movie(1, 2005, "KazkoksFilmas", "Sony", "Drama", 5);

            Person person = new Person(1, "vardenis", "pavardenis");
            person.Interact(hooby);
            Console.WriteLine("Hello, World!");

            /*1: Sukurkite klasę Skaicius . Savyje turi tik readonly kintamąjį kuriame saugoma reikšmė sveikasis skaičius.
            - Sukurkite interfeisą IMatematika . 
            - Interfeise aprašykite metodus: (Pridėti, Atimti, Padauginti, Padalinti --> metodams bus paduodamas sveikasis skaičius ir bus grąžinama reikšmė),
            - PakeltiKvadratu , PakeltiKubu --> metodai grąžina reikšmes.
            - Klasė Skaicius paveldi interfeisą . 
            - Implementuokite paveldėtus metodus.
            Irodyti veikima parasant testus kiekvienam metodui.*/


            Skaicius skaicius = new Skaicius(5);
            skaicius.Prideti(5);
            skaicius.SpausdintiSkaiciu();

            /*Uzduotis 2. - Sukurti klasę Figura , kuri saugo pavadinimą readonly propertyje- 
             * Sukurti interfeisą IGeometrija , kurioje aprašyti du metodai Plotas ir Perimetras. Abu grąžina double reikšmes.- 
             * Sukurti klases: Kvadratas, Staciakampis , Statusis Trikampis ir Apskritimas (klasėse susikurti reikiamus properčius fieldus visi jie turi būti readonly ). - 
             * Kiekviena klasė paveldi klasę Figura ir interfeisą IGeometrija.- 
             * Realizuoti klases.Irodyti veikima parasant testus kiekvienam metodui.*/

            Kvadratas kvadratas = new Kvadratas(5);

            /*Uzduotis 3: Sukurkite interface <IPayable>. Sis interface bus naudojamas apskaitos departamento sistemose rasant israsus. <IPayable> turetu tureti sias tris kontrakto funkcines dalis:        
             * 1.    Isgauti dabartine alga        
             * 2.    Padidinti esama alga        
             * 3.    Isgauti uzmokescio adresa (Fizinis siunciamas laisku)
             Sukurkite klase <Employee> ir paveldekite ja <Person> klaseje (Snippet pasiimkit is apacios)        
            internal class SD_Person
             {                
             public int Id { get; set; }                
             public string Name { get; set; }                
             public string LastName { get; set; }            
             }
            <Employee> turetu tureti siuos properties:        
            1.    Salary        2.    Mailing address        
            <Employee> turetu paveldeti is <IPayable> interface. 
            Kiekviena kontrakto dali uzpildykite logiskais sprendimais pvz: Mailing address funkcionalumas greiciausiai turetu grazinti zmogaus esama registruota adresa.        
            Irodyti veikima parasant testus kiekvienam metodui.
         */

            /*Uzduotis 4
             * Sukurti <Movie> klase (Id, CreationDate) +
             * Sukurti <Music> klase (Id, Length, ArtistName) +
             * Sukurti <Game> klase (Id, Platform, IsMultiplayer)   +
             * Sukurti <IHobby> interface ir visoms sukurtoms klasems sukurti interface implementacijas:    +
             * String Name get +
             * String Publisher get +
             * String Genre get +
             * Int Rating get +
             * String GetHobbyName() -> Turetu grazinti atgal ar tai filmas, daina ar zaidimasString +
             * GetHobbyInformation() -> Turetu grazinti atgal informacija apie pati hobi pvz, kad tai filmas kazkokio zanro, kurio ivertinimas yra X/Y +
             * Sukurti <Person> klase, kuri turetu savyje laikyti sarasa megstamiausiu dalyku. +
             * Turetume galeti programos eigoje prideti i ta pati sarasa bet koki Hobby t.y Movie, Music, Game +
             * Sukurti <IPerson>Void Interact(<IHobby>) -> Turetu atspausdinti i ekrana informacija apie tai kas ivyksta kada vartotojas nusprendzia uzsiimti paduota veikla. +
             * Pvz jei buna paduodamas filmas i ekrana turetu isvesti “<UserName> will now watch a <MovieName> which is a <Genre> movie.string +
             * GetFavoriteHobbyType() -> Turetu gauti hobio tipa (pvz Movie). Atspausdinti apie tai informacija I ekrana ir grazinti atgal hobio pavadinimaIHobby 
             * GetFavoriteHobby() -> Turetu grazinti megstamiausios rusies hobio auksciausia ivertinima turincio iraso informacijaList<IHobby> 
             * GetFavoriteFromEachHobby() -> Turetu grazinti auksciausio ivertinimo irasa is kiekvienos rusies hobioString 
             * GetFavoriteMusicGenre() -> Turetu grazinti megstamiausia dazniausiai pasikartojanti muzikos zanra zmogaus hobiuoseDictionary<string, int> 
             * GetEachHobbyAvgRating() -> Grazina dictionary su irasais kuriuose key yra hobio tipas pvz filmas, o value yra vidurkisVoid 
             * ShareHobbies(<Person>) -> Pasidalina hobiais su paduotu zmogumi ir tie hobiai prisideda prie perduoto zmogaus hobiuVoid 
             * ShareOldMovies(<Person>) -> Pasildaina filmais, kurie atsirado veliau nei 2010 metaiList<IHobby> 
             * FindSimilarHobbies(<Person>) -> Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiaisList<IHobby> 
             * FindSimilarHobbies(<Person>, string hobbyType) -> Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais ir yra tik tarp perduoto hobbyType pvz filmuList<string> 
             * FindMatchingGenres(<Person>, string hobbyType) -> Randa sutampancius zanrus su paduoto zmogaus, kurie butu paduoto hobby tipoPrie <Person> pridekite nauja sarasa List<IHobby> 
             * CheckoutListSukurkite nauja <Person> metoda void AddRandomToCheckList(<Person>), kuris prideda nauja(Nesikartojanti) hobby is kito zmogaus atsitiktine tvarka, Visus metodus istestuoskite*/
            


        }
    }
}
