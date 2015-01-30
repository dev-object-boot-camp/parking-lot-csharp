using System;

namespace ParkingLot
{
	// Understands the reason for not being able to park
	public class CannotParkException : ApplicationException
	{
		public CannotParkException(string reason)
			: base(reason)
		{
		}
	}
}
