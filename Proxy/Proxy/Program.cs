namespace Proxy
{
	class Program
	{
		static void Main(string[] args)
		{
			ProxyImage proxy = new ProxyImage("/etc/img.png");
			proxy.Display();
			proxy.Display();
		}
	}
}