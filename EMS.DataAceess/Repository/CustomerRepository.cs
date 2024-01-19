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
    public class CustomerRepository : Repository<Customer> , ICustomerRepository
    {
        private readonly ApplicationDbContext _db;
        public CustomerRepository (ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Customer customer)
        {
            _db.Customers.Update(customer);
        }
    }
}
