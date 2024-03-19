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
    public class VehicleInsuranceRepository : Repository<VehicleInsurance> , IVehicleInsuranceRepository
    {
        public readonly ApplicationDbContext _db;
        public VehicleInsuranceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(VehicleInsurance vehicleInsurance)
        {
            _db.VehicleInsurances.Update(vehicleInsurance);
        }
    }
}
