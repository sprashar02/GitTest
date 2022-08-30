namespace DIConstructor
{
    public class Program
    { 
        public static void Main()
        {

            EmployeeBL getemp = new EmployeeBL(new EmployeeDAL());
            getemp.GetAllEmployess();

        }
    }
}


