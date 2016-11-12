using BrainFuckInterpreter.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter
{
	class Program
	{
		static void Main(string[] args)
		{
			var operations = BrainFuckOperationFactory.GetAllOperations();
			int i = 0;
			while(Console.ReadLine()!="quit")
			{
				var left = Console.CursorLeft;
				var top = Console.CursorTop;
				i++;
				Console.SetCursorPosition(10, 0);
				Console.CursorTop = Console.CursorTop>0 ? Console.CursorTop-1 : 0;
				Console.WriteLine(string.Format("\b\b\rdsadasd {0}", i));
				Console.SetCursorPosition(left, top);
			}
		}
	}
}
