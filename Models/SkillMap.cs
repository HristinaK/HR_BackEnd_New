using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace HR.Models
{
    public class SkillMap : ClassMap<Skill>
    {
        public SkillMap()
        {
            Id(x => x.SkillId);
            Map(x => x.Name);
            Table("Skill");
        }
    }
}
