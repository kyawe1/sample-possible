using Application.Repository.Base;
using Core.Entity;
using Core.Repository;

namespace Application.Repository
{
    public class InventoryControlRepository : CrudService<InventoryControl>, IInventoryControlRepository
    {
    }
}
