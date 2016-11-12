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

		public void HandleSign(char sign)
		{
			if (sign == '>')
				IncrementPointer();
		}

		private void IncrementPointer()
		{
			pointer.IncrementAddress();
		}

		private Pointer pointer;
	}
}
