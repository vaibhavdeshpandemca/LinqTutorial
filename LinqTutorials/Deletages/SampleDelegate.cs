using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.Deletages
{
    public delegate void delDisplayString(string str);
    class SampleDelegate
    {
        //static void Main(string[] args)
        //{
        //    delDisplayString del = new delDisplayString(DisplayString);
        //    del("Hellow World");
        //}

        public static void DisplayString(string str)
        {
            Console.WriteLine("You have entered "+ str);
        }
    }
}
