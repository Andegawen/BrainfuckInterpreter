namespace BrainFuckInterpreter.Operations
{
	class GetByteValueToIndicatedCellOperation : IBrainFuckOperation
	{
		public GetByteValueToIndicatedCellOperation(Pointer pointer)
		{
			this.pointer = pointer;
		}

		public void HandleSign(char sign)
		{
			if(sign==',' || shouldReadByte)
			{
				if (shouldReadByte)
				{
					var bytes = System.Text.Encoding.Default.GetBytes(new char[] { sign });
					pointer.SetValueAt(bytes[0]);
					shouldReadByte = false;
				}
				if (sign == ',')
				{
					shouldReadByte = true;
				}
			}
		}

		private char[] byteArray = new char[4];
		private bool shouldReadByte = false;
		private Pointer pointer;
	}
}
