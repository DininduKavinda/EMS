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
    public class ColorRepository : Repository<Color>, IColorRepository
    {
        private readonly ApplicationDbContext _db;
        public ColorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Color color)
        {
            _db.Colors.Update(color);
        }
    }
}
