using Zadanie3.Containers;
using Zadanie3.Exceptions;
using Zadanie3.Ships;
namespace Zadanie3
{

    class Program
    {
        static void Main(string[] args)
        {
            Ship ship1 = new Ship(10, 15, 5);
            Ship ship2 = new Ship(30, 12, 4);
            Container liquidContainer1, liquidContainer3;
            try
            {
                liquidContainer1 = new LiquidContainer(1500, 1000, 100, 1200, 1000, false);
            }
            catch (OverfillException e)
            {
                Console.WriteLine(e.Message);
                liquidContainer1 = new LiquidContainer(1000, 100, 1200, 1000);
                liquidContainer1.LoadCargo(300);
            }
            try
            {
                liquidContainer3 = new LiquidContainer(-100, 1000, 100, 1200, 1000, false);
            }
            catch (IncorrectCargoMass e)
            {
                Console.WriteLine(e.Message);
                liquidContainer3 = new LiquidContainer(1000, 100, 1200, 5000);
                liquidContainer3.LoadCargo(5000);
            }
            Container gasContainer1 = new GasContainer(400, 1500, 100, 1300, 1000, 5);
            
            Container gasContainer2 = new GasContainer(950, 1300, 100, 1100, 1000, 9);
            Container coolingContainer1 = new CoolingContainer(100, 500, 100, 200, 500, "Chocolate");

            
            List<Container> ContainerList = new List<Container>();
            ContainerList.Add(new LiquidContainer(500, 10, 100, 10, 1000, true));
            Console.WriteLine("teraz");
            ContainerList.Add(new LiquidContainer(600, 10, 100, 10, 1000, true));
            ContainerList.Add(new LiquidContainer(950, 10, 100, 10, 1000, false));
            ContainerList.Add(new GasContainer(100, 10, 100, 10, 1000, 1));
            ContainerList.Add(new CoolingContainer(200,10,100,10,500,"Ice Cream"));
            ContainerList.Add(new CoolingContainer(400,10,100,10,500,"Fish"));
            
            Console.WriteLine("\nloading ships:");
            
            ship1.LoadContainer(liquidContainer1);
            ship1.LoadContainer(gasContainer1);
            //ship1.LoadContainer(ContainerList);

            ship2.LoadContainer(gasContainer2);
            ship2.LoadContainer(coolingContainer1);

            Console.WriteLine(ship1);
            Console.WriteLine(ship2);
            
        }
    }
}