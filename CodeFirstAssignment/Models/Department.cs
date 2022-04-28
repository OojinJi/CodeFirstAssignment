using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAssignment.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Title { get; set; }
        public Nullable<int> Credits { get; set; } 
        
        public virtual ICollection<Enrollment> Enrollments{ get; set; }
    }
}