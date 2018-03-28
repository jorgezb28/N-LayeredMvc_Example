using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Generic;

namespace Infraestructure.Repositories
{
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(StoreContext context) : base(context)
        {
        }

        public StoreContext StoreContext
        {
            get { return Context as StoreContext; }
        }
    }
}
