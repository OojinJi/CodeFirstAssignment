using CodeFirstAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAssignment.DAL
{
    public class DepartmentInitializer :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {

            var Departments = new List<Department>
            {
            new Department{DepartmentID=1,Title="Microsoft",Credits=3,},
            new Department{DepartmentID=2,Title="Java",Credits=3,},
            new Department{DepartmentID=3,Title="Php",Credits=4,}
            };
            Departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var Employees = new List<Employee>
            {
            new Employee{FirstName="Ark",LastName="Roop",JoiningDate=DateTime.Parse("2005-09-01")},
            new Employee{FirstName="Akash",LastName="Gupta",JoiningDate=DateTime.Parse("2002-09-01")},
            new Employee{FirstName="Saurabh",LastName="Gupta",JoiningDate=DateTime.Parse("2003-09-01")},

            };
            Employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{EmployeeID=1,DepartmentID=1,Band=Convert.ToDecimal(2.00)},
            new Enrollment{EmployeeID=2,DepartmentID=1,Band=Convert.ToDecimal(3.00)},
            new Enrollment{EmployeeID=3,DepartmentID=2,Band=Convert.ToDecimal(4.00)},

            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}