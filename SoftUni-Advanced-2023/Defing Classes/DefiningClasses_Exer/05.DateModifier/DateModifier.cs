using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateModifier
{
    public class DateModifier
    {
        public static int DateModifier1(string start, string end)
        {
            DateTime firstDate = DateTime.Parse(start);
            DateTime secDate = DateTime.Parse(end);

            TimeSpan difference = firstDate - secDate;

            return Math.Abs(difference.Days);
        }
    }
}
