using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WB_A1
{
    public class WB_A1
    {
		public static void Main(string[] args)
		{
			char answer;
			do
			{
			Console_UI:
				Console.WriteLine("Hello Neo!! \n  welcome to Rectangle101 Class with unit testing");

				Console.WriteLine("Enter the Length of your Rectangle");
				

				var len = Console.ReadLine();
				Rectangle rec = new Rectangle();

				Console.WriteLine("Enter the Width of your Rectangle");
				

				var wid = Console.ReadLine();

				if (rec.isNumber(len) && rec.isNumber(wid))
				{
					
					Console.WriteLine("Select an option from below to start \n");
					Console.WriteLine("1. Retrieve Rectangle Length \n");
					Console.WriteLine("2. Edit Rectangle Length \n");
					Console.WriteLine("3. Retrieve Rectangle Width \n");
					Console.WriteLine("4. Edit Rectangle Width \n");
					Console.WriteLine("5. Calculate the Perimeter of your Rectangle\n");
					Console.WriteLine("6. Calculate the Area of your Rectangle \n");
					Console.WriteLine("7. Exit \n");

					var selection = Console.ReadLine();

					Rectangle rects = new Rectangle(Convert.ToInt32(len), Convert.ToInt32(wid));

					switch (selection)
					{

						case "1":
							Console.WriteLine("Length of your Rectangle is " + rects.GetLength());
							break;

						case "2":
							Console.WriteLine(" Enter Length of your Rectangle \n");
							var leng = Console.ReadLine();
							if (rec.isNumber(leng))
							{
								Console.WriteLine("New Length of your Rectangle is =" + rects.SetLength(Convert.ToInt32(leng)));
							}
							else
							{
								Console.WriteLine("Invalid Input! Please enter an Integer \n");
								goto Console_UI;

							}
							break;
						case "3":
							Console.WriteLine("Width of your Rectangle is " + rects.GetWidth());
							break;
						case "4":
							Console.WriteLine(" Enter Width of your Rectangle \n");
							var widt = Console.ReadLine();
							if (rec.isNumber(widt))
							{
								Console.WriteLine("New Width of your Rectangle is = " + rects.SetWidth(Convert.ToInt32(widt)));
							}
							else
							{
								Console.WriteLine("Invalid input! an integer number is required\n");
								goto Console_UI;

							}
							break;
						case "5":
							Console.WriteLine("Perimeter of your Rectangle is " + rects.GetPerimeter());
							break;
						case "6":
							Console.WriteLine("Area of your Rectangle is " + rects.GetArea());
							break;
						case "7":
							
                            break;
						default:
							Console.WriteLine("Enter a valid menu selection");
							break;
							
					}
				}
				else
				{
					Console.WriteLine("Invalid Input! Please enter an Integer \n");
					goto Console_UI;
					//return;

				}
				Console.WriteLine("Do you want to continue Press (Y) to continue/(N) to Terminate");
				answer = Convert.ToChar(Console.ReadLine());
			} while (answer == 'y' || answer == 'Y');
		}
	}
}
