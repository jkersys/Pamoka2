using ApiMokymai.Data;
using ApiMokymai.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiMokymai.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(BookContext db) : base(db)
        {
        }

        public override Reservation Create(Reservation entity)
        {            
            return base.Create(entity);
        }

        public Reservation Update(Reservation reservatedBook)
        {
            _db.Reservations.Update(reservatedBook);
            _db.SaveChanges();
            return reservatedBook;
        }
    }
}
