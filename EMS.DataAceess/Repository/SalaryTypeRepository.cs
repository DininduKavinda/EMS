using EMS.DataAccess.Data;
using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccess.Repository
{
    public class SalaryTypeRepository :Repository<SalaryType>, ISalaryTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public SalaryTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(SalaryType salaryType)
        {
            _db.SalaryTypes.Update(salaryType);
        }
    }
}
