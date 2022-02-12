using Core.Entity;
using Core.Repository;

namespace Application.Repository
{
    public class PaymentRepository : Base.CrudService<Payment>, IPaymentRepository
    {
    }
}
