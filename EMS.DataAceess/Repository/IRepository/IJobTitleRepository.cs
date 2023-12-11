using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccess.Repository.IRepository
{
    public interface IJobTitleRepository :IRepository<JobTitle>
    {
        void Update(JobTitle jobTitle);
    }
}
