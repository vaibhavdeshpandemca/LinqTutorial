using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorials
{
    class Program
    {
        //static void Main(string[] args)
        //{
            //List<int> listInt = new List<int> { 3, 2, 1 };

            //List<string> countries = new List<string> { "India", "US", "Cannada" };

            //// var febo = listInt.Aggregate(10, (a, b) => a * b);

            //var ss = countries.Max(x => x.Length);

            //Console.WriteLine(ss);

            //var listEmployeeBonus = Employee.GetAllEmployees()
            //                                                .Where(x => x.AnnualSalary > 50000)
            //                                                .Select(e => new
            //                                                {
            //                                                    Name = e.FirstName + " " + e.LastName,
            //                                                    Salary = e.AnnualSalary,
            //                                                    Bonus = e.AnnualSalary / 100 * 10
            //                                                }).OrderByDescending(x=>x.Name);

            //foreach (var emp in listEmployeeBonus)
            //{
            //    Console.WriteLine(emp.Name+ " -- " + emp.Salary + "  --  " + emp.Bonus);

            //}

            //IEnumerable<string> subjects = Student.GetAllStudetns().SelectMany(s => s.Subjects).Distinct();


            //IEnumerable<string> subjects = (from student in Student.GetAllStudetns()
            //from subject in student.Subjects
            //select subject).Distinct();

            //var student = Student.GetAllStudetns().SelectMany(s => s.Subjects, (stud, subject) => new { StudName = stud.Name, Subject = subject });

            //var student = from stud in Student.GetAllStudetns()
            //              from subject in stud.Subjects
            //              select new { StudName = stud.Name, Subject = subject };

            //foreach (var stud in student)
            //{
            //    Console.WriteLine(stud.StudName + " -- " + stud.Subject);
            //}


            ////////////////////////////
            ///
            //EmployeeDBContext employeedb = new EmployeeDBContext();

            //IEnumerable<Department> dept = employeedb.Departments.Where(x => x.Name == "IT" || x.Name == "HR");

            //foreach (Department department in dept)
            //{
            //    Console.WriteLine($"The department is {department.Name}");

            //    //Console.WriteLine("Employee for this department are");
            //    IEnumerable<Employee> emp = department.Employees.Where(x => x.Gender == "Male");

            //    foreach (Employee employee in emp)
            //    {
            //        Console.WriteLine($"\tEmployee Name is {employee.FirstName} {employee.LastName}");
            //    }

            //    Console.WriteLine();
            //}

            //do
            //{
            //    Console.WriteLine("Enter the Page number");
            //    try
            //    {
            //        int pageNumber = int.Parse(Console.ReadLine());

            //        int pagSize = 3;

            //        var studentList = Student1.GetAllStudetns().Skip((pageNumber - 1) * 3).Take(pagSize);

            //        foreach (Student1 student in studentList)
            //        {
            //            Console.WriteLine($"Student Id is {student.StudentID} Name is {student.Name} and his marks are {student.TotalMarks}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine("Enter Valid Number between 1 and 4");
            //        // throw;
            //    }
            //} while (true);
           

       // }


    }
}
