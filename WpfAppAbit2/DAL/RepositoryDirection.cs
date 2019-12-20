using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    public interface IRepositoryDirection : IRepository<Direction>
    {
        ObservableCollection<Direction> GetAll();
        Direction Get(Direction item);
    }
    public class RepositoryDirection : IRepositoryDirection
    {
        public LocalStorage db;

        public RepositoryDirection(LocalStorage db)
        {
            this.db = db;
        }
        public ObservableCollection<Direction> GetAll()
        {
            //   db.FillDepartments();
            return db.Directions;
        }

        public Direction Get(Direction item)
        {
            throw new System.NotImplementedException();
        }
        public void Create(Direction item)
        {
            db.Directions.Add(item);
        }
        public void Update(Direction item, Direction item_prev)
        {
            db.Directions[db.Directions.IndexOf(item_prev)] = item;
        }
        public void Delete(Direction item)
        {
            db.Directions.Remove(item);
        }
    }
}
