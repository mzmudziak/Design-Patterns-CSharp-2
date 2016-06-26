namespace ChainOfResponsibility
{
	public abstract class AbstractLogger
	{
		public static int CONSOLE = 1;
		public static int REMOTE = 2;
		public static int ERROR = 3;
		protected int level;
		protected AbstractLogger NextLogger;

		public void setNextLogger(AbstractLogger abstractLogger)
		{
			this.NextLogger = abstractLogger;
		}

		public void Log(int level, string message)
		{
			if (this.level == level)
			{
				Write(message);
			}
			else
			{
				NextLogger.Log(level, message);
			}
		}

		protected abstract void Write(string message);
	}
}