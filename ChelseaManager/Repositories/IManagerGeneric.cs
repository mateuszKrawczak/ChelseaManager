using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChelseaManager.Repositories
{
    interface IManagerGeneric<T> where T : class
    {
        List<T> GetAll();
        IQueryable<T> Get();

        T GetByID(int id);

        void DeleteById(int id);
        void Update(T entity);
        void Create(T entity);
        void Save();
    }
}
