using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class ComputerPartsVisitorUser : IComputerPartVisitor
	{
		public void visit(Keyboard keyboard)
		{
			Console.WriteLine("Use::keyboard");
		}

		public void visit(Monitor keyboard)
		{
Console.WriteLine("Use::monitor");
		}

		public void visit(Mouse keyboard)
		{
			Console.WriteLine("Use::keyboard");
		}

		public void visit(Computer keyboard)
		{
			Console.WriteLine("Use::computer");
		}
	}
}
