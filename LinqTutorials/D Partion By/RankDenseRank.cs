using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorials.D_Partion_By
{
    class RankDenseRank
    {
        //static void Main(string[] args)
        //{
        //    var emplist = Employee.GetAllEmployees();
        //    //Rank implemenation
        //    Console.WriteLine("Rank");
        //    var filterEmp = from emp in emplist
        //                    orderby emp.Salary descending
        //                    select new
        //                    {
        //                        emp.Name,
        //                        emp.Gender,
        //                        emp.Salary,
        //                        Rank = emplist.Count(el => el.Salary > emp.Salary) + 1
        //                    };

        //    Console.WriteLine(string.Join("\n", filterEmp));
        //    //Console.ReadLine();

        //    //Dense Rank Implemenation
        //    Console.WriteLine();
        //    Console.WriteLine("Dense Rank");
        //    var filterEmpNew = from emp in emplist
        //                       orderby emp.Salary descending
        //                       group emp by emp.Salary into g
        //                       from emp in g
        //                       select new
        //                       {
        //                           emp.Name,
        //                           emp.Gender,
        //                           emp.Salary,
        //                           DenseRank = (from e in emplist
        //                                        group e by e.Salary into eg
        //                                        select eg
        //                                  ).Count(x => x.Key > g.Key) + 1
        //                       };

        //    Console.WriteLine(string.Join("\n", filterEmpNew));
        //    Console.WriteLine();

        //    var customFilterRank = from emp in emplist
        //                           orderby emp.Salary descending
        //                           let eList = emplist.OrderByDescending(x => x.Salary).ToList()
        //                           select new
        //                           {
        //                               emp.Salary,
        //                               Rank = eList.FindIndex(e => e.Salary == emp.Salary) + 1
        //                           };

        //    Console.WriteLine(string.Join("\n", customFilterRank));
        //    Console.ReadLine();
        //}

        //private static int findRank(List<Employee> eList, Employee emp)
        //{
        //    var emplist = eList.OrderByDescending(x => x.Salary).ToList();
        //    var findindex = emplist.FindIndex(e => e.Salary == emp.Salary) + 1;

        //    return  ;
        //}

        //private static object findRank(Employee e)
        //{
        //    var OldSal = 0;
        //    if (e.Salary > OldSal)
        //    {
        //        return 
        //    }
        //    OldSal = e.Salary;
        //}
    }
}
