namespace BrainFuckInterpreter.Operations
{
	class GetByteValueToIndicatedCellOperation : IBrainFuckOperation
	{
		public GetByteValueToIndicatedCellOperation(Pointer pointer)
		{
			this.pointer = pointer;
		}

		public string HandleSign(char sign)
		{
			if(sign==',')
			{
				pointer.SetByteValue(ByteProvider.GetByte());
			}
			return string.Empty;
		}

		private Pointer pointer;
	}
}
