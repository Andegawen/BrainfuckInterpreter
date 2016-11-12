using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class DecrementIndicatedCellValueOperation : IBrainFuckOperation
	{
		public DecrementIndicatedCellValueOperation(Pointer pointer)
		{
			this.pointer = pointer;
		}
		public void HandleSign(char sign)
		{
			if (sign == '-')
				DecrementIndicatedCellValue();
		}

		private void DecrementIndicatedCellValue()
		{
			pointer.DecrementValue();
		}

		private Pointer pointer;
	}
}
