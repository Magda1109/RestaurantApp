using RestaurantApp.Entities;

namespace RestaurantApp.Repositories
{
    public class ListRepository<T> : IRepository<T>
        where T : class, //class- T has to be a class, cannot be a value type
        IEntity, //przyjmuje jako T tylko te klasy, które implementują interfejs IEntity
        new() //klasa ma mieć bezparametrowy konstruktor
    {
        private readonly List<T> _items = new();

        public IEnumerable<T> GetAll()
        {
            return _items.ToList(); //dzięki temu, że mamy ToList, zostanie stworzony nowy obiekt i będziemy na nim operować (czyli na kopii), a nie na oryginalnej liscie
        }
        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);

        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            //Save is not required with lists
        }

    }
}
