namespace Visitor
{
	public interface IComputerPartVisitor
	{
		void visit(Keyboard keyboard);
		void visit(Monitor keyboard);
		void visit(Mouse keyboard);
		void visit(Computer keyboard);
	}
}