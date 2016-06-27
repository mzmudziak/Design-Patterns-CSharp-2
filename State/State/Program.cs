using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	class Program
	{
		static void Main(string[] args)
		{
			Context context = new Context();

			StartState start = new StartState();
			StopState stop = new StopState();

			start.Action(context);
			Console.WriteLine(context.getState());

			stop.Action(context);
			Console.WriteLine(context.getState());
		}
	}
}