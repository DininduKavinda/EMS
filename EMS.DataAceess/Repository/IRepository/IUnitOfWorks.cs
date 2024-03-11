using EMS.DataAceess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccess.Repository.IRepository
{
    public interface IUnitOfWorks
    {
        IEmployeeRepository Employee { get; }
        IAttendanceRepository Attendance { get; }
        ISalaryTypeRepository SalaryType { get; }
        IJobTitleRepository JobTitle { get; }
        ILeaveRepository Leave { get; }
        ILeaveTypeReository LeaveType { get; }
        IDepartmentRepository Department { get; }
        IGenderRepository Gender { get; }
        IPayRollRepository PayRoll { get; }
        IBrandRepository Brand { get; }
        IProductRepository Product { get; }
        ISizeRepository Size { get; }
        IColorRepository Color { get; }
        IWhereHouseRepository WhereHouse { get; }
        ISalesExecutiveRepository SalesExecutive { get; }
        ICustomerRepository Customer { get; }
        ICityRepository City { get; }
        IOrderFormReository OrderForm {get;}
        IOrderFormProductRepository OrderFormProduct { get;}
        IStatusRepository Status { get; }
        IOutletRepository Outlet { get; }
        void Save();
    }
}
