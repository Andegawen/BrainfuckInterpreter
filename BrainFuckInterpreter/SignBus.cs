using System;

namespace BrainFuckInterpreter
{
	public class SignBus
	{
		public event Action<char> SignArrive;

		public void Send(char sign)
		{
			var signArrive = SignArrive;
			if (signArrive != null)
				signArrive(sign);
		}

		public void RegisterOperation(IBrainFuckOperation operation)
		{
			SignArrive += operation.HandleSign;
		}
	}
}
