using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbyBlog.DataAccess.Repository.Interface
{
    public interface IDatastore<T> where  T: class
    {
        IQueryable<T> GetAll();
        T GetById(Guid id);
        void Update(T entity);
        T Post(T entity);
        void Delete(T entity);

    }
}
