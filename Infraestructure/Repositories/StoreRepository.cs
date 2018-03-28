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
    public class StoreRepository:Repository<Store>, IStoreRepository
    {
        public StoreRepository(StoreContext context) : base(context)
        {
        }

        public StoreContext StoreContext
        {
            get { return Context as StoreContext; }
        }
    }
}
