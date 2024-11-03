using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_restaurant.Pattern
{
    // Интерфейс кухни, распределяющей заказы
    public class Kitchen
    {
        private Chef chef;

        public Kitchen(Chef chef)
        {
            this.chef = chef;
        }

        public void PrepareDish(string dish)
        {
            chef.Cook(dish);
        }       
    }
}
