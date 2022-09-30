using Muzikos_Parduotuve.Domain.Models;
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
        List<Track> ShowCatalog();
        void SortBy();
        void SearchBy();
        void AddToBasket();
        List<Track> SongsById();
        List<Track> SongsByName();
        List<Track> SongsByAlbumId();
        List<Track> SongsByAlbumName();


    }
}
