namespace Zadanie3
{
    public class GasContainer:Container, IHazardNotifier
    {
        protected int _pressure { get; set; }

        public GasContainer(int CargoMass, int Height, int ContainerMass, int Depth, int MaxCapacity, int pressure) : base(CargoMass, Height, ContainerMass, Depth, MaxCapacity)
        {
            _pressure = pressure;
        }

        public override void Empty()
        {
            this._cargoMass = this._cargoMass / 20;
        }

        public override void LoadCargo(int weight)
        {
            try
            {
                base.LoadCargo(weight);
            }
            catch (OverfillException e)
            {
                SendHazardNotification();
                throw e.GetBaseException();
            }
        }

        public void SendHazardNotification()
        {
            Console.WriteLine(getSerialNumber()+" is in danger!");
        }

        public override string getSerialNumber()
        {
            return base.getSerialNumber()+"G-"+counter;
        }
    }
}