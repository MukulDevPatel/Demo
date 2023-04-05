using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarBuckStore
    {
        public readonly IMakeACoffee coffee;
        public StarBuckStore(IMakeACoffee coffee)
        {
            this.coffee = coffee;
        }
        public string OrderACoffee(int sugarPerSpoon, int coffeePack)
        {
            if (coffee.CheckIngredientAvailability())
            {
                return coffee.CoffeeMaking(sugarPerSpoon, coffeePack);
            }
            else
            {
                return "Sorry! coffee is not available";
            }
        }
    }
}
