using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_restaurant.Pattern
{
    // Получатель команды — Повар
    public class Chef
    {
        public void Cook(string dish)
        {
            Console.WriteLine($"Шеф готовит: {dish}");
        }       
    }
}