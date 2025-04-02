using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DZ1
{
    public class Rat
    {
        public int numinator { get; }
        public int denominator { get; }

        public static int Kr(int a, int b)
        {
            int temp = 0;

            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }
        public Rat(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Denominator cant be zero");
            }
            if (b < 0)
            {
                b *= -1;
                a *= -1;
            }
            int del = Kr(a, b);

            numinator = a / del;
            denominator = b / del;
            
        }
        override public string ToString()
        {
            if (denominator == 1)
                return $"{numinator}";
            return $"{numinator}/{denominator}";
        }
        public static Rat operator +(Rat rn1, Rat rn2)
        {
            int numenator = rn1.numinator * rn2.denominator + rn2.numinator * rn1.denominator;
            int denominator = rn1.denominator * rn2.denominator;

            return new Rat(numenator, denominator);
        }

        public static Rat operator -(Rat rn1, Rat rn2)
        {
            int numenator = rn1.numinator * rn2.denominator - rn2.numinator * rn1.denominator;
            int denominator = rn1.denominator * rn2.denominator;

            return new Rat(numenator, denominator);
        }

        public static Rat operator *(Rat rn1, Rat rn2)
        {
            int numerator = rn1.numinator * rn2.numinator;
            int denominator = rn1.denominator * rn2.denominator;

            return new Rat(numerator, denominator);
        }

        public static Rat operator /(Rat rn1, Rat rn2)
        {
            int numerator = rn1.numinator * rn2.denominator;
            int denominator = rn1.denominator * rn2.numinator;

            return new Rat(numerator, denominator);
        }

        public static Rat operator -(Rat rn)
        {
            return new Rat(-rn.numinator, rn.denominator);
        }

        public static bool operator ==(Rat rn1, Rat rn2)
        {
            return rn1.numinator == rn2.numinator && rn1.denominator == rn2.denominator;
        }

        public static bool operator !=(Rat rn1, Rat rn2)
        {
            return !(rn1.numinator == rn2.numinator) && rn1.denominator == rn2.denominator;
        }

        public static bool operator <(Rat rn1, Rat rn2)
        {
            return rn1.numinator * rn2.denominator < rn2.numinator * rn1.denominator;
        }

        public static bool operator <=(Rat rn1, Rat rn2)
        {
            return rn1.numinator * rn2.denominator <= rn2.numinator * rn1.denominator;
        }

        public static bool operator >(Rat rn1, Rat rn2)
        {
            return rn1.numinator * rn2.denominator > rn2.numinator * rn1.denominator;
        }

        public static bool operator >=(Rat rn1, Rat rn2)
        {
            return rn1.numinator * rn2.denominator >= rn2.numinator * rn1.denominator;
        }
    }
}      
