using GroceryDal.Model;

namespace GroceryDal.DAL
{
    public interface IGroceryRepository
    {
        GroceryItem GetItem(int id);

        IEnumerable<GroceryItem> GetItems();

        void AddItem(GroceryItem item);

        void UpdateItem(GroceryItem item);

        void RemoveItem(GroceryItem item);

        void SaveChanges();
    }
}
