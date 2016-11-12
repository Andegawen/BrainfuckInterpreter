using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class DecrementPointerOperation : IBrainFuckOperation
	{
		public DecrementPointerOperation(Pointer pointer)
		{
			this.pointer = pointer;
		}
		public void HandleSign(char sign)
		{
			if (sign == '<')
				DecrementPointer();
		}

		private void DecrementPointer()
		{
			pointer.DecrementAddress();
		}

		private Pointer pointer;
	}
}
