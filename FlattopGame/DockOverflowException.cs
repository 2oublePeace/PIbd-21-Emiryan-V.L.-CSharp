using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattopGame
{
	class DockOverflowException : Exception
	{
		public DockOverflowException() : base("На парковке нет свободных мест")
		{ }
	}
}
