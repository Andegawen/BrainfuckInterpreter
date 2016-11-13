using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFuckInterpreter
{
	public static class ByteProvider
	{
		public static byte GetByte()
		{
			Console.Write("\tuser input byte:> ");
			var line = Console.ReadLine();
			return GetByte(line);
		}

		private static byte GetByte(string line)
		{
			byte b;
			byte.TryParse(line, out b);
			return b;
		}
	}
}