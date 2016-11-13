using BrainFuckInterpreter.Operations;
using System;
using System.Linq;

namespace BrainFuckInterpreter
{
	class Program
	{
		static void Main(string[] args)
		{
			string readLine;
			var bus = new SignBus();
			var pointer = new Pointer(new Memory());
			var operations = BrainFuckOperationFactory.GetAllOperations(pointer);
			foreach(var operation in operations)
			{
				bus.RegisterOperation(operation);
			}
			Console.SetCursorPosition(0, 1);
			string notEndedOperationSymbol = string.Empty;
			do
			{
				Console.Write("{0}$", bus.ConsoleStartedPhrase);
				ShowPointer(pointer);
				readLine = Console.ReadLine();
				foreach (var sign in readLine)
				{
					bus.Send(sign);
				}
			}
			while (!quitCommands.Any(q=> readLine == q));
		}

		private static void ShowPointer(Pointer pointer)
		{
			var left = Console.CursorLeft;
			var top = Console.CursorTop;
			Console.SetCursorPosition(0, 0);
			Console.WriteLine(pointer.ToText());
			Console.SetCursorPosition(left, top);
		}

		private static string[] quitCommands = new[] { "quit", "exit" };
	}
}