using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.D_Partion_By
{
    class CompResults
    {
        public string Name { get; set; }
        public int WaightClass { get; set; }
        public int Victories { get; set; }
        public string Gender { get; set; }

        public static List<CompResults> GetCompResult()
        {
           return new List<CompResults>
            {
                new CompResults
                {
                    Name = "Dave",
                    WaightClass = 75,
                    Victories = 2,
                    Gender = "Male"
                },
                new CompResults
                {
                    Name = "Austin",
                    WaightClass = 94,
                    Victories = 8,
                    Gender = "Female"
                },
                new CompResults
                {
                    Name = "Uriah",
                    WaightClass = 56,
                    Victories = 5,
                    Gender = "Female"
                },
                new CompResults
                {
                    Name = "Ricky",
                    WaightClass = 75,
                    Victories = 22,
                    Gender = "Male"
                },
                new CompResults
                {
                    Name = "Steve",
                    WaightClass = 56,
                    Victories = 20,
                    Gender = "Male"
                },
                new CompResults
                {
                    Name = "Andrew",
                    WaightClass = 75,
                    Victories = 4,
                    Gender = "Male"
                },
                new CompResults
                {
                    Name = "Jordan",
                    WaightClass = 94,
                    Victories = 12,
                    Gender = "Male"
                },
                new CompResults
                {
                    Name = "Pedro",
                    WaightClass = 94,
                    Victories = 10,
                    Gender = "Female"
                },
                new CompResults
                {
                    Name = "Phillip",
                    WaightClass = 75,
                    Victories = 5,
                    Gender = "Male"
                }
            };
        }
    }
}
