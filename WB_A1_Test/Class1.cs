using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WB_A1;

namespace WB_A1_Test
{

    [TestFixture]
    public class Class1
    {
        Rectangle r1 = new Rectangle(3, 5);

        [Test]
        public void GetLengthTest1()
        {
            int expected = 3;

            int res = r1.GetLength();

            Assert.AreEqual(expected, res, 1);
        }

        [Test]
        public void GetLengthTest2()
        {
            int expected = 4;

            int res = r1.GetLength();

            Assert.AreNotEqual(expected, res);
        }


        [Test]
        public void SetLengthTest1()
        {
            int expected = 4;

            int res = r1.SetLength(4);

            Assert.AreEqual(expected, res);
        }



        [Test]
        public void SetLengthTest2()
        {
            int expected = 4;

            int res = r1.SetLength(6);

            Assert.AreNotEqual(expected, res);
        }


        [Test]
        public void GetWidthTest1()
        {
            int expected = 5;

            int res = r1.GetWidth();

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void GetWidthTest2()
        {
            int expected = 4;

            int res = r1.GetWidth();

            Assert.AreNotEqual(expected, res);
        }


        [Test]
        public void SetWidthTest1()
        {
            int expected = 4;

            int res = r1.SetWidth(4);

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void SetWidthTest2()
        {
            int expected = 4;

            int res = r1.SetWidth(3);

            Assert.AreNotEqual(expected, res);
        }

        [Test]
        public void Perimeter1()
        {
            int expected = 16;

            int res = r1.GetPerimeter();

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void Perimeter2()
        {
            int expected = 4;

            int res = r1.GetPerimeter();

            Assert.AreNotEqual(expected, res);
        }


        [Test]
        public void Area1()
        {
            int expected = 15;

            int res = r1.GetArea();

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void Area2()
        {
            int expected = 4;

            int res = r1.GetArea();

            Assert.AreNotEqual(expected, res);
        }
    }
}
