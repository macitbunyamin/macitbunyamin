using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortFolio.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext db;
        public UnitOfWork(ApplicationDbContext db) {
            this.db = db;
        }
        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
