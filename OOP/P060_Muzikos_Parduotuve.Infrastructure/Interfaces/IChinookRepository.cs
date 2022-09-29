using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzikos_Parduotuve.Infrastructure.Interfaces
{
    public interface IChinookRepository
    {
        void MainMenu();
        void LogIn();
        void AddUser(string firstName, string lastName, string? company, string? 
            adress, string? city, string? state, string? country, 
            string? postalCode, string? phone, string? fax, string email);
        void EmployeeLogin();
        void RegistrationForm();
        void BuyMenu();
        void ShowCatalog();
        void SortBy();
        void SearchBy();
       
    }
}
