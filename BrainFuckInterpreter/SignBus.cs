using System;
using System.Collections.Generic;
using System.Linq;

namespace BrainFuckInterpreter
{
	public class SignBus
	{
		public event Func<char, string> SignArrive;

		public void Send(char sign)
		{
			RaiseSignArrive(sign);
		}

		public void RegisterOperation(IBrainFuckOperation operation)
		{
			SignArrive += operation.HandleSign;
			registeredOperations.Add(operation);
		}

		public void HandleJustOneOperation(IBrainFuckOperation operation)
		{
			SignArrive = null;
			SignArrive += operation.HandleSign;
		}

		public void RevertRegisteredOperations()
		{
			SignArrive = null;
			foreach (var operation in registeredOperations)
			{
				SignArrive += operation.HandleSign;
			}
		}

		internal void HandleAllRegisteredOperationExpect(IBrainFuckOperation operation)
		{
			SignArrive = null;
			var ops = registeredOperations.ToList();
			ops.Remove(operation);
			foreach (var op in ops)
			{
				SignArrive += op.HandleSign;
			}
		}

		public string ConsoleStartedPhrase { get; private set; }

		private void RaiseSignArrive(char sign)
		{
			var myList = new List<string>();
			if (SignArrive != null)
				foreach (Func<char, string> handler in SignArrive.GetInvocationList())
					myList.Add(handler(sign));

			ConsoleStartedPhrase = string.Concat(myList);
		}

		private IList<IBrainFuckOperation> registeredOperations = new List<IBrainFuckOperation>();
	}
}