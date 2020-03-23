using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.Model
{
    class DateFilter
    {
        public string date_from { get; set; }
        public string date_to { get; set; }
        public string description { get; set; }
        public int orderno { get; set; }
    }

    class DateF
    {
        public int total_count { get; set; }
        public string due_date { get; set; }
    }
}
