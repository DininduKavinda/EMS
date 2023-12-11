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
    public class LeaveTypeRepository :Repository<LeaveType>, ILeaveTypeReository
    {
        private readonly ApplicationDbContext _db;
        public LeaveTypeRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }
        public  void Update (LeaveType leaveType)
        {
            _db.LeaveTypes.Update(leaveType);
        }
    }
}
