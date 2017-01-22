using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Employee
    {
        public virtual Guid EmployeeId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string EMBG { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Education { get; set; }
        public virtual DateTime Start_employment_date { get; set; }
        public virtual DateTime End_employment_date { get; set; }
        public virtual int Vacation_days { get; set; }
        public virtual Boolean Status_present { get; set; }
        public virtual Boolean Status_employed { get; set; }
        public virtual Boolean isManager { get; set; }
        public virtual Department EmployeeDepartment { get; set; }
        public virtual JobTitle EmployeeJobTitle { get; set; }
        public virtual IList<Skill> Skills { get; set; }

    }
}
