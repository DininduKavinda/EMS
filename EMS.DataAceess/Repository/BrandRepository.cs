using EMS.DataAccess.Data;
using EMS.DataAccess.Repository.IRepository;
using EMS.DataAccess.Repository;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.DataAceess.Repository.IRepository;

namespace EMS.DataAceess.Repository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        
            private readonly ApplicationDbContext _db;
            public BrandRepository(ApplicationDbContext db) : base(db)
            {
                _db = db;
            }
            public void Update(Brand brand)
            {   
                _db.Brands.Update(brand);
            }
        
    }
}
