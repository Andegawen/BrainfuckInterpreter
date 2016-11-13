using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class IncrementIndicatedCellValueOperation : IBrainFuckOperation
	{
		public IncrementIndicatedCellValueOperation(Pointer pointer)
		{
			this.pointer = pointer;
		}
		public string HandleSign(char sign)
		{
			if (sign == '+')
				IncrementIndicatedCellValue();
			return string.Empty;
		}

		private void IncrementIndicatedCellValue()
		{
			pointer.IncrementValue();
		}

		private Pointer pointer;
	}
}
