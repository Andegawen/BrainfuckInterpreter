using BrainFuckInterpreter.Operations;
using System;

namespace BrainFuckInterpreter
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			string readLine;
			var bus = new SignBus();
			var operations = BrainFuckOperationFactory.GetAllOperations();
			foreach(var operation in operations)
			{
				bus.RegisterOperation(operation);
			}
			var pointer = new Pointer(new Memory());
			Console.SetCursorPosition(0, 1);
			do
			{
				Console.Write("$");
				ShowPointer(pointer);
				readLine = Console.ReadLine();
				foreach (var sign in readLine)
				{
					bus.Send(sign);
				}
			}
			while (readLine != "quit");
		}

		private static void ShowPointer(Pointer pointer)
		{
			var left = Console.CursorLeft;
			var top = Console.CursorTop;
			Console.SetCursorPosition(0, 0);
			Console.WriteLine(pointer.ToText());
			Console.SetCursorPosition(left, top);
		}
	}
}
