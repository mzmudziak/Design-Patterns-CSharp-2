namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle redCircle = new Circle(new RedCircleDrawer(), 30, 5, 4);
			Circle blueCircle = new Circle(new BlueCircleDrawer(), 15, 15, 40);
			redCircle.Draw();
			blueCircle.Draw();
		}
	}
}