using System;

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
			if(sign==',' || shouldReadByte)
			{
				if(!HasByteValueCreated(sign))
					return string.Format("creating byte value {0}/3", byteValuePointer);
			}
			return string.Empty;
		}

		private bool HasByteValueCreated(char sign)
		{
			if (shouldReadByte)
			{
				if (char.IsNumber(sign))
				{
					byteArray[byteValuePointer] = sign;
					byteValuePointer++;
				}
				else
				{
					pointer.SetValueAt(GenerateByte());
					shouldReadByte = false;
					return true;
				}
				if (byteValuePointer == 3)
				{
					pointer.SetValueAt(GenerateByte());
					shouldReadByte = false;
					return true;
				}
			}
			if (sign == ',')
			{
				shouldReadByte = true;
				byteValuePointer = 0;
			}
			return false;
		}

		private byte GenerateByte()
		{
			var stringRepresentional = new string(byteArray, 0, byteValuePointer);
			return BitConverter.GetBytes(int.Parse(stringRepresentional))[0];
		}

		private int byteValuePointer = 0;
		private char[] byteArray = new char[3];
		private bool shouldReadByte = false;
		private Pointer pointer;
	}
}
