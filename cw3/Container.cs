namespace cw3;

public abstract class Container
{
    int CargoMass {get;}; 
	int Height {get;}; 
	int ContainerMass {get;};
	int Depth {get;};
	int MaxCapacity {get;};
	string SerialNumber {get;};
	static int counter=1 {get;};

	
	
	public virtual void Empty()
	{
		this.mass=0;	
	}

	public virtual getSerialNumber();
	
}