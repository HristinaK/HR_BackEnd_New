using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap() {
            Id(x => x.DepartmentId);
            Map(x => x.Name);
            Table("Department");

        }

    }
}
