using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Generic;
using Infraestructure.Repositories;

namespace Infraestructure
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly StoreContext _storeContext;
        public UnitOfWork()
        {
            _storeContext = new StoreContext();
            EmployeeRepository = new EmployeeRepository(_storeContext);
            StoreRepository = new StoreRepository(_storeContext);
        }
        public void Dispose()
        {
            _storeContext.Dispose();
        }

        public IStoreRepository StoreRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public void Commit()
        {
            _storeContext.SaveChanges();
        }
    }
}
