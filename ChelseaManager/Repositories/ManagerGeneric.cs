using ChelseaManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChelseaManager.Repositories
{
    class ManagerGeneric<T> : IManagerGeneric<T> where T : class
    {
        /// <summary>
        /// context bazy danych - połączenie z nią
        /// </summary>
        private readonly ChelseaManagerContext _context;


        public ManagerGeneric()
        {
            _context = new ChelseaManagerContext();
        }



        /// <summary>
        /// dodanie nowego rekordu
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        /// <summary>
        /// usunienicie po id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(int id)
        {
            T entities = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entities);
        }

        /// <summary>
        /// pobranie query z bazy
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsQueryable();
        }

        /// <summary>
        /// pobranie wszystkich danych z tabeli do listy
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        /// <summary>
        /// pobranie obiektu z bazy po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        /// <summary>
        /// zapisanie dokonanych zmian
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }



    }
}
