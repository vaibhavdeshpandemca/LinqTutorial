using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials
{
    //class Student
    //{
    //public int ID { get; set; }
    //public string Name { get; set; }
    //public string Gender { get; set; }

    //public List<Student> GetEmployees()
    //{
    //    List<Student> listStudents = new List<Student>();

    //    Student student1 = new Student
    //    {
    //        ID = 101,
    //        Name = "Mark",
    //        Gender = "Male"
    //    };
    //    listStudents.Add(student1);

    //    Student student2 = new Student
    //    {
    //        ID = 102,
    //        Name = "Mary",
    //        Gender = "Female"
    //    };
    //    listStudents.Add(student2);

    //    Student student3 = new Student
    //    {
    //        ID = 103,
    //        Name = "John",
    //        Gender = "Male"
    //    };
    //    listStudents.Add(student3);

    //    Student student4 = new Student
    //    {
    //        ID = 104,
    //        Name = "Steve",
    //        Gender = "Male"
    //    };
    //    listStudents.Add(student4);

    //    Student student5 = new Student
    //    {
    //        ID = 105,
    //        Name = "Pam",
    //        Gender = "Female"
    //    };
    //    listStudents.Add(student5);

    //    return listStudents;
    //}

    // }

    //public class Student
    //{
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public List<string> Subjects { get; set; }

    //    public static List<Student> GetAllStudetns()
    //    {
    //        List<Student> listStudents = new List<Student>
    //    {
    //        new Student
    //        {
    //            Name = "Tom",
    //            Gender = "Male",
    //            Subjects = new List<string> { "ASP.NET", "C#" }
    //        },
    //        new Student
    //        {
    //            Name = "Mike",
    //            Gender = "Male",
    //            Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
    //        },
    //        new Student
    //        {
    //            Name = "Pam",
    //            Gender = "Female",
    //            Subjects = new List<string> { "WCF", "SQL Server", "C#" }
    //        },
    //        new Student
    //        {
    //            Name = "Mary",
    //            Gender = "Female",
    //            Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
    //        },
    //    };

    //        return listStudents;
    //    }
    //}

    public class Student1
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student1> GetAllStudetns()
        {
            List<Student1> listStudents = new List<Student1>
        {
            new Student1 { StudentID= 101, Name = "Tom", TotalMarks = 800 },
            new Student1 { StudentID= 102, Name = "Mary", TotalMarks = 900 },
            new Student1 { StudentID= 103, Name = "Pam", TotalMarks = 800 },
            new Student1 { StudentID= 104, Name = "John", TotalMarks = 800 },
            new Student1 { StudentID= 105, Name = "John", TotalMarks = 800 },
            new Student1 { StudentID= 106, Name = "Brian", TotalMarks = 700 },
            new Student1 { StudentID= 107, Name = "Jade", TotalMarks = 750 },
            new Student1 { StudentID= 108, Name = "Ron", TotalMarks = 850 },
            new Student1 { StudentID= 109, Name = "Rob", TotalMarks = 950 },
            new Student1 { StudentID= 110, Name = "Alex", TotalMarks = 750 },
            new Student1 { StudentID= 111, Name = "Susan", TotalMarks = 860 },
        };

            return listStudents;
        }
    }
}