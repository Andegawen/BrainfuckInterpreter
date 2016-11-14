using System;

namespace BrainFuckInterpreter.Operations
{
	class PrintAsciiValueOperation : IBrainFuckOperation
	{
		public PrintAsciiValueOperation(Pointer pointer)
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
			Console.WriteLine((char)pointer.PointedValue);
		}

		private Pointer pointer;
	}
}