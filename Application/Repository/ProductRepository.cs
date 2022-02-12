using Core.Entity;
using Core.Repository;

namespace Application.Repository
{
    public class ProductRepository : Base.CrudService<Product>, IProductRepository
    {

    }
}
