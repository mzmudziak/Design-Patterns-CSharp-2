using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	class RedCircleDrawer : IDrawer
	{
		public void draw(int r, int x, int y)
		{
			Console.WriteLine("Circle: RED at x: " + x + ", y: " + y + " with radius " + r);
		}
	}
}