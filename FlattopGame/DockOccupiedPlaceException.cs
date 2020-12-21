using System;
using System.Runtime.Serialization;

namespace FlattopGame
{
	class DockOccupiedPlaceException : Exception
	{
		public DockOccupiedPlaceException() : base("Занятое место")
		{ }
	}
}