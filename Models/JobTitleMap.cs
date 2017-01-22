using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace HR.Models
{
    public class JobTitleMap : ClassMap<JobTitle>
    {
        public JobTitleMap()
        {
            Id(x => x.JobTitleId);
            Map(x => x.Name);
            Table("JobTitle");
        }
    }
}
