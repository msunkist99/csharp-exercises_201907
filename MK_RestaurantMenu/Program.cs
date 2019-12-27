using System;
using System.Collections.Generic;

namespace MK_RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuIdCount = 0;
            Menu menu = new Menu();
            List<MenuItem> menuItems = new List<MenuItem>();

            MenuItem menuItem = new MenuItem();
            menuItem.Category = "Main Course";
            menuItem.Description = "with cheese and fries";
            menuItem.Name = "Burger";
            menuItem.Price = 8.99;
            menuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.Category = "Appetizer";
            menuItem.Description = "with cheese, beans, and jalepeno peppers";
            menuItem.Name = "Nachos";
            menuItem.Price = 5.99;
            menuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.Category = "Dessert";
            menuItem.Description = "ultimate chocolate";
            menuItem.Name = "Cake";
            menuItem.Price = 4.99;
            menuItems.Add(menuItem);

            menu.MenuItems = menuItems;
            menu.NewMenu = true;
            menu.Id = menuIdCount + 1;

            Console.ReadLine();

        }
    }
}
