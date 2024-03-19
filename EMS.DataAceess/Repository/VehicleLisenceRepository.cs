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
    public class VehicleLisenceRepository : Repository<VehicleLicense> , IVehicleLisenceRepository
    {
        public readonly ApplicationDbContext _db;
        public VehicleLisenceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(VehicleLicense vehicleLisence)
        {
            _db.VehicleLicenses.Update(vehicleLisence);
        }
    }
}
