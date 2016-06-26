using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	abstract class AbstractShape
	{
		protected IDrawer Drawer;

		protected AbstractShape(IDrawer iDrawer)
		{
			this.Drawer = iDrawer;
		}

		public abstract void Draw();
	}
}