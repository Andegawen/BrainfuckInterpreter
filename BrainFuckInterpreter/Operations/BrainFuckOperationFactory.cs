using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class BrainFuckOperationFactory
	{
		public static IBrainFuckOperation[] GetAllOperations()
		{
			return new IBrainFuckOperation[]
			{
				new IncrementPointer(),
				new DecrementPointer(),
				new IncrementIndicatedCellValue(),
				new DecrementIndicatedCellValue(),
				new GetByteValueToIndicatedCell(),
				new PrintIndicatedCellValue(),
				new Loop()
			};
		}
	}
}