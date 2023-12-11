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
    public class JobTitleRepository : Repository<JobTitle>, IJobTitleRepository
    {
        private readonly ApplicationDbContext _db;
        public JobTitleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(JobTitle jobTitle)
        {
            _db.JobTitles.Update(jobTitle);
        }
    }
}
