using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace HR.Models
{
    public class LeaveMap : ClassMap<Leave>
    {
        public LeaveMap()
        {
            Id(x => x.LeaveId);

            Map(x => x.from);
            Map(x => x.to);

            Map(x => x.tottalDays);
            Map(x => x.type);
            Map(x => x.comment);
            Map(x => x.status);

            HasOne(x => x.EmployeeLeave);


            Table("Leave");

        }


    }
}
