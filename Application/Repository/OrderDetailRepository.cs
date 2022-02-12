using Core.Entity;
using Core.Repository;

namespace Application.Repository
{
    public class OrderDetailRepository : Base.CrudService<OrderDetail>, IOrderDetailsRepository
    {
    }
}
