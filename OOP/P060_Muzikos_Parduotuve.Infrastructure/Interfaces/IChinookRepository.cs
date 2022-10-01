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
        void LogIn();
        void AddUser(string firstName, string lastName, string? company, string? 
            adress, string? city, string? state, string? country, 
            string? postalCode, string? phone, string? fax, string email);
        void EmployeeLogin();
        
       
        List<Track> ShowCatalog();
       
        void SearchBy();
        void AddToBasket(int customerId, List<int> trackIds);
               
        List<Track> SortSongs();
        List<Track> TracksByNameDecending();
        List<Track> TracksByComposer();
        List<Track> TracksByGenre();
        List<Track> TracksByComposerAndAlbum();
        List<Track> SearchSongsById(int songId);
        List<Track> SearchBySongName(string songName);
        List<Track> SearchByComposer(string composer);
        List<Track> SearchByGenre(string genre);
        List<Track> SearchSongsByComposerAndAlbum(string composer, string album);
        List<Track> SearchSongsByLength(int length, int choice);
        List<Track> SongsByAlbumName(string albumName);



    }
}
