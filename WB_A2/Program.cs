using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WB_A2
{
    class Program
    {
        static void Main(string[] arg)
        {

            char answer;
            do
            {
                Console.WriteLine(" Welcome to Triangle Solver Select a menu option to continue \n");
                Console.WriteLine("1.Enter triangle dimension");
                Console.WriteLine("2.Exit \n");

                Console.WriteLine("Enter your menu choice \n");

                TriangleSolver tri = new TriangleSolver();
                var selection = Console.ReadLine();

                if (isNumber(selection))
                {
                    String result = "";

                    if (Convert.ToInt32(selection) == 1 || Convert.ToInt32(selection) == 2)
                    {
                        switch (selection)
                        {

                            case "1":
                                Console.WriteLine("Enter triangle dimension ");
                                break;

                            case "2":
                                return;
                        }

                        TriangleSolver tro = new TriangleSolver();

                        Console.Write("Input side 1 of triangle: ");
                        var a = Console.ReadLine();
                        Console.Write("Input side 2 of triangle: ");
                        var b = Console.ReadLine();
                        Console.Write("Input side 3 of triangle: ");
                        var c = Console.ReadLine();


                        if (isNumber(a) && isNumber(b) && isNumber(c))
                        {
                            result = TriangleSolver.Analyze(Convert.ToInt32(a), Convert.ToInt32(b), Convert.ToInt32(c));
                        }


                        Console.WriteLine(result);

                    }
                    else
                    {

                        Console.WriteLine("Enter valid menu option \n");


                    }
                }
                else
                {
                    Console.WriteLine("Entered character is not a number");
                }

                Console.ReadLine();
                Console.WriteLine("Do you want to continue");
                answer = Convert.ToChar(Console.ReadLine());

            } while (answer == 'y' || answer == 'Y');

        }

        public string Analyze(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public static bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false)
                    return false;

            return true;

        }
    }
}
