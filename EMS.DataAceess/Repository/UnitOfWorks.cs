using EMS.DataAccess.Data;
using EMS.DataAccess.Repository.IRepository;
using EMS.DataAceess.Repository;
using EMS.DataAceess.Repository.IRepository;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
        public IBrandRepository Brand { get; private set; }
        public IProductRepository Product { get; private set; }
        public ISizeRepository Size { get; private set; }
        public IColorRepository Color { get; private set; }
        public IWhereHouseRepository WhereHouse { get; private set; }
        public ISalesExecutiveRepository SalesExecutive { get; private set; }
        public ICustomerRepository Customer { get; private set; }
        public ICityRepository City {  get; private set; }
        public IOrderFormReository OrderForm { get; private set; }
        public IOrderFormProductRepository OrderFormProduct { get; private set; }
        public IStatusRepository Status { get; private set; }
        public IOutletRepository Outlet { get; private set; }
        public IVehicleRepository Vehicle { get; private set; }
        public IVehicleTypeRepository VehicleType { get; private set; }
        public IDistributionPointRepository DistributionPoint { get; private set; }
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
            Product = new ProductRepository(_db);
            WhereHouse = new WhereHouseRepository(_db);
            Color = new ColorRepository(_db);
            Size = new SizeRepository(_db);
            Brand = new BrandRepository(_db);
            SalesExecutive = new SalesExecutiveRepository(_db);
            Customer = new CustomerRepository(_db);
            City = new CityRepository(_db);
            OrderForm = new OrderFormRepository(_db);
            OrderFormProduct = new OrderFormProductRepository(_db);
            Status = new StatusRepository(_db);
            Outlet = new OutletRepository(_db);
            Vehicle = new VehicleRepository(_db);
            VehicleType = new VehicleTypeRepository(_db);
            DistributionPoint = new DistributionPointRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
