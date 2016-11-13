using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class PrintIndicatedCellValueOperation : IBrainFuckOperation
	{
		public PrintIndicatedCellValueOperation(Pointer pointer)
		{
			this.pointer = pointer;
		}
		public string HandleSign(char sign)
		{
			if (sign == '.')
				PrintIndicatedCellValue();
			return string.Empty;
		}

		private void PrintIndicatedCellValue()
		{
			Console.WriteLine(pointer.PointedValue);
		}

		private Pointer pointer;
	}
}