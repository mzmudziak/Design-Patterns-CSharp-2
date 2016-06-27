using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
IComputerPart computer = new Computer();
computer.Accept(new ComputerPartsVisitorDisplay());
computer.Accept(new ComputerPartsVisitorUser());
		}
	}
}
