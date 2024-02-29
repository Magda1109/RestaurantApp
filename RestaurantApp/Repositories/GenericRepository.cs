using RestaurantApp.Entities;

namespace RestaurantApp.Repositories
{
    public class GenericRepository<TEntity, TKey> 
        where TEntity : IEntity //przyjmuje jako T tylko te klasy, które implementują interfejs IEntity
    {
        public TKey Key { get; set; }
        protected readonly List<TEntity> _items = new();
        public void Add(TEntity item)
        {
            //_items.Id = _items.Count + 1;
            _items.Add(item);

        }

        public TEntity GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }     
    }
}
