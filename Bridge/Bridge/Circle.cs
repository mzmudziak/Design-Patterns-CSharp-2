using System;

namespace Bridge
{
	class Circle : AbstractShape
	{
		private int x;
		private int y;
		private int radius;

		public Circle(IDrawer iDrawer, int x, int y, int radius) : base(iDrawer)
		{
			this.x = x;
			this.y = y;
			this.radius = radius;
		}

		public override void Draw()
		{
			Drawer.draw(radius, x, y);
		}
	}
}