using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	class FlyweightShapeFactory
	{
		private static Dictionary<string, Shape> shapeRepository = new Dictionary<string, Shape>();

		public static Shape GetCircle(string color)
		{
			Shape circle;
			shapeRepository.TryGetValue(color, out circle);

		
			if (circle == null)
			{
				circle = new Circle(color);
				shapeRepository.Add(color, circle);
				Console.WriteLine("Created " + circle + " with color " + color);
			}

			return circle;
		}
	}
}