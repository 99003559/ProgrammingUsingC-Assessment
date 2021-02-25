using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        public GourmetCoffeeShop(int v1, string v2, Dictionary<int, double> coffeePriceDict)
        {
            V1 = v1;
            V2 = v2;
            CoffeePriceDict = coffeePriceDict;
        }

        public int V1 { get; }
        public string V2 { get; }
        public Dictionary<int, double> CoffeePriceDict { get; }
        public int ItemName { get; set; }

        public override double PayPerPiece(int quantity)
        {
            throw new NotImplementedException();
        }

        public override double PayPerWeight(int weight)
        {
            throw new NotImplementedException();
        }

        public double TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }
    }
}
