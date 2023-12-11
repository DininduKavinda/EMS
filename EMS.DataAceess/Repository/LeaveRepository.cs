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
    public class LeaveRepository :Repository<Leave>, ILeaveRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }
        public void Update (Leave leave)
        {
            _db.Leaves.Update(leave);
        }
    }
}
