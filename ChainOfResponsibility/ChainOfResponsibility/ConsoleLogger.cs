using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	class ConsoleLogger : AbstractLogger
	{
		public ConsoleLogger(int level)
		{
			this.level = level;
		}

		protected override void Write(string message)
		{
			Console.WriteLine("ConsoleLogger::" + message);
		}
	}
}
