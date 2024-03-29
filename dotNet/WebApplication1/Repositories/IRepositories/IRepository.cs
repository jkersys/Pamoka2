﻿using System.Linq.Expressions;

namespace ApiMokymai.Repositories.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // CRuD

        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);

        TEntity Get(Expression<Func<TEntity, bool>> filter, bool tracked = true);

        TEntity Create(TEntity entity);

        void Remove(TEntity entity);

        void Save();
    }
}
