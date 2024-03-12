using EMS.DataAccess.Data;
using EMS.DataAccess.Repository;
using EMS.DataAceess.Repository.IRepository;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAceess.Repository
{
    public class DistributionPointRepository : Repository<DistributionPoint>, IDistributionPointRepository
    {
        private readonly ApplicationDbContext _db;
        public DistributionPointRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(DistributionPoint distributionPoint)
        {
            _db.DistributionPoints.Update(distributionPoint);
        }
    }
}
