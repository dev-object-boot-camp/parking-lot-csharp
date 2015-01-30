using System.Collections;

namespace ParkingLot
{
	// Understands a collection of cars
	public class ParkingLot
	{
		private readonly int capacity;
		private int numberOfCars = 0;
		private IList cars; 

		public ParkingLot(int capacity)
		{
			this.capacity = capacity;
			cars = new ArrayList(capacity);
		}

		public object Park(object car)
		{
			if (cars.Count == capacity) 
				throw new CannotParkException("Cannot park " + car + " into " + this + "because the ParkingLot is full");
			cars.Add(car);
			return car;
		}

		public object Unpark(object ticket)
		{
			if (!cars.Contains(ticket))
				throw new CannotUnparkException("The " + ticket + "is not parked in " + this);
			cars.Remove(ticket);
			return ticket;
		}
	}
}
