using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P052_CodeFirstSqliteDbDomain.Models
{
    //CodeFirst approche - Klase yra lentele
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName, DateTime? birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
        }

        //PrimaryKey - Pirminis raktas
        //Pirminis raktas yra visda unikalus
        //Reliacines duombazes (Relationships between tables)
        [Key] //sakome kad PersonId butu pirminis raktas musu duombazese
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int Age { get; set;}
        public DateTime? BirthDay { get; set; }
        public string? Email { get; set; }
        public double? Heigh { get; set; }
        public double Weigh { get; set; } = 0;
        public string? Biografy { get; set; }
        
    }
}
