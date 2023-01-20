using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class LinqJoins
    {
        public static void Main()
        {
            var emp = Employee.GetAllEmployees();
            var dept = Department.GetAllDepartments();
          
            //simple join
            var join=(from e in emp join d in dept
                      //we cant switch the e.DepartmentId equals d.ID , we cant write d.ID equals e.DepartmentId
                      on e.DepartmentId equals d.ID
                      select new {empName=e.Name, deptName=d.Name}).ToList();

            //GroupJoin-- get emplyee with group by dept
            var grpjoin = (from d in dept
                         join e in emp on d.ID equals e.DepartmentId
                         into temp
                         select new { DeptName = d.Name, Employee = temp }).ToList();
            //Grpup by in sible table
            var g = emp.GroupBy(x => x.DepartmentId).Select(x => new { dept = x.Key, empl = x.ToList() }).ToList();

            //left join=
            var leftjoin = (from d in dept
                            join e in emp on d.ID equals e.DepartmentId
                            into temp
                            from rt in temp.DefaultIfEmpty()
                            let empName = (rt == null ? "" : rt.Name)
                            select new { DeptName = d.Name, employee = empName }).ToList();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", DepartmentId = 10},
                new Employee { ID = 2, Name = "Priyanka", DepartmentId =20},
                new Employee { ID = 3, Name = "Anurag", DepartmentId = 30},
                new Employee { ID = 4, Name = "Pranaya", DepartmentId = 30},
                new Employee { ID = 11, Name = "Ramesh", DepartmentId = 30}
            };
        }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
                {
                    new Department { ID = 10, Name = "IT"},
                    new Department { ID = 20, Name = "HR"},
                    new Department { ID = 30, Name = "Sales"  },
                     new Department { ID = 40, Name = "Office"  },
                };
        }
    }

}
