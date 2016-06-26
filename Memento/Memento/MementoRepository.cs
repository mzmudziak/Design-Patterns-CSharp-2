using System.Collections.Generic;

namespace Memento
{
	class MementoRepository
	{
		private List<Memento> mementoes = new List<Memento>();

		public void Add(Memento memento)
		{
			mementoes.Add(memento);
		}

		public Memento Get(int index)
		{
			return mementoes[index];
		}
	}
}