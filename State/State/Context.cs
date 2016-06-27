using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	class Context
	{
		private State state;

		public void setState(State state)
		{
			this.state = state;
		}

		public State getState()
		{
			return state;
		}

		public Context()
		{
			state = null;
		}
	}
}