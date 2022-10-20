using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("QuickTest")]

namespace QuickDate
{
    internal class Calendar
    {
        static void Main(string[] args)
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"Today's date is {now.ToString("D", new System.Globalization.CultureInfo("id-ID"))}");
            Console.ReadLine();
        }
        internal static DateTime GetCurrentDate() => DateTime.Now.Date;
    }
}
