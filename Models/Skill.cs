using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Skill
    {
        public virtual Guid SkillId { get; set; }
        public virtual string Name { get; set; }

    }
}
