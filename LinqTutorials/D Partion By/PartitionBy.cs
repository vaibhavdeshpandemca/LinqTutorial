using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.D_Partion_By
{
    class PartitionBy
    {
        //static void Main(string[] args)
        //{
        //    var compResult = CompResults.GetCompResult();

        //    var result = from cr in compResult
        //                 group cr by cr.WaightClass into cGroup //Partition by WaightClass
        //                 from c in cGroup //Groups are converted to single sequence. 
        //                 //Now c contains list of records as single sequence.
        //                 select new
        //                 {
        //                     c.Name,
        //                     c.WaightClass,
        //                     c.Victories,
        //                     AtheletCount = cGroup.Min(x => x.Victories) //cGroup contains partition of records to which you can use count, min, max of that group
        //                 };

        //    Console.WriteLine(string.Join("\n", result.Select(x => 
        //    new { x.Name, x.WaightClass, x.Victories, x.AtheletCount }) ));
        //}
    }
}
