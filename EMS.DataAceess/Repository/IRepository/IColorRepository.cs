using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAceess.Repository.IRepository
{
    public interface IColorRepository : IRepository<Color>
    {
        void Update(Color color);
    }
}
