using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generic
{
    public interface IUnitOfWork:IDisposable
    {
         IStoreRepository StoreRepository { get; set; }
         IEmployeeRepository EmployeeRepository { get; set; }
        void Commit();
    }
}
