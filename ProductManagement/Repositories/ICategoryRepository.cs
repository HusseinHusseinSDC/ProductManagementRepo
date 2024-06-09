using ProductManagement.Models;

namespace ProductManagement.Repositories
{
    public interface ICategoryRepository
    {
        Product GetById(int id);
        IEnumerable<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}