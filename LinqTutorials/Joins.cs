using System;
using System.Linq;

namespace LinqTutorials
{
    //class Joins
    //{
        //static void Main(string[] args)
        //{
        //    //JoinsEntities2 db = new JoinsEntities2();
        //    EmployeeDBContext db = new EmployeeDBContext();
        //    try
        //    {
        //        // Inner Join
        //        var empDeptInner = from emp in db.Employees
        //                           join dept in db.Departments
        //                           on emp.DepartmentID equals dept.DepartmentID
        //                           select new
        //                           {
        //                               emp.EmployeeID,
        //                               emp.EmployeeName,
        //                               DepartmentName = dept.DepartmentName ?? "Null"
        //                           };

        //        // Left Join
        //        var empDeptLeft = from emp in db.Employees
        //                          join dept in db.Departments
        //                          on emp.DepartmentID equals dept.DepartmentID into eGroup
        //                          from deptNew in eGroup.DefaultIfEmpty()
        //                          select new
        //                          {
        //                              emp.EmployeeID,
        //                              emp.EmployeeName,
        //                              emp.CityID,
        //                              DepartmentName = deptNew.DepartmentName ?? "Null"
        //                          };

        //        var empDeptRight = from dept in db.Departments
        //                           join emp in db.Employees
        //                           on dept.DepartmentID equals emp.DepartmentID into eGroup
        //                           from empNew in eGroup.DefaultIfEmpty()
        //                           select new
        //                           {
        //                               EmployeeID = string.IsNullOrEmpty(empNew.EmployeeID.ToString()) ? "Null" : empNew.EmployeeID.ToString(),
        //                               EmployeeName = empNew.EmployeeName ?? "Null",
        //                               dept.DepartmentName
        //                           };

        //        //var empCityRight = from ct in db.Cities
        //        //                   join emp in empDeptLeft
        //        //                   on ct.ID equals emp.CityID into empGroup
        //        //                   from emp in empGroup.DefaultIfEmpty()
        //        //                   select new
        //        //                   {
        //        //                       EmployeeID = string.IsNullOrEmpty(emp.EmployeeID.ToString()) ? "Null" : emp.EmployeeID.ToString(),
        //        //                       DepartmentName = emp.DepartmentName ?? "Null",
        //        //                       EmployeeName = emp.EmployeeName ?? "Null",
        //        //                       CityName = ct.Name ?? "Null"
        //        //                   };

        //        //var empLeftDept_rightCity = from ct in db.Cities
        //        //                            join emp in db.Employees
        //        //                            on ct.ID equals emp.CityID into empGroup
        //        //                            from empNew in empGroup.DefaultIfEmpty()
        //        //                            join dept in db.Departments
        //        //                            on empNew.DepartmentID equals dept.DepartmentID into deptGroup
        //        //                            from deptNew in deptGroup.DefaultIfEmpty()
        //        //                            select new
        //        //                            {
        //        //                                EmployeeID = string.IsNullOrEmpty(empNew.EmployeeID.ToString()) ? "Null" : empNew.EmployeeID.ToString(),
        //        //                                DepartmentName = deptNew.DepartmentName ?? "Null",
        //        //                                EmployeeName = empNew.EmployeeName ?? "Null",
        //        //                                CityName = ct.Name ?? "Null"
        //        //                            };
        //        //var empRightDept_leftCity = from dept in db.Departments // First table will never have empty rows
        //        //                            join emp in db.Employees //Second table
        //        //                            on dept.DepartmentID equals emp.DepartmentID into empGroup
        //        //                            from empNew in empGroup.DefaultIfEmpty()// Second table will always used with Default if empty
        //        //                            join ct in db.Cities // Second table
        //        //                            on empNew.CityID equals ct.ID into ctGroup // Left table will be always first in the condition
        //        //                            from ctNew in ctGroup.DefaultIfEmpty()
        //        //                            select new
        //        //                            {
        //        //                                EmployeeID = string.IsNullOrEmpty(empNew.EmployeeID.ToString()) ? "Null" : empNew.EmployeeID.ToString(),
        //        //                                DepartmentName = dept.DepartmentName ?? "Null",
        //        //                                EmployeeName = empNew.EmployeeName ?? "Null",
        //        //                                CityName = ctNew.Name ?? "Null"
        //        //                            };

        //        foreach (var ed in empDeptInner)
        //        {
        //            Console.WriteLine(ed.EmployeeID + "\t" + ed.EmployeeName + "\t" + ed.DepartmentName);
        //        }

        //        //var result = from f in db.tblFilters
        //        //             from taks in db.tblTasks.Where(x => f.FilterFrom <= x.due_datetime)
        //        //             .Where(x => f.FilterTo >= x.due_datetime)
        //        //             .DefaultIfEmpty()
        //        //             group new { f, taks } by new { taks.total_count, f.FilterDesc, f.orderno } into filterGroup
        //        //             orderby filterGroup.Key.orderno
        //        //             select new
        //        //             {
        //        //                 filterGroup.Key.FilterDesc,
        //        //                 Count = filterGroup.Sum(x => x.taks.total_count) ?? 0,
        //        //                 filterGroup.Key.orderno
        //        //             };
        //        //foreach (var ed in result)
        //        //{
        //        //    Console.WriteLine(ed.FilterDesc + "\t" + ed.Count);
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write(ex.Message);
        //    }
        //}
    //}
}
