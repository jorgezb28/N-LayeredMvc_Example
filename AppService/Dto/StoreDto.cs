using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Dto
{
    public class StoreDto
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<EmployeeDto> Employees { get; set; }
    }
}
