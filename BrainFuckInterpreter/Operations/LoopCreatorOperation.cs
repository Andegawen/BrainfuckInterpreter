using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class LoopCreatorOperation : IBrainFuckOperation
	{
		public string HandleSign(char sign)
		{
			if (sign == '[')
				return "creating loop";
			return string.Empty;
		}
	}

	class Loop
	{
		IList<IBrainFuckOperation> operations;
	}
}
