namespace Zadanie3;

class Program
{
    static void Main(string[] args)
    {
        Ship ship1 = new Ship(10, 15, 5);
        Ship ship2 = new Ship(30, 12, 4);
        Container liquidContainer1 = new LiquidContainer(500, 10, 100, 10, 1000, false);
        Container gasContainer1 = new GasContainer(500, 10, 100, 10, 1000, 5);
        Container gasContainer2 = new GasContainer(950, 10, 100, 10, 1000, 9);
        Container coolingContainer1 = new CoolingContainer(100,10,100,10,500,"Chocolate");
        
        /*
        List<Container> ContainerList = new List<Container>();
        ContainerList.Add(new LiquidContainer(500, 10, 100, 10, 1000, true));
        ContainerList.Add(new LiquidContainer(600, 10, 100, 10, 1000, true));
        ContainerList.Add(new LiquidContainer(950, 10, 100, 10, 1000, false));
        ContainerList.Add(new GasContainer(100, 10, 100, 10, 1000, 1));
        ContainerList.Add(new CoolingContainer(200,10,100,10,500,"Ice Cream"));
        ContainerList.Add(new CoolingContainer(400,10,100,10,500,"Fish"));
        */
        ship1.LoadContainer(liquidContainer1);
        ship1.LoadContainer(gasContainer1);
        //ship1.LoadContainer(ContainerList);
        
        ship2.LoadContainer(gasContainer2);
        ship2.LoadContainer(coolingContainer1);
        
        Console.WriteLine(ship1);
        Console.WriteLine(ship2);
    }
}