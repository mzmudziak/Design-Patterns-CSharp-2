using System;

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
