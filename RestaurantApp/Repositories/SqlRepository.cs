using Microsoft.EntityFrameworkCore;
using RestaurantApp.Entities;

namespace RestaurantApp.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
    {

        //DbContext corresponds to your database (or a collection of tables and views in your database)
        //whereas a DbSet corresponds to a table or view in your database 

        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }
        
        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }
        
        
        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
