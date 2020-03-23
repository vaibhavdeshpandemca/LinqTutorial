using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials
{
    class OverClause
    {
        //static void Main(string[] args)
        //{
        //    using (LinqTutorialEntities db = new LinqTutorialEntities())
        //    {

        //        var Genders = from emp in db.Employees
        //                      group emp by emp.Gender into eGroup
        //                      let gCount = eGroup.Count()
        //                      select new
        //                      {
        //                          Gender = eGroup.Key,
        //                          GenderCount = gCount
        //                      };


        //        var result1 = from emp in db.Employees
        //                      join g in Genders on emp.Gender equals g.Gender
        //                      select new
        //                      {
        //                         Id = emp.Id,
        //                         Name = emp.Name,
        //                         Gender = emp.Gender,
        //                         GenderCount = g.GenderCount
        //                      };



        //        foreach (var item in Genders)
        //        {
        //        Console.WriteLine(item.Gender +" "+ item.GenderCount);
        //        }
        //        Console.WriteLine();
        //        foreach (var item in result1)
        //        {
        //            Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Gender, item.GenderCount);
        //        }

        //    }
        //}
    }
}
