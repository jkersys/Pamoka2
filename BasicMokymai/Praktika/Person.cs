﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{


    /*Sukurkite klasę Person su properčiais:
          - Id(int), 
          - FirstName(string), 
          - LastName(string), 
          - FullName(readonly string - generuojamas iš FirstName ir LastName)
          - Gender(int - užpildomas tik inicializuojant klasę reikšme arba per metodą iš enumo EGenderType )
          - BirthDate (DateTime - gali būtu null)
          - Height (Decimal)
          - Weight (Decimal)
          - Age (readonly int - gali būti null. Generuojamas iš gimimo datos (BirthDate). Generavimui naudoti metodą) 
          - NameChanges (string - įrašomas tik iš vidaus. Pildomas pakeitus FirstName arba LastName. 
            Saugomi visi pakeitimai csv formatu "senas,naujas" )
    */



    public class Person
    {
        private string _firstName;
        private string _lastName;

        public Person()
        {

        }

        public Person(EGenderType gender)
        {
            Gender = gender;
        }

        public int Id { get; set; }
        public string FirstName
        {
            get => _firstName;
            set
            {
                //if(!string.IsNullOrWhiteSpace)
                NameChange += $"{_firstName} => {value}";
                _firstName = value;
            }
        }
        public string LastName 
        {
            get => _lastName;
            set
            {
                NameChange += $"{_lastName} => {value}";
                _lastName = value;
            }
        
    }
        public string FullName => $"{FirstName} {LastName}";
        public EGenderType Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int? Age => GetAge();


        public string NameChange { get; private set; }








        public void ChangeGender(EGenderType gender)
        {
            Gender = gender;
        }

        private int? GetAge()
        {
            if (BirthDate == null)
                return null;

            var ts = DateTime.Now.Subtract((DateTime)BirthDate);
            return new DateTime(ts.Ticks).Year - 1;
        }








    }





}
