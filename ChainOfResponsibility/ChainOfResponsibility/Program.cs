namespace ChainOfResponsibility
{
	public class Program
	{
		private static AbstractLogger GetLoggerChain()
		{
			AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
			AbstractLogger remoteLogger = new RemoteLogger(AbstractLogger.REMOTE);
			AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.CONSOLE);

			errorLogger.setNextLogger(remoteLogger);
			remoteLogger.setNextLogger(consoleLogger);
			return errorLogger;
		}

		private static void Main(string[] args)
		{
			var loggerChain = GetLoggerChain();

			loggerChain.Log(AbstractLogger.REMOTE, "This is supposed to be sent to remote logger");
			loggerChain.Log(AbstractLogger.CONSOLE, "Log saved in console");
			loggerChain.Log(AbstractLogger.ERROR, "ERROR 404: NOT FOUND");
		}
	}
}