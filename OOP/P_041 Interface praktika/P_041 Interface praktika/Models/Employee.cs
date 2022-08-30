using P_041_Interface_praktika.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_041_Interface_praktika.Models
{
    internal class Employee : Person, IPayable
    {
        public Employee()
        {

        }
        public Employee(double salary, string mailingAdress)
        {
            Salary = salary;
            MailingAdress = mailingAdress;
        }

        public double Salary { get; set; }
        public string MailingAdress { get; set; }

        public double DabartineAlga()
        {
            return Salary;
        }

        public void PadidintiAlga(double money)
        {
            double risedSalary = Salary + money;
            Console.WriteLine($"Salary was increased from {Salary} to {risedSalary}");
        }

        public string UzmokescioAdresas()
        {
            return MailingAdress;
        }
    }
}
