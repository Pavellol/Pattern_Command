// Создаем объекты повара, кухни и официанта
using Command_restaurant.Pattern.Commands;
using Command_restaurant.Pattern;

//Определили шеф-повара
Chef chef = new Chef();
//Определили кухню и связали с шефом
Kitchen kitchen = new Kitchen(chef);
//Определили официанта и связали с кухней
BusBoy busBoy = new BusBoy(kitchen);
//Приветсвие официанта
busBoy.Hello();
//Узнать имя клиента
busBoy.WhatYourName();
//Определили клиента
Client client = new Client(Console.ReadLine());
//Клиент сделал заказ официанту
client.PlaceOrder(busBoy, "Паста");