using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	class Program
	{
	static	Random random = new Random();
		private static string[] colors =
		{
			"red",
			"blue",
			"green",
			"white",
			"black"
		};

		static void Main(string[] args)
		{
			for (int i = 0; i < 20; i++)
			{
				Circle circle = (Circle) FlyweightShapeFactory.GetCircle(getRandomColor());
				circle.setX(getRandomCoordinate());
				circle.setY(getRandomCoordinate());
				circle.setRadius(30);
				circle.Draw();
			}

		}

		private static string getRandomColor()
		{
			
			return colors[random.Next(colors.Length)];
		}

		private static int getRandomCoordinate()
		{
			return random.Next(100);
		}

	}
}