using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	class BlueCircleDrawer : IDrawer
	{
		public void draw(int r, int x, int y)
		{
			Console.WriteLine("Circle: BLUE at x: " + x + ", y: " + y + " with radius " + r);
		}
	}
}