namespace Mediator
{
	class Program
	{
		static void Main(string[] args)
		{
			User michael = new User("Michael");
			User daniel = new User("Daniel");
michael.SendMessage("Hello daniel!");
daniel.SendMessage("Oh Hello Michael!!!!");
		}
	}
}