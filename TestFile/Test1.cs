using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using project.DZ1;

namespace project.Tests
{
    [TestClass()]
    public class RNClassTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Rat rn = new Rat(5, 6);
            Assert.AreEqual("5/6", rn.ToString());
        }

        [TestMethod()]
        public void ToStringTestNegativeNumenator()
        {
            Rat rn = new Rat(-5, 6);
            Assert.AreEqual("-5/6", rn.ToString());
        }

        [TestMethod()]
        public void ToStringTestNegativeDenominator()
        {
            Rat rn = new Rat(5, -6);
            Assert.AreEqual("-5/6", rn.ToString());
        }

        [TestMethod()]
        public void ToStringTestNegativeNUMorDEN()
        {
            Rat rn = new Rat(-5, -6);
            Assert.AreEqual("5/6", rn.ToString());
        }

        [TestMethod()]
        public void SummTest()
        {
            Rat rn = new Rat(1, 2);
            rn = rn + new Rat(2, 3);
            Assert.AreEqual("7/6", rn.ToString());
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            Rat rn = new Rat(1, 2);
            rn = rn - new Rat(2, 3);
            Assert.AreEqual("-1/6", rn.ToString());
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            Rat rn = new Rat(1, 2);
            rn = rn * new RNClass(2, 3);
            Assert.AreEqual("1/3", rn.ToString());
        }

        [TestMethod()]
        public void DivisionTest()
        {
            Rat rn = new Rat(1, 2);
            rn /= new Rat(2, 3);
            Assert.AreEqual("3/4", rn.ToString());
        }

        [TestMethod()]
        public void UnaryMinusTest()
        {
            Rat rn = new Rat(1, 2);
            rn = -rn;
            Assert.AreEqual("-1/2", rn.ToString());
        }

        [TestMethod()]
        public void EqualTest()
        {
            Rat rn1 = new Rat(1, 2);
            Rat rn2 = new Rat(1, 2);

            Assert.IsTrue(rn1 == rn2);
        }

        [TestMethod()]
        public void NotEqualTest()
        {
            Rat rn1 = new Rat(1, 2);
            Rat rn2 = new Rat(3, 2);

            Assert.IsTrue(rn1 != rn2);
        }

        [TestMethod()]
        public void Less()
        {
            Rat rn1 = new Rat(1, 5);
            Rat rn2 = new Rat(2, 3);

            Assert.IsTrue(rn1 < rn2);
        }

        [TestMethod()]
        public void LessOrEquel()
        {
            Rat rn1 = new Rat(1, 2);
            Rat rn2 = new Rat(1, 2);

            Assert.IsTrue(rn1 <= rn2);
        }

        [TestMethod()]
        public void Greater()
        {

            Rat rn1 = new Rat(3, 5);
            Rat rn2 = new Rat(1, 2);

            Assert.IsTrue(rn1 > rn2);
        }

        [TestMethod()]
        public void GreaterOrEquel()
        {
            Rat rn1 = new Rat(1, 2);
            Rat rn2 = new Rat(1, 2);

            Assert.IsTrue(rn1 >= rn2);
        }

    }
}