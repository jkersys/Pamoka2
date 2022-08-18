using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    /*Sukurkite klasę Society
         1- Sukurkite propertį People (List of persons) 
         2- sukurkite metodą FillPeople kuris užpildys sąrašą iš klasės PersonInitialData.
         3- Sukurkite propertį OldPeople. Grąžinkite visus asmenis kurie gimė prieš 2001m. (unit-test)
         4- Sukurkite properčius Men ir Women. 
         5- Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris (unit-test) 
         6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašus esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio.
         7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A. 
            Pagal Vardą arba Pavardę
              tokiu principu: SortByFirstName().Asc()
                              SortByLastName().Asc()
                              SortByLastName().Desc()
            <hint> return this*/



    internal class Society
    {



        public List<Person> Men { get; set; }
        public List<Person> Women { get; set; }
        public List<Person> People { get; set; } = new List<Person>();
        public List<Person> Oldpeople
        {
            get
            {
                List<Person> oldPeople = new List<Person>();
                foreach (Person person in People)
                {
                    if (person.BirthDate < new DateTime(2001, 01, 01))
                        oldPeople.Add(person);
                }
                return oldPeople;
            }

        }









        public void FillPeople()
        {
            foreach (var person in PersonInitialData.DataSeed)
            {
                People.Add(person);
            }
        }

        public void FillMen(List<Person> men)
        {
            Men = new List<Person>();

        }


    }
}

