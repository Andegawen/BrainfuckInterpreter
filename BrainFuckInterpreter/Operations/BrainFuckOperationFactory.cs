using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter.Operations
{
	class BrainFuckOperationFactory
	{
		public static IBrainFuckOperation[] GetAllOperations(Pointer pointer, SignBus signBus)
		{
			return new IBrainFuckOperation[]
			{
				new IncrementPointerOperation(pointer),
				new DecrementPointerOperation(pointer),
				new IncrementIndicatedCellValueOperation(pointer),
				new DecrementIndicatedCellValueOperation(pointer),
				new GetByteValueToIndicatedCellOperation(pointer),
				new PrintAsciiValueOperation(pointer),
				new LoopCreatorOperation(pointer, signBus)
			};
		}
	}
}