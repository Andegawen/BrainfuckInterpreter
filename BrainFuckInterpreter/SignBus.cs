using System;
using System.Collections.Generic;

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
	}
}
