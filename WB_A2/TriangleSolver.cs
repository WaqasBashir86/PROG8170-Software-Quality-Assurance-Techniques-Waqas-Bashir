using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WB_A2
{
    class TriangleSolver
    {

        public static String Analyze(int a, int b, int c)
        {
            TriangleSolver tr = new TriangleSolver();


            if (tr.checkValidity(Convert.ToInt32(a), Convert.ToInt32(b), Convert.ToInt32(c)))
            {
                String triangleName = tr.whichTriangle(Convert.ToInt32(a), Convert.ToInt32(b), Convert.ToInt32(c));

                return triangleName;

            }
            else
            {
                return "Not form a triangle";

            }

        }



        public String whichTriangle(int a, int b, int c)
        {
            if (a == b && b == c && c == a)
            {
                return "It is an Equilateral Triangle";

            }
            else if (a == b || a == c || b == c)
            {
                return "It is an Isosceles Triangle";


            }
            else if (a != b && b != c && c != a)
            {
                return "It is a Scalene Triangle";

            }

            return "Triangle Not Found";

        }

        public bool checkValidity(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
