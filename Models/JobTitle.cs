using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class JobTitle
    {
        public virtual Guid JobTitleId { get; set; }
        public virtual string Name { get; set; }

    }
}
