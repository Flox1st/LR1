using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DZ2
{
    internal class ConcreteDecorator : TimePrintDecor
    {
        protected string expressionString;

        public ConcreteDecorator(string stringGot, TimePrint got) : base(got)
        {
            expressionString = stringGot;
            timePrint = got;
        }

        public override void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(expressionString);
            sb.Append(timePrint.ToString());
            sb.Append(expressionString);

            Console.WriteLine(sb.ToString());
        }
    }
}