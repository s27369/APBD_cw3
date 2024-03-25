namespace Zadanie3
{

    public class Ship
    {
        private Dictionary<string, Container> _containers = new Dictionary<string, Container>();
        private int _maxSpeed;
        private int _maxContainerAmount;
        private int _containerAmount = 0;
        private int _maxCargoWeight;
        private int _cargoWeight = 0;

        public Ship(int maxSpeed, int maxContainerAmount, int maxCargoWeight)
        {
            _maxSpeed = maxSpeed;
            _maxContainerAmount = maxContainerAmount;
            _maxCargoWeight = maxCargoWeight;
        }

        public bool LoadContainer(Container c)
        {
            if ((_containerAmount >= _maxContainerAmount) || (_cargoWeight + c.getTotalWeight() > _maxCargoWeight))
            {
                Console.WriteLine("Can't load container");
                return false;
            }
            _containerAmount += 1;
            _cargoWeight += c.getTotalWeight();
            _containers.Add(c.getSerialNumber(), c);
            return true;
        }

        public bool LoadContainer(List<Container> containerList)
        {
            foreach (Container c in containerList)
            {
                if (!LoadContainer(c)) return false;
            }
            return true;
        }

        public Container findContainer(string serialNumber)
        {
                Container c;
                try
                {
                    c = _containers[serialNumber];
                }
                catch (Exception e)
                {
                    throw new ContainerNotFound("Could not find container: "+serialNumber);
                }
                return c;
        }
        public bool RemoveContainer(string serialNumber)
        {
            Container c;
            try
            {
                c = findContainer(serialNumber);
            }
            catch (ContainerNotFound)
            {
                return false;
            }
            _cargoWeight -= c.getTotalWeight();
            _containerAmount -= 1;
            _containers.Remove(serialNumber);
            return true;
        }

        public bool UnloadContainer(string serialNumber)
        {
            foreach (var pair in _containers)
            {
                if (pair.Key == serialNumber)
                {
                    pair.Value.Empty();
                    return true;
                }
            }
            return false;
        }

        public bool ReplaceContainer(string serialNumber, Container c)
        {
            if (RemoveContainer(serialNumber) && LoadContainer(c)) return true;
            return false;
        }

        public bool MoveContainer(string serialNumber, Ship ship)
        {
            Container c;
            try
            {
                c = findContainer(serialNumber);
            }
            catch (ContainerNotFound e)
            {
                Console.WriteLine("Can't find container "+serialNumber);
                return false;
            }

            RemoveContainer(c.getSerialNumber());
            return ship.LoadContainer(c);
        }
    }
}