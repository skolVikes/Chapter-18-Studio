using System;

namespace Chapter_18_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem pizza = new MenuItem();
            pizza.Price = 10;
            pizza.Description = "Pizza: Tastes good";
            pizza.Category = "Dinner";
            pizza.DateAdded = new DateTime(2021, 06, 28);

            Menu.MenuItems.Add(pizza); 
        }
    }
}
