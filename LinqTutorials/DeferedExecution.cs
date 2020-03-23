using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials
{
    class DeferedExecution
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("**************Defered Execution***************");
        //    List<Student1> studentList = Student1.GetAllStudetns();
        //    IEnumerable<Student1> result = from stud in studentList
        //                                   where stud.TotalMarks == 800
        //                                   select stud;
            
        //    studentList.Add(new Student1{ StudentID = 201, Name = "Sam", TotalMarks = 800 });
        //    foreach (var stud in result)
        //    {
        //        Console.WriteLine("Student Name {0} -- Total Marks is {1}",stud.Name, stud.TotalMarks);
        //    }
        //    // Result will contain Student ID 201 since query will be executed at foreach loop which
        //    // is called as Defered Execution.

        //    //1.Deferred or Lazy Operators - These query operators use deferred execution.
        //    //Examples - select, where, Take, Skip etc
        //    //2.Immediate or Greedy Operators - These query operators use immediate execution.
        //    //Examples - count, average, min, max, ToList etc

        //    // Example of Immediate Execution

        //    Console.WriteLine("\n\n*********Early Execution***************");

        //    List<Student1> studentList1 = Student1.GetAllStudetns();
        //    IEnumerable<Student1> result1 = (from stud in studentList1
        //                                   where stud.TotalMarks == 800
        //                                   select stud).ToList(); // Here we used toList Greedy Operator

        //    studentList1.Add(new Student1 { StudentID = 201, Name = "Sam", TotalMarks = 800 });
        //    foreach (var stud in result1)
        //    {
        //        Console.WriteLine("Student Name {0} -- Total Marks is {1}", stud.Name, stud.TotalMarks);
        //    }
        //    // Now, result will not contain Student ID 201 since the query is executed
        //    // At result level and not at foreach level

        //}
    }
}
