using System;

namespace ChainOfResponsibility
{
	class RemoteLogger : AbstractLogger
	{

		public RemoteLogger(int level)
		{
			this.level = level;
		}
		protected override void Write(string message)
		{
			Console.WriteLine("RemoteLogger::"+message);
		}
	}
}
