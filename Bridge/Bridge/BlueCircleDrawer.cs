using System;

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