using System;

namespace Bridge
{
	internal class RedCircleDrawer : IDrawer
	{
		public void draw(int r, int x, int y)
		{
			Console.WriteLine("Circle: RED at x: " + x + ", y: " + y + " with radius " + r);
		}
	}
}