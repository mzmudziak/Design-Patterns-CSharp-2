using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Computer : IComputerPart
	{
		private IComputerPart[] parts;

		public Computer()
		{
			parts = new IComputerPart[] {new Monitor(), new Mouse(), new Keyboard(),};
		}

		public void Accept(IComputerPartVisitor computerPartVisitor)
		{
			for (int i = 0; i < parts.Length; i++)
			{
				parts[i].Accept(computerPartVisitor);
			}
			computerPartVisitor.visit(this);
		}
	}
}