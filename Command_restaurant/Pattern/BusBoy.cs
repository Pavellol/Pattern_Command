using Command_restaurant.Pattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_restaurant.Pattern
{
    // Инициатор — Официант
    public class BusBoy
    {
        private Kitchen kitchen;
        public BusBoy(Kitchen kitchen)
        {
              this.kitchen = kitchen;
        }
        public void Hello()
        {
            Console.WriteLine("Добро пожаловать в ресторан трех кухонь! Выберите свой заказ:");
        }

        public void WhatYourName()
        {
            Console.WriteLine("Пожалуйста, напишите ваше имя, дорогой гость:");
        }

        public void TakeOrder(string dish)
        {
            var order = new OrderDishCommand(kitchen, dish);
            order.Execute();
        }
    }
}
