using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DZ2
{
    internal class TimePrintDecor : TimePrint
    {
        protected TimePrint timePrint;

        public TimePrintDecor(TimePrint got)
        {
            timePrint = got;
        }
        virtual public void Print()
        {
            timePrint.Print();
        }
    }
}