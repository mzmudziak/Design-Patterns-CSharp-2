using System;

namespace ChainOfResponsibility
{
	class ErrorLogger : AbstractLogger
	{
		public ErrorLogger(int level)
		{
			this.level = level;
		}

		protected override void Write(string message)
		{
			Console.WriteLine("ErrorLogger::" + message);
		}
	}
}