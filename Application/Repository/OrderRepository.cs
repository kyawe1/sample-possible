using Core.Entity;
using Core.Repository;

namespace Application.Repository
{
    public class OrderRepository : Base.CrudService<Order>, IOrderRepository
    {
    }
}
