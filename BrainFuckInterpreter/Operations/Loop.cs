using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class LoopCreator : IBrainFuckOperation
	{
		public void HandleSign(char sign)
		{
			throw new NotImplementedException();
		}
	}

	class Loop
	{
		IList<IBrainFuckOperation> operations;
	}
}
