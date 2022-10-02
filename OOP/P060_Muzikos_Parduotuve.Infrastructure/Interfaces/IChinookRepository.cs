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
        List<Customer> CustomerList();
        void AddUser(string firstName, string lastName, string? company, string? 
            adress, string? city, string? state, string? country, 
            string? postalCode, string? phone, string? fax, string email);
        List<Employee> EmployeesList();


        List<Track> ShowCatalogForAdmin();
        List<Track> SongList();


       
        void AddToBasket(int customerId, List<int> trackIds);

        void AddInvoice(Invoice invoice);
        List<Track> SortSongs();
        List<Track> TracksByNameDecending();
        List<Track> TracksByComposer();
        List<Track> TracksByGenre();
        List<Track> TracksByComposerAndAlbum();
        Track GetSongById(long songId);
        List<Track> SearchBySongName(string songName);
        List<Track> SearchByComposer(string composer);
        List<Track> SearchByGenre(string genre);
        List<Track> SearchSongsByComposerAndAlbum(string composer, string album);
        List<Track> SearchSongsByLength(int length, int choice);
        List<Track> SearchSongsByAlbumId(int albumId);
        List<Track> SearchBySongAlbumName(string albumName);
        void UpdateSongStatus(long id, string status);
        List<Invoice> GetCustomerInvoices(int customerId);
        List<Invoice> TotalIncome();
        List<Invoice> TotalIncomeByYear(string date);
        void TotalGenreSold();





    }
}
