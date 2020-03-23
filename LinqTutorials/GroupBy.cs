using LinqTutorials.Model;
using System.Linq;

namespace LinqTutorials
{
    class GroupBy
    {
        //static void Main(string[] args)
        //{
            //var employeeGroup = Employee2.GetAllEmployees().GroupBy(d => d.Department);

            ////foreach (var group in employeeGroup)
            ////{
            ////    System.Console.WriteLine(group.Key + "\t" + group.Count());
            ////}

            //foreach (var group in employeeGroup)
            //{
            //    System.Console.WriteLine(group.Key + "\t" + group.Count());
            //    System.Console.WriteLine("------------");
            //    foreach (var employee in group)
            //    {
            //        System.Console.WriteLine(employee.Name +"\t"+ employee.Department);
            //    }
            //    System.Console.WriteLine();
            //}

        //    var employeeGroup = from employee in Employee2.GetAllEmployees()
        //                        group employee by employee.Department into eGroup
        //                        orderby eGroup.Key
        //                        select new
        //                        {
        //                            eGroup.Key,
        //                            Employees = eGroup.OrderBy(d => d.Name)
        //                        };

        //    foreach (var group in employeeGroup)
        //    {
        //        System.Console.WriteLine(group.Key +"\t"+ group.Employees.Count());
        //        System.Console.WriteLine("---------");

        //        foreach (var employee in group.Employees)
        //        {
        //            System.Console.WriteLine(employee.Name +"\t"+ employee.Department);
        //        }
        //        System.Console.WriteLine();

        //    }
        //}

    }
}
