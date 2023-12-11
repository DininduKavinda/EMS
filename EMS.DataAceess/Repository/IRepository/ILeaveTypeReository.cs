using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccess.Repository.IRepository
{
    public interface ILeaveTypeReository : IRepository<LeaveType>
    {
        void Update(LeaveType leaveType);
    }
}
