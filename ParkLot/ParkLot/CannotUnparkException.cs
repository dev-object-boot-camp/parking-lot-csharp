using System;

namespace ParkingLot
{
	// Understands why a car cannot be unparked.
	public class CannotUnparkException : ApplicationException
	{

		public CannotUnparkException(string reason)
			: base(reason)
		{
		}
	}
}
