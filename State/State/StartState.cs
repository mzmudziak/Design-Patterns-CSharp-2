using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	class StartState : State
	{
		public void Action(Context context)
		{
			Console.WriteLine("Player is in START state");
			context.setState(this);
		}

		public override string ToString()
		{
			return "state::START";
		}
	}
}