using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	class Originator
	{
		private string state;


		public void setState(string state)
		{
			this.state = state;
Console.WriteLine(state);
		}

		public String getState()
		{
			return state;
		}

		public Memento saveMemento()
		{
			return new Memento(state);
		}

		public void restoreStateFromMemento(Memento memento)
		{
			state = memento.getState();
		}
	}
}