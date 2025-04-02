using System;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DZ2
{
    internal class EuropTimePrint : TimePrint
    {
        public void Print()
        {
            var Info = new CultureInfo("es-ES");
            Console.WriteLine(DateTime.Now.ToString(Info));
        }

        public override string ToString()
        {
            var Info = new CultureInfo("es-ES");
            return DateTime.Now.ToString(Info);
        }
    }
}