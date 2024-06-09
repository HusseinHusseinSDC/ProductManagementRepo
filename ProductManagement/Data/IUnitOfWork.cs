using ProductManagement.Repositories;

namespace ProductManagement.Data
{
    public interface IUnitOfWork
    {

        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        void Complete();

    }
}
