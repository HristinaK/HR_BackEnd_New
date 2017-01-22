using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Leave
    {
        public virtual Guid LeaveId { get; set; }
        public virtual Employee EmployeeLeave { get; set; }
        public virtual DateTime from { get; set; } 
        public virtual DateTime to { get; set; }
        public virtual int tottalDays { get; set; }
        public virtual string type { get; set; }
        public virtual string comment { get; set; }
        public virtual string status { get; set; }
           

    }
}
