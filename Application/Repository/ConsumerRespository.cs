using Core.Entity;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class ConsumerRespository: Base.CrudService<Consumer>,IConsumerRepository
    {
    }
}
