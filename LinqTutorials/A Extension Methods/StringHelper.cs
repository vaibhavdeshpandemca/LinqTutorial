using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.A_Extension_Methods
{
    public static class StringHelper
    {
        /// <summary>
        /// This method converts string first letter to title case
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string toTitleCase(this string name)
        {
            var str = name.ToCharArray();
            str[0] = char.ToUpper(str[0]);
            return new string(str);
        }
    }
}
