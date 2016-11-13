using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class IncrementPointerOperation : IBrainFuckOperation
	{
		public IncrementPointerOperation(Pointer pointer)
		{
			this.pointer = pointer;
		}

		public string HandleSign(char sign)
		{
			if (sign == '>')
				IncrementPointer();
			return string.Empty;
		}

		private void IncrementPointer()
		{
			pointer.IncrementAddress();
		}

		private Pointer pointer;
	}
}
