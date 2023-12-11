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
    public class GenderRepository :Repository<Gender>, IGenderRepository
    {
        private readonly ApplicationDbContext _db;
        public GenderRepository (ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(Gender gender)
        {
            _db.Genders.Update(gender);
        }
    }
}
