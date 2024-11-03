using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_restaurant.Pattern.Commands
{
    // Команда для выполнения заказа
    class OrderDishCommand : ICommand
    {
        Kitchen kitchen;
        private string dish;

        public OrderDishCommand(Kitchen kitchen, string dish)
        {
            this.kitchen = kitchen;
            this.dish = dish;
        }

        public void Execute()
        {
            kitchen.PrepareDish(dish);
        }

        public void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
