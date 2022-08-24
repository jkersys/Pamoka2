using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_0038_Praktika.Models
{
    public class UniversityPerson : Person
    {
        public virtual Profession Profesija { get; set; }
        public List<Hobby> Hobbies { get; set; }

        private Random _rnd;

        public UniversityPerson()
        {
            _rnd = new Random();
        }

        public UniversityPerson(Random rnd)
        {
            _rnd = rnd;
        }

        public void SetHobbies(string[] data)
        {
            Hobbies = new List<Hobby>();
            List<int> indexesTaken = new List<int>(); // masyvas saugantos kokie hobiu indeksai jau buvo paimti
            //sugeneruoti skaiciu nuo 0 iki 4 - hobiu kieki
            int hobbiesCount = _rnd.Next(0, 5);
            for (int i = 0; i < hobbiesCount; i++)
            {
                //todo mechanizmas kuris tikrina, ar naujai sugeneruotas hobby indeksas dar nera irasytas i indexIsTaken,
                //jeigu jau yra sugeneruoti kita hobbyIndex
              
                    int hobbyIndex;
                    do
                    {
                        hobbyIndex = _rnd.Next(0, data.Length);
                    }
                    while (indexesTaken.Contains(hobbyIndex));
                indexesTaken.Add(hobbyIndex);
                }

                FillHobbies(data, indexesTaken);
            
        }

        private void FillHobbies(string[] data, List<int> indexesTaken)
        {
            foreach (var index in indexesTaken)
            {
                Hobby h = new Hobby();
                h.EncodeCsv(data[index]);
                Hobbies.Add(h);
            }
        }

        public void setProffesion(Profession[] data)
        {
            int randomProfesion = _rnd.Next(0, data.Length);
            Profesija = data[randomProfesion];
            
        }
            //toks netinka sprendimas?
            //for (int i = 0; i < data.Length; i++)
            //{
            //  if (randomProfesion == data.Length)
            //    {
            //        Profesija = data[i];
            //    }
                    
            //}

            //}

        public void setProffesion(string[] data)
        {
            int profesionIndex = _rnd.Next(0, data.Length);
            Profession profession = new();
            profession.EncodeCsv(data[profesionIndex].Replace(";", ","));
            Profesija = profession;
        }

        public string GetCsv()
        {
                return $"{Id},{FirstName},{LastName},{Gender},{BirthDate},{Weight},{Height},{Profesija.Id}," +
                $"{(Hobbies.Count > 0 ? Hobbies[0].Id : "")}" +
                $"{(Hobbies.Count > 1 ? Hobbies[0].Id : "")}" +
                $"{(Hobbies.Count > 2 ? Hobbies[0].Id : "")}" +
                $"{(Hobbies.Count > 3 ? Hobbies[0].Id : "")}";
        }


    }
    }

