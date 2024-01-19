using EMS.DataAccess.Data;
using EMS.DataAccess.Repository;
using EMS.DataAceess.Repository.IRepository;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAceess.Repository
{
    public class SalesExecutiveRepository : Repository<SalesExecutive> , ISalesExecutiveRepository
    {
        private readonly ApplicationDbContext _db;
        public SalesExecutiveRepository(ApplicationDbContext db) : base (db)
        {
            _db = db;
        }
        public void Update(SalesExecutive salesExecutive)
        {
            _db.SalesExecutives.Update(salesExecutive);
        }
    }
}
