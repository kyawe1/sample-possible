using Application.Repository.Base;
using Core.Entity;
using Core.Repository;
using System;

namespace Application.Repository
{
    public class EmployeeRepository : CrudService<Employee>, IEmployeeRepository
    {
    }
}
