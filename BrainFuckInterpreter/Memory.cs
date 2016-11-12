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

		private readonly Dictionary<int, byte> map = new Dictionary<int, byte>();
	}
}
