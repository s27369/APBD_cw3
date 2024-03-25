namespace Zadanie3
{
    public class LiquidContainer : Container, IHazardNotifier

    {
        private bool Dangerous;
        public LiquidContainer(int CargoMass, int Height, int ContainerMass, int Depth, int MaxCapacity, bool dangerous) : base(CargoMass, Height, ContainerMass, Depth, MaxCapacity)
        {
            Dangerous = dangerous;
        }

        public override string getSerialNumber()
        {
            return base.getSerialNumber()+"C-"+counter;
        }

        public void SendHazardNotification()
        {
            Console.WriteLine(getSerialNumber()+" is in danger!");
        }

        public override void LoadCargo(int weight)
        {
            if (
                (Dangerous && (_cargoMass + weight > _maxCapacity / 2))
                ||
                (_cargoMass + weight > _maxCapacity*0.9)
                )
            {
                SendHazardNotification();
            }
            base.LoadCargo(weight);
        }
    }
    
}

