namespace cw3;

public abstract class Container
{
	private int CargoMass { get; set;}
	int Height {get; set;}
	int ContainerMass {get; set;}
	int Depth {get; set;}
	int MaxCapacity {get; set;}
	string SerialNumber {get; set;}
	private static int counter = 1;

	public Container(int CargoMass, int Height, int ContainerMass, int Depth, int MaxCapacity)
	{
		CargoMass = CargoMass;
		Height = Height;
		ContainerMass = ContainerMass;
		Depth = Depth;
		MaxCapacity = MaxCapacity;
		SerialNumber = getSerialNumber();
	}

	
	public virtual void Empty()
	{
		CargoMass=0;	
	}

	public virtual void LoadCargo(int weight)
	{
		if (weight < 0) 
			throw IncorrectCargoMass("Cargo mass can't be " + weight);
		if (this.CargoMass + weight > this.MaxCapacity)
			throw OverfillException("Capacity for cargo exceeded by " + (this.MaxCapacity - this.CargoMass + weight));
		this.CargoMass += weight;
	}

	public virtual string getSerialNumber();
}