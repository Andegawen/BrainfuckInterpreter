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
			return string.Format("P:{0}:{1}", PointedCell, PointedValue);
		}

		internal void IncrementAddress()
		{
			PointedCell++;
		}

		internal void DecrementAddress()
		{
			PointedCell--;
		}

		internal int PointedCell { get; set; }
		internal byte PointedValue { get { return memory.GetValueAt(PointedCell); } }

		internal void IncrementValue()
		{
			memory.IncrementAt(PointedCell);
		}

		internal void DecrementValue()
		{
			memory.DecrementAt(PointedCell);
		}

		private Memory memory;
	}
}