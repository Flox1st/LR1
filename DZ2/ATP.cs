using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DZ2
{
    internal class AmericanTimePrint : TimePrint
    {
        public void Print()
        {
            var Info = new CultureInfo("en-US");
            Console.WriteLine(DateTime.Now.ToString(Info));
        }

        public override string ToString()
        {
            var Info = new CultureInfo("en-US");
            return DateTime.Now.ToString(Info);
        }
    }
}
