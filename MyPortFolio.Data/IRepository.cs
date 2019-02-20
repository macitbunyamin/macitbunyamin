﻿using MyPortFolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPortFolio.Data
{
    public interface IRepository<T> where T:BaseEntity
    {//yo
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Find(Guid id);
        T Find(Expression<Func<T,bool>>where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where);

    }
}
