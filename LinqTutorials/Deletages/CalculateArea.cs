using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.Deletages
{
    class CalculateArea
    {
        //public delegate double CalPointer(int r);
        //static void Main(string[] args)
        //{
        //    //CalPointer cp = CalcualteArea;

        //    //CalPointer cp = x => x * x * 3.14;

        //    Func<double, double> cp = x => 3.14 * x * x;

        //    var r = 20;
        //    var area = cp(r);
            
        //    Console.WriteLine($"Redius is {r} Area is {area}");

        //    Action<string> action = x => Console.WriteLine("You have entered "+x);
        //    action("Hello world");

        //    Predicate<string> predicate = x => x.Length > 5;

        //    Console.WriteLine(predicate("Hello"));

        //    Console.WriteLine("****************");
        //    List<string> str = new List<string>
        //    {
        //        "Str1",
        //        "str 2d",
        //        "str 2ddfd",
        //        "str"
        //    };
        //    var f = str.FindAll(predicate);
        //    foreach (var s in f)
        //    {

        //    Console.WriteLine(s);
        //    }
        //    Console.WriteLine("************");
        //    Func<List<string>, List<string>> fu = x => x.Where(p => p.Length > 3).ToList();
        //    var kk = fu(str);

        //    Console.WriteLine("*************");
        //    Predicate<string> pred = x => x.Length  > 5;
        //    var ll = getListString(str, pred);
        //    foreach (var s in ll)   
        //    {

        //        Console.WriteLine(s);
        //    }



        //}

        private static List<string> getListString(List<string> strlist, Predicate<string> predicate)
        {
            List<string> ss = new List<string>();
            foreach (var item in strlist)
            {
                if(predicate(item))
                {
                    ss.Add(item);
                }
            }
            return ss;
        }
        public static double CalcualteArea(int redius)
        {
            return 3.14 * redius * redius;
        }
    }
}
