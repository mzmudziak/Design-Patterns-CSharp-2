using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	class Memento
	{
		private string _state;

		public Memento(string state)
		{
			this._state = state;
		}

		public string getState()
		{
			return _state;
		}
	}
}
