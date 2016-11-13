using System;

namespace BrainFuckInterpreter
{
	public class Pointer
	{
		public Pointer(Memory memory)
		{
			this.memory = memory;
			PointedCell = 0;
		}

		public string ToText()
		{
			return string.Format("P:{0,10}:{1,3}", PointedCell, PointedValue);
		}

		internal void IncrementAddress()
		{
			PointedCell++;
		}

		internal void DecrementAddress()
		{
			PointedCell--;
		}

		internal byte PointedValue { get { return memory.GetValueAt(PointedCell); } }

		internal void SetValueAt(byte newValue)
		{
			memory.SetValueAt(newValue, PointedCell);
		}

		internal void IncrementValue()
		{
			memory.IncrementAt(PointedCell);
		}

		internal void DecrementValue()
		{
			memory.DecrementAt(PointedCell);
		}

		private int PointedCell { get; set; }
		private Memory memory;
	}
}