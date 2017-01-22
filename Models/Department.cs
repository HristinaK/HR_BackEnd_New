using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Department
    {
        public virtual Guid DepartmentId { get; set; }
        public virtual string Name { get; set; }

    }
}
