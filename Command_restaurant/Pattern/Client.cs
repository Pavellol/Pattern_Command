using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_restaurant.Pattern
{
    public class Client
    {
        private string name;

        public Client(string name)
        {
            this.name = name;
        }
        public void PlaceOrder(BusBoy busBoy, string dish)
        {
            busBoy.TakeOrder(dish);
        }
    }
}
