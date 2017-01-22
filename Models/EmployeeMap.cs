using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap() {

            Id(x => x.EmployeeId);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.EMBG);
            Map(x => x.Phone);
            Map(x => x.Address);

            Map(x => x.Education);
            Map(x => x.Start_employment_date);
            Map(x => x.End_employment_date);
            Map(x => x.Vacation_days);

            Map(x => x.Status_present);
            Map(x => x.Status_employed);
            Map(x => x.isManager);

            HasOne(x => x.EmployeeDepartment);
            HasOne(x => x.EmployeeJobTitle);
            HasMany(x => x.Skills).KeyColumn("EmployeeId").Inverse();

            Table("Employee");
        }
       

    }
}
