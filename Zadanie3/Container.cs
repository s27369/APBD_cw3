namespace Zadanie3
{
	public abstract class Container
	{
		public int _cargoMass { get; set; }
		protected int _height { get; set; }
		protected int _containerMass { get; set; }
		protected int _depth { get; set; }
		protected int _maxCapacity { get; set; }
		protected string _serialNumber { get; set; }
		protected static int counter2 = 1;
		protected static int counter { get; } = counter2++;

		public Container(int CargoMass, int Height, int ContainerMass, int Depth, int MaxCapacity)
		{
			_cargoMass = CargoMass;
			_height = Height;
			_containerMass = ContainerMass;
			_depth = Depth;
			_maxCapacity = MaxCapacity;
			_serialNumber = getSerialNumber();
		}


		public virtual void Empty()
		{
			_cargoMass = 0;
		}

		public virtual void LoadCargo(int weight)
		{
			if (weight < 0)
			{
				throw new IncorrectCargoMass("Cargo mass can't be " + weight);
			}
			if (this._cargoMass + weight > this._maxCapacity)
			{
				throw new OverfillException(
					"Capacity for cargo exceeded by " + (this._maxCapacity - this._cargoMass + weight));
			}
				
			this._cargoMass += weight;
		}

		public virtual string getSerialNumber()
		{
			return "KON-";
		}

		public int getTotalWeight()
		{
			return _cargoMass + _containerMass;
		}

		public override string ToString()
		{
			return "Container "+_serialNumber+": cargo mass="+_cargoMass+"";
		}
	}
}