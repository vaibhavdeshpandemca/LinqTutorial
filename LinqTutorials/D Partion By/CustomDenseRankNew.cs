using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.D_Partion_By
{
    class CustomDenseRankNew
    {
        static void Main(string[] args)
        {
            var emplist = Employee.GetAllEmployees();
             var filterEmpNew = (from emp in emplist
                               orderby emp.Salary descending
                               group emp by emp.Salary
                               );
            List<Employee> lstEmp = new List<Employee>();
            foreach (var empl in filterEmpNew)
            {
                lstEmp = empl.ToList();
            }

            Console.WriteLine(string.Join("\n", lstEmp));
        }
    }
}
