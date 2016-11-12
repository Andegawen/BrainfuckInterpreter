using System;
using System.Collections.Generic;

namespace BrainFuckInterpreter
{
	public class Memory
	{
		internal byte GetValueAt(int pointedCell)
		{
			byte b;
			map.TryGetValue(pointedCell, out b);
			return b;
		}

		internal void IncrementAt(int pointedCell)
		{
			var value = GetValueAt(pointedCell) + 1;
			map[pointedCell] = (byte)value;
		}

		internal void DecrementAt(int pointedCell)
		{
			var value = GetValueAt(pointedCell) - 1;
			map[pointedCell] = (byte)value;
		}

		internal void SetValueAt(byte newValue, int pointedCell)
		{
			map[pointedCell] = (byte)newValue;
		}

		private readonly Dictionary<int, byte> map = new Dictionary<int, byte>();
	}
}