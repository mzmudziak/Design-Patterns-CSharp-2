using System;

namespace Mediator
{
	class ChatRoom
	{
		public static void SendMessage(User user, string message)
		{
			Console.WriteLine(DateTime.Now + "::" + user.Name + " - " + message);
		}
	}
}