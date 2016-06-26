namespace Bridge
{
	abstract class AbstractShape
	{
		protected IDrawer Drawer;

		protected AbstractShape(IDrawer iDrawer)
		{
			Drawer = iDrawer;
		}

		public abstract void Draw();
	}
}