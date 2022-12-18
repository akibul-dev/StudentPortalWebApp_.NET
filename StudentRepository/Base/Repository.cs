using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StudentPortal.Database.Databases;
using StudentPortal.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository.Base
{
    public class Repository<T> where T : class 
    {
        StudentPortalDBcontext _db;

        public Repository(StudentPortalDBcontext db)
        {
            _db = db;  
        }

        public DbSet<T> Table {
            get {
                return _db.Set<T>();
            
            }}

        public bool Add(T entity)
        {
            Table.Add(entity);
            bool res= _db.SaveChanges() > 0;
            return res;
        }
        public bool Update(T entity)
        {
            Table.Update(entity);
            return _db.SaveChanges() > 0;
        }

        public bool Remove(T entity)
        {
            Table.Remove(entity);
            return _db.SaveChanges()>0;
        }

        

        public ICollection<T> GetAll()
    {
           return Table.ToList();
            
    }
        
        //public ICollection<T> Get (Expression <Func<T , bool>> predicate)
        //{
        //    return Table.Where(predicate).ToList();
        //}

        public T GetById(Expression<Func<T,bool>> predicate)
        {
            return Table.FirstOrDefault(predicate);
        }
    }
}
