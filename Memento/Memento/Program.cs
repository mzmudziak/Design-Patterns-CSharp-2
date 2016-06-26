using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	class Program
	{
		static void Main(string[] args)
		{
			Originator originator = new Originator();
			MementoRepository mementoRepository = new MementoRepository();

			originator.setState("#1");
			originator.setState("#2");
			Console.WriteLine("Saving 1...");
			mementoRepository.Add(originator.saveMemento());
			originator.setState("#3");
			Console.WriteLine("Saving 2...");
			mementoRepository.Add(originator.saveMemento());

			originator.setState("#4");

			Console.WriteLine("State::" + originator.getState());

			Console.WriteLine("Restoring 1: ");
			originator.restoreStateFromMemento(mementoRepository.Get(0));
			Console.WriteLine("State::" + originator.getState());

			Console.WriteLine("Restoring 2: ");
			originator.restoreStateFromMemento(mementoRepository.Get(1));
			Console.WriteLine("State::" + originator.getState());
		}
	}
}