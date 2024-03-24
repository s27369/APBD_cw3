namespace Zadanie3
{

    public class CoolingContainer
    {
        protected private double _temperature;
        private string _product { get; set; } = "";
        public string Procuct { get { return _product; } set { _product = value;} }
        private Dictionary<string, double> _prodTemp = new Dictionary<string, double>
        {
            { "Bananas", 13.3 }, { "Chocolate", 18 }, { "Fish", 2 }, { "Meat", -15 }, { "Ice Cream", -18 },
            { "Frozen pizza", -30 }, { "Cheese", 7.2 }, { "Sausages", 5 }, { "Butter", 20.5 }, { "Eggs", 19 }
        };

        public CoolingContainer(string product)
        {
            _product = product;
            _temperature = _prodTemp[_product];
        }
        
    }
}