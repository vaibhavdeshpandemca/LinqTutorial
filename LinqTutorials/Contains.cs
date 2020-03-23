using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials
{
    class Contains
    {
        //static void Main(string[] args)
        //{
        //    List<c_Employee> emp = new List<c_Employee>() {
        //    new c_Employee() {emp_id = 209, emp_name = "Anjita", emp_gender = "Female",
        //                            emp_hire_date = "12/3/2017", emp_salary = 20000},
        //    new c_Employee() {emp_id = 210, emp_name = "Soniya", emp_gender = "Female",
        //                            emp_hire_date = "22/4/2018", emp_salary = 30000},
        //    new c_Employee() {emp_id = 211, emp_name = "Rohit", emp_gender = "Male",
        //                          emp_hire_date = "3/5/2016", emp_salary = 40000},
        //    new c_Employee() {emp_id = 212, emp_name = "Supriya", emp_gender = "Female",
        //                              emp_hire_date = "4/8/2017", emp_salary = 40000},
        //    new c_Employee() {emp_id = 213, emp_name = "Anil", emp_gender = "Male",
        //                        emp_hire_date = "12/1/2016", emp_salary = 40000},
        //    new c_Employee() {emp_id = 214, emp_name = "Anju", emp_gender = "Female",
        //                          emp_hire_date = "17/6/2015", emp_salary = 50000},
        //};

        //    // New employee 
        //    c_Employee emp1 = new c_Employee()
        //    {
        //        emp_id = 214,
        //        emp_name = "Anju",
        //        emp_gender = "Female",
        //        emp_hire_date = "17/6/2015",
        //        emp_salary = 50000
        //    };
        //    var result = emp.Contains(emp1,new EmpCompar());
        //    Console.WriteLine(result);
        //}
    }

    
// C# program to check the new employee 
// is found in the given old data list 

// Employee details 
    public class c_Employee
    {
    
        public int emp_id
        {
            get;
            set;
        }

        public string emp_name
        {
            get;
            set;
        }

        public string emp_gender
        {
            get;
            set;
        }

        public string emp_hire_date
        {
            get;
            set;
        }

        public int emp_salary
        {
            get;
            set;
        }
    }

    public class EmpCompar : IEqualityComparer<c_Employee>
    {

        public bool Equals(c_Employee a, c_Employee b)
        {
            if (a.emp_id == b.emp_id && a.emp_name == b.emp_name &&
                                    a.emp_gender == b.emp_gender &&
                              a.emp_hire_date == b.emp_hire_date &&
                                      a.emp_salary == b.emp_salary)
                return true;

            return false;
        }

        public int GetHashCode(c_Employee obj)
        {
            return obj.GetHashCode();
        }
        //public bool Equals(c_Employee x, c_Employee y)
        //{
        //    throw new NotImplementedException();
        //}

        //public int GetHashCode(c_Employee obj)
        //{
        //    throw new NotImplementedException();
        //}
    }


}
