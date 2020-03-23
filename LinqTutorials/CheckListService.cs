using LinqTutorials.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorials
{
    class CheckListService
    {

        //static void Main(string[] args)
        //{
        //    var filters = new List<DateFilter>();
        //    AddFilters(filters);
        //    var tasks = new List<DateF>();
        //    AddTasks(tasks);

        //    var result = (from filt in filters
        //                  from task in tasks.Where(x => Convert.ToDateTime(x.due_date) >= Convert.ToDateTime(filt.date_from))
        //                                    .Where(x => Convert.ToDateTime(x.due_date) <= Convert.ToDateTime(filt.date_to))
        //                  group new { filt, task } by new { task.total_count, filt.description, filt.orderno }
        //                                   into tfGroup
        //                  orderby tfGroup.Key.orderno
        //                  select new
        //                  {
        //                      filt
        //                      //tfGroup.Key.description,
        //                      //TotalCount = tfGroup.Key.total_count,
        //                      //tfGroup.Key.orderno
        //                  }).ToList();
        //    //Console.Write(result);

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item.orderno + "\t" + item.description + "\t" + item.TotalCount);
        //    }
        //}

        private static void AddTasks(List<DateF> tasks)
        {
            tasks.Add(new DateF()
            {
                due_date = "1/1/2018",
                total_count = 1
            });
        }

        private static void AddFilters(List<DateFilter> filters)
        {
            filters.Add(
                            new DateFilter()
                            {
                                date_from = "1/1/1999",
                                date_to = "12/31/2999",
                                description = "All Outstanding",
                                orderno = 1
                            }); filters.Add(
                 new DateFilter()
                 {
                     date_from = DateTime.UtcNow.ToString("M/d/yyyy"),
                     date_to = DateTime.UtcNow.ToString("M/d/yyyy"),
                     description = "Today",
                     orderno = 2
                 }); filters.Add(
                 new DateFilter()
                 {
                     date_from = DateTime.UtcNow.AddDays(1).ToString("M/d/yyyy"),
                     date_to = DateTime.UtcNow.AddDays(1).ToString("M/d/yyyy"),
                     description = "Tomorrow",
                     orderno = 3
                 }); filters.Add(
                 new DateFilter()
                 {
                     date_from = DateTime.UtcNow.ToString("M/d/yyyy"),
                     date_to = DateTime.UtcNow.AddDays(7).ToString("M/d/yyyy"),
                     description = "In Current Week",
                     orderno = 4
                 }); filters.Add(
                 new DateFilter()
                 {
                     date_from = DateTime.UtcNow.AddDays(0).ToString("M/d/yyyy"),
                     date_to = DateTime.UtcNow.AddDays(31).ToString("M/d/yyyy"),
                     description = "Current Month",
                     orderno = 5
                 }); filters.Add(
                 new DateFilter()
                 {
                     date_from = "1/1/0001",
                     date_to = "1/1/0001",
                     description = "Custom",
                     orderno = 6
                 });
        }
    }
}
