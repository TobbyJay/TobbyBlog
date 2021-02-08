using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TobbyBlog.Data;
using TobbyBlog.DataAccess.Repository.Interface;

namespace TobbyBlog.DataAccess.Repository.Implementation
{
    public class DataStore<T> : IDatastore<T> where T : class
    {
        private readonly TobbyBlogDbContext _context;
        public DbSet<T> _entities;
        public DataStore(TobbyBlogDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();

        }


        public void Delete(T entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();

        }

        public IQueryable<T> GetAll()
        {
            return _entities;
        }

        public T GetById(Guid id)
        {
            if (id == null) throw new NotImplementedException();
            return _entities.Find(id);
        }

        public T Post(T entity)
        {
            if (entity == null) throw new NotImplementedException();
            _entities.Add(entity);
            _context.SaveChanges();
            return entity;

        }

        public void Update(T entity)
        {
            if (_entities == null) throw new ArgumentNullException();
            _entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
