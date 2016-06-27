using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	class RealImage : Image
	{
		private string filename;

		public RealImage(string filename)
		{
			this.filename = filename;
			loadImageFromDisk();
		}

		private void loadImageFromDisk()
		{
			Console.WriteLine("Loading from disk and it takes soo much time!");
		}

		public void Display()
		{
			Console.WriteLine("Displaying image from " + filename);
		}
	}
}
