using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WB_A2;
using NUnit.Framework;

namespace Triangle_Test
{

    [TestFixture]
    public class Class1
    {
        TriangleSolver tr = new TriangleSolver();


        [Test]

        public void Analyze1()
        {
            int a = 5;
            int b = 6;    //Arrange
            int c = 7;


            string output =   TriangleSolver.Analyze(a, b, c);   //Act

            Assert.AreEqual("It is a Scalene Triangle", output);
        }

        [Test]
        public void Analyze2()
        {
            int a = 8;
            int b = 15;    //Arrange
            int c = 3;


            string output = TriangleSolver.Analyze(a, b, c);   //Act

            Assert.AreNotEqual("Scalene Triangle", output);
        }
        [Test]
        public void Analyze3()
        {
            int a = 5;
            int b = 5;    //Arrange
            int c = 5;


            string output = TriangleSolver.Analyze(a, b, c);   //Act

            Assert.AreEqual("It is an Equilateral Triangle", output);
        }
        [Test]
        public void Analyze4()
        {
            int a = 9;
            int b = 5;    //Arrange
            int c = 8;


            string output =  TriangleSolver.Analyze(a, b, c);   //Act

            Assert.AreNotEqual("It is an Equilateral Triangle", output);
        }
        [Test]
        public void Analyze5()
        {
            int a = 7;
            int b = 7;    //Arrange
            int c = 8;


            string output = TriangleSolver.Analyze(a, b, c);   //Act

            Assert.AreEqual("It is an Isosceles Triangle", output);
        }
        [Test]
        public void Analyze6()
        {
            int a = 14;
            int b = 2;    //Arrange
            int c = 20;


            string output = TriangleSolver.Analyze(a, b, c);   //Act

            Assert.AreNotEqual("It is an Isosceles Triangle", output);
        }

        [Test]
        public void Analyze7()
        {
            int a = 5;
            int b = 5;    //Arrange
            int c = 5;


            bool output = tr.checkValidity(a, b, c);   //Act

            Assert.AreEqual(true, output);
        }

        [Test]
        public void Analyze8()
        {
            int a = 50;
            int b = 20;    //Arrange
            int c = 60;


            bool output = tr.checkValidity(a, b, c);   //Act

            Assert.AreNotEqual(true, output);
        }

    }
}
