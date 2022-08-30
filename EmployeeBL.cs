using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConstructor
{
    internal class EmployeeBL
    {
        IEmployeeDAL iempdal;

        public EmployeeBL(IEmployeeDAL iempdal)
        {
            this.iempdal = iempdal;
        }

        public void GetAllEmployess()
        {
             //EmployeeDAL Emp = new EmployeeDAL();
            List<Employee> eList = new List<Employee>();
            eList = iempdal.SetAllEmployees();
            foreach (Employee e in eList)
            {
                Console.WriteLine(e.Emp_id + e.Emp_name + e.Emp_department);

            }
        }
    }
}
