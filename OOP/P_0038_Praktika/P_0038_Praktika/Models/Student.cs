using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_0038_Praktika.Models
{
    public class Student : UniversityPerson
    {
        public List<Profession> Coureses { get; set; }
        public override Profession Profesija
        {
            get => Profesija;
            set
            {
                List<string> invalidProffesions = new List<string> { "Lecturer", "Teacher", "Scientist" };
                if (invalidProffesions.Contains(value.Text))
                {
                    throw new Exception();
                }
                else
                {
                    Profesija = value;
                }

            }
        }



        }
    }