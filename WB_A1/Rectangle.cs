using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WB_A1
{

	public class Rectangle
	{
		int length, width;

		// default constructor
		public Rectangle()
		{
			this.length = 1;
			this.width = 1;
		}

		// parameterized constructor to set default values
		public Rectangle(int a, int b)
		{
			this.length = a;
			this.width = b;
		}

		// get length of rectangle
		public int GetLength()
		{
			return this.length;
		}

		// set length of rectangle
		public int SetLength(int leng)
		{
			this.length = leng;
			return this.length;
		}

		// get width of rectangle 
		public int GetWidth()
		{
			return this.width;
		}

		// set rectangle width 
		public int SetWidth(int widt)
		{
			this.width = widt;
			return this.width;
		}

		// get perimeter 
		public int GetPerimeter()
		{
			return 2 * (this.length + this.width);
		}

		// get Area rectangle 
		public int GetArea()
		{
			return this.length * this.width;
		}

		public bool isNumber(string s)
		{
			for (int i = 0; i < s.Length; i++)
				if (char.IsDigit(s[i]) == false)
					return false;

			return true;

		}
	}
}
