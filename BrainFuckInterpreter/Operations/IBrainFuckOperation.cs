using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter
{
	public interface IBrainFuckOperation
	{
		void HandleSign(char sign);
	}
}