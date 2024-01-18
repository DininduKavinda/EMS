using EMS.DataAccess.Data;
using EMS.DataAccess.Repository.IRepository;
using EMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
            //_db.Categories == dbSet;
            _db.Employees.Include(u => u.JobTitle).Include(u=>u.Department).Include(u => u.Gender).Include(u =>u.JobTitle.SalaryType);
            _db.Attendances.Include(u => u.Employee);
            _db.Leaves.Include(u => u.Employee).Include(u => u.LeaveType);
            _db.JobTitles.Include(u => u.SalaryType);
            _db.PayRolls.Include(u => u.Employee).Include(u => u.Employee.JobTitle).Include(u => u.Employee.Department).Include(u => u.Employee.Gender).Include(u => u.Employee.JobTitle.SalaryType);
            _db.Products.Include(u => u.Brand).Include(u => u.Color).Include(u => u.Size);
        }
        public void Add(T entity)
        {

            dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, string? includeProperties =null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter).AsQueryable();
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
