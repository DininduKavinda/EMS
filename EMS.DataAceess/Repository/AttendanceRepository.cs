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
    public class AttendanceRepository : Repository<Attendance>, IAttendanceRepository
    {
        private readonly ApplicationDbContext _db;
        public AttendanceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Attendance attendance)
        {
            _db.Attendances.Update(attendance);
        }
    }
}
