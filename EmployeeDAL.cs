using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConstructor
{
    interface IEmployeeDAL
    {
        public List<Employee> SetAllEmployees();
    }
    internal class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SetAllEmployees ()
        {
            List<Employee> EmpList = new List<Employee>();
            Employee E1= new Employee(){ Emp_id = 1, Emp_name = "shubra", Emp_department = "ATD" };
            Employee E2 = new Employee() { Emp_id = 2, Emp_name = "Mandeep", Emp_department = "AGR" };
            Employee E3 = new Employee() {Emp_id= 3, Emp_name="Arry", Emp_department="School" };
            EmpList.Add(E1);
            EmpList.Add(E2);
            EmpList.Add(E3);
            return EmpList;
        }
        
        
       
    }
}
