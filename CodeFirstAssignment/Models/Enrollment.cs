using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAssignment.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public Nullable<decimal> Band { get; set; }
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; } 

        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }  
    }
}