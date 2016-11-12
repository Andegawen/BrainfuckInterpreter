using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter
{
	public class Pointer
	{
		public Pointer(Memory memory)
		{
			this.memory = memory;
			PointedCell = 0;
		}

		public int PointedCell { get; set; }

		public byte PointedValue { get { return memory.GetValueAt(PointedCell); } }

		public string ToText()
		{
			return string.Format("P:{0}:{1}", PointedCell, PointedValue);
		}

		private Memory memory;
	}
}