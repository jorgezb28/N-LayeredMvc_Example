using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Store
    {
        public int  StoreId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual  ICollection<Employee> Employees{ get; set; }
    }
}
