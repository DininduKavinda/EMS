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
    public class PayRollRepository: Repository<PayRoll>, IPayRollRepository
    {
        private readonly ApplicationDbContext _db;
        public PayRollRepository (ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(PayRoll payroll)
        {
            _db.PayRolls.Update(payroll);
        }
    }
}
