using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			char answer;
			do
			{
			Found:
				Console.WriteLine("Hi welcome to Rectangle Class");

				Console.WriteLine("Enter the Length for the Rectangle");
				//int len = Convert.ToInt32(Console.ReadLine());

				var len = Console.ReadLine();
				Rectangle rec = new Rectangle();

				Console.WriteLine("Enter the Width for the Rectangle");
				//int wid = Convert.ToInt32(Console.ReadLine());

				var wid = Console.ReadLine();

				if (rec.isNumber(len) && rec.isNumber(wid))
				{
					// true is a number
					//Console.WriteLine("is a number");
					Console.WriteLine("Select an option from below to start \n");

					Console.WriteLine("1. Get Rectangle Length \n");
					Console.WriteLine("2. Change Rectangle Length \n");
					Console.WriteLine("3. Get Rectangle Width \n");
					Console.WriteLine("4. Change Rectangle Width \n");
					Console.WriteLine("5. Get Rectangle Perimeter \n");
					Console.WriteLine("6. Get Rectangle Area \n");
					Console.WriteLine("7. Exit \n");

					var selection = Console.ReadLine();

					Rectangle rects = new Rectangle(Convert.ToInt32(len), Convert.ToInt32(wid));

					switch (selection)
					{

						case "1":
							Console.WriteLine("Length of the rectangle is " + rects.GetLength());
							break;

						case "2":
							Console.WriteLine(" Enter Length of the rectangle \n");
							var leng = Console.ReadLine();
							if (rec.isNumber(leng))
							{
								Console.WriteLine("Rectangle length is changed new Length of Rectangle is =" + rects.SetLength(Convert.ToInt32(leng)));
							}
							else
							{
								Console.WriteLine("Enter a proper input Enter an integer number \n");
								goto Found;

							}
							break;
						case "3":
							Console.WriteLine("Width of the rectangle is " + rects.GetWidth());
							break;
						case "4":
							Console.WriteLine(" Enter Width of the rectangle \n");
							var widt = Console.ReadLine();
							if (rec.isNumber(widt))
							{
								Console.WriteLine("Rectangle Width is changed new Width of the rectangle is = " + rects.SetWidth(Convert.ToInt32(widt)));
							}
							else
							{
								Console.WriteLine("Enter a proper input Enter an integer number \n");
								goto Found;

							}
							break;
						case "5":
							Console.WriteLine("Perimeter of the rectangle is " + rects.GetPerimeter());
							break;
						case "6":
							Console.WriteLine("Area of the rectangle is " + rects.GetArea());
							break;
						case "7":
							return;
							break;
						default:
							Console.WriteLine("Enter a valid menu selection");
							break;

					}
				}
				else
				{
					Console.WriteLine("Enter a proper input Enter an integer number \n");
					goto Found;
					//return;

				}
				Console.WriteLine("Do you want to continue");
				answer = Convert.ToChar(Console.ReadLine());
			} while (answer == 'y' || answer == 'Y');
		}
	}
}
