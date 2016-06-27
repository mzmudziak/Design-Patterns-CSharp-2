namespace Proxy
{
	class ProxyImage : Image
	{
		private string fileame;
		private RealImage realImage;

		public ProxyImage(string filename)
		{
			this.fileame = filename;
		}

		public void Display()
		{
			if (realImage == null)
			{
				realImage = new RealImage(fileame);
			}
			realImage.Display();
		}
	}
}