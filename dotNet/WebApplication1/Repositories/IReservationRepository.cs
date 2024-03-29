﻿using ApiMokymai.Models;
using ApiMokymai.Repositories.IRepositories;
using System.Linq.Expressions;

namespace ApiMokymai.Repositories
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        public Reservation Update(Reservation book);
    }
}