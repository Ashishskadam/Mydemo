using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Format(DateTime.Now));
            Console.WriteLine(Format(Convert.ToDateTime( "12/1/2016")));
            Console.WriteLine(Format(Convert.ToDateTime("12/2/2016 12:00:00 pm")));
            Console.WriteLine(Format(Convert.ToDateTime("12/3/2016 12:00:00 pm")));
            Console.WriteLine(Format(Convert.ToDateTime("12/10/2016 12:00:00 pm")));
            Console.ReadKey();
        }

        public static string Format( object arg)
        {
            if (!(arg is DateTime)) throw new NotSupportedException();

            var dt = (DateTime)arg;

            string suffix;

            if (dt.Day  == 1)
            {
                suffix = "st";
            }
            else if (dt.Day  == 2)
            {
                suffix = "nd";
            }
            else if (dt.Day == 3)
            {
                suffix = "rd";
            }
            else
            {
                suffix = "th";
            }

            return string.Format("{0:dddd MMM} {1}{2}, {0:yyyy}", arg, dt.Day, suffix);
        }
    }
}
