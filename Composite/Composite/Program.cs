using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{

			Employee CEO = new Employee("Mark Zuckerberg", "CEO", 501239432);
			Employee Director = new Employee("Michal Zmudziak", "Director of Marketing", 1000);
			Employee headSales = new Employee("Anthony Bourdai","Head Sales", 3032);

			Employee coolGuy1= new Employee("John Andy", "Marketing", 300);
			Employee coolGuy2 = new Employee("Enry Goey", "Marketing", 340);

			Employee coolGirl1 = new Employee("Patricia Queen","Sales", 4030);
			Employee coolGirl2 = new Employee("Silvia Angry", "Sales", 49153);

			CEO.addSubordinate(Director);
			CEO.addSubordinate(headSales);

			Director.addSubordinate(coolGuy1);
			Director.addSubordinate(coolGuy2);

			headSales.addSubordinate(coolGirl1);
			headSales.addSubordinate(coolGirl2);

			Console.WriteLine(CEO);
			foreach (Employee head in CEO.getSubordinates())
			{
				Console.WriteLine(head);
				foreach (Employee subordinate in head.getSubordinates())
				{
					Console.WriteLine(subordinate);
				}
				Console.WriteLine();
			}

		}
	}
}
