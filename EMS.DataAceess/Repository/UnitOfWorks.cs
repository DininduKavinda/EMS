using EMS.DataAccess.Data;
using EMS.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccess.Repository
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly ApplicationDbContext _db;
        public IEmployeeRepository Employee { get; private set; }
        public IAttendanceRepository Attendance { get; private set; }
        public ISalaryTypeRepository SalaryType { get; private set; }
        public IJobTitleRepository JobTitle { get; private set; }
        public ILeaveRepository Leave { get; private set; }
        public ILeaveTypeReository LeaveType { get; private set; }
        public IDepartmentRepository Department { get; private set; }
        public IGenderRepository Gender { get; private set; }
        public IPayRollRepository PayRoll { get; private set; }
        public UnitOfWorks(ApplicationDbContext db)
        {
            _db = db;
            Employee = new EmployeeRepository(_db);
            Attendance = new AttendanceRepository(_db);
            SalaryType = new SalaryTypeRepository(_db);
            JobTitle = new JobTitleRepository(_db);
            Leave = new LeaveRepository(_db);
            LeaveType = new LeaveTypeRepository(_db);
            Department = new DepartmentRepository(_db);
            Gender = new GenderRepository(_db);
            PayRoll = new PayRollRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
