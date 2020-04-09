using System.Collections.Generic;
using System.Linq;

namespace LinqTutorials
{

    class OrderingOperatorsPart2
    {
        //static void Main(string[] args)
        //{
        //    //var students = Student.GetAllStudetns().OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenByDescending(s=>s.StudentID);

        //    //IEnumerable<Student> students = (from student in Student.GetAllStudetns()
        //    //                                orderby student.TotalMarks, student.Name, student.StudentID descending
        //    //                                select student).ToList();

        //    Console.WriteLine("Before Calling Reverse");
        //    IEnumerable<Student> students = Student.GetAllStudetns();

        //    foreach (var student in students)
        //    {
        //        Console.WriteLine("\t" + student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
        //    }

        //    Console.WriteLine("After Calling Reverse");
        //    students = students.Reverse();

        //    foreach(var student in students)
        //    {
        //        Console.WriteLine("\t" + student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
        //    }
        //}
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static IQueryable<Student> GetAllStudents()
        {
           var listStudents = new List<Student>
        {
            new Student
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student
            {
                StudentID= 103,
                Name = "Pam",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 105,
                Name = "John",
                TotalMarks = 900
            },
        };

            return listStudents.AsQueryable();
        }
        public static List<Student> GetAllStudetns()
        {
            List<Student> listStudents = new List<Student>
        {
            new Student
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student
            {
                StudentID= 103,
                Name = "Pam",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 105,
                Name = "John",
                TotalMarks = 900
            },
        };

            return listStudents;
        }
    }
}
