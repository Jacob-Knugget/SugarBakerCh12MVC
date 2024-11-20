using System;
using System.Collections.Generic;

namespace Sugarbaker.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
