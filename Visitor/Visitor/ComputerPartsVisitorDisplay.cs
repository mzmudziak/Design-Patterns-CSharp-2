using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class ComputerPartsVisitorDisplay : IComputerPartVisitor
	{
		public void visit(Keyboard keyboard)
		{
			Console.WriteLine("Display::keyboard");
		}

		public void visit(Monitor keyboard)
		{
			Console.WriteLine("Display::monitor");
		}

		public void visit(Mouse keyboard)
		{
			Console.WriteLine("Display::keyboard");
		}

		public void visit(Computer keyboard)
		{
			Console.WriteLine("Display::computer");
		}
	}
}
